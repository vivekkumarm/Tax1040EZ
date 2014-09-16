/*
copyright                   : copyright jeevan technologies
file name                   : IT_EfileRepository.cs
description                 : Efile Business Logic integration test.
author                      : Yogalakshmi Rangan
created date                : 23 July 2014
 
Modification History:
  
 
*/


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JTL.Tax1040.BusinessObject;
using Newtonsoft.Json;
using System.Dynamic;
using System.Linq;
using JTL.Tax1040.Core.Object;
using System.Collections.Generic;
using JTL.Tax1040.Core.Process;

namespace JTL.Tax1040.BusinessLogic.Test
{
    [TestClass]
    public class IT_EfileRepository
    {
        static IEFileRepository mEfileRepository;
        static long userId = 0;


        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mEfileRepository = new EFileRepository();
            userId = IT_UserRepository.PersistNewUser();

        }

        #region Test Cases with values

        //Filing 
        public static Filing CreateEfile()
        {
            return new Filing()
            {
                HaveFiledPriorYearReturnElectronically = true,
                Email = "gorgeousangel03@gmail.com",
                FederalFiling = new FederalFiling()
                {
                  //  IRS = PersisrIRSTransmission(),
                    IsEfile = true,
                    ReturnStatus = ReturnStatus.InProgress,
                },
                StateFiling = new List<StateFiling>()
                {
                    PersistStateFiling()
                }
            };
        }

        //StateFiling
        public static StateFiling PersistStateFiling()
        {
            return new StateFiling()
            {
                IsEfile = true,
                ReturnStatus = ReturnStatus.InProgress,
                State = new State()
                {
                    StateId = 3,
                    StateCode = "",
                    StateName = ""
                }
            };
        }

        //IRSTransmission
        public static IRSTransmission PersisrIRSTransmission()
        {
            return new IRSTransmission()
            {
                IsFilingStateReturnElectronically = true,
                IsFilingFederalReturnElectronically = true,
                HavePriorYearPIN = true,
                HavePriorYearAGI = true,
                HavePriorYearAGIAndPIN = true,
                FilingDate = new DateTime(2015, 05, 14),
                HasReceivedIPINFromIRS = true,
                PrimaryTaxPayerIPIN = "1234567896",
                SpouseIPIN = "9874563212",
                PrimaryPIN = "61654654546",
                PrimaryPriorYearPIN = "8523697412",
                PrimaryPriorYearAGI = 32.3,
                PrimaryTaxPayerFilingDate = new DateTime(2015, 05, 14),
                PrimaryTaxpayerEFIN = "",
                SpousePIN = "",
                SpousePriorYearPIN = "",
                SpousePriorYearAGI = 545.33,
                SpouseEFIN = "",
                SpouseFilingDate = new DateTime(2015, 05, 14),
                DayTimePhone = "",
                //Form8879=,
                IPAddress = "",
                TaxpayerEFINIssuedByIRS = "",
                SpouseEFINIssuedByIRS = "",
                TaxpayerDateIssuedByIRS = new DateTime(2015, 05, 14),
                SpouseDateIssuedByIRS = new DateTime(2015, 05, 14)
            };
        }

        //UserDTO
        public static UserDTO GetUserDTO()
        {
            UserDTO userdto = new UserDTO();
            var userDataId = 0L;
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(CreateEfile());
            var value = mEfileRepository.PersistFiling(userId, taxReturnData);
            userdto.UserId = userId;
            userdto.UserDataId = taxReturnData.UserDataId;

            return userdto;
        }


        //PaymentDTO
        public static PaymentDTO PersistPaymentDTO()
        {
            return new PaymentDTO()
            {
                UserId = IT_UserRepository.PersistNewUser(),
                UserDataId = 0L,
                ProductType = ProductType.None,
                ShoppingCartId = 0,
                StateIDs = null,
                Order = new Order()
                {
                    OrderId = 0,
                    Processed = false,
                    ShoppingCartId = 0,
                    ShoppingCart = new List<ShoppingCart>()
                    {
                        PersistShoppingCart()
                    },
                    TotalAmount = 0,
                    PaymentDate = DateTime.MinValue,
                    BillingDetails = new BillingDetails()
                    {
                        FirstName = null,
                        LastName = null,
                        PaymentDate = DateTime.MinValue,
                        BillingAddress = new BillingAddress()
                        {
                            StreetAddress = null,
                            ApartmentNumber = null,
                            City = null,
                            State = new State()
                            {
                            },
                            ZipCode = null,
                            PhoneNumber = null,
                            StateOrProvince = null,
                            Country = new Country()
                            {
                                CountryId = 0,
                                CountryCode = null,
                                CountryName = null
                            },
                            IsForeignAddress = false
                        },
                        CreditCard = new CreditCard()
                        {
                            CreditCardNo = null,
                            CreditCardType = new CreditCardType()
                            {
                                CardType = CardType.None,
                                CreditCardTypeName = null
                            },
                            SecurityCodeNo = null,
                            ExpiryMonth = null,
                            ExpiryYear = null
                        },
                        Email = null
                    },
                    Authorization = null
                },
                IRS = CreateIRS()
            };
        }

