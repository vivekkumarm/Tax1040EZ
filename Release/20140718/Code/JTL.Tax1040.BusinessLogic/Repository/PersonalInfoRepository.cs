/*
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
 * 22May2014 Bala Modified code to move the zip code validation to Utilities file. 
 * 28May2014 Ashok Modified code To check Personal Info Eligibility on Address Persist also 
 * 04.06.14 thileep Changed Phone no Validation.  
 * 05Jun2014 Sathish added optional parameter taxobject used in delete spouse info while changing filling status MFJ to single
 * 13Jun2014 Bala Removed Social security validation Whenever click on 'Continue' button in any 'Personal Info' section, it adds +1 in 'Income' error count in 'Bredcrum'.
 * vivek -7-July-14 null checked 
 * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
 * 14thJuly2014 Ashok - Added logic for Clearing EIC Worksheet, Form 8862 and EIC classes when failing EIC eligibility
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
            taxObject.PersonalDetails.Spouse.LivedInAnotherState = new State() //10Jul2014 Sathish changed to new state bo
            {
                StateId = spouse.LivedInAnotherState.StateId
            };

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

                    // 05Jun2014 Sathish Delete the spouse information if filling status is single
                    if (taxObject != null && taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null)
                    {
                        if (taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus != FilingStatus.None &&
                            taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus != primaryTaxPayer.FilingStatus
                            && primaryTaxPayer.FilingStatus == FilingStatus.Single)
                            DeleteSpouseInfo(userId, userDataId, taxObject);
                    }

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

                    //Bala,16Jul2014 Code implemented for creating Taxpayer, Spouse and address
                    if (primaryTaxPayer.Person == null && topic == Constants.TOPIC_PERSONAL_FILINGSTATUS)
                    {
                        primaryTaxPayer.Person = new Person()
                        {
                            PersonType = PersonType.PrimaryTaxPayer,
                            PersonId = personIdFromDb
                        };

                    PopulateFilingStatusIntoTaxObject(primaryTaxPayer, taxObject, personIdFromDb);

                        Address address = new Address()
                            {
                                AddressType = AddressType.PersonalAddress,
                                PersonalAddress = new PersonalAddress()
                            };

                        PopulateAddresssIntoTaxObject(address, taxObject);

                    }
                    else
                    {
                        PopulateFilingStatusIntoTaxObject(primaryTaxPayer, taxObject, personIdFromDb);
                    }

                    if (taxObject.PersonalDetails.Spouse == null && primaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly)
                    {
                        Spouse spouse = new Spouse()
                        {
                            Person = new Person()
                            {
                                PersonType = PersonType.Spouse,
                            },
                            LivedInAnotherState = new State()
                            {
                                StateId = 0
                            }
                        };

                        PopulateSpouseIntoTaxObject(spouse, taxObject);
                    }

                    if (taxObject.ErrorMessages == null)
                    {
                        //Initializing ErrorMessages
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    }

                    //Retrieving Error Message list from Database
                    var errorMessage = messageRepository.GetErrorMessages();
                    var errorMessages = new ErrorMessages(errorMessage);

                    //Bala - 18 Jun, 2014 - code modified to avoid adding error messages for PrimaryTaxpayer(its showing error message count in PersonalInfo Breadcrum even before entering the values in PrimaryFiler).
                    //Bala - 16Jul2014 - Again Code commented to fix the Defect#14176 raised by testingTeam.
                    //if (topic != Constants.TOPIC_PERSONAL_FILINGSTATUS)
                    //{
                    //Saravanan N. - 26th Mar, 2014 - Update PersonId into TaxObject.
                    //UpdatePersonIdIntoTaxObject(taxObject, personIdFromDB);

                    ClearErrorMessages(taxObject.ErrorMessages);

                    //Invoking Eligibility rule Workflow
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    input.ErrorMessages = errorMessages;
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new PersonalInfoEligibilityRuleCheck(), input));
                    BusinessValidation(taxObject.PersonalDetails, taxObject.ErrorMessages, errorMessages);
                    //}
                    //else
                    //{
                    //    messageRepository.ClearErrorMessages(taxObject.ErrorMessages, Constants.TOPIC_PERSONAL_FILINGSTATUS, errorCode: Constants.TAXPAYER_FILING_STATUS);
                    //    //taxObject.ErrorMessages
                    //    if ((taxObject != null && taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null) && !(taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.Single || taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly))
                    //    {
                    //        taxObject.ErrorMessages.Add(errorMessages[Constants.TAXPAYER_FILING_STATUS]);
                    //    }

                    //}
                    if (taxObject != null)
                    {
                        //10Jul2014 Sathish checked is EIC eligible, if not eligible set EIC to null
                        //16Jul2014 Sathish called EIC eligibility check work flow with no validation
                        dynamic EICEligibilityCheck = new Microsoft.Activities.Extensions.WorkflowArguments();
                        EICEligibilityCheck.Tax1040Object = taxObject;
                        Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZEICEligibilityRuleCheckWithNoValidation(), EICEligibilityCheck));
                        Utilities.EICEligibilityCheck(taxObject);

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

                        //25Jun2014 Sathish primary tax payer return user data id and has eligibility but we user dataid assigned directly
                        Tuple<long, bool> primayTaxPayer = PersistPrimaryTaxPayer(personalDetails.PrimaryTaxPayer, userId, userDataId);
                        userDataId = primayTaxPayer.Item1;
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

                    //Saravanan N - 27th June, 2014 - Paymentvoucher (Form 1040V). Based on AddressType new property will be populated.
                    string addressForPDF = string.Empty;
                    string streetAddressForPDF = string.Empty;
                    string apartmentNumberForPDF = string.Empty;
                    string stateCode = string.Empty;
                    string countryCode = string.Empty;

                    if (address.AddressType == AddressType.ForeignAddress)
                    {
                        if (address.ForeignAddress != null)
                        {
                            addressForPDF = address.ForeignAddress.City;
                            streetAddressForPDF = address.ForeignAddress.StreetAddress;
                            apartmentNumberForPDF = address.ForeignAddress.ApartmentNumber;

                            //Saravanan N - 30th June, 2014 - GetCountry Code.
                            var lstCountry = GetAllCountry();
                            if (lstCountry != null)
                            {
                                // 01Jul2014 Sathish checked country id is zero before geting country code
                                // 09Jul2014 Sathsih checked country null references
                                if (address.ForeignAddress.Country != null && address.ForeignAddress.Country.CountryId != 0)
                                    countryCode = lstCountry.Where(country => country.CountryId == address.ForeignAddress.Country.CountryId).FirstOrDefault().CountryCode;
                            }
                        }
                    }
                    else if (address.AddressType == AddressType.PersonalAddress)
                    {
                        if (address.PersonalAddress != null)
                        {
                            //Saravanan N - 30th June, 2014 - GetState Code.
                            var lstState = GetAllState();
                            if (lstState != null)
                            {
                                // 01Jul2014 Sathish checked state id is zero before geting state code
                                // 09Jul2014 Sathsih checked state null references
                                if (address.PersonalAddress.State != null && address.PersonalAddress.State.StateId != 0)
                                    stateCode = lstState.Where(states => states.StateId == address.PersonalAddress.State.StateId).FirstOrDefault().StateCode;
                            }

                            addressForPDF = address.PersonalAddress.City +
                                (address.PersonalAddress.City.Trim().Length > 0 ? ", " : "") +
                                stateCode + ", " + address.PersonalAddress.ZipCode;
                            streetAddressForPDF = address.PersonalAddress.StreetAddress;
                            apartmentNumberForPDF = address.PersonalAddress.ApartmentNumber;
                        }
                    }

                    //Satevanan N - 30th June, 2014 - Persist the State and Country code into BO object.
                    address.StateCode = stateCode;
                    address.CountryCode = countryCode;

                    address.AddressForPdfOutput = addressForPDF;
                    address.StreetAddressForPdfOutput = streetAddressForPDF;
                    address.ApartmentNumberForPdfOutput = apartmentNumberForPDF;

                    PopulateAddresssIntoTaxObject(address, taxObject);
                    personalInfoDataService.PersistAddress(address, personId);

                    //Added by Ashok - To check Personal Info Eligibility on Address Persist also
                    //Invoking Eligibility rule Workflow
                    dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
                    input.Tax1040Object = taxObject;
                    input.ErrorMessages = errorMessages;
                    var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new PersonalInfoEligibilityRuleCheck(), input));

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
                        //10Jul2014 Sathish checked is EIC eligible, if not eligible set EIC to null
                        //16Jul2014 Sathish called EIC eligibility check work flow with no validation
                        dynamic EICEligibilityCheck = new Microsoft.Activities.Extensions.WorkflowArguments();
                        EICEligibilityCheck.Tax1040Object = taxObject;
                        Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZEICEligibilityRuleCheckWithNoValidation(), EICEligibilityCheck));
                        Utilities.EICEligibilityCheck(taxObject);

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
                //vivek 18-June-14 added by vivek fot the tax payer name
                var taxPayerName = Constants.TAXPAYER_DEFAULT_DISPAY_NAME;

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
            // Added by vivek on 5-June-14 to remove USA
            var countryResult = personalInfoDataService.GetAllCountry();
            countryResult = countryResult.Where(x => x.CountryCode != "USA").ToList();
            return countryResult;
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
                        //Praveen 17 July 2014 Error Message displayed based on Error Type(Properly Shuffled)
                        taxObjectErrorList = taxObject.ErrorMessages.FindAll(em => (em.Topic == Constants.TOPIC_PERSONAL_FILINGSTATUS) || (em.Topic == Constants.TOPIC_PERSONAL_PRIMARYFILER) || (em.Topic == Constants.TOPIC_PERSONAL_ADDRESS)).OrderBy(x => x.ErrorType).ToList();

                        if (taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly)
                        {
                            //Praveen 17 July 2014 Error Message displayed based on Error Type(Properly Shuffled)
                            taxObjectErrorList.AddRange(taxObject.ErrorMessages.FindAll(em => (em.Topic == Constants.TOPIC_PERSONAL_SPOUSE)).OrderBy(a => a.ErrorType).AsEnumerable());
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


        #region Delete SpouseInfo
        private bool DeleteSpouseInfo(long userId, long userDataId, Tax1040.BusinessObject.Tax1040 taxObject)
        {
            bool isSpouseDeleted = false;
            try
            {
                if (taxObject != null && taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null)
                {
                    UserDTO userDTO = new UserDTO();
                    userDTO.UserDataId = userDataId;
                    userDTO.UserId = userId;

                    if (taxObject.PersonalDetails.Spouse != null && taxObject.PersonalDetails.Spouse.Person != null)
                    {

                        personalInfoDataService.DeleteSpouseByPersonId(taxObject.PersonalDetails.Spouse.Person.PersonId);

                        taxObject.PersonalDetails.Spouse = null;
                        if (taxObject.ErrorMessages != null)
                        {
                            taxObject.ErrorMessages.RemoveAll(em => em.Topic.Equals(Constants.TOPIC_PERSONAL_SPOUSE));
                        }
                    }

                    if (taxObject.Income != null)
                    {
                        // W2 wages
                        if (taxObject.Income.W2Wages != null)
                        {
                            // Get all w2 wages assoicated to the spouse
                            List<W2> spouseWages = taxObject.Income.W2Wages.FindAll(wages => wages.OwnerType.Equals(OwnerType.Spouse));

                            IW2Repository w2Repository = new W2Repository();
                            // Delete each W2 wages associated to the spouse
                            foreach (var wages in spouseWages)
                            {
                                userDTO.FormId = wages.W2Id;
                                w2Repository.DeleteAndPersistW2(userDTO, taxObject);
                            }
                        }
                        // Intrest income
                        if (taxObject.Income.Form1099INT != null)
                        {
                            // Get all Intrest Income assoicated to the spouse
                            List<Form1099INT> spouseIntrestIncome = taxObject.Income.Form1099INT.FindAll(wages => wages.Owner.Equals(OwnerType.Spouse));

                            IInterestIncomeRepository interestIncomeRepository = new InterestIncomeRepository();

                            // Delete each all Intrest associated to the spouse
                            foreach (var intrestIncome in spouseIntrestIncome)
                            {
                                userDTO.FormId = intrestIncome.Form1099INTId;
                                interestIncomeRepository.DeleteAndPersist1099INT(userDTO, taxObject);
                            }

                            // Get all Intrest Income assoicated to the Joint
                            List<Form1099INT> jointIntrestIncome = taxObject.Income.Form1099INT.FindAll(wages => wages.Owner.Equals(OwnerType.Joint));
                            foreach (var intrestIncome in jointIntrestIncome)
                            {
                                // If intrest income is added for joint it will be changed single if filling status is updated from MFJ to Single
                                intrestIncome.Owner = OwnerType.PrimaryTaxPayer;
                            }
                        }

                        // OID
                        if (taxObject.Income.Form1099OID != null)
                        {
                            // Get all OID assoicated to the spouse
                            List<Form1099OID> spouseIntrestIncome = taxObject.Income.Form1099OID.FindAll(wages => wages.Owner.Equals(OwnerType.Spouse));

                            IInterestIncomeRepository interestIncomeRepository = new InterestIncomeRepository();

                            // Delete each all OID associated to the spouse
                            foreach (var intrestIncome in spouseIntrestIncome)
                            {
                                userDTO.FormId = intrestIncome.Form1099OIDId;
                                interestIncomeRepository.DeleteAndPersist1099OID(userDTO, taxObject);
                            }
                        }

                        // Unemployment 
                        if (taxObject.Income.Form1099G != null)
                        {
                            // Get all unemployment Income assoicated to the spouse
                            List<Form1099G> spouseUnemployment = taxObject.Income.Form1099G.FindAll(wages => wages.OwnerType.Equals(OwnerType.Spouse));

                            IUnemploymentRepository unemploymentRepository = new UnemploymentRepository();

                            // Delete each all unemployment associated to the spouse
                            foreach (var unemploymentIncome in spouseUnemployment)
                            {
                                userDTO.FormId = unemploymentIncome.Form1099GId;
                                unemploymentRepository.DeleteAndPersistUnemployment(userDTO, taxObject);
                            }
                        }

                        // Other Income
                        if (taxObject.Income.OtherIncome != null)
                        {
                            if (taxObject.Income.OtherIncome.AlaskaPermanentFundDividend != null)
                            {
                                taxObject.Income.OtherIncome.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend = null;
                            }
                            if (taxObject.Income.OtherIncome.SSB != null)
                            {
                                taxObject.Income.OtherIncome.SSB.SpouseFederalTaxWithheld = 0;
                                taxObject.Income.OtherIncome.SSB.SpouseNetBenefits = 0;
                            }
                            if (taxObject.Income.OtherIncome.RRB != null)
                            {
                                taxObject.Income.OtherIncome.RRB.SpouseFederalTaxWithheld = 0;
                                taxObject.Income.OtherIncome.RRB.SpouseNetBenefits = 0;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:W2Repository,Method Name:DeleteAndPersistW2", ex);
            }
            return isSpouseDeleted;
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
                //Required Entry #5
                //Vincent- 8/7/14- Added a required entry for Military
                if (personalDetails.PrimaryTaxPayer.Person.IsMilitary.HasValue && personalDetails.PrimaryTaxPayer.Person.IsMilitary.Value)
                {
                    //Required Entry #5
                    if ((personalDetails.PrimaryTaxPayer.Person.ServedInMilitary == ServedInMilitary.None))
                    {
                        errorMessage = errorMessages[Constants.TAXPAYER_HAS_SERVED_IN_MILITARY];

                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                    }

                    //Required Entry #6
                    if ((personalDetails.PrimaryTaxPayer.Person.ServedInMilitary == ServedInMilitary.OtherCombatZone))
                    {
                        errorMessage = BusinessValidationRepository.AssertIsNotNull(personalDetails.PrimaryTaxPayer.Person.DateOfDeployed,
                                                                      Constants.TAXPAYER_HAS_OTHER_COMBAT_ZONE,
                                                                      errorMessages);

                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                        //10Jul2014 Bala Code will be un comment after fixing the format issue
                        //if (personalDetails.PrimaryTaxPayer.Person.DateOfDeployed != null)
                        //{
                        //    errorMessage = BusinessValidationRepository.DateFormate(personalDetails.PrimaryTaxPayer.Person.DateOfDeployed,
                        //                                             Constants.TAX_PAYER_DATE_FORMATE,
                        //                                             errorMessages);

                        //    if (errorMessage != null)
                        //        errorMessageList.Add(errorMessage);
                        //}
                    }
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

                //Yogalakshmi - 11th June 2014 - Null check for Spouse live in another state.
                if (personalDetails.Spouse.HasLivedInAnotherState.HasValue && personalDetails.Spouse.HasLivedInAnotherState.Value
                    && personalDetails.Spouse.LivedInAnotherState != null
                    && personalDetails.Spouse.LivedInAnotherState.StateId == 0)
                {
                    errorMessage = BusinessValidationRepository.AssertGreaterThanZero(personalDetails.Spouse.LivedInAnotherState.StateId,
                                                                            Constants.SPOUSE_STATE_OF_RESIDENCE,
                                                                            errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                }
                if (personalDetails.Spouse.Person.IsDied.HasValue && personalDetails.Spouse.Person.IsDied.Value)
                {
                    errorMessage = BusinessValidationRepository.AssertIsNotNull(personalDetails.Spouse.Person.DateOfDeath,
                                                                                    Constants.SPOUSE_MISSING_DATE_OF_DEATH,
                                                                                    errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                }

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

                //Vincent- 8/7/14- Added a required entry for Military
                if (personalDetails.Spouse.Person.IsMilitary.HasValue && personalDetails.Spouse.Person.IsMilitary.Value)
                {
                    //Required Entry #5
                    if ((personalDetails.Spouse.Person.ServedInMilitary == ServedInMilitary.None))
                    {
                        errorMessage = errorMessages[Constants.SPOUSE_HAS_SERVED_IN_MILITARY];

                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    //Required Entry #6
                    if ((personalDetails.Spouse.Person.ServedInMilitary == ServedInMilitary.OtherCombatZone))
                    {
                        errorMessage = BusinessValidationRepository.AssertIsNotNull(personalDetails.Spouse.Person.DateOfDeployed,
                                                                      Constants.SPOUSE_HAS_OTHER_COMBAT_ZONE,
                                                                      errorMessages);

                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    //10Jul2014 Bala Code will be un comment after fixing the format issue
                    //if (personalDetails.Spouse.Person.DateOfDeployed != null)
                    //{
                    //    errorMessage = BusinessValidationRepository.DateFormate(personalDetails.Spouse.Person.DateOfDeployed,
                    //                                             Constants.SPOUSE_DATE_FORMATE,
                    //                                             errorMessages);

                    //    if (errorMessage != null)
                    //        errorMessageList.Add(errorMessage);
                    //}

                }
            }

            // Person Address Validation
            if (personalDetails != null && personalDetails.PrimaryTaxPayer != null &&
                personalDetails.PrimaryTaxPayer.Person != null &&
                personalDetails.PrimaryTaxPayer.Person.Address != null) // 09Jul2014 Sathsih checked personal address not null
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

                    //Validation #11 
                    //Vivek 9-july-14 Added for the apartment number Validation 
                    if (personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress != null && !Utilities.IsStringEmpty(personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.ApartmentNumber))
                    {
                    errorMessage =
                        BusinessValidationRepository.AssertIsAlphapetOrNumber(
                            personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.ApartmentNumber,
                            Constants.TAXPAYER_PERSONAL_ADDRESS_APARTMENT_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    }

                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(
                            personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.City,
                            Constants.TAXPAYER_PERSONAL_ADDRESS_MISSING_CITY, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(
                           personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.ZipCode,
                            Constants.TAXPAYER_PERSONAL_ADDRESS_MISSING_ZIP_CODE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    // 09Jul2014 Sathsih changed state id to state and checked null before validating state id 
                    errorMessage = BusinessValidationRepository.AssertIsNotNull(personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.State,
                                            Constants.TAXPAYER_PERSONAL_ADDRESS_MISSING_STATE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    else
                    {
                        errorMessage =
                            BusinessValidationRepository.AssertGreaterThanZero(
                                   personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.State.StateId,
                                Constants.TAXPAYER_PERSONAL_ADDRESS_MISSING_STATE, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(
                            personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.PhoneNumber,
                            Constants.TAXPAYER_ADDRESS_MISSING_PHONE_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.StreetAddress))
                    {

                        errorMessage =
                            BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(
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

                    if (!Utilities.IsStringEmpty(personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.ZipCode))
                    {
                        if (personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.State != null) //10Jul2014 Sathish changed to new state bo
                        {
                            //Modified by prasana made changes for validating zipcode in DB on 14.07.2014
                            bool isValidZipcodeForState = Utilities.ValidateZipCodeByStateId(
                                            personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.State.StateId,
                                    personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.ZipCode.Substring(0, 5));

                            errorMessage = BusinessValidationRepository.AssertIsTrue(isValidZipcodeForState,
                                    Constants.TAXPAYER_PERSONAL_ADDRESS_VALID_ZIP_CODE, errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }
                    }

                    //Added by thileep 28.05.14
                    //Changed by thileep 04.06.14
                    if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.PhoneNumber))
                    {
                        errorMessage =
                                 BusinessValidationRepository.AssertIsWithinPhoneNoRange(
                                     personalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.PhoneNumber, 12, 12,
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

                    //Addred by vivek
                    //07Jul2014 Sathish changed country id to country object and checked null
                    errorMessage = BusinessValidationRepository.AssertIsNotNull(
                       personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.Country,
                       Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_COUNTRY, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    else
                    {

                        //Added by vivek
                        errorMessage =
                           BusinessValidationRepository.AssertGreaterThanZero(
                                       personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.Country.CountryId,
                               Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_COUNTRY, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    if (personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress != null && !Utilities.IsStringEmpty(personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.ApartmentNumber))
                    {
                    //Validation #12
                    //Vivek 9-july-14 Added for the apartment number Validation 
                    errorMessage =
                       BusinessValidationRepository.AssertIsAlphapetOrNumber(
                           personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.ApartmentNumber,
                           Constants.TAXPAYER_FOREIGN_ADDRESS_APARTMENT_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);

                    }

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
                            BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(
                                personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.StreetAddress,
                                Constants.TAXPAYER_FOREIGN_ADDRESS_STREET_ALPHABET, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNullOrEmpty(
                            personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.PhoneNumber,
                            Constants.TAXPAYER_ADDRESS_MISSING_FOREIGN_PHONE_NUMBER, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);


                    //Changed by thileep 04.06.14
                    if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.PhoneNumber))
                    {
                        errorMessage =
                            BusinessValidationRepository.AssertIsWithinPhoneNoRange(
                                personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.PhoneNumber, 12, 12,
                                Constants.TAXPAYER_PERSONAL_ADDRESS_VALID_FOREIGN_PHONE_NUMBER, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    //Validation #18
                    //vivek 9-July-14 postal code validation
                    if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.PostalCode))
                    {
                        if (personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.PostalCode.Length > 3)
                        {
                            errorMessage =
                           BusinessValidationRepository.AssertIsNumbersLettersAndHyphen(
                               personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.PostalCode,
                               Constants.TAXPAYER_FOREIGN_ADDRESS_POSTAL_CODE, errorMessages);
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                            else
                            {  //Bala 16Jul2014, As discussed with BA, Code added to check Nine zeros for Postal code
                                var postalCode = Utilities.RemoveHiphen(personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.PostalCode);
                                postalCode = Utilities.RemoveUnderscore(postalCode);
                                postalCode = Utilities.RemoveOpenBracket(postalCode);
                                postalCode = Utilities.RemoveCloseBracket(postalCode);

                                if (postalCode == Constants.NineZeros)
                                {
                                    errorMessage = errorMessages[Constants.TAXPAYER_FOREIGN_ADDRESS_POSTAL_CODE];
                                    if (errorMessage != null)
                                        errorMessageList.Add(errorMessage);
                                }
                            }
                        }
                        else
                        {
                            errorMessage = errorMessages[Constants.TAXPAYER_FOREIGN_ADDRESS_POSTAL_CODE];
                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }

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

                    // 30-june-2014 - vivek Comment for the defect TAX1040-14081
                    //if (!string.IsNullOrEmpty(personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.PhoneNumber))
                    //{
                    //    errorMessage =
                    //        BusinessValidationRepository.AssertIsWithinPhoneNoRange(
                    //           personalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.PhoneNumber, 12, 12,
                    //            Constants.TAXPAYER_PERSONAL_ADDRESS_VALID_PHONE_NUMBER, errorMessages);
                    //    if (errorMessage != null)
                    //        errorMessageList.Add(errorMessage);
                    //}
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

                    errorMessage = BusinessValidationRepository.AssertIsNotNull(
                                    personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherState,
                                    Constants.TAXPAYER_ADDRESS_MISSING_LIVED_IN_ANOTHER_STATE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    else
                    {
                        errorMessage = BusinessValidationRepository.AssertGreaterThanZero(
                                personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherState.StateId,
                            Constants.TAXPAYER_ADDRESS_MISSING_LIVED_IN_ANOTHER_STATE, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }
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

                    // 09Jul2014 Sathsih changed LivedInAnotherState to LivedInAnotherState
                    if (personalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateId != 0
                        && personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherState != null
                         && personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherState.StateId != 0
                       && personalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateId == personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherState.StateId)
                    {
                        errorMessage =
                                            BusinessValidationRepository.AssertIsEqualToLongValue(
                                            personalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateId, personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherState.StateId,
                                            Constants.TAXPAYER_ADDRESS_SAMERESIDENT_NAME, errorMessages);

                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }

                    // 09Jul2014 Sathsih changed EarnedIncomeFromNonLivedStateId to EarnedIncomeFromNonLivedState
                    if (personalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateId != 0
                        && personalDetails.PrimaryTaxPayer.Person.Address.EarnedIncomeFromNonLivedState != null
                        && personalDetails.PrimaryTaxPayer.Person.Address.EarnedIncomeFromNonLivedState.StateId != 0
                       && personalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateId == personalDetails.PrimaryTaxPayer.Person.Address.EarnedIncomeFromNonLivedState.StateId)
                    {
                        errorMessage =
                                            BusinessValidationRepository.AssertIsEqualToLongValue(
                                      personalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateId, personalDetails.PrimaryTaxPayer.Person.Address.EarnedIncomeFromNonLivedState.StateId,
                                            Constants.TAXPAYER_ADDRESS_RESIDENTAND_NONRESIDENT, errorMessages);

                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }




                    if (personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateFrom.HasValue)
                    {
                        errorMessage =
                                             BusinessValidationRepository.AssertIsCurrentYear(
                                             personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateFrom.Value.Year,
                                             Constants.TAXPAYER_ADDRESS_FROMDATE_RESIDENT, errorMessages);

                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);

                    }

                    if (personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateTo.HasValue)
                    {
                        errorMessage =
                                             BusinessValidationRepository.AssertIsCurrentYear(
                                             personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateTo.Value.Year,
                                             Constants.TAXPAYER_ADDRESS_TODATE_RESIDENT, errorMessages);

                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }


                    if (personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateFrom.HasValue && personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateTo.HasValue)
                    {
                        if (personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateFrom.Value > personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateTo.Value)
                        {
                            errorMessage =
                          BusinessValidationRepository.AssertDateIsGreater(
                       personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateTo.Value,
                        personalDetails.PrimaryTaxPayer.Person.Address.LivedInAnotherStateFrom.Value,
                          Constants.TAXPAYER_ADDRESS_FROMDATE_TODATE_GREATER, errorMessages);

                            if (errorMessage != null)
                                errorMessageList.Add(errorMessage);
                        }
                    }
                }

                //Added by Swapnesh on 28 May

                // 09Jul2014 Sathsih changed HasEarnedIncomeFromNonLivedStateId to HasEarnedIncomeFromNonLivedState and checked null
                // Bala, 16Jul2014 added HasValue condition checking
                if (personalDetails.PrimaryTaxPayer.Person.Address.HasEarnedIncomeFromNonLivedState.HasValue && personalDetails.PrimaryTaxPayer.Person.Address.HasEarnedIncomeFromNonLivedState.Value)
                {

                    errorMessage =
                        BusinessValidationRepository.AssertIsNotNull(
                            personalDetails.PrimaryTaxPayer.Person.Address.EarnedIncomeFromNonLivedState,
                            Constants.TAXPAYER_ADDRESS_MISSING_EARNED_INCOME_STATE, errorMessages);
                    if (errorMessage != null)
                        errorMessageList.Add(errorMessage);
                    else
                    {
                        errorMessage =
                            BusinessValidationRepository.AssertGreaterThanZero(
                                        personalDetails.PrimaryTaxPayer.Person.Address.EarnedIncomeFromNonLivedState.StateId,
                                Constants.TAXPAYER_ADDRESS_MISSING_EARNED_INCOME_STATE, errorMessages);
                        if (errorMessage != null)
                            errorMessageList.Add(errorMessage);
                    }
                }

            }
        }


        #endregion

    }
}
