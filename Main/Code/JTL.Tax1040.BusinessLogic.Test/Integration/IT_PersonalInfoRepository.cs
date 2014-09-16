﻿/*
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
*/


using System;
using System.Linq;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
        private static IPersonalInfoRepository mPersonalInfoRepository;
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

        #region
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

        //[TestMethod()]
        //public void ElizibilityRuleDateOfDeathValidation()
        //{
        //    var userDatatId = 0L;
        //    //create new user.
        //    var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
        //    primaryTaxPayer.Person.DateOfDeath = new DateTime(07/07/2014);
        //    //Before persist
        //    Assert.AreEqual(0, primaryTaxPayer.Person.PersonId);

        //    //Before persist in tax object
        //    Assert.AreEqual(0, userDatatId);
        //    var topic = "PrimaryFiler";
        //    var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDatatId, topic);
        //    Assert.IsTrue(userData.Item2);
        //}
        #endregion 
    }
}
