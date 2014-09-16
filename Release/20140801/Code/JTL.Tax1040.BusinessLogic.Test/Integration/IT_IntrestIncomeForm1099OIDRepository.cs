/*
Copyright   : Copyright Jeevan Technologies
File Name   : IT_IntrestIncomeForm1099OIDRepository.cs 
Description : Business Logic for Tax Return  
Author      : Sathish N
Created Date : 17 Apr 2014

 * Modification History:
---------------------
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
    public class IT_IntrestIncomeForm1099OIDRepository
    {

        #region private local variables
        private long userId;
        private static long mStateId;
        private static IPersonalInfoRepository mPersonalInfoRepository = new PersonalInfoRepository();
        private static InterestIncomeRepository mInterestIncomeRepository = new InterestIncomeRepository();
        static ITaxReturnRepository mTaxReturnRepository;
        List<ErrorMessage> errorMessageList;
        static TaxReturnData taxReturnData;
        private dynamic userInputData;
        #endregion

        #region test initialize
        [TestInitialize()]
        public void TestInitialize()
        {
            //Get State. Use it all over the Test methods.
            mStateId = mPersonalInfoRepository.GetAllState().First().StateId;
            //Get UserId. Use it all over the Test methods.
            //    mUserId = IT_UserRepository.PersistNewUser();
            userId = IT_UserRepository.PersistNewUser();
            //Get Person Id. Use it all over the test method
            mTaxReturnRepository = new TaxReturnRepository();
            userInputData = new ExpandoObject();
            userInputData.userId = userId;
            taxReturnData = new TaxReturnData();
        }
        #endregion

        #region Persist 1099OID
        //Yogalakshmi - 25th July 2014 - Added some methods fro OID from IT_InterestIncomeForm1099INTRepository
        /// <summary>
        /// Persists the form1099 oid as primary tax payer.
        /// </summary>
        [TestMethod]
        public void PersistForm1099OIDAsPrimaryTaxPayer()
        {
            var userDataId = 0L;
            //Persist User
         //   var userId = IT_UserRepository.PersistNewUser();
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);

            List<ErrorMessage> errorMessageList;

            var actualForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            taxReturnData.TaxData = JsonConvert.SerializeObject(actualForm1099OID);
            taxReturnData.UserDataId = expectedUserDataID.Item1;

            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object

            Assert.AreEqual(0, actualForm1099OID.Form1099OIDId);

            //Persist first Form 1099OID
            var expectedUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);



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
            //Persist User
          //  var userId = IT_UserRepository.PersistNewUser();
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.MarriedFilingJointly);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);

            List<ErrorMessage> errorMessageList;

            var actualForm1099OID = CreateForm1099OID(OwnerType.Spouse);

            taxReturnData.TaxData = JsonConvert.SerializeObject(actualForm1099OID);
            taxReturnData.UserDataId = expectedUserDataID.Item1;

            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object

            Assert.AreEqual(0, actualForm1099OID.Form1099OIDId);

            //Persist first Form 1099OID
            var expectedUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);



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
            //Persist User
           // var userId = IT_UserRepository.PersistNewUser();
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.MarriedFilingJointly);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;

            var actualFirstForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            //Serializing Object
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = JsonConvert.SerializeObject(actualFirstForm1099OID);


            //Getting userId  & Tax Return data
            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, userDataId);
            Assert.AreEqual(0, actualFirstForm1099OID.Form1099OIDId);

            //Persist first Form 1099OID 
            var exepectedFirstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);


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


            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, actualSecondForm1099OID.Form1099OIDId);

            //Persist second Form 1099OID 
            var exepectedSecondUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);

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
            var userDataId = 0L;
            //Persist User
       //     var userId = IT_UserRepository.PersistNewUser();
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;

            var actualFirstForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            //Serializing Object
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = JsonConvert.SerializeObject(actualFirstForm1099OID);


            //Getting userId  & Tax Return data
            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, userDataId);
            Assert.AreEqual(0, actualFirstForm1099OID.Form1099OIDId);

            //Persist first Form 1099OID 
            var expectedFirstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);


            //Getting the tax return data
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedFirstUserDataId.UserDataId, userId);
            List<Form1099OID> f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            Assert.AreEqual(1, f1099OIDListObject.Count);

            // Get first Form 1099OID id.
            var FirstForm1099OIDId = f1099OIDListObject[0].Form1099OIDId;

            Assert.IsTrue(f1099OIDListObject[0].Form1099OIDId > 0);

            Assert.AreEqual(actualFirstForm1099OID.FederalTaxWithHoldingAmount, f1099OIDListObject[0].FederalTaxWithHoldingAmount);
            Assert.AreEqual(actualFirstForm1099OID.ForeignCountryId, f1099OIDListObject[0].ForeignCountryId);


            var actualSecondForm1099OID = CreateForm1099OID(OwnerType.Spouse);
            var convertingSecondForm1099OIDJson = JsonConvert.SerializeObject(actualSecondForm1099OID);
            taxReturnData.UserDataId = expectedFirstUserDataId.UserDataId;
            taxReturnData.TaxData = convertingSecondForm1099OIDJson;


            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, actualSecondForm1099OID.Form1099OIDId);

            //Persist second Form 1099OID 
            var expectedSecondUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);

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


            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);


            //Persist second Form 1099OID 
            expectedSecondUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);

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
            var userDataId = 0L;
            //Persist User

            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;


            var actualFirstform1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            var firstForm1099OIDJson = JsonConvert.SerializeObject(actualFirstform1099OID);
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = firstForm1099OIDJson;


            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object

            Assert.AreEqual(0, actualFirstform1099OID.Form1099OIDId);

            //Persist first Form 1099OID 
            var firstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);


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


            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object
            Assert.AreEqual(0, actualForm1099OID.Form1099OIDId);

            //Persist second Form 1099OID
            var secondUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);

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

        //swapnesh changed on 25/7/2014
        [TestMethod()]
        public void DeleteForm1099OID()
        {
            var userDataId = 0L;
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);


            dynamic taxobject = new ExpandoObject();

            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099OID());
            taxReturnData.UserDataId = expectedUserDataID.Item1;

            taxobject.userId = userId;
            taxobject.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);


            var form1099OIDId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxobject);
            Assert.AreNotEqual(0, form1099OIDId.Form1099OIDId);

            UserDTO userDTO = new UserDTO();
            userDTO.UserId = userId;
            userDTO.UserDataId = taxReturnData.UserDataId;
            userDTO.FormId = form1099OIDId.Form1099OIDId;
            mInterestIncomeRepository.DeleteAndPersist1099OID(userDTO);

            userInputData.currentForm1099OIDId = form1099OIDId;
            Form1099OID Form1099OID = GetForm1099OID(userDTO);
            Assert.AreEqual(Form1099OID, null);
        }

     
        //Yogalakshmi - 25th July 2014 - Test for Payers Address null.
        [TestMethod()]
        public void PersistForm1099OIDWitOutPayerAddress()
        {
            var userDataId = 0L;
            //Persist User
          //  var userId = IT_UserRepository.PersistNewUser();
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);

            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;


            var actualFirstform1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);
            actualFirstform1099OID.Payer.Address = null;
            var firstForm1099OIDJson = JsonConvert.SerializeObject(actualFirstform1099OID);
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = firstForm1099OIDJson;


            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);

            //Before persist in tax object

            Assert.AreEqual(0, actualFirstform1099OID.Form1099OIDId);

            //Persist first Form 1099OID 
            var firstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(firstUserDataId.UserDataId, userId);
            List<Form1099OID> f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;
            foreach (var payerAddress in f1099OIDListObject)
            {
                Assert.AreEqual(null, payerAddress.Payer.Address);
            }

        }

        //Yogalakshmi - 25th July 2014 - Test for Payers null.
        [TestMethod()]
        public void PersistForm1099OIDWitOutPayer()
        {
            var userDataId = 0L;
            //Persist User
       //     var userId = IT_UserRepository.PersistNewUser();
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;
            var actualFirstform1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);
            actualFirstform1099OID.Payer = null;
            var firstForm1099OIDJson = JsonConvert.SerializeObject(actualFirstform1099OID);
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = firstForm1099OIDJson;
            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            //Before persist in tax object
            Assert.AreEqual(0, actualFirstform1099OID.Form1099OIDId);
            //Persist first Form 1099OID 
            var firstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(firstUserDataId.UserDataId, userId);
            List<Form1099OID> f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;
            foreach (var payer in f1099OIDListObject)
            {
                Assert.AreEqual(null, payer.Payer);
            }
        }

        //Yogalakshmi - 25th July 2014 - Test for State Information null.
        [TestMethod()]
        public void PersistForm1099OIDWitoutStateInformation()
        {
            var userDataId = 0L;
            //Persist User
         //   var userId = IT_UserRepository.PersistNewUser();
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;
            var actualFirstform1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);
            actualFirstform1099OID.Form1099StateInfo = null;
            var firstForm1099OIDJson = JsonConvert.SerializeObject(actualFirstform1099OID);
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = firstForm1099OIDJson;
            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            //Before persist in tax object
            Assert.AreEqual(0, actualFirstform1099OID.Form1099OIDId);
            //Persist first Form 1099OID 
            var firstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(firstUserDataId.UserDataId, userId);
            List<Form1099OID> f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;
            foreach (var stateInfo in f1099OIDListObject)
            {
                Assert.AreEqual(null, stateInfo.Form1099StateInfo);
            }
        }


        //Yogalakshmi - 25th July 2014 - Test for Adding a new State info.
        [TestMethod()]
        public void UpdateNewStateInfo()
        {
            var userDataId = 0L;
            //Persist User
          //  var userId = IT_UserRepository.PersistNewUser();
            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId);
            List<ErrorMessage> errorMessageList;
            var actualFirstform1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);
            //Update State Identification number
            foreach (var item in actualFirstform1099OID.Form1099StateInfo)
            {
                item.StateIdentificationNumber = "1";
            }
            var firstForm1099OIDJson = JsonConvert.SerializeObject(actualFirstform1099OID);
            taxReturnData.UserDataId = expectedUserDataID.Item1;
            taxReturnData.TaxData = firstForm1099OIDJson;
            userInputData.userId = userId;
            userInputData.TaxReturnData = JsonConvert.SerializeObject(taxReturnData);
            //Before persist in tax object
            Assert.AreEqual(0, actualFirstform1099OID.Form1099OIDId);
            //Persist first Form 1099OID 
            var firstUserDataId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(userInputData);
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(firstUserDataId.UserDataId, userId);
            List<Form1099OID> f1099OIDListObject = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;
            foreach (var stateInfo in f1099OIDListObject)
            {
                foreach (var state in stateInfo.Form1099StateInfo)
                {
                    Assert.AreEqual("1", state.StateIdentificationNumber);
                }
            }
        }


        #endregion


        #region Helper Method

        #region Form1099 OID

        ///// <summary>
        ///// Creates the and persist form1099 oid.
        ///// </summary>
        ///// <returns></returns>
        //public static dynamic CreateAndPersistForm1099OID()
        //{

        //   var userDataId = 0L;
        //    List<ErrorMessage> errorMessageList;
        //    var primaryTaxPayer = IT_PersonalInfo.CreateAndPersistPrimaryTaxPayer(userId, FilingStatus.Single, ref userDataId);

        //    var form1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

        //    var form1099OIDJson = JsonConvert.SerializeObject(form1099OID);
        //    taxReturnData.TaxData = form1099OIDJson;
        //    taxReturnData.UserDataId = userDataId;

        //    //Persist Form1099OID
        //    var userData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);

        //    userData.UserId = userId;
        //    return userData;

        //}

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
        #endregion

        public static Form1099OID CreateForm1099OID()
        {
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
                StateExemptInterest = Utilities.CreateRandomNumber(0, 20),
                Owner = (OwnerType)Utilities.CreateRandomNumber(1, 2),
                TaxExemptInterest = Utilities.CreateRandomNumber(0, 1),
            };

            form1099OID.Form1099StateInfo = new List<Form1099StateInformation>();

            form1099OID.Form1099StateInfo.Add(CreateStatInformation());
            form1099OID.Form1099StateInfo.Add(CreateStatInformation());
            form1099OID.Form1099StateInfo.Add(CreateStatInformation());

            return form1099OID;
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


        public static Form1099OID GetForm1099OID(UserDTO userInputData)
        {
            Form1099OID form1099OID = null;
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.UserId,
         userInputData.UserDataId);
            if (taxObject != null)
            {
                if (taxObject.Income != null && taxObject.Income.Form1099OID != null)
                {
                    form1099OID = taxObject.Income.Form1099OID.Find(frm => frm.Form1099OIDId == userInputData.FormId);
                }
            }
            return form1099OID;
        }

        #endregion

    }
}
