/*
copyright                   : copyright jeevan technologies
file name                   : IT_PersonalInfoRepository.cs
description                 : personal info bl integration test.
author                      : saravanan n.
created date                : 14 march 2014
 
modification history:
---------------------
 * saravanan n. - 19th mar, 2014 -  code refactored and created static method for createandpersistpersonalinfo() to access from other unit test classes.
 * saravanan n. - 27th mar, 2014 - As the PersistXXX method name changes, the corresponding changes done here.
 * Sathish N - 7 April 2014 Changed code in CreateAndPersistPersonalAddressDetails to send state
 * Bala - 15 April 2014 Added and modified methods for integration test.
 * Sathish N - 17 April 2014 Changed zip code value to string to long.
 * Bala - 14 May 2014 Modified methods for integration test.
 * Vincent- 3 Sept 2014- Worked on required field validation  for spouse and taxpayer and Address
 * Vincent- 3 Sept 2014- Worked on Business rule validation for addresss.
 * Vincent- 3 Sept 2014- Worked on eligibility rule for primary filer and spouse.
 * vincent- 4 Sept 2014- Worked on Validation for Spouse, taxpayer and address.  
*/


using System;
using System.Linq;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JTL.Tax1040.Core.Process;
using System.Web;

namespace JTL.Tax1040.BusinessLogic.Test
{
    /// <summary>
    /// Test Classs - For PersonInfoReporsitory BL methods.
    /// </summary>
    [TestClass()]
    public class IT_PersonalInfo
    {
        #region private local variables
        private static long mUserId;
        private static long mUserDataId;
        private static long mStateId;
        private static long mCountryId;
        private static IPersonalInfoRepository mPersonalInfoRepository;
        private static IMessagesRepository mMessagesRepository;
        #endregion

        #region test initialize
        [TestInitialize()]
        public void TestInitialize()
        {
            mPersonalInfoRepository = new PersonalInfoRepository();
            //Get State. Use it all over the Test methods.
            mStateId = mPersonalInfoRepository.GetAllState().First().StateId;
            //Get UserId. Use it all over the Test methods.
            mUserId = IT_UserRepository.PersistNewUser();
            mCountryId = mPersonalInfoRepository.GetAllCountry().First().CountryId;

            mMessagesRepository = new MessagesRepository();
            HttpRuntime.Cache["ErrorMessageCollection"] = mMessagesRepository.GetErrorMessages();
        }
        #endregion

        #region Primary Tax Payer - Test methods
        /// <summary>
        /// Primary Tax Payer insert
        /// </summary>
        [TestMethod()]
        public void PrimaryTaxPayerInsertTest()
        {
            //create new user.
            var expectedPrimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            var actualUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedPrimaryTaxPayer, mUserId, mUserDataId);
            PrimaryTaxPayer actualPrimaryTaxPayer = mPersonalInfoRepository.GetPrimaryTaxPayerByUserIdAndUserDataId(mUserId,actualUserData.Item1);
            ValidatePrimaryTaxPayerAfterPersist(expectedPrimaryTaxPayer, actualPrimaryTaxPayer);
        }

        /// <summary>
        /// Primary Tax Payer Update
        /// </summary>
        [TestMethod()]
        public void PersonalInfoUpdateTest()
        {
            //create new user.
            var expectedprimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedprimaryTaxPayer, mUserId, mUserDataId);

            //Update person object values
            expectedprimaryTaxPayer.Person.FirstName = "first name modified";
            expectedprimaryTaxPayer.FilingStatus = FilingStatus.MarriedFilingJointly;

