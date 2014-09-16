using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Dynamic;
using System.Linq;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace JTL.Tax1040.BusinessLogic.Test.Integration
{
    /// <summary>
    /// Summary description for IT_OtherIncomeRepository
    /// </summary>
    [TestClass]
    public class IT_OtherIncomeRepository
    {
        #region private local variables
        private static long userId;
        private long mUserDataId = 1;
        private static IPersonalInfoRepository mPersonalInfoRepository = new PersonalInfoRepository();
        private static IOtherIncomeRepository mOtherIncomeRepository = new OtherIncomeRepository();
        static TaxReturnData taxReturnData;
        static dynamic userInputData;
        IEnumerable<ErrorMessage> lstTaxObjectErrors = null;


        static ITaxReturnRepository mTaxReturnRepository;
        static IInterestIncomeRepository mInterestIncomeRepository;
        static dynamic userData;
        //static dynamic userInputData
        #endregion
        public IT_OtherIncomeRepository()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        #region test initialize
        [TestInitialize()]
        public void TestInitialize()
        {
           
            mTaxReturnRepository = new TaxReturnRepository();
            mPersonalInfoRepository = new PersonalInfoRepository();
            mInterestIncomeRepository = new InterestIncomeRepository();
            taxReturnData = new TaxReturnData();
            userData = new ExpandoObject();
            userInputData = new ExpandoObject();
            userId = IT_UserRepository.PersistNewUser();
        }
        #endregion

        #region Persist And Get Methods
        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        public void PersistOtherIncome()
        {
            //Persist
            var userDataId = 0L;
            List<ErrorMessage> errorMessageList;
            var actualOtherIncome = CreateOtherIncome();
            taxReturnData.TaxData = JsonConvert.SerializeObject(actualOtherIncome);
            taxReturnData.UserDataId = userDataId;
            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            Assert.AreEqual(0, userDataId);
            var expectedUserDataId = mOtherIncomeRepository.PersistOtherIncome(userData);

            //Get

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedUserDataId.Item1, userId);
            var otherIncome = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.OtherIncome;


            //Assert
            Assert.AreEqual(otherIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend, actualOtherIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);


        }

        //Added by Prasanna on 23 July 2014
        [TestMethod]
        public void DeteleAndPersistOtherIncome()
        {
            //Persist
            var userId = IT_UserRepository.PersistNewUser();
            var userDataId = 0L;
           
            var actualOtherIncome = CreateOtherIncome();
            taxReturnData.TaxData = JsonConvert.SerializeObject(actualOtherIncome);
            taxReturnData.UserDataId = userDataId;
            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            Assert.AreEqual(0, userDataId);
            var expectedUserDataId = mOtherIncomeRepository.PersistOtherIncome(userData);

            //Get

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedUserDataId.Item1, userId);
            var otherIncome = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.OtherIncome;


            //Assert
            Assert.AreEqual(otherIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend, actualOtherIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);


            //Delete
          
            UserDTO userDTO = new UserDTO();
            userDTO.UserId = userId;
            userDTO.UserDataId = expectedUserDataId.Item1;

            OtherIncomeType otherIncomeType = OtherIncomeType.AlaskaDividendIncome;

            mOtherIncomeRepository.DeleteAndPersistOtherIncome(userDTO.UserId, userDTO.UserDataId, otherIncomeType);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedUserDataId.Item1, userId);
            var otherIncomeDel = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.OtherIncome;

            //Assert
            Assert.IsNull(otherIncomeDel.AlaskaPermanentFundDividend);



        }

        //Added by Prasanna on 23 July 2014
        [TestMethod]
        public void GetOtherIncome()
        {
            //Persist

            var userDataId = 0L;
            
            var actualOtherIncome = CreateOtherIncome();
            taxReturnData.TaxData = JsonConvert.SerializeObject(actualOtherIncome);
            taxReturnData.UserDataId = userDataId;
            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            Assert.AreEqual(0, userDataId);
            var expectedUserDataId = mOtherIncomeRepository.PersistOtherIncome(userData);

            //Get

            UserDTO userDTO = new UserDTO();
            userDTO.UserId = userId;
            userDTO.UserDataId = expectedUserDataId.Item1;
            var otherIncome = mOtherIncomeRepository.GetOtherIncome(userDTO);


            //Assert
            Assert.IsNotNull(otherIncome.Item1);
        }

        //Added by Prasanna on 23 July 2014
        [TestMethod]
        public void GetOtherIncomeSummary()
        {
            //Persist

            var userDataId = 0L;
          
            var actualOtherIncome = CreateOtherIncome();
            taxReturnData.TaxData = JsonConvert.SerializeObject(actualOtherIncome);
            taxReturnData.UserDataId = userDataId;

      
            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            Assert.AreEqual(0, userDataId);
            var expectedUserDataId = mOtherIncomeRepository.PersistOtherIncome(userData);

            userInputData.userId = new ExpandoObject();
            userInputData.userDataId = new ExpandoObject();
           

            userInputData.userId.Value = userId;
            userInputData.userDataId.Value = expectedUserDataId.Item1;

            //Get
            var otherIncome = mOtherIncomeRepository.GetOtherIncomeSummary(userInputData);

            //Assert
            Assert.IsNotNull(otherIncome.Item1);

        }

        #endregion  Persist And Get Methods


        #region EligiilityRuleCheck
        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        public void HasStateAndLocalTaxDeductionPriorYear()
        {
            OtherIncome otherIncome = new OtherIncome()
            {
                StateOrLocalIncomeTaxRefunds = new StateOrLocalIncomeTaxRefunds()
                {
                    HasStateAndLocalTaxDeductionPriorYear = true
                }


            };
            // Persist
            var userDataId = 0L;

            
            taxReturnData.TaxData = JsonConvert.SerializeObject(otherIncome);
            taxReturnData.UserDataId = userDataId;


            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            Assert.AreEqual(0, userDataId);
            var expectedUserDataId = mOtherIncomeRepository.PersistOtherIncome(userData);


            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userData.userId,
      expectedUserDataId.Item1);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            lstTaxObjectErrors = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_OTHER_INCOME && err.MessageType.StartsWith("ER"));

            foreach (var errorMsg in lstTaxObjectErrors)
            {
                Assert.IsNotNull(errorMsg.ErrorCode);
            }

        }



        #endregion EligiilityRuleCheck

        #region RequiredFieldValidationsCheck
        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        public void TaxpayerNetBenefitsAndTaxpayerNetBenefitsNotGiven()
        {
            var hasEligibilityDiagnostics = false;
            OtherIncome otherIncome = new OtherIncome()
            {
                HasSsbAndRrb = true,
                
                SSB = new SocialSecurityBenefits()
                {
                    TaxpayerNetBenefits = null
                 
                },
                RRB = new RailroadRetirementIncome()
                {
                    TaxpayerNetBenefits = null
                }

            };
            // Persist
            var userDataId = 0L;

           
            taxReturnData.TaxData = JsonConvert.SerializeObject(otherIncome);
            taxReturnData.UserDataId = userDataId;


            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            Assert.AreEqual(0, userDataId);
            var expectedUserDataId = mOtherIncomeRepository.PersistOtherIncome(userData);


            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userData.userId,
    expectedUserDataId.Item1);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "OtherIncome_RF1"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }



        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        public void PrimaryTaxpayerAlaskaFundDividendAndSpouseAlaskaFundDividendNotGiven()
        {
            var hasEligibilityDiagnostics = false;
            OtherIncome otherIncome = new OtherIncome()
            {
                HasAlaskaPermanantFund = true,
                AlaskaPermanentFundDividend = new AlaskaPermanentFundDividend()
                {
                    PrimaryTaxpayerAlaskaFundDividend = null,
                    SpouseAlaskaFundDividend = null
                }

            };
            // Persist
            var userDataId = 0L;

            
            taxReturnData.TaxData = JsonConvert.SerializeObject(otherIncome);
            taxReturnData.UserDataId = userDataId;


            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            Assert.AreEqual(0, userDataId);
            var expectedUserDataId = mOtherIncomeRepository.PersistOtherIncome(userData);


            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userData.userId,
    expectedUserDataId.Item1);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "OtherIncome_RF2"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        public void HasClaimedItemizedDeductionPriorYearNotGiven()
        {
            var hasEligibilityDiagnostics = false;
            OtherIncome otherIncome = new OtherIncome()
            {
                HasStateTaxRefund = true,
                StateOrLocalIncomeTaxRefunds = new StateOrLocalIncomeTaxRefunds()
                {
                    HasClaimedItemizedDeductionPriorYear = null
                }

            };
            // Persist
            var userDataId = 0L;

           
            taxReturnData.TaxData = JsonConvert.SerializeObject(otherIncome);
            taxReturnData.UserDataId = userDataId;


            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            Assert.AreEqual(0, userDataId);
            var expectedUserDataId = mOtherIncomeRepository.PersistOtherIncome(userData);


            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userData.userId,
    expectedUserDataId.Item1);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "OtherIncome_RF3"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        public void HasStateAndLocalTaxDeductionPriorYearNotGiven()
        {
            var hasEligibilityDiagnostics = false;
            OtherIncome otherIncome = new OtherIncome()
            {
                HasStateTaxRefund = true,
                StateOrLocalIncomeTaxRefunds = new StateOrLocalIncomeTaxRefunds()
                {
                    HasClaimedItemizedDeductionPriorYear = true,
                    HasStateAndLocalTaxDeductionPriorYear = null
                }

            };
            // Persist
            var userDataId = 0L;

            
            taxReturnData.TaxData = JsonConvert.SerializeObject(otherIncome);
            taxReturnData.UserDataId = userDataId;


            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            Assert.AreEqual(0, userDataId);
            var expectedUserDataId = mOtherIncomeRepository.PersistOtherIncome(userData);


            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userData.userId,
    expectedUserDataId.Item1);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "OtherIncome_RF4"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }
        #endregion RequiredFieldValidationsCheck

        #region BusinessRulesCheck
        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        public void TaxPayerFederalTaxWithheldGreaterThanTaxpayerNetBenefits()
        {
        
            OtherIncome otherIncome = new OtherIncome()
            {
                
                SSB = new SocialSecurityBenefits()
                {
                    TaxpayerNetBenefits = 500,
                    TaxPayerFederalTaxWithheld = 1000,
                    SpouseNetBenefits = 500,
                    SpouseFederalTaxWithheld = 1000
                }

            };
            // Persist
            var userDataId = 0L;

           
            taxReturnData.TaxData = JsonConvert.SerializeObject(otherIncome);
            taxReturnData.UserDataId = userDataId;


            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            Assert.AreEqual(0, userDataId);
            var expectedUserDataId = mOtherIncomeRepository.PersistOtherIncome(userData);



            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userData.userId,
    expectedUserDataId.Item1);

            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            lstTaxObjectErrors = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_UNEMPLOYMENT_COMPENSATION && err.MessageType.StartsWith("BR"));

            foreach (var errorMsg in lstTaxObjectErrors)
            {
                Assert.IsNotNull(errorMsg.ErrorCode);
            }
        }
        #endregion BusinessRulesCheck




        #region Helper Method
        //Added by Prasanna on 07 July 2014
        public static OtherIncome CreateOtherIncome()
        {
            
            OtherIncome otherIncome = new OtherIncome()
            {
                HasSsbAndRrb = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                HasAlaskaPermanantFund = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),

                HasStateTaxRefund = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),

                HasClaimedItemizedDeductionPriorYear = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),

                HasStateAndLocalTaxDeductionPriorYear = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),

                AlaskaPermanentFundDividend = new AlaskaPermanentFundDividend()
                {
                    PrimaryTaxpayerAlaskaFundDividend = Utilities.CreateRandomNumber(0, 20),
                    SpouseAlaskaFundDividend = Utilities.CreateRandomNumber(0, 20)
                },

                StateOrLocalIncomeTaxRefunds = new StateOrLocalIncomeTaxRefunds()
                {
                    HasClaimedItemizedDeductionPriorYear = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),

                    HasStateAndLocalTaxDeductionPriorYear = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean()
                },

                SSB = new SocialSecurityBenefits()
                {
                    HasTaxableSocialSecurityBenefits = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),

                    TaxpayerNetBenefits = Utilities.CreateRandomNumber(0, 20),
                    TaxPayerFederalTaxWithheld = Utilities.CreateRandomNumber(0, 20),
                    SpouseNetBenefits = Utilities.CreateRandomNumber(0, 20),
                    SpouseFederalTaxWithheld = Utilities.CreateRandomNumber(0, 20)
                },

                RRB = new RailroadRetirementIncome()
                {

                    NetBenefits = Utilities.CreateRandomNumber(0, 20),
                    FederalTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 20),
                    TaxpayerNetBenefits = Utilities.CreateRandomNumber(0, 20),
                    TaxPayerFederalTaxWithheld = Utilities.CreateRandomNumber(0, 20),
                    SpouseNetBenefits = Utilities.CreateRandomNumber(0, 20),
                    SpouseFederalTaxWithheld = Utilities.CreateRandomNumber(0, 20)
                }

            };

            return otherIncome;
        }
           
            
        #endregion
    }
}
