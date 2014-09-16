using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JTL.Tax1040.BusinessLogic.Test.Integration
{
    [TestClass]
    public class IT_PaymentRepository
    {
        #region private local variables


        private static long mUserId;

        private static IPersonalInfoRepository mPersonalInfoRepository;
        private static IUserRepository mUserRepository;
        //private static IEarnedIncomeCreditRepository mEarnedIncomeCreditRepository;
        //private static ITaxReturnRepository mTaxReturnRepository;
        //private static IW2Repository mW2Repository;
        //private static IInterestIncomeRepository mInterestIncomeRepository;
        //private static IOtherIncomeRepository mOtherIncomeRepository;
        //private static IUnemploymentRepository mUnemploymentRepository;
        private static IPaymentRepository mPaymentRepository;

        private static TaxReturnData taxReturnData;
        private static BusinessObject.Tax1040 taxObject = new BusinessObject.Tax1040();
        private UserDTO userDTO;

        private long userDataId = 0L;
        private PaymentDTO paymentDTO;
        #endregion


        #region test initialize
        [TestInitialize()]
        public void TestInitialize()
        {
            paymentDTO = new PaymentDTO();
            userDTO = new UserDTO();
            mUserId = IT_UserRepository.PersistNewUser();
            //mW2Repository = new W2Repository();
            //mInterestIncomeRepository = new InterestIncomeRepository();
            mPersonalInfoRepository = new PersonalInfoRepository();
            mUserRepository = new UserRepository();
            mPaymentRepository = new PaymentRepository();
            //mEarnedIncomeCreditRepository = new EarnedIncomeCreditRepository();
            //mTaxReturnRepository = new TaxReturnRepository();
            //mOtherIncomeRepository = new OtherIncomeRepository();
            taxReturnData = new TaxReturnData();
            //mUnemploymentRepository = new UnemploymentRepository();
        }
        #endregion

        //[TestMethod]
        //public void BusinessValidationAfterPersist()
        //{

        //    var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.MarriedFilingJointly);

        //    var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);

        //    taxReturnData = mPersonalInfoRepository.GetPersonalDetailsByUserIdAndUserDataId(mUserId, expectedUserDataID.Item1);


        //}

        #region Required

        [TestMethod]
        public void RequiredForFristName()
        {
            //Required #1
            bool HasErrorCode = false;
            var primaryTaxPayer = CreateUser(FilingStatus.Single);
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);
            var result = mPersonalInfoRepository.GetPersonalDetailsByUserIdAndUserDataId(mUserId, userData.Item1);
            List<ErrorMessage> lsterrormsg = (result.Item2) as List<ErrorMessage>;
            HasErrorCode = lsterrormsg.Any(em => (em.ErrorCode == "PrimaryFiler_RF1"));
            Assert.IsTrue(HasErrorCode);
        }

        [TestMethod]
        public void RequiredForLastName()
        {
            //Required #2
            bool HasErrorCode = false;
            var primaryTaxPayer = CreateUser(FilingStatus.Single);
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);
            var result = mPersonalInfoRepository.GetPersonalDetailsByUserIdAndUserDataId(mUserId, userData.Item1);
            List<ErrorMessage> lsterrormsg = (result.Item2) as List<ErrorMessage>;
            HasErrorCode = lsterrormsg.Any(em => (em.ErrorCode == "PrimaryFiler_RF2"));
            Assert.IsTrue(HasErrorCode);
        }

        [TestMethod]
        public void RequiredForStreetAddress()
        {
            //Required #3
            bool HasErrorCode = false;
            var primaryTaxPayer = CreateUser(FilingStatus.Single);
            var userData = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var address = CreateAddress();
            var userDataID = mPersonalInfoRepository.PersistAddress(address, mUserId, userDataId);
            var result = mPersonalInfoRepository.GetPersonalDetailsByUserIdAndUserDataId(mUserId, userDataID);
            List<ErrorMessage> lsterrormsg = (result.Item2) as List<ErrorMessage>;
            HasErrorCode = lsterrormsg.Any(em => (em.ErrorCode == "Address_RF1"));
            Assert.IsTrue(HasErrorCode);
        }

        [TestMethod]
        public void RequiredForApartmentNumber()
        {
            //Required #4
        }

        [TestMethod]
        public void RequiredForCity()
        {
            bool HasErrorCode = false;
            var primaryTaxPayer = CreateUser(FilingStatus.Single);
            var userData = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var address = CreateAddress();
            var userDataID = mPersonalInfoRepository.PersistAddress(address, mUserId, userDataId);
            var result = mPersonalInfoRepository.GetPersonalDetailsByUserIdAndUserDataId(mUserId, userDataID);
            List<ErrorMessage> lsterrormsg = (result.Item2) as List<ErrorMessage>;
            HasErrorCode = lsterrormsg.Any(em => (em.ErrorCode == "Address_RF2"));
            Assert.IsTrue(HasErrorCode);
        }

        [TestMethod]
        public void RequiredForStateProvince()
        {
            bool HasErrorCode = false;
            var primaryTaxPayer = CreateUser(FilingStatus.Single);
            var userData = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var address = CreateAddress();
            var userDataID = mPersonalInfoRepository.PersistAddress(address, mUserId, userDataId);
            var result = mPersonalInfoRepository.GetPersonalDetailsByUserIdAndUserDataId(mUserId, userDataID);
            List<ErrorMessage> lsterrormsg = (result.Item2) as List<ErrorMessage>;
            HasErrorCode = lsterrormsg.Any(em => (em.ErrorCode == "Address_RF11"));
            Assert.IsTrue(HasErrorCode);
        }



        [TestMethod]
        public void RequiredForZipCode()
        {
            bool HasErrorCode = false;
            var primaryTaxPayer = CreateUser(FilingStatus.Single);
            var userData = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var address = CreateAddress();
            var userDataID = mPersonalInfoRepository.PersistAddress(address, mUserId, userDataId);
            var result = mPersonalInfoRepository.GetPersonalDetailsByUserIdAndUserDataId(mUserId, userDataID);
            List<ErrorMessage> lsterrormsg = (result.Item2) as List<ErrorMessage>;
            HasErrorCode = lsterrormsg.Any(em => (em.ErrorCode == "Address_RF4"));
            Assert.IsTrue(HasErrorCode);
        }



        [TestMethod]
        public void RequiredForPhoneNumber()
        {
            bool HasErrorCode = false;
            var primaryTaxPayer = CreateUser(FilingStatus.Single);
            var userData = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var address = CreateAddress();
            var userDataID = mPersonalInfoRepository.PersistAddress(address, mUserId, userDataId);
            var result = mPersonalInfoRepository.GetPersonalDetailsByUserIdAndUserDataId(mUserId, userDataID);
            List<ErrorMessage> lsterrormsg = (result.Item2) as List<ErrorMessage>;
            HasErrorCode = lsterrormsg.Any(em => (em.ErrorCode == "Address_RF15"));
            Assert.IsTrue(HasErrorCode);
        }



        [TestMethod]
        public void RequiredForCardType()
        {
            //Required #10

            bool HasErrorCode = false;
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.MarriedFilingJointly);

            var userDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);

            var CardDetail = CardDetails(CardType.None);

            // paymentDTO.Order=JsonConvert.DeserializeObject(CardDetail);

          //  var result = mPaymentRepository.PersistIRSPaymentOption(paymentDTO);
          
            
            // var primaryTaxPayer = CreateUser(FilingStatus.Single);
            // var userData = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            // var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);
            // paymentDTO.UserDataId=
            //var userDataID = mPaymentRepository.PersistIRSPaymentOption(
            //var result = mPersonalInfoRepository.GetPersonalDetailsByUserIdAndUserDataId(mUserId, userDataID);
            //List<ErrorMessage> lsterrormsg = (result.Item2) as List<ErrorMessage>;
            // HasErrorCode = lsterrormsg.Any(em => (em.ErrorCode == "Address_RF15"));
            // Assert.IsTrue(HasErrorCode);
        }



        public static PaymentDTO CardDetails(CardType cardType)
        {
            PaymentDTO paymentDTO = new PaymentDTO
            {

                Order = new Order
                {
                    BillingDetails = new BillingDetails
                    {
                        CreditCard = new CreditCard
                        {
                            CreditCardNo = "",
                            SecurityCodeNo = "",
                            ExpiryMonth = "",
                            ExpiryYear = ""
                        }

                    }
                }

            };
            cardType = CardType.None;
            return paymentDTO;
        }


        public static User PersistUser()
        {
            User user = new User
            {
                UserId = mUserId,
                Email = ""
            };
            return user;
        }


        #endregion


        #region Validation
        public void ValidationFirstName()
        {
            bool HasErrorCode = false;
            var primaryTaxPayer = CreateUser(FilingStatus.Single);
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);
            var result = mPersonalInfoRepository.GetPersonalDetailsByUserIdAndUserDataId(mUserId, userData.Item1);
            List<ErrorMessage> lsterrormsg = (result.Item2) as List<ErrorMessage>;
            HasErrorCode = lsterrormsg.Any(em => (em.ErrorCode == "PrimaryFiler_V1"));
            Assert.IsTrue(HasErrorCode);
        }
        #endregion


        public static Address CreateAddress()
        {
            var address = new Address()
            {

                //Vincent-30 July 2014- Commented the State form and state to condition
               // LivedInAnotherStateFrom = DateTime.Now,
               // LivedInAnotherStateTo = DateTime.Now,
                AddressType = AddressType.PersonalAddress,

                PersonalAddress = new PersonalAddress()
                {
                    StreetAddress = "",
                    ApartmentNumber = "",
                    City = "",

                    ZipCode = "",
                    PhoneNumber = ""
                },
                ForeignAddress = new ForeignAddress
                {
                    StateOrProvince = ""
                }

            };

            return address;
        }

        public static PrimaryTaxPayer CreateUser(FilingStatus filingStatus)
        {
            PrimaryTaxPayer primarytaxpayer = new PrimaryTaxPayer
            {
                Person = new Person
                {
                    FirstName = "",
                },
                FilingStatus = filingStatus
            };
            return primarytaxpayer;
        }
    }
}
