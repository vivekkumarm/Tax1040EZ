/*
Copyright   : Copyright Jeevan Technologies
File Name   : IT_EarnedIncomeCreditRepository.cs 
Description : Integration Test EarnedIncomeCreditRepository 
Author      : vivek
Created Date : 25/May/14

 * Modification History:
------------------------
 * Modified by prasana on 08.07.2014
 * 11August2014 Ashok Kumar - Removed unwanted Bool Varaibales of EIC
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
    public class IT_EarnedIncomeCreditRepository
    {

        #region private local variables

        private long mUserId;
        private int mYear = 2014;
        private long mUserDataId = 0L;
        private static IPersonalInfoRepository mPersonalInfoRepository;
        private static IEarnedIncomeCreditRepository mEarnedIncomeCreditRepository;
        private static IW2Repository mW2Repository;
        private static TaxReturnData mTaxReturnData;
        private dynamic mW2Data;
        private UserDTO mUserDTO;

        #endregion

        #region test initialize

        [TestInitialize()]
        public void TestInitialize()
        {
            mUserDTO = new UserDTO();
            //New User Persist
            mUserId = IT_UserRepository.PersistNewUser();
            mW2Repository = new W2Repository();
            mPersonalInfoRepository = new PersonalInfoRepository();
            mEarnedIncomeCreditRepository = new EarnedIncomeCreditRepository();
            mTaxReturnData = new TaxReturnData();
        }
        #endregion


        /// <summary>
        /// PersistEarnedIncomeCredit
        /// </summary>
        [TestMethod]
        [TestCategory("EIC")]
        public void PersistEarnedIncomeCredit()
        {
            //Prepare EIC
            var expectedEic = CreateEIC();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedEic);

            //Persist EIC
            var expectedEicUserDataId = mEarnedIncomeCreditRepository.PersitEarnedIncomeCredit(mUserId, mTaxReturnData, mYear);

            //Get EIC
            mUserDTO.UserDataId = expectedEicUserDataId;
            mUserDTO.UserId = mUserId;
            var eic = mEarnedIncomeCreditRepository.GetEarnedIncomeCredit(mUserDTO);
            var actualEic = (EIC)eic.Item1;

            
            Assert.AreEqual(expectedEic.HasReceivedIRSNoticeOnEICNotEligible,actualEic.HasReceivedIRSNoticeOnFiling8862);
        }


        /// <summary>
        /// GetEarnedIncomeCredit 
        /// </summary>
        [TestMethod]
        [TestCategory("EIC")]
        public void GetEarnedIncomeCredit()
        {
            //Prepare EIC
            var expectedEic = CreateEIC();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedEic);

            //Persist EIC
            var expectedEicUserDataId = mEarnedIncomeCreditRepository.PersitEarnedIncomeCredit(mUserId, mTaxReturnData, mYear);

            //Get EIC
            mUserDTO.UserDataId = expectedEicUserDataId;
            mUserDTO.UserId = mUserId;
            var eic = mEarnedIncomeCreditRepository.GetEarnedIncomeCredit(mUserDTO);
            var actualEic = (EIC)eic.Item1;

            
            Assert.AreEqual(expectedEic.HasReceivedIRSNoticeOnEICNotEligible, actualEic.HasReceivedIRSNoticeOnFiling8862);
        }      

        /// <summary>
        /// EIC Persist as a primary tax payer
        /// </summary>
        [TestMethod()]
        [TestCategory("EIC")]
        public void EicPersistAsPrimaryTaxPayer()
        {
          
            //Persist personal 
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedUserDataId = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);


            var expectedEic = CreateEIC();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedEic);
            mTaxReturnData.UserDataId = expectedUserDataId.Item1;

            //Persist EIC
            var expectedEicUserDataId = mEarnedIncomeCreditRepository.PersitEarnedIncomeCredit(mUserId, mTaxReturnData, mYear);

            //Get EIC
            mUserDTO.UserDataId = expectedEicUserDataId;
            mUserDTO.UserId = mUserId;
            var eic = mEarnedIncomeCreditRepository.GetEarnedIncomeCredit(mUserDTO);
            var actualEic = (EIC)eic.Item1;

            
            Assert.AreEqual(expectedEic.HasReceivedIRSNoticeOnEICNotEligible, actualEic.HasReceivedIRSNoticeOnFiling8862);

        }

        /// <summary>
        /// PersistEicPrimaryTaxpayerAndSpouse
        /// </summary>
        [TestMethod]
        [TestCategory("EIC")]
        public void PersistEicPrimaryTaxpayerAndSpouse()
        {
            
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.MarriedFilingJointly);
            var expectedUserDataId = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);


            var expectedEic = CreateEIC();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedEic);
            mTaxReturnData.UserDataId = expectedUserDataId.Item1;

            //Persist EIC
            var expectedEicUserDataId = mEarnedIncomeCreditRepository.PersitEarnedIncomeCredit(mUserId, mTaxReturnData, mYear);

            //Get EIC
            mUserDTO.UserDataId = expectedEicUserDataId;
            mUserDTO.UserId = mUserId;
            var eic = mEarnedIncomeCreditRepository.GetEarnedIncomeCredit(mUserDTO);
            var actualEic = (EIC)eic.Item1;

            
            Assert.AreEqual(expectedEic.HasReceivedIRSNoticeOnEICNotEligible, actualEic.HasReceivedIRSNoticeOnFiling8862);
            }

        /// <summary>
        ///GetCreditSummary
        /// </summary>
        [TestMethod]
        [TestCategory("EIC")]
        public void GetCreditSummary()
        {
            //Persist Personal Info
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedPrimaryTaxpayer = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);

            //Persist W2
            var expectedWages = IT_W2Repository.CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedWages.WagesAmount = 10000.00;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedWages);
            mTaxReturnData.UserDataId = expectedPrimaryTaxpayer.Item1;
            var expectedWagesData = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);

            //Persist EIC
            var expectedEic = CreateEIC();
            expectedEic.HasValidSSN = true;
            expectedEic.IsInUSMorethanHalfYear = true;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedEic);
            mTaxReturnData.UserDataId = expectedWagesData.UserDataId;
            var expectedEicUserDataId = mEarnedIncomeCreditRepository.PersitEarnedIncomeCredit(mUserId, mTaxReturnData, mYear);

            //Get EIC
            mUserDTO.UserDataId = expectedEicUserDataId;
            mUserDTO.UserId = mUserId;
            var actualeic = mEarnedIncomeCreditRepository.GetCreditSummary(mUserDTO);
            Assert.IsTrue(actualeic.EICEligibility);
        }


        //Business Rule check for EarnedIncomeCredit_BR3 and EarnedIncomeCredit_BR5
        /// <summary>
        /// BR3 - When "You & your Spouse(MFJ) have a valid SSN that allows you to work" check box not checked
        /// BR5 - When "You & your Spouse (MFJ) lived in  the United States for more than half of the year(2014)" check box not checked
        /// BR6 - When "You are claimed as Qualified Child in another person's tax return" check box not chenked
        /// BR7 - When "You received notice from IRS as 'Not to Claim EIC" check box not chenked
        /// </summary>
        [TestMethod]
        [TestCategory("EIC")]
        public void ValidateEicBR3BR5BR6BR7()
        {

            //Persist Personal Info
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            var expectedPrimaryTaxpayer = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);

            //Persist W2
            var wages = IT_W2Repository.CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            wages.FederalTaxWithholdingAmount = 10000.00;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(wages);
            mTaxReturnData.UserDataId = expectedPrimaryTaxpayer.Item1;
            var expectedWages = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);


            //Persist EIC
            var expectedEic = CreateEIC();
            expectedEic.HasValidSSN = false;
            expectedEic.IsInUSMorethanHalfYear = false;
            expectedEic.HasClaimedAsQualifyingChild = true;
            expectedEic.HasReceivedIRSNoticeOnEICNotEligible = true;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedEic);
            mTaxReturnData.UserDataId = expectedWages.UserDataId;
            var expectedEicUserDataId = mEarnedIncomeCreditRepository.PersitEarnedIncomeCredit(mUserId, mTaxReturnData, mYear);

            //Get EIC
            mUserDTO.UserDataId = expectedEicUserDataId;
            mUserDTO.UserId = mUserId;
            BusinessObject.Tax1040 actualEicData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserDTO.UserId,
            mUserDTO.UserDataId);

            // When "You & your Spouse(MFJ) have a valid SSN that allows you to work" check box not checked
            Assert.IsTrue(actualEicData.ErrorMessages.Any(er => er.ErrorCode.Equals("EarnedIncomeCredit_BR3")));
            // when "You & your Spouse (MFJ) lived in  the United States for more than half of the year(2014)" check box not checked
            Assert.IsTrue(actualEicData.ErrorMessages.Any(er => er.ErrorCode.Equals("EarnedIncomeCredit_BR5")));
            // When "You are claimed as Qualified Child in another person's tax return" check box not chenked
            Assert.IsTrue(actualEicData.ErrorMessages.Any(er => er.ErrorCode.Equals("EarnedIncomeCredit_BR6")));
            // When "You received notice from IRS as 'Not to Claim EIC" check box not chenked
            Assert.IsTrue(actualEicData.ErrorMessages.Any(er => er.ErrorCode.Equals("EarnedIncomeCredit_BR7")));
        }



        /// <summary>
        ///Page level error messages When filing status is given as single
        /// </summary>
        [TestMethod]
        [TestCategory("EIC")]
        public void ValidateEicEiWithFilingStatusAsSingle()
                {

            //Persist Personal Info
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.Single);
            primaryTaxPayer.Person.HasClaimedAsDependent = true;
            primaryTaxPayer.Person.DateOfBirth = DateTime.Now;
            var expectedPrimaryTaxpayer = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);

            //Persist W2
            var expectedWages = IT_W2Repository.CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedWages.FederalTaxWithholdingAmount = 15000.00;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedWages);
            mTaxReturnData.UserDataId = expectedPrimaryTaxpayer.Item1;
            mW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);

            //Get EIC
            mUserDTO.UserDataId = mW2Data.UserDataId;
            mUserDTO.UserId = mUserId;
            var eic = mEarnedIncomeCreditRepository.GetEarnedIncomeCredit(mUserDTO);
            var actualEic = (IEnumerable<ErrorMessage>)eic.Item4;

            var actualEI13ErrorMessage = actualEic.FirstOrDefault(x => x.ErrorCode == Constants.EIC_INFO_TAXPAYER_CLAIM_DEPENDENT);
            Assert.IsNotNull(actualEI13ErrorMessage.ErrorText);
            var actualEI15ErrorMessage = actualEic.FirstOrDefault(x => x.ErrorCode == Constants.EIC_INFO_TAXPAYER_AGE_LIMIT);
            Assert.IsNotNull(actualEI15ErrorMessage.ErrorText);

        }


        /// <summary>
        ///Page level error messages When filing status is given as MFJ
        /// </summary>
        [TestMethod]
        [TestCategory("EIC")]
        public void ValidateEicEiWithFilingStatusAsMFJ()
            {
           // var hasEligibilityDiagnostics = false;
            //Persist Primary Taxpayer
            var primaryTaxPayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.MarriedFilingJointly);
            primaryTaxPayer.Person.HasClaimedAsDependent = true;
            primaryTaxPayer.Person.DateOfBirth = DateTime.Now;
            var expectedPrimaryTaxpayer = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, mUserId, mUserDataId);

            //Persist Spouse
            var spouse = IT_PersonalInfo.CreateAndPersistSpouse(mUserId, expectedPrimaryTaxpayer.Item1);
            spouse.Person.HasClaimedAsDependent = true;
            spouse.Person.DateOfBirth = DateTime.Now;
            var expectedSpouse = mPersonalInfoRepository.PersistSpouse(spouse, mUserId, expectedPrimaryTaxpayer.Item1);

            //Persist Wages Object
            var w2 = IT_W2Repository.CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            w2.FederalTaxWithholdingAmount = 15000.00;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            mTaxReturnData.UserDataId = expectedSpouse.Item1;
            mW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);

            //Get EIC
            mUserDTO.UserDataId = mW2Data.UserDataId;
            mUserDTO.UserId = mUserId;

            var eic = mEarnedIncomeCreditRepository.GetEarnedIncomeCredit(mUserDTO);
            var actualEic = (IEnumerable<ErrorMessage>)eic.Item4;

            var actualEI13ErrorMessage = actualEic.FirstOrDefault(x => x.ErrorCode == Constants.EIC_INFO_TAXPAYER_SPOUSE_CLAIM_DEPENDENT);
            Assert.IsNotNull(actualEI13ErrorMessage.ErrorText);
            var actualEI15ErrorMessage = actualEic.FirstOrDefault(x => x.ErrorCode == Constants.EIC_INFO_TAXPAYER_SPOUSE_AGE_LIMIT);
            Assert.IsNotNull(actualEI15ErrorMessage.ErrorText);

                    }

        #region Helper Method


        public static EIC CreateEIC()
        {
            var eic = new EIC
            {
                HasValidSSN =  Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                IsInUSMorethanHalfYear =  Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                HasEICForPriorYearDisallowance =  Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                HasReceivedIRSNoticeOnFiling8862 =  Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                HasIncorrectlyReportedEarnedIncome =  Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                
                HasClaimedAsQualifyingChild = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                HasPenalInstitutionInmateWages = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                HasReceivedIRSNoticeOnEICNotEligible = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                PenalInstitutionInmateWages = Utilities.CreateRandomNumber(0, 20),
                PensionAnnuity = Utilities.CreateRandomNumber(0, 20),
                IsProhibitedFromClaimingEIC = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                IsNonResidentAlien = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                NumberOfDaysSpouseLivedInUS = Utilities.CreateRandomNumber(0, 20),
                NumberOfDaysTaxPayerLivedInUS = Utilities.CreateRandomNumber(0, 20)

            };
            return eic;
        }


        public static EIC CreateEIC(EmploymentType employmentType, OwnerType ownerType)
        {
            EIC eic = new EIC
            {
                HasValidSSN = true,
                IsInUSMorethanHalfYear = true,
                HasEICForPriorYearDisallowance = true,
                //HasPensionAnnuity = true,
                HasReceivedIRSNoticeOnFiling8862 = true,
                HasIncorrectlyReportedEarnedIncome = true,
                //HasTaxableScholarshipCredits = true,

            };
            return eic;
        }


        #endregion

    }
}