        //IRS
        public static IRS CreateIRS()
        {
            return new IRS()
            {
                BankDetails = new BankDetails()
                {
                    BankName = null,
                    RoutingTransitNumber = null,
                    AccountNumber = null,
                    BankAccountTypeCode = AccountType.None,

                },
                Amount = 0,
                PaymentOption = PaymentOption.DirectDebit,
                PaymentDate = DateTime.MinValue,
                IsIRSPaymentOptionAgreed = true
            };
        }

        //ShoppingCart
        public static ShoppingCart PersistShoppingCart()
        {
            return new ShoppingCart()
            {
                ProductType = ProductType.None,
                SkuId = 0,
                SkuName = null,
                SkuDescription = null,
                SkuPrice = 0,
                State = new State()
                {
                    StateId = 3,
                    StateCode = "",
                    StateName = ""
                },
                FederalFeature = new FederalFeature()
                {
                    FederalFeatureSKU = new List<FederalFeatureSKU>()
                    {
                        PersistFederalFeatureSKU()
                    },
                },
                StateFeature = new List<StateFeature>()
                {
                    PersistStateFeature()
                }
            };
        }

        //FederalFeatureSKU
        public static FederalFeatureSKU PersistFederalFeatureSKU()
        {
            return new FederalFeatureSKU()
            {
                FederalFeatureSkuId = 0,
                ProductType = ProductType.None,
                FederalName = null,
                Feature = new Feature()
                {
                    FeatureId = 0,
                    FeatureName = null,
                    Description = null
                },
                FederalFeaturePrice = 0
            };
        }

        //StateFeature
        public static StateFeature PersistStateFeature()
        {
            return new StateFeature()
            {
                StateFeatureSKU = new List<StateFeatureSKU>()
                {
                    PersistStateFeatureSKU()
                },
                State = new State()
                {
                    StateId = 3,
                    StateCode = "",
                    StateName = ""
                }
            };
        }

        //StateFeatureSKU
        public static StateFeatureSKU PersistStateFeatureSKU()
        {
            return new StateFeatureSKU()
            {
                StateFeatureSkuId = 0,
                ProductType = ProductType.None,
                Feature = new Feature()
                {
                    FeatureId = 0,
                    FeatureName = null,
                    Description = null
                },
                StatePrice = 0,
                State = new State()
                {
                    StateId = 3,
                    StateCode = "",
                    StateName = ""
                }
            };
        }

        //Persist Efile 
        [TestMethod]
        public void PersistEfile()
        {
            var userDataId = 0L;
            TaxReturnData taxReturnData = new TaxReturnData();
            var createEfile = CreateEfile();
            taxReturnData.TaxData = JsonConvert.SerializeObject(createEfile);
            //Persist for Filing
            var filing = mEfileRepository.PersistFiling(userId, taxReturnData);
            Assert.AreNotEqual(0, filing.Item1);
        }

        //Persist IRS Transmission
        [TestMethod]
        public void PersistIRSTranmission()
        {
            TaxReturnData taxReturnData = new TaxReturnData();
            var persistIRSTransmission = PersisrIRSTransmission();
            taxReturnData.TaxData = JsonConvert.SerializeObject(persistIRSTransmission);
            var createIRSTransmission = mEfileRepository.PersistIRSTranmission(userId, taxReturnData);
            Assert.AreNotEqual(0, createIRSTransmission);
        }

        //Persist IRS Payment Option
        [TestMethod]
        public void PersistIRSPaymentOption()
        {
            var persistPaymentDTO = PersistPaymentDTO();
            var paymentDetails = mEfileRepository.PersistIRSPaymentOption(persistPaymentDTO);
            Assert.AreNotEqual(0, paymentDetails.Item1);
        }

