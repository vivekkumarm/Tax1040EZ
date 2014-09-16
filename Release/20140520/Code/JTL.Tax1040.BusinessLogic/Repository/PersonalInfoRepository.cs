﻿/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : PersonalInfoRepository.cs
Description                 : Personal Info for Repository.
Author                      : Vivekkumar.M
Created Date                : 07 March 2014
 
Modification History:
---------------------
 * 24Mar2014 Bala New methods added for persist and get Ez Eligibility check values.
 * saravanan n. - 27th mar, 2014 - PersistXXX method name changed as per standard.
 * 24Mar2014 Bala New methods added for persist and get Ez Eligibility check values.
 * Saravanan N. - 28th mar, 2014 - PersonId param removed from Persist PT, Address and Spouse methods.
 * 28Mar2014 Sathish Persist Spouse Tax Object
 * 01Apr2014 Sathish Changed GetPrimaryTaxPayerByUserIdAndUserDataId to return primary tax payer not null
 * 08Apr2014 Sathish Added business validation and regular expression validation
 * 11Apr2014 Sathish Changed GetPersonalDetailsByUserIdAndUserDataId to return Error Message list and personal details
 * 15Apr2014 Sathish Checked char has value in busines Validation
 * 16Apr2014 Sathish Checked valid zip code against state
 * 17Apr2014 Sathish Changed zip code to pass string to check is null or empty
 * 02May2014 Bala Modified code to clear the error messages from error message list. 
 * 08May2014 Sathish Set filing status to single if filing status not updated
 *                   Added Date of birth validation against tax year
 * 12May2014 Bala Modified code to check the Eligibility. 
*/

using System;
using System.Dynamic;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.DataAccess;
using JTL.Tax1040.BusinessObject;
using System.Collections.Generic;
using State = JTL.Tax1040.BusinessObject.State;
using System.Activities;
using System.Linq;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;

namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// personal info repository with personal interface repository
    /// </summary>
    public class PersonalInfoRepository : IPersonalInfoRepository
    {
        #region Local variable declaration
        IPersonalInfoDataService personalInfoDataService;
        private readonly MessagesRepository messageRepository;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalInfoRepository"/> class.
        /// </summary>
        public PersonalInfoRepository()
        {
            personalInfoDataService = new PersonalInfoDataService();
            messageRepository = new MessagesRepository();
        }
        #endregion

        #region Private methods

        /// <summary>
        /// Saravanan N. - 26th Mar, 2014 - Store FilingStatus into Tax1040.
        /// </summary>
        /// <param name="primaryTaxPayerDetails"></param>
        /// <param name="taxObject"></param>
        /// <param name="personIdFromDb"></param>
        /// <returns></returns>
        private void PopulateFilingStatusIntoTaxObject(PrimaryTaxPayer primaryTaxPayer, BusinessObject.Tax1040 taxObject, long personIdFromDb)
        {
            if (taxObject.PersonalDetails == null)
            {
                taxObject.PersonalDetails = new PersonalDetails()
                {
                    PrimaryTaxPayer = new PrimaryTaxPayer()
                };
            }

            if (taxObject.PersonalDetails.PrimaryTaxPayer == null)
            {
                taxObject.PersonalDetails.PrimaryTaxPayer = new PrimaryTaxPayer();
            }

            if (taxObject.PersonalDetails.PrimaryTaxPayer.Person == null)
            {
                taxObject.PersonalDetails.PrimaryTaxPayer.Person = new Person();
            }

            //Update FilingStatus.
            taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus = primaryTaxPayer.FilingStatus;

            //Update Person.
            if (primaryTaxPayer.Person != null)
            {
                Address address = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address;
                taxObject.PersonalDetails.PrimaryTaxPayer.Person = primaryTaxPayer.Person;
                taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address = address;
            }
            else
            {
                taxObject.PersonalDetails.PrimaryTaxPayer.Person.PersonId = personIdFromDb;
            }
        }

        /// <summary>
        /// Store Address into Tax object 
        /// </summary>
        /// <param name="address">The Address</param>
        /// <param name="taxObject">The Tax Object</param>
        private void PopulateAddresssIntoTaxObject(Address address, BusinessObject.Tax1040 taxObject)
        {
            if (taxObject.PersonalDetails == null)
            {
                taxObject.PersonalDetails = new PersonalDetails()
                {
                    PrimaryTaxPayer = new PrimaryTaxPayer()
                };
            }

            if (taxObject.PersonalDetails.PrimaryTaxPayer == null)
            {
                taxObject.PersonalDetails.PrimaryTaxPayer = new PrimaryTaxPayer()
                {
                    Person = new Person()
                };
            }

            if (taxObject.PersonalDetails.PrimaryTaxPayer.Person == null)
            {
                taxObject.PersonalDetails.PrimaryTaxPayer.Person = new Person();
            }

            taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address = address;
        }

        /// <summary>
        /// Sathis N 28Mar2014 Store Spouse into Tax object
        /// </summary>
        /// <param name="spouse">The Spouse</param>
        /// <param name="taxObject">The Tax Object</param>
        private void PopulateSpouseIntoTaxObject(Spouse spouse, BusinessObject.Tax1040 taxObject)
        {
            if (taxObject.PersonalDetails == null)
            {
                taxObject.PersonalDetails = new PersonalDetails();
            }

            if (taxObject.PersonalDetails.Spouse == null)
            {
                taxObject.PersonalDetails.Spouse = new Spouse();
            }

            if (taxObject.PersonalDetails.Spouse.Person == null)
            {
                taxObject.PersonalDetails.Spouse.Person = new Person();
            }

            taxObject.PersonalDetails.Spouse.HasLivedInAnotherState = spouse.HasLivedInAnotherState;
            taxObject.PersonalDetails.Spouse.LivedInAnotherStateId = spouse.LivedInAnotherStateId;

            //Update Person.
            if (spouse.Person != null)
            {
                taxObject.PersonalDetails.Spouse.Person = spouse.Person;
            }
        }

        /// <summary>
        /// Clear error messages
        /// </summary>
        /// <param name="errorMessages">The error message list</param>
        /// <returns></returns>
        private void ClearErrorMessages(List<ErrorMessage> errorMessages)
        {
            messageRepository.ClearErrorMessages(errorMessages, Constants.TOPIC_PERSONAL_FILINGSTATUS);
            messageRepository.ClearErrorMessages(errorMessages, Constants.TOPIC_PERSONAL_PRIMARYFILER);
            messageRepository.ClearErrorMessages(errorMessages, Constants.TOPIC_PERSONAL_SPOUSE);
            messageRepository.ClearErrorMessages(errorMessages, Constants.TOPIC_PERSONAL_ADDRESS);
            messageRepository.ClearErrorMessages(errorMessages, Constants.TOPIC_PERSONAL_EZELIGIBILITY);
        }

        #endregion

        #region Persist Methods

        /// <summary>
        /// Persist the personal information.
        /// </summary>
        /// <param name="primaryTaxPayerDetails">The primary tax payer details.</param>
        /// <param name="userId">The user identifier.</param>
        /// <param name="userDataId"></param>
        /// <param name="topic"></param>
        /// <returns>User data.</returns>
        public dynamic PersistPrimaryTaxPayer(PrimaryTaxPayer primaryTaxPayer, long userId, long userDataId, string topic = null)
        {
            var hasEligibilityDiagnostics = false;
            try
            {
                if (primaryTaxPayer != null)
                {
                    var taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);

                    if (taxObject != null && taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                        taxObject.PersonalDetails.PrimaryTaxPayer.Person != null)
                    {
                        if (primaryTaxPayer.Person != null)
                        {
                            primaryTaxPayer.Person.PersonId = taxObject.PersonalDetails.PrimaryTaxPayer.Person.PersonId;
                        }
                        else
                        {
                            primaryTaxPayer.Person = taxObject.PersonalDetails.PrimaryTaxPayer.Person;
                        }
                    }

                    //08May2014 Sathish Set filing status to single if filling status not update and trying to update person detail
                    if (primaryTaxPayer.Person != null && primaryTaxPayer.FilingStatus == FilingStatus.None)
                    {
                        primaryTaxPayer.FilingStatus = FilingStatus.Single;
                    }

                    //Persist into DB.                    
                    var personIdFromDb = personalInfoDataService.PersistPrimaryTaxPayer(primaryTaxPayer, userId);

                    //Update personId for new primaryTax payer.
                    if (primaryTaxPayer.Person != null)
                    {
                        if (primaryTaxPayer.Person.PersonId == 0)
                            primaryTaxPayer.Person.PersonId = personIdFromDb;
                    }

                    //Saravanan N. - 26th Mar, 2014 - Update PersonId into TaxObject.
                    //UpdatePersonIdIntoTaxObject(taxObject, personIdFromDB);
                    if (taxObject.ErrorMessages == null)
                    {
                        //Initializing ErrorMessages
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    }
                    //Retrieving Error Message list from Database
                    var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessages = new ErrorMessages(errorMessage);

                    ClearErrorMessages(taxObject.ErrorMessages);

                    PopulateFilingStatusIntoTaxObject(primaryTaxPayer, taxObject, personIdFromDb);

                    //Invoking Eligibility rule Workflow
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    input.ErrorMessages = errorMessages;
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new PersonalInfoEligibilityRuleCheck(), input));
                    
                                       
                    BusinessValidation(taxObject.PersonalDetails, taxObject.ErrorMessages, errorMessages);
                    if (taxObject != null)
                    {
                        userDataId = Utilities.PersistTaxObject(userId, userDataId, taxObject);
                        if (!string.IsNullOrEmpty(topic))
                        {
                            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.Topic == topic) && em.ErrorCode.StartsWith(topic + "_ER"));
                        }
                    }

                    }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:PersonalInfoRepository,Method Name:PersistPrimaryTaxPayer", ex);
            }
            dynamic userData = new Tuple<long, bool>(userDataId, hasEligibilityDiagnostics);
            return userData;
        }

        /// <summary>
        /// Address Persist
        /// </summary>
        /// <param name="address">The address details.</param>
        /// <param name="personalInfoId">Personal Info Id.</param>
        /// <returns>The User Data ID</returns>
        public long PersistAddress(Address address, long userId, long userDataId)
        {
            try
            {
                if (address != null)
                {
                    BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);

                    long personId = 0;
                    if (taxObject != null && taxObject.PersonalDetails != null &&
                        taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                        taxObject.PersonalDetails.PrimaryTaxPayer.Person != null)
                    {
                        personId = taxObject.PersonalDetails.PrimaryTaxPayer.Person.PersonId;
                    }


                    if (personId == 0)
                    {
                        var personalDetails = new PersonalDetails()
                        {
                            PrimaryTaxPayer = new PrimaryTaxPayer()
                            {
                                FilingStatus = FilingStatus.Single
                            }
                        };
                        userDataId = PersistPrimaryTaxPayer(personalDetails.PrimaryTaxPayer, userId, userDataId);
                        taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);
                        personId = taxObject.PersonalDetails.PrimaryTaxPayer.Person.PersonId;
                    }
                    if (taxObject.ErrorMessages == null)
                    {
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    }

                    //Retrieving Error Message list from Database
                    var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessages = new ErrorMessages(errorMessage);

                    ClearErrorMessages(taxObject.ErrorMessages);

                    PopulateAddresssIntoTaxObject(address, taxObject);
                    personalInfoDataService.PersistAddress(address, personId);
                    BusinessValidation(taxObject.PersonalDetails, taxObject.ErrorMessages, errorMessages);
                    userDataId = Utilities.PersistTaxObject(userId, userDataId, taxObject);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:PersonalInfoRepository,Method Name:PersistAddress", ex);
            }

            return userDataId;
        }


        /// <summary>
        /// Persist Spouse object into DB.
        /// </summary>
        /// <param name="spouse"></param>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        public dynamic PersistSpouse(Spouse spouse, long userId, long userDataId)
        {
            var hasEligibilityDiagnostics = false;
            try
            {
                if (spouse != null)
                {
                    personalInfoDataService.PersistSpouse(spouse, userId);

                    //Sathish N. - 28th Mar, 2014 - Persist into TaxObject.
                    BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);

                    if (taxObject.ErrorMessages == null)
                    {
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    }

                    //Retrieving Error Message list from Database
                    var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessages = new ErrorMessages(errorMessage);

                    ClearErrorMessages(taxObject.ErrorMessages);

                    PopulateSpouseIntoTaxObject(spouse, taxObject);

                    //Invoking Eligibility rule Workflow
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    input.ErrorMessages = errorMessages;
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new PersonalInfoEligibilityRuleCheck(), input));
                   
                    BusinessValidation(taxObject.PersonalDetails, taxObject.ErrorMessages, errorMessages);

                    if (taxObject != null)
                    {
                        userDataId = Utilities.PersistTaxObject(userId, userDataId, taxObject);
                        hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.Topic == Constants.TOPIC_PERSONAL_SPOUSE) && (em.ErrorCode.StartsWith("Spouse_ER")));
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:PersonalInfoRepository,Method Name:PersistSpouse", ex);
            }

            dynamic userData = new Tuple<long, bool>(userDataId, hasEligibilityDiagnostics);
            return userData;
            
        }


        /// <summary>
        /// Persist EzEligiblity into DB.
        /// </summary>
        /// <param name="tax1040Object"></param>
        /// <returns></returns>
        public long PersistEzEligibility(JTL.Tax1040.BusinessObject.Tax1040 tax1040Object, long userId)
        {
            var ezEligibilityId = 0L;
            try
            {
                dynamic ezEligibility = new ExpandoObject();
                ezEligibility.UserId = userId;
                ezEligibility.PersonalInfoId = tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.PersonId;
                ezEligibility.HaveDependent = tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue &&
                tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value;
                ezEligibility.HasReceivedOtherIncome = tax1040Object.Income.HasIncomeFromOtherSources.HasValue &&
                tax1040Object.Income.HasIncomeFromOtherSources.Value;
                ezEligibility.HasAdjustedGrossIncome = tax1040Object.Deductions.HasAGIDeductions.HasValue && tax1040Object.Deductions.HasAGIDeductions.Value;
                ezEligibility.HasClaimedItemizedDeduction = tax1040Object.Deductions.HasItemizedDeductions.HasValue &&
                tax1040Object.Deductions.HasItemizedDeductions.Value;
                ezEligibility.HasClaimedCredit = tax1040Object.Credits.HasCreditsToClaim.HasValue && tax1040Object.Credits.HasCreditsToClaim.Value;
                ezEligibility.HasHiredPerson = tax1040Object.TaxesAndPenalties.HasOwedHouseholdEmploymentTax.HasValue &&
                tax1040Object.TaxesAndPenalties.HasOwedHouseholdEmploymentTax.Value;
                ezEligibility.HasClaimedPriorYearTax = tax1040Object.TaxesAndPenalties.HasAlternativeMinimumTax.HasValue &&
                tax1040Object.TaxesAndPenalties.HasAlternativeMinimumTax.Value;
                ezEligibility.HasPaidAnyEstimate = tax1040Object.Credits.HasEstimatedTaxPayments.HasValue &&
                tax1040Object.Credits.HasEstimatedTaxPayments.Value;
                ezEligibility.HasClaimedAsDebtor = tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsBankruptcyDebtor.HasValue &&
                tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsBankruptcyDebtor.Value;

                ezEligibilityId = personalInfoDataService.PersistEzEligibility(ezEligibility);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:PersonalInfoRepository,Method Name:PersistEzEligibility", ex);
            }

            return ezEligibilityId;

        }

        #endregion

        #region Get Methods
        /// <summary>
        /// Gets the personal information by personal information identifier.
        /// </summary>
        /// <param name="personalInfoId">The personal information identifier.</param>
        /// <returns></returns>
        public PrimaryTaxPayer GetPersonByPersonId(long personId)
        {
            PrimaryTaxPayer primaryTaxPayer = new PrimaryTaxPayer();
            try
            {
                primaryTaxPayer = personalInfoDataService.GetPersonByPersonId(personId);
        }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(personId, "Class:PersonalInfoRepository,Method Name:GetPersonByPersonId", ex);
            }
            return primaryTaxPayer;
        }

        /// <summary>
        /// Gets the personal information by personal information identifier.
        /// </summary>
        /// <param name="personalInfoId">The personal information identifier.</param>
        /// <returns></returns>
        public PrimaryTaxPayer GetPrimaryTaxPayerByUserIdAndUserDataId(long userId, long userDataId)
        {
            PrimaryTaxPayer primaryTaxPayer = new PrimaryTaxPayer();
            try
            {
            //Saravanan N. - Instead of DB call data obtained from TaxObject.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);
                if (taxObject.PersonalDetails == null)
                    taxObject.PersonalDetails = new PersonalDetails();

                primaryTaxPayer = taxObject.PersonalDetails.PrimaryTaxPayer ??
                       (taxObject.PersonalDetails.PrimaryTaxPayer = new PrimaryTaxPayer());
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:PersonalInfoRepository,Method Name:GetPrimaryTaxPayerByUserIdAndUserDataId", ex);
            }

            return primaryTaxPayer;
        }
        //Need to Test this
        /// <summary>
        ///  Gets the Spouse information by personal information identifier.
        /// </summary>
        /// <param name="personId"></param>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        public dynamic GetSpouseByUserIdAndUserDataId(long userId, long userDataId)
        {
            dynamic personalDetails = new ExpandoObject();
            try
            {

                BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);
                if (taxObject.PersonalDetails == null)
                    taxObject.PersonalDetails = new PersonalDetails();
                        
                if (taxObject.PersonalDetails.PrimaryTaxPayer == null)
                {
                    taxObject.PersonalDetails.PrimaryTaxPayer = new PrimaryTaxPayer()
                    {
                        FilingStatus = FilingStatus.Single
                    };
                }

                if (taxObject.PersonalDetails.Spouse == null)
                {
                    taxObject.PersonalDetails.Spouse = new Spouse();
                }

                personalDetails.Spouse = taxObject.PersonalDetails.Spouse;
                personalDetails.FilingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:PersonalInfoRepository,Method Name:GetSpouseByUserIdAndUserDataId", ex);
            }
            return personalDetails;
        }

        /// <summary>
        /// Gets the Address by UserId and UserDataId.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        public dynamic GetAddressByUserIdAndUserDataId(long userId, long userDataId)
        {
            dynamic personalDetails = new ExpandoObject();
            try
            {
                BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);
                if (taxObject.PersonalDetails == null)
                {
                    taxObject.PersonalDetails = new PersonalDetails()
                        {
                            PrimaryTaxPayer = new PrimaryTaxPayer()
                                {
                                    Person = new Person()
                                }
                        };
                }
                else if (taxObject.PersonalDetails.PrimaryTaxPayer == null)
                {
                    taxObject.PersonalDetails.PrimaryTaxPayer = new PrimaryTaxPayer()
                        {
                            Person = new Person()
                        };
                }
                else if (taxObject.PersonalDetails.PrimaryTaxPayer.Person == null)
                {
                    taxObject.PersonalDetails.PrimaryTaxPayer.Person = new Person();
                }

                var taxPayerName = Constants.DEFAULT_TAX_PAYER_NAME;
               
                if (!string.IsNullOrEmpty(taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName))
                  taxPayerName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName;
                else if (!string.IsNullOrEmpty(taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName))
                  taxPayerName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName;

                personalDetails.Address = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address;
                personalDetails.FilingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                personalDetails.TaxPayerName = taxPayerName;

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:PersonalInfoRepository,Method Name:GetAddressByUserIdAndUserDataId", ex);
            }

            return personalDetails;

        }



        /// <summary>
        /// Get All the States
        /// </summary>
        /// <returns></returns>
        public List<State> GetAllState(bool isAdditionalMailingAddress = false)
        {
            return personalInfoDataService.GetAllState(isAdditionalMailingAddress);
        }

        /// <summary>
        /// Get All Country
        /// </summary>
        /// <returns>Country as a List</returns>
        public List<Country> GetAllCountry()
        {
            return personalInfoDataService.GetAllCountry();
        }

        /// <summary>
        /// Get EzEligibility By PersonalInfo Id
        /// </summary>
        /// <returns></returns>
        public dynamic GetEzEligibilityByPersonalInfoId(long personId)
        {
            dynamic ezEligibility = new ExpandoObject();
            try
            {
                ezEligibility = personalInfoDataService.GetEzEligibilityByPersonalInfoId(personId);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(personId, "Class:PersonalInfoRepository,Method Name:GetEzEligibilityByPersonalInfoId", ex);
            }

            return ezEligibility;
        }

        /// <summary>
        /// Get Personal Detail by user Id and Data Id
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The Data Id</param>
        /// <returns>The Personal Details</returns>
        public System.Tuple<PersonalDetails, List<ErrorMessage>> GetPersonalDetailsByUserIdAndUserDataId(long userId, long userDataId)
        {
            List<ErrorMessage> taxObjectErrorList = new List<ErrorMessage>();
            BusinessObject.Tax1040 taxObject = new BusinessObject.Tax1040();
            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);

                if (taxObject.PersonalDetails == null)
                {
                    taxObject.PersonalDetails = new PersonalDetails();
                }

                if (taxObject.PersonalDetails.PrimaryTaxPayer != null)
                {
                    taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatusDescription =
                        Utilities.GetEnumDescription(taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus);

                    if (taxObject.ErrorMessages != null)
                    {
                        taxObjectErrorList = taxObject.ErrorMessages.FindAll(em => (em.Topic == Constants.TOPIC_PERSONAL_FILINGSTATUS) || (em.Topic == Constants.TOPIC_PERSONAL_PRIMARYFILER) || (em.Topic == Constants.TOPIC_PERSONAL_ADDRESS));

                        if (taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly)
                        {
                            taxObjectErrorList.AddRange(taxObject.ErrorMessages.FindAll(em => (em.Topic == Constants.TOPIC_PERSONAL_SPOUSE)).AsEnumerable());
                        }
                    }

                }
                               
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:PersonalInfoRepository,Method Name:GetPersonalDetailsByUserIdAndUserDataId", ex);
            }

            return new System.Tuple<PersonalDetails, List<ErrorMessage>>(taxObject.PersonalDetails,
                                                                         taxObjectErrorList);

        }

        /// <summary>
        /// Gets the Person id by UserId and UserDataId.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns>The person id.</returns>
        public long GetPersonIdByUserIdAndUserDataId(long userId, long userDataId)
        {
            BusinessObject.Tax1040 taxObject = new BusinessObject.Tax1040();
            try
            {
                taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);

                if (taxObject.PersonalDetails == null)
                {
                    taxObject.PersonalDetails = new PersonalDetails();
                }
                if (taxObject.PersonalDetails.PrimaryTaxPayer == null)
                {
                    taxObject.PersonalDetails.PrimaryTaxPayer = new PrimaryTaxPayer();
                }
                if (taxObject.PersonalDetails.PrimaryTaxPayer.Person == null)
                {
                    taxObject.PersonalDetails.PrimaryTaxPayer.Person = new Person();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:PersonalInfoRepository,Method Name:GetPersonIdByUserIdAndUserDataId", ex);
            }

            return taxObject.PersonalDetails.PrimaryTaxPayer.Person.PersonId;
        }

        #endregion

        #region Validation

        public void BusinessValidation(PersonalDetails personalDetails, List<ErrorMessage> errorMessageList,
                                       ErrorMessages errorMessages)
        {
            //Person Validation
            if (personalDetails != null && personalDetails.PrimaryTaxPayer != null &&
                personalDetails.PrimaryTaxPayer.Person != null)
            {
                ErrorMessage errorMessage =
                    BusinessValidationRepository.AssertIsNotNullOrEmpty(
                        personalDetails.PrimaryTaxPayer.Person.FirstName,
                        Constants.TAXPAYER_MISSING_FIRST_NAME, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                errorMessage =
                    BusinessValidationRepository.AssertIsNotNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.LastName,
                                                                        Constants.TAXPAYER_MISSING_LAST_NAME,
                                                                        errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                errorMessage =
                    BusinessValidationRepository.AssertIsNotNull(personalDetails.PrimaryTaxPayer.Person.DateOfBirth,
                                                                 Constants.TAXPAYER_MISSING_DATE_OF_BIRTH, errorMessages);
                if (errorMessage != null)
                {
                    errorMessageList.Add(errorMessage);
                }

                errorMessage =
                  BusinessValidationRepository.AssertIsEqual(personalDetails.PrimaryTaxPayer.Person.DateOfBirth, new DateTime(1899, 12, 31),
                                                               Constants.TAXPAYER_MISSING_DATE_OF_BIRTH, errorMessages);
                if (errorMessage != null)
                {
                    errorMessageList.Add(errorMessage);
                }

                var dateTime = new DateTime(1899, 12, 31);
                if (personalDetails.PrimaryTaxPayer.Person.DateOfBirth != null && personalDetails.PrimaryTaxPayer.Person.DateOfBirth.ToShortDateString() != dateTime.ToShortDateString() && personalDetails.PrimaryTaxPayer.Person.DateOfBirth != DateTime.MinValue)
                {

                        errorMessage =
                         BusinessValidationRepository.AssertIsLessthenIntegerValue(personalDetails.PrimaryTaxPayer.Person.DateOfBirth.Year,
                                                                            Constants.TAX_YEAR,
                                                                 Constants.TAXPAYER_DATE_OF_BIRTH_GREATER_THAT_TAX_YEAR, errorMessages);
                        if (errorMessage != null)
                        {
                            errorMessageList.Add(errorMessage);
                        }

                }

                errorMessage =
                    BusinessValidationRepository.AssertIsNotNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.SSN,
                                                                        Constants.TAXPAYER_MISSING_SSN, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                if (personalDetails.PrimaryTaxPayer.Person.IsDied.HasValue && personalDetails.PrimaryTaxPayer.Person.IsDied.Value)
                {
                errorMessage =
                    BusinessValidationRepository.AssertIsNotNull(personalDetails.PrimaryTaxPayer.Person.DateOfDeath,
                                                                 Constants.TAXPAYER_MISSING_DATE_OF_DEATH, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);
                }

                if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.FirstName))
                {
                errorMessage =
                    BusinessValidationRepository.AssertIsOnlyAlphapet(personalDetails.PrimaryTaxPayer.Person.FirstName,
                                                                      Constants.TAXPAYER_FIRST_NAME_ALPHABET,
                                                                      errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);
                }

                if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.LastName))
                {

                errorMessage =
                    BusinessValidationRepository.AssertIsOnlyAlphapet(personalDetails.PrimaryTaxPayer.Person.LastName,
                                                                      Constants.TAXPAYER_LAST_NAME_ALPHABET,
                                                                      errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);
                }

                if (personalDetails.PrimaryTaxPayer.Person.MiddleInitial.HasValue)
                {

                errorMessage =
                        BusinessValidationRepository.AssertIsOnlyAlphapet(personalDetails.PrimaryTaxPayer.Person.MiddleInitial.Value,
                        Constants.TAXPAYER_MIDDLE_NAME_ALPHABET, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);
                }

                if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.NickName))
                {

                errorMessage =
                    BusinessValidationRepository.AssertIsOnlyAlphapet(personalDetails.PrimaryTaxPayer.Person.NickName,
                                                                      Constants.TAXPAYER_NICK_NAME_ALPHABET,
                                                                      errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                }
                errorMessage =
                  BusinessValidationRepository.AssertIsNotNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Occupation,
                                                                      Constants.TAXPAYER_MISSING_OCCUPATION_NAME,
                                                                      errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);
                
                if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Occupation))
                {

                errorMessage =
                    BusinessValidationRepository.AssertIsOnlyAlphapet(personalDetails.PrimaryTaxPayer.Person.Occupation,
                                                                      Constants.TAXPAYER_OCCUPATION_NAME_ALPHABET,
                                                                      errorMessages);

                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);
                }

                if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.SSN))
                {

                errorMessage = BusinessValidationRepository.IsValidSSN(personalDetails.PrimaryTaxPayer.Person.SSN,
                                                                       Constants.TAXPAYER_INVALID_SSN, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

            }
            }
            // Spouse Validation
            if (personalDetails != null && personalDetails.Spouse != null && personalDetails.Spouse.Person != null)
            {
                ErrorMessage errorMessage =
                    BusinessValidationRepository.AssertIsNotNullOrEmpty(personalDetails.Spouse.Person.FirstName,
                                                                        Constants.SPOUSE_MISSING_FIRST_NAME,
                                                                        errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                errorMessage =
                    BusinessValidationRepository.AssertIsNotNullOrEmpty(personalDetails.Spouse.Person.LastName,
                                                                        Constants.SPOUSE_MISSING_LAST_NAME,
                                                                        errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                errorMessage = BusinessValidationRepository.AssertIsNotNullOrEmpty(personalDetails.Spouse.Person.SSN,
                                                                                   Constants.SPOUSE_MISSING_SSN,
                                                                                   errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                errorMessage = BusinessValidationRepository.AssertIsNotNull(personalDetails.Spouse.Person.DateOfBirth,
                                                                            Constants.SPOUSE_MISSING_DATE_OF_BIRTH,
                                                                            errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                errorMessage = BusinessValidationRepository.AssertIsEqual(personalDetails.Spouse.Person.DateOfBirth, new DateTime(1899, 12, 31),
                                                            Constants.SPOUSE_MISSING_DATE_OF_BIRTH,
                                                            errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                if (personalDetails.Spouse.Person.DateOfBirth != null)
                {

                    errorMessage = BusinessValidationRepository.AssertIsLessthenIntegerValue(personalDetails.Spouse.Person.DateOfBirth.Year,
                                                                                    Constants.TAX_YEAR,
                                                                                  Constants.SPOUSE_DATE_OF_BIRTH_GREATER_THAT_TAX_YEAR,
                                                                                  errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                }


                errorMessage = BusinessValidationRepository.AssertGreaterThanZero(personalDetails.Spouse.LivedInAnotherStateId,
                                                                        Constants.SPOUSE_STATE_OF_RESIDENCE,
                                                                        errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                if (personalDetails.Spouse.Person.IsDied.HasValue && personalDetails.Spouse.Person.IsDied.Value)
                {
              errorMessage = BusinessValidationRepository.AssertIsNotNull(personalDetails.Spouse.Person.DateOfDeath,
                                                                              Constants.SPOUSE_MISSING_DATE_OF_DEATH,
                                                                              errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
              
                }
              

                errorMessage =
                    BusinessValidationRepository.AssertGreaterThanZero(personalDetails.Spouse.LivedInAnotherStateId,
                                                                       Constants.SOCIAL_SECURITY_AND_RAILROAD_BENEFITS,
                                                                       errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                errorMessage =
                    BusinessValidationRepository.AssertIsNotNullOrEmpty(personalDetails.Spouse.Person.Occupation,
                                                                        Constants.SPOUSE_MISSING_OCCUPATION_NAME,
                                                                        errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                if (!string.IsNullOrEmpty(personalDetails.Spouse.Person.FirstName))
                {

                errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(
                    personalDetails.Spouse.Person.FirstName,
                    Constants.SPOUSE_FIRST_NAME_ALPHABET, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);

                }

                if (!string.IsNullOrEmpty(personalDetails.Spouse.Person.LastName))
                {

                errorMessage = BusinessValidationRepository.AssertIsOnlyAlphapet(personalDetails.Spouse.Person.LastName,
                                                                                 Constants.SPOUSE_LAST_NAME_ALPHABET,
                                                                                 errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);
                }

                if (personalDetails.Spouse.Person.MiddleInitial.HasValue)
                {
                errorMessage =
                        BusinessValidationRepository.AssertIsOnlyAlphapet(personalDetails.Spouse.Person.MiddleInitial.Value,
                                                                      Constants.SPOUSE_MIDDLE_NAME_ALPHABET,
                                                                      errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);
                }

                if (!string.IsNullOrEmpty(personalDetails.Spouse.Person.SSN))
                {
                errorMessage = BusinessValidationRepository.IsValidSSN(personalDetails.Spouse.Person.SSN,
                                                                       Constants.SPOUSE_INVALID_SSN, errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);
                }


                if (!string.IsNullOrEmpty(personalDetails.Spouse.Person.Occupation))
                {
                errorMessage =
                    BusinessValidationRepository.AssertIsOnlyAlphapet(personalDetails.Spouse.Person.Occupation,
                                                                      Constants.SPOUSE_OCCUPATION_NAME_ALPHABET,
                                                                      errorMessages);
                if (errorMessage != null)
                    errorMessageList.Add(errorMessage);
            }
            }

            // Person Address Validation
            if (personalDetails != null && personalDetails.PrimaryTaxPayer != null &&
                personalDetails.PrimaryTaxPayer.Person != null &&
                personalDetails.PrimaryTaxPayer.Person.Address != null)
            {
                ErrorMessage errorMessage;
                if (personalDetails.PrimaryTaxPayer.Person.Address.AddressType == AddressType.PersonalAddress)
                {
                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(
                            personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.StreetAddress,
                            Constants.TAXPAYER_PERSONAL_ADDRESS_MISSING_STREET, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(
                            personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.City,
                            Constants.TAXPAYER_PERSONAL_ADDRESS_MISSING_CITY, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    if (personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.ZipCode.HasValue)
                    {
                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(
                           Convert.ToString(personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.ZipCode),
                            Constants.TAXPAYER_PERSONAL_ADDRESS_MISSING_ZIP_CODE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    }

                    errorMessage =
                        BusinessValidationRepository.AssertGreaterThanZero(
                            personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.StateId,
                            Constants.TAXPAYER_PERSONAL_ADDRESS_MISSING_STATE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(
                            personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.PhoneNumber,
                            Constants.TAXPAYER_ADDRESS_MISSING_PHONE_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.StreetAddress))
                    {

                    errorMessage =
                        BusinessValidationRepository.AssertIsOnlyAlphapet(
                            personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.StreetAddress,
                            Constants.TAXPAYER_PERSONAL_ADDRESS_STREET_ALPHABET, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    }

                    if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.City))
                    {
                    errorMessage =
                        BusinessValidationRepository.AssertIsOnlyAlphapet(
                            personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.City,
                            Constants.TAXPAYER_PERSONAL_ADDRESS_CITY_ALPHABET, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    }

                    if (personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.ZipCode.HasValue)
                    {
                        bool isValidZipcodeForState =
                            personalInfoDataService.ValidateZipCodeByStateId(
                                personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.StateId,
                                personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.ZipCode.Value);

                        errorMessage = BusinessValidationRepository.AssertIsTrue(isValidZipcodeForState,
                                Constants.TAXPAYER_PERSONAL_ADDRESS_VALID_ZIP_CODE, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.PhoneNumber))
                    {
                    errorMessage =
                        BusinessValidationRepository.AssertIsWithinRange(
                            personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.PhoneNumber, 10, 10,
                            Constants.TAXPAYER_PERSONAL_ADDRESS_VALID_PHONE_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    }

                }
                else if (personalDetails.PrimaryTaxPayer.Person.Address.AddressType == AddressType.ForeignAddress)
                {
                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(
                            personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.StreetAddress,
                            Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_STREET, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);


                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(
                            personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.City,
                            Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_CITY, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(
                            personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.StateOrProvince,
                            Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_STATE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(
                            personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.PostalCode,
                            Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_POSTAL_CODE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.StreetAddress))
                    {
                    errorMessage =
                        BusinessValidationRepository.AssertIsOnlyAlphapet(
                            personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.StreetAddress,
                            Constants.TAXPAYER_FOREIGN_ADDRESS_STREET_ALPHABET, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    }

                     if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.City))
                    {
                    errorMessage =
                        BusinessValidationRepository.AssertIsOnlyAlphapet(
                            personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.City,
                            Constants.TAXPAYER_FOREIGN_ADDRESS_CITY_ALPHABET, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                     }

                     if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.StateOrProvince))
                     {
                    errorMessage =
                        BusinessValidationRepository.AssertIsOnlyAlphapet(
                            personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.StateOrProvince,
                            Constants.TAXPAYER_FOREIGN_ADDRESS_STATE_OR_PROVINCE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }
                }
                if (personalDetails.PrimaryTaxPayer.Person.Address.ResidenceState != null)
                {
                    errorMessage =
                        BusinessValidationRepository.AssertGreaterThanZero(
                            personalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateId,
                            Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_RESIDENT_STATE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

                if (personalDetails.PrimaryTaxPayer.Person.Address.HasLivedInMoreThanOneState.HasValue && personalDetails.PrimaryTaxPayer.Person.Address.HasLivedInMoreThanOneState.Value)
                {
                    errorMessage =
                        BusinessValidationRepository.AssertGreaterThanZero(
                            personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateId,
                            Constants.TAXPAYER_ADDRESS_MISSING_LIVED_IN_ANOTHER_STATE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNull(
                            personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateFrom,
                            Constants.TAXPAYER_ADDRESS_MISSING_LIVED_IN_ANOTHER_STATE_FROM, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNull(
                            personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateTo,
                            Constants.TAXPAYER_ADDRESS_MISSING_LIVED_IN_ANOTHER_STATE_TO, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }
                if (personalDetails.PrimaryTaxPayer.Person.Address.HasEarnedIncomeFromNonLivedState == true)
                {
                    errorMessage =
                        BusinessValidationRepository.AssertGreaterThanZero(
                            personalDetails.PrimaryTaxPayer.Person.Address.EarnedIncomeFromNonLivedStateId,
                            Constants.TAXPAYER_ADDRESS_MISSING_EARNED_INCOME_STATE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }

            }
        }

       
        #endregion

    }
}