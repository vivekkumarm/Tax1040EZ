/*
Copyright   : Copyright Jeevan Technologies
File Name   : UnemploymentRepository.cs 
Description : Business Logic for Unemployment
Author      : Vivek
Created Date : 7 Apr 2014

 * Modification History:
------------------------
 * Saravanan N - 10th April, 2014 - DeleteAndPersist1099G param list altered.
 * Sathish N -   15th April 2014 Commented because it will not allow to add new 1099G
 * Vincent-15th April 2014- Added a formid to get the Form1099GId. 
 * Sathish N  - 28Apr2014 Changed CreateAndPersist1099G method to return user data id and form1099g ID
 * 02May2014 Bala Modified code to clear the error messages from error message list. 
 * Sathish N  - 02May2014 Changed persist method to use TaxReturnData BO and Removed error message list in persist and delete 
 * Saravanan N - 6th May, 2014 - GetUnemploymentById() Method moved from UnemploymentController class.
 * Saravanan N - 7th May, 2014 - DeleteAndPersistUnemployment() and GetUnemploymentById() removed formId.
 * Saravanan N - 22nd May, 2014 - ExceptionHandling done.
 * 05Jun2014 Sathish added optional parameter taxobject used in delete spouse info while changing filling status MFJ to single
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Activities;
using Newtonsoft.Json;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using System.Dynamic;
using Tax1040WorkFlow.WorkFlow.Activities;
using System.Text.RegularExpressions;

namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Contains Get and Persist methods for Unemployment.
    /// </summary>
    public class UnemploymentRepository : IUnemploymentRepository
    {
        #region Local variables declaration
        MessagesRepository messageRepository;
        Tuple<string, string, string, string> taxPayerAndSpouseNames;
        JTL.Tax1040.BusinessObject.Tax1040 taxObject;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="W2Repository"/> class.
        /// </summary>
        public UnemploymentRepository()
        {
            messageRepository = new MessagesRepository();
        }
        #endregion

        #region Interface Implementated Methods
        /// <summary>
        /// Delete and then Persist Form1099G.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <param name="form1099GId"></param>
        /// <param name="errorMessageList"></param>
        public void DeleteAndPersistUnemployment(UserDTO userDTO, Tax1040.BusinessObject.Tax1040 refTaxObject = null) // 05Jun2014 Sathish added optional parameter taxobject used in delete spouse info while changing filling status MFJ to single
        {
            try
            {
                // 05Jun2014 Sathish check optional parameter which is used in deleting spouse info
                if (refTaxObject == null)
                    //Retrieving TaxObject from database
                    taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);
                else
                    taxObject = refTaxObject;

                //Converting Json to Form1099G by DeSerializing
                if (taxObject != null && taxObject.Income != null && taxObject.Income.Form1099G != null)
                {
                    int index = taxObject.Income.Form1099G.FindIndex(form => form.Form1099GId == userDTO.FormId);

                    if (index >= 0)
                    {
                        //Delete the current Form1099G object.
                        taxObject.Income.Form1099G.RemoveAt(index);

                        // Clear the Error messages
                        messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_UNEMPLOYMENT_COMPENSATION, userDTO.FormId);
                    }
                }

                //Persist latest TaxObject.
                Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:UnemploymentRepository,Method Name:DeleteAndPersistUnemployment", ex);
            }
        }

        /// <summary>
        /// Create and Persist Unemployment
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taxReturnData"></param>
        /// <returns></returns>
        public dynamic CreateAndPersistUnemployment(long userId, TaxReturnData taxReturnData)
        {
            dynamic userDataIDand1099GId = new ExpandoObject();

            try
            {
                //Retrieving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, taxReturnData.UserDataId);

                //Converting Json to Form1099G by DeSerializing
                Form1099G form1099g = JsonConvert.DeserializeObject<Form1099G>(taxReturnData.TaxData);
                if (taxObject != null)
                {
                    //Get TaxPayer and Spouse Names.
                    taxPayerAndSpouseNames = Utilities.GetTaxPayerAndSpouseName(taxObject);

                    if (taxObject.Income == null)
                    {
                        taxObject.Income = new Income();
                    }
                }

                if (taxObject.Income.Form1099G != null && taxObject.Income.Form1099G.Any())
                {
                    int index = taxObject.Income.Form1099G.FindIndex(form => form.Form1099GId == form1099g.Form1099GId);

                    if (index < 0)
                    {
                        //Saravanan N - 3rd April, 2014 - Current Form1099G is new one. So created ID for this.
                        form1099g.Form1099GId = taxObject.Income.Form1099G.Max(frm => frm.Form1099GId) + 1;

                        //Adding new Form1099G to the TaxObject Form1099GList
                        taxObject.Income.Form1099G.Add(form1099g);
                    }
                    else
                    {
                        taxObject.Income.Form1099G[index] = form1099g;
                    }
                }
                else
                {
                    //Saravanan N - 3rd April, 2014 - Form1099G doesn't exists for this user. Hence, assign 1 as its ID.
                    form1099g.Form1099GId = 1;

                    //Creating Instance if Form1099GList section is Null
                    taxObject.Income.Form1099G = new List<Form1099G> { form1099g };
                    //Adding new Form1099G to the TaxObject W2List
                }

                if (taxObject.ErrorMessages == null)
                {
                    taxObject.ErrorMessages = new List<ErrorMessage>();
                }

                //Retrieving Error Message list from Database
                messageRepository = new MessagesRepository();
                var errorMessage = messageRepository.GetErrorMessages();
                var errorMessages = new ErrorMessages(errorMessage);

                // Clear the Error messages
                messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_UNEMPLOYMENT_COMPENSATION);

                //Required and Validation check for current Form1099G.
                FilingStatus filingStatus = FilingStatus.None;
                if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null)
                {
                    filingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                }
                if (taxObject.Income.Form1099G != null && taxObject.Income.Form1099G.Any())
                {
                    BusinessFieldValidations(taxObject.Income.Form1099G, filingStatus, taxObject.ErrorMessages, errorMessages);
                }

                //Invoking Business Rules Validation Workflow
                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;
                input.ErrorMessages = errorMessages;
                var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new
                    F1099GBusinessValidationRule(), input));

                //Saravanan N - 7th May, 2014 - Check if any hard stop (Eligibility Check found) in workflow for Unemployment.
                var isEligibilityCheckFailed = taxObject.ErrorMessages.Any(errMsg => errMsg.Topic ==
                    Constants.TOPIC_UNEMPLOYMENT_COMPENSATION && errMsg.ErrorCode.Equals(Constants.F1099G__REPAID_AMOUNT_FOR_EARLIER_YEAR));

                taxReturnData.UserDataId = Utilities.PersistTaxObject(userId, taxReturnData.UserDataId, taxObject);

                userDataIDand1099GId.UserDataId = taxReturnData.UserDataId;
                userDataIDand1099GId.Form1099GId = form1099g.Form1099GId;
                userDataIDand1099GId.isEligibilityCheckFailed = isEligibilityCheckFailed;
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:UnemploymentRepository,Method Name:CreateAndPersistUnemployment", ex);
            }

            return userDataIDand1099GId;
        }

        //Saravanan N - 7th April, 2014 - GetForm1099GList for UnemploymentSummary page.
        //Saravanan N - 5th May, 2014 - This method moved from F1099GController class and Refacotred.
        public Tuple<List<Form1099G>, IEnumerable<ErrorMessage>, double?> GetAllUnemployment(UserDTO userDTO)
        {
            List<Form1099G> lstForm1099G = null;
            IEnumerable<ErrorMessage> lstErrorMessages = null;
            double? totalUnemploymentReceived = null;
            double? totalUnemploymentRepaid = null;

            try
            {
                //Get TaxObject from DB.
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                //Get Form1099G and its Error Messages.
                if (taxObject != null)
                {
                    if (taxObject.Income != null && taxObject.Income.Form1099G != null)
                    {
                        lstForm1099G = taxObject.Income.Form1099G;
                        //Added By Yogalakshmi on 20th May 2014 to bind the latest First Name and Last Name in unemploymentSummary Page
                        foreach (var taxPayerName in lstForm1099G)
                        {
                            if (taxPayerName.OwnerType == OwnerType.Spouse)
                            {
                                //Yogalakshmi - 22nd May 2014 - Checked for null
                                if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.Spouse != null &&
                                    taxObject.PersonalDetails.Spouse.Person != null)
                                {
                                    taxPayerName.TaxPayerName = taxObject.PersonalDetails.Spouse.Person.FirstName + " " + taxObject.PersonalDetails.Spouse.Person.LastName;
                                }
                            }
                            else
                            {
                                if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                                    taxObject.PersonalDetails.PrimaryTaxPayer.Person != null)
                                {
                                    taxPayerName.TaxPayerName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName + " " + taxObject.PersonalDetails.PrimaryTaxPayer.Person.LastName;
                                }
                            }
                        }
                    }
                    else
                    {
                        lstForm1099G = new List<Form1099G>();
                    }

                    //Yogalakshmi - 20th May 2014 
                    //Get Summary Page total unemployment compensation summary amount.
                    totalUnemploymentRepaid = lstForm1099G.Select(m => m.CurrentYearUnemploymentRepaid).Sum();
                    totalUnemploymentReceived = lstForm1099G.Select(m => m.UnEmploymentCompensation).Sum();

                    //Get ErrorMessage if exists.
                    if (taxObject.ErrorMessages != null)
                    {
                        //If ErrorMessages doesn't have any object it returns count as 1 for NULL object. So removing this NULL object from the list.
                        taxObject.ErrorMessages.RemoveAll(err => err == null);

                        if (taxObject.ErrorMessages.Count > 0)
                        {
                            //Get Unemployment Compensation related error messages.
                            lstErrorMessages = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_UNEMPLOYMENT_COMPENSATION);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:UnemploymentRepository,Method Name:GetAllUnemployment", ex);
            }

            return new Tuple<List<Form1099G>, IEnumerable<ErrorMessage>, double?>(lstForm1099G, lstErrorMessages,
                totalUnemploymentReceived - totalUnemploymentRepaid);
        }

        //Saravanan N - 7th April, 2014 - GetForm1099GList for UnemploymentSummary page.
        //Saravanan N - 6th May, 2014 - Method moved from UnemploymentController class.
        public Tuple<Form1099G, string, string, FilingStatus> GetUnemploymentById(UserDTO userDTO)
        {
            Form1099G form1099G = null;
            FilingStatus filingStatus = FilingStatus.None;

            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

                taxPayerAndSpouseNames = Utilities.GetTaxPayerAndSpouseName(taxObject);

                if (taxObject != null)
                {
                    //Get FilingStatus.
                    if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null)
                    {
                        filingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                    }

                    if (taxObject.Income != null && taxObject.Income.Form1099G != null)
                    {
                        form1099G = taxObject.Income.Form1099G.Find(frm => frm.Form1099GId == userDTO.FormId);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:UnemploymentRepository,Method Name:GetUnemploymentById", ex);
            }

            return new Tuple<Form1099G, string, string, FilingStatus>(form1099G, taxPayerAndSpouseNames.Item1, taxPayerAndSpouseNames.Item3, filingStatus);
        }
        #endregion

        #region Helper Methods

        //Saravanan N - 9th April, 2014 - Business validations added.
        //Vincent - 15th April 2014 - Added a FormId to get F1099GID.
        private void BusinessFieldValidations(List<Form1099G> form1099GList, FilingStatus filingStatus, List<ErrorMessage> errorMessageList,
            ErrorMessages errorMessages)
        {
            Regex regex;
            ErrorMessage errorMessage;
            bool isHavingFiveChars = true;
            bool isHavingNineChars = true;
            bool isValidNumeric = true;

            foreach (var form1099G in form1099GList)
            {
                //Required field validations 1.
                if (form1099G == null || (filingStatus == FilingStatus.MarriedFilingJointly && form1099G.OwnerType == OwnerType.None))
                {
                    errorMessage = errorMessages[Constants.F1099G_WHOSE_UNEMPLOYMENT_COMPENSATION_IS_THIS];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 2
                if (form1099G == null || form1099G.Payer == null || string.IsNullOrEmpty(form1099G.Payer.PayerName.Trim()))
                {
                    errorMessage = errorMessages[Constants.F1099G_PAYER_NAME_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 3
                if (form1099G == null || form1099G.Payer == null || form1099G.Payer.Address == null ||
                    form1099G.Payer.Address.PayerAddress == null ||
                    string.IsNullOrEmpty(form1099G.Payer.Address.PayerAddress.StreetAddress.Trim()))
                {
                    errorMessage = errorMessages[Constants.F1099G_PAYER_ADDRESS_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 4
                if (form1099G == null || form1099G.Payer == null || form1099G.Payer.Address == null ||
                    form1099G.Payer.Address.PayerAddress == null ||
                    string.IsNullOrEmpty(form1099G.Payer.Address.PayerAddress.City.Trim()))
                {
                    errorMessage = errorMessages[Constants.F1099G_PAYER_CITY_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 5
                if (form1099G == null || form1099G.Payer == null || form1099G.Payer.Address == null ||
                    form1099G.Payer.Address.PayerAddress == null ||
                    form1099G.Payer.Address.PayerAddress.StateId == 0)
                {
                    errorMessage = errorMessages[Constants.F1099G_PAYER_STATE_CODE_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 6
                if (form1099G == null || form1099G.Payer == null || form1099G.Payer.Address == null ||
                    form1099G.Payer.Address.PayerAddress == null || string.IsNullOrEmpty(form1099G.Payer.Address.PayerAddress.ZipCode))
                {
                    errorMessage = errorMessages[Constants.F1099G_PAYER_ZIP_CODE_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 7
                if (form1099G == null || form1099G.Payer == null ||
                    string.IsNullOrEmpty(form1099G.Payer.PayerIdentificationNumber.Trim()))
                {
                    errorMessage = errorMessages[Constants.F1099G_PAYER_IDENTIFIQATION_NUMBER_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 8
                if (form1099G == null || (!form1099G.UnEmploymentCompensation.HasValue))
                {
                    errorMessage = errorMessages[Constants.F1099G_UNEMPLOYMENT_COMPENSATION_AMOUNT_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 9
                if (form1099G == null || (!form1099G.FederalTaxWithHoldingAmount.HasValue))
                {
                    errorMessage = errorMessages[Constants.F1099G_BOX_4_FEDERAL_TAX_WITHHELD_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 10
                if (form1099G == null || (form1099G.IsCurrentYearUnemploymentRepaid == true && (!form1099G.CurrentYearUnemploymentRepaid.HasValue)))
                {
                    errorMessage = errorMessages[Constants.F1099G_REPAID_AMOUNT_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 11
                if (form1099G == null || (form1099G.IsPriorYearUnEmploymentRepaid == true && !form1099G.PriorYearUnEmploymentRepaid.HasValue))
                {
                    errorMessage = errorMessages[Constants.F1099G_REPAID_AMOUNT_PRIOR_YEAR_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Yogalakshmi - 29th May 2014 - Added a error message for RF12
                if (form1099G.Form1099StateInfo != null)
                {
                    foreach (var stateInfo in form1099G.Form1099StateInfo)
                    {
                        if (stateInfo.StateTaxWithholdingAmount != null && stateInfo.StateId == 0)
                        {
                            errorMessage = errorMessages[Constants.F1099G_STATE_CODE_MISSING];
                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                        }
                    }
                }

                //Validations
                if (form1099G != null && form1099G.Payer != null)
                {
                    //validataion #1
                    //Defect Key : TAX1040-13964 - Saravanan N - 5th June, 2014. - NULL or Empty check handled.
                    if (!String.IsNullOrEmpty(form1099G.Payer.PayerName.Trim()))
                    {
                        errorMessage = BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(form1099G.Payer.PayerName, 
                            Constants.F1099G_PAYER_NAME_HAS_SPECIAL_CHARACTERS, errorMessages);
                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                    }

                    if (form1099G.Payer.Address != null && form1099G.Payer.Address.PayerAddress != null)
                    {
                        //Saravanan N - 23rd May, 2014 - As discussed with BA, Address will allow AlphaNumeric, hence commented this.
                        //validataion #2 - StreetAddress
                        if (!string.IsNullOrEmpty(form1099G.Payer.Address.PayerAddress.StreetAddress.Trim()))
                        {
                            regex = new Regex("^[a-zA-Z0-9- ]+$");
                            if (!regex.IsMatch(form1099G.Payer.Address.PayerAddress.StreetAddress))
                            {
                                errorMessage = errorMessages[Constants.F1099G_PAYER_ADDRESS_HAS_SPECIAL_CHARACTERS];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                            }
                        }

                        //validataion #3 - PayerCity
                        if (!string.IsNullOrEmpty(form1099G.Payer.Address.PayerAddress.City.Trim()))
                        {
                            regex = new Regex("^[a-zA-Z ]+$"); // 15May2014 Sathish Changed rejex to allow space character
                            if (!regex.IsMatch(form1099G.Payer.Address.PayerAddress.City))
                            {
                                errorMessage = errorMessages[Constants.F1099G_PAYER_CITY_HAS_SPECIAL_CHARACTERS];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                            }
                        }

                        //validataion # 4 - ZipCode
                        //Saravanan N - 26th May, 2014 - Code inherited from PersonalInfoRepository.
                        if (!string.IsNullOrEmpty(form1099G.Payer.Address.PayerAddress.ZipCode))
                        {
                            bool isValidZipcodeForState = true;

                            if (form1099G.Payer.Address.PayerAddress.StateId > 0)
                            {
                                //Get the first 5 chars (i.e., til Hyphen -)
                                var zipCodeFromUI = form1099G.Payer.Address.PayerAddress.ZipCode;

                                if (!string.IsNullOrEmpty(zipCodeFromUI))
                                {
                                    ////Thileep - 27.05.14 - Changed Zip Code Validation
                                    //var zipCodeToCheckWithState = zipCodeFromUI.Contains('-') ? zipCodeFromUI.Substring(0, 
                                    //    (zipCodeFromUI.IndexOf('-'))) : zipCodeFromUI;

                                    isValidZipcodeForState = Utilities.ValidateZipCodeByStateId(form1099G.Payer.Address.PayerAddress.StateId,
                                        zipCodeFromUI);
                                }
                            }
                            else
                            {
                                //State ID not selected, then check the Zip Code format.
                                string zipCode = form1099G.Payer.Address.PayerAddress.ZipCode;
                                zipCode = Utilities.RemoveHiphen(zipCode);
                                isValidNumeric = Utilities.IsValidRegexPattern(zipCode, "^[0-9]+$");
                                isHavingNineChars = (zipCode.Trim().Length == 9);
                                isHavingFiveChars = (zipCode.Trim().Length == 5);
                            }
                            //Defect Key TAX1040-13961 on 5th June, 2014 - By Saravanan 
                            if (!isValidZipcodeForState || !isValidNumeric || (!isHavingNineChars && !isHavingFiveChars))
                            {
                                errorMessage = errorMessages[Constants.F1099G_PAYER_ZIP_CODE_INVALID];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                            }
                        }
                    }

                    //validataion #5 - PayerIdentificationNumber
                    if (!string.IsNullOrEmpty(form1099G.Payer.PayerIdentificationNumber))
                    {
                        string payerIdentificationNumber = form1099G.Payer.PayerIdentificationNumber;
                        payerIdentificationNumber = Utilities.RemoveHiphen(payerIdentificationNumber);
                        isValidNumeric = Utilities.IsValidRegexPattern(payerIdentificationNumber, "^[0-9]+$");
                        isHavingNineChars = (payerIdentificationNumber.Trim().Length == 9);
                        if (!isValidNumeric || !isHavingNineChars || payerIdentificationNumber == Constants.NineZeros ||
                            payerIdentificationNumber == Constants.NineNines)
                        {
                            errorMessage = errorMessages[Constants.F1099G_PAYER_IDENTIFIQATION_NUMBER_INVALID];
                            //Yogalakshmi - 22nd May 2014 - Object name was wrongly placed while returning so changed it from errormessage to error
                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