        ////Get filing details
        //[TestMethod]
        //public void GetFiling()
        //{
        //    var getUserDTO = GetUserDTO();
        //    var filingDetails = mEfileRepository.GetFiling(getUserDTO);
        //    Assert.IsNotNull(filingDetails);
        //}

        //Get filing options summary
        [TestMethod]
        public void GetFilingOptionSummary()
        {
            var getUserDTO = GetUserDTO();
            var filingOptionsSummary = mEfileRepository.GetFilingOptionSummary(getUserDTO);
            Assert.IsNotNull(filingOptionsSummary);
        }

        ////Get filing options summary
        //[TestMethod]
        //public void GetEFileDetails()
        //{
        //    var getUserDTO = GetUserDTO();
        //    var eFileDetails = mEfileRepository.GetEFileDetails(getUserDTO);
        //    Assert.IsNotNull(eFileDetails);
        //}

        //Delete Efile Information
        [TestMethod]
        public void DeleteEfileInformation()
        {
            var getUserDTO = GetUserDTO();
            var eFileDetails = mEfileRepository.DeleteEfileInformation(getUserDTO);
            Assert.IsNotNull(eFileDetails);
        }
        #endregion Test Cases with values

        #region Test Cases with no values


        //Filing
        public static Filing CreateEfileWithNullEntries()
        {
            return new Filing()
            {
                //HaveFiledPriorYearReturnElectronically = null,
                Email = null,
                FederalFiling = new FederalFiling()
                {
                //    IRSTransmission = PersisrIRSTransmissionEfileWithNullEntries(),
                    //IsEfile = null,
                    //ReturnStatus = ReturnStatus.InProgress,
                },
                StateFiling = new List<StateFiling>()
                {
                    PersistStateFilingEfileWithNullEntries()
                }
            };
        }

        //StateFiling
        public static StateFiling PersistStateFilingEfileWithNullEntries()
        {
            return new StateFiling()
            {
                IsEfile = true,
                ReturnStatus = ReturnStatus.InProgress,
                State = new State()
                {
                    StateId = 0,
                    StateCode = null,
                    StateName = null
                }
            };
        }

        //IRSTransmission
        public static IRSTransmission PersisrIRSTransmissionEfileWithNullEntries()
        {
            return new IRSTransmission()
            {
                IsFilingStateReturnElectronically = null,
                //IsFilingFederalReturnElectronically = null,
                HavePriorYearPIN = null,
                HavePriorYearAGI = null,
                HavePriorYearAGIAndPIN = null,
                FilingDate = null,
                HasReceivedIPINFromIRS = null,
                PrimaryTaxPayerIPIN = null,
                SpouseIPIN = null,
                PrimaryPIN = null,
                PrimaryPriorYearPIN = null,
                PrimaryPriorYearAGI = null,
                PrimaryTaxPayerFilingDate = null,
                PrimaryTaxpayerEFIN = null,
                SpousePIN = null,
                SpousePriorYearPIN = null,
                SpousePriorYearAGI = null,
                SpouseEFIN = null,
                SpouseFilingDate = null,
                DayTimePhone = null,
                //Form8879=,
                IPAddress = null,
                TaxpayerEFINIssuedByIRS = null,
                SpouseEFINIssuedByIRS = null,
                TaxpayerDateIssuedByIRS = null,
                SpouseDateIssuedByIRS = null
            };
        }

        //UserDTO
        public static UserDTO GetUserDTOEfileWithNullEntries()
        {
            var userDataId = 0L;
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(CreateEfileWithNullEntries());
            var value = mEfileRepository.PersistFiling(userId, taxReturnData);
            UserDTO userdto = new UserDTO();

            userdto.UserId = userId;
            userdto.UserDataId = value.Item1;

            return userdto;
        }

        //Persist Efile With null entries
        [TestMethod]
        public void PersistEfileWithNullEntries()
        {
            var userDataId = 0L;
            TaxReturnData taxReturnData = new TaxReturnData();
            var createEfileWithNullEntries = CreateEfileWithNullEntries();
            taxReturnData.TaxData = JsonConvert.SerializeObject(createEfileWithNullEntries);
            //Persist for Filing
            var filing = mEfileRepository.PersistFiling(userId, taxReturnData);

            Assert.AreNotEqual(0, filing.Item1);

            //Persist for IRS Transmission 
            var irsTransmission = mEfileRepository.PersistIRSTranmission(userId, taxReturnData);
            Assert.AreNotEqual(0, irsTransmission);

            //Get IRS Tranmission data
            UserDTO userDTO = new UserDTO() { UserId = userId = taxReturnData.UserDataId };
            var irsTransmisiionDetails = mEfileRepository.GetPersonAndIRSTransmission(userDTO);
            Assert.IsNotNull(irsTransmisiionDetails);
        }
        #endregion Test Cases with no values

