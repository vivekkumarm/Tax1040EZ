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
*/


using System;
using System.Linq;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        private static long mStateId;
        private static IPersonalInfoRepository mPersonalInfoRepository = new PersonalInfoRepository();
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

        #region Static Constructor
        static IT_PersonalInfo()
        {
           
        }
        #endregion

        #region Primary Tax Payer - Test methods
        /// <summary>
        /// Primary Tax Payer insert
        /// </summary>
        [TestMethod()]
        public void PrimaryTaxPayerInsertTest()
        {
            var userDatatId = 0L;
            //create new user.
            var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);

            //Before persist
            Assert.AreEqual(0, primaryTaxPayer.Person.PersonId);

            //Before persist in tax object
            Assert.AreEqual(0, userDatatId);

            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDatatId);

            //After Persist
            Assert.IsTrue(primaryTaxPayer.Person.PersonId > 0);

            //After Persist in tax object
            Assert.IsTrue(userData.Item1 > 0);
        }

        /// <summary>
        /// Primary Tax Payer Update
        /// </summary>
        [TestMethod()]
        public void PersonalInfoUpdateTest()
        {
            var userDatatId1 =0L;
            //create new user.
            var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);

            //Before persist
            Assert.AreEqual(0,primaryTaxPayer.Person.PersonId);

            //Before persist in tax object
            Assert.AreEqual(0, userDatatId1);
           
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDatatId1);
            userDatatId1=userData.Item1;

            //After Persist
            Assert.IsTrue(primaryTaxPayer.Person.PersonId > 0);

            //After Persist in tax object
            Assert.IsTrue(userDatatId1 > 0);

            var firstNameOld = primaryTaxPayer.Person.FirstName;
            var filingStatusOld = primaryTaxPayer.FilingStatus;

            //Update person first name.
            primaryTaxPayer.Person.FirstName = "first name modified";
            //Update primary tax payer filing status
            primaryTaxPayer.FilingStatus = FilingStatus.MarriedFilingJointly;

            //Update Primary tax payer
           userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDatatId1);

           var userDatatId2 = userData.Item1;
            //get personal info.
           var primaryTaxPayerNew = mPersonalInfoRepository.GetPrimaryTaxPayerByUserIdAndUserDataId(mUserId, userDatatId2);

           Assert.AreEqual(userDatatId1, userDatatId2);
           Assert.AreEqual(primaryTaxPayer.Person.FirstName,primaryTaxPayerNew.Person.FirstName);
           Assert.AreEqual(primaryTaxPayer.FilingStatus, primaryTaxPayerNew.FilingStatus);
        }
        #endregion

        #region Spouse - Test Methods
        /// <summary>
        /// Spouse insert
        /// </summary>
        [TestMethod()]
        public void SpouseInsertTest()
        {
            var userDataId = 0L;
            //create new spouse.
            var spouse = CreateSpouse();

            //Before persist
            Assert.AreEqual(0, spouse.Person.PersonId);

            //Before persist in tax object
            Assert.AreEqual(0, userDataId);

           var userData = mPersonalInfoRepository.PersistSpouse(spouse, mUserId, userDataId);

           userDataId = userData.Item1;
            //After Persist
            Assert.IsTrue(spouse.Person.PersonId > 0);

            //After Persist in tax object
            Assert.IsTrue(userDataId > 0);

        }

        /// <summary>
        /// Spouse Update
        /// </summary>
        [TestMethod()]
        public void SpouseUpdateTest()
        {
            //create new user.
            //var spouseOld = CreateAndPersistSpouse(mUserId);
            //Assert.IsTrue(spouseOld.Person.PersonId > 0);

            var userDataId1 = 0L;
            //create new spouse.
            var spouse1 = CreateSpouse();

            //Before persist
            Assert.AreEqual(0, spouse1.Person.PersonId);

            //Before persist in tax object
            Assert.AreEqual(0, userDataId1);

            var userData = mPersonalInfoRepository.PersistSpouse(spouse1, mUserId, userDataId1);
            userDataId1 = userData.Item1;

            //After Persist
            Assert.IsTrue(spouse1.Person.PersonId > 0);

            //After Persist in tax object
            Assert.IsTrue(userDataId1 > 0);

            //Update spouse nick name.
            spouse1.Person.NickName = "Nick name modified";
            spouse1.HasLivedInAnotherState = false;
            spouse1.LivedInAnotherState = new State() { StateId = 0 };

           userData = mPersonalInfoRepository.PersistSpouse(spouse1, mUserId, userDataId1);

           var userDataId2 = userData.Item1;

            //get personal info.
           var personalDetail = mPersonalInfoRepository.GetSpouseByUserIdAndUserDataId(mUserId, userDataId2);
           Spouse spouse2 = personalDetail.Spouse;

            Assert.AreEqual(userDataId1, userDataId2);
            Assert.AreEqual(spouse1.Person.NickName, spouse2.Person.NickName);
            Assert.AreEqual(spouse1.HasLivedInAnotherState, spouse2.HasLivedInAnotherState);
            Assert.AreEqual(spouse1.LivedInAnotherState.StateId, spouse2.LivedInAnotherState.StateId);
        }
        #endregion

        #region Address - Test Methods
        /// <summary>
        /// address and address history insert
        /// </summary>
        [TestMethod()]
        public void AddressInsertTest()
        {
            var userDataId = 0L;

            //create new user.
            var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);

            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);

            userDataId = userData.Item1;
            //create new address.
            var address = CreatePersonalAddressDetails();

            //Before persist.
            Assert.AreEqual(0, address.AddressId);

            userDataId = mPersonalInfoRepository.PersistAddress(address, mUserId, userDataId);

            //After persist.
            Assert.IsTrue(address.AddressId > 0);
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
            var userDatatId = 0L;
            //create new user.
            var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);

            //Before persist
            Assert.AreEqual(0, primaryTaxPayer.Person.PersonId);

            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDatatId);

            userDatatId = userData.Item1;

            //After Persist
            Assert.IsTrue(primaryTaxPayer.Person.PersonId > 0);

           var personId = mPersonalInfoRepository.GetPersonIdByUserIdAndUserDataId(mUserId, userDatatId);

           Assert.AreEqual(primaryTaxPayer.Person.PersonId, personId);

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

            var address = new Address()
            {
                LivedInAnotherState = new State()
                {
                    StateId = mStateId
                },
                EarnedIncomeFromNonLivedState = new State()
                {
                    StateId = mStateId,
                },
                LivedInAnotherStateFrom = DateTime.Now,
                LivedInAnotherStateTo = DateTime.Now,
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
    }
}
