/*
Copyright   : Copyright Jeevan Technologies
File Name   : IT_InterestIncomeForm1099INTRepository.cs 
Description : Business Logic testing for InterestIncome Form1099INT 
Author      : Bala
Created Date : 17 Apr 2014

 * Modification History:
---------------------
 *Vincent- 22 July 2014 - Refactored the entire code for Interest income UNIT Test case.
 */
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Dynamic;

namespace JTL.Tax1040.BusinessLogic.Test
{
    [TestClass]
    public class IT_InterestIncomeForm1099INTRepository
    {
        static ITaxReturnRepository mTaxReturnRepository;
        static IInterestIncomeRepository mInterestIncomeRepository;
        static IPersonalInfoRepository mPersonalInfoRepository;
        static TaxReturnData taxReturnData;
        static dynamic userData;
        static long userId = 0;


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
            userData = new ExpandoObject();
            userId = IT_UserRepository.PersistNewUser();
        }

        #region Form 1099INT

        /// <summary>
        /// Persist the Form1099INT list data.
        /// </summary>
        [TestMethod]
        public void UpdateForm1099INTData()
        {
            var userDataId = 0L;
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;

            var actualFirstForm1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);

            //Serializing Object
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = JsonConvert.SerializeObject(actualFirstForm1099INT);
            