        #region Required Feild
        
        [TestMethod()]
        public void AccountTypeRFCheck()
        {
            //var hasEligibilityDiagnostics = false;
            //Persist Payment Options
            var persistPaymentDTO = PersistPaymentDTO();
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(persistPaymentDTO);
            var persistPaymentDetails = mEfileRepository.PersistIRSPaymentOption(persistPaymentDTO);
            Assert.IsTrue(persistPaymentDetails.Item1 > 0);
            //persistPaymentDetails.Item2
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(persistPaymentDTO.UserId, persistPaymentDetails.Item1);
            //Required Field validation #1
            bool hasAccountType = persistPaymentDetails.Item2.Any(em => (em.ErrorCode == "Efile_RF1"));
            Assert.IsTrue(hasAccountType);
            //Required Field validation #2
            bool hasAccountNumber = persistPaymentDetails.Item2.Any(em => (em.ErrorCode == "Efile_RF2"));
            Assert.IsTrue(hasAccountNumber);
            //Required Field validation #3
            bool hasRoutingNumber = persistPaymentDetails.Item2.Any(em => (em.ErrorCode == "Efile_RF3"));
            Assert.IsTrue(hasRoutingNumber);
            //Required Field validation #4
            bool hasBankName = persistPaymentDetails.Item2.Any(em => (em.ErrorCode == "Efile_RF4"));
            Assert.IsTrue(hasBankName);
            //Required Field validation #5
            bool hasIRSPaymentOptionAgreedWithPaymentDebit = persistPaymentDetails.Item2.Any(em => (em.ErrorCode == "Efile_RF5"));
            Assert.IsTrue(hasIRSPaymentOptionAgreedWithPaymentDebit);
            //Required Field validation #6
            bool hasIRSPaymentOptionAgreedWithPaymentEFTS = persistPaymentDetails.Item2.Any(em => (em.ErrorCode == "Efile_RF6"));
            Assert.IsTrue(hasIRSPaymentOptionAgreedWithPaymentEFTS);
            //Required Field validation #7
            bool hasIRSPaymentOptionAgreedWithPaymentCheckByMail = persistPaymentDetails.Item2.Any(em => (em.ErrorCode == "Efile_RF7"));
            Assert.IsTrue(hasIRSPaymentOptionAgreedWithPaymentCheckByMail);
        }

        //Required Field validation #3
        [TestMethod()]
        public void RoutingNumberRFCheck()
        {
            var hasEligibilityDiagnostics = false;
            //Persist Payment Options
            var persistPaymentDTO = PersistPaymentDTO();
            var persistPaymentDetails = mEfileRepository.PersistIRSPaymentOption(persistPaymentDTO);
            //persistPaymentDetails.Item2
            hasEligibilityDiagnostics = persistPaymentDetails.Item2.Any(em => (em.ErrorCode == "Efile_RF3"));
            Assert.IsTrue(hasEligibilityDiagnostics);
        }
        
        ////Required Field validation #9
        //[TestMethod()]
        //public void EmailRFCheck()
        //{
        //    var hasEligibilityDiagnostics = false;
        //    //Persist Payment Options
        //    var createFiling = CreateEfile();
        //    createFiling.Email = null;
        //    TaxReturnData taxReturnData = new TaxReturnData();
        //    taxReturnData.TaxData = JsonConvert.SerializeObject(createFiling);
        //    var persistFiling = mEfileRepository.PersistFiling(userId, taxReturnData);
        //    var getUserDTO = new UserDTO();
        //    getUserDTO.UserId = userId;
        //    getUserDTO.UserDataId = taxReturnData.UserDataId;
        //    var getFiling = mEfileRepository.GetFiling(getUserDTO);
        //    if (getFiling.Email == null)
        //    {
        //        hasEligibilityDiagnostics = true;
        //    }
        //    Assert.IsTrue(hasEligibilityDiagnostics);
        //}

