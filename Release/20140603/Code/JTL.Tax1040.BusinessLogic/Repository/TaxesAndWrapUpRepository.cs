/*
Copyright       : Copyright Jeevan Technologies
File Name       : TaxesAndWrapUpRepository.cs 
Description     : Bussiness Logic for Taxes And WrapUp  
Author          : Vivek
Created Date    : 28 Apr 2014

 * Modification History:
 * 27May2014 Sathish added GetTaxAndWrapupSummary method
 * 28May2014 Sathish created person detail if person detail not updated in tax and wrap up persist
 * 28May2014 Sathish added TaxableIncomeEligibilityCheck to check taxable income is eligible for 1040EZ
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

namespace JTL.Tax1040.BusinessLogic
{
    public class TaxesAndWrapUpRepository : ITaxesAndWrapUpRepository
    {
        #region Local variable declaration
        ITaxReturnDataService taxReturnDataService;
        private readonly MessagesRepository messageRepository;
        IPersonalInfoRepository personalInfoRepository;
        bool hasEligibilityDiagnostics = false;
        DateTime DUE_DATE = new DateTime(2014, 4, 15);
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

                    Tuple<long, bool> userDataId = personalInfoRepository.PersistPrimaryTaxPayer(taxObject.PersonalDetails.PrimaryTaxPayer, userId, taxReturnData.UserDataId);

                    taxReturnData.UserDataId = userDataId.Item1;
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

                var errorMessage = messageRepository.GetErrorMessages();
                var errorMessages = new ErrorMessages(errorMessage);
                input.ErrorMessages = errorMessages;


                //BusinessFieldValidations(otherIncome, taxObject.ErrorMessages, errorMessages);
                if (taxObject.TaxesAndPenalties != null)
                {
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new TaxAndWrapUpEligibilityCheck(), input));
                    hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => em.Topic == Constants.TOPIC_TAX_AND_WRAPUP && em.ErrorCode.StartsWith("TaxesAndWrapUp_ER"));
                }

                BusinessValidation(taxObject.TaxesAndPenalties, taxObject.ErrorMessages, errorMessages);

                taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);


                userData = new Tuple<long, bool>(taxReturnData.UserDataId, hasEligibilityDiagnostics);

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:TaxesAndWrapUpRepository,Method Name:PersistTaxesAndWrapUpData", ex);
            }
            return userData;
        }
        #endregion

        #region Get method

        public System.Tuple<TaxesAndPenalties, string, DateTime> GetTaxAndWrapup(UserDTO userDTO)
        {
            Tuple<TaxesAndPenalties, string, DateTime> taxAndPenalties = null;
            try
            {
                BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                taxAndPenalties = new Tuple<TaxesAndPenalties, string, DateTime>(((taxObject != null && taxObject.TaxesAndPenalties != null)
                                                                                    ? taxObject.TaxesAndPenalties : null),
                                                                            Utilities.GetTaxPayerFirstNameOrNickName(taxObject),
                                                                           ((taxObject != null && taxObject.TaxesAndPenalties == null
                                                                           || taxObject.TaxesAndPenalties.FederalExtensionAmountPaidDate.HasValue == false) ?
                                                                                DateTime.Now : DateTime.MinValue));
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:TaxesAndWrapUpRepository,Method Name:GetTaxAndWrapup", ex);
            }
            return taxAndPenalties;
        }

        public Tuple<Tax1040EZPage1, List<ErrorMessage>> GetFederalTaxSummary(UserDTO userDTO)
        {
            Tuple<Tax1040EZPage1, List<ErrorMessage>> federalTaxSummary = null;

            try
            {
                BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;
                var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                            WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), input));
                federalTaxSummary = new Tuple<Tax1040EZPage1, List<ErrorMessage>>(
                                             ((taxObject != null && taxObject.OutputForms != null && taxObject.OutputForms.Tax1040EZPage1 != null)
                                             ? taxObject.OutputForms.Tax1040EZPage1 : null),
            taxObject.ErrorMessages.FindAll(em => em.ErrorCode.StartsWith(Constants.TOPIC_TAX_AND_WRAPUP)));
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:TaxesAndWrapUpRepository,Method Name:GetFederalTaxSummary", ex);
            }
            return federalTaxSummary;


        }

        // 28May2014 Check Taxable income eligibility
        public Tuple<string, bool> TaxableIncomeEligibilityCheck(UserDTO userDTO)
        {
            Tuple<string, bool> taxableIncomeEligibility = null;
            try
            {
                BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                if (taxObject != null)
                {
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                                WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), input));

                    if (taxObject.OutputForms != null && taxObject.OutputForms.Tax1040EZPage1 != null)
                    {
                        if (taxObject.ErrorMessages == null)
                            taxObject.ErrorMessages = new List<ErrorMessage>();

                        var errorMessage = messageRepository.GetErrorMessages();
                        var errorMessages = new ErrorMessages(errorMessage);


                        ErrorMessage taxableIncomeEligibilityErrorMessage = BusinessValidationRepository.AssertIsGreater(taxObject.OutputForms.Tax1040EZPage1.TaxableIncome,
                                                                        Constants.TAXABLE_INCOME_ELIGIBILITY_AMOUNT,
                                                                     Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME,
                                                                     errorMessages);
                        if (taxableIncomeEligibilityErrorMessage != null)
                            taxObject.ErrorMessages.Add(taxableIncomeEligibilityErrorMessage);

                        hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.Topic == Constants.TOPIC_TAX_AND_WRAPUP) && em.ErrorCode.StartsWith(Constants.TOPIC_TAX_AND_WRAPUP + "_ER"));

                        if (hasEligibilityDiagnostics)
                            Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);

                    }
                }
                taxableIncomeEligibility = new Tuple<string, bool>(Utilities.GetTaxPayerFirstNameOrNickName(taxObject), hasEligibilityDiagnostics);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:TaxesAndWrapUpRepository,Method Name:TaxableIncomeEligibilityCheck", ex);
            }
            return taxableIncomeEligibility;
        }

        #endregion


        #region Validation

        public void BusinessValidation(TaxesAndPenalties taxesAndPenalties, List<ErrorMessage> errorMessageList,
                                       ErrorMessages errorMessages)
        {
            if (taxesAndPenalties != null)
            {
                ErrorMessage errorMessage;


                if (taxesAndPenalties.HasFiledForm4868.HasValue && taxesAndPenalties.HasFiledForm4868.Value == true)
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

                if (taxesAndPenalties.HasPaidFederalExtensionWithForm4868.HasValue && taxesAndPenalties.HasPaidFederalExtensionWithForm4868.Value == true)
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
                        errorMessage = BusinessValidationRepository.AssertIsOnlyNumeric(
                                                            taxesAndPenalties.BankDetails.AccountNumber,
                                                    Constants.TAX_AND_WRAP_UP_ACCOUNT_NUMBER_VALIDATION, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    if (Utilities.ConvertToInteger32(taxesAndPenalties.BankDetails.BankAccountTypeCode) == 0)
                    {
                        if (taxesAndPenalties.BankDetails.BankAccountTypeCode != AccountType.Checking
                            && taxesAndPenalties.BankDetails.BankAccountTypeCode != AccountType.Savings)
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

                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                               taxesAndPenalties.ThirdPartyDesignee.PIN,
                                  Constants.TAX_AND_WRAP_UP_DESIGNEE_PERSONAL_IDENTIFICATION_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                                              taxesAndPenalties.ThirdPartyDesignee.PhoneNumber,
                                                 Constants.TAX_AND_WRAP_UP_DESIGNEE_PHONE_NO, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage = BusinessValidationRepository.AssertIsWithinRange(
                                   taxesAndPenalties.ThirdPartyDesignee.PhoneNumber,
                                                   10,
                                                   10,
                                   Constants.TAX_AND_WRAP_UP_INVALID_PHONE_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                }


                if (taxesAndPenalties.InCareOfPhoneNumber != null)
                {
                    errorMessage = BusinessValidationRepository.AssertIsWithinRange(
                                    taxesAndPenalties.InCareOfPhoneNumber,
                                                    10,
                                                    10,
                                    Constants.TAX_AND_WRAP_UP_INVALID_PHONE_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

            }
        }

        #endregion

    }
}