            //Getting userId  & Tax Return data
            userData.userId = userId;
            userData.TaxReturnData =JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, userDataId);
            Assert.AreEqual(0, actualFirstForm1099INT.Form1099INTId);

            //Persist first Form 1099INT 
            var expectedFirstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(userData);


            //Getting the tax return data
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedFirstUserDataId.UserDataId, userId);
            List<Form1099INT> f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            Assert.AreEqual(1, f1099INTListObject.Count);

            // Get first Form 1099INT id.
            var FirstForm1099INTId = f1099INTListObject[0].Form1099INTId;

            Assert.IsTrue(f1099INTListObject[0].Form1099INTId > 0);

            Assert.AreEqual(actualFirstForm1099INT.FederalTaxWithHoldingAmount, f1099INTListObject[0].FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualFirstForm1099INT.USBondsTreasury, f1099INTListObject[0].USBondsTreasury);


            var actualSecondForm1099INT2 = CreateForm1099INT(OwnerType.Spouse);
            var convertingSecondForm1099INTJson = JsonConvert.SerializeObject(actualSecondForm1099INT2);
            taxReturnData.UserDataId = expectedFirstUserDataId.UserDataId;
            taxReturnData.TaxData = convertingSecondForm1099INTJson;
           

            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, actualSecondForm1099INT2.Form1099INTId);

            //Persist second Form 1099INT 
            var expectedSecondUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(userData);

            //After Persist
            Assert.AreEqual(expectedFirstUserDataId.UserDataId, expectedSecondUserDataId.UserDataId);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedSecondUserDataId.UserDataId, userId);
            f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            Assert.AreEqual(2, f1099INTListObject.Count);

            // Get first Form 1099INT 
            var f1099Int_1 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId == FirstForm1099INTId);

            // Get second Form 1099INT 
            var f1099Int_2 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId != FirstForm1099INTId);

            // Get second Form 1099INT id
            var SecondForm1099INTId = f1099Int_2.Form1099INTId;

            //Check first Form 1099INT
            Assert.AreEqual(actualFirstForm1099INT.FederalTaxWithHoldingAmount, f1099Int_1.FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualFirstForm1099INT.USBondsTreasury, f1099Int_1.USBondsTreasury);
            

            //Check second Form 1099INT
            Assert.AreEqual(actualSecondForm1099INT2.FederalTaxWithHoldingAmount, f1099Int_2.FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualSecondForm1099INT2.USBondsTreasury, f1099Int_2.USBondsTreasury);
           

            //Update second Form 1099INT
            var ownerForm2Old = f1099Int_2.Owner;
            f1099Int_2.Owner = OwnerType.Joint;

            var taxableInterestAmountOld = f1099Int_2.TaxableInterestAmount;
            f1099Int_2.TaxableInterestAmount = 0;

            var federalTaxWithHoldingAmountOld = f1099Int_2.FederalTaxWithHoldingAmount;
            f1099Int_2.FederalTaxWithHoldingAmount = 0;



            convertingSecondForm1099INTJson = JsonConvert.SerializeObject(f1099Int_2);
            taxReturnData.UserDataId = expectedSecondUserDataId.UserDataId;
            taxReturnData.TaxData = convertingSecondForm1099INTJson;
            

            userData.userId = userId;
            userData.TaxReturnData =JsonConvert.SerializeObject(taxReturnData);


            //Persist second Form 1099INT 
            expectedSecondUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(userData);

            //After Persist
            Assert.AreEqual(expectedFirstUserDataId.UserDataId, expectedSecondUserDataId.UserDataId);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedSecondUserDataId.UserDataId, userId);
            f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            // Get modified second Form 1099INT 
            f1099Int_2 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId == SecondForm1099INTId);

            //Check modified second Form 1099INT
            Assert.AreNotEqual(federalTaxWithHoldingAmountOld, f1099Int_2.FederalTaxWithHoldingAmount);
            Assert.AreNotEqual(taxableInterestAmountOld, f1099Int_2.TaxableInterestAmount);
            Assert.AreNotEqual(ownerForm2Old, f1099Int_2.Owner);

        }

        /// <summary>
        /// Persists the form1099 int as primary tax payer.
        /// </summary>
        [TestMethod]
        public void PersistForm1099INTAsPrimaryTaxPayer()
        {


            var userDataId = 0L;
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);

            List<ErrorMessage> errorMessageList;

            var actualForm1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);

                        
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = JsonConvert.SerializeObject(actualForm1099INT);

            userData.userId = userId;
            userData.TaxReturnData =JsonConvert.SerializeObject( taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, actualForm1099INT.Form1099INTId);

            //Persist first Form 1099INT 
            var expectedUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(userData);



            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedUserDataId.UserDataId, userId);
            List<Form1099INT> f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            Assert.AreEqual(1, f1099INTListObject.Count);

            // Get Form 1099INT id.
            var form1099INTId = f1099INTListObject[0].Form1099INTId;

            Assert.IsTrue(form1099INTId > 0);

            Assert.AreEqual(actualForm1099INT.USBondsTreasury, f1099INTListObject[0].USBondsTreasury);
            Assert.AreEqual(actualForm1099INT.FederalTaxWithHoldingAmount, f1099INTListObject[0].FederalTaxWithHoldingAmount);


        }

        /// <summary>
        /// Persists the form1099 int as spouse.
        /// </summary>
        [TestMethod]
        public void PersistForm1099INTAsSpouse()
        {

            var userDataId = 0L;
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);

            List<ErrorMessage> errorMessageList;

            var actualForm1099INT = CreateForm1099INT(OwnerType.Spouse);

            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = JsonConvert.SerializeObject(actualForm1099INT);
            

            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, userDataId);
            Assert.AreEqual(0, actualForm1099INT.Form1099INTId);

            //Persist first Form 1099INT 
            var expectedUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(userData);



            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedUserDataId.UserDataId, userId);
            List<Form1099INT> f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            Assert.AreEqual(1, f1099INTListObject.Count);

            // Getting Form 1099INT id.
            var form1099INTId = f1099INTListObject[0].Form1099INTId;

            Assert.IsTrue(form1099INTId > 0);

            Assert.AreEqual(actualForm1099INT.USBondsTreasury, f1099INTListObject[0].USBondsTreasury);
            Assert.AreEqual(actualForm1099INT.FederalTaxWithHoldingAmount, f1099INTListObject[0].FederalTaxWithHoldingAmount);


        }

        /// <summary>
        /// Persists the form1099 int primary taxpayer and spouse.
        /// </summary>
        [TestMethod]
        public void PersistForm1099INTPrimaryTaxpayerAndSpouse()
        {
            var userDataId = 0L;
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;

            var actualFirstForm1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);

            //Serializing Object
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = JsonConvert.SerializeObject(actualFirstForm1099INT);
            

            //Getting userId  & Tax Return data
            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, userDataId);
            Assert.AreEqual(0, actualFirstForm1099INT.Form1099INTId);

            //Persist first Form 1099INT 
            var exepectedFirstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(userData);


            //Getting the tax return data
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(exepectedFirstUserDataId.UserDataId, userId);
            List<Form1099INT> f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            Assert.AreEqual(1, f1099INTListObject.Count);

            // Get first Form 1099INT id.
            var firstForm1099INTId = f1099INTListObject[0].Form1099INTId;

            Assert.IsTrue(f1099INTListObject[0].Form1099INTId > 0);

            Assert.AreEqual(actualFirstForm1099INT.FederalTaxWithHoldingAmount, f1099INTListObject[0].FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualFirstForm1099INT.ForeignCountryId, f1099INTListObject[0].ForeignCountryId);


            var actualSecondForm1099INT = CreateForm1099INT(OwnerType.Spouse);
            var convertingSecondform1099INTJson = JsonConvert.SerializeObject(actualSecondForm1099INT);
            taxReturnData.UserDataId = exepectedFirstUserDataId.UserDataId;
            taxReturnData.TaxData = convertingSecondform1099INTJson;
            

            userData.userId = userId;
            userData.TaxReturnData =JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, actualSecondForm1099INT.Form1099INTId);

            //Persist second Form 1099INT 
            var exepectedSecondUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(userData);

            //After Persist
            Assert.AreEqual(exepectedFirstUserDataId.UserDataId, exepectedSecondUserDataId.UserDataId);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(exepectedSecondUserDataId.UserDataId, userId);
            f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            Assert.AreEqual(2, f1099INTListObject.Count);

            // Get first Form 1099INT 
            var f1099Int_1 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId == firstForm1099INTId);

            // Get second Form 1099INT 
            var f1099Int_2 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId != firstForm1099INTId);

            // Get second Form 1099INT id
            var f1099INTId2 = f1099Int_2.Form1099INTId;

            //Check first Form 1099INT
            Assert.AreEqual(actualFirstForm1099INT.FederalTaxWithHoldingAmount, f1099Int_1.FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualFirstForm1099INT.USBondsTreasury, f1099Int_1.USBondsTreasury);


            //Check second Form 1099INT
            Assert.AreEqual(actualSecondForm1099INT.FederalTaxWithHoldingAmount, f1099Int_2.FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualSecondForm1099INT.USBondsTreasury, f1099Int_2.USBondsTreasury);

        }
        
        /// <summary>
        /// Persists and delete the W2 list data.
        /// </summary>
        [TestMethod]
        public void PersistAndDeleteForm1099INTData()
        {
            var userDataId = 0L;
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;


            var actualFirstform1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);

            var firstForm1099INTJson = JsonConvert.SerializeObject(actualFirstform1099INT);
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = firstForm1099INTJson;
            

            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object

            Assert.AreEqual(0, actualFirstform1099INT.Form1099INTId);

            //Persist first Form 1099INT 
            var firstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(userData);

            //After Persist
            //Assert.IsTrue(userDataId1 > 0);

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(firstUserDataId.UserDataId, userId);
            List<Form1099INT> f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            Assert.AreEqual(1, f1099INTListObject.Count);

            // Get first Form 1099INT id.
            var FirstForm1099INTId = f1099INTListObject[0].Form1099INTId;

            Assert.AreNotEqual(actualFirstform1099INT.Form1099INTId, f1099INTListObject[0].Form1099INTId);

            Assert.AreEqual(actualFirstform1099INT.FederalTaxWithHoldingAmount, f1099INTListObject[0].FederalTaxWithHoldingAmount);
            //Assert.AreEqual(form1099INT1.Form1099StateInfo.Count, f1099INTListObject[0].Form1099StateInfo.Count);
            //Assert.AreEqual(form1099INT1.Owner, form1099INT1.Owner);


            var actualForm1099INT = CreateForm1099INT(OwnerType.Spouse);
            var secondForm1099INTJson = JsonConvert.SerializeObject(actualForm1099INT);
            taxReturnData.UserDataId = firstUserDataId.UserDataId;
            taxReturnData.TaxData = secondForm1099INTJson;
            

            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, actualForm1099INT.Form1099INTId);

            //Persist second Form 1099INT 
            var secondUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(userData);

            //After Persist
            Assert.AreEqual(firstUserDataId.UserDataId, secondUserDataId.UserDataId);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(secondUserDataId.UserDataId, userId);
            f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            Assert.AreEqual(2, f1099INTListObject.Count);

            // Get first Form 1099INT 
            var f1099Int_1 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId == FirstForm1099INTId);

            // Get second Form 1099INT 
            var f1099Int_2 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId != FirstForm1099INTId);

            // Get second Form 1099INT id
            var secondForm1099INTId = f1099Int_2.Form1099INTId;

            //Check second Form 1099INT
            Assert.AreEqual(actualForm1099INT.FederalTaxWithHoldingAmount, f1099Int_2.FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualForm1099INT.ForeignCountryId, f1099Int_2.ForeignCountryId);
            

            //Delete second Form 1099INT 
            UserDTO userDTO = new UserDTO();
            userDTO.UserId = userId;
            userDTO.UserDataId = secondUserDataId.UserDataId;
            userDTO.FormId = secondForm1099INTId;
            mInterestIncomeRepository.DeleteAndPersist1099INT(userDTO);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(secondUserDataId.UserDataId, userId);
            f1099INTListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            Assert.AreEqual(1, f1099INTListObject.Count);

            // Get first Form 1099INT 
            f1099Int_1 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId == FirstForm1099INTId);

            // First Form 1099INT avaialable
            Assert.IsNotNull(f1099Int_1);

            // Get second Form 1099INT 
            f1099Int_2 = f1099INTListObject.FirstOrDefault(fInt => fInt.Form1099INTId == secondForm1099INTId);

            // First Form 1099INT not avaialable
            Assert.IsNull(f1099Int_2);
        }

        #endregion


        #region Form 1099OID

        /// <summary>
        /// Persists the form1099 oid as primary tax payer.
        /// </summary>
        [TestMethod]
        public void PersistForm1099OIDAsPrimaryTaxPayer()
        {
            var userDataId = 0L;
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);

            List<ErrorMessage> errorMessageList;

            var actualForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            taxReturnData.TaxData = JsonConvert.SerializeObject(actualForm1099OID);
            taxReturnData.UserDataId = expectedUserDataID.Item1;

            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
           
            Assert.AreEqual(0, actualForm1099OID.Form1099OIDId);

            //Persist first Form 1099OID
            var expectedUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userData);



            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedUserDataId.UserDataId, userId);
            List<Form1099OID> f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            Assert.AreEqual(1, f1099OIDListObject.Count);

            // Get Form 1099OID id.
            var form1099OIDId = f1099OIDListObject[0].Form1099OIDId;

            Assert.IsTrue(form1099OIDId > 0);

            Assert.AreEqual(actualForm1099OID.OriginalIssueDiscount, f1099OIDListObject[0].OriginalIssueDiscount);
            Assert.AreEqual(actualForm1099OID.FederalTaxWithHoldingAmount, f1099OIDListObject[0].FederalTaxWithHoldingAmount);


        }

        /// <summary>
        /// Persists the form1099 oid as spouse.
        /// </summary>
        [TestMethod]
        public void PersistForm1099OIDAsSpouse() 
        {
            var userDataId = 0L;
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);

            List<ErrorMessage> errorMessageList;

            var actualForm1099OID = CreateForm1099OID(OwnerType.Spouse);

            taxReturnData.TaxData = JsonConvert.SerializeObject(actualForm1099OID);
            taxReturnData.UserDataId = expectedUserDataID.Item1;

            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object

            Assert.AreEqual(0, actualForm1099OID.Form1099OIDId);

            //Persist first Form 1099OID
            var expectedUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userData);



            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedUserDataId.UserDataId, userId);
            List<Form1099OID> f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            Assert.AreEqual(1, f1099OIDListObject.Count);

            // Get Form 1099OID id.
            var form1099OIDId = f1099OIDListObject[0].Form1099OIDId;

            Assert.IsTrue(form1099OIDId > 0);

            Assert.AreEqual(actualForm1099OID.OriginalIssueDiscount, f1099OIDListObject[0].OriginalIssueDiscount);
            Assert.AreEqual(actualForm1099OID.FederalTaxWithHoldingAmount, f1099OIDListObject[0].FederalTaxWithHoldingAmount);
        
        
        }

        /// <summary>
        /// Persists the form1099 oid primary taxpayer and spouse.
        /// </summary>
        [TestMethod]
        public void PersistForm1099OIDPrimaryTaxpayerAndSpouse()
        {
            var userDataId = 0L;
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;

            var actualFirstForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            //Serializing Object
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = JsonConvert.SerializeObject(actualFirstForm1099OID);


            //Getting userId  & Tax Return data
            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, userDataId);
            Assert.AreEqual(0, actualFirstForm1099OID.Form1099OIDId);

            //Persist first Form 1099OID 
            var exepectedFirstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userData);


            //Getting the tax return data
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(exepectedFirstUserDataId.UserDataId, userId);
            List<Form1099OID> f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            Assert.AreEqual(1, f1099OIDListObject.Count);

            // Get first Form 1099OID id.
            var firstForm1099OIDId = f1099OIDListObject[0].Form1099OIDId;

            Assert.IsTrue(f1099OIDListObject[0].Form1099OIDId > 0);

            Assert.AreEqual(actualFirstForm1099OID.FederalTaxWithHoldingAmount, f1099OIDListObject[0].FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualFirstForm1099OID.OriginalIssueDiscount, f1099OIDListObject[0].OriginalIssueDiscount);


            var actualSecondForm1099OID = CreateForm1099OID(OwnerType.Spouse);
            var secondform1099OIDJson = JsonConvert.SerializeObject(actualSecondForm1099OID);
            taxReturnData.UserDataId = exepectedFirstUserDataId.UserDataId;
            taxReturnData.TaxData = secondform1099OIDJson;


            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, actualSecondForm1099OID.Form1099OIDId);

            //Persist second Form 1099OID 
            var exepectedSecondUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userData);

            //After Persist
            Assert.AreEqual(exepectedFirstUserDataId.UserDataId, exepectedSecondUserDataId.UserDataId);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(exepectedSecondUserDataId.UserDataId, userId);
            f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            Assert.AreEqual(2, f1099OIDListObject.Count);

            // Get first Form 1099OID 
            var f1099OID_1 = f1099OIDListObject.FirstOrDefault(fOID => fOID.Form1099OIDId == firstForm1099OIDId);

            // Get second Form 1099OID 
            var f1099OID_2 = f1099OIDListObject.FirstOrDefault(fOID => fOID.Form1099OIDId != firstForm1099OIDId);


            //Check first Form 1099OID
            Assert.AreEqual(actualFirstForm1099OID.FederalTaxWithHoldingAmount, f1099OID_1.FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualFirstForm1099OID.OriginalIssueDiscount, f1099OID_1.OriginalIssueDiscount);


            //Check second Form 1099OID
            Assert.AreEqual(actualSecondForm1099OID.FederalTaxWithHoldingAmount, f1099OID_2.FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualSecondForm1099OID.OriginalIssueDiscount, f1099OID_2.OriginalIssueDiscount);

        }

        /// <summary>
        /// Updates the form1099 oid data.
        /// </summary>
        [TestMethod]
        public void UpdateForm1099OIDData()
        {
            var userDataId = 0L;;
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;

            var actualFirstForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            //Serializing Object
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = JsonConvert.SerializeObject(actualFirstForm1099OID);


            //Getting userId  & Tax Return data
            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, userDataId);
            Assert.AreEqual(0, actualFirstForm1099OID.Form1099OIDId);

            //Persist first Form 1099OID 
            var expectedFirstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userData);


            //Getting the tax return data
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedFirstUserDataId.UserDataId, userId);
            List<Form1099OID> f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            Assert.AreEqual(1, f1099OIDListObject.Count);

            // Get first Form 1099OID id.
            var FirstForm1099OIDId = f1099OIDListObject[0].Form1099OIDId;

            Assert.IsTrue(f1099OIDListObject[0].Form1099OIDId > 0);

            Assert.AreEqual(actualFirstForm1099OID.FederalTaxWithHoldingAmount, f1099OIDListObject[0].FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualFirstForm1099OID.ForeignCountryId, f1099OIDListObject[0].ForeignCountryId);


            var actualSecondForm1099OID = CreateForm1099INT(OwnerType.Spouse);
            var convertingSecondForm1099OIDJson = JsonConvert.SerializeObject(actualSecondForm1099OID);
            taxReturnData.UserDataId = expectedFirstUserDataId.UserDataId;
            taxReturnData.TaxData = convertingSecondForm1099OIDJson;


            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, actualSecondForm1099OID.Form1099INTId);

            //Persist second Form 1099OID 
            var expectedSecondUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userData);

            //After Persist
            Assert.AreEqual(expectedFirstUserDataId.UserDataId, expectedSecondUserDataId.UserDataId);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedSecondUserDataId.UserDataId, userId);
            f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            Assert.AreEqual(2, f1099OIDListObject.Count);

            // Get first Form 1099OID 
            var f1099OID_1 = f1099OIDListObject.FirstOrDefault(fOID => fOID.Form1099OIDId == FirstForm1099OIDId);

            // Get second Form 1099OID 
            var f1099OID_2 = f1099OIDListObject.FirstOrDefault(fOID => fOID.Form1099OIDId != FirstForm1099OIDId);

            // Get second Form 1099OID id
            var SecondForm1099OIDId = f1099OID_2.Form1099OIDId;

            //Check first Form 1099OID
            Assert.AreEqual(actualFirstForm1099OID.FederalTaxWithHoldingAmount, f1099OID_1.FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualFirstForm1099OID.ForeignCountryId, f1099OID_1.ForeignCountryId);


            //Check second Form 1099OID
            Assert.AreEqual(actualSecondForm1099OID.FederalTaxWithHoldingAmount, f1099OID_2.FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualSecondForm1099OID.ForeignCountryId, f1099OID_2.ForeignCountryId);


            //Update second Form 1099OID
            var ownerForm2Old = f1099OID_2.Owner;
            f1099OID_2.Owner = OwnerType.Joint;

            var taxableInterestAmountOld = f1099OID_2.TaxableInterestAmount;
            f1099OID_2.TaxableInterestAmount = 0;

            var federalTaxWithHoldingAmountOld = f1099OID_2.FederalTaxWithHoldingAmount;
            f1099OID_2.FederalTaxWithHoldingAmount = 0;



            convertingSecondForm1099OIDJson = JsonConvert.SerializeObject(f1099OID_2);
            taxReturnData.UserDataId = expectedSecondUserDataId.UserDataId;
            taxReturnData.TaxData = convertingSecondForm1099OIDJson;


            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);


            //Persist second Form 1099OID 
            expectedSecondUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userData);

            //After Persist
            Assert.AreEqual(expectedFirstUserDataId.UserDataId, expectedSecondUserDataId.UserDataId);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedSecondUserDataId.UserDataId, userId);
            f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            // Get modified second Form 1099OID 
            f1099OID_2 = f1099OIDListObject.FirstOrDefault(fOID => fOID.Form1099OIDId == SecondForm1099OIDId);

            //Check modified second Form 1099OID
            Assert.AreNotEqual(federalTaxWithHoldingAmountOld, f1099OID_2.FederalTaxWithHoldingAmount);
            Assert.AreNotEqual(taxableInterestAmountOld, f1099OID_2.TaxableInterestAmount);
            Assert.AreNotEqual(ownerForm2Old, f1099OID_2.Owner);

        }

        /// <summary>
        /// Persists the and delete form1099 oid data.
        /// </summary>
        [TestMethod]
        public void PersistAndDeleteForm1099OIDData()
        {
            var userDataId = 0L;;
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;


            var actualFirstform1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            var firstForm1099OIDJson = JsonConvert.SerializeObject(actualFirstform1099OID);
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = firstForm1099OIDJson;


            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object

            Assert.AreEqual(0, actualFirstform1099OID.Form1099OIDId);

            //Persist first Form 1099OID 
            var firstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userData);

            
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(firstUserDataId.UserDataId, userId);
            List<Form1099OID> f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            Assert.AreEqual(1, f1099OIDListObject.Count);

            // Get first Form 1099OID id.
            var FirstForm1099OIDId = f1099OIDListObject[0].Form1099OIDId;

            Assert.AreNotEqual(actualFirstform1099OID.Form1099OIDId, f1099OIDListObject[0].Form1099OIDId);

            Assert.AreEqual(actualFirstform1099OID.FederalTaxWithHoldingAmount, f1099OIDListObject[0].FederalTaxWithHoldingAmount);


            var actualForm1099OID = CreateForm1099OID(OwnerType.Spouse);
            var secondForm1099OIDJson = JsonConvert.SerializeObject(actualForm1099OID);
            taxReturnData.UserDataId = firstUserDataId.UserDataId;
            taxReturnData.TaxData = secondForm1099OIDJson;


            userData.userId = userId;
            userData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, actualForm1099OID.Form1099OIDId);

            //Persist second Form 1099OID
            var secondUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userData);

            //After Persist
            Assert.AreEqual(firstUserDataId.UserDataId, secondUserDataId.UserDataId);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(secondUserDataId.UserDataId, userId);
            f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            Assert.AreEqual(2, f1099OIDListObject.Count);

            // Get first Form 1099OID 
            var f1099OID_1 = f1099OIDListObject.FirstOrDefault(fOID => fOID.Form1099OIDId == FirstForm1099OIDId);

            // Get second Form 1099OID
            var f1099OID_2 = f1099OIDListObject.FirstOrDefault(fOID => fOID.Form1099OIDId != FirstForm1099OIDId);

            // Get second Form 1099OID id
            var secondForm1099OIDId = f1099OID_2.Form1099OIDId;

            //Check second Form 1099OID
            Assert.AreEqual(actualForm1099OID.FederalTaxWithHoldingAmount, f1099OID_2.FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualForm1099OID.ForeignCountryId, f1099OID_2.ForeignCountryId);
            

            //Delete second Form 1099INT 
            UserDTO userDTO = new UserDTO();
            userDTO.UserId = userId;
            userDTO.UserDataId = secondUserDataId.UserDataId;
            userDTO.FormId = secondForm1099OIDId;
            mInterestIncomeRepository.DeleteAndPersist1099OID(userDTO);

            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(secondUserDataId.UserDataId, userId);
            f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            Assert.AreEqual(1, f1099OIDListObject.Count);

            // Get first Form 1099OID 
            f1099OID_1 = f1099OIDListObject.FirstOrDefault(fOID => fOID.Form1099OIDId == FirstForm1099OIDId);

            // First Form 1099OID avaialable
            Assert.IsNotNull(f1099OID_1);

            // Get second Form 1099OID 
            f1099OID_2 = f1099OIDListObject.FirstOrDefault(fOID => fOID.Form1099OIDId == secondForm1099OIDId);

            // First Form 1099OID not avaialable
            Assert.IsNull(f1099OID_2);
        }



        #endregion

        /// <summary>
        /// Tests the clean up.
        /// </summary>
        /// 
        [TestCleanup]
        public void TestCleanUp()
        {

        }

        #region Helper Methods

        #region Form1099INT

        /// <summary>
        /// Creates the and persist form1099 int.
        /// </summary>
        /// <returns></returns>
        public static dynamic CreateAndPersistForm1099INT()
        {
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

        /// <summary>
        /// Creates the form1099 int.
        /// </summary>
        /// <param name="ownerType">Type of the owner.</param>
        /// <returns></returns>
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

                TaxExemptInterestState=new State()
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

        #region Form1099 OID

        /// <summary>
        /// Creates the and persist form1099 oid.
        /// </summary>
        /// <returns></returns>
        public static dynamic CreateAndPersistForm1099OID()
        {

            var userDataId = 0L;
            List<ErrorMessage> errorMessageList;
            var primaryTaxPayer = IT_PersonalInfo.CreateAndPersistPrimaryTaxPayer(userId, FilingStatus.Single, ref userDataId);

            var form1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            var form1099OIDJson = JsonConvert.SerializeObject(form1099OID);
            taxReturnData.TaxData = form1099OIDJson;
            taxReturnData.UserDataId = userDataId;

            //Persist Form1099OID
            var userData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);

            userData.UserId = userId;
            return userData;
        
        }

        /// <summary>
        /// Creates the form1099 oid.
        /// </summary>
        /// <param name="ownerType">Type of the owner.</param>
        /// <returns></returns>
        public static Form1099OID CreateForm1099OID(OwnerType ownerType)
        {
            Form1099OID form1099OID = null;

            form1099OID = new Form1099OID()
            {
                Form1099OIDId=0,
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
                Description="testContent",
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
                TaxExemptInterestState=new State
                {
                    StateId = mPersonalInfoRepository.GetAllState().First().StateId


                },
                StateExemptInterest = Utilities.CreateRandomNumber(0, 2000),
                TaxExemptInterest = Utilities.CreateRandomNumber(0, 2000),
                Form = FormType.Form1099OID
            };

            return form1099OID;
        }
        #endregion

        #endregion

    }
}
