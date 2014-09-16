
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
 * 30thJune2014 Ashok added for Form 8862 Pdf Binding.
 * 10thjuly2014 Thileep added the Business validation for No of days lived by Taxyear and Spouse
 * 14thJuly2014 Ashok - Added logic for Clearing Form8862 class and setting IsForm8862Required false when failing EIC eligibility
 * 30July2014-Thileep changed GetEarnedIncomeCredit method to Get EligiblityInformation Messages in Credit Section
 * 01August2014 - Added by Ashok Kumar Setting defalult filing status as Single
 * 04August2014-Thileep changed  GetEarnedIncomeCredit method to get Filingstatus of Taxpayer
 * 04August2014-Thileep changed  Business Validation method to check Filingstatus of Taxpayer 
 * 05August2014 Ashok Kumar changed GetEarnedIncomeCredit method to get TaxableScholarship and NonQualifiedPlans from W2
 * 07August2014 Thileep Kumar changed Business Validation method as per Credit Spec(V1.7)
 * 07August2014 Ashok Kumar added condtion to check claimed as dependent for EIC eligibility
 * 11August2014 Ashok Kumar modified EIC Eligibility Check based on EIC Information Error Messages
 * 20Aug2014-Thileep changed and added code in PersitEarnedIncomeCredit method for Refundoptioncheck and (Income,Refund,Taxes all are Zeros check)
 * 01Sep2014 - Ashok Kumar changed logic in Clearing of EIC Error Messages
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
using System.Runtime.CompilerServices;
using System.Web;


namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Contains EIC and Credit Summary related Repository methods.
    /// </summary>
    public class EarnedIncomeCreditRepository : IEarnedIncomeCreditRepository
    {
        #region Local variable declaration
        const string TAXPAYER = "Taxpayer";
        MessagesRepository messageRepository;
        IPersonalInfoRepository personalInfoRepository;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxReturnRepository"/> class.
        /// </summary>
        public EarnedIncomeCreditRepository()
        {
            messageRepository = new MessagesRepository();
            personalInfoRepository = new PersonalInfoRepository();
        }
        #endregion

        #region EIC related Methods
        /// <summary>
        /// Get EIC based UserId and UserDataId
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        public Tuple<EIC, string, bool, IEnumerable<ErrorMessage>, long, FilingStatus, Tuple<double, double, IEnumerable<ErrorMessage>>> GetEarnedIncomeCredit(UserDTO userDTO)
        {
            try
            {
                //local variable declaration.
                var taxPayerName = string.Empty;
                BusinessObject.Tax1040 taxObject;
                FilingStatus filingStatus = FilingStatus.None;
                string primaryTaxPayerSSN = string.Empty, spouseSSN = string.Empty;
                double annualGrossIncome = 0L;
                double totalW2Wages = 0L;
                double totaltaxableScholarshipAmount = 0L, totalNonQualifiedPlansAmount = 0L;
                bool isEicEligible = false;
                IEnumerable<ErrorMessage> taxObjectErrorList = null;
                IEnumerable<ErrorMessage> eicErrorList = null;

                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                //01August2014 - Added by Ashok Kumar Setting defalult filing status as Single
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
                    Tuple<long, bool> userDataId = personalInfoRepository.PersistPrimaryTaxPayer(taxObject.PersonalDetails.PrimaryTaxPayer, userDTO.UserId, userDTO.UserDataId);
                    userDTO.UserDataId = userDataId.Item1;

                    //Retrieving TaxObject from database
                    //26Aug2014 Sathish Get Tax object after personal info persist to get the error message list
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                }



                //Assigning Filing Status as Single if no filing status is selected.
                if (taxObject != null)
                {
                    //Get PrimaryTaxPayer  Nick / First Name.
                    if (taxObject.PersonalDetails != null)
                    {
                        if (taxObject.PersonalDetails.PrimaryTaxPayer != null)
                        {
                            //Get PrimaryTaxPayer FilingStatus.
                            filingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                            if (taxObject.PersonalDetails.PrimaryTaxPayer.Person != null)
                            {
                                primaryTaxPayerSSN = taxObject.PersonalDetails.PrimaryTaxPayer.Person.SSN;
                            }
                            if (taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly && taxObject.PersonalDetails.Spouse.Person != null)
                            {
                                spouseSSN = taxObject.PersonalDetails.Spouse.Person.SSN;
                            }
                        }
                        if (taxObject.ErrorMessages != null)
                        {
                            eicErrorList = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT
                                                                                    && (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V)).ToList();
                        }
                    }
                }

                // 09Jun2014 Sathish get tax payer name from common method in utilites
                taxPayerName = Utilities.GetTaxPayerFirstNameOrNickName(taxObject);

                //TODO: Saravanan N - 23rd April, 2014 - The ErrorMessage should be removed after workflow changes done. - START
                //Retrieving Error Message list from Database
                messageRepository = new MessagesRepository();
                //var errorMessage = messageRepository.GetErrorMessages();
                var errorMessage = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
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
                    totalNonQualifiedPlansAmount = output.NonQualifiedPlansAmount;
                    totaltaxableScholarshipAmount = output.TaxableScholarshipAmount;
                }

                //07Jul2014 Sathish called EIC work flow to check age limit for Primary and spouse tax payer for the defect #TAX1040-14069
                //messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EARNED_INCOME_CREDIT);
                taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT && (err.MessageType == Constants.MESSAGE_TYPE_EI));
                input.ErrorMessages = errorMessages;
                output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZEICEligibilityRuleCheck(), input));

                //Check ECI Eligiblity
                //30thJuly2014 - Added Condtions for checking Valid SSN for both taxpayer and Spouse
                //11August2014 Ashok Kumar modified EIC Eligibility Check based on EIC Information Error Messages
                //20August2014 Thileep Kumar modified Valid SSN on EIC Eligibility Check
                if (((filingStatus == FilingStatus.Single && annualGrossIncome <= Constants.EIC_SINGLE_ADJUSTED_GROSS_INCOME
                                                          && !taxObject.ErrorMessages.Any(err => err.ErrorCode == Constants.EIC_INFO_TAXPAYER_AGE_LIMIT
                                                              || err.ErrorCode == Constants.EIC_INFO_TAXPAYER_CLAIM_DEPENDENT)
                                                          && (!Utilities.IsStringEmpty(primaryTaxPayerSSN) && Utilities.IsValidSSNorITIN(primaryTaxPayerSSN))) ||
                    (filingStatus == FilingStatus.MarriedFilingJointly && annualGrossIncome <= Constants.EIC_MFJ_ADJUSTED_GROSS_INCOME
                                                           && !taxObject.ErrorMessages.Any(err => err.ErrorCode == Constants.EIC_INFO_TAXPAYER_AGE_LIMIT
                                                               || err.ErrorCode == Constants.EIC_INFO_TAXPAYER_SPOUSE_AGE_LIMIT
                                                               || err.ErrorCode == Constants.EIC_INFO_TAXPAYER_CLAIM_DEPENDENT
                                                               || err.ErrorCode == Constants.EIC_INFO_TAXPAYER_SPOUSE_CLAIM_DEPENDENT)
                                                           && (!Utilities.IsStringEmpty(primaryTaxPayerSSN) && Utilities.IsValidSSNorITIN(primaryTaxPayerSSN))
                                                           && (!Utilities.IsStringEmpty(spouseSSN) && Utilities.IsValidSSNorITIN(spouseSSN)))) 
                                                           && totalW2Wages > 0 && !taxObject.ErrorMessages.Any(err => err.ErrorCode == Constants.EIC_INFO_TAXPAYER_INVESTMENT_INCOME_LIMIT))
                {
                    isEicEligible = true;
                }
                else
                {
                    //Vincent - 25 Jun 2014 - Defect 14034 - IF EIC Credits fails then in EIC objects should be cleared.
                    //if (taxObject != null && taxObject.UserDataId != 0)
                    if (taxObject != null)
                    {
                        //If EIC eligbility fails in AGI calculation, Taxobject's EIC object should be cleared while loading this page.
                        //if (taxObject.Credits != null && taxObject.Credits.EIC != null)
                        //{
                        //    taxObject.Credits.EIC = null;
                        //}

                        //If EIC eligbility fails in AGI calculation, worksheet EIC object should be cleared in output form while loading this page.
                        if (taxObject.F1040EZ != null && taxObject.F1040EZ.F1040EZWorkSheets != null)
                        {
                            taxObject.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired = false;
                            if (taxObject.F1040EZ.F1040EZWorkSheets.EICWorkSheet != null)
                            {
                                taxObject.F1040EZ.F1040EZWorkSheets.EICWorkSheet = null;
                            }
                        }
                        //14thJuly2014 Ashok - Added for Clearing Form 8862 class and setting IsForm8862Required false when failing EIC eligibility                       
                        if (taxObject.Income != null)
                        {
                            taxObject.Income.IsForm8862Required = false;
                            if (taxObject.Income.Form8862 != null)
                            {
                                taxObject.Income.Form8862 = null;
                            }
                        }
                        //30July2014-Thileep Added to Get EligiblityInformation Messages in Credit Section
                        if (taxObject.ErrorMessages != null)
                        {
                            taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT &&
                                                             (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V ||
                                                              err.MessageType == Constants.MESSAGE_TYPE_BR));
                            taxObjectErrorList = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT && err.MessageType == Constants.MESSAGE_TYPE_EI);
                            eicErrorList = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT
                                                                                     && (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V)).ToList();
                        }
                    }
                }
                Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);
                Tuple<double, double, IEnumerable<ErrorMessage>> wagesNonQualifiedAndTaxableScholarshipAmount =
                   new Tuple<double, double, IEnumerable<ErrorMessage>>(totalNonQualifiedPlansAmount, totaltaxableScholarshipAmount, eicErrorList);
                return new Tuple<EIC,
                    string,
                    bool,
                    IEnumerable<ErrorMessage>,
                    long, FilingStatus,
                    Tuple<double, double, IEnumerable<ErrorMessage>>>(
                   ((taxObject != null && taxObject.Credits != null && taxObject.Credits.EIC != null) ? taxObject.Credits.EIC : null),
                    taxPayerName,
                    isEicEligible,
                    taxObjectErrorList,
                    userDTO.UserDataId,
                    filingStatus,
                    wagesNonQualifiedAndTaxableScholarshipAmount);

                //Vincent, 2-sep-14, Persist Audit information
                string description = "Get EarnedIncomeCredit, ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.Tab_EARNED_INCOME_CREDITS, Constants.TOPIC_EARNED_INCOME_CREDIT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool GetHasEarnedIncomeCredits(UserDTO userDTO)
        {
            bool hasEarnedIncomeCredits = false;
            try
            {
                BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
               if (taxObject != null && taxObject.Credits != null && taxObject.Credits.HasEarnedIncomeCredits.HasValue)
                   hasEarnedIncomeCredits = taxObject.Credits.HasEarnedIncomeCredits.Value;

               //Vincent, 2-sep-14, Persist Audit information
               string description = "Has EarnedIncomeCredits, ClassName: {0}, Method Name: {1}";
               Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.Tab_EARNED_INCOME_CREDITS, Constants.TOPIC_EARNED_INCOME_CREDIT);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:W2Repository,Method Name:GetHasEarnedIncomeCredits", ex);
            }

            return hasEarnedIncomeCredits;

        }

        /// <summary>
        /// Persist EIC
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <param name="eicData"></param>
        /// <returns></returns>
        public long PersitEarnedIncomeCredit(long userId, TaxReturnData taxReturnData, int year)
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
                    //var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessage = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
                    var errorMessages = new ErrorMessages(errorMessage);

                    // Clear the Error messages
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EARNED_INCOME_CREDIT);

                    BusinessValidation(taxObject.Credits.EIC, taxObject.ErrorMessages, errorMessages, year, (taxObject != null && taxObject.PersonalDetails != null &&
                        taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                        taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus != null ? taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus : FilingStatus.None));

                    //Invoking Business Rules Validation Workflow
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;

                    //Getting the AGI value from output forms porperty.
                    //25Jun2014 Sathish called AGI work flow with no validation to avoid error message update for the defect #TAX1040-14036
                    var outputGetData = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZAdjustedGrossIncomeWithNoValidation(), input));

                    //30thJune2014 Ashok added for Form 8862 Pdf Binding
                    if (taxObject != null && taxObject.Credits != null && taxObject.Credits.EIC != null)
                    {
                        if (taxObject.Income == null)
                        {
                            taxObject.Income = new Income();
                        }
                        if (taxObject.Income.Form8862 == null)
                        {
                            taxObject.Income.Form8862 = new Form8862();
                        }

                        if (taxObject.Credits.EIC.HasClaimedAsQualifyingChild.HasValue)
                            taxObject.Income.Form8862.HasClaimedAsQualifyingChild = taxObject.Credits.EIC.HasClaimedAsQualifyingChild.Value;
                        else
                            taxObject.Income.Form8862.HasClaimedAsQualifyingChild = false;

                        if (taxObject.Credits.EIC.HasIncorrectlyReportedEarnedIncome.HasValue)
                            taxObject.Income.Form8862.HasReportedIncorrectIncome = taxObject.Credits.EIC.HasIncorrectlyReportedEarnedIncome.Value;
                        else
                            taxObject.Income.Form8862.HasReportedIncorrectIncome = false;

                        // 01Jul2014 Sathish checked nullable value and set zero
                        taxObject.Income.Form8862.DaysLivedInUS = (taxObject.Credits.EIC.NumberOfDaysTaxPayerLivedInUS.HasValue) ? taxObject.Credits.EIC.NumberOfDaysTaxPayerLivedInUS.Value : 0;
                        taxObject.Income.Form8862.DaysSpouseLivedInUS = (taxObject.Credits.EIC.NumberOfDaysSpouseLivedInUS.HasValue) ? taxObject.Credits.EIC.NumberOfDaysSpouseLivedInUS.Value : 0;
                        taxObject.Income.Form8862.FormFilingTaxYear = 2013;
                        taxObject.Income.IsForm8862Required = true;
                    }

                    input.ErrorMessages = errorMessages;
                    //Checking EIC Eligibility check
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZEICEligibilityRuleCheck(), input));


                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME);
                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_REQUIRED_REFUND_DETAIL);
                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_MISSING_INCOME);
                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.OTHERINCOME_TAXABLE_SOCIAL_SECURITY_AND_RAILROAD_BENEFITS);

                    dynamic federalSummaryInput = new Microsoft.Activities.Extensions.WorkflowArguments();
                    federalSummaryInput.Tax1040Object = taxObject;                   
                    federalSummaryInput.IsRefundAvailableCheck = true;
                    federalSummaryInput.IsIncomeAndRefundAllZeros = true;
                    //25 Aug 2014-Vincent- Added the SSB and RRB check in FederalSummaryWithNoValidation
                    federalSummaryInput.IsSSBAndRRBCheck = true;
                    federalSummaryInput.ErrorMessages = errorMessages;
                    output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                             WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), federalSummaryInput));

                    //Persist TaxObject.
                    taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);

                    //Vincent, 2-sep-14, Persist Audit information
                    string description = "Persit EarnedIncomeCredit, ClassName: {0}, Method Name: {1}";
                    Utilities.PersistAuditInfo(userId, taxReturnData.UserDataId, description, this.GetType().Name, Constants.Tab_EARNED_INCOME_CREDITS, Constants.TOPIC_EARNED_INCOME_CREDIT);

                }

                return taxReturnData.UserDataId;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //10thjuly2014 Thileep Added for getting No of days in a year 
        public static int GetDaysInYear(int year)
        {
            var thisYear = new DateTime(year, 1, 1);
            var nextYear = new DateTime(year + 1, 1, 1);

            return (nextYear - thisYear).Days;
        }

        /// <summary>
        /// Business Fields Validations (Required and Validation) checked.
        /// </summary>
        /// <param name="eic"></param>
        /// <param name="errorMessageList"></param>
        /// <param name="errorMessages"></param>
        public void BusinessValidation(EIC eic, List<ErrorMessage> errorMessageList,
           ErrorMessages errorMessages, int year, FilingStatus filingStatus)
        {
            ErrorMessage errorMessage;

            if (eic != null)
            {
                ////Required Entry #1
                //if (eic.HasTaxableScholarshipCredits != null && eic.HasTaxableScholarshipCredits == true)
                //{
                //    errorMessage =
                //   BusinessValidationRepository.AssertIsNotNull(eic.TaxableScholarshipCredit,
                //       Constants.EIC_TAXABLE_FELLOWSHIP_INCOME, errorMessages);
                //    if (errorMessage != null)
                //        errorMessageList.Add(errorMessage);
                //}

                ////Required Entry #2
                //if (eic.HasPensionAnnuity != null && eic.HasPensionAnnuity == true)
                //{
                //    errorMessage =
                //   BusinessValidationRepository.AssertIsNotNull(eic.PensionAnnuity,
                //       Constants.EIC_PENSION_OR_ANNUITY_NOT_QUALIFIED_COMPENSATION, errorMessages);
                //    if (errorMessage != null)
                //        errorMessageList.Add(errorMessage);
                //}

                //Required Entry #3
                if (eic.HasPenalInstitutionInmateWages != null && eic.HasPenalInstitutionInmateWages == true)
                {
                    errorMessage =
                   BusinessValidationRepository.AssertIsNotNull(eic.PenalInstitutionInmateWages,
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
                    int noOfDaysInTaxYear = GetDaysInYear(year);

                    if (filingStatus != null)
                    {
                        if (filingStatus == FilingStatus.Single)
                        {
                            errorMessage =
                         BusinessValidationRepository.AssertIsNotNull(eic.NumberOfDaysTaxPayerLivedInUS,
                             Constants.EIC_NUMBER_OF_DAYS_TaxPayer_LIVED_IN_US, errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);

                            else
                            {
                              //07Aug2014-Validation Changed for Number Of Days 
                                 errorMessage =
                             BusinessValidationRepository.AssertIsWithinRange(Utilities.ConvertToInteger32(eic.NumberOfDaysTaxPayerLivedInUS), 1, noOfDaysInTaxYear,
                               Constants.EIC_NUMBER_OF_DAYS_TAXPAYER_LIVED_IN_US_VALID, errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);

                                
                            }

                        }
                        if (filingStatus == FilingStatus.MarriedFilingJointly)
                        {
                            errorMessage =
                          BusinessValidationRepository.AssertIsNotNull(eic.NumberOfDaysTaxPayerLivedInUS,
                              Constants.EIC_NUMBER_OF_DAYS_TaxPayer_LIVED_IN_US, errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);

                            else
                            {
                                errorMessage =
                              BusinessValidationRepository.AssertIsWithinRange(Utilities.ConvertToInteger32(eic.NumberOfDaysTaxPayerLivedInUS), 1, noOfDaysInTaxYear,
                               Constants.EIC_NUMBER_OF_DAYS_TAXPAYER_LIVED_IN_US_VALID, errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }

                            //Spouse Lived in US

                            errorMessage =
                         BusinessValidationRepository.AssertIsNotNull(eic.NumberOfDaysSpouseLivedInUS,
                             Constants.EIC_NUMBER_OF_DAYS_SPOUSE_LIVED_IN_US, errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);


                            else
                            {
                                errorMessage =
                            BusinessValidationRepository.AssertIsWithinRange(Utilities.ConvertToInteger32(eic.NumberOfDaysSpouseLivedInUS), 1, noOfDaysInTaxYear,
                             Constants.EIC_NUMBER_OF_DAYS_SPOUSE_LIVED_IN_US_VALID, errorMessages);
                                if (errorMessage != null)
                                    errorMessageList.Add(errorMessage);
                            }
                        }
                    }
                }


                //Waring Rules
                //This Business rule is related to Form 8862
                if (eic.HasReceivedIRSNoticeOnFiling8862 == true && eic.HasEICForPriorYearDisallowance == false)
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
                    // 16Jul2014 Sathish commented the above code and checked EIC eligibility using work flow
                    dynamic EICEligibilityCheck = new Microsoft.Activities.Extensions.WorkflowArguments();
                    EICEligibilityCheck.Tax1040Object = taxObject;
                    Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZEICEligibilityRuleCheckForSummary(), EICEligibilityCheck));

                    Utilities.EICEligibilityCheck(taxObject);
                    //if (lstErrorMessages != null && lstErrorMessages.ToList().Count <= 0) // 16Jul2014 Sathish EIC Eligibility fails if no error count
                    if (taxObject.Credits != null && taxObject.Credits.HasEarnedIncomeCredits.HasValue && taxObject.Credits.HasEarnedIncomeCredits.Value) // 16Jul2014 Sathish checked eic eligibility based on EIC TODO: Need to check EIC elgibility based on the flag
                    {
                        EICEligibility = taxObject.Credits.HasEarnedIncomeCredits.Value;

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
                        //if (taxObject != null && taxObject.F1040EZ != null && taxObject.F1040EZ.F1040EZWorkSheets != null &&
                        //    taxObject.F1040EZ.F1040EZWorkSheets.EICWorkSheet != null)
                        //{
                        //    taxObject.F1040EZ.F1040EZWorkSheets.EICWorkSheet = null;
                        //    if (userDTO.UserDataId != 0)
                        //    {
                        //        Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);
                        //    }
                        //}
                        if (taxObject != null && taxObject.F1040EZ != null && taxObject.F1040EZ.F1040EZWorkSheets != null)
                        {
                            taxObject.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired = false;
                            if (taxObject.F1040EZ.F1040EZWorkSheets.EICWorkSheet != null)
                            {
                                taxObject.F1040EZ.F1040EZWorkSheets.EICWorkSheet = null;
                            }

                        }
                    }
                    if (userDTO.UserDataId != 0)
                    {
                        Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);
                    }
                    //Vincent-17Jun2014-Getting required field validation and Warning error message.
                    //Sathish 30Jun2014 Shown all the error message in the summary including summary and diagnotics as suggested by praveen
                    //Praveen 17 July 2014 Error Message displayed based on Error Type(Properly Shuffled)
                    creditSummaryData.ErrorMessages = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT).OrderBy(x => x.ErrorType);
                    //EIC Eligibility check data.
                    creditSummaryData.EICEligibility = EICEligibility;
                }

                //Vincent, 2-sep-14, Persist Audit information
                string description = "Get Credit Summary, ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.Tab_EARNED_INCOME_CREDITS, Constants.TOPIC_EARNED_INCOME_CREDIT);

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