        //Required Field validation #14
        [TestMethod()]
        public void PinRFCheck()
        {
            var hasEligibilityDiagnostics = false;
            //Persist Payment Options
            var createIRSTransmission = PersisrIRSTransmission();
            createIRSTransmission.HavePriorYearPIN = true;
            createIRSTransmission.PrimaryPIN = null;
            createIRSTransmission.SpousePIN = null;
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(createIRSTransmission);
            var persistIRSTransmission = mEfileRepository.PersistIRSTranmission(userId, taxReturnData);
            UserDTO userDTO = new UserDTO() { UserId = persistIRSTransmission.Item1, UserDataId = taxReturnData.UserDataId };
            var getIRSTransmisson = mEfileRepository.GetPersonAndIRSTransmission(userDTO);
            if (getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.PrimaryPIN == null || getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.SpousePIN == null)
            {
                hasEligibilityDiagnostics = true;
            }
            Assert.IsTrue(hasEligibilityDiagnostics);
        }

        //Required Field validation #15
        [TestMethod()]
        public void PriorYearPinRFCheck()
        {
            var hasEligibilityDiagnostics = false;
            //Persist Payment Options
            var createIRSTransmission = PersisrIRSTransmission();
            createIRSTransmission.HavePriorYearPIN = false;
            createIRSTransmission.HavePriorYearAGI = true;
            createIRSTransmission.PrimaryPriorYearPIN = null;
            createIRSTransmission.SpousePriorYearPIN = null;
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(createIRSTransmission);
            var persistIRSTransmission = mEfileRepository.PersistIRSTranmission(userId, taxReturnData);
            UserDTO userDTO = new UserDTO() { UserId = persistIRSTransmission.Item1, UserDataId = taxReturnData.UserDataId };
            var getIRSTransmisson = mEfileRepository.GetPersonAndIRSTransmission(userDTO);
            if (getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.PrimaryPriorYearPIN == null || getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.SpousePriorYearPIN == null)
            {
                hasEligibilityDiagnostics = true;
            }
            Assert.IsTrue(hasEligibilityDiagnostics);
        }

        //Required Field validation #16
        [TestMethod()]
        public void PriorYearPinAndAGIRFCheck()
        {
            var hasEligibilityDiagnostics = false;
            //Persist Payment Options
            var createIRSTransmission = PersisrIRSTransmission();
            createIRSTransmission.HavePriorYearPIN = false;
            createIRSTransmission.HavePriorYearAGI = false;
            createIRSTransmission.HavePriorYearAGIAndPIN = true;
            createIRSTransmission.PrimaryTaxpayerEFIN = null;
            createIRSTransmission.SpouseEFIN = null;
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(createIRSTransmission);
            var persistIRSTransmission = mEfileRepository.PersistIRSTranmission(userId, taxReturnData);
            UserDTO userDTO = new UserDTO() { UserId = persistIRSTransmission.Item1, UserDataId = taxReturnData.UserDataId };
            var getIRSTransmisson = mEfileRepository.GetPersonAndIRSTransmission(userDTO);
            if (getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.PrimaryTaxpayerEFIN == null || getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.SpouseEFIN == null)
            {
                hasEligibilityDiagnostics = true;
            }
            Assert.IsTrue(hasEligibilityDiagnostics);
        }

        //Required Field validation #17
        [TestMethod()]
        public void FilingDateRFCheck()
        {
            var hasEligibilityDiagnostics = false;
            //Persist Payment Options
            var createIRSTransmission = PersisrIRSTransmission();
            createIRSTransmission.PrimaryTaxPayerFilingDate = null;
            createIRSTransmission.SpouseFilingDate = null;
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(createIRSTransmission);
            var persistIRSTransmission = mEfileRepository.PersistIRSTranmission(userId, taxReturnData);
            UserDTO userDTO = new UserDTO() { UserId = persistIRSTransmission.Item1, UserDataId = taxReturnData.UserDataId };
            var getIRSTransmisson = mEfileRepository.GetPersonAndIRSTransmission(userDTO);
            if (getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.PrimaryTaxPayerFilingDate == null || getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.SpouseFilingDate == null)
            {
                hasEligibilityDiagnostics = true;
            }
            Assert.IsTrue(hasEligibilityDiagnostics);
        }

        [TestMethod()]
        public void IPinRFCheck()
        {
            var hasEligibilityDiagnostics = false;
            //Persist Payment Options
            var createIRSTransmission = PersisrIRSTransmission();
            createIRSTransmission.HasReceivedIPINFromIRS = true;
            createIRSTransmission.PrimaryTaxPayerIPIN = null;
            createIRSTransmission.SpouseIPIN = null;
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(createIRSTransmission);
            var persistIRSTransmission = mEfileRepository.PersistIRSTranmission(userId, taxReturnData);
            UserDTO userDTO = new UserDTO() { UserId = persistIRSTransmission.Item1, UserDataId = taxReturnData.UserDataId };
            var getIRSTransmisson = mEfileRepository.GetPersonAndIRSTransmission(userDTO);
            if (getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.PrimaryTaxPayerIPIN == null || getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.SpouseIPIN == null)
            {
                hasEligibilityDiagnostics = true;
            }
            Assert.IsTrue(hasEligibilityDiagnostics);
        }

