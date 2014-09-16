/*
Copyright   : Copyright Jeevan Technologies
File Name   : InterestIncomeRepository.cs 
Description : Business Logic for Interest Income(1099INT/1099OID) 
Author      : Vincent
Created Date : 31 Mar 2014

 * Modification History:
---------------------
 * 2Apr2014 Ashok kumar  New method added for Required field Server side Validations 
 * 8Apr2014 Vincent Remove the error message count for 1099OID.
 * 10Apr2014 Vincent Added Delete method for OID and INT Section.
 * 10Apr2014 Vincent Added the Required field validation and Business rule validation.
 * 10Apr2014 Vincent Added Count Value while adding new persist
 * 17Apr2014 Sathish - Commented will not allow to add new 1099OID
 * 17Apr2014 Sathish - DeleteAndPersist1099OID changed int to long in parameter for FormOIDId
 * 29Apr2014 Bala Code modified to check the EligibilityDiagnostics in PersistInterestIncomeEligibilityData() method
 * 02May2014 Sathish Added TaxReturnData for PersistTaxReturnForm1099INTData 
 * 02May2014 Bala Modified code to clear the error messages from error message list. 
 * 23May2014 AshokKumar Modified code for checklist persist method 
 * 28th May, 2014 - Saravanan N - Deserialize code moved from Controller to Repository.
 * 28May2014- Vincent- Made a code refator.
 * 30May2014-Vincent-Implemented the EIN Code.
 * 05Jun2014 Sathish added optional parameter taxobject used in delete spouse info while changing filling status MFJ to single
 * 06Jun2014 vivek added the State Tax exempt Interest 
 * 6th June, 2014 Saravanan Added Validation # 6. 
 * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
 * 14thJuly2014 Ashok - Added logic for Clearing EIC Worksheet, Form 8862 and EIC classes when failing EIC eligibility
 * 23 July 2014 Bhavani - Removed unused variables  taxReturnDataOID, IsValid, totalW2Wages, annualGrossIncome.
 * 19Aug2014-Thileep changed and added code in All persist methods for Taxableincomecheck,Refundoptioncheck and (Income,Refund,Taxes all are Zeros check)
 * 21Aug2014 - Ashok Kumar added EIC eligibility check along with Taxable Income Eligibility check using Workflow
 * 02Sep2014-  Thileep Changed Persist methods to Remove EIC Error messages on Eligibility fails
 */

using System;
using System.Activities;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using System.Collections.Generic;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;
using System.Linq;
using System.Dynamic;
using Tax1040WorkFlow.WorkFlow.Activities;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;
using System.Web;

namespace JTL.Tax1040.BusinessLogic
{
    public class InterestIncomeRepository : IInterestIncomeRepository
    {
        #region Local variables
        private readonly MessagesRepository messageRepository;
        bool isHavingNineChars = true;
        bool isValidNumeric = true;
        JTL.Tax1040.BusinessObject.Tax1040 taxObject;
        FilingStatus filingStatus = FilingStatus.None;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="InterestIncomeRepository"/> class.
        /// </summary>
        public InterestIncomeRepository()
        {
            messageRepository = new MessagesRepository();

            if (taxObject != null && taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null)
            {
                filingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;
            }
        }
        #endregion

