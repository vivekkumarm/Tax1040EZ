
/*
Copyright   : Copyright Jeevan Technologies
File Name   : EarnedIncomeCredit.cs 
Description : Earned Income credit  
Author      : Sathish 
Created Date : 21Apr2014

 * Modification History:
------------------------
 * 23Apr2014 Sathish Changed dynamic to long in return type for PersitEarnedIncomeCredit
 * 23Apr2014 Sathish Added new method to Get Credit Summary
 * 02May2014 Sathish Used TaxReturnData for persist
 * 02May2014 Bala Modified code to clear the error messages from error message list. 
 */

using System;
using System.Collections.Generic;
using System.Dynamic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using Newtonsoft.Json;
using System.Activities;
using JTL.Tax1040.BusinessLogic;
using Tax1040WorkFlow.WorkFlow.Activities;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities;


namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Contains EIC and Credit Summary related Repository methods.
    /// </summary>
    public class EarnedIncomeCreditRepository : IEarnedIncomeCreditRepository
    {
        #region Local variable declaration
        const string TAXPAYER = "Taxpayer";
        const int AGI_LIMIT_FOR_SINGLE = 14340;
        const int AGI_LIMIT_FOR_MFJ = 19680;
        MessagesRepository messageRepository;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxReturnRepository"/> class.
        /// </summary>
        public EarnedIncomeCreditRepository()
        {
            messageRepository = new MessagesRepository();
        }
        #endregion

        #region EIC related Methods
        /// <summary>
        /// Get EIC based UserId and UserDataId
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        public Tuple<EIC, string, bool> GetEarnedIncomeCredit(UserDTO userDTO)
        {
            try
            {
                //local variable declaration.
                var taxPayerName = TAXPAYER;
                BusinessObject.Tax1040 taxObject;
                FilingStatus filingStatus = FilingStatus.None;
                double annualGrossIncome = 0L;
                double totalW2Wages = 0L;
                bool isEciEligible = false;

                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                if (taxObject != null)
                {
                    //Get PrimaryTaxPayer  Nick / First Name.
                    if (taxObject.PersonalDetails != null)
                    {
                        if (taxObject.PersonalDetails.PrimaryTaxPayer != null)
                        {
                            if (taxObject.PersonalDetails.PrimaryTaxPayer.Person != null)
                            {
                                if (!Utilities.IsStringEmpty(taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName.Trim()))
                                {
                                    taxPayerName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName;
                                }
                                else if (!Utilities.IsStringEmpty(taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName.Trim()))
                                {
                                    taxPayerName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName;
                                }
                            }

                            //Get PrimaryTaxPayer FilingStatus.
                            filingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                        }
                    }
                }

                //TODO: Saravanan N - 23rd April, 2014 - The ErrorMessage should be removed after workflow changes done. - START
                //Retrieving Error Message list from Database
                messageRepository = new MessagesRepository();
                var errorMessage = messageRepository.GetErrorMessages();
                var errorMessages = new ErrorMessages(errorMessage);
                //TODO: Saravanan N - 23rd April, 2014 - The ErrorMessage should be removed after workflow changes done. - END
                
                //AGI Workflow call.
                //Invoking Business Rules Validation Workflow
                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;
                input.ErrorMessages = errorMessages;  //TODO: Saravanan N - 23rd April, 2014 - The ErrorMessage should be removed after workflow changes done.
                var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZAdjustedGrossIncome(), input));
                
                //Get the output value from workflow.
                if (output != null)
                {
                    annualGrossIncome = output.AnnualGrossIncome;
                    totalW2Wages = output.TotalW2Wages;
                }

                //Check ECI Eligiblity
                if (((filingStatus == FilingStatus.Single && annualGrossIncome <= AGI_LIMIT_FOR_SINGLE) ||
                    (filingStatus == FilingStatus.MarriedFilingJointly && annualGrossIncome <= AGI_LIMIT_FOR_MFJ)) &&
                    totalW2Wages > 0)
                {
                    isEciEligible = true;
                }

                return new Tuple<EIC, string, bool>(((taxObject != null && taxObject.Credits != null && taxObject.Credits.EIC != null) ? taxObject.Credits.EIC : null), taxPayerName, isEciEligible);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Persist EIC
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <param name="eicData"></param>
        /// <returns></returns>
        public long PersitEarnedIncomeCredit(long userId, TaxReturnData taxReturnData)
        {
            try
            {
                BusinessObject.Tax1040 taxObject;
                EIC eic = JsonConvert.DeserializeObject<EIC>(taxReturnData.TaxData);

                if (eic != null)
                {
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);

                    if (taxObject == null)
                        taxObject = new BusinessObject.Tax1040();

                    if (taxObject.Credits == null)
                    {
                        taxObject.Credits = new Credits();
                    }
                    taxObject.Credits.EIC = eic;

                    //Initializing Out Parameter
                    if (taxObject.ErrorMessages == null)
                        taxObject.ErrorMessages = new List<ErrorMessage>();

                    //Retrieving Error Message list from Database
                    var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessages = new ErrorMessages(errorMessage);

                    // Clear the Error messages
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EARNED_INCOME_CREDIT);

                    BusinessValidation(taxObject.Credits.EIC, taxObject.ErrorMessages, errorMessages);

                    //TODO: Raising Object Reference exception. - Saravanan N - 25th April, 2014.
                    //Invoking Business Rules Validation Workflow
                    //dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    //input.Tax1040Object = taxObject;
                    //input.ErrorMessages = errorMessages;
                    //var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZEarnedIncomeCreditCalculation(), input));

                    //Persist TaxObject.
                    taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);
                }

                return taxReturnData.UserDataId;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Business Fields Validations (Required and Validation) checked.
        /// </summary>
        /// <param name="eic"></param>
        /// <param name="errorMessageList"></param>
        /// <param name="errorMessages"></param>
        public void BusinessValidation(EIC eic, List<ErrorMessage> errorMessageList,
           ErrorMessages errorMessages)
        {
            ErrorMessage errorMessage;

            if (eic != null)
            {
                if (eic.HasTaxableScholarshipCredits != null && eic.HasTaxableScholarshipCredits == true)
                {
                    errorMessage =
                   BusinessValidationRepository.AssertGreaterThanZero(eic.TaxableScholarshipCredit,
                       Constants.EIC_TAXABLE_FELLOWSHIP_INCOME, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

                if (eic.HasPensionAnnuity != null && eic.HasPensionAnnuity == true)
                {
                    errorMessage =
                   BusinessValidationRepository.AssertGreaterThanZero(eic.PensionAnnuity,
                       Constants.EIC_PENSION_OR_ANNUITY_NOT_QUALIFIED_COMPENSATION, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

                if (eic.HasPenalInstitutionInmateWages != null && eic.HasPenalInstitutionInmateWages == true)
                {
                    errorMessage =
                   BusinessValidationRepository.AssertGreaterThanZero(eic.PenalInstitutionInmateWages,
                       Constants.EIC_WAGES_FOR_WORK_DONE_WHILE_PENAL_INSTITUTION, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

                if (eic.HasReceivedIRSNoticeOnFiling8862 != null && eic.HasReceivedIRSNoticeOnFiling8862 == true)
                {
                    errorMessage =
                   BusinessValidationRepository.AssertIsNotNull(eic.HasReceivedIRSNoticeOnFiling8862,
                       Constants.EIC_LIKE_TO_CLAIM_FORM_8862, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

                if (eic.HasEICForPriorYearDisallowance != null && eic.HasEICForPriorYearDisallowance == true)
                {
                    errorMessage =
                   BusinessValidationRepository.AssertIsNotNull(eic.HasEICForPriorYearDisallowance,
                       Constants.EIC_REDUCED_OR_DISALLOWED_FOR_INCORRECTLY_REPORTEED_INCOME, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }


            }

        }
        #endregion

        #region CreditSummary related methods
        /// <summary>
        /// Get Credit Summary by UserId and UserDataId
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        public dynamic GetCreditSummary(UserDTO userDTO)
        {
            try
            {
                BusinessObject.Tax1040 taxObject;
                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                dynamic creditSummaryData = new ExpandoObject();
                creditSummaryData.PrimaryTaxPayerName = Constants.TAXPAYER_DEFAULT_DISPAY_NAME;
                creditSummaryData.TotalEIC = 0;

                if (taxObject != null)
                {
                    PersonalDetails personalDetails = taxObject.PersonalDetails;

                    if (personalDetails != null)
                    {
                        if (personalDetails.PrimaryTaxPayer != null && personalDetails.PrimaryTaxPayer.Person != null)
                        {
                            if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.NickName))
                                creditSummaryData.PrimaryTaxPayerName = personalDetails.PrimaryTaxPayer.Person.NickName;
                            else if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.FirstName))
                                creditSummaryData.PrimaryTaxPayerName = personalDetails.PrimaryTaxPayer.Person.FirstName;
                        }
                    }

                    //taxObject.ErrorMessages = new List<ErrorMessage>();

                    ////Initializing Out Parameter
                    //List<ErrorMessage> errorMessageList = new List<ErrorMessage>();

                    //dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    //input.Tax1040Object = taxObject;
                    //var errorMessage = messageRepository.GetErrorMessages();
                    //var errorMessages = new ErrorMessages(errorMessage);
                    //input.ErrorMessages = errorMessages;
                    //input.EICOut = 0;
                    //var output =
                    //    Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                    //        WorkflowInvoker.Invoke(new F1040EZEarnedIncomeCreditCalculation(), input));

                    creditSummaryData.TotalEIC = 0; // TODO : HARD CODED WILL BE REMOVED AFTER WE GET Total EIC FROM WORKFLOW
                    creditSummaryData.ErrorMessages = taxObject.ErrorMessages;

                }


                return creditSummaryData;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