        //Required Field validation #18
        [TestMethod()]
        public void EFinRFCheck()
        {
            var hasEligibilityDiagnostics = false;
            //Persist Payment Options
            var createIRSTransmission = PersisrIRSTransmission();
            createIRSTransmission.TaxpayerEFINIssuedByIRS = null;
            createIRSTransmission.SpouseEFINIssuedByIRS = null;
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(createIRSTransmission);
            taxReturnData.TaxData = JsonConvert.SerializeObject(CreateEfile());
            var persistIRSTransmission = mEfileRepository.PersistIRSTranmission(userId, taxReturnData);
            UserDTO userDTO = new UserDTO() { UserId = persistIRSTransmission.Item1, UserDataId = taxReturnData.UserDataId };
            var getIRSTransmisson = mEfileRepository.GetPersonAndIRSTransmission(userDTO);
            if (getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.TaxpayerEFINIssuedByIRS == null || getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.SpouseEFINIssuedByIRS == null)
            {
                hasEligibilityDiagnostics = true;
            }
            Assert.IsTrue(hasEligibilityDiagnostics);
        }
        #endregion

        #region Business Validations
        //Business Validation #V1
        [TestMethod()]
        public void RoutingNumberValidationCheck()
        {
            var hasEligibilityDiagnostics = false;
            //Persist Payment Options
            var persistPaymentDTO = PersistPaymentDTO();
            persistPaymentDTO.IRS.BankDetails.RoutingTransitNumber = "123456789123";
            var persistPaymentDetails = mEfileRepository.PersistIRSPaymentOption(persistPaymentDTO);
            //persistPaymentDetails.Item2
            hasEligibilityDiagnostics = persistPaymentDetails.Item2.Any(em => (em.ErrorCode == "Efile_V1"));
            Assert.IsTrue(hasEligibilityDiagnostics);
        }

        //Business Validation #V2
        [TestMethod()]
        public void EmailValidationCheck()
        {
            var hasEligibilityDiagnostics = false;
            //Persist Payment Options
            var createFiling = CreateEfile();
            createFiling.Email = "yoga";
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(createFiling);
            var persistFiling = mEfileRepository.PersistFiling(userId, taxReturnData);
            if (persistFiling.Item2 != null)
            {
                foreach (var item in persistFiling.Item2)
                {
                    if (item.ErrorCode == "Efile_V2")
                    {
                        hasEligibilityDiagnostics = true;
                    }
                }
            }
            Assert.IsTrue(hasEligibilityDiagnostics);
        }

        //Business Validation #V9
        [TestMethod()]
        public void DateValidationCheck()
        {
            var hasEligibilityDiagnostics = false;
            //Persist Payment Options
            var createIRSTransmission = PersisrIRSTransmission();
            createIRSTransmission.FilingDate = new DateTime(2014, 02, 14);
            createIRSTransmission.PrimaryTaxPayerFilingDate = new DateTime(2014, 02, 14);
            createIRSTransmission.SpouseFilingDate = new DateTime(2014, 02, 14);
            createIRSTransmission.TaxpayerDateIssuedByIRS = new DateTime(2014, 02, 14);
            createIRSTransmission.SpouseDateIssuedByIRS = new DateTime(2014, 02, 14);
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(createIRSTransmission);
            var persistFiling = mEfileRepository.PersistIRSTranmission(userId, taxReturnData);
            UserDTO userDTO = new UserDTO() { UserId = persistFiling.Item1, UserDataId = taxReturnData.UserDataId };
            var getIRSTransmisson = mEfileRepository.GetPersonAndIRSTransmission(userDTO);
            if (getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.FilingDate != DateTime.Now || getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.PrimaryTaxPayerFilingDate != DateTime.Now || getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.SpouseFilingDate != DateTime.Now || getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.TaxpayerDateIssuedByIRS != DateTime.Now || getIRSTransmisson.Item3.FederalFiling.IRS.IRSTransmission.SpouseDateIssuedByIRS != DateTime.Now)
            {
                hasEligibilityDiagnostics = true;
            }
            Assert.IsTrue(hasEligibilityDiagnostics);
        }
        #endregion Business Validations

    }
}
