/*
Copyright       : Copyright Jeevan Technologies
File Name       : TaxesAndWrapUpRepository.cs 
Description     : Bussiness Logic for Taxes And WrapUp  
Author          : Vivek
Created Date    : 28 Apr 2014

 * Modification History:
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

namespace JTL.Tax1040.BusinessLogic
{
    public class TaxesAndWrapUpRepository : ITaxesAndWrapUpRepository
    {
        #region Local variable declaration
        ITaxReturnDataService taxReturnDataService;
        private readonly MessagesRepository messageRepository;
        const string TAXPAYER = "Taxpayer";
        bool hasEligibilityDiagnostics = false;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="W2Repository"/> class.
        /// </summary>
        public TaxesAndWrapUpRepository()
        {
            taxReturnDataService = new TaxReturnDataService();
            messageRepository = new MessagesRepository();
        }
        #endregion

        #region Persist Method
        /// <summary>
        /// Tax and wrap-up persist
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="sessionData"></param>
        /// <param name="taxAndWrapUpData"></param>
        /// <param name="historyData"></param>
        /// <param name="userDataId"></param>
        /// <param name="errorMessageList"></param>
        /// <returns></returns>
        public dynamic PersistTaxesAndWrapUpData(long userId, TaxReturnData taxReturnData)
        {
            try
            {
                JTL.Tax1040.BusinessObject.Tax1040 taxObject;

                //Retrieving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);

                //Converting Json to OtherIncome by DeSerializing
                TaxesAndPenalties taxesAndPenalties = JsonConvert.DeserializeObject<TaxesAndPenalties>(taxReturnData.TaxData);

                if (taxObject != null && taxesAndPenalties != null)
                {
                    taxObject.TaxesAndPenalties = new TaxesAndPenalties();
                    taxObject.TaxesAndPenalties = taxesAndPenalties;
                }

                if(taxObject.ErrorMessages == null)
                    taxObject.ErrorMessages = new List<ErrorMessage>();


                // Clear the Error messages exist for this topic.
                messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_TAX_AND_WRAPUP);


                //Workflow Validation Section
                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;

                var errorMessage = messageRepository.GetErrorMessages();
                var errorMessages = new ErrorMessages(errorMessage);
                input.ErrorMessages = errorMessages;

                //TODO: vivek 28-Apr-14 have to invoke the tax and wrap up class and Business validation for tax and wrap up

                //BusinessFieldValidations(otherIncome, taxObject.ErrorMessages, errorMessages);
                if (taxObject.TaxesAndPenalties != null)
                {
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new TaxAndWrapUpEligibilityCheck(), input));
                    hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => em.Topic == Constants.TOPIC_TAX_AND_WRAPUP && em.ErrorCode.StartsWith("TaxesAndWrapUp_ER"));
                }

                BusinessValidation(taxObject.TaxesAndPenalties, taxObject.ErrorMessages, errorMessages);

                taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);


                dynamic userData = new Tuple<long, bool>(taxReturnData.UserDataId, hasEligibilityDiagnostics);

                return userData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Get method

        public System.Tuple<Tax1040EZPage1, TaxesAndPenalties, string> GetTaxAndWrapup(long userId, long userDataId)
        {

            string taxPayerName = TAXPAYER;

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);


            //TODO : Sathish Need to Work flow to get Tax1040EZPage1, As if now no suggestion
            Tax1040EZPage1 tax1040EZPage1 = new Tax1040EZPage1();

            //Get PrimaryTaxPayer  Nick / First Name.
            if (taxObject.PersonalDetails != null)
            {
                if (taxObject.PersonalDetails.PrimaryTaxPayer != null)
                {
                    if (taxObject.PersonalDetails.PrimaryTaxPayer.Person != null)
                    {
                        if (!Utilities.IsStringEmpty(taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName))
                        {
                            taxPayerName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName;
                        }
                        else if (!Utilities.IsStringEmpty(taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName))
                        {
                            taxPayerName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName;
                        }
                    }
                }
            }

            return new Tuple<Tax1040EZPage1, TaxesAndPenalties, string>(tax1040EZPage1,
                                                                        ((taxObject.TaxesAndPenalties != null) ? taxObject.TaxesAndPenalties : null),
                                                                        taxPayerName);
        }
        #endregion


        #region Validation

        public void BusinessValidation(TaxesAndPenalties taxesAndPenalties, List<ErrorMessage> errorMessageList,
                                       ErrorMessages errorMessages)
        {
            if (taxesAndPenalties != null)
            {
   
                ErrorMessage errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                    Convert.ToString(taxesAndPenalties.FederalExtensionAmount),
                       Constants.TAX_AND_WRAP_UP_EXTENSTION_AMOUNT, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                    Convert.ToString(taxesAndPenalties.FederalExtensionAmountPaidDate),
                       Constants.TAX_AND_WRAP_UP_EXTENSION_DATE, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                    Convert.ToString(taxesAndPenalties.FilingDate),
                       Constants.TAX_AND_WRAP_UP_FILING_DATE, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);


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

                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                                             taxesAndPenalties.BankDetails.AccountNumber,
                                                Constants.TAX_AND_WRAP_UP_ACCOUNT_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage = BusinessValidationRepository.AssertGreaterThanZero(
                                                  Utilities.ConvertToInteger32(taxesAndPenalties.BankDetails.BankAccountTypeCode),
                                                      Constants.TAX_AND_WRAP_UP_TYPE_OF_ACCOUNT, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage = BusinessValidationRepository.AssertIsOnlyNumeric(
                          taxesAndPenalties.BankDetails.AccountNumber,
                          Constants.TAX_AND_WRAP_UP_ROUTING_NUMBER_VALIDATION, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    //Validation of Bank Name - If needed can be used in Future ...By Ashok
                    //errorMessage = BusinessValidationRepository.AssertIsValidBankName(
                    //                        taxesAndPenalties.BankDetails.BankName,
                    //                           Constants.TAX_AND_WRAP_UP_BANK_NAME, errorMessages);
                    //if (errorMessage != null)
                    //    errorMessageList.Add(errorMessage);

                    errorMessage = BusinessValidationRepository.AssertIsValidRTN(
                       taxesAndPenalties.BankDetails.RoutingTransitNumber,
                          Constants.TAX_AND_WRAP_UP_ROUTING_NUMBER_VALIDATION, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                     errorMessage = BusinessValidationRepository.AssertIsValidAccountNumber(
                       taxesAndPenalties.BankDetails.AccountNumber,
                          Constants.TAX_AND_WRAP_UP_ACCOUNT_NUMBER_VALIDATION, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                
                }

                if (taxesAndPenalties.ThirdPartyDesignee != null)
                {
                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                        taxesAndPenalties.ThirdPartyDesignee.DesigneeName,
                           Constants.TAX_AND_WRAP_UP_DESIGNEE_NAME, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                            taxesAndPenalties.ThirdPartyDesignee.PhoneNumber,
                               Constants.TAX_AND_WRAP_UP_DESIGNEE_PHONE_NO, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                     errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(
                                taxesAndPenalties.ThirdPartyDesignee.PIN,
                                   Constants.TAX_AND_WRAP_UP_DESIGNEE_PERSONAL_IDENTIFICATION_NUMBER, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                    // Validation
                        errorMessage = BusinessValidationRepository.AssertIsWithinMaxLength(
                                        taxesAndPenalties.ThirdPartyDesignee.PhoneNumber,
                                                        10,
                                        Constants.TAX_AND_WRAP_UP_PHONE_NUMBER, errorMessages);
                                        if (errorMessage != null)
                                            errorMessageList.Add(errorMessage);
                }

            }
        }

        #endregion

    }
}
