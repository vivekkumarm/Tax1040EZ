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
using System.Activities.Expressions;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        static TaxReturnData mTaxReturnData;
        static dynamic mUserData;
        static long mUserId;
        static long mUserDataId;

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mTaxReturnRepository = new TaxReturnRepository();
            mPersonalInfoRepository = new PersonalInfoRepository();
            mInterestIncomeRepository = new InterestIncomeRepository();
            mTaxReturnData = new TaxReturnData();
            mUserData = new ExpandoObject();
            mUserId = IT_UserRepository.PersistNewUser();
        }

        #region Form 1099INT

        /// <summary>
        /// Persists the form1099 int as primary tax payer.
        /// </summary>
        [TestMethod]
        [TestCategory("1099INT")]
        public void PersistForm1099INTAsPrimaryTaxPayer()
        {
            //Persist personal data
            var givenPrimaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var userDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(givenPrimaryTaxPayer, mUserId, mUserDataId);
            
            var expectedForm1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);
            mTaxReturnData.UserDataId = userDataID.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099INT);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData =JsonConvert.SerializeObject( mTaxReturnData);

            //Persist first Form 1099INT 
            var expectedUserData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);

            // Get Form1099INT object
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedUserData.UserDataId, mUserId);
            var actualForm1099INTList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            var actualForm1099INT = actualForm1099INTList.FirstOrDefault(x => x.Form1099INTId == expectedUserData.Form1099INTId);
            //Validating returned info after persist Form1099INT object as PrimaryTaxPayer.
            ValidateForm1099INTInfoAfterPersist(actualForm1099INT, expectedForm1099INT);
        }
        
        /// <summary>
        /// Persists the form1099 int as spouse.
        /// </summary>
        [TestMethod]
        [TestCategory("1099INT")]
        public void PersistForm1099INTAsSpouse()
        {
            //Persist personal data
            var givenPrimaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var userDataId = mPersonalInfoRepository.PersistPrimaryTaxPayer(givenPrimaryTaxPayer, mUserId, mUserDataId);
           
            var expectedForm1099INT = CreateForm1099INT(OwnerType.Spouse);
            mTaxReturnData.UserDataId = userDataId.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099INT);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            
            //Persist first Form 1099INT 
            var expectedUserData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);

            // Get Form1099INT object
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedUserData.UserDataId, mUserId);
            var actualForm1099INTList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            var actualForm1099INT = actualForm1099INTList.FirstOrDefault(x => x.Form1099INTId == expectedUserData.Form1099INTId);
            //Validating returned info after persist Form1099INT object as PrimaryTaxPayer.
            ValidateForm1099INTInfoAfterPersist(actualForm1099INT, expectedForm1099INT);
        }

        /// <summary>
        /// Persists the form1099 int primary taxpayer and spouse.
        /// </summary>
        [TestMethod]
        [TestCategory("1099INT")]
        public void PersistForm1099INTPrimaryTaxpayerAndSpouse()
        {
            
            var givenPrimaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(givenPrimaryTaxPayer, mUserId, mUserDataId);
            var expectedPrimayTaxPayerForm1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);

            //Serializing PrimaryTax payer Object
            mTaxReturnData.UserDataId = userData.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedPrimayTaxPayerForm1099INT);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);
            
            //Persist Primary Tax Payer Form 1099INT 
            var exepectedPrimaryTaxPayerUserData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);
          
            
            var expectedSpouseForm1099INT = CreateForm1099INT(OwnerType.Spouse);
            var convertingSecondform1099INTJson = JsonConvert.SerializeObject(expectedSpouseForm1099INT);
            mTaxReturnData.UserDataId = exepectedPrimaryTaxPayerUserData.UserDataId;
            mTaxReturnData.TaxData = convertingSecondform1099INTJson;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData =JsonConvert.SerializeObject(mTaxReturnData);
            
            //Persist Spouse Form 1099INT 
            var exepectedSpouseUserData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);

            //Getting the tax return data
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(exepectedPrimaryTaxPayerUserData.UserDataId, mUserId);
            var actualForm1099INTList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            var actualPrimaryTaxPayerForm1099INT =
                actualForm1099INTList.FirstOrDefault(x => x.Form1099INTId == exepectedPrimaryTaxPayerUserData.Form1099INTId);
            
            var actualSpouseForm1099INT =
                actualForm1099INTList.FirstOrDefault(x => x.Form1099INTId == exepectedSpouseUserData.Form1099INTId);
            
            //Validating returned info after persist Form1099INT object as PrimaryTaxPayer.
            ValidateForm1099INTInfoAfterPersist(actualPrimaryTaxPayerForm1099INT, expectedPrimayTaxPayerForm1099INT);

            //Validating returned info after persist Form1099INT object as Spouse.
            ValidateForm1099INTInfoAfterPersist(actualSpouseForm1099INT, expectedSpouseForm1099INT);

        }
        
        /// <summary>
        /// Persists and delete the W2 list data.
        /// </summary>
        [TestMethod]
        [TestCategory("1099INT")]
        public void PersistAndDeleteForm1099INTData()
        {
            var givenPrimaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var userData = mPersonalInfoRepository.PersistPrimaryTaxPayer(givenPrimaryTaxPayer, mUserId, mUserDataId);
            var expectedPrimayTaxPayerForm1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);

            //Serializing PrimaryTax payer Object
            mTaxReturnData.UserDataId = userData.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedPrimayTaxPayerForm1099INT);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist Primary Tax Payer Form 1099INT 
            var exepectedPrimaryTaxPayerUserData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);

            var expectedSpouseForm1099INT = CreateForm1099INT(OwnerType.Spouse);
            var convertingSecondform1099INTJson = JsonConvert.SerializeObject(expectedSpouseForm1099INT);
            mTaxReturnData.UserDataId = exepectedPrimaryTaxPayerUserData.UserDataId;
            mTaxReturnData.TaxData = convertingSecondform1099INTJson;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist Spouse Form 1099INT 
            var exepectedSpouseUserData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);
           
            //Delete second Form 1099INT 
            var userDTO = new UserDTO
            {
                UserId = mUserId,
                UserDataId = exepectedSpouseUserData.UserDataId,
                FormId = exepectedSpouseUserData.Form1099INTId
            };
            //Delete and Persist 1099INT object
            mInterestIncomeRepository.DeleteAndPersist1099INT(userDTO);

            //Getting the tax return data
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(exepectedPrimaryTaxPayerUserData.UserDataId, mUserId);
            var actualForm1099INTList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            var actualPrimaryTaxPayerForm1099INT =
                actualForm1099INTList.FirstOrDefault(x => x.Form1099INTId == exepectedPrimaryTaxPayerUserData.Form1099INTId);

                //Validating existing values after deletion
              ValidateForm1099INTInfoAfterDeleteAndPersist(actualPrimaryTaxPayerForm1099INT, expectedPrimayTaxPayerForm1099INT);

            var actualSpouseForm1099INT =
               actualForm1099INTList.FirstOrDefault(x => x.Form1099INTId == exepectedSpouseUserData.Form1099INTId);

            Assert.IsNull(actualSpouseForm1099INT);
         
        }

        /// <summary>
        /// Updates the Form1099INT PrimaryTaxPayer data.
        /// </summary>
        [TestMethod]
        [TestCategory("1099INT")]
        public void UpdateForm1099INTPrimaryTaxPayer()
        {
            #region Input for updating Form1099

            //Persist personal data
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);

            var expectedPrimaryTaxPayer1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);
            mTaxReturnData.UserDataId = expectedUserDataID.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedPrimaryTaxPayer1099INT);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);


            //Persist PrimaryTax payer 1099INT 
            var expectedPrimaryTaxPayer1099INTData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);

            //Getting the tax return data
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedPrimaryTaxPayer1099INTData.UserDataId, mUserId);
            var expectedForm1099List = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;
            
            // Get Spouse Form 1099INT for Update
            var expectedSpouseForm1099INTForUpdate = expectedForm1099List.FirstOrDefault(fInt => fInt.Form1099INTId == expectedPrimaryTaxPayer1099INTData.Form1099INTId);

            expectedSpouseForm1099INTForUpdate.Owner = OwnerType.Joint;
            expectedSpouseForm1099INTForUpdate.TaxableInterestAmount = 0;
            expectedSpouseForm1099INTForUpdate.FederalTaxWithHoldingAmount = 0;

            mTaxReturnData.UserDataId = expectedPrimaryTaxPayer1099INTData.UserDataId;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedSpouseForm1099INTForUpdate);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            #endregion

            #region Update Form1099INT
            //Persist Primary tax payer 1099INT Form with Updated values
            var actualPrimaryTaxPayer1099INTData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);
            #endregion

            #region Validating Form1099 with Updated values
            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedPrimaryTaxPayer1099INTData.UserDataId, mUserId);
            var actualForm1099List = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            // Get modified form 1099INT 
            var actualPrimaryTaxPayerForm1099 = actualForm1099List.FirstOrDefault(fInt => fInt.Form1099INTId == actualPrimaryTaxPayer1099INTData.Form1099INTId);
            Assert.AreEqual(expectedPrimaryTaxPayer1099INTData.UserDataId, expectedPrimaryTaxPayer1099INTData.UserDataId);
            Assert.AreEqual(expectedSpouseForm1099INTForUpdate.FederalTaxWithHoldingAmount, actualPrimaryTaxPayerForm1099.FederalTaxWithHoldingAmount);
            Assert.AreEqual(expectedSpouseForm1099INTForUpdate.TaxableInterestAmount, actualPrimaryTaxPayerForm1099.TaxableInterestAmount);
            Assert.AreEqual(expectedSpouseForm1099INTForUpdate.Owner, actualPrimaryTaxPayerForm1099.Owner);
            #endregion
        }

        /// <summary>
        /// Updates the Form1099INT PrimaryTaxPayer data.
        /// </summary>
        [TestMethod]
        [TestCategory("1099INT")]
        public void UpdateForm1099INTSpouse()
        {
            #region Input for updating Form1099

            //Persist personal data
            var spouse = IT_PersonalInfo.CreateSpouse();
            var expectedUserDataID = mPersonalInfoRepository.PersistSpouse(spouse, mUserId, mUserDataId);

            var expectedSpouse1099INT = CreateForm1099INT(OwnerType.Spouse);
            mTaxReturnData.UserDataId = expectedUserDataID.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedSpouse1099INT);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);


            //Persist Spouse 1099INT 
            var expectedSpouse1099INTData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);

            //Getting the tax return data
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedSpouse1099INTData.UserDataId, mUserId);
            var expectedForm1099List = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            // Get Spouse Form 1099INT for Update
            var expectedSpouseForm1099INTForUpdate = expectedForm1099List.FirstOrDefault(fInt => fInt.Form1099INTId == expectedSpouse1099INTData.Form1099INTId);

            expectedSpouseForm1099INTForUpdate.Owner = OwnerType.Joint;
            expectedSpouseForm1099INTForUpdate.TaxableInterestAmount = 0;
            expectedSpouseForm1099INTForUpdate.FederalTaxWithHoldingAmount = 0;

            mTaxReturnData.UserDataId = expectedSpouse1099INTData.UserDataId;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedSpouseForm1099INTForUpdate);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            #endregion

            #region Update Form1099INT
            //Persist spouse 1099INT Form with Updated values
            var actualSpouse1099INTData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);
            #endregion

            #region Validating Form1099 with Updated values
            taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(expectedSpouse1099INTData.UserDataId, mUserId);
            var actualForm1099List = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099INT;

            // Get modified form 1099INT 
            var actualSpouseForm1099 = actualForm1099List.FirstOrDefault(fInt => fInt.Form1099INTId == actualSpouse1099INTData.Form1099INTId);
            Assert.AreEqual(expectedSpouse1099INTData.UserDataId, expectedSpouse1099INTData.UserDataId);
            Assert.AreEqual(expectedSpouseForm1099INTForUpdate.FederalTaxWithHoldingAmount, actualSpouseForm1099.FederalTaxWithHoldingAmount);
            Assert.AreEqual(expectedSpouseForm1099INTForUpdate.TaxableInterestAmount, actualSpouseForm1099.TaxableInterestAmount);
            Assert.AreEqual(expectedSpouseForm1099INTForUpdate.Owner, actualSpouseForm1099.Owner);
            #endregion
        }

        #endregion

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
            var expectedForm1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);
            expectedForm1099INT.InterestIncome = 1600;
            mTaxReturnData.UserDataId = userDataID.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099INT);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist first Form 1099INT with InterestIncome =1600 value.
            var actualFormINTData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(actualFormINTData.UserDataId, mUserId);
            var actualTax1040 = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject);

            Assert.IsTrue(actualTax1040.ErrorMessages.Any(er => er.ErrorCode.Equals("InterestIncome_ER10")));
        }

        /// <summary>
        /// Validates InterestIncome_ER10 with INT and OID value -  Your Taxable Interest Income on Form 1040EZ (Line 2) should be less than $1,500.  
        /// </summary>
        [TestMethod]
        [TestCategory("109INT")]
        public void ValidateInterestIncomeER10WithINTAndOID()
        {

            //Persist personal data
            var givenPrimaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var userDataID = mPersonalInfoRepository.PersistPrimaryTaxPayer(givenPrimaryTaxPayer, mUserId, mUserDataId);
            var expectedForm1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);
            expectedForm1099INT.InterestIncome = 800;
            mTaxReturnData.UserDataId = userDataID.Item1;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099INT);
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist first Form 1099INT with InterestIncome =800 value.
            var actualFormINTData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mUserData);

            var expectedForm1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);
            expectedForm1099OID.TaxableInterestAmount = 800;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099OID);
            mTaxReturnData.UserDataId = userDataID.Item1;
            mUserData.userId = mUserId;
            mUserData.TaxReturnData = JsonConvert.SerializeObject(mTaxReturnData);

            //Persist first Form 1099OID
           mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mUserData);

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(actualFormINTData.UserDataId, mUserId);
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


        #region BusinessRules



        #endregion

        #region Form 1099OID

        /// <summary>
        /// Persists the form1099 oid as primary tax payer.
        /// </summary>
        [TestMethod]
        [TestCategory("1099OID")]
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
        [TestCategory("1099OID")]
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
        [TestCategory("1099OID")]
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
        [TestCategory("1099OID")]
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
            var form1099INT = CreateForm1099INT(OwnerType.PrimaryTaxPayer);

            var form1099INTJson = JsonConvert.SerializeObject(form1099INT);
            mTaxReturnData.TaxData = form1099INTJson;
            mTaxReturnData.UserDataId = mUserDataId;

            var userData = mInterestIncomeRepository.PersistTaxReturnForm1099INTData(mTaxReturnData);

            userData.UserId = mUserId;
            return userData;
        }

        /// <summary>
        /// Creates the form1099 int.
        /// </summary>
        /// <param name="ownerType">Type of the owner.</param>
        /// <returns></returns>
        public static Form1099INT CreateForm1099INT(OwnerType ownerType)
        {
            mPersonalInfoRepository = mPersonalInfoRepository ?? new PersonalInfoRepository();

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

        private void ValidateForm1099INTInfoAfterPersist(Form1099INT actualForm1099Int, Form1099INT expectedForm1099INT)
        {
            Assert.IsTrue(actualForm1099Int.Form1099INTId > 0);
            Assert.AreEqual(expectedForm1099INT.ForeignTaxPaid, actualForm1099Int.ForeignTaxPaid);
            Assert.AreEqual(expectedForm1099INT.EarlyWithdrawalPenalty, actualForm1099Int.EarlyWithdrawalPenalty);
            Assert.AreEqual(expectedForm1099INT.USBondsTreasury, actualForm1099Int.USBondsTreasury);
            Assert.AreEqual(expectedForm1099INT.FederalTaxWithHoldingAmount, actualForm1099Int.FederalTaxWithHoldingAmount);
            Assert.AreEqual(expectedForm1099INT.ForeignCountryId, actualForm1099Int.ForeignCountryId);
            Assert.AreEqual(expectedForm1099INT.TaxExemptInterest, actualForm1099Int.TaxExemptInterest);
            Assert.AreEqual(expectedForm1099INT.TaxExemptAccuredInterest, actualForm1099Int.TaxExemptAccuredInterest);
            Assert.AreEqual(expectedForm1099INT.SpecifiedPrivateActivityBond, actualForm1099Int.SpecifiedPrivateActivityBond);
            Assert.AreEqual(expectedForm1099INT.TaxExemptBondCUSIPNumber, actualForm1099Int.TaxExemptBondCUSIPNumber);
            Assert.AreEqual(expectedForm1099INT.BothFederalStateExemptInterest,
                actualForm1099Int.BothFederalStateExemptInterest);
            Assert.AreEqual(expectedForm1099INT.IsStateInformationAvailable, actualForm1099Int.IsStateInformationAvailable);
            Assert.AreEqual(expectedForm1099INT.InterestReceivedAsNominee, actualForm1099Int.InterestReceivedAsNominee);
            Assert.AreEqual(expectedForm1099INT.AccuredInterestInpaymentDates,
                actualForm1099Int.AccuredInterestInpaymentDates);
            Assert.AreEqual(expectedForm1099INT.AmortizableBondPremium, actualForm1099Int.AmortizableBondPremium);
            Assert.AreEqual(expectedForm1099INT.InterestIncome, actualForm1099Int.InterestIncome);
            Assert.AreEqual(expectedForm1099INT.TaxableInterestAmount, actualForm1099Int.TaxableInterestAmount);
            Assert.AreEqual(expectedForm1099INT.WithholdingTaxAmount, actualForm1099Int.WithholdingTaxAmount);
            Assert.AreEqual(expectedForm1099INT.Form, actualForm1099Int.Form);
            Assert.AreEqual(expectedForm1099INT.StateExemptInterest, actualForm1099Int.StateExemptInterest);
            Assert.AreEqual(expectedForm1099INT.TaxExemptInterestState.StateId,
                actualForm1099Int.TaxExemptInterestState.StateId);
            Assert.AreEqual(expectedForm1099INT.Payer.PayerName, actualForm1099Int.Payer.PayerName);
            Assert.AreEqual(expectedForm1099INT.Payer.PayerIdentificationNumber,
                actualForm1099Int.Payer.PayerIdentificationNumber);
            Assert.AreEqual(expectedForm1099INT.Payer.Address.AddressId, actualForm1099Int.Payer.Address.AddressId);
            Assert.AreEqual(expectedForm1099INT.Payer.Address.AddressType, actualForm1099Int.Payer.Address.AddressType);
            Assert.AreEqual(expectedForm1099INT.Payer.Address.PayerAddress.City,
                actualForm1099Int.Payer.Address.PayerAddress.City);
            Assert.AreEqual(expectedForm1099INT.Payer.Address.PayerAddress.StreetAddress,
                actualForm1099Int.Payer.Address.PayerAddress.StreetAddress);
            Assert.AreEqual(expectedForm1099INT.Payer.Address.PayerAddress.StreetAddress,
                actualForm1099Int.Payer.Address.PayerAddress.StreetAddress);
            Assert.AreEqual(expectedForm1099INT.Payer.Address.PayerAddress.ZipCode,
                actualForm1099Int.Payer.Address.PayerAddress.ZipCode);

            if (actualForm1099Int.Form1099StateInfo.Any())
            {
                var expectedW2StateLocalTaxInfo = expectedForm1099INT.Form1099StateInfo.ToArray();
                var x = 0;
                foreach (var actualForm1099StateInfo in actualForm1099Int.Form1099StateInfo)
                {
                    Assert.AreEqual(expectedW2StateLocalTaxInfo[x].State.StateId, actualForm1099StateInfo.State.StateId);
                    Assert.AreEqual(expectedW2StateLocalTaxInfo[x].StateIdentificationNumber,
                        actualForm1099StateInfo.StateIdentificationNumber);
                    Assert.AreEqual(expectedW2StateLocalTaxInfo[x].StateTaxWithholdingAmount,
                        actualForm1099StateInfo.StateTaxWithholdingAmount);
                    x += 1;
                }
            }
        }


        private void ValidateForm1099INTInfoAfterDeleteAndPersist(Form1099INT actualForm1099Int, Form1099INT expectedForm1099INT)
        {
            Assert.IsTrue(actualForm1099Int.Form1099INTId > 0);
            Assert.AreEqual(expectedForm1099INT.ForeignTaxPaid, actualForm1099Int.ForeignTaxPaid);
            Assert.AreEqual(expectedForm1099INT.EarlyWithdrawalPenalty, actualForm1099Int.EarlyWithdrawalPenalty);
            Assert.AreEqual(expectedForm1099INT.USBondsTreasury, actualForm1099Int.USBondsTreasury);
            Assert.AreEqual(expectedForm1099INT.FederalTaxWithHoldingAmount, actualForm1099Int.FederalTaxWithHoldingAmount);
            Assert.AreEqual(expectedForm1099INT.ForeignCountryId, actualForm1099Int.ForeignCountryId);
            Assert.AreEqual(expectedForm1099INT.TaxExemptInterest, actualForm1099Int.TaxExemptInterest);
            Assert.AreEqual(expectedForm1099INT.TaxExemptAccuredInterest, actualForm1099Int.TaxExemptAccuredInterest);
            Assert.AreEqual(expectedForm1099INT.SpecifiedPrivateActivityBond, actualForm1099Int.SpecifiedPrivateActivityBond);
            Assert.AreEqual(expectedForm1099INT.TaxExemptBondCUSIPNumber, actualForm1099Int.TaxExemptBondCUSIPNumber);
            Assert.AreEqual(expectedForm1099INT.BothFederalStateExemptInterest,
                actualForm1099Int.BothFederalStateExemptInterest);
            Assert.AreEqual(expectedForm1099INT.IsStateInformationAvailable, actualForm1099Int.IsStateInformationAvailable);
            Assert.AreEqual(expectedForm1099INT.InterestReceivedAsNominee, actualForm1099Int.InterestReceivedAsNominee);
            Assert.AreEqual(expectedForm1099INT.AccuredInterestInpaymentDates,
                actualForm1099Int.AccuredInterestInpaymentDates);
            Assert.AreEqual(expectedForm1099INT.AmortizableBondPremium, actualForm1099Int.AmortizableBondPremium);
            Assert.AreEqual(expectedForm1099INT.InterestIncome, actualForm1099Int.InterestIncome);
            Assert.AreEqual(expectedForm1099INT.TaxableInterestAmount, actualForm1099Int.TaxableInterestAmount);
            Assert.AreEqual(expectedForm1099INT.WithholdingTaxAmount, actualForm1099Int.WithholdingTaxAmount);
            Assert.AreEqual(expectedForm1099INT.Form, actualForm1099Int.Form);
            Assert.AreEqual(expectedForm1099INT.StateExemptInterest, actualForm1099Int.StateExemptInterest);
            Assert.AreEqual(expectedForm1099INT.TaxExemptInterestState.StateId,
                actualForm1099Int.TaxExemptInterestState.StateId);
            Assert.AreEqual(expectedForm1099INT.Payer.PayerName, actualForm1099Int.Payer.PayerName);
            Assert.AreEqual(expectedForm1099INT.Payer.PayerIdentificationNumber,
                actualForm1099Int.Payer.PayerIdentificationNumber);
            Assert.AreEqual(expectedForm1099INT.Payer.Address.AddressId, actualForm1099Int.Payer.Address.AddressId);
            Assert.AreEqual(expectedForm1099INT.Payer.Address.AddressType, actualForm1099Int.Payer.Address.AddressType);
            Assert.AreEqual(expectedForm1099INT.Payer.Address.PayerAddress.City,
                actualForm1099Int.Payer.Address.PayerAddress.City);
            Assert.AreEqual(expectedForm1099INT.Payer.Address.PayerAddress.StreetAddress,
                actualForm1099Int.Payer.Address.PayerAddress.StreetAddress);
            Assert.AreEqual(expectedForm1099INT.Payer.Address.PayerAddress.StreetAddress,
                actualForm1099Int.Payer.Address.PayerAddress.StreetAddress);
            Assert.AreEqual(expectedForm1099INT.Payer.Address.PayerAddress.ZipCode,
                actualForm1099Int.Payer.Address.PayerAddress.ZipCode);

            if (actualForm1099Int.Form1099StateInfo.Any())
            {
                var expectedForm1099StateInfo = expectedForm1099INT.Form1099StateInfo.ToArray();
                var x = 0;
                foreach (var actualForm1099StateInfo in actualForm1099Int.Form1099StateInfo)
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

        #region Form1099 OID

        /// <summary>
        /// Creates the and persist form1099 oid.
        /// </summary>
        /// <returns></returns>
        public static dynamic CreateAndPersistForm1099OID()
        {

            var userDataId = 0L;
            List<ErrorMessage> errorMessageList;
            var primaryTaxPayer = IT_PersonalInfo.CreateAndPersistPrimaryTaxPayer(mUserId, FilingStatus.Single, ref userDataId);

            var form1099OID = CreateForm1099OID(OwnerType.PrimaryTaxPayer);

            var form1099OIDJson = JsonConvert.SerializeObject(form1099OID);
            mTaxReturnData.TaxData = form1099OIDJson;
            mTaxReturnData.UserDataId = userDataId;

            //Persist Form1099OID
            var userData = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(mTaxReturnData);

            userData.UserId = mUserId;
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

        #endregion

    }
}
