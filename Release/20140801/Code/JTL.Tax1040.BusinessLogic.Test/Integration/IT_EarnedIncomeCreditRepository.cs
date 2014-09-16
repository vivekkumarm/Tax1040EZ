/*
Copyright   : Copyright Jeevan Technologies
File Name   : IT_EarnedIncomeCreditRepository.cs 
Description : Integration Test EarnedIncomeCreditRepository 
Author      : vivek
Created Date : 25/May/14

 * Modification History:
------------------------
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace JTL.Tax1040.BusinessLogic.Test
{
    [TestClass]
    public class IT_EarnedIncomeCreditRepository
    {

        #region private local variables
        private long mUserId;
        private int mYear = 2014;
        private long mUserDataId = 0L;
        private static IPersonalInfoRepository mPersonalInfoRepository;
        private static IEarnedIncomeCreditRepository mEarnedIncomeCreditRepository;
        private static ITaxReturnRepository mTaxReturnRepository;
        private static IW2Repository mW2Repository;
        private static IInterestIncomeRepository mInterestIncomeRepository;
        private static IOtherIncomeRepository mOtherIncomeRepository;
        private static IUnemploymentRepository mUnemploymentRepository;
        private static TaxReturnData taxReturnData;
        private dynamic w2Data;
        private UserDTO userDTO;
        private dynamic taxobject;
        #endregion


        #region test initialize
        [TestInitialize()]
        public void TestInitialize()
        {
            taxobject = new ExpandoObject();
            userDTO = new UserDTO();
            //New User Persist
            mUserId = IT_UserRepository.PersistNewUser();
            mW2Repository = new W2Repository();
            mInterestIncomeRepository = new InterestIncomeRepository();
            mPersonalInfoRepository = new PersonalInfoRepository();
            mEarnedIncomeCreditRepository = new EarnedIncomeCreditRepository();
            mTaxReturnRepository = new TaxReturnRepository();
            mOtherIncomeRepository = new OtherIncomeRepository();
            taxReturnData = new TaxReturnData();
            mUnemploymentRepository = new UnemploymentRepository();
        }
        #endregion

        /// <summary>
        /// GetEarnedIncomeCredit Test
        /// </summary>
        [TestMethod]
        public void GetEarnedIncomeCredit()
        {
            //User Data Persist
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);
            //After persist
            Assert.AreNotEqual(mUserDataId, expectedUserDataID.Item1);

            //User Id to User DTO
            userDTO.UserDataId = expectedUserDataID.Item1;
            userDTO.UserId = mUserId;

            //Get Primary data
            var getprimaryDetail = mPersonalInfoRepository.GetPrimaryTaxPayerByUserIdAndUserDataId(mUserId, expectedUserDataID.Item1);
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = JsonConvert.SerializeObject(getprimaryDetail);

            // EIC Persist 
            var persistEIC = mEarnedIncomeCreditRepository.PersitEarnedIncomeCredit(mUserId, taxReturnData, mYear);

            //Assign the user Data to the User DTO 
            userDTO.UserDataId = expectedUserDataID.Item1;
            userDTO.UserId = mUserId;

            //Get EIC using user DTO
            var getEIC = mEarnedIncomeCreditRepository.GetEarnedIncomeCredit(userDTO);
            Assert.AreNotEqual(0, getEIC);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void PersistEarnedIncomeCredit()
        {
            //Primary Tax Payer persist
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);
            //After persist
            Assert.AreNotEqual(mUserDataId, expectedUserDataID.Item1);

            //Get primary user details using user id
            var getprimaryDetail = mPersonalInfoRepository.GetPrimaryTaxPayerByUserIdAndUserDataId(mUserId, expectedUserDataID.Item1);

            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = JsonConvert.SerializeObject(getprimaryDetail);
            //EIC persist 
            var EICPersist = mEarnedIncomeCreditRepository.PersitEarnedIncomeCredit(mUserId, taxReturnData, mYear);
            //After persist
            Assert.AreNotEqual(EICPersist, 0);
        }      

        #region Persist EIC

        #region primary tax payer persist
        /// <summary>
        /// EIC Persist as a primary tax payer
        /// </summary>
        [TestMethod()]
        public void EICPersistAsPrimaryTaxPayer()
        {
            var userDataId = 0L;
            //personal persist
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);
            //After persist
            Assert.AreNotEqual(userDataId, expectedUserDataID.Item1);
            var eic = CreateEIC(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            var eicJson = JsonConvert.SerializeObject(eic);
            taxReturnData.TaxData = eicJson;
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            //Before Persist
            Assert.AreEqual(0, userDataId);
            //EIC Persist
            var userData = mEarnedIncomeCreditRepository.PersitEarnedIncomeCredit(mUserId, taxReturnData, mYear);
            //After w2 Persist
            Assert.AreNotEqual(userData, null);

        }
        #endregion

        #region Spouse persist
        /// <summary>
        /// EIC Persist With spouse 
        /// </summary>
        [TestMethod()]
        public void EICPersistAsSpouse()
        {

            var userDataId = 0L;
            //personal persist
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);
            //After persist
            Assert.AreNotEqual(userDataId, expectedUserDataID.Item1);
            var eic = CreateEIC(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            var eicJson = JsonConvert.SerializeObject(eic);
            taxReturnData.TaxData = eicJson;
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            //Before Persist
            Assert.AreEqual(0, userDataId);
            //EIC Persist
            var userData = mEarnedIncomeCreditRepository.PersitEarnedIncomeCredit(mUserId, taxReturnData, mYear);
            //After w2 Persist
            Assert.AreNotEqual(userData, null);

        }

        #endregion
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void PersistEICPrimaryTaxpayerAndSpouse()
        {
            var userDataId = 0L;
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.MarriedFilingJointly);
            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);
            //After persist
            Assert.AreNotEqual(userDataId, expectedUserDataID.Item1);
            //EIC Serialization
            var eic = CreateEIC(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            var eicJson = JsonConvert.SerializeObject(eic);
            taxReturnData.TaxData = eicJson;
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            //Before Persist
            Assert.AreEqual(0, userDataId);
            //EIC Persist
            var userData = mEarnedIncomeCreditRepository.PersitEarnedIncomeCredit(mUserId, taxReturnData, mYear);
            //After w2 Persist
            Assert.AreNotEqual(userData, null);
        }
        /// <summary>
        /// EIC business validation with value for single
        /// </summary>
        [TestMethod()]
        public void EICBussinessValidationWithValuesForSingle()
        {
            var userDataId = 0L;
            var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);
            //primary persist for EIC business check
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);

            //After Persist
            Assert.AreNotEqual(userData, userDataId);
            //Address Persist
            var address = IT_PersonalInfo.CreateAndPersistPersonalAddressDetails(mUserId, userData.Item1);
            //Get primary tax payer data using user 
            var PrimaryTaxPayerUsingPersonalID = mPersonalInfoRepository.GetPersonByPersonId(primaryTaxPayer.Person.PersonId);

            //w2 Create
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            var w2Json = JsonConvert.SerializeObject(w2);
            taxReturnData.TaxData = w2Json;
            taxReturnData.UserDataId = userData.Item1;

            //w2 Persist
            w2Data = mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);

            userDTO.UserDataId = userData.Item1;
            userDTO.UserId = mUserId;
            //Get W2 Data
            var getw2Data = mW2Repository.GetTaxReturnW2List(userDTO);

            long wagesAmount = 0L;
            long householdEmployeeWages = 0L;
            long taxableScholarshipAmount = 0L;
            foreach (var item in getw2Data)
            {
                householdEmployeeWages = Convert.ToInt64(item.Employer.HouseholdEmployeeWages);
                taxableScholarshipAmount = Convert.ToInt64(item.Employer.TaxableScholarshipAmount);
                wagesAmount = Convert.ToInt64(item.WagesAmount);

            }

            var AGI = householdEmployeeWages + taxableScholarshipAmount + wagesAmount;

            if (primaryTaxPayer.FilingStatus == FilingStatus.Single && AGI < 14340)
            {
                Assert.AreNotEqual(AGI, 0);
            }
        }

        /// <summary>
        /// EIC Business Validation with value or MFJ
        /// </summary>
        [TestMethod()]
        public void EICBussinessValidationWithValuesForMFJ()
        {
            var userDataId = 0L;

            var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.MarriedFilingJointly);


            //primary persist for EIC business check
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);


            //After Persist
            Assert.AreNotEqual(userData, userDataId);

            //Address Persist
            var address = IT_PersonalInfo.CreateAndPersistPersonalAddressDetails(mUserId, userData.Item1);
            //Get primary tax payer data using user 
            var PrimaryTaxPayerUsingPersonalID = mPersonalInfoRepository.GetPersonByPersonId(primaryTaxPayer.Person.PersonId);

            //w2 Create
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            var w2Json = JsonConvert.SerializeObject(w2);
            taxReturnData.TaxData = w2Json;
            taxReturnData.UserDataId = userData.Item1;

            //w2 Persist
            w2Data = mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);

            userDTO.UserDataId = userData.Item1;
            userDTO.UserId = mUserId;
            var getw2Data = mW2Repository.GetTaxReturnW2List(userDTO);

            long wagesAmount = 0L;

            foreach (var item in getw2Data)
            {
                wagesAmount = Convert.ToInt64(item.WagesAmount);
            }

            //After w2 Persist
            Assert.AreNotEqual(w2Data, 0);

            //IntrestIncome Persist
            var form1099INT = CreateForm1099INTForMFJ(OwnerType.PrimaryTaxPayer);
            Assert.AreNotEqual(form1099INT, 0);

            var form1099OID = CreateForm1099OIDForMFJ(OwnerType.PrimaryTaxPayer);
            Assert.AreNotEqual(form1099INT, 0);

            var form1099G = CreateForm1099GForMFJ();
            Assert.AreNotEqual(form1099G, 0);

            var otherIncome = CreateOtherIncomeMFJ(OwnerType.PrimaryTaxPayer);
            Assert.AreNotEqual(otherIncome, 0);

            var formINT = form1099INT.InterestIncome + form1099INT.USBondsTreasury;
            var formOID = form1099OID.OriginalIssueDiscount + form1099OID.OtherPeriodicInterest + form1099OID.USTreasuryObligations;
            var unEmployement = form1099G.UnEmploymentCompensation;
            var otherIntrestIncome = otherIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend;
            var AGI = wagesAmount + formINT + formOID + unEmployement + otherIntrestIncome;

            if (primaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly && AGI < 19680)
            {
                Assert.AreNotEqual(AGI, 0);
            }
        }


        /// <summary>
        /// EIC Business Validation with out values
        /// </summary>
        [TestMethod()]
        public void EICBussinessValidationWithOutValues()
        {

            var userDataId = 0L;

            var primaryTaxPayer = CreatePrimaryTaxPayer(FilingStatus.Single);

            //primary persist for EIC business check
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, userDataId);

            //After Persist
            Assert.AreNotEqual(userData, userDataId);

            //Address Persist
            var address = IT_PersonalInfo.CreateAndPersistPersonalAddressDetails(mUserId, userData.Item1);
            //Get primary tax payer data using user 
            var PrimaryTaxPayerUsingPersonalID = mPersonalInfoRepository.GetPersonByPersonId(primaryTaxPayer.Person.PersonId);

            //w2 Create
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            var w2Json = JsonConvert.SerializeObject(w2);
            taxReturnData.TaxData = w2Json;
            taxReturnData.UserDataId = userData.Item1;

            //w2 Persist
            w2Data = mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);

            //UserDTO userDTO=new UserDTO();
            userDTO.UserDataId = userData.Item1;
            userDTO.UserId = mUserId;
            var getw2Data = mW2Repository.GetTaxReturnW2List(userDTO);

            //var wagesAmount=  

            //After w2 Persist
            Assert.AreNotEqual(w2Data, 0);

            //IntrestIncome Persist
            var form1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);
            Assert.AreNotEqual(form1099INT, 0);

            var form1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);
            Assert.AreNotEqual(form1099INT, 0);

            var form1099G = CreateForm1099G();
            Assert.AreNotEqual(form1099G, 0);

            var otherIncome = CreateOtherIncome(OwnerType.PrimaryTaxPayer);
            Assert.AreNotEqual(otherIncome, 0);
        }




        #endregion

        #region Helper Method


        #region Single
        public static OtherIncome CreateOtherIncome(OwnerType ownerType)
        {
            OtherIncome otherIncome = new OtherIncome
            {
                AlaskaPermanentFundDividend = new AlaskaPermanentFundDividend
                {
                    PrimaryTaxpayerAlaskaFundDividend = 123,
                }

            };
            return otherIncome;
        }

        public static Form1099OID CreateForm1099OID(OwnerType ownerType)
        {
            Form1099OID form1099OID = null;

            form1099OID = new Form1099OID()
            {
                Form1099OIDId = 0,
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
                AccountNumber = "TestAc12345",
                OriginalIssueDiscount = Utilities.CreateRandomNumber(0, 2000),
                OtherPeriodicInterest = Utilities.CreateRandomNumber(0, 2000),
                EarlyWithdrawalPenalty = Utilities.CreateRandomNumber(0, 2000),
                IncomeMarketDiscount = Utilities.CreateRandomNumber(0, 2000),
                ForeignTaxPaid = Utilities.CreateRandomNumber(0, 2000),
                ForeignCountryId = 1,
                IsMutualFundRegulatedInvestment = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                USTreasuryObligations = Utilities.CreateRandomNumber(0, 2000),
                InvestmentExpenses = Utilities.CreateRandomNumber(0, 2000),
                IsStateInformationAvailable = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                InterestReceivedAsNominee = Utilities.CreateRandomNumber(0, 2000),
                AdjustmentAmount = Utilities.CreateRandomNumber(0, 2000),
                TaxableInterestAmount = Utilities.CreateRandomNumber(0, 2000),
                FederalTaxWithHoldingAmount = Utilities.CreateRandomNumber(0, 2000),
                Description = "testContent",
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
                AcquisitionPremium = Utilities.CreateRandomNumber(0, 2000),
                HasToReportTaxExempt = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                HasToReportAdjustment = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                TaxExemptInterestState = new State
                {
                    StateId = mPersonalInfoRepository.GetAllState().First().StateId


                },
                StateExemptInterest = Utilities.CreateRandomNumber(0, 2000),
                TaxExemptInterest = Utilities.CreateRandomNumber(0, 2000),
                Form = FormType.Form1099OID
            };

            return form1099OID;
        }

        public static Form1099G CreateForm1099G()
        {
            Form1099G form1099G = new Form1099G()
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
                UnEmploymentCompensation = Utilities.CreateRandomNumber(0, 20),
                FederalTaxWithHoldingAmount = Utilities.CreateRandomNumber(0, 20),
                IsCurrentYearUnemploymentRepaid = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                CurrentYearUnemploymentRepaid = Utilities.CreateRandomNumber(0, 20),
                IsPriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                PriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 20)

            };
            form1099G.OwnerType = (OwnerType)Utilities.CreateRandomNumber(0, 1);

            form1099G.Form1099StateInfo = new List<Form1099StateInformation>();



            return form1099G;
        }

        public static Form1099INT CreateForm1099INT(OwnerType ownerType)
        {
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

                TaxExemptInterestState = new State()
                {
                    StateId = mPersonalInfoRepository.GetAllState().First().StateId


                },

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
                //TaxExemptInterestStateId = Utilities.CreateRandomNumber(0, 2000),
                StateExemptInterest = Utilities.CreateRandomNumber(0, 2000)
            };

            return form1099INT;
        }
        #endregion

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
                    DateOfBirth = new DateTime(1964, 6, 16),
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
                    IsFullTimeStudent = false,
                    //IsOtherInfoNone = false
                },
                FilingStatus = filingStatus
            };



            return primaryTaxPayer;
        }


        public static W2 CreateW2(EmploymentType employmentType, OwnerType ownerType)
        {
            W2 w2 = new W2
            {
                FederalTaxWithholdingAmount = 8,
                SocialSecurityTaxWithholdingAmount = 14340,
                WagesAmount = 12309,
            };
            return w2;
        }


        public static EIC CreateEIC(EmploymentType employmentType, OwnerType ownerType)
        {
            EIC eic = new EIC
            {
                HasValidSSN = true,
                IsInUSMorethanHalfYear = true,
                HasEICForPriorYearDisallowance = true,
                HasPensionAnnuity = true,
                HasReceivedIRSNoticeOnFiling8862 = true,
                HasIncorrectlyReportedEarnedIncome = true,
                HasTaxableScholarshipCredits = true,

            };
            return eic;
        }

        private static PrimaryTaxPayer PersonalUpdate(long personalID)
        {
            PrimaryTaxPayer primaryTaxPayer = new PrimaryTaxPayer
            {
                Person = new Person
                {
                    DateOfBirth = new DateTime(1964, 6, 16)
                },
            };

            return primaryTaxPayer;
        }

        #region MFJ
        public static Form1099OID CreateForm1099OIDForMFJ(OwnerType ownerType)
        {
            Form1099OID form1099OID = null;

            form1099OID = new Form1099OID()
            {
                Form1099OIDId = 0,
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
                AccountNumber = "TestAc12345",
                OriginalIssueDiscount = Utilities.CreateRandomNumber(0, 2000),
                OtherPeriodicInterest = Utilities.CreateRandomNumber(0, 2000),
                EarlyWithdrawalPenalty = Utilities.CreateRandomNumber(0, 2000),
                IncomeMarketDiscount = Utilities.CreateRandomNumber(0, 2000),
                ForeignTaxPaid = Utilities.CreateRandomNumber(0, 2000),
                ForeignCountryId = 1,
                IsMutualFundRegulatedInvestment = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                USTreasuryObligations = Utilities.CreateRandomNumber(0, 2000),
                InvestmentExpenses = Utilities.CreateRandomNumber(0, 2000),
                IsStateInformationAvailable = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                InterestReceivedAsNominee = Utilities.CreateRandomNumber(0, 2000),
                AdjustmentAmount = Utilities.CreateRandomNumber(0, 2000),
                TaxableInterestAmount = Utilities.CreateRandomNumber(0, 2000),
                FederalTaxWithHoldingAmount = Utilities.CreateRandomNumber(0, 2000),
                Description = "testContent",
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
                AcquisitionPremium = Utilities.CreateRandomNumber(0, 2000),
                HasToReportTaxExempt = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                HasToReportAdjustment = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                TaxExemptInterestState = new State
                {
                    StateId = mPersonalInfoRepository.GetAllState().First().StateId


                },
                StateExemptInterest = Utilities.CreateRandomNumber(0, 2000),
                TaxExemptInterest = Utilities.CreateRandomNumber(0, 2000),
                Form = FormType.Form1099OID
            };

            return form1099OID;
        }

        private static Form1099G CreateForm1099GForMFJ()
        {
            Form1099G form1099G = new Form1099G()
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
                UnEmploymentCompensation = Utilities.CreateRandomNumber(0, 20),
                FederalTaxWithHoldingAmount = Utilities.CreateRandomNumber(0, 20),
                IsCurrentYearUnemploymentRepaid = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                CurrentYearUnemploymentRepaid = Utilities.CreateRandomNumber(0, 20),
                IsPriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                PriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 20)

            };
            form1099G.OwnerType = (OwnerType)Utilities.CreateRandomNumber(0, 1);

            form1099G.Form1099StateInfo = new List<Form1099StateInformation>();



            return form1099G;
        }

        public static Form1099INT CreateForm1099INTForMFJ(OwnerType ownerType)
        {
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

                TaxExemptInterestState = new State()
                {
                    StateId = mPersonalInfoRepository.GetAllState().First().StateId


                },

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
                //TaxExemptInterestStateId = Utilities.CreateRandomNumber(0, 2000),
                StateExemptInterest = Utilities.CreateRandomNumber(0, 2000)
            };

            return form1099INT;
        }

        public static OtherIncome CreateOtherIncomeMFJ(OwnerType ownerType)
        {
            OtherIncome otherIncome = new OtherIncome
            {
                AlaskaPermanentFundDividend = new AlaskaPermanentFundDividend
                {
                    PrimaryTaxpayerAlaskaFundDividend = 123,
                }

            };
            return otherIncome;
        }
        #endregion

        #endregion




    }
}