        #region F1099 INT
        //Saravanan N - 9th May, 2014 - Code moved from Controller and refactored.
        /// <summary>
        /// Returns INT data.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        public System.Tuple<Form1099INT, FilingStatus, dynamic> GetTaxReturn1099INTData(UserDTO userDTO)
        {
            // Vincent-20th May 2014-Modified the GetTaxReturn1099INTData 
            Tuple<Form1099INT, FilingStatus, dynamic> taxReturnDataINT = null;
            
            try
            {
                var taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                List<Form1099INT> lstFormINT = null;
                Form1099INT form1099INT = null;
                FilingStatus filingStatus = FilingStatus.None;
                List<ErrorMessage> form1099INTErrorList = new List<ErrorMessage>();
                dynamic taxReturnPersonData = new ExpandoObject();
                if (taxObject != null)
                {
                    if (taxObject.Income != null && taxObject.Income.Form1099INT != null)
                    {
                        lstFormINT = taxObject.Income.Form1099INT;

                        //Check current INT object already exists in the TaxObject.
                        if (lstFormINT != null && lstFormINT.Any())
                        {
                            //Vincent N - 20th May, 2014 - Id used from UserDTO.
                            int index = lstFormINT.FindIndex(F1099INT => F1099INT.Form1099INTId == userDTO.FormId);

                            if (index >= 0)
                            {
                                //INT Object found in the List, then GET it.
                                form1099INT = lstFormINT[index];
                            }
                        }
                    }

                    //Get FilingStatus.
                    if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null)
                    {
                        filingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                    }
                    //Yogalakshmi - 12th June 2014 - Added to display the Taxpaer name and Spouse name if given
                    if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null && taxObject.PersonalDetails.PrimaryTaxPayer.Person != null)
                    {
                        if (taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName != null)
                        {
                            taxReturnPersonData.PrimaryTaxPayerFirstName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName;
                        }
                    }
                    if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.Spouse != null && taxObject.PersonalDetails.Spouse.Person != null)
                    {
                        if (taxObject.PersonalDetails.Spouse.Person.FirstName != null)
                        {
                            taxReturnPersonData.SpouseFirstName = taxObject.PersonalDetails.Spouse.Person.FirstName;
                        }
                    }
                    //vivek - 6-Aug-14 -Added the error message list for the error message focus 
                    if (taxObject.ErrorMessages != null)
                    {
                        form1099INTErrorList = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_FORM_INT
                                                                                         && (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V)).ToList();
                    }
                    taxReturnPersonData.errorlist = form1099INTErrorList;
                }

                taxReturnDataINT = new Tuple<Form1099INT, FilingStatus, dynamic>(form1099INT, filingStatus, taxReturnPersonData);
                
                //01-Sep-2014 Bhavani Audit functionality implementation
                var description = "Get Form1099INT: " + userDTO.FormId + ", ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.TOPIC_INTEREST_INCOME, Constants.TOPIC_FORM_INT);

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:InterestIncomeRepository,Method Name:GetTaxReturn1099INTData", ex);
            }

            return taxReturnDataINT;
        }

              
        //Saravanan N - 9th May, 2014 - Code moved from Controller and refactored.
        /// <summary>
        /// Returns List of INT data.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        public System.Tuple<List<Form1099INT>, List<ErrorMessage>> GetTaxReturn1099INTListandErrorList(UserDTO userDTO)
        {
            List<Form1099INT> lstF1099INT = null;
            List<ErrorMessage> lstTaxObjectErrors = null;

            try
            {

                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(Utilities.ConvertToLong(userDTO.UserId), Utilities.ConvertToLong(userDTO.UserDataId));

                if (taxObject != null)
                {
                    if (taxObject.Income != null && taxObject.Income.Form1099INT != null)
                    {
                        lstF1099INT = taxObject.Income.Form1099INT;
                    }

                    if (taxObject.ErrorMessages != null)
                    {
                        lstTaxObjectErrors = taxObject.ErrorMessages;
                    }
                }

                if (lstF1099INT != null)
                {
                    //Get the TaxPayer names
                    var taxPayerAndSpouseNames = Utilities.GetTaxPayerAndSpouseName(taxObject);

                    foreach (var form1099INT in lstF1099INT)
                    {
                        if (form1099INT != null)
                        {
                            switch (form1099INT.Owner)
                            {
                                case OwnerType.PrimaryTaxPayer:
                                    form1099INT.RecipientName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item2;
                                    break;
                                case OwnerType.Spouse:
                                    form1099INT.RecipientName = taxPayerAndSpouseNames.Item3 + " " + taxPayerAndSpouseNames.Item4;
                                    break;
                                case OwnerType.Joint:
                                    form1099INT.RecipientName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item3;
                                    break;
                                default:
                                    form1099INT.RecipientName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item2;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:InterestIncomeRepository,Method Name:GetTaxReturn1099INTListandErrorList", ex);
            }

            //01-Sep-2014 Bhavani Audit functionality implementation
            string description = "Get Form1099INTList, ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.TOPIC_INTEREST_INCOME, Constants.TOPIC_FORM_INT);

            return new System.Tuple<List<Form1099INT>, List<ErrorMessage>>(lstF1099INT, lstTaxObjectErrors);
        }

        //Saravanan N - 9th May, 2014 - Code refactored.
        /// <summary>
        /// Persists the tax return data.
        /// </summary>
        /// <param name="taxReturn"></param>
        /// <returns></returns>
        public dynamic PersistTaxReturnForm1099INTData(dynamic taxReturn)
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject = null;
            Form1099INT form1099INT = null;
            dynamic userData = new ExpandoObject();
            long userId = 0;
            TaxReturnData taxReturnData = null;
            var formINTID = 0;

            try
            {
                var isEligibilityCheckFailed = false;


                taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(taxReturn.TaxReturnData.ToString());
                userId = Utilities.ConvertToLong(taxReturn.userId);

                if (taxReturnData != null)
                {
                    //Retreiving TaxObject from database
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);
                }

                if (taxObject != null)
                {
                    //Creating Instance if Income section is Null
                    if (taxObject.Income == null)
                    {
                        taxObject.Income = new Income();
                        taxObject.Income.Form1099INT = new List<Form1099INT>();
                    }
                    else
                    {
                        //Yogalakshmi - 21st May 2014 - Null check
                        if (taxObject.Income.Form1099INT == null)
                        {
                            taxObject.Income.Form1099INT = new List<Form1099INT>();
                        }
                    }

                    // SaranS: Remove the DeSerialzation code here, it should happen at the service layer
                    //Converting Json to Form1099INT by DeSerializing
                    form1099INT = JsonConvert.DeserializeObject<Form1099INT>(taxReturnData.TaxData);

                    //Clear Box 8 Grid rows if Box 8 doesn't have value. - Saravanan N - 28th Aug, 2014.
                    if(form1099INT != null && !form1099INT.TaxExemptInterest.HasValue) 
                    {
                        form1099INT.TaxExemptStateCodeAndAmount = null;
                    }
                    
                    if (taxObject.Income.Form1099INT != null && taxObject.Income.Form1099INT.Any())
                    {
                        
                        int index = taxObject.Income.Form1099INT.FindIndex(frm => frm.Form1099INTId == form1099INT.Form1099INTId);

                        if (index < 0)
                        {
                            form1099INT.Form1099INTId = taxObject.Income.Form1099INT.Max(frm => frm.Form1099INTId) + 1;

                            //Adding new Form1099INT to the TaxObject 1099INTList
                            taxObject.Income.Form1099INT.Add(form1099INT);
                            formINTID = 0;
                        }
                        else
                        {
                            taxObject.Income.Form1099INT[index] = form1099INT;
                            formINTID = form1099INT.Form1099INTId;
                        }
                    }
                    else
                    {
                        form1099INT.Form1099INTId = 1;
                        taxObject.Income.Form1099INT.Add(form1099INT);
                        formINTID = 0;
                    }

                    if (taxObject.ErrorMessages == null)
                    {
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    }

                    //Retrieving Error Message list from Database
                    //var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessage = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
                    var errorMessagesListFromDB = new ErrorMessages(errorMessage);

                    // Clear the Error messages
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FORM_INT);

                    if (taxObject.Income.Form1099INT != null && taxObject.Income.Form1099INT.Any())
                    {
                        //Invoking Required Field Validations Method
                        F1099INTRequiredFieldCheck(taxObject.Income.Form1099INT, taxObject.ErrorMessages, errorMessagesListFromDB);

                        //Invoking Business Field Validations Method
                        F1099INTValidationsCheck(taxObject.Income.Form1099INT, taxObject.ErrorMessages, errorMessagesListFromDB);
                    }

                    // Clear the Error messages
                    //messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EARNED_INCOME_CREDIT);
                    //02Sep2014-Thileep Changed code to Remove EIC errormessages which has Message Type EI only
                    taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT && (err.MessageType == Constants.MESSAGE_TYPE_EI));


                    //14thJuly2014 Ashok - Added logic for Clearing EIC Worksheet, Form 8862 and EIC classes when failing EIC eligibility
                    //Workflow Validation check.
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    input.ErrorMessages = errorMessagesListFromDB;
                    //Check if EIC with espect to AGI
                    var output = AGICheck(taxObject, input);

                    //02Sep2014-  Thileep added  to Remove EIC Error messages when EIC Eligibility fails
                    if (!output.HasEarnedIncomeCredit)
                    {
                        taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT &&
                            (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V || err.MessageType == Constants.MESSAGE_TYPE_BR));

                    }
                    //Bala, 17-Jun-14,Workflow call removed from EligibilityCheckValidation() to avoid duplicate error messages
                    //dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    //input.Tax1040Object = taxObject;
                    input.ErrorMessages = errorMessagesListFromDB;
                    output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary
                        (WorkflowInvoker.Invoke(new F1099INTBusinessValidationRules(), input));

                    //25 Aug 2014-Vincent- Federal work flow Summary check was missed in INT
                    //25 Aug 2014-Vincent- Added the SSB and RRB check in FederalSummaryWithNoValidation
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
                    federalSummaryInput.IsSSBAndRRBCheck = true;
                    federalSummaryInput.ErrorMessages = errorMessagesListFromDB;
                    output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                             WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), federalSummaryInput));

                    //Saravanan N - 2nd June, 2014 - Invoking Business Rules Validation Workflow
                    EligibilityCheckValidation(taxObject, errorMessagesListFromDB);

                    //Check whether any Eligibility Check found.
                    isEligibilityCheckFailed = taxObject.ErrorMessages.Any(errMsg => errMsg.Topic ==
                        Constants.TOPIC_INTEREST_INCOME && errMsg.ErrorCode.Equals(Constants.INTEREST_INCOME_TAXABLE_INTEREST_EXCEEDS_LIMIT));

                    taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);
                }
                userData.UserDataId = taxReturnData.UserDataId;
                userData.Form1099INTId = form1099INT.Form1099INTId;
                userData.isEligibilityCheckFailed = isEligibilityCheckFailed;

                //01-Sep-2014 Bhavani Audit functionality implementation
                string description = formINTID > 0
                    ? "Update Form1099INT" + formINTID + ", ClassName: {0}, Method Name: {1}"
                    : "Persist Form1099INT" + formINTID + ", ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userId, userData.UserDataId, description, this.GetType().Name, Constants.TOPIC_INTEREST_INCOME, Constants.TOPIC_FORM_INT);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:InterestIncomeRepository,Method Name:PersistTaxReturnForm1099INTData", ex);
            }

            return userData;
        }

        //Saravanan N - 9th May, 2014 - Code refactored.
        /// <summary>
        /// Delete INT by ID.
        /// </summary>
        /// <param name="userDTO"></param>
        public void DeleteAndPersist1099INT(UserDTO userDTO, Tax1040.BusinessObject.Tax1040 refTaxObject = null) // 05Jun2014 Sathish added optional parameter taxobject used in delete spouse info while changing filling status MFJ to single
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            long form1099INTId = userDTO.FormId.ConvertToLong();

            try
            {
                // 05Jun2014 Sathish check optional parameter which is used in deleting spouse info
                if (refTaxObject == null)
                    //Retrieving TaxObject from database
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong());
                else
                    taxObject = refTaxObject;

                //Converting Json to Form1099INT by DeSerializing
                if (taxObject != null && taxObject.Income != null && taxObject.Income.Form1099INT != null)
                {
                    int index = taxObject.Income.Form1099INT.FindIndex(form => form.Form1099INTId == form1099INTId);

                    if (index >= 0)
                    {

                        //Delete the current Form1099INT object.
                        taxObject.Income.Form1099INT.RemoveAt(index);

                        //Clear the error messages for the corresponding form
                        messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FORM_INT, form1099INTId);


                        // 17Jun2014 Sathish removed eligibility rule InterestIncome_ER10 on delete
                        //Retrieving Error Message list from Database
                        //var errorMessage = messageRepository.GetErrorMessages();
                        var errorMessage = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
                        var errorMessagesListFromDB = new ErrorMessages(errorMessage);


                        taxObject.ErrorMessages.RemoveAll(errMsg => errMsg.ErrorCode == "InterestIncome_ER10");
                        dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                        input = new Microsoft.Activities.Extensions.WorkflowArguments();
                        input.Tax1040Object = taxObject;
                        input.ErrorMessages = errorMessagesListFromDB;
                        var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary
                           (WorkflowInvoker.Invoke(new F1040EZTaxableInterestEligibility(), input));


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
                        federalSummaryInput.ErrorMessages = errorMessagesListFromDB;
                        output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                                 WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), federalSummaryInput));

                        //Added by Ashok for EIC Eligibility Check
                        // Clear the Error messages
                        //messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EARNED_INCOME_CREDIT);
                        //02Sep2014-Thileep Changed code to Remove EIC errormessages which has Message Type EI only
                        taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT && (err.MessageType == Constants.MESSAGE_TYPE_EI));


                        dynamic eicEligbilityInput = new Microsoft.Activities.Extensions.WorkflowArguments();
                        eicEligbilityInput.Tax1040Object = taxObject;
                        eicEligbilityInput.ErrorMessages = errorMessagesListFromDB;
                        //Check if EIC with espect to AGI
                        output = AGICheck(taxObject, input);

                        //02Sep2014-  Thileep added  to Remove EIC Error messages when EIC Eligibility fails
                        if (!output.HasEarnedIncomeCredit)
                        {
                            taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT &&
                                (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V || err.MessageType == Constants.MESSAGE_TYPE_BR));

                        }
                    }
                }

                //Persist latest TaxObject.
                Utilities.PersistTaxObject(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong(), taxObject);

                //01-Sep-2014 Bhavani Audit functionality implementation
                string description = "Delete Form1099INT " + form1099INTId + ", ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.TOPIC_INTEREST_INCOME, Constants.TOPIC_FORM_INT);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:InterestIncomeRepository,Method Name:DeleteAndPersist1099INT", ex);
            }
        }
        #endregion

        #region F1099 OID
        //Saravanan N - 9th May, 2014 - Code moved from Controller and refactored.
        /// <summary>
        /// Returns OID data.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        public System.Tuple<Form1099OID, FilingStatus, dynamic> GetTaxReturn1099OIDData(UserDTO userDTO)
        {
            Form1099OID form1099OID = null;
            FilingStatus filingStatus = FilingStatus.None;
            List<ErrorMessage> form1099OIDTErrorList = new List<ErrorMessage>();
            // Vincent-20th May 2014-Modified the GetTaxReturn1099OIDData 
            dynamic taxReturnPersonData = new ExpandoObject();
            try
            {
                var taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                List<Form1099OID> lstFormOID = null;

                if (taxObject != null)
                {
                    if (taxObject.Income != null && taxObject.Income.Form1099OID != null)
                    {
                        lstFormOID = taxObject.Income.Form1099OID;

                        if (lstFormOID != null && lstFormOID.Any())
                        {
                            //Vincent N - 20th May, 2014 - Id used from UserDTO.
                            int index = lstFormOID.FindIndex(F1099OID => F1099OID.Form1099OIDId == userDTO.FormId);

                            if (index >= 0)
                            {
                                form1099OID = lstFormOID[index];
                            }
                        }
                    }

                    //Get FilingStatus.
                    if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null)
                    {
                        filingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                    }
                    //Yogalakshmi - 12th June 2014 - Added to display the Taxpaer name and Spouse name if given
                    if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null && taxObject.PersonalDetails.PrimaryTaxPayer.Person != null)
                    {
                        if (taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName != null)
                        {
                            taxReturnPersonData.PrimaryTaxPayerFirstName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName;
                        }
                    }
                    if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.Spouse != null && taxObject.PersonalDetails.Spouse.Person != null)
                    {
                        if (taxObject.PersonalDetails.Spouse.Person.FirstName != null)
                        {
                            taxReturnPersonData.SpouseFirstName = taxObject.PersonalDetails.Spouse.Person.FirstName;
                        }
                    }
                    //vivek - 6-Aug-14 -Added the error message list for the error message focus 
                    if (taxObject.ErrorMessages != null)
                    {
                        form1099OIDTErrorList = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_FORM_OID
                                                                                         && (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V)).ToList();
                    }
                    taxReturnPersonData.errorlist = form1099OIDTErrorList;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:InterestIncomeRepository,Method Name:GetTaxReturn1099OIDData", ex);
            }

            //01-Sep-2014 Bhavani Audit functionality implementation
            string description = "Get Form1099OID: " + userDTO.FormId + ", ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.TOPIC_INTEREST_INCOME, Constants.TOPIC_FORM_OID);



            return new Tuple<Form1099OID, FilingStatus, dynamic>(form1099OID, filingStatus, taxReturnPersonData);
        }

        //Saravanan N - 9th May, 2014 - Code moved from Controller and refactored.
        /// <summary>
        /// Returns all OID data with Error List.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        public System.Tuple<List<Form1099OID>, List<ErrorMessage>> GetTaxReturn1099OIDListandErrorList(UserDTO userDTO)
        {
            List<Form1099OID> lstForm10999OID = null;
            List<ErrorMessage> lstTaxObjectErrors = null;

            try
            {

                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(Utilities.ConvertToLong(userDTO.UserId),
                    Utilities.ConvertToLong(userDTO.UserDataId));

                if (taxObject != null)
                {
                    if (taxObject.Income != null && taxObject.Income.Form1099OID != null)
                    {
                        lstForm10999OID = taxObject.Income.Form1099OID;
                    }

                    if (taxObject.ErrorMessages != null)
                    {
                        lstTaxObjectErrors = taxObject.ErrorMessages;
                    }
                }


                if (lstForm10999OID != null)
                {
                    //Get the TaxPayer names
                    var taxPayerAndSpouseNames = Utilities.GetTaxPayerAndSpouseName(taxObject);

                    foreach (var form1099OID in lstForm10999OID)
                    {
                        if (form1099OID != null)
                        {
                            switch (form1099OID.Owner)
                            {
                                case OwnerType.PrimaryTaxPayer:
                                    form1099OID.RecipientName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item2;
                                    break;
                                case OwnerType.Spouse:
                                    form1099OID.RecipientName = taxPayerAndSpouseNames.Item3 + " " + taxPayerAndSpouseNames.Item4;
                                    break;
                                case OwnerType.Joint:
                                    form1099OID.RecipientName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item3;
                                    break;
                                default:
                                    form1099OID.RecipientName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item2;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:InterestIncomeRepository,Method Name:GetTaxReturn1099OIDListandErrorList", ex);
            }

            //01-Sep-2014 Bhavani Audit functionality implementation
            string description = "Get Form1099OIDList, ClassName: {0}, Method Name: {1}";
            Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.TOPIC_INTEREST_INCOME, Constants.TOPIC_FORM_OID);

            return new System.Tuple<List<Form1099OID>, List<ErrorMessage>>(lstForm10999OID, lstTaxObjectErrors);
        }

        /// <summary>
        /// Persists the tax return form1099 oid data.
        /// </summary>
        /// <param name="taxReturn"></param>
        /// <returns></returns>
        public dynamic PersistTaxReturnForm1099OIDData(dynamic taxReturn)
        {
            Form1099OID f1099OID = null;
            dynamic userData = new ExpandoObject();
            TaxReturnData taxReturnData = null;
            long userId = 0;
            long formOIDID = 0;

            try
            {
                var isEligibilityCheckFailed = false;

                taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(taxReturn.TaxReturnData.ToString());
                //Vincent-22 July 2014- Remove the unwanted Value condition in UserID
                userId = Utilities.ConvertToLong(taxReturn.userId);

                if (taxReturnData != null)
                {
                    //Retreiving TaxObject from database
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);
                }

                //Creating Instance if Income section is Null
                if (taxObject != null)
                {
                    //Creating Instance if Income section is Null
                    if (taxObject.Income == null)
                    {
                        taxObject.Income = new Income();
                        taxObject.Income.Form1099OID = new List<Form1099OID>();
                    }
                    else
                    {
                        //Yogalakshmi - 21st May 2014 - Null check
                        if (taxObject.Income.Form1099OID == null)
                        {
                            taxObject.Income.Form1099OID = new List<Form1099OID>();
                        }
                    }

                    //Converting Json to Form1099OID by DeSerializing
                    f1099OID = JsonConvert.DeserializeObject<Form1099OID>(taxReturnData.TaxData);

                    if (taxObject.Income.Form1099OID != null && taxObject.Income.Form1099OID.Any())
                    {
                        int index = taxObject.Income.Form1099OID.FindIndex(frm => frm.Form1099OIDId == f1099OID.Form1099OIDId);

                        if (index < 0)
                        {
                            f1099OID.Form1099OIDId = taxObject.Income.Form1099OID.Max(frm => frm.Form1099OIDId) + 1;

                            //Adding new Form1099OID to the TaxObject 1099OIDList
                            taxObject.Income.Form1099OID.Add(f1099OID);
                        }
                        else
                        {
                            taxObject.Income.Form1099OID[index] = f1099OID;
                        }
                    }
                    else
                    {
                        f1099OID.Form1099OIDId = 1;
                        taxObject.Income.Form1099OID.Add(f1099OID);
                    }

                    if (taxObject.ErrorMessages == null)
                    {
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    }

                    //Retrieving Error Message list from Database
                    //var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessage = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
                    var errorMessagesListFromDB = new ErrorMessages(errorMessage);

                    // Clear the Error messages
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FORM_OID);

                    if (taxObject.Income.Form1099OID != null && taxObject.Income.Form1099OID.Any())
                    {
                        //Invoking Required Field Validations Method
                        F1099OIDRequiredFieldCheck(taxObject.Income.Form1099OID, taxObject.ErrorMessages, errorMessagesListFromDB);

                        //Invoking Business Field Validations Method
                        F1099OIDValidationsCheck(taxObject.Income.Form1099OID, taxObject.ErrorMessages, errorMessagesListFromDB);

                        //Yogalakshmi - 25th August 2014 - When checkbox is unchecked then the list is made null
                        foreach (var form1099OID in taxObject.Income.Form1099OID)
                        {
                            if (form1099OID != null)
                            {
                                if (form1099OID.HasToReportTaxExempt != true)
                                {
                                    form1099OID.TaxExemptStateCodeAndAmount = null;
                                }
                            }
                        }
                    }

                    // Clear the Error messages
                    //messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EARNED_INCOME_CREDIT);
                    //02Sep2014-Thileep Changed code to Remove EIC errormessages which has Message Type EI only
                    taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT && (err.MessageType == Constants.MESSAGE_TYPE_EI));


                    //14thJuly2014 Ashok - Added logic for Clearing EIC Worksheet, Form 8862 and EIC classes when failing EIC eligibility
                    //Workflow Validation check.
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    input.ErrorMessages = errorMessagesListFromDB;

                    //Check if EIC with espect to AGI
                    var output = AGICheck(taxObject, input);

                    //02Sep2014-  Thileep added  to Remove EIC Error messages when EIC Eligibility fails
                    if (!output.HasEarnedIncomeCredit)
                    {
                        taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT &&
                            (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V || err.MessageType == Constants.MESSAGE_TYPE_BR));

                    }
                    //Workflow Validation Section
                    //dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    //input.Tax1040Object = taxObject;

                    input.ErrorMessages = errorMessagesListFromDB;
                    output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new
                        F1099OIDBusinessValidation(), input));

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
                    federalSummaryInput.ErrorMessages = errorMessagesListFromDB;
                    output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                             WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), federalSummaryInput));

                    //Saravanan N - 2nd June, 2014 - Invoking Business Rules Validation Workflow
                    EligibilityCheckValidation(taxObject, errorMessagesListFromDB);

                    //Check whether any Eligibility Check found.
                    isEligibilityCheckFailed = taxObject.ErrorMessages.Any(errMsg => errMsg.Topic ==
                        Constants.TOPIC_INTEREST_INCOME && errMsg.ErrorCode.Equals(Constants.INTEREST_INCOME_TAXABLE_INTEREST_EXCEEDS_LIMIT));

                    taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);
                }
                userData.UserDataId = taxReturnData.UserDataId;
                userData.Form1099OIDId = f1099OID.Form1099OIDId;
                userData.isEligibilityCheckFailed = isEligibilityCheckFailed;

                //01-Sep-2014 Bhavani Audit functionality implementation
                string description = formOIDID > 0
                  ? "Update Form1099OID" + formOIDID + ", ClassName: {0}, Method Name: {1}"
                  : "Persist Form1099OID" + formOIDID + ", ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userId, userData.UserDataId, description, this.GetType().Name, Constants.TOPIC_INTEREST_INCOME, Constants.TOPIC_FORM_OID);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:InterestIncomeRepository,Method Name:PersistTaxReturnForm1099OIDData", ex);
            }

            return userData;
        }

        //Saravanan N - 9th May, 2014 - Param changed to UserDTO.
        /// <summary>
        /// Delete and Persist OID
        /// </summary>
        /// <param name="userDTO"></param>
        public void DeleteAndPersist1099OID(UserDTO userDTO, Tax1040.BusinessObject.Tax1040 refTaxObject = null) // 05Jun2014 Sathish added optional parameter taxobject used in delete spouse info while changing filling status MFJ to single
        {
            try
            {
                long form1099OIDId = userDTO.FormId.ConvertToLong();

                // 05Jun2014 Sathish check optional parameter which is used in deleting spouse info
                if (refTaxObject == null)
                    //Retrieving TaxObject from database
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong());
                else
                    taxObject = refTaxObject;

                //Converting Json to Form1099OID by DeSerializing
                if (taxObject != null && taxObject.Income != null && taxObject.Income.Form1099OID != null)
                {
                    int index = taxObject.Income.Form1099OID.FindIndex(form => form.Form1099OIDId == form1099OIDId);

                    if (index >= 0)
                    {


                        //Delete the current Form1099OID object.
                        taxObject.Income.Form1099OID.RemoveAt(index);

                        //Clear the error messages for the corresponding form
                        messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FORM_OID, form1099OIDId);


                        // 17Jun2014 Sathish removed eligibility rule InterestIncome_ER10 on delete

                        //Retrieving Error Message list from Database
                        //var errorMessage = messageRepository.GetErrorMessages();
                        var errorMessage = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
                        var errorMessagesListFromDB = new ErrorMessages(errorMessage);

                        taxObject.ErrorMessages.RemoveAll(errMsg => errMsg.ErrorCode == "InterestIncome_ER10");
                        dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                        input = new Microsoft.Activities.Extensions.WorkflowArguments();
                        input.Tax1040Object = taxObject;
                        input.ErrorMessages = errorMessagesListFromDB;
                        var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary
                           (WorkflowInvoker.Invoke(new F1040EZTaxableInterestEligibility(), input));

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
                        federalSummaryInput.ErrorMessages = errorMessagesListFromDB;
                        output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                                 WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), federalSummaryInput));

                        //Added by Ashok for EIC Eligibility Check

                        // Clear the Error messages
                        //messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_EARNED_INCOME_CREDIT);
                        //02Sep2014-Thileep Changed code to Remove EIC errormessages which has Message Type EI only
                        taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT && (err.MessageType == Constants.MESSAGE_TYPE_EI));


                        dynamic eicEligbilityInput = new Microsoft.Activities.Extensions.WorkflowArguments();
                        eicEligbilityInput.Tax1040Object = taxObject;
                        eicEligbilityInput.ErrorMessages = errorMessagesListFromDB;
                        //Check if EIC with espect to AGI
                        output = AGICheck(taxObject, input);

                        //02Sep2014-  Thileep added  to Remove EIC Error messages when EIC Eligibility fails
                        if (!output.HasEarnedIncomeCredit)
                        {
                            taxObject.ErrorMessages.RemoveAll(err => err.Topic == Constants.TOPIC_EARNED_INCOME_CREDIT &&
                                (err.MessageType == Constants.MESSAGE_TYPE_RF || err.MessageType == Constants.MESSAGE_TYPE_V || err.MessageType == Constants.MESSAGE_TYPE_BR));

                        }

                    }
                }
                //Persist latest TaxObject.
                Utilities.PersistTaxObject(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong(), taxObject);
                
                //01-Sep-2014 Bhavani Audit functionality implementation
                string description = "Delete Form1099OID " + userDTO.FormId + ", ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.TOPIC_INTEREST_INCOME, Constants.TOPIC_FORM_OID);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:InterestIncomeRepository,Method Name:DeleteAndPersist1099OID", ex);
            }
        }
        #endregion

        #region Interest Income
        /// <summary>
        /// Get All INT and OID data.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        public System.Tuple<Income, IEnumerable<ErrorMessage>> GetAllInterestIncome(UserDTO userDTO)
        {
            Income income = null;
            IEnumerable<ErrorMessage> lstTaxObjectErrors = null;

            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(Utilities.ConvertToLong(userDTO.UserId),
                Utilities.ConvertToLong(userDTO.UserDataId));

            try
            {
                if (taxObject != null)
                {
                    if (taxObject.Income != null)
                    {
                        income = taxObject.Income;

                        //Get the TaxPayer names
                        var taxPayerAndSpouseNames = Utilities.GetTaxPayerAndSpouseName(taxObject);

                        //TODO: Saravanan N - 27th May, 2014 - This code has to be refactored.
                        //Form 1099INT
                        if (income.Form1099INT != null)
                        {
                            foreach (var form1099INT in income.Form1099INT)
                            {
                                if (form1099INT != null)
                                {
                                    switch (form1099INT.Owner)
                                    {
                                        case OwnerType.PrimaryTaxPayer:
                                            form1099INT.RecipientName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item2;
                                            break;
                                        case OwnerType.Spouse:
                                            form1099INT.RecipientName = taxPayerAndSpouseNames.Item3 + " " + taxPayerAndSpouseNames.Item4;
                                            break;
                                        case OwnerType.Joint:
                                            form1099INT.RecipientName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item3;
                                            break;
                                        default:
                                            form1099INT.RecipientName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item2;
                                            break;
                                    }
                                }
                            }
                        }

                        //F1099OID
                        if (income.Form1099OID != null)
                        {
                            foreach (var form1099OID in income.Form1099OID)
                            {
                                if (form1099OID != null)
                                {
                                    switch (form1099OID.Owner)
                                    {
                                        case OwnerType.PrimaryTaxPayer:
                                            form1099OID.RecipientName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item2;
                                            break;
                                        case OwnerType.Spouse:
                                            form1099OID.RecipientName = taxPayerAndSpouseNames.Item3 + " " + taxPayerAndSpouseNames.Item4;
                                            break;
                                        case OwnerType.Joint:
                                            form1099OID.RecipientName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item3;
                                            break;
                                        default:
                                            form1099OID.RecipientName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item2;
                                            break;
                                    }
                                }
                            }
                        }
                    }

                    if (taxObject.ErrorMessages != null)
                    {
                        //If ErrorMessages doesn't have any object it returns count as 1 for NULL object. So removing this NULL object from the list.
                        taxObject.ErrorMessages.RemoveAll(err => err == null);

                        if (taxObject.ErrorMessages.Count > 0)
                        {
                            //Get Unemployment Compensation related error messages.
                            // 17Jun2014 Sathish reterived all the error message including eligibility rule for navigation to hot stop from summary
                            //Praveen 17 July 2014 Error Message displayed based on Error Type(Properly Shuffled)
                            lstTaxObjectErrors = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_FORM_INT
                                                                                    || err.Topic == Constants.TOPIC_FORM_OID
                                                                                    || err.Topic == Constants.TOPIC_INTEREST_INCOME).OrderBy(x => x.ErrorType);

                        }
                    }
                }

                //01-Sep-2014 Bhavani Audit functionality implementation
                string description = "Get Form1099INT and Form1099OID List, ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.TOPIC_INTEREST_INCOME, Constants.TOPIC_FORM_INT + "||" + Constants.TOPIC_FORM_OID);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:InterestIncomeRepository,Method Name:GetAllInterestIncome", ex);
            }

            return new System.Tuple<Income, IEnumerable<ErrorMessage>>(income, lstTaxObjectErrors);
        }
        #endregion

        #region Interest Income Eligibility
        /// <summary>
        /// Persist InterestIncome Eligibility related data.
        /// </summary>
        /// <param name="taxReturn"></param>
        /// <returns></returns>
        public dynamic PersistInterestIncomeEligibilityData(dynamic taxReturn)
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            List<ErrorMessage> errorMessageList;
            dynamic userData = null;
            UserDTO userDTO = null;
            InterestIncomeEligibility interestIncomeEligibility = null;
            bool isNew = false;

            try
            {
                userDTO = JsonConvert.DeserializeObject<UserDTO>(taxReturn.UserDTO.ToString());
                interestIncomeEligibility = JsonConvert.DeserializeObject<InterestIncomeEligibility>(taxReturn.InterestIncomeEligibility.ToString());

                if (userDTO != null)
                {
                    //Retreiving TaxObject from database
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                    //Already No Eligibility exists for this Interest Income, then Create new object.
                    if (taxObject.F1040EZEligibility == null)
                    {
                        taxObject.F1040EZEligibility = new F1040EZEligibility();
                        isNew = true;
                    }

                    if (interestIncomeEligibility != null)
                    {
                        //Persist InterestIncomeEligibility Instance.
                        taxObject.F1040EZEligibility.InterestIncomeEligibility = interestIncomeEligibility;
                        isNew = false;
                    }

                    //Create Error message list if iterator is Null.
                    if (taxObject.ErrorMessages == null)
                    {
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    }

                    //Initializing Out Parameter
                    errorMessageList = new List<ErrorMessage>();

                    //Retrieving Error Message list from Database
                    //var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessage = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
                    var errorMessages = new ErrorMessages(errorMessage);

                    // Clear the Error messages
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, topic: Constants.TOPIC_INTEREST_INCOME, errorCode: "InterestIncome_ER");

                    //Invoking Business Rules Validation Workflow
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    input.ErrorMessages = errorMessages;
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new
                        InterestIncomeEligibilityCheck(), input));

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
                    federalSummaryInput.ErrorMessages = errorMessages;
                    output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(
                                                             WorkflowInvoker.Invoke(new FederalSummaryWithNoValidation(), federalSummaryInput));


                    var hasEligibilityDiagnostics = false;
                    var userDataId = 0L;
                    if (taxObject != null)
                    {
                        userDataId = Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);
                        hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => em.Topic ==
                            Constants.TOPIC_INTEREST_INCOME && em.ErrorCode.StartsWith("InterestIncome_ER"));
                    }
                    errorMessageList = taxObject.ErrorMessages;
                    userData = new Tuple<long, bool>(userDataId, hasEligibilityDiagnostics);

                  
                    //01-Sep-2014 Bhavani Audit functionality implementation
                    string description = isNew
                        ? "Persist InterestIncomeEligibility, ClassName: {0}, Method Name: {1}"
                        : "Update InterestIncomeEligibility, ClassName: {0}, Method Name: {1}";
                    
                    Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.Tab_INCOME_ER,Constants.TOPIC_INTEREST_INCOME);

                }

                return userData;
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:InterestIncomeRepository,Method Name:PersistInterestIncomeEligibilityData", ex);
            }

            return new ExpandoObject();
        }

        //Saravanan N - 9th May, 2014 - Parameter changed as UserDTO.
        /// <summary>
        /// Persist InterestIncome Eligibility related data.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        public InterestIncomeEligibility GetTaxReturnInterestIncomeEligibilityData(UserDTO userDTO)
        {
            string taxReturnData = string.Empty;
            InterestIncomeEligibility intIncomeEligibility = null;

            try
            {
                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong());

                if (taxObject != null && taxObject.F1040EZEligibility != null)
                {
                    intIncomeEligibility = taxObject.F1040EZEligibility.InterestIncomeEligibility;
                }

                //01-Sep-2014 Bhavani Audit functionality implementation
                string description = "Get InterestIncomeEligibility, ClassName: {0}, Method Name: {1}";
                Utilities.PersistAuditInfo(userDTO.UserId, userDTO.UserDataId, description, this.GetType().Name, Constants.Tab_INCOME_ER, Constants.TOPIC_INTEREST_INCOME);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:InterestIncomeRepository,Method Name:GetTaxReturnInterestIncomeEligibilityData", ex);
            }

            return intIncomeEligibility;
        }


        #endregion

        #region Business Validations

        //TODO - Required field Validations still pending - 
        /// <summary>
        /// INT Required Field Checking.
        /// </summary>
        /// <param name="form1099INTList"></param>
        /// <param name="errorMessageFromTaxObject"></param>
        /// <param name="errorMessagesFromDB"></param>
        private void F1099INTRequiredFieldCheck(List<Form1099INT> form1099INTList, List<ErrorMessage> errorMessageFromTaxObject,
            ErrorMessages errorMessagesFromDB)
        {
            ErrorMessage errorMessage;
            foreach (var form1099INT in form1099INTList)
            {
                if (form1099INT != null)
                {
                    var formINT_ID = form1099INT.Form1099INTId;

                    //Required entry #1.
                    if (filingStatus == FilingStatus.MarriedFilingJointly && form1099INT.Owner == OwnerType.None)
                    {
                        errorMessage = errorMessagesFromDB[Constants.INT_WHOSE_INCOME_IS_THIS];
                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
                    }

                    //Required entry #2.
                    if (form1099INT.Payer == null || string.IsNullOrEmpty(form1099INT.Payer.PayerName.Trim()))
                    {
                        errorMessage = errorMessagesFromDB[Constants.INT_PAYER_NAME];
                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
                    }

                    //Required entry #3
                    //Yogalakshmi - 21st May 2014 - Changed 0 to null
                    if (form1099INT.InterestIncome == null && form1099INT.USBondsTreasury == null)
                    {
                        errorMessage = errorMessagesFromDB[Constants.INT_INTEREST_INCOME];
                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
                    }

                    //Required Entry # 4
                    //Yogalakshmi - 21st May 2014 - Changed 0 to null 
                    //Modified by vivek on 10-jun-14 TAX1040-14000
                    //Yogalakshmi - 6th August 2014 - if Condition check separated for different error message to display
                    if (form1099INT.TaxExemptInterest.HasValue)
                    {
                        int loopIndex = 0;
                        //Yogalakshmi - 21st August 2014 - Tax Exempt State And Amount made as list
                        if (form1099INT.TaxExemptStateCodeAndAmount != null)
                        {
                            foreach (var taxExempt in form1099INT.TaxExemptStateCodeAndAmount)
                            {
                                if(taxExempt != null)
                                {
                                    if (taxExempt.TaxExemptInterestState != null && taxExempt.TaxExemptInterestState.StateId <= 0)
                                    {
                                        errorMessage = errorMessagesFromDB[Constants.INT_STATE_TAX_EXEMPT_STATE_CODE];
                                        errorMessage.FieldName = errorMessage.FieldName + loopIndex;
                                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
                                    }

                                    if (!taxExempt.StateExemptInterest.HasValue)  //10Jul2014 Sathish changed to new state bo
                                    {
                                        errorMessage = errorMessagesFromDB[Constants.INT_STATE_TAX_EXEMPT_AMOUNT];
                                        errorMessage.FieldName = errorMessage.FieldName + loopIndex;
                                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
                                    }
                                }

                                loopIndex++;
                            }
                        }
                    }


                    if (form1099INT.Form1099StateInfo != null)
                    {
                        //Required Entry # 10
                        if (form1099INT.Form1099StateInfo[0] != null && form1099INT.Form1099StateInfo[0].StateTaxWithholdingAmount.HasValue)
                        {
                            if (form1099INT.Form1099StateInfo[0].State != null
                                && form1099INT.Form1099StateInfo[0].State.StateId <= 0) //10Jul2014 Sathish changed to new state bo
                            {
                                errorMessage = errorMessagesFromDB[Constants.INT_BOX11_STATE_CODE1_MISSING];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
                            }
                        }

                        //Required Entry # 11
                        if (form1099INT.Form1099StateInfo[1] != null && form1099INT.Form1099StateInfo[1].StateTaxWithholdingAmount.HasValue)
                        {
                            if (form1099INT.Form1099StateInfo[1].State != null
                                && form1099INT.Form1099StateInfo[1].State.StateId <= 0) //10Jul2014 Sathish changed to new state bo
                            {
                                errorMessage = errorMessagesFromDB[Constants.INT_BOX11_STATE_CODE2_MISSING];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
                            }
                        }

                        //Saravanan N - 22nd Aug, 2014 - Validation # 16 and 17 added as per spec. Ver 2.6 changes
                        if (form1099INT.TaxExemptStateCodeAndAmount != null)
                        {

                            int loopIdx = 0;
                            foreach (var taxExemptState in form1099INT.TaxExemptStateCodeAndAmount)
                            {
                                //Required Entry # 16
                                if (taxExemptState != null)
                                {
                                    if (taxExemptState.TaxExemptInterestState != null)
                                    {
                                        if (taxExemptState.TaxExemptInterestState.StateId > 0)  //<dd46> has selected valid value.
                                        {
                                            if (!taxExemptState.StateExemptInterest.HasValue)  //<47> doesn't have value.
                                            {
                                                errorMessage = errorMessagesFromDB[Constants.INT_STATE_TAX_EXEMPT_AMOUNT];
                                                errorMessage.FieldName = errorMessage.FieldName + loopIdx;
                                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
                                            }
                                        }
                                    }
                                }

                                //Required Entry # 17
                                if (taxExemptState.StateExemptInterest.HasValue)  //<47> has value.
                                {
                                    if (taxExemptState.TaxExemptInterestState != null)
                                    {
                                        if (taxExemptState.TaxExemptInterestState.StateId == 0)  //<dd46> has selected none.
                                        {
                                            errorMessage = errorMessagesFromDB[Constants.INT_STATE_TAX_EXEMPT_STATE_CODE];
                                            errorMessage.FieldName = errorMessage.FieldName + loopIdx;
                                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
                                        }
                                    }
                                    else
                                    {
                                        errorMessage = errorMessagesFromDB[Constants.INT_STATE_TAX_EXEMPT_STATE_CODE];
                                        errorMessage.FieldName = errorMessage.FieldName + loopIdx;
                                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
                                    }
                                }

                                loopIdx++;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// INT Validations Checking.
        /// </summary>
        /// <param name="form1099INTList"></param>
        /// <param name="errorMessageList"></param>
        /// <param name="errorMessages"></param>
        private void F1099INTValidationsCheck(List<Form1099INT> form1099INTList, List<ErrorMessage> errorMessageList, ErrorMessages errorMessages)
        {
            ErrorMessage errorMessage;

            foreach (var form1099INT in form1099INTList)
            {
                if (form1099INT != null && form1099INT.Payer != null)
                {
                    //Validatiion Entry #2
                    if (!string.IsNullOrEmpty(form1099INT.Payer.PayerIdentificationNumber))
                    {
                        string payerIdentificationNumber = form1099INT.Payer.PayerIdentificationNumber;
                        payerIdentificationNumber = Utilities.RemoveHiphen(payerIdentificationNumber);

                        isValidNumeric = Utilities.IsValidRegexPattern(payerIdentificationNumber, "^[0-9]+$");
                        isHavingNineChars = (payerIdentificationNumber.Trim().Length == 9);
                        if (!isValidNumeric || !isHavingNineChars || payerIdentificationNumber == Constants.NineZeros ||
                                 payerIdentificationNumber == Constants.NineNines)
                        {
                            errorMessage = errorMessages[Constants.INT_PAYER_IDENTIFICATION_NUMBER];
                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099INT.Form1099INTId, errorMessage);
                        }
                    }

                    //Validatiion Entry #1
                    if (!string.IsNullOrEmpty(form1099INT.Payer.PayerName))
                    {
                        //Check for Business Name Valid            
                        //Yogalakshmi - 21st May 2014 - Validate only for alphabets 
                        var isValid = Utilities.IsValidRegexPattern(form1099INT.Payer.PayerName, "^[A-Za-z0-9 -]+$");
                        if (!isValid)
                        {
                            errorMessage = errorMessages[Constants.INT_PAYER_NAME_SPECIAL_CHARACTERS];
                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099INT.Form1099INTId, errorMessage);
                        }
                    }

                    //Validatiion Entry #5
                    //Defect TAX1040-13968 - Vivek - 6-jun-14
                    //Yogalakshmi - 21st August 2014 - Tax Exempt State And Amount made as list
                    if (form1099INT.TaxExemptStateCodeAndAmount != null)
                    {
                        int loopIdx = 0;

                        foreach (var taxExempt in form1099INT.TaxExemptStateCodeAndAmount)
                        {
                            if (taxExempt.StateExemptInterest > form1099INT.TaxExemptInterest)
                            {
                                errorMessage = errorMessages[Constants.INT_STATE_TAX_EXEMPT_INTEREST_EXCEEDS_TAX_EXEMPT_INTEREST];
                                errorMessage.FieldName = errorMessage.FieldName + loopIdx;
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099INT.Form1099INTId, errorMessage);
                            }

                            loopIdx++;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// OID Required Field Checking
        /// </summary>
        /// <param name="form1099OIDList"></param>
        /// <param name="errorMessageList"></param>
        /// <param name="errorMessages"></param>
        private void F1099OIDRequiredFieldCheck(List<Form1099OID> form1099OIDList, List<ErrorMessage> errorMessageList, ErrorMessages errorMessages)
        {
            ErrorMessage errorMessage;

            foreach (var form1099OID in form1099OIDList)
            {
                if (form1099OID != null)
                {
                    var formOID_ID = form1099OID.Form1099OIDId;

                    //Required entry #14.
                    if (filingStatus == FilingStatus.MarriedFilingJointly && form1099OID.Owner == OwnerType.None)
                    {
                        errorMessage = errorMessages[Constants.OID_WHOSE_INCOME_IS_THIS];
                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, formOID_ID, errorMessage);
                    }

                    //Required entry #15.
                    //Saravanan N - 30th July, 2014 - Trim() added for the Defect # 14292
                    if (form1099OID.Payer == null || string.IsNullOrEmpty(form1099OID.Payer.PayerName.Trim()))
                    {
                        errorMessage = errorMessages[Constants.OID_PAYER_NAME];
                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, formOID_ID, errorMessage);
                    }

                    //Required entry #5
                    //Yogalakshmi - 21st May 2014 - Changed 0 to null and used && condition so that any one field is mandatory.
                    if (!form1099OID.OriginalIssueDiscount.HasValue && !form1099OID.OtherPeriodicInterest.HasValue &&
                        !form1099OID.USTreasuryObligations.HasValue)
                    {
                        errorMessage = errorMessages[Constants.OID_ORIGINAL_ISSUE_DISCOUNT];
                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, formOID_ID, errorMessage);
                    }

                    //Required entry #6.
                    if (form1099OID.HasToReportTaxExempt.HasValue && form1099OID.HasToReportTaxExempt == true)
                    {
                        if (!form1099OID.TaxExemptInterest.HasValue)
                        {
                            errorMessage = errorMessages[Constants.OID_TAX_EXEMPT_INTEREST];
                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, formOID_ID, errorMessage);
                        }
                    }

                    //Required entry #7.
                    //Yogalakshmi - 6th August 2014 - if Condition check separated for different error message to display
                    //25 Aug 2014-Vincent- Maded a changes to Condition
                    if (form1099OID.TaxExemptInterest.HasValue)
                    {
                        int loopIndex = 0;
                        if (form1099OID.TaxExemptStateCodeAndAmount != null)
                        {
                            foreach (var taxExemptInterest in form1099OID.TaxExemptStateCodeAndAmount)
                            {
                                //Defect TAX1040-14000 - Saravanan N - 10th June, 2014 - && changed to ||
                                if (taxExemptInterest != null && taxExemptInterest.TaxExemptInterestState != null)
                                {
                                    if (taxExemptInterest.TaxExemptInterestState.StateId == 0)
                                    {
                                        errorMessage = errorMessages[Constants.OID_STATE_TAX_EXEMPT_STATE_CODE];
                                        errorMessage.FieldName = errorMessage.FieldName + loopIndex;
                                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, formOID_ID, errorMessage);
                                    }
                                    if (!taxExemptInterest.StateExemptInterest.HasValue) //10Jul2014 Sathish changed to new state bo
                                    {
                                        errorMessage = errorMessages[Constants.OID_STATE_TAX_EXEMPT_AMOUNT];
                                        errorMessage.FieldName = errorMessage.FieldName + loopIndex;
                                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, formOID_ID, errorMessage);
                                    }
                                }
                                loopIndex++;
                            }
                        }
                    }

                    //Required entry #8.
                    if (form1099OID.HasToReportAdjustment.HasValue && form1099OID.HasToReportAdjustment == true)
                    {
                        if (!form1099OID.AdjustmentAmount.HasValue)
                        {
                            errorMessage = errorMessages[Constants.OID_ADUJUSTMENT];
                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, formOID_ID, errorMessage);
                        }
                    }

                    //Required Entry # 12
                    if (form1099OID.Form1099StateInfo != null)
                    {
                        if (form1099OID.Form1099StateInfo[0] != null && form1099OID.Form1099StateInfo[0].StateTaxWithholdingAmount.HasValue)
                        {
                            if (form1099OID.Form1099StateInfo[0].State != null
                                && form1099OID.Form1099StateInfo[0].State.StateId <= 0) //10Jul2014 Sathish changed to new state bo
                            {
                                errorMessage = errorMessages[Constants.OID_BOX11_STATE_CODE1_MISSING];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, formOID_ID, errorMessage);
                            }
                        }

                        //Required Entry # 13
                        if (form1099OID.Form1099StateInfo[1] != null && form1099OID.Form1099StateInfo[1].StateTaxWithholdingAmount.HasValue)
                        {
                            if (form1099OID.Form1099StateInfo[1].State != null
                                && form1099OID.Form1099StateInfo[1].State.StateId <= 0) //10Jul2014 Sathish changed to new state bo
                            {
                                errorMessage = errorMessages[Constants.OID_BOX11_STATE_CODE2_MISSING];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, formOID_ID, errorMessage);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// OID Validations Checking
        /// </summary>
        /// <param name="form1099OIDList"></param>
        /// <param name="errorMessageList"></param>
        /// <param name="errorMessages"></param>
        private void F1099OIDValidationsCheck(List<Form1099OID> form1099OIDList, List<ErrorMessage> errorMessageList, ErrorMessages errorMessages)
        {
            bool IsValid = true;
            ErrorMessage errorMessage;

            foreach (var form1099OID in form1099OIDList)
            {
                if (form1099OID != null)
                {
                    if (form1099OID.Payer != null)
                    {
                        //Validation Entry #2
                        if (!string.IsNullOrEmpty(form1099OID.Payer.PayerIdentificationNumber))
                        {
                            string payerIdentificationNumber = form1099OID.Payer.PayerIdentificationNumber;
                            payerIdentificationNumber = Utilities.RemoveHiphen(payerIdentificationNumber);

                            isValidNumeric = Utilities.IsValidRegexPattern(payerIdentificationNumber, "^[0-9]+$");
                            isHavingNineChars = (payerIdentificationNumber.Trim().Length == 9);
                            if (!isValidNumeric || !isHavingNineChars || payerIdentificationNumber == Constants.NineZeros ||
                                     payerIdentificationNumber == Constants.NineNines)
                            {
                                errorMessage = errorMessages[Constants.OID_PAYER_IDENTIFICATION_NUMBER];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, errorMessage);
                            }
                        }

                        //Validatiion Entry #3
                        if (!string.IsNullOrEmpty(form1099OID.Payer.PayerName))
                        {
                            //Defect TAX1040-13996 - Saravanan N - 11th June, 2014 - RegularExpression changed to accept AlphaNumeric, hyphen and 
                            //space not any special characters.
                            //Check for Business Name Valid            
                            IsValid = Utilities.IsValidRegexPattern(form1099OID.Payer.PayerName, "^[A-Za-z0-9 -]+$");
                            if (!IsValid)
                            {
                                errorMessage = errorMessages[Constants.OID_PAYER_NAME_SPECIAL_CHARACTERS];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, errorMessage);
                            }
                        }
                    }

                    //Validatiion Entry #6
                    //25 Aug 2014-Vincent- Maded a changes to Condition
                    if (form1099OID.TaxExemptStateCodeAndAmount != null)
                    {
                        int loopIdx = 0;
                        foreach (var stateExemptInterest in form1099OID.TaxExemptStateCodeAndAmount)
                        {
                            if (stateExemptInterest != null && stateExemptInterest.StateExemptInterest != null)
                            {
                                if (stateExemptInterest.StateExemptInterest > form1099OID.TaxExemptInterest)
                                {
                                    errorMessage = errorMessages[Constants.OID_STATE_TAX_EXEMPT_INTEREST_EXCEEDS_TAX_EXEMPT_INTEREST];
                                    errorMessage.FieldName = errorMessage.FieldName + loopIdx;
                                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, errorMessage);
                                }
                            }

                            loopIdx++;
                        }
                    }
                }
            }
        }
        #endregion

        #region Common Methods
        /// <summary>
        /// Check the Eligiblity validations.
        /// </summary>
        /// <param name="taxObject"></param>
        /// <param name="errorMessagesListFromDB"></param>
        private void EligibilityCheckValidation(JTL.Tax1040.BusinessObject.Tax1040 taxObject, ErrorMessages errorMessagesListFromDB)
        {
            dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();

            //Saravanan N - 2nd June, 2014 - Invoking Eligibility Check Workflow
            //Clear the EligibilityRule 10 already exists.
            taxObject.ErrorMessages.RemoveAll(errMsg => errMsg.ErrorCode == "InterestIncome_ER10");
            input = new Microsoft.Activities.Extensions.WorkflowArguments();
            input.Tax1040Object = taxObject;
            input.ErrorMessages = errorMessagesListFromDB;
            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary
                (WorkflowInvoker.Invoke(new F1040EZTaxableInterestEligibility(), input));
        }

        #endregion

        private dynamic AGICheck(JTL.Tax1040.BusinessObject.Tax1040 taxObject, dynamic input)
        {
            // 16Jul2014 Sathish commented the above code and checked EIC eligibility using work flow
            //21Aug2014 - Ashok Kumar added EIC eligibility check workflow instead of without validation worklfow

            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZEICEligibilityRuleCheck(), input));

            Utilities.EICEligibilityCheck(taxObject);
            return output;
        }
    }
}


