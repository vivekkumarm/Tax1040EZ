using System;
using System.Linq;
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
        static long userId = 0;
        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mTaxesAndWrapUpRepository = new TaxesAndWrapUpRepository();
            userId = IT_UserRepository.PersistNewUser();
        }

        /// <summary>
        ///Persist the TaxesAndWrapUp WithData
        /// </summary>
        [TestMethod]
        public void PersistTaxesAndWrapUpWithData()
        {
            var userDataId = 0L;
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(CreateTaxesAndWrapUp());

            var value = mTaxesAndWrapUpRepository.PersistTaxesAndWrapUpData(userId, taxReturnData);

            Assert.AreNotEqual(0, value.Item1);
        }

        /// <summary>
        ///Persist the TaxesAndWrapUp BusinessValidation WithoutFederalDate
        /// </summary>
        [TestMethod]
        public void PersistTaxesAndWrapUpBusinessValidationWithoutFederalDate()
        {

            var userDataId = 0L;
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(CreateTaxesAndWrapUpNoFilingDate());

            var value = mTaxesAndWrapUpRepository.PersistTaxesAndWrapUpData(userId, taxReturnData);

            Assert.AreNotEqual(0, value.Item1);

            UserDTO userdto = new UserDTO();
            userdto.UserDataId = value.Item1;
            userdto.UserId = userId;

            var result = mTaxesAndWrapUpRepository.GetFederalTaxSummary(userdto);

            bool isErroravailable = result.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF11");

            Assert.IsTrue(isErroravailable);
        }

        /// <summary>
        ///Persist the TaxesAndWrapUp BusinessValidation WithoutData
        /// </summary>
        [TestMethod]
        public void PersistTaxesAndWrapUpBusinessValidationWithoutData()
        {
            var userDataId = 0L;
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(CreateTaxesAndWrapWithoutData());

            var value = mTaxesAndWrapUpRepository.PersistTaxesAndWrapUpData(userId, taxReturnData);

            Assert.AreNotEqual(0, value.Item1);

            UserDTO userdto = new UserDTO();
            userdto.UserDataId = value.Item1;
            userdto.UserId = userId;

            var result = mTaxesAndWrapUpRepository.GetFederalTaxSummary(userdto);

            bool isExtensionFileddate = result.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF11");
            bool isExtensionamount = result.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF1");
            bool isFilingdate = result.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF3");
            bool isBankName = result.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF4");
            bool isBankRoutingNumber = result.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF5");
            bool isAccountNumber = result.Item2.Any(a => a.ErrorCode == "TaxesAndWrapUp_RF6");


            Assert.IsTrue(isExtensionFileddate);
            Assert.IsTrue(isExtensionamount);
            Assert.IsTrue(isFilingdate);
            Assert.IsTrue(isBankName);
            Assert.IsTrue(isBankRoutingNumber);
            Assert.IsTrue(isAccountNumber);
        }

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
        ///Gets the tax and wrapup info by userid and Userdataid
        /// </summary>
        [TestMethod]
        public void GetTaxAndWrapup()
        {
            var result = mTaxesAndWrapUpRepository.GetTaxAndWrapup(GetUserDTO());
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///Gets the userid and Userdataid
        /// </summary>
        public static UserDTO GetUserDTO()
        {
            var userDataId = 0L;
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(CreateTaxesAndWrapUp());
            var value = mTaxesAndWrapUpRepository.PersistTaxesAndWrapUpData(userId, taxReturnData);
            UserDTO userdto = new UserDTO();

            userdto.UserId = userId;
            userdto.UserDataId = value.Item1;

            return userdto;
        }

        /// <summary>
        ///Gets the Federal Tax Summary  by userid and Userdataid
        /// </summary>
        [TestMethod]
        public void GetFederalTaxSummary()
        {
            var result = mTaxesAndWrapUpRepository.GetFederalTaxSummary(GetUserDTO());

            Assert.IsNotNull(result.Item5);
        }

        /// <summary>
        ///Gets the Genernate1040EZForm  by userid and Userdataid
        /// </summary>
        [TestMethod]
        public void Genernate1040EZForm()
        {
            mTaxesAndWrapUpRepository.Genernate1040EZForm(GetUserDTO());
        }
    }
}
