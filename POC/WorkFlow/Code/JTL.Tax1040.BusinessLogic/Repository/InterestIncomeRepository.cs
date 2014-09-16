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
 */

using System;
using JTL.Tax1040.DataAccess;
using Tax1040WorkFlow.WorkFlow.Activities;
using System.Activities;
using Newtonsoft.Json;
using System.Collections.Generic;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;
using System.Linq;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities;

namespace JTL.Tax1040.BusinessLogic
{
    public class InterestIncomeRepository : IInterestIncomeRepository
    {
        ITaxReturnDataService taxReturnDataService;
        private readonly MessagesRepository messageRepository;
        JTL.Tax1040.BusinessObject.Tax1040 taxObject;
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="InterestIncomeRepository"/> class.
        /// </summary>
        public InterestIncomeRepository()
        {
            taxReturnDataService = new TaxReturnDataService();
            messageRepository=new MessagesRepository();
        }
        #endregion

        #region F1099INT
        //Saravanan N - 9th May, 2014 - Code moved from Controller and refactored.
        /// <summary>
        /// Returns INT data.
        /// </summary>
        /// <returns></returns>
        public Form1099INT GetTaxReturn1099INTData(UserDTO userDTO)
        {
            List<Form1099INT> lstF1099INT;
            Form1099INT form1099INT = null;

            long F1099INTId = Utilities.ConvertToLong(userDTO.FormId);

            Income income = GetIncomeFromTaxobject(userDTO);

            if (income != null && income.Form1099INT != null)
            {
                lstF1099INT = income.Form1099INT;

                if (lstF1099INT.Any())
                {
                    int index = lstF1099INT.FindIndex(F1099INT => F1099INT.Form1099INTId == F1099INTId);

                    if (index >= 0)
                    {
                        form1099INT = lstF1099INT[index];
                    }
                }
            }

            return form1099INT;
        }

        //Saravanan N - 9th May, 2014 - Code moved from Controller and refactored.
        /// <summary>
        /// Returns List of INT data.
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        public System.Tuple<List<Form1099INT>, List<ErrorMessage>> GetTaxReturn1099INTListandErrorList(UserDTO userDTO)
        {
            List<Form1099INT> lstF1099INT = null;
            List<ErrorMessage> lstTaxObjectErrors = null;

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

            return new System.Tuple<List<Form1099INT>, List<ErrorMessage>>(lstF1099INT, lstTaxObjectErrors);
        }

        //Saravanan N - 9th May, 2014 - Code refactored.
        /// <summary>
        /// Persists the tax return data.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="sessionData">The session data.</param>
        /// <param name="F1099INTData"></param>
        /// <param name="historyData"></param>
        /// <param name="userDataId"></param>
        /// <param name="errorMessageList"></param>
        /// <returns></returns>
        public dynamic PersistTaxReturnForm1099INTData(long userId, TaxReturnData taxReturnData)
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            try
            {
                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);

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
                        if (taxObject.Income.Form1099INT != null)
                        {
                            taxObject.Income.Form1099INT = new List<Form1099INT>();
                        }
                    }

                    //Converting Json to Form1099INT by DeSerializing
                    var form1099INT = JsonConvert.DeserializeObject<Form1099INT>(taxReturnData.TaxData);

                    if (taxObject.Income.Form1099INT != null && taxObject.Income.Form1099INT.Any())
                    {
                        int index = taxObject.Income.Form1099INT.FindIndex(frm => frm.Form1099INTId == form1099INT.Form1099INTId);

                        if (index < 0)
                        {
                            form1099INT.Form1099INTId = taxObject.Income.Form1099INT.Max(frm => frm.Form1099INTId) + 1;

                            //Adding new Form1099INT to the TaxObject 1099INTList
                            taxObject.Income.Form1099INT.Add(form1099INT);
                        }
                        else
                        {
                            taxObject.Income.Form1099INT[index] = form1099INT;
                        }
                    }
                    else
                    {
                        form1099INT.Form1099INTId = 1;
                        taxObject.Income.Form1099INT.Add(form1099INT);
                    }

                    if (taxObject.ErrorMessages == null)
                    {
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    }

                    //Retrieving Error Message list from Database
                    var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessagesListFromDB = new ErrorMessages(errorMessage);

