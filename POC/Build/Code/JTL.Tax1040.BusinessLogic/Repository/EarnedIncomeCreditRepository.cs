
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
 * 04Jun2014 Vincent Modified code for Persist and get method for EIC and workflow changes.
 * 09Jun2014 Sathish get tax payer name from common method in utilites
 * 11jun2014 Vincent Modified code for Persist and get method for EIC. 
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
using System.Linq;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;


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
                var taxPayerName = string.Empty;
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
                            //Get PrimaryTaxPayer FilingStatus.
                            filingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                        }
                    }
                }

                // 09Jun2014 Sathish get tax payer name from common method in utilites
                taxPayerName = Utilities.GetTaxPayerFirstNameOrNickName(taxObject);

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
                //25Jun2014 Sathish called AGI work flow with no validation to avoid error message update for the defect #TAX1040-14036
                var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZAdjustedGrossIncomeWithNoValidation(), input));

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
                else
                {
                    //Vincent - 25 Jun 2014 - Defect 14034 - IF EIC Credits fails then in EIC objects should be cleared.
                    if (taxObject != null && taxObject.UserDataId != 0)
                    {
                        //If EIC eligbility fails in AGI calculation, Taxobject's EIC object should be cleared while loading this page.
                        if (taxObject.Credits != null && taxObject.Credits.EIC != null)
                        {
                            taxObject.Credits.EIC = null;
                        }

                        //If EIC eligbility fails in AGI calculation, worksheet EIC object should be cleared in output form while loading this page.
                        if (taxObject.F1040EZ != null && taxObject.F1040EZ.F1040EZWorkSheets != null &&
                            taxObject.F1040EZ.F1040EZWorkSheets.EICWorkSheet != null)
                        {
                            taxObject.F1040EZ.F1040EZWorkSheets.EICWorkSheet = null;
                        }

                        //Cleared Taxobject and OutputForm  object's cleared EIC object will be persisted.
                        Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);
                    }
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

                    //Invoking Business Rules Validation Workflow
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;

                    //Getting the AGI value from output forms porperty.
                    //25Jun2014 Sathish called AGI work flow with no validation to avoid error message update for the defect #TAX1040-14036
                    var outputGetData = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZAdjustedGrossIncomeWithNoValidation(), input));

                    input.ErrorMessages = errorMessages;
                    //Checking EIC Eligibility check
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZEICEligibilityRuleCheck(), input));

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
                //Required Entry #1
                if (eic.HasTaxableScholarshipCredits != null && eic.HasTaxableScholarshipCredits == true)
                {
                    errorMessage =
                   BusinessValidationRepository.AssertGreaterThanZero(eic.TaxableScholarshipCredit,
                       Constants.EIC_TAXABLE_FELLOWSHIP_INCOME, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

                //Required Entry #2
                if (eic.HasPensionAnnuity != null && eic.HasPensionAnnuity == true)
                {
                    errorMessage =
                   BusinessValidationRepository.AssertGreaterThanZero(eic.PensionAnnuity,
                       Constants.EIC_PENSION_OR_ANNUITY_NOT_QUALIFIED_COMPENSATION, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

                //Required Entry #3
                if (eic.HasPenalInstitutionInmateWages != null && eic.HasPenalInstitutionInmateWages == true)
                {
                    errorMessage =
                   BusinessValidationRepository.AssertGreaterThanZero(eic.PenalInstitutionInmateWages,
                       Constants.EIC_WAGES_FOR_WORK_DONE_WHILE_PENAL_INSTITUTION, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }



                //Required Entry #4
                if (eic.HasReceivedIRSNoticeOnFiling8862 == true && eic.HasIncorrectlyReportedEarnedIncome == null && eic.HasEICForPriorYearDisallowance == true)
                {
                    errorMessage = errorMessages[Constants.EIC_REDUCED_OR_DISALLOWED_FOR_INCORRECTLY_REPORTEED_INCOME];
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

                //Required Entry #5
                if (eic.HasReceivedIRSNoticeOnFiling8862 == true && eic.HasEICForPriorYearDisallowance == null)
                {
                    errorMessage = errorMessages[Constants.EIC_LIKE_TO_CLAIM_FORM_8862];
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

                //Required Entry #6
                if (eic.HasReceivedIRSNoticeOnFiling8862 == true && eic.HasEICForPriorYearDisallowance != null && eic.HasEICForPriorYearDisallowance == true)
                {
                    //Taxpayer Lived in US.
                    errorMessage =
                  BusinessValidationRepository.AssertGreaterThanZero(eic.NumberOfDaysTaxPayerLivedInUS,
                      Constants.EIC_NUMBER_OF_DAYS_TaxPayer_LIVED_IN_US, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    //Spouse Lived in US

                    errorMessage =
                 BusinessValidationRepository.AssertGreaterThanZero(eic.NumberOfDaysSpouseLivedInUS,
                     Constants.EIC_NUMBER_OF_DAYS_SPOUSE_LIVED_IN_US, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }


                //Waring Rules
                //This Business rule is related to Form 8862
                if (eic.HasReceivedIRSNoticeOnFiling8862 == true && eic.HasEICForPriorYearDisallowance == true)
                {

                    errorMessage = errorMessages[Constants.EIC_PRIOR_YEAR_DISALLOWANCE];
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                }


                if (eic.HasReceivedIRSNoticeOnFiling8862 == true && eic.HasEICForPriorYearDisallowance == true)
                {
                    if (eic.HasIncorrectlyReportedEarnedIncome == true)
                    {
                        errorMessage = errorMessages[Constants.EIC_INCORRECTLY_REPORTED_YOUR_EARNED_INCOME];
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }
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
                IEnumerable<ErrorMessage> lstErrorMessages = null;
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


                    if (taxObject.ErrorMessages != null)
                    {
                        //If ErrorMessages doesn't have any object it returns count as 1 for NULL object. So removing this NULL object from the list.
                        taxObject.ErrorMessages.RemoveAll(err => err == null);

                        if (taxObject.ErrorMessages.Count > 0)
                        {
                            //Get Other Income related error messages.
                            //Vincent-17Jun2014-Checking for EIC Information calculation for EIC credits. 
                            lstErrorMessages = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT && err.ErrorType.StartsWith("Information"));
                        }
                    }

                    //Vincent -18Jun2014-Added EIC Eligibility check.
                    var EICEligibility = false;

                    if (lstErrorMessages != null && lstErrorMessages.ToList().Count <= 0)
                    {
                        EICEligibility = true;

                        dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                        input.Tax1040Object = taxObject;

                        var output =
                             Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                 WorkflowInvoker.Invoke(new F1040EZEarnedIncomeCreditWithNoValidation(), input));
                        creditSummaryData.TotalEIC = output.TotalEIC;
                    }
                    else
                    {
                        //Vincent - 25 Jun 2014 - Defect 14034 - IF EIC Credits fails then in EIC Worksheeet object should be cleared.
                        if (taxObject != null && taxObject.F1040EZ != null && taxObject.F1040EZ.F1040EZWorkSheets != null &&
                            taxObject.F1040EZ.F1040EZWorkSheets.EICWorkSheet != null)
                        {
                            taxObject.F1040EZ.F1040EZWorkSheets.EICWorkSheet = null;
                            Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);
                        }
                    }

                    //Vincent-17Jun2014-Getting required field validation and Warning error message.
                    creditSummaryData.ErrorMessages = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT &&
                        (err.ErrorCode.StartsWith("EarnedIncomeCredit_RF") || err.ErrorType.StartsWith("Warning")));
                    //EIC Eligibility check data.
                    creditSummaryData.EICEligibility = EICEligibility;
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