            //Update Primary tax payer
            var actualUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedprimaryTaxPayer, mUserId, expectedUserData.Item1);

            var actualPrimayTaxPayer = mPersonalInfoRepository.GetPrimaryTaxPayerByUserIdAndUserDataId(mUserId, actualUserData.Item1);

            Assert.AreEqual(expectedUserData.Item1, actualUserData.Item1);
            ValidatePrimaryTaxPayerAfterPersist(expectedprimaryTaxPayer, actualPrimayTaxPayer);
        }
        #endregion

        #region Spouse - Test Methods
        /// <summary>
        /// Spouse insert
        /// </summary>
        [TestMethod()]
        public void SpouseInsertTest()
        {
            //create new spouse.
            var expectedSpouse = CreateSpouse();
            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);
            Spouse actualSpouse = mPersonalInfoRepository.GetSpouseByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            ValidateSpouseAfterPersist(expectedSpouse, actualSpouse);
        }

        /// <summary>
        /// Spouse Update
        /// </summary>
        [TestMethod()]
        public void SpouseUpdateTest()
        {
            var expectedSpouse = CreateSpouse();
            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            //Update spouse nick name.
            expectedSpouse.Person.NickName = "Nick name modified";
            expectedSpouse.HasLivedInAnotherState = false;
            expectedSpouse.LivedInAnotherState = new State() { StateId = 0 };

            var actualUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, expectedUserData.Item1);

            //get personal info.
           Spouse actualSpouse = mPersonalInfoRepository.GetSpouseByUserIdAndUserDataId(mUserId, actualUserData.Item1);
           Assert.AreEqual(expectedUserData.Item1, actualUserData.Item1);
           ValidateSpouseAfterPersist(expectedSpouse,actualSpouse);
            
        }
        #endregion

        #region Address - Test Methods
        /// <summary>
        /// address and address history insert
        /// </summary>
        [TestMethod()]
        public void AddressInsertTest()
        {
            //create new user and Address
            var givenPrimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(givenPrimaryTaxPayer, mUserId, mUserDataId);
            var expectedAddress = CreatePersonalAddressDetails();

            //Persist Address object
            var actualUserDataId = mPersonalInfoRepository.PersistAddress(expectedAddress, mUserId, userData.Item1);

            var address = mPersonalInfoRepository.GetAddressByUserIdAndUserDataId(mUserId, actualUserDataId);
            var actualAddress = (Address) address;
            Assert.AreEqual(expectedAddress.PersonalAddress.StreetAddress, actualAddress.PersonalAddress.StreetAddress);
            Assert.AreEqual(expectedAddress.PersonalAddress.ApartmentNumber,actualAddress.PersonalAddress.ApartmentNumber);
            Assert.AreEqual(expectedAddress.PersonalAddress.ZipCode,actualAddress.PersonalAddress.ZipCode);
            Assert.AreEqual(expectedAddress.PersonalAddress.City,actualAddress.PersonalAddress.City);
            Assert.AreEqual(expectedAddress.PersonalAddress.PhoneNumber,actualAddress.PersonalAddress.PhoneNumber);
            Assert.AreEqual(expectedAddress.PersonalAddress.State.StateId,actualAddress.PersonalAddress.State.StateId);
        }

        /// <summary>
        /// address update and address history insert
        /// </summary>
        [TestMethod()]
        public void AddressUpdateTest()
        {
            var userDataId1 = 0L;

            //create new user.
           var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
           var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId1);

           userDataId1 = userData.Item1;

            //create new address.
            var address1 = CreatePersonalAddressDetails();

            //Before persist.
            Assert.AreEqual(0, address1.AddressId);

            userDataId1 = mPersonalInfoRepository.PersistAddress(address1, mUserId, userDataId1);

            //After persist.
            Assert.IsTrue(address1.AddressId > 0);

            //Edit and persist address
            address1.PersonalAddress.StreetAddress = "address line 1 modified";
            address1.PersonalAddress.PhoneNumber = "43210";

           var userDataId2 = mPersonalInfoRepository.PersistAddress(address1, mUserId, userDataId1);
           var addressDetail = mPersonalInfoRepository.GetAddressByUserIdAndUserDataId(mUserId, userDataId2);

           Assert.AreEqual(userDataId1, userDataId2);
           Assert.AreEqual(address1.PersonalAddress.StreetAddress, addressDetail.Address.PersonalAddress.StreetAddress);
           Assert.AreEqual(address1.PersonalAddress.PhoneNumber, addressDetail.Address.PersonalAddress.PhoneNumber);
           Assert.AreEqual(primaryTaxPayer.FilingStatus, addressDetail.FilingStatus);
        }
        #endregion

        #region Get All - Test methods
        /// <summary>
        /// Get all state
        /// </summary>
        [TestMethod()]
        public void GetStateTest()
        {
            var statelist = mPersonalInfoRepository.GetAllState();
            Assert.IsTrue(statelist.Count > 0);
            Assert.AreEqual(mStateId, statelist.First().StateId);
        }

        /// <summary>
        /// Get all country.
        /// </summary>
        [TestMethod()]
        public void GetCountryTest()
        {
            var countrylist = mPersonalInfoRepository.GetAllCountry();
            Assert.IsTrue(countrylist.Count > 0);
        }
        #endregion

        #region Get - Test Methods

         /// <summary>
         /// Get the person id by userid and user data id.
         /// </summary>
        [TestMethod()]
        public void GetPersonIdTest()
        {
            var givenprimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(givenprimaryTaxPayer, mUserId, mUserDataId);
            var actualPersonId = mPersonalInfoRepository.GetPersonIdByUserIdAndUserDataId(mUserId, expectedUserData.Item1);

            Assert.AreEqual(givenprimaryTaxPayer.Person.PersonId, actualPersonId);

        }

        /// <summary>
        /// Get the person from DB and Tax object.
        /// </summary>
        [TestMethod()]
        public void GetPersonByPersonIdTest()
        {
            var userDataId = 0L;
            //create new user.
            var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);

            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);

            userDataId = userData.Item1;
            //create new address.
            var address = CreatePersonalAddressDetails();

            userDataId = mPersonalInfoRepository.PersistAddress(address, mUserId, userDataId);


            //Get person details from DB
            var primaryTaxPayer1 = mPersonalInfoRepository.GetPersonByPersonId(primaryTaxPayer.Person.PersonId);

            //Get person details from Tax1040 object
            var primaryTaxPayer2 = mPersonalInfoRepository.GetPrimaryTaxPayerByUserIdAndUserDataId(mUserId, userDataId);

            Assert.AreEqual(primaryTaxPayer1.FilingStatus, primaryTaxPayer2.FilingStatus);
            Assert.AreEqual(primaryTaxPayer1.Person.PersonId, primaryTaxPayer2.Person.PersonId);
            Assert.AreEqual(primaryTaxPayer1.Person.PersonType, primaryTaxPayer2.Person.PersonType);
            Assert.AreEqual(primaryTaxPayer1.Person.SSN, primaryTaxPayer2.Person.SSN);
            Assert.AreEqual(primaryTaxPayer1.Person.NickName, primaryTaxPayer2.Person.NickName);

        }
        
        #endregion

        #region Required field validationn for TaxPayer

        //RF #1

        /// <summary>
        /// Requireds the first name of the feild .
        /// </summary>
        [TestMethod]
        public void RequiredFeildFirstName ()
        {

            var expectedPrimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            expectedPrimaryTaxPayer.Person.FirstName = string.Empty;
            expectedPrimaryTaxPayer.Person.LastName = string.Empty;

            var expectedUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedPrimaryTaxPayer, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_MISSING_FIRST_NAME)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_MISSING_LAST_NAME)));
        }

        /// <summary>
        /// Requireds the last name of the feild.
        /// </summary>
        /// RF#2
        [TestMethod]
        public void RequiredFeildLastName()
        {
            var expectedPrimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            expectedPrimaryTaxPayer.Person.LastName = string.Empty;
            var expectedUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedPrimaryTaxPayer, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_MISSING_LAST_NAME)));
            
        }

        /// <summary>
        /// Requireds the feild date of birth.
        /// </summary>
        /// RF #3
        [TestMethod]
        public void RequiredFeildDateOfBirth()
        {
            var expectedPrimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            //If date of birth is empty we will set a mininum value 
            var dateTime = new DateTime(1899, 12, 31);
            expectedPrimaryTaxPayer.Person.DateOfBirth = dateTime;

            var expectedUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedPrimaryTaxPayer, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_MISSING_DATE_OF_BIRTH)));

        }

        /// <summary>
        /// Requireds the feild SSN.
        /// </summary>
        /// RF #4
        [TestMethod]
        public void RequiredFeildSSN()
        {
            var expectedPrimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            expectedPrimaryTaxPayer.Person.SSN = string.Empty;
            var expectedUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedPrimaryTaxPayer, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_MISSING_SSN)));
        }

        /// <summary>
        /// Requireds the feild date of death.
        /// </summary>
        /// RF #5
        [TestMethod]
        public void RequiredFeildDateOfDeath()
        {
            var expectedPrimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            expectedPrimaryTaxPayer.Person.IsDied = true;
            expectedPrimaryTaxPayer.Person.DateOfDeath = null;
            var expectedUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedPrimaryTaxPayer, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_MISSING_DATE_OF_DEATH)));
        }


        /// <summary>
        /// Requireds the feild served in military.
        /// </summary>
        /// RF #6
        [TestMethod]
        public void RequiredFeildServedInMilitary()
        {
            var expectedPrimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            expectedPrimaryTaxPayer.Person.IsMilitary = true;
            expectedPrimaryTaxPayer.Person.ServedInMilitary = ServedInMilitary.None;

            var expectedUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedPrimaryTaxPayer, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_HAS_SERVED_IN_MILITARY)));
        }

        /// <summary>
        /// Requireds the feild date of deployed.
        /// </summary>
        /// RF #7
        [TestMethod]
        public void RequiredFeildDateOfDeployed()
        {
            var expectedPrimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            expectedPrimaryTaxPayer.Person.IsMilitary = true;
            expectedPrimaryTaxPayer.Person.ServedInMilitary = ServedInMilitary.OtherCombatZone;
            expectedPrimaryTaxPayer.Person.DateOfDeployed = null;

            var expectedUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedPrimaryTaxPayer, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_HAS_OTHER_COMBAT_ZONE)));
        }


        #endregion

        #region Required field validation for Spouse
        /// <summary>
        /// Spouses Required field validation for first name.
        /// </summary>
        /// RF#1 
        [TestMethod()]
        public void SpouseRequiredFieldForFirstName()
        {
            var expectedSpouse = CreateSpouse();
            expectedSpouse.Person.FirstName = string.Empty;
            
            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_MISSING_FIRST_NAME)));
            
        }

        /// <summary>
        /// Spouses the last name of the required field.
        /// </summary>
        /// RF#2
        [TestMethod()]
        public void SpouseRequiredFieldForLastName()
        {
            var expectedSpouse = CreateSpouse();
            expectedSpouse.Person.LastName = string.Empty;

            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_MISSING_LAST_NAME)));
        }

        /// <summary>
        /// Spouses the required field for SSN.
        /// </summary>
        /// Rf#3
        [TestMethod()]
        public void SpouseRequiredFieldForSSN()
        {
            var expectedSpouse = CreateSpouse();
            expectedSpouse.Person.SSN = string.Empty;
            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_MISSING_SSN)));
        }

        /// <summary>
        /// Spouses the required field for date of birth.
        /// </summary>
        [TestMethod()]
        public void SpouseRequiredFieldForDateOfBirth()
        {
            var expectedSpouse = CreateSpouse();
            //If date of birth is empty we will set a mininum value 
            var dateTime = new DateTime(1899, 12, 31);
            expectedSpouse.Person.DateOfBirth = dateTime;
            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_MISSING_DATE_OF_BIRTH)));
        }


        /// <summary>
        /// Spouses Lived in another state.
        /// </summary>
        /// RF #5
        [TestMethod()]
        public void SpouseRequiredFieldForLivedInAnotherState()
        {
            var expectedSpouse = CreateSpouse();
            expectedSpouse.HasLivedInAnotherState = true;
            expectedSpouse.LivedInAnotherState.StateId = 0;

            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_STATE_OF_RESIDENCE)));
        }

        /// <summary>
        /// Spouses Required field validation for Date of death.
        /// </summary>
        /// RF #6
        [TestMethod()]
        public void SpouseRequiredFieldForDateOfDeath()
        {
            var expectedSpouse = CreateSpouse();
            expectedSpouse.Person.IsDied = true;
            expectedSpouse.Person.DateOfDeath = null;

            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_MISSING_DATE_OF_DEATH)));
        }

        /// <summary>
        /// Spouses required field for Missing Military Served.
        /// </summary>
        [TestMethod()]
        public void SpouseRequiredFieldForMilitaryServed()
        {
            var expectedSpouse = CreateSpouse();
            expectedSpouse.Person.IsMilitary = true;
            expectedSpouse.Person.ServedInMilitary = ServedInMilitary.None;

            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_HAS_SERVED_IN_MILITARY)));
        }


        /// <summary>
        /// Spouses required field for date of deployment .
        /// </summary>
        [TestMethod()]
        public void SpouseRequiredFieldDateOfDeployment()
        {
            var expectedSpouse = CreateSpouse();
            expectedSpouse.Person.IsMilitary = true;
            expectedSpouse.Person.ServedInMilitary = ServedInMilitary.OtherCombatZone;
            expectedSpouse.Person.DateOfDeployed = null;

            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_HAS_OTHER_COMBAT_ZONE)));
        }
        #endregion

        #region Required field Validation For Address
        /// <summary>
        /// Address required field for Street Address,City,State,Zip Code and Phone number.
        /// </summary>
        [TestMethod()]
        public void AddressRequiredFieldRF1RF2RF3RF4RF15()
        {
            var address = CreatePersonalAddressDetails();
            address.AddressType = AddressType.PersonalAddress;
            address.PersonalAddress.State.StateId = 0;
            address.PersonalAddress.ZipCode = string.Empty;
            address.PersonalAddress.StreetAddress = string.Empty;
            address.PersonalAddress.City = string.Empty;
            address.PersonalAddress.PhoneNumber = string.Empty;
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_PERSONAL_ADDRESS_MISSING_STREET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_PERSONAL_ADDRESS_MISSING_CITY)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_PERSONAL_ADDRESS_MISSING_STATE)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_PERSONAL_ADDRESS_MISSING_ZIP_CODE)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_MISSING_PHONE_NUMBER)));
        }

        /// <summary>
        /// Address required field for Street Address,City,State or province,Country Name,Postal Code and Phone number.
        /// </summary>
        [TestMethod()]
        public void AddressRequiredFieldRF5RF6RF7RF8RF9RF16()
        {
            var address = CreatePersonalAddressDetails();
            address.AddressType = AddressType.ForeignAddress;
            address.ForeignAddress.City = string.Empty;
            address.ForeignAddress.StreetAddress = string.Empty;
            address.ForeignAddress.StateOrProvince = string.Empty;
            address.ForeignAddress.PostalCode = string.Empty;
            address.ForeignAddress.Country.CountryId = 0;
            address.ForeignAddress.PhoneNumber = string.Empty;
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_STREET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_CITY)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_STATE)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_POSTAL_CODE)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_COUNTRY)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_MISSING_FOREIGN_PHONE_NUMBER)));

        }

        /// <summary>
        /// Address required field Residence state.
        /// </summary>
        [TestMethod()]
        public void AddressRequiredFieldRF10()
        {
            var address = CreatePersonalAddressDetails();
            address.ResidenceState.StateId = 0;
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_FOREIGN_ADDRESS_MISSING_RESIDENT_STATE)));
        }

        /// <summary>
        /// Address required field BR11.
        /// </summary>
        [TestMethod()]
        public void AddressRequiredFieldRF11()
        {
            var address = CreatePersonalAddressDetails();
            address.HasLivedInMoreThanOneState = true;
            address.LivedInAnotherStates = new List<State>
            {
                new State{
                    StateId=0
                },
            
            };
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_MISSING_LIVED_IN_ANOTHER_STATE)));   
            
        }

        /// <summary>
        /// Address required field for RF14.
        /// </summary>
        [TestMethod()]
        public void AddressRequiredFieldRF14()
        {
            var address = CreatePersonalAddressDetails();
            address.HasEarnedIncomeFromNonLivedState = true;
            address.EarnedIncomeFromNonLivedStates = new List<State>
            {
                new State{
                    StateId=0
                },
            
            };
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_MISSING_EARNED_INCOME_STATE)));
        }

        #endregion

        #region Business Rules

        /// <summary>
        /// Address the business rules BR1.
        /// </summary>
        [TestMethod()]
        public void AddressBusinessRulesBR1()
        {
            var address = CreatePersonalAddressDetails();
            address.AddressType = AddressType.PersonalAddress;
            address.PersonalAddress.State.StateId = 52;//Armed Forces Americas
            address.PersonalAddress.ZipCode="65412";
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_ARMED_FORCES_AMERICAS)));
        }

        /// <summary>
        /// Address the business rules BR2.
        /// </summary>
        [TestMethod()]
        public void AddressBusinessRulesBR2()
        {
            var address = CreatePersonalAddressDetails();
            address.AddressType = AddressType.PersonalAddress;
            address.PersonalAddress.State.StateId = 53;//Armed Forces Africa 
            address.PersonalAddress.ZipCode = "65412";
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_SELECTED_STATE_NAME)));

        }

        /// <summary>
        /// Address the business rules BR3.
        /// </summary>
        [TestMethod()]
        public void AddressBusinessRulesBR3()
        {
            var address = CreatePersonalAddressDetails();
            address.AddressType = AddressType.PersonalAddress;
            address.PersonalAddress.State.StateId = 57;//Armed Forces Pacific
            address.PersonalAddress.ZipCode = "78645";
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_ARMED_FORCES_PACIFIC)));

        }

        /// <summary>
        /// Address the business rules BR4.
        /// </summary>
        [TestMethod()]
        public void AddressBusinessRulesBR4()
        {
            var address = CreatePersonalAddressDetails();
            address.AddressType = AddressType.PersonalAddress;
            address.PersonalAddress.State.StateId = 55;//Armed Forces Europe
            address.PersonalAddress.City = "wow";
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_ENTERED_CITY_NAME)));

        }

        /// <summary>
        /// Address the business rules BR5.
        /// </summary>
        [TestMethod()]
        public void AddressBusinessRulesBR5()
        {
            var address = CreatePersonalAddressDetails();
            address.AddressType = AddressType.PersonalAddress;
            address.PersonalAddress.City = "wo";
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_ENTERED_CITY_NAME_LENGTH)));
        }

        /// <summary>
        /// Address the business rules BR6.
        /// </summary>
        [TestMethod()]
        public void AddressBusinessRulesBR6()
        {
            var address = CreatePersonalAddressDetails();
            address.AddressType = AddressType.ForeignAddress;
            address.ForeignAddress.City = "wo";
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_ENTERED_ANOTHER_CITY_NAME_LENGTH)));
        }


        #endregion

        #region static methods
        /// <summary>
        /// Create and Persist PrimaryTaxPayer.
        /// </summary>
        /// <param name="userId">The user Id</param>
        /// <param name="filingStatus">The filing status</param>
        /// <returns></returns>
        public static PrimaryTaxPayer CreateAndPersistPrimaryTaxPayer(long userId, FilingStatus filingStatus,ref long userDataId)
        {
           var primaryTaxPayer = CreatePrimaryTaxPayer(filingStatus);

           var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);

           userDataId = userData.Item1;
                       
            return primaryTaxPayer;
        }

        /// <summary>
        ///  Create PrimaryTaxPayer.
        /// </summary>
        /// <param name="filingStatus">The filing status</param>
        /// <returns></returns>
        public static PrimaryTaxPayer CreatePrimaryTaxPayer(FilingStatus filingStatus)
        {
            var randomValue = Guid.NewGuid().ToString().Substring(0, 5);
            Random randomSecurityQuestionID = new Random();
            var year = randomSecurityQuestionID.Next(-30, -20);
            var primaryTaxPayer = new PrimaryTaxPayer
            {
                Person = new Person
                {
                    PersonId = 0,
                    FirstName = "first name" + randomValue,
                    MiddleInitial = 'M',
                    LastName = "last name" + randomValue,
                    NickName = "nick name" + randomValue,
                    Occupation = "occupation",
                    DateOfBirth = DateTime.Now.AddYears(year),
                    SSN = "ssn001",
                    PersonType = PersonType.PrimaryTaxPayer,
                    HasPrimaryFilerEcfContributed = false,
                    HasSpouseEcfContributed = false,
                    IsLegallyBlind = false,
                    IsDisabled = false,
                    HasClaimedAsDependent = false,
                    IsDied = false,
                    DateOfDeath = DateTime.Now,
                    IsStudent = false,
                    IsFullTimeStudent = false
                    //IsOtherInfoNone = false,
                },
                FilingStatus = filingStatus
            };

            //TODO: Has to be checked. Saravanan N. 

            return primaryTaxPayer;
        }

        /// <summary>
        /// Create and Persist Spouse. 
        /// </summary>
        /// <returns></returns>
        public static Spouse CreateAndPersistSpouse(long userId,long userDataId = 0)
        {
           var spouse = CreateSpouse();
           mPersonalInfoRepository.PersistSpouse(spouse, userId, userDataId); 
           return spouse;
        }

        /// <summary>
        /// Create and Persist Spouse. 
        /// </summary>
        /// <returns></returns>
        public static Spouse CreateSpouse()
        {
            var spouse = new Spouse
            {
                Person = new Person
                {
                    PersonId = 0,
                    FirstName = "first name",
                    MiddleInitial = 'M',
                    LastName = "last name",
                    NickName = "nick name",
                    Occupation = "occupation",
                    DateOfBirth = DateTime.Now.AddYears(-18),
                    SSN = "ssn001",
                    PersonType = PersonType.Spouse,
                    HasPrimaryFilerEcfContributed = false,
                    HasSpouseEcfContributed = false,
                    IsLegallyBlind = false,
                    IsDisabled = false,
                    HasClaimedAsDependent = false,
                    IsDied = false,
                    DateOfDeath = DateTime.Now,
                    IsStudent = false,
                    IsFullTimeStudent = false
                    //IsOtherInfoNone = false,
                },
                HasLivedInAnotherState = true,
                LivedInAnotherState = new State()
                {
                    StateId = mStateId
                }
            };

            return spouse;
        }
       
        /// <summary>
        /// Create and Persist Address.
        /// </summary>
        /// <returns></returns>
        public static Address CreateAndPersistPersonalAddressDetails(long userId,long userDataId=0)
        {

            var address = CreatePersonalAddressDetails();

            mPersonalInfoRepository.PersistAddress(address, userId, userDataId);
            return address;
        }

        public static Address CreatePersonalAddressDetails()
        {
            var livedInAnotherStates = new List<State>();
            var state = new State()
                {
                    StateId = mStateId
                };

                livedInAnotherStates.Add(state);

                var nonLivedStates = new List<State>();
                state = new State()
                {
                    StateId = mStateId
                };

                nonLivedStates.Add(state);

                var address = new Address()
                {
                    LivedInAnotherStates = livedInAnotherStates,
                    EarnedIncomeFromNonLivedStates = nonLivedStates,
                    AddressType = AddressType.PersonalAddress,
                    ResidenceState = new State()
                    {
                        StateId = mStateId
                    },
                    PersonalAddress = new PersonalAddress()
                    {
                        StreetAddress = "Street Address",
                        ApartmentNumber = "12/2",
                        City = "Test city",
                        State = new State()
                        {
                            StateId = mStateId
                        },
                        ZipCode = "123456",
                        PhoneNumber = "123456"
                    },
                    ForeignAddress = new ForeignAddress()
                    {
                        StreetAddress = "David son street",
                        ApartmentNumber = "12/2",
                        City = "Test City",
                        PostalCode = "600012",
                        PhoneNumber = "9840702356",
                        Country = new Country() 
                        {
                            CountryId = mCountryId
                        }
                    }
                };
            
            return address;
        }

        private static void ValidatePrimaryTaxPayerAfterPersist(PrimaryTaxPayer expectedPrimaryTaxPayer,
            PrimaryTaxPayer actualPrimaryTaxPayer)
        {
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.FirstName, actualPrimaryTaxPayer.Person.FirstName);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.LastName, actualPrimaryTaxPayer.Person.LastName);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.MiddleInitial, actualPrimaryTaxPayer.Person.MiddleInitial);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.NickName, actualPrimaryTaxPayer.Person.NickName);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.Occupation, actualPrimaryTaxPayer.Person.Occupation);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.DateOfBirth, actualPrimaryTaxPayer.Person.DateOfBirth);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.SSN, actualPrimaryTaxPayer.Person.SSN);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.PersonType, actualPrimaryTaxPayer.Person.PersonType);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.HasPrimaryFilerEcfContributed,
                actualPrimaryTaxPayer.Person.HasPrimaryFilerEcfContributed);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.HasSpouseEcfContributed,
                actualPrimaryTaxPayer.Person.HasSpouseEcfContributed);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.IsLegallyBlind, actualPrimaryTaxPayer.Person.IsLegallyBlind);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.IsDisabled, actualPrimaryTaxPayer.Person.IsDisabled);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.HasClaimedAsDependent,
                actualPrimaryTaxPayer.Person.HasClaimedAsDependent);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.IsDied, actualPrimaryTaxPayer.Person.IsDied);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.DateOfDeath, actualPrimaryTaxPayer.Person.DateOfDeath);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.IsStudent, actualPrimaryTaxPayer.Person.IsStudent);
            Assert.AreEqual(expectedPrimaryTaxPayer.Person.IsFullTimeStudent, actualPrimaryTaxPayer.Person.IsFullTimeStudent);
            Assert.IsTrue(actualPrimaryTaxPayer.Person.PersonId > 0);
            
        }

        private void ValidateSpouseAfterPersist(Spouse expectedSpouse, Spouse actualSpouse)
        {
            Assert.AreEqual(expectedSpouse.Person.FirstName, actualSpouse.Person.FirstName);
            Assert.AreEqual(expectedSpouse.Person.LastName, actualSpouse.Person.LastName);
            Assert.AreEqual(expectedSpouse.Person.MiddleInitial, actualSpouse.Person.MiddleInitial);
            Assert.AreEqual(expectedSpouse.Person.NickName, actualSpouse.Person.NickName);
            Assert.AreEqual(expectedSpouse.Person.Occupation, actualSpouse.Person.Occupation);
            Assert.AreEqual(expectedSpouse.Person.DateOfBirth, actualSpouse.Person.DateOfBirth);
            Assert.AreEqual(expectedSpouse.Person.SSN, actualSpouse.Person.SSN);
            Assert.AreEqual(expectedSpouse.Person.PersonType, actualSpouse.Person.PersonType);
            Assert.AreEqual(expectedSpouse.Person.HasPrimaryFilerEcfContributed,
                actualSpouse.Person.HasPrimaryFilerEcfContributed);
            Assert.AreEqual(expectedSpouse.Person.HasSpouseEcfContributed,
                actualSpouse.Person.HasSpouseEcfContributed);
            Assert.AreEqual(expectedSpouse.Person.IsLegallyBlind, actualSpouse.Person.IsLegallyBlind);
            Assert.AreEqual(expectedSpouse.Person.IsDisabled, actualSpouse.Person.IsDisabled);
            Assert.AreEqual(expectedSpouse.Person.HasClaimedAsDependent,
                actualSpouse.Person.HasClaimedAsDependent);
            Assert.AreEqual(expectedSpouse.Person.IsDied, actualSpouse.Person.IsDied);
            Assert.AreEqual(expectedSpouse.Person.DateOfDeath, actualSpouse.Person.DateOfDeath);
            Assert.AreEqual(expectedSpouse.Person.IsStudent, actualSpouse.Person.IsStudent);
            Assert.AreEqual(expectedSpouse.Person.IsFullTimeStudent, actualSpouse.Person.IsFullTimeStudent);
            Assert.IsTrue(actualSpouse.Person.PersonId > 0);
        }
        //TODO: Has to be discussed, from where it has to fetch data (DB / TaxObject). After that it will be corrected. - Saravanan N. 27th Mar, 2014
        /// <summary>
        /// Get PrimaryTaxPayer by PersonId.
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        //public static PrimaryTaxPayer GetPersonByPersonId(long personId)
        //{
        //    return mPersonalInfoRepository.GetPersonByPersonId(personId);
        //}
        #endregion

        #region Elizibility
        [TestMethod()]
        public void ElizibilityRuleFilingStatusValidation()
        {
            var userDatatId = 0L;
            //create new user.
            var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Widower);
            //Before persist
            Assert.AreEqual(0, primaryTaxPayer.Person.PersonId);

            //Before persist in tax object
            Assert.AreEqual(0, userDatatId);
            var topic = "FilingStatus";
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDatatId, topic);
            Assert.IsTrue(userData.Item2);
        }

        [TestMethod()]
        public void ElizibilityRuleAgeValidation()
        {
            var userDatatId = 0L;
            //create new user.
            var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            primaryTaxPayer.Person.DateOfBirth = DateTime.Now.AddYears(-70);
            //Before persist
            Assert.AreEqual(0, primaryTaxPayer.Person.PersonId);

            //Before persist in tax object
            Assert.AreEqual(0, userDatatId);
            var topic = "PrimaryFiler";
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDatatId,topic);
            Assert.IsTrue(userData.Item2);
        }

        [TestMethod()]
        public void ElizibilityRuleForBlindValidation()
        {
            var userDatatId = 0L;
            //create new user.
            var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            primaryTaxPayer.Person.IsLegallyBlind = true;
            //Before persist
            Assert.AreEqual(0, primaryTaxPayer.Person.PersonId);

            //Before persist in tax object
            Assert.AreEqual(0, userDatatId);
            var topic = "PrimaryFiler";
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDatatId,topic);
            Assert.IsTrue(userData.Item2);
        }

        [TestMethod()]
        public void ElizibilityRuleAgeValidationForSpouse()
        {
            var userDatatId = 0L;
            //create new user.
            var spouse = CreateSpouse();
            spouse.Person.DateOfBirth = DateTime.Now.AddYears(-70);
            //Before persist
            Assert.AreEqual(0, spouse.Person.PersonId);

            //Before persist in tax object
            Assert.AreEqual(0, userDatatId);
            var userData = mPersonalInfoRepository.PersistSpouse(spouse, mUserId, userDatatId);
            Assert.IsTrue(userData.Item2);
        }

        [TestMethod()]
        public void ElizibilityRuleForBlindValidationForSpouse()
        {
            var userDatatId = 0L;
            //create new user.
            var spouse = CreateSpouse();
            spouse.Person.IsLegallyBlind = true;
            //Before persist
            Assert.AreEqual(0, spouse.Person.PersonId);

            //Before persist in tax object
            Assert.AreEqual(0, userDatatId);
            var userData = mPersonalInfoRepository.PersistSpouse(spouse, mUserId, userDatatId);
            Assert.IsTrue(userData.Item2);
        }

        [TestMethod()]
        public void ElizibilityRuleDateOfDeathValidationForTaxpayer()
        {
            var userDatatId = 0L;
            //create new user.
            var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            primaryTaxPayer.Person.IsDied = true;

            var dateofDeath=new DateTime(2014, 08, 20);
            primaryTaxPayer.Person.DateOfDeath = dateofDeath;
            //Before persist
            Assert.AreEqual(0, primaryTaxPayer.Person.PersonId);

            //Before persist in tax object
            Assert.AreEqual(0, userDatatId);
            var topic = "PrimaryFiler";
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDatatId, topic);
            Assert.IsTrue(userData.Item2);
        }

        [TestMethod()]
        public void ElizibilityRuleDateOfDeathValidationForSpouse()
        {
            var userDatatId = 0L;
            //create new user.
            var spouse = CreateSpouse();
            spouse.Person.IsDied = true;
            var dateofDeath=new DateTime(2014, 08, 20);
            spouse.Person.DateOfDeath = dateofDeath;
            //Before persist
            Assert.AreEqual(0, spouse.Person.PersonId);

            //Before persist in tax object
            Assert.AreEqual(0, userDatatId);
            var userData = mPersonalInfoRepository.PersistSpouse(spouse, mUserId, userDatatId);
            Assert.IsTrue(userData.Item2);

        }
        #endregion 

        #region validation


        #region validation for Taxpayer
        /// <summary>
        /// Validation for the first name,Last Name,middle name,nick name and occupation for a non alphabetic.
        /// </summary>
        /// V #1 ,V2,V3,V4,V5
        [TestMethod()]
        public void ValidationForPersonalnonAlphabetic()
        {
            var expectedPrimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            expectedPrimaryTaxPayer.Person.FirstName = "david@fg";
            expectedPrimaryTaxPayer.Person.LastName = "san$don";
            expectedPrimaryTaxPayer.Person.MiddleInitial = '2';
            expectedPrimaryTaxPayer.Person.NickName="shawn007";
            expectedPrimaryTaxPayer.Person.Occupation="tank business23";

            var expectedUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedPrimaryTaxPayer, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_FIRST_NAME_ALPHABET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_LAST_NAME_ALPHABET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_MIDDLE_NAME_ALPHABET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_NICK_NAME_ALPHABET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_OCCUPATION_NAME_ALPHABET)));
        }

        /// <summary>
        /// Validations for no alphabetic in SSN and missing value in Occupation.
        /// </summary>
        /// V6 and V7
        [TestMethod()]
        public void ValidationForPersonalNoAlphabetic()
        {
            var expectedPrimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            expectedPrimaryTaxPayer.Person.Occupation = string.Empty;
            expectedPrimaryTaxPayer.Person.SSN = "405-23-er45";

            var expectedUserData = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedPrimaryTaxPayer, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_MISSING_OCCUPATION_NAME)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_INVALID_SSN)));

        }


        #endregion

        #region validation for Spouse
        /// <summary>
        /// Validations the spouse section as non alphabetic for first name, last name,middle name,invalid snn and occupation.
        /// </summary>
        /// v1,v2,v3,v4,v5
        [TestMethod()]
        public void ValidationForSpousenonAlphabetic()
        {
            var expectedSpouse = CreateSpouse();
            //If date of birth is empty we will set a mininum value 
            var dateTime = new DateTime(1899, 12, 31);
            expectedSpouse.Person.FirstName = "test@123";
            expectedSpouse.Person.LastName = "test@123";
            expectedSpouse.Person.SSN = "405-23-er45";
            expectedSpouse.Person.Occupation= "test@12";
            expectedSpouse.Person.MiddleInitial = '3';
            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_FIRST_NAME_ALPHABET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_LAST_NAME_ALPHABET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_MIDDLE_NAME_ALPHABET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_INVALID_SSN)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_OCCUPATION_NAME_ALPHABET)));
        }

        /// <summary>
        /// Validations for spouse missing occupation.
        /// </summary>
        /// V6
        [TestMethod()]
        public void ValidationForSpouseMissingOccupation()
        {
            var expectedSpouse = CreateSpouse();
            expectedSpouse.Person.Occupation = string.Empty;
            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_MISSING_OCCUPATION_NAME)));
        }

        /// <summary>
        /// Validations for spouse date of birth.
        /// </summary>
        /// V8
        [TestMethod()]
        public void ValidationForSpouseDateOfBirth()
        {
            var expectedSpouse = CreateSpouse();
            var dateOfBirth=new DateTime(2014, 10, 1);
            expectedSpouse.Person.DateOfBirth = dateOfBirth;
            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_DATE_OF_BIRTH_GREATER_THAT_TAX_YEAR)));
        }
        /// <summary>
        /// Validations for spouse same SSN.
        /// </summary>
        [TestMethod()]
        public void ValidationForSpouseSameSSN()
        {
            //Taxpayer
            var expectedPrimaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            expectedPrimaryTaxPayer.Person.SSN = "405-23-1234";
            var expectedUserDataTaxpayer = mPersonalInfoRepository.PersistPrimaryTaxPayer(expectedPrimaryTaxPayer, mUserId, mUserDataId);
            //Spouse
            var expectedSpouse = CreateSpouse();
            expectedSpouse.Person.SSN = "405-23-1234";
            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, expectedUserDataTaxpayer.Item1);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedUserData.Item1);
            Assert.IsTrue(expectedUserData.Item1 > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_TAXPAYER_SSN_SAME)));
        }
        /// <summary>
        /// Validations spouse state name and address state name should not be same if spouse lived in another state.
        /// </summary>
        [TestMethod()]
        public void ValidationForSpouseSameStateName()
        {
            //Spouse
            var expectedSpouse = CreateSpouse();
            expectedSpouse.HasLivedInAnotherState = true;
            expectedSpouse.LivedInAnotherState.StateId = mStateId;
            var expectedUserData = mPersonalInfoRepository.PersistSpouse(expectedSpouse, mUserId, mUserDataId);

            //Address
            var address = CreatePersonalAddressDetails();
            address.PersonalAddress.State.StateId = mStateId;
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, expectedUserData.Item1);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.SPOUSE_TAXPAYER_RESIDENT_STATE_SAME)));
        }



        #endregion

        #region validation for Address

        /// <summary>
        /// Validations for address non alphabetic in Personal Address section.
        /// </summary>
        [TestMethod()]
        public void ValidationForAddressnonAlphabeticPersonalAddress()
        {
            var address = CreatePersonalAddressDetails();
            address.AddressType = AddressType.PersonalAddress;
            address.PersonalAddress.City = "yahoo#";
            address.PersonalAddress.StreetAddress = "david@#$";
            address.PersonalAddress.ZipCode = "123";
            address.PersonalAddress.PhoneNumber = "123-44";
            address.PersonalAddress.ApartmentNumber = "12@";
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_PERSONAL_ADDRESS_STREET_ALPHABET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_PERSONAL_ADDRESS_CITY_ALPHABET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_PERSONAL_ADDRESS_VALID_ZIP_CODE)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_PERSONAL_ADDRESS_VALID_PHONE_NUMBER)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_PERSONAL_ADDRESS_APARTMENT_NUMBER)));
        }

        /// <summary>
        /// Validations for address non alphabetic in foreign address Section.
        /// </summary>
        [TestMethod()]
        public void ValidationForAddressnonAlphabeticForeignAddress()
        {
            var address = CreatePersonalAddressDetails();
            address.AddressType = AddressType.ForeignAddress;
            address.ForeignAddress.City = "dfdb#$";
            address.ForeignAddress.StreetAddress = "ashfj@#";
            address.ForeignAddress.StateOrProvince = "sam@#";
            address.ForeignAddress.PostalCode = "12";
            address.ForeignAddress.ApartmentNumber = "12@";
            address.ForeignAddress.PhoneNumber = "00000000000000000000";
            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_FOREIGN_ADDRESS_STREET_ALPHABET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_FOREIGN_ADDRESS_CITY_ALPHABET)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_FOREIGN_ADDRESS_STATE_OR_PROVINCE)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_FOREIGN_ADDRESS_APARTMENT_NUMBER)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_PERSONAL_ADDRESS_VALID_FOREIGN_PHONE_NUMBER)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_FOREIGN_ADDRESS_POSTAL_CODE)));

        }

        /// <summary>
        /// Validations for address same state name.
        /// </summary>
        [TestMethod()]
        public void ValidationForAddressSameStatename()
        {
            var address = CreatePersonalAddressDetails();
            address.ResidenceState.StateId = mStateId;
            address.HasLivedInMoreThanOneState = true;
            address.LivedInAnotherStates = new List<State>
            {
                new State{
                StateId=mStateId
                },

            };
            address.HasEarnedIncomeFromNonLivedState = true;
            address.EarnedIncomeFromNonLivedStates = new List<State> 
            {
                new State{
                StateId=mStateId
                },
            };


            var actualUserData = mPersonalInfoRepository.PersistAddress(address, mUserId, mUserDataId);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualUserData);
            Assert.IsTrue(actualUserData > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_SAMERESIDENT_NAME)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_RESIDENTAND_NONRESIDENT)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.TAXPAYER_ADDRESS_NONRESIDENT_PARTYEARRESIDENT_SAME)));


        }

        #endregion


        #endregion
    }
}
