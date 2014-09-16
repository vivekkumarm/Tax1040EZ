using System;
using System.Dynamic;
using System.Linq;
using JTL.Tax1040.Core.Process;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JTL.Tax1040.BusinessObject;
using Newtonsoft.Json;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessLogic.Test
{
    [TestClass]
    public class IT_TaxesAndWrapUpRepository
    {
        static ITaxesAndWrapUpRepository mTaxesAndWrapUpRepository;
        private static TaxReturnData mTaxReturnData;
        private static long mUserId;
        private static PersonalInfoRepository mPersonalInfoRepository;
        private static W2Repository mW2Repository;
        private static InterestIncomeRepository mInterestIncomeRepository;
        private static UnemploymentRepository mUnemploymentRepository;
        private static dynamic mUserData;

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mTaxesAndWrapUpRepository = new TaxesAndWrapUpRepository();
            mPersonalInfoRepository = new PersonalInfoRepository();
            mW2Repository = new W2Repository();
            mInterestIncomeRepository =new InterestIncomeRepository();
            mUnemploymentRepository = new UnemploymentRepository();
            mUserData = new ExpandoObject();
            mUserId = IT_UserRepository.PersistNewUser();
            mTaxReturnData = new TaxReturnData();

        }

        /// <summary>
        ///Persist the TaxesAndWrapUp WithData
        /// </summary>
        [TestMethod]
        public void PersistTaxesAndWrapUpWithData()
        {

            //Prepare Taxes and Wrap Up 
            var expectedTaxesAndWrapUp = CreateTaxesAndWrapUp();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedTaxesAndWrapUp);

            //Presist Taxes and Wrap Up 
            var expectedTaxesAndWrapUpData = mTaxesAndWrapUpRepository.PersistTaxesAndWrapUpData(mUserId, mTaxReturnData);

            //Get Taxes and Wrap Up 
            var userDTO = new UserDTO() {UserDataId = expectedTaxesAndWrapUpData.Item1, UserId = mUserId};
            var actualTaxesAndWrapUp = mTaxesAndWrapUpRepository.GetTaxAndWrapup(userDTO);

            Assert.AreEqual(expectedTaxesAndWrapUp.FederalExtensionAmount,actualTaxesAndWrapUp.Item1.FederalExtensionAmount);
            Assert.AreEqual(expectedTaxesAndWrapUp.BankDetails.AccountNumber,actualTaxesAndWrapUp.Item1.BankDetails.AccountNumber);
            Assert.AreEqual(expectedTaxesAndWrapUp.ThirdPartyDesignee.DesigneeName,actualTaxesAndWrapUp.Item1.ThirdPartyDesignee.DesigneeName);


        }

        /// <summary>
        ///Persist the TaxesAndWrapUp BusinessValidation WithoutFederalDate
        /// </summary>
        [TestMethod]
        public void PersistTaxesAndWrapUpBusinessValidationWithoutFederalDate()
        {
            //Prepare Taxes and Wrap Up 
            var expectedTaxesAndWrapUp = CreateTaxesAndWrapUpNoFilingDate();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedTaxesAndWrapUp);

            //Persist Taxes and Wrap Up 
            var expectedTaxesAndWrapUpData = mTaxesAndWrapUpRepository.PersistTaxesAndWrapUpData(mUserId, mTaxReturnData);

            //Get Taxes and Wrap Up 
            var userDTO = new UserDTO { UserDataId = expectedTaxesAndWrapUpData.Item1, UserId = mUserId };
            var actualTaxesAndWrapUp = mTaxesAndWrapUpRepository.GetFederalTaxSummary(userDTO);
            bool isErroravailable = actualTaxesAndWrapUp.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF11");
           
            Assert.IsTrue(isErroravailable);
        }

        /// <summary>
        ///Persist the TaxesAndWrapUp BusinessValidation WithoutData
        /// </summary>
        [TestMethod]
        public void PersistTaxesAndWrapUpBusinessValidationWithoutData()
        {

            //Prepare Taxes and Wrap Up 
            var expectedTaxesAndWrapUp = CreateTaxesAndWrapWithoutData();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedTaxesAndWrapUp);

            //Persist Taxes and Wrap Up 
            var expectedTaxesAndWrapUpData = mTaxesAndWrapUpRepository.PersistTaxesAndWrapUpData(mUserId, mTaxReturnData);

            //Get Taxes and Wrap Up 
            var userDTO = new UserDTO { UserDataId = expectedTaxesAndWrapUpData.Item1, UserId = mUserId };
            var actualTaxesAndWrapUp = mTaxesAndWrapUpRepository.GetFederalTaxSummary(userDTO);

            bool isExtensionFileddate = actualTaxesAndWrapUp.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF11");
            bool isExtensionamount = actualTaxesAndWrapUp.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF1");
            bool isFilingdate = actualTaxesAndWrapUp.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF3");
            bool isBankName = actualTaxesAndWrapUp.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF4");
            bool isBankRoutingNumber = actualTaxesAndWrapUp.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF5");
            bool isAccountNumber = actualTaxesAndWrapUp.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF6");


            Assert.IsTrue(isExtensionFileddate);
            Assert.IsTrue(isExtensionamount);
            Assert.IsTrue(isFilingdate);
            Assert.IsTrue(isBankName);
            Assert.IsTrue(isBankRoutingNumber);
            Assert.IsTrue(isAccountNumber);
        }



        /// <summary>
        ///Gets the tax and wrapup info by userid and Userdataid
        /// </summary>
        [TestMethod]
        public void GetTaxAndWrapup()
        {
            var actualTaxesAndWrapUp = mTaxesAndWrapUpRepository.GetTaxAndWrapup(GetUserDTO());
            Assert.IsNotNull(actualTaxesAndWrapUp);
        }

       

        /// <summary>
        ///Gets the Federal Tax Summary  by userid and Userdataid
        /// </summary>
        [TestMethod]
        public void GetFederalTaxSummary()
        {
            var actualTaxesAndWrapUp = mTaxesAndWrapUpRepository.GetFederalTaxSummary(GetUserDTO());

            Assert.IsNotNull(actualTaxesAndWrapUp.Item5);
        }

        /// <summary>
        ///Gets the Genernate1040EZForm  by userid and Userdataid
        /// </summary>
        [TestMethod]
        public void Genernate1040EZForm()
        {
            mTaxesAndWrapUpRepository.Genernate1040EZForm(GetUserDTO());
        }

        #region Eligibility Rules

        /// <summary>
        /// ER1 - if check box "Taxes for Household Employee Wages Paid more than $1,800" is checked
        /// ER2 - if check box "Alternative Minimum Taxes and  AMT Adjustment" is checked
        /// ER3 - if check box "Additional Social Security or Medicare Taxes" is checked
        /// ER4 - if check box "Federal Quarterly Estimates Paid" is checked
        /// </summary>
        [TestMethod]
        public void ValidateER1ER2ER3ER4()
        {
            //Prepare Taxes and Wrap Up 
            var expectedTaxesAndWrapUp = CreateTaxesAndWrapWithoutData();
            expectedTaxesAndWrapUp.HasOwedHouseholdEmploymentTax = true;
            expectedTaxesAndWrapUp.HasAlternativeMinimumTax = true;
            expectedTaxesAndWrapUp.HasAdditionalSocialSecurityOrMedicareTax = true;
            expectedTaxesAndWrapUp.HasFederalQuarterlyEstimatesPaid = true;

            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedTaxesAndWrapUp);

            //Persist Taxes and Wrap Up 
            var expectedTaxesAndWrapUpData = mTaxesAndWrapUpRepository.PersistTaxesAndWrapUpData(mUserId, mTaxReturnData);

            //Get Taxes and Wrap Up
            BusinessObject.Tax1040 actualTaxesAndWrapUpData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedTaxesAndWrapUpData.Item1);


            Assert.IsTrue(actualTaxesAndWrapUpData.ErrorMessages.Any(er => er.ErrorCode.Equals("TaxesAndWrapUp_ER1")));
            Assert.IsTrue(actualTaxesAndWrapUpData.ErrorMessages.Any(er => er.ErrorCode.Equals("TaxesAndWrapUp_ER2")));
            Assert.IsTrue(actualTaxesAndWrapUpData.ErrorMessages.Any(er => er.ErrorCode.Equals("TaxesAndWrapUp_ER3")));
            Assert.IsTrue(actualTaxesAndWrapUpData.ErrorMessages.Any(er => er.ErrorCode.Equals("TaxesAndWrapUp_ER4")));

        }

        /// <summary>
        /// ER5 - if check box "Taxes for Household Employee Wages Paid more than $1,800" is checked
        /// </summary>
        [TestMethod]
        public void TaxableIncomeGreatherthanLakhDollars()
        {

            //Persist Personal Info
            const long mUserDataId = 0L;
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedPrimaryTaxpayer = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);

            //Persist W2
            var wages = IT_W2Repository.CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            wages.WagesAmount = 41812.00;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(wages);
            mTaxReturnData.UserDataId = expectedPrimaryTaxpayer.Item1;
            var expectedWages = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);

            //Persist Interest Income INT
            var expectedForm1099INT = IT_InterestIncomeForm1099INTRepository.CreateForm1099INT(OwnerType.PrimaryTaxPayer);
            expectedForm1099INT.InterestIncome = 100000.00;
            mTaxReturnData.UserDataId = expectedWages.UserDataId;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099INT);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            var expectedUserData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);

            //Persist Form 1099G
            var expectedForm1099G = IT_UnemploymentRepository.CreateForm1099G();
            expectedForm1099G.UnEmploymentCompensation = 1580.00;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099G);
            mTaxReturnData.UserDataId = expectedUserData.UserDataId;
            var expectedForm1099GData = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Persist Taxes and Wrap Up 
            var expectedTaxesAndWrapUp = CreateTaxesAndWrapWithoutData();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedTaxesAndWrapUp);
            mTaxReturnData.UserDataId = expectedForm1099GData.UserDataId;
            var expectedTaxesAndWrapUpData = mTaxesAndWrapUpRepository.PersistTaxesAndWrapUpData(mUserId, mTaxReturnData);
            var userDTO = new UserDTO() { UserId = mUserId, UserDataId = expectedTaxesAndWrapUpData.Item1 };

            //Get Taxes and Wrap Up
            var actualTaxesAndWrapUp = mTaxesAndWrapUpRepository.GetFederalTaxSummary(userDTO);
            BusinessObject.Tax1040 actualTaxesAndWrapUpData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, expectedTaxesAndWrapUpData.Item1);
            Assert.IsTrue(actualTaxesAndWrapUpData.ErrorMessages.Any(er => er.ErrorCode.Equals("TaxesAndWrapUp_ER5")));

        }

        #endregion Eligibility Rules
        
        #region HelperMethod

        /// <summary>
        ///Gets the tax and wrapup  Without data
        /// </summary>
        public static TaxesAndPenalties CreateTaxesAndWrapWithoutData()
        {
            return new TaxesAndPenalties()
            {
                HasFiledForm4868 = true,
                FederalExtensionFiledDate = null,
                HasPaidFederalExtensionWithForm4868 = true,
                FederalExtensionAmount = null,
                FederalExtensionAmountPaidDate = new DateTime(2015, 03, 16),
                IsFilingReturnAfterDueDate = true,
                FilingDate = null,
                HasToDepositTaxRefundsToBankAccount = null,
                HasThirdPartyDesignee = null,
                InCareOf = string.Empty,
                InCareOfPhoneNumber = string.Empty,
                BankDetails = new BankDetails()
                {
                    BankName = null,
                    RoutingTransitNumber = null,
                    AccountNumber = null,
                    BankAccountTypeCode = AccountType.Saving,

                },
                ThirdPartyDesignee = new ThirdPartyDesignee()
                {
                    DesigneeName = "ta1040designee name",
                    PIN = "32459",
                    PhoneNumber = "339-233-2343"
                }
            };
        }

        /// <summary>
        ///Gets the tax and wrapup  With data
        /// </summary>
        public static TaxesAndPenalties CreateTaxesAndWrapUp()
        {
            return new TaxesAndPenalties()
            {
                HasFiledForm4868 = true,
                FederalExtensionFiledDate = new DateTime(2015, 04, 14),
                HasPaidFederalExtensionWithForm4868 = true,
                FederalExtensionAmount = 100,
                FederalExtensionAmountPaidDate = new DateTime(2015, 03, 14),
                IsFilingReturnAfterDueDate = true,
                FilingDate = new DateTime(2015, 05, 14),
                HasToDepositTaxRefundsToBankAccount = null,
                HasThirdPartyDesignee = null,
                InCareOf = string.Empty,
                InCareOfPhoneNumber = string.Empty,
                BankDetails = new BankDetails()
                {
                    BankName = "Bank OF america",
                    RoutingTransitNumber = "321070007",
                    AccountNumber = "523234523",
                    BankAccountTypeCode = AccountType.Saving,

                },
                ThirdPartyDesignee = new ThirdPartyDesignee()
                {
                    DesigneeName = "ta1040designee name",
                    PIN = "32459",
                    PhoneNumber = "339-233-2343"
                }
            };
        }

        /// <summary>
        ///Gets the tax and wrapup  without FederalExtensionFiledDate
        /// </summary>
        public static TaxesAndPenalties CreateTaxesAndWrapUpNoFilingDate()
        {
            return new TaxesAndPenalties()
            {
                HasFiledForm4868 = true,
                FederalExtensionFiledDate = null,
                HasPaidFederalExtensionWithForm4868 = true,
                FederalExtensionAmount = 100,
                FederalExtensionAmountPaidDate = new DateTime(2015, 03, 14),
                IsFilingReturnAfterDueDate = true,
                FilingDate = new DateTime(2015, 05, 14),
                HasToDepositTaxRefundsToBankAccount = null,
                HasThirdPartyDesignee = null,
                InCareOf = string.Empty,
                InCareOfPhoneNumber = string.Empty,
                BankDetails = new BankDetails()
                {
                    BankName = "Bank OF america",
                    RoutingTransitNumber = "321070007",
                    AccountNumber = "523234523",
                    BankAccountTypeCode = AccountType.Saving,

                },
                ThirdPartyDesignee = new ThirdPartyDesignee()
                {
                    DesigneeName = "ta1040designee name",
                    PIN = "32459",
                    PhoneNumber = "339-233-2343"
                }
            };
        }


        /// <summary>
        ///Gets the userid and Userdataid
        /// </summary>
        public static UserDTO GetUserDTO()
        {
            //Prepare Taxes and Wrap Up 
            var expectedTaxesAndWrapUp = CreateTaxesAndWrapUp();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedTaxesAndWrapUp);

            //Persist Taxes and Wrap Up 
            var expectedTaxesAndWrapUpData = mTaxesAndWrapUpRepository.PersistTaxesAndWrapUpData(mUserId, mTaxReturnData);

            //Get Taxes and Wrap Up 
            var userDTO = new UserDTO { UserDataId = expectedTaxesAndWrapUpData.Item1, UserId = mUserId };

            userDTO.UserId = mUserId;
            userDTO.UserDataId = expectedTaxesAndWrapUpData.Item1;

            return userDTO;
        }

        #endregion HelperMethod
    }
}
