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
 */

using System;
using System.Activities;
using Newtonsoft.Json;
using System.Collections.Generic;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;
using System.Linq;
using System.Dynamic;
using Tax1040WorkFlow.WorkFlow.Activities;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities;

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

            if(taxObject != null && taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null)
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
        public System.Tuple<Form1099INT, FilingStatus> GetTaxReturn1099INTData(UserDTO userDTO)
        {
            // Vincent-20th May 2014-Modified the GetTaxReturn1099INTData 
            Tuple<Form1099INT, FilingStatus> taxReturnDataINT = null;

            try
            {
                var taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                List<Form1099INT> lstFormINT = null;
                Form1099INT form1099INT = null;
                FilingStatus filingStatus = FilingStatus.None;

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
                }

                taxReturnDataINT = new Tuple<Form1099INT, FilingStatus>(form1099INT, filingStatus);
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
            Form1099INT form1099INT=null;
            dynamic userData = new ExpandoObject();
            long userId = 0;
            TaxReturnData taxReturnData = null;
           
            try
            {
                var isEligibilityCheckFailed = false;
               
                    taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(taxReturn.TaxReturnData.ToString());
                    userId = Utilities.ConvertToLong(taxReturn.userId.Value);

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

                    //Converting Json to Form1099INT by DeSerializing
                    form1099INT = JsonConvert.DeserializeObject<Form1099INT>(taxReturnData.TaxData);

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
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FORM_INT);

                    if (taxObject.Income.Form1099INT != null && taxObject.Income.Form1099INT.Any())
                    {
                        //Invoking Required Field Validations Method
                        F1099INTRequiredFieldCheck(taxObject.Income.Form1099INT, taxObject.ErrorMessages, errorMessagesListFromDB);

                        //Invoking Business Field Validations Method
                        F1099INTValidationsCheck(taxObject.Income.Form1099INT, taxObject.ErrorMessages, errorMessagesListFromDB);
                    }

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
                        messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FORM_INT, form1099INTId);
                    }
                }

                //Persist latest TaxObject.
                Utilities.PersistTaxObject(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong(), taxObject);
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
        public System.Tuple<Form1099OID, FilingStatus> GetTaxReturn1099OIDData(UserDTO userDTO)
        {
            Form1099OID form1099OID = null;
            FilingStatus filingStatus = FilingStatus.None;
            // Vincent-20th May 2014-Modified the GetTaxReturn1099OIDData 
            Tuple<Form1099OID, FilingStatus> taxReturnDataOID = null;

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
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:InterestIncomeRepository,Method Name:GetTaxReturn1099OIDData", ex);
            }

            return new Tuple<Form1099OID, FilingStatus>(form1099OID, filingStatus);
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

            try
            {
                var isEligibilityCheckFailed = false;

                taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(taxReturn.TaxReturnData.ToString());
                userId = Utilities.ConvertToLong(taxReturn.userId.Value);

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
                    var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessagesListFromDB = new ErrorMessages(errorMessage);

                    // Clear the Error messages
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FORM_OID);

                    if (taxObject.Income.Form1099OID != null && taxObject.Income.Form1099OID.Any())
                    {
                        //Invoking Required Field Validations Method
                        F1099OIDRequiredFieldCheck(taxObject.Income.Form1099OID, taxObject.ErrorMessages, errorMessagesListFromDB);

                        //Invoking Business Field Validations Method
                        F1099OIDValidationsCheck(taxObject.Income.Form1099OID, taxObject.ErrorMessages, errorMessagesListFromDB);
                    }

                    //Workflow Validation Section
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;

                    input.ErrorMessages = errorMessagesListFromDB;
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new
                        F1099OIDBusinessValidation(), input));

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
                        messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_FORM_OID, form1099OIDId);
                    }
                }
                //Persist latest TaxObject.
                Utilities.PersistTaxObject(userDTO.UserId.ConvertToLong(), userDTO.UserDataId.ConvertToLong(), taxObject);
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
                            lstTaxObjectErrors = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_FORM_INT || err.Topic == Constants.TOPIC_FORM_OID);
                        }
                    }
                }
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
                    }

                    if (interestIncomeEligibility != null)
                    {
                        //Persist InterestIncomeEligibility Instance.
                        taxObject.F1040EZEligibility.InterestIncomeEligibility = interestIncomeEligibility;
                    }

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
                    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, topic: Constants.TOPIC_INTEREST_INCOME, errorCode: "InterestIncome_ER");

                    //Invoking Business Rules Validation Workflow
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    input.ErrorMessages = errorMessages;
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new
                        InterestIncomeEligibilityCheck(), input));
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
                    if (form1099INT.TaxExemptInterest.HasValue)
                    {
                        if (form1099INT.TaxExemptInterestStateId <= 0 && form1099INT.StateExemptInterest == null)
                        {
                            errorMessage = errorMessagesFromDB[Constants.INT_STATE_CODE_TAX_EXEMPT_INTEREST];
                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
                        }
                    }

                    if (form1099INT.Form1099StateInfo != null)
                    {
                        //Required Entry # 10
                        if (form1099INT.Form1099StateInfo[0] != null && form1099INT.Form1099StateInfo[0].StateTaxWithholdingAmount.HasValue)
                        {
                            if (form1099INT.Form1099StateInfo[0].StateId <= 0)
                            {
                                errorMessage = errorMessagesFromDB[Constants.INT_BOX11_STATE_CODE1_MISSING];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
                            }
                        }

                        //Required Entry # 11
                        if (form1099INT.Form1099StateInfo[1] != null && form1099INT.Form1099StateInfo[1].StateTaxWithholdingAmount.HasValue)
                        {
                            if (form1099INT.Form1099StateInfo[1].StateId <= 0)
                            {
                                errorMessage = errorMessagesFromDB[Constants.INT_BOX11_STATE_CODE2_MISSING];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageFromTaxObject, formINT_ID, errorMessage);
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
            bool IsValid = true;
           
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
                            ErrorMessage errorMessage = errorMessages[Constants.INT_PAYER_IDENTIFICATION_NUMBER];
                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099INT.Form1099INTId, errorMessage);
                        }
                    }

                    //Validatiion Entry #1
                    if (!string.IsNullOrEmpty(form1099INT.Payer.PayerName))
                    {
                        //Check for Business Name Valid            
                        //Yogalakshmi - 21st May 2014 - Validate only for alphabets
                        IsValid = Utilities.IsAlphabet(form1099INT.Payer.PayerName);
                        if (!IsValid)
                        {
                            ErrorMessage errorMessage = errorMessages[Constants.INT_PAYER_NAME_SPECIAL_CHARACTERS];
                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099INT.Form1099INTId, errorMessage);
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

                    //Required entry #1.
                    if (filingStatus == FilingStatus.MarriedFilingJointly &&  form1099OID.Owner == OwnerType.None)
                    {
                        errorMessage = errorMessages[Constants.OID_WHOSE_INCOME_IS_THIS];
                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, formOID_ID, errorMessage);
                    }

                    //Required entry #2.
                    if (form1099OID.Payer == null || string.IsNullOrEmpty(form1099OID.Payer.PayerName))
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
                    if (form1099OID.TaxExemptInterest.HasValue)
                    {
                        if (form1099OID.TaxExemptInterestStateId <= 0 && !form1099OID.StateExemptInterest.HasValue)
                        {
                            errorMessage = errorMessages[Constants.OID_STATE_TAX_EXEMPT_INTEREST];
                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, formOID_ID, errorMessage);
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
                            if (form1099OID.Form1099StateInfo[0].StateId <= 0)
                            {
                                errorMessage = errorMessages[Constants.OID_BOX11_STATE_CODE1_MISSING];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, formOID_ID, errorMessage);
                            }
                        }

                        //Required Entry # 13
                        if (form1099OID.Form1099StateInfo[1] != null && form1099OID.Form1099StateInfo[1].StateTaxWithholdingAmount.HasValue)
                        {
                            if (form1099OID.Form1099StateInfo[1].StateId <= 0)
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
            foreach (var form1099OID in form1099OIDList)
            {
                if (form1099OID != null && form1099OID.Payer != null)
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
                            ErrorMessage error = errorMessages[Constants.OID_PAYER_IDENTIFICATION_NUMBER];
                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, error);
                        }
                    }

                    //Validatiion Entry #1
                    if (!string.IsNullOrEmpty(form1099OID.Payer.PayerName))
                    {
                        //Check for Business Name Valid            
                        IsValid = Utilities.IsValidRegexPattern(
                            form1099OID.Payer.PayerName, @"(([A-Za-z0-9 .&#\-\(\)]|&#x26;|&#x27;)?)*([A-Za-z0-9 .&#\-\(\)]|&#x26;|&#x27;){3,75}");
                        if (!IsValid)
                        {
                            ErrorMessage error = errorMessages[Constants.OID_PAYER_NAME_SPECIAL_CHARACTERS];
                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099OID.Form1099OIDId, error);
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
            input.Tax1040Object = taxObject;
            input.ErrorMessages = errorMessagesListFromDB;
            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary
                (WorkflowInvoker.Invoke(new F1099INTBusinessValidationRules(), input));

            //Saravanan N - 2nd June, 2014 - Invoking Eligibility Check Workflow
            //Clear the EligibilityRule 10 already exists.
            taxObject.ErrorMessages.RemoveAll(errMsg => errMsg.ErrorCode == "InterestIncome_ER10");
            input = new Microsoft.Activities.Extensions.WorkflowArguments();
            input.Tax1040Object = taxObject;
            input.ErrorMessages = errorMessagesListFromDB;
            output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary
                (WorkflowInvoker.Invoke(new F1040EZTaxableInterestEligibility(), input));
        }
        #endregion
    }
}


