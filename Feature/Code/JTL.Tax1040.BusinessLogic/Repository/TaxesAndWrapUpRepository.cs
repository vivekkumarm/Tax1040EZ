﻿/*
Copyright       : Copyright Jeevan Technologies
File Name       : TaxesAndWrapUpRepository.cs 
Description     : Bussiness Logic for Taxes And WrapUp  
Author          : Vivek
Created Date    : 28 Apr 2014

 * Modification History:
 * 27May2014 Sathish added GetTaxAndWrapupSummary method
 * 28May2014 Sathish created person detail if person detail not updated in tax and wrap up persist
 * 28May2014 Sathish added TaxableIncomeEligibilityCheck to check taxable income is eligible for 1040EZ
 * 06June2014 Bala Removed TaxableIncomeEligibilityCheck method and modified GetFederalTaxSummary method
 * 09Jun2014 Sathish Persisted tax object to updated eligibility rule addd for taxable income is more that $100,000
 * 03July2014 Thileep Added the business validation for four fields in taxesanwrapup
 * 04July2014 Thileep Changed  the business validation for bank acc number.
 * 12Aug2014 Added BusinessValidationFederalTaxSummary method and changed GetFederalTaxSummary method Regarding changes in Taxeswrapup Spec(V1.5)
 * 19Aug2014-Thileep changed and added code in PersistTaxesAndWrapUpData method  for Taxableincomecheck,Refundoptioncheck and (Income,Refund,Taxes all are Zeros check)  
 */
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.DataAccess;
using Newtonsoft.Json;
using System;
using System.Activities;
using System.Collections.Generic;
using Tax1040WorkFlow.WorkFlow.Activities;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities;
using System.Linq;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;
using System.Web;
using System.Runtime.CompilerServices;

namespace JTL.Tax1040.BusinessLogic
{
    public class TaxesAndWrapUpRepository : ITaxesAndWrapUpRepository
    {
        #region Local variable declaration
        ITaxReturnDataService taxReturnDataService;
        private readonly MessagesRepository messageRepository;
        IPersonalInfoRepository personalInfoRepository;
        bool hasEligibilityDiagnostics = false;
        DateTime DUE_DATE = new DateTime(2015, 4, 15);
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="W2Repository"/> class.
        /// </summary>
        public TaxesAndWrapUpRepository()
        {
            taxReturnDataService = new TaxReturnDataService();
            messageRepository = new MessagesRepository();
            personalInfoRepository = new PersonalInfoRepository();
        }
        #endregion

        #region Persist Method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taxReturnData"></param>
        /// <returns></returns>
        public Tuple<long, bool> PersistTaxesAndWrapUpData(long userId, TaxReturnData taxReturnData)
        {
            Tuple<long, bool> userData = null;
            try
            {
                JTL.Tax1040.BusinessObject.Tax1040 taxObject;

                //Retrieving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);


                //28May2014 Sathish Creat person if person detail not updated. Used in federal tax and wrap up work flow for line 10 calc.
                if (taxObject == null || taxObject.PersonalDetails == null || taxObject.PersonalDetails.PrimaryTaxPayer == null)
                {
                    if (taxObject == null)
                        taxObject = new BusinessObject.Tax1040()
                                            {
                                                PersonalDetails = new PersonalDetails()
                                                {
                                                    PrimaryTaxPayer = new PrimaryTaxPayer()
                                                    {
                                                        FilingStatus = FilingStatus.Single,
                                                        Person = new Person()
                                                    }
                                                }
                                            };

                    if (taxObject.PersonalDetails == null)
                    {
                        taxObject.PersonalDetails = new PersonalDetails()
                        {
                            PrimaryTaxPayer = new PrimaryTaxPayer()
                            {
                                FilingStatus = FilingStatus.Single,
                                Person = new Person()
                            }
                        };
                    }

                    if (taxObject.PersonalDetails.PrimaryTaxPayer == null)
                    {
                        taxObject.PersonalDetails.PrimaryTaxPayer = new PrimaryTaxPayer()
                        {
                            FilingStatus = FilingStatus.Single,
                            Person = new Person()
                        };
                    }

                    Tuple<long, bool> userDataId = personalInfoRepository.PersistPrimaryTaxPayer(taxObject.PersonalDetails.PrimaryTaxPayer, userId, taxReturnData.UserDataId, Constants.TOPIC_PERSONAL_FILINGSTATUS);

                    taxReturnData.UserDataId = userDataId.Item1;

                    //Retrieving TaxObject from database
                    //26Aug2014 Sathish Get Tax object after personal info persist to get the error message list
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);
                }



                //Converting Json to OtherIncome by DeSerializing
                TaxesAndPenalties taxesAndPenalties = JsonConvert.DeserializeObject<TaxesAndPenalties>(taxReturnData.TaxData);

                if (taxObject != null && taxesAndPenalties != null)
                {
                    taxObject.TaxesAndPenalties = new TaxesAndPenalties();
                    taxObject.TaxesAndPenalties = taxesAndPenalties;
                }

                if (taxObject.ErrorMessages == null)
                    taxObject.ErrorMessages = new List<ErrorMessage>();


                // Clear the Error messages exist for this topic.
                messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_TAX_AND_WRAPUP);


