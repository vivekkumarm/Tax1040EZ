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
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Activities;
using Newtonsoft.Json;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.DataAccess;
using System.Dynamic;
using Tax1040WorkFlow.WorkFlow.Activities;

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
        public void DeleteAndPersistUnemployment(UserDTO userDTO)
        {
            try
            {
                //Retrieving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

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
                throw ex;
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

                    //Store the TaxPayer Name as per their OwnerType.
                    if (form1099g.OwnerType == OwnerType.Spouse)
                    {
                        form1099g.TaxPayerName = taxPayerAndSpouseNames.Item3 + " " + taxPayerAndSpouseNames.Item4;
                    }
                    else
                    {
                        //Get Primary Tax Payer First and Last Name
                        form1099g.TaxPayerName = taxPayerAndSpouseNames.Item1 + " " + taxPayerAndSpouseNames.Item2;
                    }

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

                return userDataIDand1099GId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        //Saravanan N - 7th April, 2014 - GetForm1099GList for UnemploymentSummary page.
        //Saravanan N - 5th May, 2014 - This method moved from F1099GController class and Refacotred.
        public Tuple<List<Form1099G> , IEnumerable<ErrorMessage>, double?> GetAllUnemployment(UserDTO userDTO)
        {
            List<Form1099G> lstForm1099G = null;
            IEnumerable<ErrorMessage> lstErrorMessages = null;
            double? totalUnemploymentReceived = null;
            double? totalUnemploymentRepaid = null;


            //Get TaxObject from DB.
            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

            //Get Form1099G and its Error Messages.
            if (taxObject != null)
            {
                if (taxObject.Income != null && taxObject.Income.Form1099G != null)
                {
                    lstForm1099G = taxObject.Income.Form1099G;
                }
                else
                {
                    lstForm1099G = new List<Form1099G>();
                }

                //Get Summary Page total unemployment compensation summary amount.
                lstForm1099G.ToList().ForEach(frm =>
                    {
                        totalUnemploymentRepaid += frm.CurrentYearUnemploymentRepaid;
                        totalUnemploymentReceived += frm.UnEmploymentCompensation;
                    });


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

            return new Tuple<List<Form1099G>, IEnumerable<ErrorMessage>, double?>(lstForm1099G, lstErrorMessages, 
                totalUnemploymentReceived - totalUnemploymentRepaid);
        }

        //Saravanan N - 7th April, 2014 - GetForm1099GList for UnemploymentSummary page.
        //Saravanan N - 6th May, 2014 - Method moved from UnemploymentController class.
        public Tuple<Form1099G, string, string, FilingStatus> GetUnemploymentById(UserDTO userDTO)
        {
            Form1099G form1099G = null;
            FilingStatus filingStatus = FilingStatus.None;

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

            return new Tuple<Form1099G, string, string, FilingStatus>(form1099G, taxPayerAndSpouseNames.Item1, taxPayerAndSpouseNames.Item3, filingStatus);
        }
        #endregion

        #region Helper Methods

        //Saravanan N - 9th April, 2014 - Business validations added.
        //Vincent - 15th April 2014 - Added a FormId to get F1099GID.
        private void BusinessFieldValidations(List<Form1099G> form1099GList, FilingStatus filingStatus, List<ErrorMessage> errorMessageList,
            ErrorMessages errorMessages)
        {
            ErrorMessage errorMessage;
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
                    form1099G.Payer.Address.PayerAddress == null ||
                    string.IsNullOrEmpty(form1099G.Payer.Address.PayerAddress.ZipCode.Trim()))
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
                if (form1099G == null || form1099G.UnEmploymentCompensation == 0L)
                {
                    errorMessage = errorMessages[Constants.F1099G_UNEMPLOYMENT_COMPENSATION_AMOUNT_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 9
                if (form1099G == null || form1099G.FederalTaxWithHoldingAmount == 0L)
                {
                    errorMessage = errorMessages[Constants.F1099G_BOX_4_FEDERAL_TAX_WITHHELD_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 10
                if (form1099G == null || form1099G.IsCurrentYearUnemploymentRepaid == true && form1099G.CurrentYearUnemploymentRepaid == 0L)
                {
                    errorMessage = errorMessages[Constants.F1099G_REPAID_AMOUNT_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Required field validations 10
                if (form1099G == null || form1099G.IsPriorYearUnEmploymentRepaid == true && form1099G.PriorYearUnEmploymentRepaid == 0L)
                {
                    errorMessage = errorMessages[Constants.F1099G_REPAID_AMOUNT_MISSING];
                    Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                }

                //Validations
                if (form1099G != null)
                {
                    if (form1099G.Payer != null)
                    {
                        //validataion 1
                        errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(form1099G.Payer.PayerName,
                            Constants.F1099G_PAYER_NAME_HAS_SPECIAL_CHARACTERS, errorMessages);
                        Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);

                        //validataion 5
                        bool IsValid = true;
                        if (!string.IsNullOrEmpty(form1099G.Payer.PayerIdentificationNumber))
                        {
                            string payerIdentificationNumber = form1099G.Payer.PayerIdentificationNumber;
                            payerIdentificationNumber = Utilities.RemoveUnderscore(payerIdentificationNumber);
                            payerIdentificationNumber = Utilities.RemoveHiphen(payerIdentificationNumber);

                            bool IsNumeric = Utilities.IsNumeric(payerIdentificationNumber);

                            IsValid = Utilities.IsValidRegexPattern(form1099G.Payer.PayerIdentificationNumber, @"[0-9\-]{11}");
                            if (!IsValid || !IsNumeric || payerIdentificationNumber == Constants.NineZeros || payerIdentificationNumber == Constants.NineNines)
                            {
                                ErrorMessage error = errorMessages[Constants.F1099G_PAYER_IDENTIFIQATION_NUMBER_INVALID];
                                Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                            }
                        }

                        if (form1099G.Payer.Address != null && form1099G.Payer.Address.PayerAddress != null)
                        {
                            //validataion 2
                            errorMessage =
                                BusinessValidationRepository.AssertIsOnlyAlphapet(
                                    form1099G.Payer.Address.PayerAddress.StreetAddress,
                                    Constants.F1099G_PAYER_ADDRESS_HAS_SPECIAL_CHARACTERS, errorMessages);

                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);

                            //validataion 3
                            errorMessage =
                                BusinessValidationRepository.AssertIsOnlyAlphapet(
                                    form1099G.Payer.Address.PayerAddress.City,
                                    Constants.F1099G_PAYER_CITY_HAS_SPECIAL_CHARACTERS, errorMessages);

                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);

                            //validataion 4
                            errorMessage =
                                BusinessValidationRepository.IsValidZipCode(
                                    form1099G.Payer.Address.PayerAddress.ZipCode,
                                    Constants.F1099G_PAYER_ZIP_CODE_INVALID, errorMessages);

                            Utilities.AddErrorToTaxObjectWithFormId(errorMessageList, form1099G.Form1099GId, errorMessage);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
