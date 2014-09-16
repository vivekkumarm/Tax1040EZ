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

        private static long mUserId;
        //private long mUserDataId = 1;
        private static IPersonalInfoRepository mPersonalInfoRepository;
        private static IOtherIncomeRepository mOtherIncomeRepository;
        static ITaxReturnRepository mTaxReturnRepository;
        static IInterestIncomeRepository mInterestIncomeRepository;
        static TaxReturnData mTaxReturnData;
        static dynamic mUserInputData;
        IEnumerable<ErrorMessage> mLstTaxObjectErrors = null;
        static dynamic mUserData;
   

        #endregion


        #region test initialize
        [TestInitialize()]
        [TestCategory("OtherIncome")]
        public void TestInitialize()
        {
            mOtherIncomeRepository = new OtherIncomeRepository();
            mTaxReturnRepository = new TaxReturnRepository();
            mPersonalInfoRepository = new PersonalInfoRepository();
            mInterestIncomeRepository = new InterestIncomeRepository();
            mTaxReturnData = new TaxReturnData();
            mUserData = new ExpandoObject();
            mUserInputData = new ExpandoObject();
            mUserId = IT_UserRepository.PersistNewUser();
        }
        #endregion

        #region Persist And Get Methods
        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        [TestCategory("OtherIncome")]
        public void PersistOtherIncome()
        {
            //Prepare Other Income
            var expectedOtherIncome = CreateOtherIncome();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedOtherIncome);

            //Persist Other Income
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            var actualOtherIncomeData = mOtherIncomeRepository.PersistOtherIncome(mUserData);

            //Get  Other Income
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(actualOtherIncomeData.Item1, mUserId);
            var actualotherIncome = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.OtherIncome;

            Assert.AreEqual(expectedOtherIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend, actualotherIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);
            Assert.AreEqual(expectedOtherIncome.RRB.FederalTaxWithholdingAmount, actualotherIncome.RRB.FederalTaxWithholdingAmount);
        }

        //Added by Prasanna on 23 July 2014
        [TestMethod]
        [TestCategory("OtherIncome")]
        public void DeteleAndPersistOtherIncome()
        {
            
            //Prepare Other Income
            var expectedOtherIncome = CreateOtherIncome();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedOtherIncome);

            //Persist Other Income
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            var expectedOtherIncomeData = mOtherIncomeRepository.PersistOtherIncome(mUserData);

            //Delete Other Income
            var userDTO = new UserDTO {UserId = mUserId, UserDataId = expectedOtherIncomeData.Item1};
            const OtherIncomeType otherIncomeType = OtherIncomeType.AlaskaDividendIncome;
            mOtherIncomeRepository.DeleteAndPersistOtherIncome(userDTO.UserId, userDTO.UserDataId, otherIncomeType);
            
            //Get Other Income
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedOtherIncomeData.Item1, mUserId);
            var actualOtherIncome = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.OtherIncome;

            Assert.IsNull(actualOtherIncome.AlaskaPermanentFundDividend);

        }

        //Added by Prasanna on 23 July 2014
        [TestMethod]
        [TestCategory("OtherIncome")]
        public void GetOtherIncome()
        {
            //Prepare Other Income
            var expectedOtherIncome = CreateOtherIncome();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedOtherIncome);

            //Persist Other Income
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            var actualOtherIncomeData = mOtherIncomeRepository.PersistOtherIncome(mUserData);

            //Get Other Income
            var userDTO = new UserDTO {UserId = mUserId, UserDataId = actualOtherIncomeData.Item1};
            var actualOtherIncome = mOtherIncomeRepository.GetOtherIncome(userDTO);

            Assert.AreEqual(expectedOtherIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend, actualOtherIncome.Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);
            Assert.AreEqual(expectedOtherIncome.SSB.SpouseFederalTaxWithheld,actualOtherIncome.Item1.SSB.SpouseFederalTaxWithheld);
        }

        //Added by Prasanna on 23 July 2014
        [TestMethod]
        [TestCategory("OtherIncome")]
        public void GetOtherIncomeSummary()
        {
            //Prepare Other Income
            var expectedOtherIncome = CreateOtherIncome();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedOtherIncome);

            //Persist Other Income
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            var actualOtherIncomeData = mOtherIncomeRepository.PersistOtherIncome(mUserData);

            //Get Other Income
            mUserInputData.userId = new ExpandoObject();
            mUserInputData.userDataId = new ExpandoObject();
            mUserInputData.userId.Value = mUserId;
            mUserInputData.userDataId.Value = actualOtherIncomeData.Item1;
            var otherIncome = mOtherIncomeRepository.GetOtherIncomeSummary(mUserInputData);
            var actualOtherIncome = (OtherIncome)otherIncome.Item1;
            
            Assert.AreEqual(expectedOtherIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend,actualOtherIncome.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);
            Assert.AreEqual(expectedOtherIncome.RRB.FederalTaxWithholdingAmount,actualOtherIncome.RRB.FederalTaxWithholdingAmount);
            Assert.AreEqual(expectedOtherIncome.HasSsbAndRrb, actualOtherIncome.HasSsbAndRrb);

           
        }

        #endregion  Persist And Get Methods


        #region EligiilityRuleCheck
        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        [TestCategory("OtherIncome")]
        public void HasStateAndLocalTaxDeductionPriorYear()
        {
            //Prepare Other Income
            var expectedOtherIncome = new OtherIncome()
            {
                StateOrLocalIncomeTaxRefunds = new StateOrLocalIncomeTaxRefunds()
                {
                    HasStateAndLocalTaxDeductionPriorYear = true
                },
                HasClaimedItemizedDeductionPriorYear = true,
                HasStateAndLocalTaxDeductionPriorYear = true

            };
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedOtherIncome);

            //Persist Other Income
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            var actualOtherIncomeData = mOtherIncomeRepository.PersistOtherIncome(mUserData);

            //Get Other Income
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserData.userId,
            actualOtherIncomeData.Item1);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            mLstTaxObjectErrors = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_OTHER_INCOME && err.MessageType.StartsWith("ER"));
            foreach (var actualOtherIncome in mLstTaxObjectErrors)
            {
                Assert.IsNotNull(actualOtherIncome.ErrorCode);
            }

        }



        #endregion EligiilityRuleCheck

        #region RequiredFieldValidationsCheck
        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        [TestCategory("OtherIncome")]
        public void TaxpayerNetBenefitsAndTaxpayerNetBenefitsNotGiven()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Other Income
            var expectedOtherIncome = new OtherIncome()
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
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedOtherIncome);

            //Persist Other Income
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            var actualOtherIncomeData = mOtherIncomeRepository.PersistOtherIncome(mUserData);

            //Get Other Income
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserData.userId,
            actualOtherIncomeData.Item1);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "OtherIncome_RF1"));
            Assert.IsTrue(hasEligibilityDiagnostics);
        }



        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        [TestCategory("OtherIncome")]
        public void PrimaryTaxpayerAlaskaFundDividendAndSpouseAlaskaFundDividendNotGiven()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Other Income
            var expectedOtherIncome = new OtherIncome()
            {
                HasAlaskaPermanantFund = true,
                AlaskaPermanentFundDividend = new AlaskaPermanentFundDividend()
                {
                    PrimaryTaxpayerAlaskaFundDividend = null,
                    SpouseAlaskaFundDividend = null
                }

            };
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedOtherIncome);

            //Persist Other Income
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            var actualOtherIncomeData = mOtherIncomeRepository.PersistOtherIncome(mUserData);

            //Get Other Income
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserData.userId,
            actualOtherIncomeData.Item1);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "OtherIncome_RF2"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        [TestCategory("OtherIncome")]
        public void HasClaimedItemizedDeductionPriorYearNotGiven()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Other Income
            var expectedOtherIncome = new OtherIncome()
            {
                HasStateTaxRefund = true,
                StateOrLocalIncomeTaxRefunds = new StateOrLocalIncomeTaxRefunds()
                {
                    HasClaimedItemizedDeductionPriorYear = null
                }

            };
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedOtherIncome);

            //Persist Other Income
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            var actualOtherIncomeData = mOtherIncomeRepository.PersistOtherIncome(mUserData);


            //Get Other Income
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserData.userId,
            actualOtherIncomeData.Item1);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "OtherIncome_RF3"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        [TestCategory("OtherIncome")]
        public void HasStateAndLocalTaxDeductionPriorYearNotGiven()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Other Income
            var expectedOtherIncome = new OtherIncome()
            {
                HasStateTaxRefund = true,
                StateOrLocalIncomeTaxRefunds = new StateOrLocalIncomeTaxRefunds()
                {
                    HasClaimedItemizedDeductionPriorYear = true,
                    HasStateAndLocalTaxDeductionPriorYear = null
                }

            };
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedOtherIncome);

            //Persist Other Income
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            var actualOtherIncomeData = mOtherIncomeRepository.PersistOtherIncome(mUserData);


            //Get Other Income
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserData.userId,
            actualOtherIncomeData.Item1);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "OtherIncome_RF4"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }
        #endregion RequiredFieldValidationsCheck

        #region BusinessRulesCheck
        //Added by Prasanna on 23 July 2014
        [TestMethod()]
        [TestCategory("OtherIncome")]
        public void TaxPayerFederalTaxWithheldGreaterThanTaxpayerNetBenefits()
        {
            //Prepare Other Income
            var expectedOtherIncome = new OtherIncome()
            {
                
                SSB = new SocialSecurityBenefits()
                {
                    TaxpayerNetBenefits = 500,
                    TaxPayerFederalTaxWithheld = 1000,
                    SpouseNetBenefits = 500,
                    SpouseFederalTaxWithheld = 1000
                }

            };
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedOtherIncome);

            //Persist Other Income
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            var actualOtherIncomeData = mOtherIncomeRepository.PersistOtherIncome(mUserData);


            //Get Other Income
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserData.userId,
            actualOtherIncomeData.Item1);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            mLstTaxObjectErrors = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_UNEMPLOYMENT_COMPENSATION && err.MessageType.StartsWith("BR"));
            foreach (var errorMsg in mLstTaxObjectErrors)
            {
                Assert.IsNotNull(errorMsg.ErrorCode);
            }
        }
        #endregion BusinessRulesCheck




        #region Helper Method
        //Added by Prasanna on 07 July 2014
        public static OtherIncome CreateOtherIncome()
        {
            
            var otherIncome = new OtherIncome()
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