                //Workflow Validation Section
                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;

                //var errorMessage = messageRepository.GetErrorMessages();
                var errorMessage = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
                var errorMessages = new ErrorMessages(errorMessage);
                input.ErrorMessages = errorMessages;


                //BusinessFieldValidations(otherIncome, taxObject.ErrorMessages, errorMessages);
                if (taxObject.TaxesAndPenalties != null)
                {
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new TaxAndWrapUpEligibilityCheck(), input));
                    hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => em.Topic == Constants.TOPIC_TAX_AND_WRAPUP && em.ErrorCode.StartsWith(Constants.TOPIC_TAX_AND_WRAPUP + "_ER"));

                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_REQUIRED_REFUND_DETAIL);
                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_MISSING_INCOME);                    
                    dynamic federalSummaryInput = new Microsoft.Activities.Extensions.WorkflowArguments();
                    federalSummaryInput.Tax1040Object = taxObject;
                    federalSummaryInput.IsTaxableIncomeExceedCheck = true;
                    federalSummaryInput.IsRefundAvailableCheck = true;
                    federalSummaryInput.IsIncomeAndRefundAllZeros = true;
                    federalSummaryInput.ErrorMessages = errorMessages;
                    output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                             WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), federalSummaryInput));
                }

                BusinessValidation(taxObject.TaxesAndPenalties, taxObject.ErrorMessages, errorMessages);

                taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);


                userData = new Tuple<long, bool>(taxReturnData.UserDataId, hasEligibilityDiagnostics);

                //vincent, 2-sep-14, Persist Audit information
                string description = "Persist TaxesAndWrapUpData, ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userId, taxReturnData.UserDataId, description, this.GetType().Name, Constants.Tab_TAX_AND_WRAPUP, Constants.TOPIC_TAX_AND_WRAPUP);

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:TaxesAndWrapUpRepository,Method Name:PersistTaxesAndWrapUpData", ex);
            }
            return userData;
        }
        #endregion

        #region Get method

        public System.Tuple<TaxesAndPenalties, string, DateTime, IEnumerable<ErrorMessage>> GetTaxAndWrapup(UserDTO userDTO)
        {
            IEnumerable<ErrorMessage> taxAndWrapupErrorList = null;
            Tuple<TaxesAndPenalties, string, DateTime, IEnumerable<ErrorMessage>> taxAndPenalties = null;
            try
            {
                BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                //vivek 7-Aug-14 Added for the error message focus 
                if (taxObject.ErrorMessages != null)
                {
                    taxAndWrapupErrorList = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_TAX_AND_WRAPUP
                                                                                     && (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V)).ToList();
                }
                taxAndPenalties = new Tuple<TaxesAndPenalties, string, DateTime, IEnumerable<ErrorMessage>>(((taxObject != null && taxObject.TaxesAndPenalties != null)
                                                                                    ? taxObject.TaxesAndPenalties : null),
                                                                            Utilities.GetTaxPayerFirstNameOrNickName(taxObject),
                                                                           ((taxObject != null && taxObject.TaxesAndPenalties == null
                                                                           || taxObject.TaxesAndPenalties.FilingDate.HasValue == false) ?
                                                                                DateTime.Now : DateTime.MinValue), taxAndWrapupErrorList);
                //Vincent, 2-sep-14, Persist Audit information
                string description = "Get TaxesAndWrapUpData, ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.Tab_TAX_AND_WRAPUP, Constants.TOPIC_TAX_AND_WRAPUP);

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:TaxesAndWrapUpRepository,Method Name:GetTaxAndWrapup", ex);
            }
            return taxAndPenalties;
        }

        public Tuple<Tax1040EZPage1, List<ErrorMessage>, bool, string, long> GetFederalTaxSummary(UserDTO userDTO)
        {
            Tuple<Tax1040EZPage1, List<ErrorMessage>, bool, string, long> federalTaxSummary = null;

            try
            {
                BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;
                var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                            WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), input));
                var hasEligibilityDiagnostics = HasEligibilityTaxIncome(userDTO, taxObject);

                // 09Jun2014 Sathish Persisted tax object to updated eligibility rule addd for taxable income is more that $100,000
                userDTO.UserDataId = Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);


                //var errorMessage = messageRepository.GetErrorMessages();
                //var errorMessages = new ErrorMessages(errorMessage);

               // BusinessValidationFederalTaxSummary(taxObject != null ? taxObject : null, taxObject.ErrorMessages, errorMessages);

                //Praveen 17 July 2014 Error Message displayed based on Error Type(Properly Shuffled)
                federalTaxSummary = new Tuple<Tax1040EZPage1, List<ErrorMessage>, bool, string, long>(
                                  ((taxObject != null && taxObject.OutputForms != null && taxObject.OutputForms.Tax1040EZPage1 != null)
                                                   ? taxObject.OutputForms.Tax1040EZPage1 : null),
                            taxObject.ErrorMessages.FindAll(em => em.ErrorCode.StartsWith(Constants.TOPIC_TAX_AND_WRAPUP)).OrderBy(x => x.ErrorType).ToList(),
                          hasEligibilityDiagnostics,
                          Utilities.GetTaxPayerFirstNameOrNickName(taxObject),
                          userDTO.UserDataId);
                //userDTO.UserDataId = Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);

                //Vincent, 2-sep-14, Persist Audit information
                string description = "Get FederalTaxSummary, ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.Tab_TAX_AND_WRAPUP, Constants.TOPIC_TAX_AND_WRAPUP);

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:TaxesAndWrapUpRepository,Method Name:GetFederalTaxSummary", ex);
            }
            return federalTaxSummary;


        }

        //// 28May2014 Check Taxable income eligibility
        //public Tuple<string, bool> TaxableIncomeEligibilityCheck(UserDTO userDTO)
        //{
        //    Tuple<string, bool> taxableIncomeEligibility = null;
        //    try
        //    {
        //        BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

        //        if (taxObject != null)
        //        {
        //            dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
        //            input.Tax1040Object = taxObject;
        //            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
        //                                                        WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), input));

        //            hasEligibilityDiagnostics = HasEligibilityTaxIncome(userDTO, taxObject);
        //        }
        //        taxableIncomeEligibility = new Tuple<string, bool>(Utilities.GetTaxPayerFirstNameOrNickName(taxObject), hasEligibilityDiagnostics);
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionHandling.LogException(userDTO.UserId, "Class:TaxesAndWrapUpRepository,Method Name:TaxableIncomeEligibilityCheck", ex);
        //    }
        //    return taxableIncomeEligibility;
        //}

        #endregion

        #region Validation

        public void BusinessValidation(TaxesAndPenalties taxesAndPenalties, List<ErrorMessage> errorMessageList,
                                       ErrorMessages errorMessages)
        {
            if (taxesAndPenalties != null)
            {
                ErrorMessage errorMessage;


                if (taxesAndPenalties.HasFiledForm4868.HasValue && taxesAndPenalties.HasFiledForm4868.Value)
                {
                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                      Convert.ToString(taxesAndPenalties.FederalExtensionFiledDate),
                         Constants.TAX_AND_WRAP_UP_REQUIRED_EXTENSION_FILED_DATE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    if (taxesAndPenalties.FederalExtensionFiledDate.HasValue && taxesAndPenalties.FederalExtensionFiledDate.Value != null)
                    {
                        errorMessage =
                            BusinessValidationRepository.AssertDateIsLesser(taxesAndPenalties.FederalExtensionFiledDate.Value, DUE_DATE,
                                                                 Constants.TAX_AND_WRAP_UP_VALIDATION_EXTENSION_FILED_DATE, errorMessages);
                        if (errorMessage != null)
                        {
                            errorMessageList.Add(errorMessage);
                        }
                    }
                }

                if (taxesAndPenalties.HasPaidFederalExtensionWithForm4868.HasValue && taxesAndPenalties.HasPaidFederalExtensionWithForm4868.Value)
                {

                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                        Convert.ToString(taxesAndPenalties.FederalExtensionAmount),
                           Constants.TAX_AND_WRAP_UP_EXTENSTION_AMOUNT, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                        Convert.ToString(taxesAndPenalties.FederalExtensionAmountPaidDate),
                           Constants.TAX_AND_WRAP_UP_EXTENSION_DATE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    if (taxesAndPenalties.FederalExtensionAmountPaidDate.HasValue && taxesAndPenalties.FederalExtensionAmountPaidDate.Value != null)
                    {
                        errorMessage =
                            BusinessValidationRepository.AssertDateIsLesser(taxesAndPenalties.FederalExtensionAmountPaidDate.Value, DUE_DATE,
                                                                 Constants.TAX_AND_WRAP_UP_VALIDATION_EXTENSION_DATE, errorMessages);
                        if (errorMessage != null)
                        {
                            errorMessageList.Add(errorMessage);
                        }
                    }

                }

                if (taxesAndPenalties.IsFilingReturnAfterDueDate.HasValue && taxesAndPenalties.IsFilingReturnAfterDueDate.Value)
                {

                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                        Convert.ToString(taxesAndPenalties.FilingDate),
                           Constants.TAX_AND_WRAP_UP_FILING_DATE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);


                    if (taxesAndPenalties.FilingDate.HasValue && taxesAndPenalties.FilingDate.Value != null)
                    {
                        errorMessage =
                            BusinessValidationRepository.AssertDateIsGreater(taxesAndPenalties.FilingDate.Value, DUE_DATE,
                                                                 Constants.TAX_AND_WRAP_UP_VALIDATION_FILED_DATE, errorMessages);
                        if (errorMessage != null)
                        {
                            errorMessageList.Add(errorMessage);
                        }
                    }

                }

                if (taxesAndPenalties.BankDetails != null)
                {


                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                                            taxesAndPenalties.BankDetails.BankName,
                                               Constants.TAX_AND_WRAP_UP_BANK_NAME, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    else
                    {
                        errorMessage = BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(
                              taxesAndPenalties.BankDetails.BankName,
                                 Constants.TAX_AND_WRAP_UP_INVALID_BANK_NAME, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }



                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                        taxesAndPenalties.BankDetails.RoutingTransitNumber,
                           Constants.TAX_AND_WRAP_UP_ROUTING_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    else
                    {
                        errorMessage = BusinessValidationRepository.AssertIsValidRTN(
                           taxesAndPenalties.BankDetails.RoutingTransitNumber,
                              Constants.TAX_AND_WRAP_UP_ROUTING_NUMBER_VALIDATION, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                                             taxesAndPenalties.BankDetails.AccountNumber,
                                                Constants.TAX_AND_WRAP_UP_ACCOUNT_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    else
                    {
                        errorMessage = BusinessValidationRepository.AssertIsAccountNumber(
                                                            taxesAndPenalties.BankDetails.AccountNumber,
                                                    Constants.TAX_AND_WRAP_UP_ACCOUNT_NUMBER_VALIDATION, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    if (Utilities.ConvertToInteger32(taxesAndPenalties.BankDetails.BankAccountTypeCode) == 0)
                    {
                        if (taxesAndPenalties.BankDetails.BankAccountTypeCode != AccountType.Checking
                            && taxesAndPenalties.BankDetails.BankAccountTypeCode != AccountType.Saving)
                        {
                            errorMessage = BusinessValidationRepository.AssertGreaterThanZero(Utilities.ConvertToDouble(taxesAndPenalties.BankDetails.BankAccountTypeCode),
                                                              Constants.TAX_AND_WRAP_UP_TYPE_OF_ACCOUNT, errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }
                    }

                }

                if (taxesAndPenalties.ThirdPartyDesignee != null)
                {
                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                        taxesAndPenalties.ThirdPartyDesignee.DesigneeName,
                           Constants.TAX_AND_WRAP_UP_DESIGNEE_NAME, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    else
                    {
                        errorMessage = BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(
                            taxesAndPenalties.ThirdPartyDesignee.DesigneeName,
                               Constants.TAX_AND_WRAP_UP_INVALID_DESIGNEE_NAME, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                               taxesAndPenalties.ThirdPartyDesignee.PIN,
                                  Constants.TAX_AND_WRAP_UP_DESIGNEE_PERSONAL_IDENTIFICATION_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    else
                    {
                        errorMessage = BusinessValidationRepository.AssertIsWithinRange(
                                   taxesAndPenalties.ThirdPartyDesignee.PIN, 5, 5,
                                      Constants.TAX_AND_WRAP_UP_INVALID_DESIGNEE_PERSONAL_IDENTIFICATION_NUMBER, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                                              taxesAndPenalties.ThirdPartyDesignee.PhoneNumber,
                                                 Constants.TAX_AND_WRAP_UP_DESIGNEE_PHONE_NO, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    else
                    {

                        errorMessage = BusinessValidationRepository.AssertIsWithinPhoneNoRange(
                                       taxesAndPenalties.ThirdPartyDesignee.PhoneNumber,
                                                       12,
                                                       12,
                                       Constants.TAX_AND_WRAP_UP_INVALID_DESIGNEE_PHONE_NUMBER, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                }

                if (!Utilities.IsStringEmpty(taxesAndPenalties.InCareOf))
                {
                    errorMessage = BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(
                                    taxesAndPenalties.InCareOf,
                                    Constants.TAX_AND_WRAP_UP_INVALID_INCARE_OF, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }


                if (!Utilities.IsStringEmpty(taxesAndPenalties.InCareOfPhoneNumber))
                {
                    errorMessage = BusinessValidationRepository.AssertIsWithinPhoneNoRange(
                                    taxesAndPenalties.InCareOfPhoneNumber,
                                                    12,
                                                    12,
                                    Constants.TAX_AND_WRAP_UP_INVALID_INCARE_PHONE_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

            }
        }



        //public void BusinessValidationFederalTaxSummary(BusinessObject.Tax1040 taxObject, List<ErrorMessage> errorMessageList, ErrorMessages errorMessages)
        //{
        //    if (taxObject != null)
        //    {
        //        if (taxObject.OutputForms != null && taxObject.TaxesAndPenalties != null)
        //        {
        //            ErrorMessage errorMessage;
        //            if (taxObject.OutputForms != null && taxObject.OutputForms.Tax1040EZPage1 != null)
        //            {
        //                //18Aug2014-Condition Changed By Thileep as per Spec Change Taxesandwrpup(V1.5)
        //                if (taxObject.OutputForms.Tax1040EZPage1.RefundAmount > Constants.intZero &&
        //                    (taxObject.TaxesAndPenalties == null || taxObject.TaxesAndPenalties.HasToDepositTaxRefundsToBankAccount == null))
        //                {
        //                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_REQUIRED_REFUND_DETAIL);
        //                    errorMessage = errorMessages[Constants.TAX_AND_WRAP_UP_REQUIRED_REFUND_DETAIL];
        //                    if (errorMessage != null)
        //                        errorMessageList.Add(errorMessage);
        //                }
        //                else
        //                {
        //                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_REQUIRED_REFUND_DETAIL);

        //                }

        //                //To DO
        //                //if (taxObject.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= Constants.intZero &&
        //                //    taxObject.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits <= Constants.intZero &&
        //                //    taxObject.OutputForms.Tax1040EZPage1.TaxAmount <= Constants.intZero &&
        //                //    taxObject.OutputForms.Tax1040EZPage1.RefundAmount <= Constants.intZero)
        //                //{
        //                //    errorMessage = errorMessages[Constants.TAX_AND_WRAP_UP_MISSING_INCOME];
        //                //    if (errorMessage != null)
        //                //        errorMessageList.Add(errorMessage);
        //                //}
        //                //else
        //                //{
        //                //    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_MISSING_INCOME);

        //                //}                       

        //            }

        //        }
        //    }
        //}
        #endregion

        #region Helper Method
        private bool HasEligibilityTaxIncome(UserDTO userDTO, BusinessObject.Tax1040 taxObject)
        {
            bool hasEligibilityTaxIncome = false;
            if (taxObject.ErrorMessages == null)
                taxObject.ErrorMessages = new List<ErrorMessage>();
            if (taxObject.OutputForms != null && taxObject.OutputForms.Tax1040EZPage1 != null)
            {
                //var errorMessage = messageRepository.GetErrorMessages();
                var errorMessage = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
                var errorMessages = new ErrorMessages(errorMessage);

                taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME);

                ErrorMessage taxableIncomeEligibilityErrorMessage = BusinessValidationRepository.AssertIsGreater(taxObject.OutputForms.Tax1040EZPage1.TaxableIncome,
                                                                Constants.TAXABLE_INCOME_ELIGIBILITY_AMOUNT,
                                                             Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME,
                                                      errorMessages);

                if (taxableIncomeEligibilityErrorMessage != null)
                {
                    taxObject.ErrorMessages.Add(taxableIncomeEligibilityErrorMessage);
                    Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);
                    hasEligibilityTaxIncome = true;
                }
            }
            return hasEligibilityTaxIncome;
        }

        //Vincent-26/06/14- Genernating 1040EZ Output Form
        public void Genernate1040EZForm(UserDTO userDTO)
        {
            userDTO.UserDataId = userDTO.UserDataId == null ? 0 : userDTO.UserDataId;

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

            dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
            input.Tax1040Object = taxObject;
            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                        WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), input));
            if (userDTO.UserDataId != 0)
            {
                Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);
            }
        }

        #endregion

    }
}
