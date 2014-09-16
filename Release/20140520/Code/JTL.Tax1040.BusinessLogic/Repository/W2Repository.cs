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
 */

using System;
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
                //Creating Instance if Income section is Null
                if (taxObject.Income == null)
                {
                    taxObject.Income = new Income();
                }

                w2 = PersistW2Data(taxReturnData.TaxData, taxObject);

                if (taxObject.ErrorMessages == null)
                {
                taxObject.ErrorMessages = new List<ErrorMessage>();
                }
                //Initializing Out Parameter
                List<ErrorMessage> errorMessageList = new List<ErrorMessage>();

                // Clear the Error messages exist for this topic.
                messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_WAGES);

                //Obtain the List of Error Messages from DB.
                var errorMessagesFromDB = messageRepository.GetErrorMessages();
                var errorMessagesAll = new ErrorMessages(errorMessagesFromDB);

                //Call to Required and Validations Server side Validation check.
                if (taxObject.Income.W2Wages != null)
                {
                    BusinessFieldValidations(taxObject.Income.W2Wages, taxObject.ErrorMessages, errorMessagesAll);
                }

                //Workflow Validation check.
                dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                input.Tax1040Object = taxObject;


                //Assisn error message list into workflow input param.
                input.ErrorMessages = errorMessagesAll;

                //Call to Business validation workflow to obtain Business Validation error messages.
                var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new FW2BusinessRuleValidation(), input));
                taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

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

                if (w2ListObject != null && w2ListObject.Any())
                {
                    //Saravanan N - 13th May, 2014 - Id used from UserDTO.
                    int index = w2ListObject.FindIndex(wages => wages.W2Id == userDTO.FormId);

                    if (index >= 0)
                    {
                        taxReutrnData = new System.Tuple<W2, dynamic>(w2ListObject[index], taxReturnPersonData);
                    }
                    else
                    {
                        taxReutrnData = new System.Tuple<W2, dynamic>(null, taxReturnPersonData);
                    }
                }
                else
                {
                    taxReutrnData = new System.Tuple<W2, dynamic>(null, taxReturnPersonData);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:W2Repository,Method Name:GetW2Data", ex);
            }

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

                double wagesAmount = 0;

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
                        taxObjectErrorList = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_WAGES);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userDTO.UserId, "Class:W2Repository,Method Name:GetW2ListandErrorList", ex);
            }

            return new System.Tuple<List<W2>, IEnumerable<ErrorMessage>, dynamic>(w2ListObject, taxObjectErrorList, personData);
        }  

        /// <summary>
        /// Delete and persist W2
        /// </summary>
        /// <param name="userId">The User ID</param>
        /// <param name="w2Id">The W2 id</param>
        /// <param name="userDataId">The User Data ID</param>
        /// <param name="errorMessageList">The Error Message List</param>
        public void DeleteAndPersistW2(UserDTO userDTO)
        {
            JTL.Tax1040.BusinessObject.Tax1040 taxObject;
            try
            {
                //Retrieving TaxObject from database
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userDTO.UserId, userDTO.UserDataId);

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

                    //Persist latest TaxObject.
                    Utilities.PersistTaxObject(userDTO.UserId, userDTO.UserDataId, taxObject);
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
            var IsValid=false;

            foreach (var wages in lstW2Wages)
            {
                if (wages != null)
                {
                    //Variable declaration
                    var w2Id = wages.W2Id;

                    //Required and Validations.
                    if (wages.EmploymentType != EmploymentType.HouseholdEmployeeWages &&
                        wages.EmploymentType != EmploymentType.TaxableScholarshipIncome)
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
                                IsValid = Utilities.IsValidRegexPattern(wages.Employer.Organization.EIN, @"[0-9\-]{10}");
                                if (!IsValid || !IsNumeric || eIN == Constants.NineZeros || eIN == Constants.NineNines)
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

                            if (!string.IsNullOrEmpty (wages.Employer.Organization.Name))
                            {
                                //Validation entry #2
                            errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(wages.Employer.Organization.Name,
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
                                errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(wages.Employer.Organization.Address.CompanyAddress.StreetAddress,
                                        Constants.WAGES_EMPLOYER_ADDRESS_ALPHABET, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }

                                //Required entry #6
                                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.City,
                                        Constants.WAGES_EMPLOYER_CITY, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                if (!string.IsNullOrEmpty (wages.Employer.Organization.Address.CompanyAddress.City))
                                {
                                    //Validation entry #4
                                errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(wages.Employer.Organization.Address.CompanyAddress.City,
                                        Constants.WAGES_EMPLOYER_CITY_ALPHABET, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                }

                                //Required entry #7
                                errorMessage = BusinessValidationRepository.AssertGreaterThanZero(wages.Employer.Organization.Address.CompanyAddress.StateId,
                                                Constants.WAGES_EMPLOYER_STATE, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                //Required entry #8
                                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.Zip,
                                                                Constants.WAGES_EMPLOYER_ZIP, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                //Validation ZIP Code #10 
                                if (wages.Employer.Organization.Address != null)
                                {
                                    if (wages.Employer.Organization.Address.CompanyAddress != null)
                                    {
                                        if ((!string.IsNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.Zip)))
                                        {
                                            bool isValidZipcodeForState = personalInfoDataService.ValidateZipCodeByStateId(
                                                  wages.Employer.Organization.Address.CompanyAddress.StateId,
                                                  Convert.ToInt64(wages.Employer.Organization.Address.CompanyAddress.Zip));

                                            errorMessage = BusinessValidationRepository.AssertIsTrue(isValidZipcodeForState,
                                            Constants.WAGES_INSTITUITION_ZIP_INVALID, errorMessagesAllFromDB);

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
                                    errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(wages.EmployeeAddress.StreetAddress,
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
                                    errorMessage = BusinessValidationRepository.AssertGreaterThanZero(wages.EmployeeAddress.StateId,
                                                    Constants.WAGES_EMPLOYEE_STATE, errorMessagesAllFromDB);
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                        //Required entry #12
                                    errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.EmployeeAddress.ZipCode,
                                                                    Constants.WAGES_EMPLOYEE_ZIP, errorMessagesAllFromDB);
                                    //Add Error Messages into TaxObject with current Form Id.
                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                        //Validation ZIP Code #11 
                                        if (wages.Employer.Organization.Address != null)
                                        {
                                            if (wages.Employer.Organization.Address.CompanyAddress != null)
                                            {
                                                if ((!string.IsNullOrEmpty(wages.EmployeeAddress.ZipCode)))
                                                {
                                                    bool isValidZipcodeForState = personalInfoDataService.ValidateZipCodeByStateId(
                                                          wages.EmployeeAddress.StateId, Convert.ToInt64(wages.EmployeeAddress.ZipCode));

                                                    errorMessage = BusinessValidationRepository.AssertIsTrue(isValidZipcodeForState,
                                                    Constants.WAGES_INSTITUITION_ZIP_INVALID, errorMessagesAllFromDB);

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

                                //Saravanan N - 14th May, 2014 - Null check done.
                                if (wages.W2StateLocalTaxInfo != null)
                                {
                                foreach (var stateLocalTax in wages.W2StateLocalTaxInfo)
                                {
                                        if (stateLocalTax != null)
                                        {
                                            if (stateLocalTax.StateWagesAmount.HasValue) //State Wages has value 
                                            {
                                                //Required Entry # 15.
                                                if(stateLocalTax.StateId ==0)
                                                {
                                                errorMessage = errorMessagesAllFromDB[Constants.WAGES_STATE_LOCAL_STATE_CODE];
                                                //Add Error Messages into TaxObject with current Form Id.
                                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                }
                                            }

                                            if (stateLocalTax.StateId > 0)
                                            {
                                                //Required Entry # 16.
                                                if (string.IsNullOrEmpty(stateLocalTax.StateCode))
                                                {
                                                    errorMessage = errorMessagesAllFromDB[Constants.WAGES_STATE_LOCAL_STATE_ID];
                                                    //Add Error Messages into TaxObject with current Form Id.
                                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                }

                                                //Required Entry # 17.
                                                if (!stateLocalTax.StateWagesAmount.HasValue)
                                                {
                                                    errorMessage = errorMessagesAllFromDB[Constants.WAGES_STATE_LOCAL_STATE_WAGES];
                                                    //Add Error Messages into TaxObject with current Form Id.
                                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                }
                                            }

                                            if (stateLocalTax.StateWagesAmount.HasValue)
                                            {
                                                if (!stateLocalTax.StateTaxWithholdingAmount.HasValue)
                                                {
                                                    //Required Entry # 18.
                                                    errorMessage = errorMessagesAllFromDB[Constants.WAGES_STATE_LOCAL_STATE_WAGES_TAX_WITH_HOLDING_AMOUNT];
                                                    //Add Error Messages into TaxObject with current Form Id.
                                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
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
                                                        //Required Entry # 19.
                                                        if (localTaxInfo.LocalTaxWithholdingAmount.HasValue && (!string.IsNullOrEmpty(localTaxInfo.LocalityName.Trim())))
                                                        {
                                                            if (!localTaxInfo.LocalWagesAmount.HasValue) 
                                                            {
                                                                errorMessage = errorMessagesAllFromDB[Constants.WAGES_LOCAL_WAGES_AMOUNT];
                                        //Add Error Messages into TaxObject with current Form Id.
                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                            }
                                                        }

                                                        //Required Entry # 20.
                                                        if ((!string.IsNullOrEmpty(localTaxInfo.LocalityName.Trim())) && localTaxInfo.LocalWagesAmount.HasValue)
                                                        {
                                                            if(!localTaxInfo.LocalTaxWithholdingAmount.HasValue) 
                                                            {
                                                                errorMessage = errorMessagesAllFromDB[Constants.WAGES_LOCAL_WAGES_WITH_HOLDING_AMOUNT];
                                        //Add Error Messages into TaxObject with current Form Id.
                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                                            }
                                                        }

                                                        //Required Entry # 21.
                                                        if (localTaxInfo.LocalTaxWithholdingAmount.HasValue && localTaxInfo.LocalWagesAmount.HasValue)
                                                        {
                                                            if (string.IsNullOrEmpty(localTaxInfo.LocalityName.Trim()))
                                                            {
                                                                 
                                                                errorMessage = errorMessagesAllFromDB[Constants.WAGES_LOCAL_WAGES_LOCALITY_NAME];
                                        //Add Error Messages into TaxObject with current Form Id.
                                        AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                    }
                                }

                                    }
                                }
                                            }
                                        }
                                    }
                                }

                                if (wages.W2EmployerCodes != null)
                                {
                                    //Required field Validation for employerCode
                                    var employerCodeCount = 0;
                                foreach (var employerCode in wages.W2EmployerCodes)
                                {
                                        employerCodeCount++;

                                        if (employerCode.EmployerCode != EmployerCode.NoneSelected)
                                        {

                                            if (employerCode.Amount == 0 || employerCode.Amount == null)
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
                                            }

                                    AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
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
                                errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(wages.Employer.Organization.Name,
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
                                errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(wages.Employer.Organization.Address.CompanyAddress.StreetAddress,
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
                                errorMessage = BusinessValidationRepository.AssertGreaterThanZero(wages.Employer.Organization.Address.CompanyAddress.StateId,
                                 Constants.WAGES_INSTITUITION_STATE, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);

                                //Required Entry #31
                                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.Zip,
                                                                Constants.WAGES_INSTITUITION_ZIP, errorMessagesAllFromDB);
                                //Add Error Messages into TaxObject with current Form Id.
                                AddErrorToTaxObjectWithFormId(errorMessageListInTaxObject, w2Id, errorMessage);
                                //Validation ZIP Code #15 
                                if (wages.Employer.Organization.Address != null)
                                {
                                    if (wages.Employer.Organization.Address.CompanyAddress != null)
                                    {
                                        if ((!string.IsNullOrEmpty(wages.Employer.Organization.Address.CompanyAddress.Zip)))
                                        {
                                            bool isValidZipcodeForState = personalInfoDataService.ValidateZipCodeByStateId( 
                                                  wages.Employer.Organization.Address.CompanyAddress.StateId,
                                                  Convert.ToInt64 (wages.Employer.Organization.Address.CompanyAddress.Zip));

                                            errorMessage = BusinessValidationRepository.AssertIsTrue(isValidZipcodeForState,
                                            Constants.WAGES_INSTITUITION_ZIP_INVALID, errorMessagesAllFromDB);

                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Helper Methods
        private static W2 PersistW2Data(string w2Data, BusinessObject.Tax1040 taxObject)
        {
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
                    taxObject.Income.W2Wages.Add(w2);
                }
                else
                {
                    taxObject.Income.W2Wages[index] = w2;
                }
            }
            else
            {
                w2.W2Id = 1;
                //Creating Instance if W2WagesList section is Null
                taxObject.Income.W2Wages = new List<W2> { w2 };
                //Adding new W2 to the TaxObject W2List
            }

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
