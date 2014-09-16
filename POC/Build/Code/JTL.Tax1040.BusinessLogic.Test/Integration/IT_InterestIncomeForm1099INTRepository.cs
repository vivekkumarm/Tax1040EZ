/*
Copyright   : Copyright Jeevan Technologies
File Name   : IT_InterestIncomeForm1099INTRepository.cs 
Description : Business Logic testing for InterestIncome Form1099INT 
Author      : Bala
Created Date : 17 Apr 2014

 * Modification History:
---------------------
 */
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JTL.Tax1040.BusinessLogic.Test
{
    [TestClass]
    public class IT_InterestIncomeForm1099INTRepository
    {
        static ITaxReturnRepository mTaxReturnRepository;
        static IInterestIncomeRepository mInterestIncomeRepository;
        static IPersonalInfoRepository mPersonalInfoRepository;
        static TaxReturnData taxReturnData;


        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mTaxReturnRepository = new TaxReturnRepository();
            mPersonalInfoRepository = new PersonalInfoRepository();
            mInterestIncomeRepository = new InterestIncomeRepository();
            taxReturnData = new TaxReturnData(); 
        }

        /// <summary>
        /// Persist the Form1099INT list data.
        /// </summary>
        [TestMethod]
        public void PersistForm1099INTData()
        {
            var userId = IT_UserRepository.PersistNewUser();
            var userDataId = 0L;
            List<ErrorMessage> errorMessageList;
            //var primaryTaxPayer = IT_PersonalInfo.CreateAndPersistPrimaryTaxPayer(userId, FilingStatus.Single, ref userDataId);

            var form1099INT1 = CreateForm1099INT(OwnerType.PrimaryTaxPayer);

            var form1099INTJson1 = JsonConvert.SerializeObject(form1099INT1);
            taxReturnData.TaxData = form1099INTJson1;
            taxReturnData.UserDataId = userDataId;

            //Before persist in tax object
            Assert.AreEqual(0, userDataId);
            Assert.AreEqual(0, form1099INT1.Form1099INTId);

            //Persist first Form 1099INT 
            var userDataId1 = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(taxReturnData);

            //After Persist
            Assert.IsTrue(userDataId1 > 0);

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(userDataId1, userId);
             List<Form1099INT> f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

             Assert.AreEqual(1, f1099INTListObject.Count);

             // Get first Form 1099INT id.
             var f1099INTId1 = f1099INTListObject[0].Form1099INTId;

             Assert.IsTrue(f1099INTListObject[0].Form1099INTId > 0);

             Assert.AreEqual(form1099INT1.FederalTaxWithHoldingAmount, f1099INTListObject[0].FederalTaxWithHoldingAmount);
             Assert.AreEqual(form1099INT1.ForeignCountryId, f1099INTListObject[0].ForeignCountryId);
             Assert.AreEqual(form1099INT1.Form1099StateInfo.Count, f1099INTListObject[0].Form1099StateInfo.Count);
             Assert.AreEqual(form1099INT1.Owner, form1099INT1.Owner);

             
             var form1099INT2 = CreateForm1099INT(OwnerType.Spouse);
             var form1099INTJson2 = JsonConvert.SerializeObject(form1099INT2);
             taxReturnData.TaxData = form1099INTJson2;
             taxReturnData.UserDataId = userDataId1;

             //Before persist in tax object
             Assert.AreEqual(0, form1099INT2.Form1099INTId);

             //Persist second Form 1099INT 
             var userDataId2 = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(taxReturnData);

             //After Persist
             Assert.AreEqual(userDataId1, userDataId2);

             taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(userDataId2, userId);
             f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

             Assert.AreEqual(2, f1099INTListObject.Count);

             // Get first Form 1099INT 
             var f1099Int_1 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId == f1099INTId1);

             // Get second Form 1099INT 
             var f1099Int_2 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId != f1099INTId1);

             // Get second Form 1099INT id
             var f1099INTId2 = f1099Int_2.Form1099INTId;

             //Check first Form 1099INT
             Assert.AreEqual(form1099INT1.FederalTaxWithHoldingAmount, f1099Int_1.FederalTaxWithHoldingAmount);
             Assert.AreEqual(form1099INT1.ForeignCountryId, f1099Int_1.ForeignCountryId);
             Assert.AreEqual(form1099INT1.Form1099StateInfo.Count, f1099Int_1.Form1099StateInfo.Count);
             Assert.AreEqual(form1099INT1.Owner, f1099Int_1.Owner);

             //Check second Form 1099INT
             Assert.AreEqual(form1099INT2.FederalTaxWithHoldingAmount, f1099Int_2.FederalTaxWithHoldingAmount);
             Assert.AreEqual(form1099INT2.ForeignCountryId, f1099Int_2.ForeignCountryId);
             Assert.AreEqual(form1099INT2.Form1099StateInfo.Count, f1099Int_2.Form1099StateInfo.Count);
             Assert.AreEqual(form1099INT2.Owner, f1099Int_2.Owner);

            //Update second Form 1099INT

             var ownerForm2Old = f1099Int_2.Owner;
             f1099Int_2.Owner = OwnerType.Joint;

             var taxableInterestAmountOld = f1099Int_2.TaxableInterestAmount;
             f1099Int_2.TaxableInterestAmount = 0;

             var federalTaxWithHoldingAmountOld = f1099Int_2.FederalTaxWithHoldingAmount;
             f1099Int_2.FederalTaxWithHoldingAmount = 0;

             var form1099StateInfoCountOld = f1099Int_2.Form1099StateInfo.Count;
             f1099Int_2.Form1099StateInfo.RemoveAt(0);


             form1099INTJson2 = JsonConvert.SerializeObject(f1099Int_2);
             taxReturnData.TaxData = form1099INTJson2;
             taxReturnData.UserDataId = userDataId2;

             //Persist second Form 1099INT 
             userDataId2 = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(taxReturnData);

             //After Persist
             Assert.AreEqual(userDataId1, userDataId2);

             taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(userDataId2, userId);
             f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

             // Get modified second Form 1099INT 
             f1099Int_2 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId == f1099INTId2);

             //Check modified second Form 1099INT
             Assert.AreNotEqual(federalTaxWithHoldingAmountOld, f1099Int_2.FederalTaxWithHoldingAmount);
             Assert.AreNotEqual(taxableInterestAmountOld, f1099Int_2.TaxableInterestAmount);
             Assert.AreNotEqual(form1099StateInfoCountOld, f1099Int_2.Form1099StateInfo.Count);
             Assert.AreNotEqual(ownerForm2Old, f1099Int_2.Owner);


        }

        /// <summary>
        /// Persists and delete the W2 list data.
        /// </summary>
        [TestMethod]
        public void PersistAndDeleteForm1099INTData()
        {
            var userId = IT_UserRepository.PersistNewUser();
            var userDataId = 0L;
            List<ErrorMessage> errorMessageList;
            //var primaryTaxPayer = IT_PersonalInfo.CreateAndPersistPrimaryTaxPayer(userId, FilingStatus.Single, ref userDataId);

            var form1099INT1 = CreateForm1099INT(OwnerType.PrimaryTaxPayer);

            var form1099INTJson1 = JsonConvert.SerializeObject(form1099INT1);
            taxReturnData.TaxData = form1099INTJson1;
            taxReturnData.UserDataId = userDataId;

            //Before persist in tax object
            
            Assert.AreEqual(0, form1099INT1.Form1099INTId);

            //Persist first Form 1099INT 
            var userDataId1 = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(taxReturnData);

            //After Persist
            Assert.IsTrue(userDataId1 > 0);

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(userDataId1, userId);
            List<Form1099INT> f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            Assert.AreEqual(1, f1099INTListObject.Count);

            // Get first Form 1099INT id.
            var f1099INTId1 = f1099INTListObject[0].Form1099INTId;

            Assert.AreNotEqual(form1099INT1.Form1099INTId, f1099INTListObject[0].Form1099INTId);

            Assert.AreEqual(form1099INT1.FederalTaxWithHoldingAmount, f1099INTListObject[0].FederalTaxWithHoldingAmount);
            Assert.AreEqual(form1099INT1.Form1099StateInfo.Count, f1099INTListObject[0].Form1099StateInfo.Count);
            Assert.AreEqual(form1099INT1.Owner, form1099INT1.Owner);


            var form1099INT2 = CreateForm1099INT(OwnerType.Spouse);
            var form1099INTJson2 = JsonConvert.SerializeObject(form1099INT2);
            taxReturnData.TaxData = form1099INTJson2;
            taxReturnData.UserDataId = userDataId1;

            //Before persist in tax object
            Assert.AreEqual(0, form1099INT2.Form1099INTId);

            //Persist second Form 1099INT 
            var userDataId2 = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(taxReturnData);

            //After Persist
            Assert.AreEqual(userDataId1, userDataId2);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(userDataId2, userId);
            f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            Assert.AreEqual(2, f1099INTListObject.Count);

            // Get first Form 1099INT 
            var f1099Int_1 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId == f1099INTId1);

            // Get second Form 1099INT 
            var f1099Int_2 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId != f1099INTId1);

            // Get second Form 1099INT id
            var f1099INTId2 = f1099Int_2.Form1099INTId;

            //Check second Form 1099INT
            Assert.AreEqual(form1099INT2.FederalTaxWithHoldingAmount, f1099Int_2.FederalTaxWithHoldingAmount);
            Assert.AreEqual(form1099INT2.ForeignCountryId, f1099Int_2.ForeignCountryId);
            Assert.AreEqual(form1099INT2.Form1099StateInfo.Count, f1099Int_2.Form1099StateInfo.Count);
            Assert.AreEqual(form1099INT2.Owner, f1099Int_2.Owner);

            //Delete second Form 1099INT 
            UserDTO userDTO = new UserDTO();
            userDTO.UserId = userId;
            userDTO.UserDataId = userDataId2;
            userDTO.FormId = f1099INTId2;
            mInterestIncomeRepository.DeleteAndPersist1099INT(userDTO);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(userDataId2, userId);
            f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            Assert.AreEqual(1, f1099INTListObject.Count);

            // Get first Form 1099INT 
            f1099Int_1 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId == f1099INTId1);

            // First Form 1099INT avaialable
            Assert.IsNotNull(f1099Int_1);

           // Get second Form 1099INT 
           f1099Int_2 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId == f1099INTId2);

           // First Form 1099INT not avaialable
           Assert.IsNull(f1099Int_2);
        }

        /// <summary>
        /// Tests the clean up.
        /// </summary>
        [TestCleanup]
        public void TestCleanUp()
        {

        }

        #region Helper Methods


        public static dynamic CreateAndPersistForm1099INT()
        {
            var userId = IT_UserRepository.PersistNewUser();
            var userDataId = 0L;
            List<ErrorMessage> errorMessageList;
            var primaryTaxPayer = IT_PersonalInfo.CreateAndPersistPrimaryTaxPayer(userId, FilingStatus.Single, ref userDataId);

            var form1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);

            var form1099INTJson = JsonConvert.SerializeObject(form1099INT);
            taxReturnData.TaxData = form1099INTJson;
            taxReturnData.UserDataId = userDataId;

            var userData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(taxReturnData);

            userData.UserId = userId;
            return userData;
        }

        public static Form1099INT CreateForm1099INT(OwnerType ownerType)
        {
            Form1099INT form1099INT = null;

            form1099INT = new Form1099INT
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
                            StateId = mPersonalInfoRepository.GetAllState().First().StateId,
                            ZipCode = "123456"
                        },
                    }
                },

                Form1099StateInfo = new List<Form1099StateInformation> {

        new Form1099StateInformation {
        StateId = mPersonalInfoRepository.GetAllState().First().StateId,
        StateIdentificationNumber = "Test SIN143",
        StateTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 2000)
        },

        new Form1099StateInformation {
        StateId = mPersonalInfoRepository.GetAllState().First().StateId,
        StateIdentificationNumber = "Test SIN144",
        StateTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 2000)
        },
        
        },
                Owner = ownerType,
                Form = FormType.Form1099INT,
                TaxExemptInterestStateId = Utilities.CreateRandomNumber(0, 2000),
                StateExemptInterest = Utilities.CreateRandomNumber(0, 2000)
            };

            return form1099INT;
        }

        #endregion

    }
}
