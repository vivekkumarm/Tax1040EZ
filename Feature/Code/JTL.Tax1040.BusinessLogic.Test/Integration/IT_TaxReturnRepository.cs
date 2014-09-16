/*
Copyright   : Copyright Jeevan Technologies
File Name   : ITaxReturnDataService.cs 
Description : Business Logic for Tax Return  
Author      : Ashok Kumar
Created Date : 18 Mar 2014

 * Modification History:
 * Swapnesh on 23-july-2014
---------------------
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using System.Collections.Generic;
using System.Linq;



namespace JTL.Tax1040.BusinessLogic.Test
{
    /// <summary>
    /// Test class for Tax Return Data
    /// </summary>
    [TestClass]
    public class IC_TaxReturnRepository
    {
        ITaxReturnRepository mTaxReturnRepository;
        IT_PersonalInfo mITPersonalInfoRepository;
        static IPersonalInfoRepository mPersonalInfoRepository;
        private static long mStateId;
        long userId = 0;

        /// <summary>
        /// Classes the initialize.
        /// </summary>
        /// <param name="test">The test.</param>
        [ClassInitialize]
        public static void ClassInitialize(TestContext test)
        {

        }

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mTaxReturnRepository = new TaxReturnRepository();
            mPersonalInfoRepository = new PersonalInfoRepository();
            userId = IT_UserRepository.PersistNewUser();
        }

        /// <summary>
        /// Persist session data in TaxObject.
        /// </summary>
        [TestMethod]
        public void PersistSessionData()
        {
            var userDataId = 0L;

            // for getting UserDataId
            BusinessObject.Tax1040 tax1040 = new BusinessObject.Tax1040();
            tax1040.UserDataId = 0;

            long userDataID = Utilities.PersistTaxObject(userId, userDataId, tax1040);

            string sessionData = "http://192.168.1.10:1040/";

            mTaxReturnRepository.PersistSessionData(userId, userDataID, sessionData);

            UserDTO userDTO = new UserDTO();
            userDTO.UserDataId = userDataID;
            userDTO.UserId = userId;

            string result = mTaxReturnRepository.GetSessionDatabyUserIdAndUserDataId(userDTO);
            Assert.AreEqual(sessionData, result);

        }

        /// <summary>
        /// Gets the tax return databy user data identifier.
        /// </summary>
        [TestMethod]
        public void GetTaxReturnDatabyUserDataId()
        {

            var userDataId = 0L;

            // for getting UserDataId
            BusinessObject.Tax1040 tax1040 = new BusinessObject.Tax1040();
            tax1040 = CreateTaxObject();

            // persist taobject with filled Person data
            long userDataID = Utilities.PersistTaxObject(userId, userDataId, tax1040);
            string taxData = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(userDataID, userId);
            var resultaxobject = Utilities.ConvertJsonToTaxObject(taxData);

            // check whether person object is saved and retrieved
            Assert.AreEqual(resultaxobject.PersonalDetails.PrimaryTaxPayer.Person.SSN, tax1040.PersonalDetails.PrimaryTaxPayer.Person.SSN);
            Assert.AreEqual(resultaxobject.Income.Form1099INT[0].AccountNumber, tax1040.Income.Form1099INT[0].AccountNumber);
            Assert.AreEqual(resultaxobject.Income.Form1099OID[0].AccountNumber, tax1040.Income.Form1099OID[0].AccountNumber);
        }


        /// <summary>
        ///Gets the SessionData by UserId and UserDataId.
        /// </summary>
        [TestMethod]
        public void GetSessionDatabyUserIdAndUserDataId()
        {
            var userDataId = 0L;

            // for getting UserDataId
            BusinessObject.Tax1040 tax1040 = new BusinessObject.Tax1040();
            tax1040.UserDataId = 0;

            userDataId = Utilities.PersistTaxObject(userId, userDataId, tax1040);

            UserDTO userDTO = new UserDTO();
            userDTO.UserDataId = userDataId;
            userDTO.UserId = userId;

            string sessionData = "http://192.168.1.10:1040/";

            mTaxReturnRepository.PersistSessionData(userId, userDataId, sessionData);


            string taxdata = mTaxReturnRepository.GetSessionDatabyUserIdAndUserDataId(userDTO);


            Assert.AreEqual(sessionData, taxdata);
        }


        /// <summary>
        ///Gets the SessionData by UserId and UserDataId.
        /// </summary>
        [TestMethod]
        public void GetUserDataIdByUserId()
        {
            var userDataId = 0L;

            // creating   UserDataId   by calling PersistTaxObject
            BusinessObject.Tax1040 tax1040 = new BusinessObject.Tax1040();
            tax1040.UserDataId = 0;
            userDataId = Utilities.PersistTaxObject(userId, userDataId, tax1040);
            long useedataresult = mTaxReturnRepository.GetUserDataIdByUserId(userId);

            // getting UserDataId by calling GetUserDataIdByUserId
            Assert.AreEqual(userDataId, useedataresult);
        }

        /// <summary>
        ///Gets the IncomeSummary by UserId and UserDataId.
        /// </summary>
        [TestMethod]
        public void GetIncomeSummaryWithOutData()
        {
            var userDataId = 0L;

            // creating   UserDataId   by calling PersistTaxObject
            BusinessObject.Tax1040 tax1040 = new BusinessObject.Tax1040();
            tax1040.UserDataId = 0;
            userDataId = Utilities.PersistTaxObject(userId, userDataId, tax1040);
            var result = mTaxReturnRepository.GetIncomeSummary(userId, userDataId);
            Assert.AreEqual(0, result.Item1);
        }


        /// <summary>
        ///Gets the IncomeSummary by UserId and UserDataId.
        /// </summary>
        [TestMethod]
        public void GetIncomeSummaryWithData()
        {
         //   var userDataId = 0L;

        //    userDataId = Utilities.PersistTaxObject(userId, userDataId, CreateTaxObject());

            var result = mTaxReturnRepository.GetIncomeSummary(1, 1);

            // wage amount
            Assert.AreNotEqual(0, result.Item1);
            // interest income amount
            Assert.AreNotEqual(0, result.Item2);
        }


        /// <summary>
        ///Gets the IncomeSummary by UserId and UserDataId.
        /// </summary>
        [TestMethod]
        public void GetFederalSummaryDetailsWithoutData()
        {
            var userDataId = 0L;

            // creating   UserDataId   by calling PersistTaxObject
            BusinessObject.Tax1040 tax1040 = new BusinessObject.Tax1040();
            tax1040.UserDataId = 0;
            
            userDataId = Utilities.PersistTaxObject(userId, userDataId, tax1040);

            UserDTO userDTO = new UserDTO();
            userDTO.UserDataId = userDataId;
            userDTO.UserId = userId;

            var result = mTaxReturnRepository.GetFederalSummaryDetails(userDTO);

            // result will be 0 since no data is passed
            Assert.AreEqual(0, result);
        }

        /// <summary>
        ///Gets the IncomeSummary by UserId and UserDataId.
        /// </summary>
        [TestMethod]
        public void GetFederalSummaryDetailsWithData()
        {
            var userDataId = 0L;

            userDataId = Utilities.PersistTaxObject(userId, userDataId, CreateTaxObject());

            UserDTO userDTO = new UserDTO();
            userDTO.UserDataId = userDataId;
            userDTO.UserId = userId;

            var result = mTaxReturnRepository.GetFederalSummaryDetails(userDTO);

            // RefundAmount  or  TaxOweAmount
            Assert.AreNotEqual(0, result);
        }


        /// <summary>
        /// order Exist or not
        /// </summary>
        [TestMethod]
        public void IsOrderExistByUserDataId()
        {
            var userDataId = 0L;

            userDataId = Utilities.PersistTaxObject(userId, userDataId, CreateTaxObject());

            PaymentDTO paymentDTO = new PaymentDTO();
            paymentDTO.UserDataId = userDataId;
            paymentDTO.UserId = userId;
            var result = mTaxReturnRepository.IsOrderExistByUserDataId(paymentDTO);

        }

        /// <summary>
        /// Persist User Rating
        /// </summary>
        /// <param name="userDTO"></param>
        /// <param name="userRating"></param>
        [TestMethod]
        public void PersistUserRating()
        {
            var userDataId = 0L;

            // creating   UserDataId   by calling PersistTaxObject
            BusinessObject.Tax1040 tax1040 = new BusinessObject.Tax1040();
            tax1040.UserDataId = 0;
            userDataId = Utilities.PersistTaxObject(userId, userDataId, tax1040);

            UserDTO userDTO = new UserDTO();
            userDTO.UserDataId = userDataId;
            userDTO.UserId = userId;

            UserRating userrating = new UserRating();
            userrating.Rating = 4;
            userrating.Comment = "good";

            mTaxReturnRepository.PersistUserRating(userDTO, userrating);
        }

        /// <summary>
        /// Get User Rating
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>       
        [TestMethod]
        public void GetUserRating()
        {
            var userDataId = 0L;

            // creating   UserDataId   by calling PersistTaxObject
            BusinessObject.Tax1040 tax1040 = new BusinessObject.Tax1040();
            tax1040.UserDataId = 0;
            userDataId = Utilities.PersistTaxObject(userId, userDataId, tax1040);

            UserDTO userDTO = new UserDTO();
            userDTO.UserDataId = userDataId;
            userDTO.UserId = userId;

            UserRating userrating = new UserRating();
            userrating.Rating = 4;
            userrating.Comment = "good";

            mTaxReturnRepository.PersistUserRating(userDTO, userrating);


            var result = mTaxReturnRepository.GetUserRating(userDTO);

            Assert.AreEqual(userrating.Rating, result.Rating);
            Assert.AreEqual(userrating.Comment, result.Comment);
        }

        /// <summary>
        /// Get User Rating
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>       
        [TestMethod]
        public void PersistUserReferral()
        {
            var userDataId = 0L;

            // creating   UserDataId   by calling PersistTaxObject
            BusinessObject.Tax1040 tax1040 = new BusinessObject.Tax1040();
            tax1040.UserDataId = 0;
            userDataId = Utilities.PersistTaxObject(userId, userDataId, tax1040);

            UserDTO userDTO = new UserDTO();
            userDTO.UserDataId = userDataId;
            userDTO.UserId = userId;

            ReferralRating ReferralRating = new BusinessObject.ReferralRating();
            UserRating userrating = new UserRating();
            userrating.Rating = 4;
            userrating.Comment = "good";

            ReferralRating.UserRating = userrating;

            ReferralRating.UserReferral = new List<UserReferral>();

            UserReferral userreferral = new UserReferral();
            userreferral.ReferralEmailId = "ss@ss.com";
            UserReferral userreferral1 = new UserReferral();
            userreferral1.ReferralEmailId = "ss1@ss1.com";

            ReferralRating.UserReferral.Add(userreferral);
            ReferralRating.UserReferral.Add(userreferral1);


            mTaxReturnRepository.PersistUserReferral(userDTO, ReferralRating);


        }


        public static BusinessObject.Tax1040 CreateTaxObject()
        {
            BusinessObject.Tax1040 tax1040 = new BusinessObject.Tax1040();
            tax1040.UserDataId = 0;

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
                },
                FilingStatus = FilingStatus.Single
            };

            if (tax1040.PersonalDetails == null)
            {
                tax1040.PersonalDetails = new PersonalDetails()
                {
                    PrimaryTaxPayer = new PrimaryTaxPayer()
                    {
                        FilingStatus = FilingStatus.Single
                    }
                };

            }

            tax1040.PersonalDetails.PrimaryTaxPayer = primaryTaxPayer;

            tax1040.Income = new Income();

            tax1040.Income.Form1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);
            tax1040.Income.Form1099OID = CreateForm1099OID();
            tax1040.Income.W2Wages = CreateW2();

            return tax1040;
        }


        public static List<Form1099OID> CreateForm1099OID()
        {

            List<Form1099OID> lstForm1099OID = new List<Form1099OID>();
            Form1099OID form1099OID = new Form1099OID()
            {
                Payer = new Payer()
                {
                    PayerName = "Un employment Payer Name" + Utilities.CreateRandomNumber(0, 5),
                    PayerIdentificationNumber = Convert.ToString(Utilities.CreateRandomNumber(0, 5)),
                    Address = new Address()
                    {
                        AddressType = AddressType.TaxPayerAddress,
                        PayerAddress = new PayerAddress()
                        {
                            City = "Payer City",
                            StreetAddress = "Payer Street Address",
                            ZipCode = Convert.ToString(Utilities.CreateRandomNumber(0, 5)),
                            State = new State()
                            {
                                StateId = Utilities.CreateRandomNumber(0, 20)
                            }
                        }
                    }
                },
                AccountNumber = Convert.ToString(Utilities.CreateRandomNumber(0, 20)),
                OriginalIssueDiscount = Utilities.CreateRandomNumber(0, 20),
                OtherPeriodicInterest = Utilities.CreateRandomNumber(0, 20),
                EarlyWithdrawalPenalty = Utilities.CreateRandomNumber(0, 20),
                IncomeMarketDiscount = Utilities.CreateRandomNumber(0, 20),
                ForeignTaxPaid = Utilities.CreateRandomNumber(0, 20),
                ForeignCountryId = Utilities.CreateRandomNumber(0, 20),
                IsMutualFundRegulatedInvestment = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                USTreasuryObligations = Utilities.CreateRandomNumber(0, 20),
                InvestmentExpenses = Utilities.CreateRandomNumber(0, 20),
                IsStateInformationAvailable = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                InterestReceivedAsNominee = Utilities.CreateRandomNumber(0, 20),
                AdjustmentAmount = Utilities.CreateRandomNumber(0, 20),
                TaxableInterestAmount = Utilities.CreateRandomNumber(0, 20),
                FederalTaxWithHoldingAmount = Utilities.CreateRandomNumber(0, 20),
                Description = "Description" + Convert.ToString(Utilities.CreateRandomNumber(0, 20)),
                AcquisitionPremium = Utilities.CreateRandomNumber(0, 20),
                HasToReportTaxExempt = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                HasToReportAdjustment = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                TaxExemptInterestState = new State()
                {
                    StateId = mStateId
                },
                //TODO
                //StateExemptInterest = Utilities.CreateRandomNumber(0, 20),
                Owner = (OwnerType)Utilities.CreateRandomNumber(1, 2),
                TaxExemptInterest = Utilities.CreateRandomNumber(0, 1),
            };

            form1099OID.Form1099StateInfo = new List<Form1099StateInformation>();

            form1099OID.Form1099StateInfo.Add(CreateStatInformation());
            form1099OID.Form1099StateInfo.Add(CreateStatInformation());
            form1099OID.Form1099StateInfo.Add(CreateStatInformation());

            lstForm1099OID.Add(form1099OID);

            return lstForm1099OID;
        }

        public static Form1099StateInformation CreateStatInformation()
        {
            Form1099StateInformation form1099StateInformation = new Form1099StateInformation();
            form1099StateInformation.State = new State()
            {
                StateId = mStateId
            };
            form1099StateInformation.StateIdentificationNumber = "SIN" + Convert.ToString(Utilities.CreateRandomNumber(0, 20));
            form1099StateInformation.StateTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 20);
            return form1099StateInformation;
        }


        public static Form1099OID GetForm1099OID(dynamic userInputData)
        {
            Form1099OID form1099OID = null;
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId,
         userInputData.userDataId);
            if (taxObject != null)
            {
                if (taxObject.Income != null && taxObject.Income.Form1099OID != null)
                {
                    form1099OID = taxObject.Income.Form1099OID.Find(frm => frm.Form1099OIDId == userInputData.currentForm1099OIDId);
                }
            }
            return form1099OID;
        }


        /// <summary>
        /// Creates the form1099 int.
        /// </summary>
        /// <param name="ownerType">Type of the owner.</param>
        /// <returns></returns>
        public static List<Form1099INT> CreateForm1099INT(OwnerType ownerType)
        {

            List<Form1099INT> lstForm1099INT = new List<Form1099INT>();

            Form1099INT form1099INT = new Form1099INT
            {
                Form1099INTId = 0,

                ForeignTaxPaid = Utilities.CreateRandomNumber(0, 2000),

                EarlyWithdrawalPenalty = Utilities.CreateRandomNumber(0, 2000),

                USBondsTreasury = Utilities.CreateRandomNumber(0, 2000),

                FederalTaxWithHoldingAmount = Utilities.CreateRandomNumber(0, 2000),

                InvestmentExpenses = Utilities.CreateRandomNumber(0, 2000),

                ForeignCountryId = mPersonalInfoRepository.GetAllCountry().First().CountryId,

                TaxExemptInterest = Utilities.CreateRandomNumber(0, 2000),

                TaxExemptAccuredInterest = Utilities.CreateRandomNumber(0, 2000),

                SpecifiedPrivateActivityBond = Utilities.CreateRandomNumber(0, 2000),

                TaxExemptBondCUSIPNumber = "Test Tax Exempt123",

                BothFederalStateExemptInterest = Utilities.CreateRandomNumber(0, 2000),

                IsStateInformationAvailable = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),

                InterestReceivedAsNominee = Utilities.CreateRandomNumber(0, 2000),

                AccuredInterestInpaymentDates = DateTime.Now.Add(new TimeSpan(120, 0, 0, 0, 0)),

                AmortizableBondPremium = Utilities.CreateRandomNumber(0, 2000),

                InterestIncome = Utilities.CreateRandomNumber(0, 2000),

                TaxableInterestAmount = Utilities.CreateRandomNumber(0, 2000),

                WithholdingTaxAmount = Utilities.CreateRandomNumber(0, 2000),

                AccountNumber = "TestAc12345",

                //TaxExemptStateCodeAndAmount = new Form1099INTTaxExemptInterest()
                //{
                //    TaxExemptInterestState = new State()
                //    {
                //        StateId = mPersonalInfoRepository.GetAllState().First().StateId
                //    }
                //},

                Payer = new Payer
                {
                    PayerName = "Test Payer",
                    PayerIdentificationNumber = "1234",
                    Address = new Address
                    {
                        AddressId = 0,
                        AddressType = AddressType.TaxPayerAddress,
                        PayerAddress = new PayerAddress
                        {
                            City = "Test Payer City",
                            StreetAddress = "Test Payer Street Address",
                            State = new State
                            {
                                StateId = mPersonalInfoRepository.GetAllState().First().StateId
                            },
                            ZipCode = "123456"
                        },
                    }
                },

                Form1099StateInfo = new List<Form1099StateInformation> {

                new Form1099StateInformation {
                    State=new State{
                        StateId = mPersonalInfoRepository.GetAllState().First().StateId
                    },
                StateIdentificationNumber = "Test SIN143",
                StateTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 2000)
                },

                new Form1099StateInformation {
                    State=new State{
                StateId = mPersonalInfoRepository.GetAllState().First().StateId
                    },
                StateIdentificationNumber = "Test SIN144",
                StateTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 2000)
                },

                },
                Form = FormType.Form1099INT,
                //TaxExemptStateCodeAndAmount = new Form1099INTTaxExemptInterest
                //{
                //    TaxExemptInterestState = new State
                //    {
                //        StateId = Utilities.CreateRandomNumber(0, 2000)
                //    },
                //    StateExemptInterest = Utilities.CreateRandomNumber(0, 2000)
                //}
            };

            lstForm1099INT.Add(form1099INT);

            return lstForm1099INT;
        }


        /// <summary>
        /// Tests the clean up.
        /// </summary>
        [TestCleanup]
        public void TestCleanUp()
        {

        }

        #region Helper Methods


        public static List<W2> CreateW2()
        {
            List<W2> W2Wages = new List<W2>();

            var w21 = new W2();
            var w22 = new W2();
            var w23 = new W2();

            w21.WagesAmount = 10000.00;
            w21.FederalTaxWithholdingAmount = 50.00;
            w21.SocialSecurityWagesAmount = 60.00;
            w21.SocialSecurityTaxWithholdingAmount = 39.00;
            w21.MedicareTaxWithholdingAmount = 80.00;
            w21.AllocatedTipsAmount = 50.00;
            w21.DependentCareBenefitsAmount = 500.00;
            w21.MedicareWagesAmount = 544.00;
            W2Wages.Add(w21);

            w22.WagesAmount = 20000.00;
            w22.FederalTaxWithholdingAmount = 100.00;
            w22.SocialSecurityWagesAmount = 120.00;
            w22.SocialSecurityTaxWithholdingAmount = 78.00;
            w22.MedicareTaxWithholdingAmount = 160.00;
            w22.AllocatedTipsAmount = 100.00;
            w22.DependentCareBenefitsAmount = 1000.00;
            w22.MedicareWagesAmount = 1088.00;
            W2Wages.Add(w22);

            w23.WagesAmount = 20000.00;
            w23.FederalTaxWithholdingAmount = 100.00;
            w23.SocialSecurityWagesAmount = 120.00;
            w23.SocialSecurityTaxWithholdingAmount = 78.00;
            w23.MedicareTaxWithholdingAmount = 160.00;
            w23.AllocatedTipsAmount = 100.00;
            w23.DependentCareBenefitsAmount = 1000.00;
            w23.MedicareWagesAmount = 1088.00;
            W2Wages.Add(w23);

            return W2Wages;
        }
        #endregion

    }
}
