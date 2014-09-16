/*
Copyright   : Copyright Jeevan Technologies
File Name   : W2Repository.cs 
Description : Business Logic for W2 Tax Return  
Author      : Bala
Created Date : 23 Apr 2014

 * Modification History:
-------------------------
 * 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.  
 * 02May2014 Bala Modified code to clear the error messages from error message list. 
 * 28Apr2014 Sathish Added TaxReturnData for PersistW2Data 
 * Saravanan N - 13th May, 2014 1) GetW2Data(UserDTO userDTO). New method GetEmployeeCode() refactored from Controller class.
 *                              2) Obtained TaxObject in GET methods using Utilities class.
 * 13May2014 Vincent added a workflow method for Getting Total Wages amount.
 * 14May2014-Vincent-Eligibility check for Hard stopper.
 * 14May2014-Vincent-Added Required field entry as per Logeshwari email Discussion.  
 * 15May2014-Vincent-Made a changes in business rule validation.
 * 16May2014-Vincent-Made a null or Empty check for String.
 * 16May2014-Vincent-Added a required field for EIN
 * 16May2014-Vincent-Made changes a null or Empty check for String.
 * 16May2014-Vincent-Made changes to State method
 * 02Jun2014 Sathish added required field validation and validation
 * 04.06.2014 Thileep Added Social Security Wages Validation  
 * 05Jun2014 Sathish added optional parameter taxobject used in delete spouse info while changing filling status MFJ to single
 * 24Jun2014-Vincent-Added a Null For the Amount section in Employer Code
 * 10Jul2014 Sathish changed references of state id/ country id to refer state/country 
 * 14July2014 Thileepkumar U - Changed the Business validation for State & Local information and localTaxInfo fields as per Income Spec V2.3
 * 14thJuly2014 Ashok - Added logic for Clearing EIC Worksheet, Form 8862 and EIC classes when failing EIC eligibility
 * 23 July 2014 Bhavani - Removed unused varibles like wagesAmount, annualGrossIncome, totalW2Wages, filingStatus
 * 19Aug2014-Thileep changed and added code in All persist methods for Taxableincomecheck,Refundoptioncheck and (Income,Refund,Taxes all are Zeros check)
 * 21Aug2014 - Ashok Kumar added EIC eligibility check along with Taxable Income Eligibility check using Workflow
 * 02 Sep 2014 Bhavani Audit functionality Implementation.
 * 02Sep2014-  Thileep Changed Persist methods to Remove EIC Error messages on Eligibility fails
 */

using System;
using System.Runtime.CompilerServices;
using Tax1040WorkFlow.WorkFlow.Activities;
using System.Activities;
using Newtonsoft.Json;
using System.Collections.Generic;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;
using System.Linq;
using System.Dynamic;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;
using JTL.Tax1040.DataAccess;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities;
using System.Web;

namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Business class for W2 Tax Return Data
    /// </summary>
    public class W2Repository : IW2Repository
    {
        private readonly MessagesRepository messageRepository;
        IPersonalInfoDataService personalInfoDataService;

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="W2Repository"/> class.
        /// </summary>
        public W2Repository()
        {
            personalInfoDataService = new PersonalInfoDataService();
            messageRepository = new MessagesRepository();
        }
        #endregion

        #region W2 Persist

        /// <summary>
        /// Persists the W2 tax return data.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="sessionData">The session data.</param>
        /// <param name="taxData">The tax data.</param>
        /// <param name="historyData">The history data.</param>
        /// <param name="userDataId">The user data identifier.</param>
        /// <param name="errorMessageList">The error message list.</param>
        /// <returns></returns>
        public dynamic PersistW2TaxReturnData(long userId, TaxReturnData taxReturnData)
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            W2 w2 = null;
            dynamic userData = new ExpandoObject();
            
            try
            {
                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);

                //Creating Instance if Tax1040 is Null
                if (taxObject == null)
                {
                    taxObject = new BusinessObject.Tax1040();
                }

                //Set Default filing status as Single if no filing status is selected
                Utilities.SetDefaultFilingStatus(taxObject);

                w2 = PersistW2Data(taxReturnData.TaxData, taxObject, userId, taxReturnData.UserDataId);

                if (taxObject.ErrorMessages == null)
                {
                    taxObject.ErrorMessages = new List<ErrorMessage>();
                }
                //Initializing Out Parameter
                List<ErrorMessage> errorMessageList = new List<ErrorMessage>();

                // Clear the Error messages exist for this topic.
                messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_WAGES);

                //Obtain the List of Error Messages from DB.
                //var errorMessagesFromDB = messageRepository.GetErrorMessages();
                var errorMessagesFromDB = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
                var errorMessagesAll = new ErrorMessages(errorMessagesFromDB);

                //Call to Required and Validations Server side Validation check.
                if (taxObject.Income.W2Wages != null)
                {
                    BusinessFieldValidations(taxObject.Income.W2Wages, taxObject.ErrorMessages, errorMessagesAll);
                }

                // Clear the Error messages
                //messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EARNED_INCOME_CREDIT);
                //02Sep2014-Thileep Changed code to Remove EIC errormessages which has Message Type EI only
                taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT && (err.MessageType == Constants.MESSAGE_TYPE_EI));


                //14thJuly2014 Ashok - Added logic for Clearing EIC Worksheet, Form 8862 and EIC classes when failing EIC eligibility
                //Workflow Validation check.
                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;
                input.ErrorMessages = errorMessagesAll;
                //Check if EIC with espect to AGI
                var output = AGICheck(taxObject, input);

                //02Sep2014-  Thileep added  to Remove EIC Error messages when EIC Eligibility fails
                if (!output.HasEarnedIncomeCredit)
                {
                    taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT &&
                        (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V || err.MessageType == Constants.MESSAGE_TYPE_BR));

                }

                //Assisn error message list into workflow input param.
                input.ErrorMessages = errorMessagesAll;

                //Call to Business validation workflow to obtain Business Validation error messages.
                output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new FW2BusinessRuleValidation(), input));
                taxReturnData.TaxData = JsonConvert.SerializeObject(w2);



                //10Jul2014 Sathish added coded to check Taxable Income Eligibility, unable to remove error message in work flow
                taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME);

                taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_REQUIRED_REFUND_DETAIL);
                taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_MISSING_INCOME);
                taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.OTHERINCOME_TAXABLE_SOCIAL_SECURITY_AND_RAILROAD_BENEFITS);

               // var taxableIncome = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZTaxableIncomeEligibilityCheck(), input));
                dynamic federalSummaryInput = new Microsoft.Activities.Extensions.WorkflowArguments();
                federalSummaryInput.Tax1040Object = taxObject;
                federalSummaryInput.IsTaxableIncomeExceedCheck = true;
                federalSummaryInput.IsRefundAvailableCheck = true;
                federalSummaryInput.IsIncomeAndRefundAllZeros = true;
                //25 Aug 2014-Vincent- Added the SSB and RRB check in FederalSummaryWithNoValidation
                federalSummaryInput.IsSSBAndRRBCheck = true;
                federalSummaryInput.ErrorMessages = errorMessagesAll;
                output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                         WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), federalSummaryInput));

                //Hard Stopper Check

                var isEligibilityCheckFailed = taxObject.ErrorMessages.Any(errMsg => errMsg.Topic ==
                    Constants.TOPIC_WAGES && errMsg.ErrorCode.Contains("Wages_ER"));


                if (taxObject != null)
                {
                    //taxRetrunData.UserDataId = taxReturnDataService.PersistTaxReturnData(userId, taxData, Utilities.ConvertTaxObjectToJSON(taxObject), taxData, userDataId);
                    taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);

                    //Assigning values to Out parameter
                    if (taxObject.ErrorMessages != null)
                    {
                        errorMessageList = taxObject.ErrorMessages;
                    }
                }

                userData.W2Id = w2.W2Id;
                userData.UserDataId = taxReturnData.UserDataId;
                userData.isEligibilityCheckFailed = isEligibilityCheckFailed;
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:W2Repository,Method Name:PersistW2TaxReturnData", ex);

            }
            return userData;

        }


        //14thJuly2014 Ashok - Added method for Clearing EIC Worksheet, Form 8862 and EIC classes when failing EIC eligibility
        private dynamic AGICheck(JTL.Tax1040.BusinessObject.Tax1040 taxObject, dynamic input)
        {
            //21Aug2014 - Ashok Kumar added EIC eligibility check workflow instead of without validation worklfow
            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZEICEligibilityRuleCheck(), input));

            Utilities.EICEligibilityCheck(taxObject);
            return output;
        }


        #endregion

        #region Get W2
        //Saravanan N - 13th May, 2014 - UserDTO param added.
        /// <summary>
        /// Get the W2 data.
        /// </summary>
        /// <param name="userDataId">The user data id.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="w2Id">The w2 id.</param>
        /// <returns></returns>
        public System.Tuple<W2, dynamic> GetW2Data(UserDTO userDTO)
        {
            Tuple<W2, dynamic> taxReutrnData = null;
            List<ErrorMessage> w2ErrorList = new List<ErrorMessage>();
            long w2Id = 0;
            try
            {
                var taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                List<W2> w2ListObject = null;
                PersonalDetails personalDetails = null;

                if (taxObject != null)
                {
                    if (taxObject.Income != null)
                        w2ListObject = taxObject.Income.W2Wages;

                    personalDetails = taxObject.PersonalDetails;
                }

                dynamic taxReturnPersonData = new ExpandoObject();
                if (personalDetails != null)
                {
                    if (personalDetails.PrimaryTaxPayer != null)
                    {
                        taxReturnPersonData.FilingStatus = personalDetails.PrimaryTaxPayer.FilingStatus;
                        if (personalDetails.PrimaryTaxPayer.Person != null)
                            taxReturnPersonData.PrimaryTaxPayerFirstName = personalDetails.PrimaryTaxPayer.Person.FirstName;
                    }
                    if (personalDetails.Spouse != null && personalDetails.Spouse.Person != null)
                    {
                        taxReturnPersonData.SpouseFirstName = personalDetails.Spouse.Person.FirstName;
                    }
                }
                //vivek - 6-Aug-14 -Added the error message list for the error message focus 
                if (taxObject.ErrorMessages != null)
                {
                    w2ErrorList = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_WAGES
                                                                                     && (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V)).ToList();
                }
                taxReturnPersonData.errorlist = w2ErrorList;
                if (w2ListObject != null && w2ListObject.Any())
                {
                    //Saravanan N - 13th May, 2014 - Id used from UserDTO.
                    int index = w2ListObject.FindIndex(wages => wages.W2Id == userDTO.FormId);

                    if (index >= 0)
                    {
                        taxReutrnData = new System.Tuple<W2, dynamic>(w2ListObject[index], taxReturnPersonData);
                        w2Id = userDTO.FormId;
                    }
                    else
                    {
                        taxReutrnData = new System.Tuple<W2, dynamic>(null, taxReturnPersonData);
                        w2Id = 0;
                    }
                }
                else
                {
                    taxReutrnData = new System.Tuple<W2, dynamic>(null, taxReturnPersonData);
                    w2Id = 0;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:W2Repository,Method Name:GetW2Data", ex);
            }

            //02-Sep-2014 Bhavani Audit functionality implementation
            var description = "Get Wages: "+ w2Id +", ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.Tab_INCOME, Constants.TOPIC_WAGES);
            return taxReutrnData;
        }

        /// <summary>
        /// Get the W2 list, corresponding error list and Taxpayer and spouse name.
        /// </summary>
        /// <param name="userDataId">The user data id.</param>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        public System.Tuple<List<W2>, IEnumerable<ErrorMessage>, dynamic> GetW2ListandErrorList(UserDTO userDTO)
        {
            List<W2> w2ListObject = null;
            IEnumerable<ErrorMessage> taxObjectErrorList = null;
            PersonalDetails personalDetails = null;
            dynamic personData = new ExpandoObject();

            try
            {
                var taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong());

                if (taxObject != null)
                {
                    if (taxObject.Income != null && taxObject.Income.W2Wages != null)
                    {
                        w2ListObject = taxObject.Income.W2Wages;
                    }

                    if (taxObject.PersonalDetails != null)
                    {
                        personalDetails = taxObject.PersonalDetails;
                    }
                }

                personData.PrimaryTaxPayerName = "Primary TaxPayer";
                personData.SpouseName = "Spouse";

                if (personalDetails != null)
                {
                    if (personalDetails.PrimaryTaxPayer != null && personalDetails.PrimaryTaxPayer.Person != null)
                    {
                        personData.PrimaryTaxPayerName = personalDetails.PrimaryTaxPayer.Person.FirstName + " " + personalDetails.PrimaryTaxPayer.Person.LastName;
                    }
                    if (personalDetails.Spouse != null && personalDetails.Spouse.Person != null)
                    {
                        personData.SpouseName = personalDetails.Spouse.Person.FirstName + " " + personalDetails.Spouse.Person.LastName;
                    }
                }

                var taxW2Object = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                //Getting Total Wages amount
                if (taxW2Object != null)
                {
                    if ((taxW2Object.Income != null) && (taxW2Object.Income.W2Wages != null))
                    {
                        dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                        input.Tax1040Object = taxObject;
                        var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new W2WithNoValidation(), input));
                        personData.TotalWages = output.TotalWages;
                    }
                }

                //Saravanan N - 15th May, 2014 - Get ErrorMessage if exists.
                if (taxObject.ErrorMessages != null)
                {
                    //If ErrorMessages doesn't have any object it returns count as 1 for NULL object. So removing this NULL object from the list.
                    taxObject.ErrorMessages.RemoveAll(err => err == null);

                    if (taxObject.ErrorMessages.Count > 0)
                    {
                        //Get Unemployment Compensation related error messages.
                        //Praveen 17 July 2014 Error Message displayed based on Error Type(Properly Shuffled)
                        taxObjectErrorList = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_WAGES).OrderBy(x => x.ErrorType);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:W2Repository,Method Name:GetW2ListandErrorList", ex);
            }

            //02-Sep-2014 Bhavani Audit functionality implementation
            var description = "Get Wages list: "+userDTO.FormId +", ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.Tab_INCOME, Constants.TOPIC_WAGES);

            return new System.Tuple<List<W2>, IEnumerable<ErrorMessage>, dynamic>(w2ListObject, taxObjectErrorList, personData);
        }

        /// <summary>
        /// Delete and persist W2
        /// </summary>
        /// <param name="userId">The User ID</param>
        /// <param name="w2Id">The W2 id</param>
        /// <param name="userDataId">The User Data ID</param>
        /// <param name="errorMessageList">The Error Message List</param>
        public void DeleteAndPersistW2(UserDTO userDTO, Tax1040.BusinessObject.Tax1040 refTaxObject = null) // 05Jun2014 Sathish added optional parameter taxobject used in delete spouse info while changing filling status MFJ to single
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            try
            {
                // 05Jun2014 Sathish check optional parameter which is used in deleting spouse info
                //Retrieving TaxObject from database
                if (refTaxObject == null)
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                else
                    taxObject = refTaxObject;

                //Converting Json to Form1099G by DeSerializing
                if (taxObject != null && taxObject.Income != null && taxObject.Income.W2Wages != null)
                {
                    int index = taxObject.Income.W2Wages.FindIndex(w2 => w2.W2Id == userDTO.FormId);

                    if (index >= 0)
                    {
                        //Delete the current W2 object.
                        taxObject.Income.W2Wages.RemoveAt(index);

                        // Clear the Error messages
                        messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_WAGES, userDTO.FormId);
                    }

                    //Obtain the List of Error Messages from DB.
                    //var errorMessagesFromDB = messageRepository.GetErrorMessages();
                    var errorMessagesFromDB = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
                    var errorMessagesAll = new ErrorMessages(errorMessagesFromDB);
                    //Assisn error message list into workflow input param.
                  

                    //messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EARNED_INCOME_CREDIT);

                    //02Sep2014-Thileep Changed code to Remove EIC errormessages which has Message Type EI only
                    taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT && (err.MessageType == Constants.MESSAGE_TYPE_EI));

                    //10Jul2014 Sathish added coded to check Taxable Income Eligibility 
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    input.ErrorMessages = errorMessagesAll;
                    //14thJuly2014 Ashok - Added logic for Clearing EIC Worksheet, Form 8862 and EIC classes when failing EIC eligibility
                    var output = AGICheck(taxObject, input);

                    

                    input.ErrorMessages = errorMessagesAll;
                    //commented by ashok - FederalSummarywithNoValidation is called instead to check taxable income eligibility
                    //taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME);
                    //var taxableIncome = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke
                    //    (new F1040EZTaxableIncomeEligibilityCheck(), input));

                    //25 Aug 2014-Vincent- Federal work flow Summary check was missed in Delete W2
                    //10Jul2014 Sathish added coded to check Taxable Income Eligibility 
                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME);

                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_REQUIRED_REFUND_DETAIL);
                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.TAX_AND_WRAP_UP_MISSING_INCOME);
                    taxObject.ErrorMessages.RemoveAll(em => em.ErrorCode == Constants.OTHERINCOME_TAXABLE_SOCIAL_SECURITY_AND_RAILROAD_BENEFITS);

                    // var taxableIncome = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZTaxableIncomeEligibilityCheck(), input));
                    dynamic federalSummaryInput = new Microsoft.Activities.Extensions.WorkflowArguments();
                    federalSummaryInput.Tax1040Object = taxObject;
                    federalSummaryInput.IsTaxableIncomeExceedCheck = true;
                    federalSummaryInput.IsRefundAvailableCheck = true;
                    federalSummaryInput.IsIncomeAndRefundAllZeros = true;
                    //25 Aug 2014-Vincent- Added the SSB and RRB check in FederalSummaryWithNoValidation
                    federalSummaryInput.IsSSBAndRRBCheck = true;
                    federalSummaryInput.ErrorMessages = errorMessagesAll;
                    output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                             WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), federalSummaryInput));

                    //Added by Ashok for EIC Eligibility Check

                    // Clear the Error messages
                    //messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EARNED_INCOME_CREDIT);

                    //03Sep2014-Thileep Changed code to Remove EIC errormessages which has Message Type EI only
                    taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT && (err.MessageType == Constants.MESSAGE_TYPE_EI));                    

                    dynamic eicEligbilityInput = new Microsoft.Activities.Extensions.WorkflowArguments();
                    eicEligbilityInput.Tax1040Object = taxObject;
                    eicEligbilityInput.ErrorMessages = errorMessagesAll;
                    //Check if EIC with espect to AGI
                    output = AGICheck(taxObject, input);

                    //02Sep2014-  Thileep added  to Remove EIC Error messages when EIC Eligibility fails
                    if (!output.HasEarnedIncomeCredit)
                    {
                        taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT &&
                            (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V || err.MessageType == Constants.MESSAGE_TYPE_BR));

                    }

                    //Persist latest TaxObject.
                    Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);

                    //02-Sep-2014 Bhavani Audit functionality implementation
                    var description = "Delete wages: " +userDTO.FormId+ ", ClassName: {0}, Method Name: {1}";
                    Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.Tab_INCOME, Constants.TOPIC_WAGES);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:W2Repository,Method Name:DeleteAndPersistW2", ex);
            }
        }
        #endregion

        #region Validation
        /// <summary>
        /// The Business Validation for W2 wages.
        /// </summary>
        /// <param name="lstW2Wages">The income object.</param>
        /// <param name="errorMessageListInTaxObject">The error message list.</param>
        /// <param name="errorMessagesAllFromDB">The errorMessages.</param>
        private void BusinessFieldValidations(List<W2> lstW2Wages, List<ErrorMessage> errorMessageListInTaxObject, ErrorMessages errorMessagesAllFromDB)
        {
            ErrorMessage errorMessage;
            var isValid = false;

            foreach (var wages in lstW2Wages)
            {
                if (wages != null)
                {
                    //Variable declaration
                    var w2Id = wages.W2Id;
                    //Yogalakshmi - 3rd Sep 2014 - Added RF1
                    if (wages.OwnerType == OwnerType.None)
                    {
                        //Required Entry #1
                        errorMessage = errorMessagesAllFromDB[Constants.WAGES_TAX_PAYER_OR_SPOUSE_CODE];
                        //assign the error message from resource file
                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                    }
                    //Required and Validations.
                    if (wages.EmploymentType != EmploymentType.HouseholdEmployeeWages &&
                        wages.EmploymentType != EmploymentType.TaxableScholarshipIncome && wages.EmploymentType != EmploymentType.ForeignEmployment)
                    {
                        if (wages.Employer != null && wages.Employer.Organization != null)
                        {

                            //Required entry #3
                            errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.EIN,
                                    Constants.WAGES_EIN, errorMessagesAllFromDB);
                            //Add Error Messages into TaxObject with current Form Id.
                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                            //EIN Validation Entry #1
                            string eIN = wages.Employer.Organization.EIN;
                            eIN = Utilities.RemoveUnderscore(eIN);
                            eIN = Utilities.RemoveHiphen(eIN);
                            if (eIN.Length > Constants.intZero)
                            {
                                bool IsNumeric = Utilities.IsNumeric(eIN);
                                isValid = Utilities.IsValidRegexPattern(wages.Employer.Organization.EIN, @"[0-9\-]{10}");
                                if (!isValid || !IsNumeric || eIN == Constants.NineZeros || eIN == Constants.NineNines)
                                {
                                    errorMessage = errorMessagesAllFromDB[Constants.WAGES_EMPLOYER_EIN_INVALID];
                                    //assign the error message from resource file
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }
                            }


                            //Required entry #4
                            errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Name,
                                      Constants.WAGES_EMPLOYER_NAME, errorMessagesAllFromDB);
                            //Add Error Messages into TaxObject with current Form Id.
                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                            if (!string.IsNullOrEmpty(wages.Employer.Organization.Name))
                            {
                                //Validation entry #2
                                errorMessage = BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(wages.Employer.Organization.Name,
                                    Constants.WAGES_EMPLOYER_NAME_ALPHABET, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                            }

                            if (wages.Employer.Organization.Address != null &&
                                wages.Employer.Organization.Address.CompanyAddress != null)
                            {
                                //Required entry #5
                                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.StreetAddress,
                                  Constants.WAGES_EMPLOYER_ADDRESS, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                if (!string.IsNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.StreetAddress))
                                {
                                    //Validation entry #3
                                    errorMessage = BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(wages.Employer.Organization.Address.CompanyAddress.StreetAddress,
                                        Constants.WAGES_EMPLOYER_ADDRESS_ALPHABET, errorMessagesAllFromDB);
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }

                                //Required entry #6
                                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.City,
                                        Constants.WAGES_EMPLOYER_CITY, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                if (!string.IsNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.City))
                                {
                                    //Validation entry #4
                                    errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(wages.Employer.Organization.Address.CompanyAddress.City,
                                            Constants.WAGES_EMPLOYER_CITY_ALPHABET, errorMessagesAllFromDB);
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                    //Yogalakshmi - 6th Aug 2014 - Validation #7 gives error when the City character length is less than 3.
                                    if (wages.Employer.Organization.Address.CompanyAddress.City.Trim().Length < 3)
                                    {
                                        errorMessage = errorMessagesAllFromDB[Constants.WAGES_EMPLOYER_CITY_VALIDATION];
                                        //assign the error message from resource file
                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                    }
                                }

                                //Required entry #7
                                errorMessage = BusinessValidationRepository.AssertIsNotNull(wages.Employer.Organization.Address.CompanyAddress.State,
                                                Constants.WAGES_EMPLOYER_STATE, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                if (errorMessage == null) //10Jul2014 Sathish changed to new state bo
                                {
                                    errorMessage = BusinessValidationRepository.AssertGreaterThanZero(wages.Employer.Organization.Address.CompanyAddress.State.StateId,
                                                    Constants.WAGES_EMPLOYER_STATE, errorMessagesAllFromDB);
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }
                                //Required entry #8
                                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.Zip,
                                                                Constants.WAGES_EMPLOYER_ZIP, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                if (errorMessage == null)
                                {
                                    // Validation Entry #10
                                    errorMessage = BusinessValidationRepository.IsValidZipCode(wages.Employer.Organization.Address.CompanyAddress.Zip,
                                                                Constants.WAGES_EMPLOYER_ZIP_VALIDATION, errorMessagesAllFromDB);
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                    if (errorMessage == null
                                        && wages.Employer.Organization.Address.CompanyAddress != null
                                        && wages.Employer.Organization.Address.CompanyAddress.State != null)   //10Jul2014 Sathish changed to new state bo
                                    {
                                        bool isValidZipcodeForState;
                                        if (wages.Employer.Organization.Address.CompanyAddress.Zip.Trim().Length < 5)
                                        {
                                            //Saravanan N - 19th Aug, 2014 - Since, client side allows to enter any characters in Zip field, zip code limit has to be verified in server side.
                                            isValidZipcodeForState = false;
                                        }
                                        else
                                        {
                                            //Yogalakshmi - 17th July 2014 - Triming zipcode to 5 digits as it validates only 5 digits in the DB
                                            isValidZipcodeForState = personalInfoDataService.ValidateZipCodeByStateId(
                                                        wages.Employer.Organization.Address.CompanyAddress.State.StateId,
                                                        Utilities.ConvertToLong(Utilities.RemoveHiphen
                                                        (wages.Employer.Organization.Address.CompanyAddress.Zip.Substring(0, 5))));
                                        }

                                        if (!isValidZipcodeForState)
                                        {
                                            errorMessage = BusinessValidationRepository.AssertIsTrue(isValidZipcodeForState,
                                            Constants.WAGES_EMPLOYER_ZIP_VALIDATION, errorMessagesAllFromDB);
                                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                        }
                                    }
                                }



                                if (wages.HasEmployeeAddress == true)
                                {
                                    if (wages.EmployeeAddress != null)
                                    {
                                        //Required entry #9
                                        errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.EmployeeAddress.StreetAddress,
                                                                            Constants.WAGES_EMPLOYEE_ADDRESS, errorMessagesAllFromDB);
                                        //Add Error Messages into TaxObject with current Form Id.
                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                        if (!string.IsNullOrEmpty(wages.EmployeeAddress.StreetAddress))
                                        {
                                            //Validation entry #5
                                            errorMessage = BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(wages.EmployeeAddress.StreetAddress,
                                            Constants.WAGES_EMPLOYEEE_ADDRESS_ALPHABET, errorMessagesAllFromDB);
                                            //Add Error Messages into TaxObject with current Form Id.
                                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                        }

                                        //Required entry #10
                                        errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.EmployeeAddress.City,
                                        Constants.WAGES_EMPLOYEE_CITY, errorMessagesAllFromDB);
                                        //Add Error Messages into TaxObject with current Form Id.
                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                        if (!string.IsNullOrEmpty(wages.EmployeeAddress.City))
                                        {
                                            //Validation entry #6
                                            errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(wages.EmployeeAddress.City,
                                                    Constants.WAGES_EMPLOYEE_CITY_ALPHABET, errorMessagesAllFromDB);
                                            //Add Error Messages into TaxObject with current Form Id.
                                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                        }

                                        //Required entry #11
                                        errorMessage = BusinessValidationRepository.AssertIsNotNull(wages.EmployeeAddress.State,
                                                        Constants.WAGES_EMPLOYEE_STATE, errorMessagesAllFromDB);
                                        //Add Error Messages into TaxObject with current Form Id.
                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                        if (errorMessage == null)
                                        {
                                            errorMessage = BusinessValidationRepository.AssertGreaterThanZero(wages.EmployeeAddress.State.StateId,
                                                            Constants.WAGES_EMPLOYEE_STATE, errorMessagesAllFromDB);
                                            //Add Error Messages into TaxObject with current Form Id.
                                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                        }
                                        //Required entry #12
                                        errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.EmployeeAddress.ZipCode,
                                                                        Constants.WAGES_EMPLOYEE_ZIP, errorMessagesAllFromDB);
                                        //Add Error Messages into TaxObject with current Form Id.
                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                        //Validation ZIP Code #11 
                                        if ((!string.IsNullOrEmpty(wages.EmployeeAddress.ZipCode)))
                                        {
                                            errorMessage = BusinessValidationRepository.IsValidZipCode(wages.EmployeeAddress.ZipCode,
                                                                                                  Constants.WAGES_EMPLOYEE_ZIP_VALIDATION,
                                                                                                    errorMessagesAllFromDB);
                                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                            if (errorMessage != null)
                                            {
                                                if (wages.EmployeeAddress.State != null)  //10Jul2014 Sathish changed to new state bo
                                                {
                                                    bool isValidZipcodeForState;
                                                    if (wages.EmployeeAddress.ZipCode.Trim().Length < 5)
                                                    {
                                                        //Saravanan N - 19th Aug, 2014 - Since, client side allows to enter any characters in Zip field, zip code limit has to be verified in server side.
                                                        isValidZipcodeForState = false;
                                                    }
                                                    else
                                                    {
                                                        //Yogalakshmi - 17th July 2014 - Triming zipcode to 5 digits as it validates only 5 digits in the DB
                                                        isValidZipcodeForState = personalInfoDataService.ValidateZipCodeByStateId(
                                                                  wages.EmployeeAddress.State.StateId, Utilities.ConvertToLong(
                                                                  Utilities.RemoveHiphen(wages.EmployeeAddress.ZipCode.Substring(0, 5))));
                                                    }

                                                    errorMessage = BusinessValidationRepository.AssertIsTrue(isValidZipcodeForState,
                                                    Constants.WAGES_EMPLOYEE_ZIP_VALIDATION, errorMessagesAllFromDB);
                                                }
                                            }
                                        }

                                    }
                                }

                                //Required Entry #13.

                                if (!wages.WagesAmount.HasValue)
                                {
                                    errorMessage = errorMessagesAllFromDB[Constants.WAGES_AMOUNT];
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }

                                ////Required Entry #14.
                                if (!wages.FederalTaxWithholdingAmount.HasValue)
                                {
                                    errorMessage = errorMessagesAllFromDB[Constants.WAGES_FEDERAL_TAX_WITH_HOLDING_AMOUNT];
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }


                                //Added by Thileep on 04.06.2014 For Social Security Wages
                                if (!wages.SocialSecurityWagesAmount.HasValue)
                                {
                                    //Requried entry #33
                                    errorMessage = errorMessagesAllFromDB[Constants.WAGES_SOCIAL_SECURITY];
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }

                                if (!wages.SocialSecurityTaxWithholdingAmount.HasValue)
                                {
                                    //Requried entry #34=>////Reuired Field Changed by Thileep 04.06.2014
                                    errorMessage = errorMessagesAllFromDB[Constants.WAGES_SOCIAL_SECURITY_TAX_WITHHOLDING_AMOUNT];
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }

                                if (!wages.MedicareWagesAmount.HasValue)
                                {
                                    //Requried entry #35
                                    errorMessage = errorMessagesAllFromDB[Constants.WAGES_MEDICARE_WAGES_AMOUNT];
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }

                                if (!wages.MedicareTaxWithholdingAmount.HasValue)
                                {
                                    //Requried entry #36
                                    errorMessage = errorMessagesAllFromDB[Constants.WAGES_MEDICARE_TAX_WITHHOLDING_AMOUNT];
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }



                                //Saravanan N - 14th May, 2014 - Null check done.
                                if (wages.W2StateLocalTaxInfo != null)
                                {
                                    int dynamiccontrolID = 0;

                                    foreach (var stateLocalTax in wages.W2StateLocalTaxInfo)
                                    {
                                        if (stateLocalTax != null)
                                        {
                                            if (stateLocalTax.State != null)
                                            {
                                                //Thileepkumar U - 14thJuly, 2014 - Suggestion Defect # 14032 -  Implemented Income spec V2.3
                                                //Saravanan N - 21st Aug, 2014 - StateIdNumber used in place of StateCode.
                                                //Yogalakshmi - 27th August 2014 - StateId number is in State Local Tax Class
                                                if (stateLocalTax.State.StateId > 0 || (stateLocalTax.StateIdNumber != null) || 
                                                    stateLocalTax.StateWagesAmount.HasValue || stateLocalTax.StateTaxWithholdingAmount.HasValue)
                                                {
                                                    //Required Entry # 15.
                                                    if (stateLocalTax.State.StateId == 0)  //10Jul2014 Sathish changed to new state bo
                                                    {
                                                        errorMessage = errorMessagesAllFromDB[Constants.WAGES_STATE_LOCAL_STATE_CODE];
                                                        errorMessage.FieldName = errorMessage.FieldName + dynamiccontrolID.ToString();
                                                        //Add Error Messages into TaxObject with current Form Id.
                                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                    }

                                                    //Required Entry # 16.
                                                    //Saravanan N - 21st Aug, 2014 - StateIdNumber used in place of StateCode.
                                                    if (stateLocalTax.StateIdNumber == null)
                                                    {
                                                        errorMessage = errorMessagesAllFromDB[Constants.WAGES_STATE_LOCAL_STATE_ID];
                                                        errorMessage.FieldName = errorMessage.FieldName + dynamiccontrolID.ToString();
                                                        //Add Error Messages into TaxObject with current Form Id.
                                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                    }

                                                    //Required Entry # 17.
                                                    if (!stateLocalTax.StateWagesAmount.HasValue)
                                                    {
                                                        errorMessage = errorMessagesAllFromDB[Constants.WAGES_STATE_LOCAL_STATE_WAGES];
                                                        errorMessage.FieldName = errorMessage.FieldName + dynamiccontrolID.ToString();
                                                        //Add Error Messages into TaxObject with current Form Id.
                                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                    }

                                                    if (!stateLocalTax.StateTaxWithholdingAmount.HasValue)
                                                    {
                                                        //Required Entry # 18.
                                                        errorMessage = errorMessagesAllFromDB[Constants.WAGES_STATE_LOCAL_STATE_WAGES_TAX_WITH_HOLDING_AMOUNT];
                                                        errorMessage.FieldName = errorMessage.FieldName + dynamiccontrolID.ToString();
                                                        //Add Error Messages into TaxObject with current Form Id.
                                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                    }
                                                }
                                            }

                                            //Saravanan N - 14th May, 2014 - Null check done.
                                            if (stateLocalTax.W2LocalTaxInfo != null)
                                            {
                                                //Local Tax Info
                                                foreach (var localTaxInfo in stateLocalTax.W2LocalTaxInfo)
                                                {
                                                    if (localTaxInfo != null)
                                                    {
                                                        //Thileepkumar U - 14thJuly, 2014 - Suggestion Defect # 14032 -  Implemented Income spec V2.3                                                                    
                                                        if (localTaxInfo.LocalWagesAmount.HasValue || localTaxInfo.LocalTaxWithholdingAmount.HasValue || (!string.IsNullOrEmpty(localTaxInfo.LocalityName.Trim())))
                                                        {
                                                            if (!localTaxInfo.LocalWagesAmount.HasValue)
                                                            {
                                                                //Required Entry # 19.
                                                                errorMessage = errorMessagesAllFromDB[Constants.WAGES_LOCAL_WAGES_AMOUNT];
                                                                errorMessage.FieldName = errorMessage.FieldName + dynamiccontrolID.ToString();
                                                                //Add Error Messages into TaxObject with current Form Id.
                                                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                            }
                                                            if (!localTaxInfo.LocalTaxWithholdingAmount.HasValue)
                                                            {
                                                                //Required Entry # 20.
                                                                errorMessage = errorMessagesAllFromDB[Constants.WAGES_LOCAL_WAGES_WITH_HOLDING_AMOUNT];
                                                                errorMessage.FieldName = errorMessage.FieldName + dynamiccontrolID.ToString();
                                                                //Add Error Messages into TaxObject with current Form Id.
                                                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                            }
                                                            if (string.IsNullOrEmpty(localTaxInfo.LocalityName.Trim()))
                                                            {
                                                                //Required Entry # 21.
                                                                errorMessage = errorMessagesAllFromDB[Constants.WAGES_LOCAL_WAGES_LOCALITY_NAME];
                                                                errorMessage.FieldName = errorMessage.FieldName + dynamiccontrolID.ToString();
                                                                //Add Error Messages into TaxObject with current Form Id.
                                                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                            }
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                        dynamiccontrolID = dynamiccontrolID + 1;
                                    }
                                }

                                // 02Jun2014 Sathish added required validation for other deduction benefits
                                // Requried entry 46
                                if (wages.OtherDeductsBenefits != null)
                                {
                                    int controldedcutionID = 0;
                                    foreach (var otherDeductsBenefits in wages.OtherDeductsBenefits)
                                    {
                                        if (otherDeductsBenefits.Amount.HasValue && otherDeductsBenefits.Amount != 0)
                                        {
                                            //Yogalakshmi - 24th June 2014 - Defect fix for TAX1040-14030 changed || to &&
                                            if (otherDeductsBenefits.W2OtherId == 0 && (otherDeductsBenefits.Description == null || otherDeductsBenefits.Description == string.Empty))
                                            {
                                                errorMessage = errorMessagesAllFromDB[Constants.WAGES_BENEFITS_OTHER_INFORMATION];
                                                errorMessage.FieldName = errorMessage.FieldName + controldedcutionID.ToString();

                                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                            }
                                        }
                                        //Yogalakshmi - 25th August 2014 - Defect fix for TAX1040-14475
                                        //Vincent- 25th Augest 2014- Added a string empty method for Description 
                                        //Required entry #53
                                        if (!otherDeductsBenefits.Amount.HasValue)
                                        {
                                            if ((otherDeductsBenefits.Description != null && otherDeductsBenefits.Description!=string.Empty) 
                                                || otherDeductsBenefits.W2OtherId != 0)
                                            {
                                                errorMessage = errorMessagesAllFromDB[Constants.WAGES_BENEFITS_OTHER_INFORMATION_AMOUNT];
                                                errorMessage.FieldName = errorMessage.FieldName + controldedcutionID.ToString();

                                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                            }
                                        }
                                        //Saravanan N - 30th July, 2014 - Moved out of the IF condition to fix the Defect # 14177.
                                        controldedcutionID = controldedcutionID + 1;
                                    }
                                }

                                if (wages.W2EmployerCodes != null)
                                {
                                    //Required field Validation for employerCode
                                    var employerCodeCount = 0;
                                    foreach (var employerCode in wages.W2EmployerCodes)
                                    {
                                        employerCodeCount++;
                                        
                                        //Yogalakshmi - 19th August 2014 - EmployerCode changed from NoneSelected to Empty
                                        //Yogalakshmi - 27th August 2014 - Null check for Employer Code
                                        if (employerCode.EmployerCode != null)
                                        {
                                            if (employerCode.EmployerCode != EmployerCode.NoneSelected)
                                            {

                                                if (!employerCode.Amount.HasValue)
                                                {
                                                    switch (employerCodeCount)
                                                    {
                                                        case 1:
                                                            //Required entry #22
                                                            errorMessage = errorMessagesAllFromDB[Constants.WAGES_BENEFITS_OTHER_INFORMATION_12A];
                                                            break;
                                                        case 2:
                                                            //Required entry #23
                                                            errorMessage = errorMessagesAllFromDB[Constants.WAGES_BENEFITS_OTHER_INFORMATION_12B];

                                                            break;
                                                        case 3:
                                                            //Required entry #24
                                                            errorMessage = errorMessagesAllFromDB[Constants.WAGES_BENEFITS_OTHER_INFORMATION_12C];
                                                            break;
                                                        case 4:
                                                            //Required entry #25
                                                            errorMessage = errorMessagesAllFromDB[Constants.WAGES_BENEFITS_OTHER_INFORMATION_12D];
                                                            break;
                                                    }

                                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                }

                                            }
                                        }
                                        // 02Jun2014 Sathish added required entry if employer code is not selected and only amout is given
                                        if (employerCode.Amount.HasValue)
                                        {
                                            //Yogalakshmi - 19th August 2014 - EmployerCode changed from NoneSelected to Empty
                                            //Yogalakshmi - 27th August 2014 - Null check for Employer Code
                                            if (employerCode.EmployerCode != null)
                                            {
                                                if (employerCode.EmployerCode == EmployerCode.NoneSelected)
                                                {
                                                    switch (employerCodeCount)
                                                    {
                                                        case 1:
                                                            //Required entry #42
                                                            errorMessage = errorMessagesAllFromDB[Constants.WAGES_BENEFITS_OTHER_INFORMATION_12A_AMOUNT];
                                                            break;
                                                        case 2:
                                                            //Required entry #43
                                                            errorMessage = errorMessagesAllFromDB[Constants.WAGES_BENEFITS_OTHER_INFORMATION_12B_AMOUNT];
                                                            break;
                                                        case 3:
                                                            //Required entry #44
                                                            errorMessage = errorMessagesAllFromDB[Constants.WAGES_BENEFITS_OTHER_INFORMATION_12C_AMOUNT];
                                                            break;
                                                        case 4:
                                                            //Required entry #45
                                                            errorMessage = errorMessagesAllFromDB[Constants.WAGES_BENEFITS_OTHER_INFORMATION_12D_AMOUNT];
                                                            break;
                                                    }

                                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                    else if (wages.EmploymentType == EmploymentType.HouseholdEmployeeWages)
                    {
                        if (wages.Employer != null)
                        {
                            //Required Entry #26
                            if (!wages.Employer.HouseholdEmployeeWages.HasValue)
                            {
                                errorMessage = errorMessagesAllFromDB[Constants.WAGES_HOUSE_HOLD_WAGES];
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                            }


                            //Required entry #37
                            errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Name,
                                      Constants.WAGES_HOUSE_HOLD_EMPLOYER_NAME_REQUIRED, errorMessagesAllFromDB);
                            //Add Error Messages into TaxObject with current Form Id.
                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                            if (errorMessage == null)
                            {
                                //Defect TAX1040-14011 - Saravanan N - 11th June, 2014.
                                isValid = Utilities.IsValidRegexPattern(wages.Employer.Organization.Name, @"^[A-Za-z0-9 -]+$");
                                //Validation #11.
                                if (!isValid)
                                {
                                    errorMessage = errorMessagesAllFromDB[Constants.WAGES_HOUSE_HOLD_EMPLOYER_NAME_VALIDATION];
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }
                            }
                            //Required Entry #38
                            errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.StreetAddress,
                              Constants.WAGES_HOUSE_HOLD_ADDRESS_REQUIRED, errorMessagesAllFromDB);
                            //Add Error Messages into TaxObject with current Form Id.
                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                            if (errorMessage == null)
                            {
                                //Bala, 17Jul2014, As discussed with saran,Validations is modified for streetAddress 
                                errorMessage = BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(wages.Employer.Organization.Address.CompanyAddress.StreetAddress,
                                 Constants.WAGES_HOUSE_HOLD_ADDRESS_VALIDATION, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                            }

                            //Required Entry #40
                            errorMessage = BusinessValidationRepository.AssertIsNotNull(wages.Employer.Organization.Address.CompanyAddress.State,
                            Constants.WAGES_HOUSE_HOLD_STATE_REQUIRED, errorMessagesAllFromDB);
                            //Add Error Messages into TaxObject with current Form Id.
                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                            if (errorMessage == null)
                            {
                                errorMessage = BusinessValidationRepository.AssertGreaterThanZero(wages.Employer.Organization.Address.CompanyAddress.State.StateId,
                             Constants.WAGES_HOUSE_HOLD_STATE_REQUIRED, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                            }
                            //Required Entry #39
                            errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.City,
                                    Constants.WAGES_HOUSE_HOLD_CITY_REQUIRED, errorMessagesAllFromDB);
                            //Add Error Messages into TaxObject with current Form Id.
                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                            if (errorMessage == null)
                            {
                                //Defect TAX1040-13952 - Yogalakshmi - 11th June 2014 - Checked for Household Employers City which allows only letters and space.
                                isValid = Utilities.IsValidRegexPattern(wages.Employer.Organization.Address.CompanyAddress.City, @"^[A-Za-z ]+$");
                                if (!isValid)
                                {
                                    errorMessage = errorMessagesAllFromDB[Constants.WAGES_HOUSE_HOLD_CITY_VALIDATION];
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }
                            }

                            //Required Entry #41
                            errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.Zip,
                                    Constants.WAGES_HOUSE_HOLD_ZIP_REQUIRED, errorMessagesAllFromDB);
                            //Add Error Messages into TaxObject with current Form Id.
                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                            if (errorMessage == null)
                            {
                                // Validation check #11
                                errorMessage = BusinessValidationRepository.IsValidZipCode(wages.Employer.Organization.Address.CompanyAddress.Zip,
                                  Constants.WAGES_HOUSE_HOLD_ZIP_VALIDATION, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                if (wages.Employer.Organization.Address.CompanyAddress.State != null)
                                {
                                    //Saravanan N - 19th Aug, 2014 - Length < 5 then Validation check #11 above will display error message. The below code will display execure if the zip code length >= 5.
                                    bool isValidZipcodeForState;
                                    if (wages.Employer.Organization.Address.CompanyAddress.Zip.Trim().Length >= 5)
                                    {
                                        //Yogalakshmi - 17th July 2014 - Triming zipcode to 5 digits as it validates only 5 digits in the DB
                                        isValidZipcodeForState = personalInfoDataService.ValidateZipCodeByStateId(
                                                    wages.Employer.Organization.Address.CompanyAddress.State.StateId,
                                                    Utilities.ConvertToLong(
                                                    Utilities.RemoveHiphen(wages.Employer.Organization.Address.CompanyAddress.Zip.Substring(0, 5))));
                                        errorMessage = BusinessValidationRepository.AssertIsTrue(isValidZipcodeForState,
                                            Constants.WAGES_HOUSE_HOLD_ZIP_VALIDATION, errorMessagesAllFromDB);
                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                    }
                                }
                            }
                        }
                    }
                    else if (wages.EmploymentType == EmploymentType.TaxableScholarshipIncome)
                    {
                        if (wages.Employer != null)
                        {
                            //Required Entry #32
                            if (!wages.Employer.TaxableScholarshipAmount.HasValue)
                            {
                                errorMessage = errorMessagesAllFromDB[Constants.WAGES_TAX_ABLE_SCHOLARSHIP_INCOME];
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                            }

                            if (wages.Employer.Organization != null)
                            {
                                //Required Entry #27
                                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Name,
                                  Constants.WAGES_INSTITUITION_NAME, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                if (!string.IsNullOrEmpty(wages.Employer.Organization.Name))
                                {
                                    //Validation entry #7
                                    errorMessage = BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(wages.Employer.Organization.Name,
                                        Constants.WAGES_INSTITUITION_NAME_ALPHABET, errorMessagesAllFromDB);
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }

                                //Required Entry #28
                                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.StreetAddress,
                                  Constants.WAGES_INSTITUITION_ADDRESS, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                if (!string.IsNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.StreetAddress))
                                {
                                    //Validation entry #8
                                    errorMessage = BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(wages.Employer.Organization.Address.CompanyAddress.StreetAddress,
                                        Constants.WAGES_INSTITUITION_ADDRESS_ALPHABET, errorMessagesAllFromDB);
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }

                                //Required Entry #29
                                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.City,
                                        Constants.WAGES_INSTITUITION_CITY, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                if (!string.IsNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.City))
                                {
                                    //Validation entry #9
                                    errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(wages.Employer.Organization.Address.CompanyAddress.City,
                                                Constants.WAGES_INSTITUITION_CITY_ALPHABET, errorMessagesAllFromDB);
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }

                                //Required Entry #30
                                errorMessage = BusinessValidationRepository.AssertIsNotNull(wages.Employer.Organization.Address.CompanyAddress.State,
                             Constants.WAGES_INSTITUITION_STATE, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                if (errorMessage == null)
                                {
                                    errorMessage = BusinessValidationRepository.AssertGreaterThanZero(wages.Employer.Organization.Address.CompanyAddress.State.StateId,
                                 Constants.WAGES_INSTITUITION_STATE, errorMessagesAllFromDB);
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                }
                                //Required Entry #31
                                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.Zip,
                                                                Constants.WAGES_INSTITUITION_ZIP, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                //Validation ZIP Code #15 
                                if (errorMessage == null)
                                {
                                    errorMessage = BusinessValidationRepository.IsValidZipCode(wages.Employer.Organization.Address.CompanyAddress.Zip,
                                                                                                Constants.WAGES_INSTITUITION_ZIP_VALIDATION,
                                                                                                errorMessagesAllFromDB);
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                    if (errorMessage == null)
                                    {
                                        if (wages.Employer.Organization.Address.CompanyAddress.State != null)
                                        {
                                            //Yogalakshmi - 17th July 2014 - Triming zipcode to 5 digits as it validates only 5 digits in the DB
                                            //Yogalakshmi - 6th Aug 2014 - Changed the Constant from #7 to #16 as per the SPEC
                                            bool isValidZipcodeForState = personalInfoDataService.ValidateZipCodeByStateId(
                                                      wages.Employer.Organization.Address.CompanyAddress.State.StateId,
                                                      Utilities.ConvertToLong(Utilities.RemoveHiphen(wages.Employer.Organization.Address.CompanyAddress.Zip.Substring(0,5))));

                                            errorMessage = BusinessValidationRepository.AssertIsTrue(isValidZipcodeForState,
                                            Constants.WAGES_INSTITUITION_ZIP_VALIDATION , errorMessagesAllFromDB);
                                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                        }
                                    }
                                }

                            }
                        }
                    }
                    else if (wages.EmploymentType == EmploymentType.ForeignEmployment)
                    {
                        //Vincent-25 Augest 2014- Added the bussiness rule check for FOREIGN_EMPLOYMENT_COMPENSATION
                        if (wages.HasForeignEmployment == null)
                        {
                            errorMessage = errorMessagesAllFromDB[Constants.WAGES_MISSING_FOREIGN_EMPLOYMENT_COMPENSATION];
                            AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                        }
                    
                    
                    }
                }
            }
        }
        #endregion

        #region Helper Methods
        private static W2 PersistW2Data(string w2Data, BusinessObject.Tax1040 taxObject, long userId, long userDataId)
        {
            long w2Id = 0;
            //Converting Json to W2 by DeSerializing
            W2 w2 = JsonConvert.DeserializeObject<W2>(w2Data);
            if (taxObject.Income.W2Wages != null && taxObject.Income.W2Wages.Any())
            {
                int index = taxObject.Income.W2Wages.FindIndex(wages => wages.W2Id == w2.W2Id);

                if (index < 0)
                {
                    w2.W2Id = taxObject.Income.W2Wages.Max(frm => frm.W2Id) + 1;
                    //TODO: Commented for testing purpose.
                    //taxObject.Income.W2Wages = new List<W2>();

                    //Adding new W2 to the TaxObject W2List
                    // Added by prasana on 17.06.2014 new new Employer to TaxObject to displsy Error Messages in diagnostics for defect 14176.
                    if (w2.Employer == null)
                    {
                        w2.Employer = new Employer
                        {
                            Organization = new Organization { Address = new Address { CompanyAddress = new CompanyAddress() } }
                        };
                    }
                    w2.EmployeeAddress = new W2EmployeeAddress();
                    taxObject.Income.W2Wages.Add(w2);
                    w2Id = 0;
                }
                else
                {
                    taxObject.Income.W2Wages[index] = w2;
                    w2Id = w2.W2Id;
                }
            }
            else
            {
                if (w2 != null)
                {
                    w2.W2Id = 1;

                    if (w2.Employer == null)
                    {
                        // Added new new Employer to TaxObject to displsy Error Messages in diagnostics for defect 14176.
                        w2.Employer = new Employer
                        {
                            Organization = new Organization { Address = new Address { CompanyAddress = new CompanyAddress() } }
                        };
                        w2.EmployeeAddress = new W2EmployeeAddress();
                    }

                    //Creating Instance if W2WagesList section is Null
                    taxObject.Income.W2Wages = new List<W2> { w2 };
                    w2Id = 0;
                    //Adding new W2 to the TaxObject W2List
                }

            }
             //02-Sep-2014 Bhavani Audit functionality implementation
            var description = w2Id < 0 ? "Persist Wages: "+ w2Id +", ClassName: {0}, Method Name: {1}" : "Update Wages: "+ w2Id +", ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userId, userDataId, description, "W2Repository", Constants.Tab_INCOME, Constants.TOPIC_WAGES);
            return w2;
        }

        //Saravanan N - 29th April, 2014 - Add Error Message into TaxObject with FormId.
        private void AddErrorToTaxObjectWithFormId(List<ErrorMessage> errorMessageListInTaxObject, long w2Id, ErrorMessage errorMessage)
        {
            if (errorMessage != null)
            {
                errorMessage.FormId = w2Id;
                errorMessageListInTaxObject.Add(errorMessage);
            }
        }

      
       
        #endregion

        #region Unit Test used methods
        /// <summary>
        /// Get the W2 list
        /// </summary>
        /// <param name="userDataId">The user data id.</param>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        public List<W2> GetTaxReturnW2List(UserDTO userDTO)
        {
            var taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

            List<W2> w2ListObject = null;
            if (taxObject != null && taxObject.Income != null && taxObject.Income.W2Wages != null && taxObject.Income.W2Wages.Any())
            {
                w2ListObject = taxObject.Income.W2Wages;
            }
            return w2ListObject;
        }
        #endregion
    }
}