                    // Clear the Error messages
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_INTEREST_INCOME);

                    if (taxObject.Income.Form1099INT != null && taxObject.Income.Form1099INT.Any())
                    {
                        //Invoking Required Field Validations Method
                        F1099INTRequiredFieldValidations(taxObject.Income.Form1099INT, taxObject.ErrorMessages, errorMessagesListFromDB);

                        //Invoking Business Field Validations Method
                        F1099INTBusinessFieldValidations(taxObject.Income.Form1099INT, taxObject.ErrorMessages, errorMessagesListFromDB);
                    }

                    //Invoking Business Rules Validation Workflow
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    input.ErrorMessages = errorMessagesListFromDB;
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary
                        (WorkflowInvoker.Invoke(new F1099INTBusinessValidationRules(), input));

                    taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);
                }

                return taxReturnData.UserDataId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Saravanan N - 9th May, 2014 - Code refactored.
        /// <summary>
        /// Delete INT by ID.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="form1099INTId"></param>
        /// <param name="userDataId"></param>
        public void DeleteAndPersist1099INT(UserDTO userDTO)
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            long form1099INTId = userDTO.FormId.ConvertToLong();
            try
            {
                //Retrieving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong());

                //Converting Json to Form1099INT by DeSerializing
                if (taxObject != null && taxObject.Income != null && taxObject.Income.Form1099INT != null)
                {
                    int index = taxObject.Income.Form1099INT.FindIndex(form => form.Form1099INTId == form1099INTId);

                    if (index >= 0)
                    {
                        //Delete the current Form1099INT object.
                        taxObject.Income.Form1099INT.RemoveAt(index);

                        //Clear the error messages for the corresponding form
                        messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_INTEREST_INCOME, form1099INTId);
                    }
                }
             
                //Persist latest TaxObject.
               Utilities.PersistTaxObject(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong(), taxObject);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }       
        #endregion

        #region F1099OID
        //Saravanan N - 9th May, 2014 - Code moved from Controller and refactored.
        /// <summary>
        /// Returns OID data.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        public Form1099OID GetTaxReturn1099OIDData(UserDTO userDTO)
        {
            Form1099OID frm1099OID = null;

            Income income = GetIncomeFromTaxobject(userDTO);

            if (income != null)
            {
                List<Form1099OID> lstForm10999OID = income.Form1099OID;

                if (lstForm10999OID != null && lstForm10999OID.Any())
                {
                    long F1099OID_Id = Utilities.ConvertToLong(userDTO.FormId);

                    int index = lstForm10999OID.FindIndex(F1099OID => F1099OID.Form1099OIDId == F1099OID_Id);

                    if (index >= 0)
                    {
                        frm1099OID = lstForm10999OID[index];
                    }
                }
            }

            return frm1099OID;
        }

        //Saravanan N - 9th May, 2014 - Code moved from Controller and refactored.
        /// <summary>
        /// Returns all OID data with Error List.
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        public System.Tuple<List<Form1099OID>, List<ErrorMessage>> GetTaxReturn1099OIDListandErrorList(UserDTO userDTO)
        {
            List<Form1099OID> lstForm10999OID = null;
            List<ErrorMessage> lstTaxObjectErrors = null;

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
 
            return new System.Tuple<List<Form1099OID>, List<ErrorMessage>>(lstForm10999OID, lstTaxObjectErrors);
        }

        /// <summary>
        /// Persists the tax return form1099 oid data.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="sessionData">The session data.</param>
        /// <param name="F1099OIDData">The F1099 oid data.</param>
        /// <param name="historyData">The history data.</param>
        /// <param name="userDataId">The user data identifier.</param>
        /// <param name="errorMessageList">The error message list.</param>
        /// <returns></returns>
        public dynamic PersistTaxReturnForm1099OIDData(long userId,TaxReturnData taxReturnData)
        {
            try
            {
                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);

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
                        if (taxObject.Income.Form1099OID != null)
                        {
                            taxObject.Income.Form1099OID = new List<Form1099OID>();
                        }
                    }

                    //Converting Json to Form1099OID by DeSerializing
                    var f1099OID = JsonConvert.DeserializeObject<Form1099OID>(taxReturnData.TaxData);

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
                    var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessages = new ErrorMessages(errorMessage);

                    // Clear the Error messages
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_INTEREST_INCOME);

                    if (taxObject.Income.Form1099OID != null && taxObject.Income.Form1099OID.Any())
                    {
                        //Invoking Required Field Validations Method
                        F1099OIDRequiredFieldValidations(taxObject.Income.Form1099OID, taxObject.ErrorMessages, errorMessages);

                        //Invoking Business Field Validations Method
                        F1099OIDBusinessFieldValidations(taxObject.Income.Form1099OID, taxObject.ErrorMessages, errorMessages);
                    }

                    //Workflow Validation Section
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;

                    input.ErrorMessages = errorMessages;
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1099OIDBusinessValidation(), input));

                    taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);
                }

                return taxReturnData.UserDataId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Saravanan N - 9th May, 2014 - Param changed to UserDTO.
        public void DeleteAndPersist1099OID(UserDTO userDTO)
        {
            try
            {
                long form1099OIDId = userDTO.FormId.ConvertToLong();

                //Retrieving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong());

                //Converting Json to Form1099OID by DeSerializing
                if (taxObject != null && taxObject.Income != null && taxObject.Income.Form1099OID != null)
                {
                    int index = taxObject.Income.Form1099OID.FindIndex(form => form.Form1099OIDId == form1099OIDId);

                    if (index >= 0)
                    {
                        //Delete the current Form1099OID object.
                        taxObject.Income.Form1099OID.RemoveAt(index);

                        //Clear the error messages for the corresponding form
                        messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_INTEREST_INCOME, form1099OIDId);
                    }
                }
                //Persist latest TaxObject.
                Utilities.PersistTaxObject(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong(), taxObject);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region InterestIncomeEligibility

        public dynamic PersistInterestIncomeEligibilityData(long userId, string sessionData, string intIncomeEligibilityData, string historyData, long userDataId, out List<ErrorMessage> errorMessageList)
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            string taxReturnData = string.Empty;
            try
            {
                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);

                //Creating Instance if F1040EZEligibility section is Null
                if (taxObject.F1040EZEligibility == null)
                {
                    taxObject.F1040EZEligibility = new F1040EZEligibility();
                }

                //Converting Json to InterestIncomeEligibility by DeSerializing
                var intIncomeEligibility = JsonConvert.DeserializeObject<InterestIncomeEligibility>(intIncomeEligibilityData);

                //Persist InterestIncomeEligibility Instance.
                    taxObject.F1040EZEligibility.InterestIncomeEligibility = intIncomeEligibility;
                   
                //Create Error message list if iterator is Null.
                if (taxObject.ErrorMessages == null)
                {
                    taxObject.ErrorMessages = new List<ErrorMessage>();
                }

                //Initializing Out Parameter
                errorMessageList = new List<ErrorMessage>();                        
                        
                //Retrieving Error Message list from Database
                var errorMessage = messageRepository.GetErrorMessages();
                var errorMessages = new ErrorMessages(errorMessage);

                // Clear the Error messages
                messageRepository.ClearErrorMessages(taxObject.ErrorMessages, topic : Constants.TOPIC_INTEREST_INCOME, errorCode : "InterestIncome_ER");

                //Invoking Business Rules Validation Workflow
                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;
                input.ErrorMessages = errorMessages;
                var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new InterestIncomeEligibilityCheck(), input));
                var hasEligibilityDiagnostics = false;
                if (taxObject != null)
                {
                   userDataId = taxReturnDataService.PersistTaxReturnData(userId, sessionData, Utilities.ConvertTaxObjectToJSON(taxObject), historyData, userDataId);
                    hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => em.Topic == Constants.TOPIC_INTEREST_INCOME && em.ErrorCode.StartsWith("InterestIncome_ER"));
                }
                errorMessageList = taxObject.ErrorMessages;          
                dynamic userData = new Tuple<long,bool>(userDataId,hasEligibilityDiagnostics);
                return userData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        //Saravanan N - 9th May, 2014 - Parameter changed as UserDTO.
        public InterestIncomeEligibility GetTaxReturnInterestIncomeEligibilityData(UserDTO userDTO)
        {
            string taxReturnData = string.Empty;
            try
            {
                //Retreiving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong());
                InterestIncomeEligibility intIncomeEligibility = null;

                if (taxObject != null && taxObject.F1040EZEligibility!= null)
                {
                   intIncomeEligibility = taxObject.F1040EZEligibility.InterestIncomeEligibility;
                }

                return intIncomeEligibility;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Helper Methods

        private void AddErrorToTaxObjectWithFormId(List<ErrorMessage> errorMessageListInTaxObject, long formId, ErrorMessage errorMessage)
        {
            if (errorMessage != null)
            {
                errorMessage.FormId = formId;
                errorMessageListInTaxObject.Add(errorMessage);
            }
        }

        #region Business Validations

        //TODO - Required field Validations still pending - 
        private void F1099INTRequiredFieldValidations(List<Form1099INT> form1099INTList, List<ErrorMessage> errorMessageFromTaxObject, ErrorMessages errorMessagesFromDB)
        {
            ErrorMessage errorMessage;
            foreach (var form1099INT in form1099INTList)
            {
                if (form1099INT != null)
                {
                    if (form1099INT.Owner == OwnerType.None)
                    {
                        errorMessage = errorMessagesFromDB[Constants.INT_WHOSE_INCOME_IS_THIS];
                        AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, form1099INT.Form1099INTId, errorMessage);
                    }

                    if (form1099INT.Payer == null || string.IsNullOrEmpty(form1099INT.Payer.PayerName))
                    {
                        errorMessage = errorMessagesFromDB[Constants.INT_PAYER_NAME];
                        AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, form1099INT.Form1099INTId, errorMessage);
                    }

                    if (form1099INT.InterestIncome <= 0 && form1099INT.USBondsTreasury <= 0)
                    {
                        errorMessage = errorMessagesFromDB[Constants.INT_INTEREST_INCOME];
                        AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, form1099INT.Form1099INTId, errorMessage);
                    }

                    if (form1099INT.TaxExemptInterest > 0)
                    {
                        if (form1099INT.TaxExemptInterestStateId <= 0 && form1099INT.StateExemptInterest <= 0)
                        {
                            errorMessage = errorMessagesFromDB[Constants.INT_INTEREST_INCOME];
                            AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, form1099INT.Form1099INTId, errorMessage);
                        }
                    }
                }
            }
        }

        private void F1099INTBusinessFieldValidations(List<Form1099INT> form1099INTList, List<ErrorMessage> errorMessageList, ErrorMessages errorMessages)
        {
            bool IsValid = true;
            foreach (var form1099INT in form1099INTList)
            {
                if (form1099INT != null && form1099INT.Payer != null)
                {

                    if (!string.IsNullOrEmpty(form1099INT.Payer.PayerIdentificationNumber))
                    {
                        string payerIdentificationNumber = form1099INT.Payer.PayerIdentificationNumber;
                        payerIdentificationNumber = Utilities.RemoveUnderscore(payerIdentificationNumber);
                        payerIdentificationNumber = Utilities.RemoveHiphen(payerIdentificationNumber);

                        bool IsNumeric = Utilities.IsNumeric(payerIdentificationNumber);

                        IsValid = Utilities.IsValidRegexPattern(form1099INT.Payer.PayerIdentificationNumber, @"[0-9\-]{11}");
                        if (!IsValid || !IsNumeric || payerIdentificationNumber == Constants.NineZeros || payerIdentificationNumber == Constants.NineNines)
                        {
                            ErrorMessage errorMessage = errorMessages[Constants.INT_PAYER_IDENTIFICATION_NUMBER];
                            AddErrorToTaxObjectWithFormId(errorMessageList, form1099INT.Form1099INTId, errorMessage);
                        }
                    }

                    if (!string.IsNullOrEmpty(form1099INT.Payer.PayerName))
                    {
                        //Check for Business Name Valid            
                        IsValid = Utilities.IsValidRegexPattern(form1099INT.Payer.PayerName, @"(([A-Za-z0-9 .&#\-\(\)]|&#x26;|&#x27;)?)*([A-Za-z0-9 .&#\-\(\)]|&#x26;|&#x27;){3,75}");
                        if (!IsValid)
                        {
                            ErrorMessage errorMessage = errorMessages[Constants.INT_PAYER_NAME_SPECIAL_CHARACTERS];
                            AddErrorToTaxObjectWithFormId(errorMessageList, form1099INT.Form1099INTId, errorMessage);
                        }

                    }

                }
            }
        }

        private void F1099OIDRequiredFieldValidations(List<Form1099OID> form1099OIDList, List<ErrorMessage> errorMessageList, ErrorMessages errorMessages)
        {
            foreach (var form1099OID in form1099OIDList)
            {
                if (form1099OID != null)
                {
                    if (form1099OID.Owner == OwnerType.None)
                    {
                        ErrorMessage error = errorMessages[Constants.INT_WHOSE_INCOME_IS_THIS];
                        AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, error);
                    }

                    if (form1099OID.Payer == null || string.IsNullOrEmpty(form1099OID.Payer.PayerName))
                    {
                        ErrorMessage error = errorMessages[Constants.INT_PAYER_NAME];
                        AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, error);
                    }

                    if (form1099OID.OriginalIssueDiscount <= 0 || form1099OID.OtherPeriodicInterest <= 0 || form1099OID.USTreasuryObligations <= 0)
                    {
                        ErrorMessage error = errorMessages[Constants.OID_ORIGINAL_ISSUE_DISCOUNT];
                        AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, error);
                    }

                    if (form1099OID.HasToReportTaxExempt.HasValue && form1099OID.HasToReportTaxExempt.Value)
                    {
                        if (form1099OID.TaxExemptInterest <= 0)
                        {
                            ErrorMessage error = errorMessages[Constants.OID_TAX_EXEMPT_INTEREST];
                            AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, error);
                        }
                    }

                    if (form1099OID.TaxExemptInterest > 0)
                    {
                        if (form1099OID.TaxExemptInterestStateId <= 0 && form1099OID.StateExemptInterest <= 0)
                        {
                            ErrorMessage error = errorMessages[Constants.OID_STATE_TAX_EXEMPT_INTEREST];
                            AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, error);
                        }
                    }

                    if (form1099OID.HasToReportAdjustment.HasValue && form1099OID.HasToReportAdjustment.Value)
                    {
                        if (form1099OID.AdjustmentAmount > 0)
                        {
                            ErrorMessage error = errorMessages[Constants.OID_ADUJUSTMENT];
                            AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, error);
                        }
                    }

                    //TODO If any of the Fields <c1>,<c2>,<c3>,<c4>,<c5>,<c6>,<c7> are not selected, then Field <c8> must be selected.
                    //Has tax object is not yet discussed
                }
            }

        }

        private void F1099OIDBusinessFieldValidations(List<Form1099OID> form1099OIDList, List<ErrorMessage> errorMessageList, ErrorMessages errorMessages)
        {
            bool IsValid = true;
            foreach (var form1099OID in form1099OIDList)
            {
                if (form1099OID != null && form1099OID.Payer != null)
                {

                    if (!string.IsNullOrEmpty(form1099OID.Payer.PayerIdentificationNumber))
                    {
                        string payerIdentificationNumber = form1099OID.Payer.PayerIdentificationNumber;
                        payerIdentificationNumber = Utilities.RemoveUnderscore(payerIdentificationNumber);
                        payerIdentificationNumber = Utilities.RemoveHiphen(payerIdentificationNumber);

                        bool IsNumeric = Utilities.IsNumeric(payerIdentificationNumber);

                        IsValid = Utilities.IsValidRegexPattern(form1099OID.Payer.PayerIdentificationNumber, @"[0-9\-]{11}");
                        if (!IsValid || !IsNumeric || payerIdentificationNumber == Constants.NineZeros || payerIdentificationNumber == Constants.NineNines)
                        {
                            ErrorMessage error = errorMessages[Constants.INT_PAYER_IDENTIFICATION_NUMBER];
                            AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, error);
                        }
                    }

                    if (!string.IsNullOrEmpty(form1099OID.Payer.PayerName))
                    {
                        //Check for Business Name Valid            
                        IsValid = Utilities.IsValidRegexPattern(form1099OID.Payer.PayerName, @"(([A-Za-z0-9 .&#\-\(\)]|&#x26;|&#x27;)?)*([A-Za-z0-9 .&#\-\(\)]|&#x26;|&#x27;){3,75}");
                        if (!IsValid)
                        {
                            ErrorMessage error = errorMessages[Constants.INT_PAYER_NAME_SPECIAL_CHARACTERS];
                            AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, error);
                        }

                    }
                }
            }
        }


        #endregion

        //Saravanan N - 9th May, 2014 - Created common method to get Income.
        /// <summary>
        /// Returns Income object from Taxobject.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        private Income GetIncomeFromTaxobject(UserDTO userDTO)
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            Income income = null;

            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(Utilities.ConvertToLong(userDTO.UserDataId), 
                 Utilities.ConvertToLong(userDTO.UserId));

            if(taxObject != null && taxObject.Income != null)
            {
                income = taxObject.Income;
            }

            return income;
        }
        #endregion
    }
}
