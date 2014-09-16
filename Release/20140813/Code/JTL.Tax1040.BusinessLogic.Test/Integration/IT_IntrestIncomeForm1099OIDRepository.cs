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

        #region member variables

        private long mUserId;
        static long mUserDataId;
        private static long mStateId;
        private static IPersonalInfoRepository mPersonalInfoRepository;
        private static InterestIncomeRepository mInterestIncomeRepository;
        static ITaxReturnRepository mTaxReturnRepository;
        List<ErrorMessage> errorMessageList;
        static TaxReturnData mTaxReturnData;
        static dynamic mUserData;
      
        

        #endregion

        #region test initialize
        [TestInitialize()]
        public void TestInitialize()
        {
            mPersonalInfoRepository = new PersonalInfoRepository();
            mInterestIncomeRepository= new InterestIncomeRepository();
            mTaxReturnRepository = new TaxReturnRepository();
            //Get State. Use it all over the Test methods.
            mStateId = mPersonalInfoRepository.GetAllState().First().StateId;
            mUserId = IT_UserRepository.PersistNewUser();
            mUserData = new ExpandoObject();
            mUserData.userId = mUserId;
            mTaxReturnData = new TaxReturnData();
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
            // Create and Persist PrimaryTaxPayer and Prepare Form1099OID object
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);
            var expectedForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099OID);
            mTaxReturnData.UserDataId = userData.Item1;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist first Form 1099OID
            var actualForm1099OIDData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(actualForm1099OIDData.UserDataId, mUserId);
            List<Form1099OID> actualForm1099OIDList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            var actualForm1099OID =
                actualForm1099OIDList.FirstOrDefault(x => x.Form1099OIDId == actualForm1099OIDData.Form1099OIDId);

            ValidateForm1099OIDInfoAfterPersist(actualForm1099OID, expectedForm1099OID);

        }

        /// <summary>
        /// Persists the form1099 oid as spouse.
        /// </summary>
        [TestMethod]
        public void PersistForm1099OIDAsSpouse()
        {
            // Create and Persist PrimaryTaxPayer and Prepare Form1099OID object
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);
            var expectedForm1099OID = CreateForm1099OID(OwnerType.Spouse);

            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099OID);
            mTaxReturnData.UserDataId = userData.Item1;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist first Form 1099OID
            var actualForm1099OIDData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(actualForm1099OIDData.UserDataId, mUserId);
            List<Form1099OID> actualForm1099OIDList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            var actualForm1099OID =
                actualForm1099OIDList.FirstOrDefault(x => x.Form1099OIDId == actualForm1099OIDData.Form1099OIDId);

            ValidateForm1099OIDInfoAfterPersist(actualForm1099OID, expectedForm1099OID);


        }

        /// <summary>
        /// Persists the form1099 oid primary taxpayer and spouse.
        /// </summary>
        [TestMethod]
        public void PersistForm1099OIDPrimaryTaxpayerAndSpouse()
        {
            var givenPrimaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(givenPrimaryTaxPayer, mUserId, mUserDataId);
            var expectedPrimayTaxPayerForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            //Serializing PrimaryTax payer Object
            mTaxReturnData.UserDataId = userData.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedPrimayTaxPayerForm1099OID);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist Primary Tax Payer Form 1099OID 
            var exepectedPrimaryTaxPayerUserData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);


            var expectedSpouseForm1099OID = CreateForm1099OID(OwnerType.Spouse);
            var convertingSecondform1099OIDJson = JsonConvert.SerializeObject(expectedSpouseForm1099OID);
            mTaxReturnData.UserDataId = exepectedPrimaryTaxPayerUserData.UserDataId;
            mTaxReturnData.TaxData = convertingSecondform1099OIDJson;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist Spouse Form 1099INT 
            var exepectedSpouseUserData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);

            //Getting the tax return data
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(exepectedPrimaryTaxPayerUserData.UserDataId, mUserId);
            var actualForm1099OIDList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            var actualPrimaryTaxPayerForm1099OID =
                actualForm1099OIDList.FirstOrDefault(x => x.Form1099OIDId == exepectedPrimaryTaxPayerUserData.Form1099OIDId);

            var actualSpouseForm1099OID =
                actualForm1099OIDList.FirstOrDefault(x => x.Form1099OIDId == exepectedSpouseUserData.Form1099OIDId);

            //Validating returned info after persist Form1099INTOID object as PrimaryTaxPayer.
            ValidateForm1099OIDInfoAfterPersist(actualPrimaryTaxPayerForm1099OID, expectedPrimayTaxPayerForm1099OID);

            //Validating returned info after persist Form1099INT object as Spouse.
            ValidateForm1099OIDInfoAfterPersist(actualSpouseForm1099OID, expectedSpouseForm1099OID);

        }

        /// <summary>
        /// Updates the form1099 oid data.
        /// </summary>
        [TestMethod]
        [TestCategory("1099OID")]
        public void UpdateForm1099OIDData()
        {

            var givenPrimaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(givenPrimaryTaxPayer, mUserId, mUserDataId);
            var expectedPrimayTaxPayerForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            //Serializing PrimaryTax payer Object
            mTaxReturnData.UserDataId = userData.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedPrimayTaxPayerForm1099OID);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist Primary Tax Payer Form 1099OID 
            var exepectedPrimaryTaxPayerUserData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);


            var expectedSpouseForm1099OID = CreateForm1099OID(OwnerType.Spouse);
            var convertingSecondform1099OIDJson = JsonConvert.SerializeObject(expectedSpouseForm1099OID);
            mTaxReturnData.UserDataId = exepectedPrimaryTaxPayerUserData.UserDataId;
            mTaxReturnData.TaxData = convertingSecondform1099OIDJson;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist Spouse Form 1099INT 
            var exepectedSpouseUserData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);


            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(exepectedSpouseUserData.UserDataId, mUserId);
            var expectedSpouseForm1099OIDList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;


            // Get Spouse Form 1099INT for Update
            var expectedSpouseForm1099OIDForUpdate = expectedSpouseForm1099OIDList.FirstOrDefault(fInt => fInt.Form1099OIDId == exepectedSpouseUserData.Form1099OIDId);

            expectedSpouseForm1099OIDForUpdate.Owner = OwnerType.Joint;
            expectedSpouseForm1099OIDForUpdate.TaxableInterestAmount = 0;
            expectedSpouseForm1099OIDForUpdate.FederalTaxWithHoldingAmount = 0;

            mTaxReturnData.UserDataId = exepectedSpouseUserData.UserDataId;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedSpouseForm1099OIDForUpdate);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            #region Update Form1099OID
            //Persist Spouse 1099OID Form with Updated values
            var actualSpouse1099OIDData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);
            #endregion

            #region Validating Form1099 with Updated values
            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(exepectedSpouseUserData.UserDataId, mUserId);
            var actualForm1099OIDList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            // Get modified second Form 1099OID 
            var actualSpouseForm1099 = actualForm1099OIDList.FirstOrDefault(fInt => fInt.Form1099OIDId == actualSpouse1099OIDData.Form1099OIDId);
            Assert.AreEqual(expectedSpouseForm1099OIDForUpdate.FederalTaxWithHoldingAmount, actualSpouseForm1099.FederalTaxWithHoldingAmount);
            Assert.AreEqual(expectedSpouseForm1099OIDForUpdate.TaxableInterestAmount, actualSpouseForm1099.TaxableInterestAmount);
            Assert.AreEqual(expectedSpouseForm1099OIDForUpdate.Owner, actualSpouseForm1099.Owner);
            #endregion

        }

        /// <summary>
        /// Persists the and delete form1099 oid data.
        /// </summary>
        [TestMethod]
        public void PersistAndDeleteForm1099OIDData()
        {
            var givenPrimaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(givenPrimaryTaxPayer, mUserId, mUserDataId);
            var expectedPrimayTaxPayerForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            //Serializing PrimaryTax payer Object
            mTaxReturnData.UserDataId = userData.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedPrimayTaxPayerForm1099OID);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist Primary Tax Payer Form 1099OID 
            var exepectedPrimaryTaxPayerUserData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);


            var expectedSpouseForm1099OID = CreateForm1099OID(OwnerType.Spouse);
            var convertingSecondform1099OIDJson = JsonConvert.SerializeObject(expectedSpouseForm1099OID);
            mTaxReturnData.UserDataId = exepectedPrimaryTaxPayerUserData.UserDataId;
            mTaxReturnData.TaxData = convertingSecondform1099OIDJson;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist Spouse Form 1099INT 
            var exepectedSpouseUserData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);

            //Delete second Form 1099INT 
            var userDTO = new UserDTO
            {
                UserId = mUserId,
                UserDataId = exepectedSpouseUserData.UserDataId,
                FormId = exepectedSpouseUserData.Form1099OIDId
            };
            //Delete and Persist 1099OID object
            mInterestIncomeRepository.DeleteAndPersist1099OID(userDTO);

            //Getting the tax return data
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(exepectedPrimaryTaxPayerUserData.UserDataId, mUserId);
            var actualForm1099OIDList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            var actualPrimaryTaxPayerForm1099OID =
                actualForm1099OIDList.FirstOrDefault(x => x.Form1099OIDId == exepectedPrimaryTaxPayerUserData.Form1099OIDId);

            //Validating existing values after deletion
            ValidateForm1099OIDInfoAfterPersist(actualPrimaryTaxPayerForm1099OID, expectedPrimayTaxPayerForm1099OID);

            var actualSpouseForm1099OID =
               actualForm1099OIDList.FirstOrDefault(x => x.Form1099OIDId == exepectedSpouseUserData.Form1099OIDId);

            Assert.IsNull(actualSpouseForm1099OID);
        }

        //swapnesh changed on 25/7/2014
        [TestMethod()]
        public void DeleteForm1099OID()
        {
            var givenPrimaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(givenPrimaryTaxPayer, mUserId, mUserDataId);

            var expectedSpouseForm1099OID = CreateForm1099OID(OwnerType.Spouse);
            mTaxReturnData.UserDataId = userData.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedSpouseForm1099OID); ;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
           
            //Persist Spouse Form 1099INT 
            var exepectedSpouseUserData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);

            //Delete second Form 1099INT 
            var userDTO = new UserDTO
            {
                UserId = mUserId,
                UserDataId = exepectedSpouseUserData.UserDataId,
                FormId = exepectedSpouseUserData.Form1099OIDId
            };
            //Delete and Persist 1099OID object
            mInterestIncomeRepository.DeleteAndPersist1099OID(userDTO);

            mUserData.currentForm1099OIDId = exepectedSpouseUserData.Form1099OIDId;
            var actualDeletedForm1099OID = GetForm1099OID(userDTO);
            Assert.AreEqual(actualDeletedForm1099OID, null);
        }

     
        //Yogalakshmi - 25th July 2014 - Test for Payers Address null.
        [TestMethod()]
        public void PersistForm1099OIDWitOutPayerAddress()
        {
          
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);
            var expectedForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            expectedForm1099OID.Payer.Address = null;
            var firstForm1099OIDJson = JsonConvert.SerializeObject(expectedForm1099OID);
            mTaxReturnData.UserDataId = expectedUserDataID.Item1;
            mTaxReturnData.TaxData = firstForm1099OIDJson;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

          
            //Persist first Form 1099OID 
            var actualForm1099UserDataID = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(actualForm1099UserDataID.UserDataId, mUserId);

            var actualForm1099OIDList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;
            foreach (var actualForm1099OID in actualForm1099OIDList)
            {
                Assert.AreEqual(expectedForm1099OID.Payer.Address, actualForm1099OID.Payer.Address);
            }

        }

        //Yogalakshmi - 25th July 2014 - Test for Payers null.
        [TestMethod()]
        public void PersistForm1099OIDWitOutPayer()
        {
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);
            var expectedForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            expectedForm1099OID.Payer = null;
            var firstForm1099OIDJson = JsonConvert.SerializeObject(expectedForm1099OID);
            mTaxReturnData.UserDataId = expectedUserDataID.Item1;
            mTaxReturnData.TaxData = firstForm1099OIDJson;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);


            //Persist first Form 1099OID 
            var actualForm1099UserDataID = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(actualForm1099UserDataID.UserDataId, mUserId);

            var actualForm1099OIDList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;
            foreach (var actualForm1099OID in actualForm1099OIDList)
            {
                Assert.AreEqual(expectedForm1099OID.Payer, actualForm1099OID.Payer);
            }
        }

        //Yogalakshmi - 25th July 2014 - Test for State Information null.
        [TestMethod()]
        public void PersistForm1099OIDWitoutStateInformation()
        {
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);
            var expectedForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            expectedForm1099OID.Form1099StateInfo = null;
            var firstForm1099OIDJson = JsonConvert.SerializeObject(expectedForm1099OID);
            mTaxReturnData.UserDataId = expectedUserDataID.Item1;
            mTaxReturnData.TaxData = firstForm1099OIDJson;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);


            //Persist first Form 1099OID 
            var actualForm1099UserDataID = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(actualForm1099UserDataID.UserDataId, mUserId);

            var actualForm1099OIDList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;
            foreach (var actualForm1099OID in actualForm1099OIDList)
            {
                Assert.AreEqual(expectedForm1099OID.Form1099StateInfo, actualForm1099OID.Form1099StateInfo);
            }
        }

        //Yogalakshmi - 25th July 2014 - Test for Adding a new State info.
        [TestMethod()]
        public void UpdateNewStateInfo()
        {
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);
            var expectedForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            foreach (var item in expectedForm1099OID.Form1099StateInfo)
            {
                item.StateIdentificationNumber = "1";
            }
            var firstForm1099OIDJson = JsonConvert.SerializeObject(expectedForm1099OID);
            mTaxReturnData.UserDataId = expectedUserDataID.Item1;
            mTaxReturnData.TaxData = firstForm1099OIDJson;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);


            //Persist first Form 1099OID 
            var actualForm1099UserDataID = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(actualForm1099UserDataID.UserDataId, mUserId);

            var actualForm1099OIDList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099OID;

            foreach (var state in actualForm1099OIDList.SelectMany(stateInfo => stateInfo.Form1099StateInfo))
            {
                Assert.AreEqual("1", state.StateIdentificationNumber);
            }
        }


        #region Eligiblity Rules

        /// <summary>
        /// InterestIncome_ER1 - Your Taxable Interest Income should not be Nominee Interest income
        /// InterestIncome_ER2 - Your 1099INT US saving bond Interest income should not include the amount reported before 2014
        /// InterestIncome_ER3 - You should not own any Foreign Financial account such as bank account with combined value over $10,000 at any time during 2014.
        /// InterestIncome_ER4 - Your Interest income should not be from Seller Finance Mortgage Property.
        /// InterestIncome_ER5 - Your OID Interest Income should not be less than the amount reported on 1099OID.
        /// </summary>
        [TestMethod]
        [TestCategory("109INT")]
        public void ValidateInterestIncomeER1ER2ER3ER4ER5()
        {

            // Prepare IncomeTaxEligibility
            var expectedIncomeTaxEligibility = CreateIncomeTaxEligibilitytData();

            var userDTO = new UserDTO { UserId = mUserId, UserDataId = mUserDataId };
            mUserData.UserDTO = JsonConvert.SerializeObject(userDTO);
            mUserData.InterestIncomeEligibility = JsonConvert.SerializeObject(expectedIncomeTaxEligibility);

            //Persist IntereseIncomeEligibility
            var userData = mInterestIncomeRepository.PersistInterestIncomeEligibilityData(mUserData);

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(userData.Item1, mUserId);
            var actualTax1040 = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject);
            Assert.IsTrue(actualTax1040.ErrorMessages.Any(er => er.ErrorCode.Equals("InterestIncome_ER1")));
            Assert.IsTrue(actualTax1040.ErrorMessages.Any(er => er.ErrorCode.Equals("InterestIncome_ER2")));
            Assert.IsTrue(actualTax1040.ErrorMessages.Any(er => er.ErrorCode.Equals("InterestIncome_ER3")));
            Assert.IsTrue(actualTax1040.ErrorMessages.Any(er => er.ErrorCode.Equals("InterestIncome_ER4")));
            Assert.IsTrue(actualTax1040.ErrorMessages.Any(er => er.ErrorCode.Equals("InterestIncome_ER5")));
        }

        /// <summary>
        /// InterestIncome_ER6 - Your Interest Income should not be reduced by amortizable Bond Premium
        /// InterestIncome_ER7 - You should not claim Exclusion of Interest from U. S series EE or I savings bonds in 2014 that were issued after 1989.
        /// InterestIncome_ER8 - Your Adjusted gross Income deduction of Early withdrawal penalty is not deductible in Form 1040EZ.
        /// InterestIncome_ER9 - You have to claim Credit for  Taxes paid to Foreign country. 
        /// </summary>
        [TestMethod]
        [TestCategory("109INT")]
        public void ValidateInterestIncomeER6ER7ER8ER9()
        {
            // Prepare IncomeTaxEligibility
            var expectedIncomeTaxEligibility = CreateIncomeTaxEligibilitytData();

            var userDTO = new UserDTO { UserId = mUserId, UserDataId = mUserDataId };
            mUserData.UserDTO = JsonConvert.SerializeObject(userDTO);
            mUserData.InterestIncomeEligibility = JsonConvert.SerializeObject(expectedIncomeTaxEligibility);

            //Persist IntereseIncomeEligibility
            var userData = mInterestIncomeRepository.PersistInterestIncomeEligibilityData(mUserData);

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(userData.Item1, mUserId);
            var actualTax1040 = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject);
            Assert.IsTrue(actualTax1040.ErrorMessages.Any(er => er.ErrorCode.Equals("InterestIncome_ER6")));
            Assert.IsTrue(actualTax1040.ErrorMessages.Any(er => er.ErrorCode.Equals("InterestIncome_ER7")));
            Assert.IsTrue(actualTax1040.ErrorMessages.Any(er => er.ErrorCode.Equals("InterestIncome_ER8")));
            Assert.IsTrue(actualTax1040.ErrorMessages.Any(er => er.ErrorCode.Equals("InterestIncome_ER9")));
        }


        /// <summary>
        /// Validates InterestIncome_ER10 -  Your Taxable Interest Income on Form 1040EZ (Line 2) should be less than $1,500.
        /// </summary>
        [TestMethod]
        [TestCategory("109INT")]
        public void ValidateInterestIncomeER10()
        {
            //Persist personal data
            var givenPrimaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var userDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(givenPrimaryTaxPayer, mUserId, mUserDataId);
            var expectedForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);
            expectedForm1099OID.TaxableInterestAmount = 1600;
            mTaxReturnData.UserDataId = userDataID.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099OID);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist first Form 1099INT with InterestIncome =1600 value.
            var actualFormOIDData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(actualFormOIDData.UserDataId, mUserId);
            var actualTax1040 = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject);

            Assert.IsTrue(actualTax1040.ErrorMessages.Any(er => er.ErrorCode.Equals("InterestIncome_ER10")));
        }

        private dynamic CreateIncomeTaxEligibilitytData()
        {
            var interestIncomeEligibility = new InterestIncomeEligibility
            {
                HasInterestReceivedAsNominee = true,
                HasPreviousYearsUSBondsInterest = true,
                HasOwnedForeignFinancialAccounts = true,
                HasSellerFinancedMortageInterest = true,
                IsReportingLesserOID = true,
                IsExemptByAmortizableBond = true,
                IsClaimingEEOrIUSBondsInterestAfter1989 = true,
                HasForeignTaxCredit = true,
                HasEarlyWithdrawalPenalty = true,
                HasNoneOfOptions = true
            };
            return interestIncomeEligibility;
        }

        #endregion

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

        private void ValidateForm1099OIDInfoAfterPersist(Form1099OID actualForm1099OID, Form1099OID expectedForm1099OID)
        {

            Assert.AreEqual(expectedForm1099OID.AccountNumber, actualForm1099OID.AccountNumber);
            Assert.AreEqual(expectedForm1099OID.OriginalIssueDiscount, actualForm1099OID.OriginalIssueDiscount);
            Assert.AreEqual(expectedForm1099OID.OtherPeriodicInterest, actualForm1099OID.OtherPeriodicInterest);
            Assert.AreEqual(expectedForm1099OID.Payer.PayerName, expectedForm1099OID.Payer.PayerName);
            Assert.AreEqual(expectedForm1099OID.Payer.PayerIdentificationNumber, actualForm1099OID.Payer.PayerIdentificationNumber);
            Assert.AreEqual(expectedForm1099OID.Payer.Address.AddressId, actualForm1099OID.Payer.Address.AddressId);
            Assert.AreEqual(expectedForm1099OID.Payer.Address.AddressType, actualForm1099OID.Payer.Address.AddressType);
            Assert.AreEqual(expectedForm1099OID.Payer.Address.PayerAddress.City, actualForm1099OID.Payer.Address.PayerAddress.City);
            Assert.AreEqual(expectedForm1099OID.Payer.Address.PayerAddress.StreetAddress, actualForm1099OID.Payer.Address.PayerAddress.StreetAddress);
            Assert.AreEqual(expectedForm1099OID.Payer.Address.PayerAddress.State.StateId, actualForm1099OID.Payer.Address.PayerAddress.State.StateId);
            Assert.AreEqual(expectedForm1099OID.Payer.Address.PayerAddress.ZipCode, actualForm1099OID.Payer.Address.PayerAddress.ZipCode);
            Assert.AreEqual(expectedForm1099OID.EarlyWithdrawalPenalty, actualForm1099OID.EarlyWithdrawalPenalty);
            Assert.AreEqual(expectedForm1099OID.IncomeMarketDiscount, actualForm1099OID.IncomeMarketDiscount);
            Assert.AreEqual(expectedForm1099OID.ForeignTaxPaid, actualForm1099OID.ForeignTaxPaid);
            Assert.AreEqual(expectedForm1099OID.ForeignCountryId, actualForm1099OID.ForeignCountryId);
            Assert.AreEqual(expectedForm1099OID.IsMutualFundRegulatedInvestment, actualForm1099OID.IsMutualFundRegulatedInvestment);
            Assert.AreEqual(expectedForm1099OID.USTreasuryObligations, actualForm1099OID.USTreasuryObligations);
            Assert.AreEqual(expectedForm1099OID.InvestmentExpenses, actualForm1099OID.InvestmentExpenses);
            Assert.AreEqual(expectedForm1099OID.IsStateInformationAvailable, actualForm1099OID.IsStateInformationAvailable);
            Assert.AreEqual(expectedForm1099OID.InterestReceivedAsNominee, actualForm1099OID.InterestReceivedAsNominee);
            Assert.AreEqual(expectedForm1099OID.AdjustmentAmount, actualForm1099OID.AdjustmentAmount);
            Assert.AreEqual(expectedForm1099OID.TaxableInterestAmount, actualForm1099OID.TaxableInterestAmount);
            Assert.AreEqual(expectedForm1099OID.Description, actualForm1099OID.Description);
            Assert.AreEqual(expectedForm1099OID.AcquisitionPremium, actualForm1099OID.AcquisitionPremium);
            Assert.AreEqual(expectedForm1099OID.HasToReportTaxExempt, actualForm1099OID.HasToReportTaxExempt);
            Assert.AreEqual(expectedForm1099OID.HasToReportAdjustment, actualForm1099OID.HasToReportAdjustment);
            Assert.AreEqual(expectedForm1099OID.StateExemptInterest, actualForm1099OID.StateExemptInterest);
            Assert.AreEqual(expectedForm1099OID.TaxExemptInterest, actualForm1099OID.TaxExemptInterest);
            Assert.AreEqual(expectedForm1099OID.Form, actualForm1099OID.Form);
            Assert.AreEqual(expectedForm1099OID.TaxExemptInterestState.StateId, actualForm1099OID.TaxExemptInterestState.StateId);
            Assert.AreEqual(expectedForm1099OID.InterestReceivedAsNominee, actualForm1099OID.InterestReceivedAsNominee);

            if (actualForm1099OID.Form1099StateInfo.Any())
            {
                var expectedForm1099StateInfo = expectedForm1099OID.Form1099StateInfo.ToArray();
                var x = 0;
                foreach (var actualForm1099StateInfo in actualForm1099OID.Form1099StateInfo)
                {
                    Assert.AreEqual(expectedForm1099StateInfo[x].State.StateId, actualForm1099StateInfo.State.StateId);
                    Assert.AreEqual(expectedForm1099StateInfo[x].StateIdentificationNumber,
                        actualForm1099StateInfo.StateIdentificationNumber);
                    Assert.AreEqual(expectedForm1099StateInfo[x].StateTaxWithholdingAmount,
                        actualForm1099StateInfo.StateTaxWithholdingAmount);
                    x += 1;
                }

            }

        }

        #endregion

    }
}
