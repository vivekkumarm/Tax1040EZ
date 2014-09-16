/*
Copyright   : Copyright Jeevan Technologies
File Name   : IT_W2Repository.cs 
Description : Business Logic testing for W2 
Author      : Bala
Created Date : 16 Apr 2014

 * Modification History:
---------------------
 * 23 July 2014 - Removed unused varaibles errorMessageList,
 */
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using System.Collections.Generic;
using Newtonsoft.Json;
using Tax1040WorkFlow.WorkFlow.Activities;
using System.Activities;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;

namespace JTL.Tax1040.BusinessLogic.Test
{
    [TestClass]
    public class IT_W2Repository
    {
        static IW2Repository mW2Repository;
        static ITaxReturnRepository mTaxReturnRepository;
        static IPersonalInfoRepository mPersonalInfoRepository;
        static TaxReturnData mTaxReturnData;
        static long mUserId;
        const double MEDICARE_TAXWITHHOLDING_AMOUNT_LIMIT = 1.46 / 100;
        const double SOCIALSECURITY_TAXWITHHOLDING_AMOUNT_LIMIT = 6.21 / 100; 

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mW2Repository = new W2Repository();
            mTaxReturnRepository = new TaxReturnRepository();
            mPersonalInfoRepository = new PersonalInfoRepository();
            mTaxReturnData = new TaxReturnData();
            mUserId = IT_UserRepository.PersistNewUser();
        }

        /// <summary>
        /// Persist the W2 with RegualrWages and Household Wages.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void PersistW2DataWithRWAndHW()
        {
            //Prepare RegularWages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data);

            //Persist RegularWages W2 object
            var actualregularWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);

            // Get RegularWages W2 object after Persist
            var userDTO = new UserDTO {UserId = mUserId, UserDataId = actualregularWagesW2Data.UserDataId};
            var actualW2Data = mW2Repository.GetTaxReturnW2List(userDTO);

            ValidateRegularWagesDataAfterPersist(actualW2Data, actualregularWagesW2Data, expectedRegularWagesW2Data);

            //Prepare HouseholdEmployeeWages W2 object.
            var givenHouseholdEmployeeWagesW2Data = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.Spouse);
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(givenHouseholdEmployeeWagesW2Data);
            mTaxReturnData.UserDataId = actualregularWagesW2Data.UserDataId;

            //Perist HouseholdEmployment W2 object
            var actualHouseholdEmployeeWageW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);

            // Get HouseholdEmployment W2 object after Persist
            actualW2Data = mW2Repository.GetTaxReturnW2List(userDTO);
           
            ValidateHouseholdEmployeeWagesDataAfterPersist(actualW2Data, actualHouseholdEmployeeWageW2Data, givenHouseholdEmployeeWagesW2Data);
        }

        
        /// <summary>
        /// Delete And Persist W2 
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void DeleteAndPersistAMWAndTSIncomeW2Data()
        {

            //prepare ActiveDutyMilitaryWages w2 object
            var expectedActiveDutyMilitaryWagesW2Data = CreateW2(EmploymentType.ActiveDutyMilitaryWages, OwnerType.PrimaryTaxPayer);
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedActiveDutyMilitaryWagesW2Data);

            //Persist ActiveDutyMilitaryWages W2 object
            var actualActiveDutyMilitaryWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);

            //prepare TaxableScholarshipIncome w2 object
            var expectedTaxableScholarshipIncomeW2Data = CreateW2(EmploymentType.TaxableScholarshipIncome, OwnerType.Spouse);
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedTaxableScholarshipIncomeW2Data);
            mTaxReturnData.UserDataId = actualActiveDutyMilitaryWagesW2Data.UserDataId;

            //Persist TaxableScholarshipIncome W2 object
            var actualTaxableScholarshipIncomeData = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);
         
            var userDTO = new UserDTO { UserId = mUserId, UserDataId = actualActiveDutyMilitaryWagesW2Data.UserDataId, FormId = actualActiveDutyMilitaryWagesW2Data.W2Id };
            //Delete ActiveDutyMilitaryWages W2 object
            mW2Repository.DeleteAndPersistW2(userDTO);

            List<W2> actulaW2DataList = mW2Repository.GetTaxReturnW2List(userDTO);
            // Deleted ActiveDutyMilitaryWages W2 object
            var w2ActiveDutyMilitaryWages = actulaW2DataList.FirstOrDefault(w => w.W2Id == actualActiveDutyMilitaryWagesW2Data.W2Id);
            Assert.IsNull(w2ActiveDutyMilitaryWages);

            // Exist TaxableScholarshipIncome W2 object
            var w2TaxableScholarshipIncome = actulaW2DataList.FirstOrDefault(w => w.W2Id == actualTaxableScholarshipIncomeData.W2Id);
            Assert.IsNotNull(w2TaxableScholarshipIncome);
        }

        #region Business Rule

        //Business Rule check for Wages_BR1, Wages_BR3 and Wages_BR4
        /// BR1 - Federal Tax withhelding amount(Box 2) greater than Federal wages(Box 1)
        /// BR3 - Box 4 Social Security Tax Withheld is limited to 6.20% of Box  3 Social Security Wages
        /// BR4 - Box 6 Medicare Tax Withheldis limited to 1.45% of Box 5 Medicare Wages
        [TestMethod]
        [TestCategory("W2")]
        public void ValidateW2BR1BR3BR4()
        {

            //Prepare RegularWages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            //Inputs for validating BR1 BR3 and BR4
            GivenWagesInfoForValidatingBR1BR3BR4(expectedRegularWagesW2Data);

            // Perist RegularWages W2 object.
            var taxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) };
            var actualregularWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);
          
            //Get RegularWages W2 object.
            BusinessObject.Tax1040 actualW2Data = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualregularWagesW2Data.UserDataId);

            Assert.IsTrue(actualregularWagesW2Data.UserDataId > 0);
            //Federal Tax withhelding amount(Box 2) greater than Federal wages(Box 1)
            Assert.IsTrue(actualW2Data.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR1")));
            //Box 4 Social Security Tax Withheld is limited to 6.20% of Box  3 Social Security Wages
            Assert.IsTrue(actualW2Data.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR3")));
            //Box 6 Medicare Tax Withheldis limited to 1.45% of Box 5 Medicare Wages
            Assert.IsTrue(actualW2Data.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR4")));
        }

       

        /// <summary>
        /// Business Rule check for Wages_BR5, Wages_BR6 and Wages_BR7
        /// BR5 - EmployerCode with value REmployeeContributionsToAnArcherMSA
        /// BR6 - EmployerCode with value TAdoptionBenefits
        /// BR7 - EmployerCode with value WEmployerAndEmployeeContributionsToAHealthSavingsAccount
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidateArcherMedicalSavingsAmount()
        {

            //Prepare RegularWages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>();
            expectedRegularWagesW2Data.W2EmployerCodes.Add(new W2EmployerCode()
            {
                EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA
            });
            var taxReturnData = new TaxReturnData {TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data)};

            // Perist RegularWages W2 object.
            var actualRegularWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);


            //Get RegularWages W2 object and Validating Wages_BR5
            BusinessObject.Tax1040 actualW2Data = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualRegularWagesW2Data.UserDataId); 
            Assert.IsTrue(actualRegularWagesW2Data.UserDataId > 0);
            Assert.IsTrue(actualW2Data.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR5")));

            ///////////////////////////
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>();
            expectedRegularWagesW2Data.W2EmployerCodes.Add(new W2EmployerCode()
            {
                EmployerCode = EmployerCode.TAdoptionBenefits
            });
            taxReturnData.TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data);

            // Perist RegularWages W2 object.
            actualRegularWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);


            //Get RegularWages W2 object and Validating Wages_BR6
            actualW2Data = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualRegularWagesW2Data.UserDataId); 
            Assert.IsTrue(actualRegularWagesW2Data.UserDataId > 0);
            Assert.IsTrue(actualW2Data.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR6")));

            ////////////////////////////////
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>();
            expectedRegularWagesW2Data.W2EmployerCodes.Add(new W2EmployerCode()
            {
                EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount
            });
            taxReturnData.TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data);

            // Perist RegularWages W2 object.
            actualRegularWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);


            //Get RegularWages W2 object and Validating Wages_BR7
            actualW2Data = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualRegularWagesW2Data.UserDataId); 
            Assert.IsTrue(actualW2Data.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR7")));
        }



        /// <summary>
        /// Business Rule check for Wages_BR8 
        /// BR8 - State Wages should not be more than Box 1 Federal Wages.
        /// </summary>
        /// 23 Jun 14 vivek created for business rule 
        [TestMethod]
        [TestCategory("W2")]
        public void ValidateStateWagesGreaterThanFederalWages()
        {
            
            //Prepare RegularWages W2 object
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            //Inputs for validating BR8
            GivenWagesInfoForValidatingBR8(expectedRegularWagesW2Data);
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data);

            // Perist RegularWages W2 object.
            var actualRegularWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);
 
            BusinessObject.Tax1040 actualW2Data = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualRegularWagesW2Data.UserDataId);
            Assert.IsTrue(actualW2Data.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR8")));
        }

       

        /// <summary>
        /// Business Rule check for Wages_BR9
        /// BR9 - Box 17 State Tax Withheld should be greater than Box 16 State wages or Box 1 Federal wages
        /// </summary>
        /// 23 Jun 14 vivek created for business rule
        [TestMethod]
        [TestCategory("W2")]
        public void StateTaxWithheldGreaterThanStateTaxAndWagesOrFederalWages()
        {
           
            //Prepare RegularWages W2 object
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            //Inputs for validating  BR9
            GivenWagesInfoForValidatingStateTaxwithHeldingGreatherThanStateWages(expectedRegularWagesW2Data);
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data);

            // Perist RegularWages W2 object.
            var actualRegularWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);

            //Get RegularWages W2 object.
            BusinessObject.Tax1040 actualW2Data = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualRegularWagesW2Data.UserDataId); 

            Assert.IsTrue(actualW2Data.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR9")));

            //Prepare RegularWages W2 object
            GivenWagesInfoForValidatingStateTaxwithHeldingGreatherThanFederalWages(expectedRegularWagesW2Data);
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data);

            // Perist RegularWages W2 object.
            actualRegularWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);
   

            //Get RegularWages W2 object.
            actualW2Data = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualRegularWagesW2Data.UserDataId);

            Assert.IsTrue(actualW2Data.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR9")));
        }

        

        //TODO
        /// <summary>
        /// Your Household employee wages should not be greater than $1,800.
        /// </summary>
        /// 23 jun 14 vivek Business Rule check for HouseholdEmployeeWages
        [TestMethod]
        [TestCategory("W2")]
        public void HouseholdEmployeeWagesGreater1800Dollar()
        {
            ////Business #8 
            ////Create w2
            ////Yogalakshmi - 1st August 2014 - Changed the employment type to household
            //var w2 = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.PrimaryTaxPayer);

            //w2.Employer = new Employer();
            //w2.Employer.HouseholdEmployeeWages = 1900;

            //taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            //var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            //Assert.IsTrue(userData.UserDataId > 0);
            ////var errorMessage = mTaxReturnRepository.GetIncomeSummary(userId, userData.UserDataId);
            //BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            //Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR10")));

        }

        #endregion

        /// <summary>
        /// Check the Total wages
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void CheckTotalWages()
        {
            //Prepare RegularWages W2 object
            //First Record
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.FederalTaxWithholdingAmount = 10000;
            expectedRegularWagesW2Data.WagesAmount = 1000;
           
            var taxReturnData = new TaxReturnData {TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data)};

            // Perist RegularWages W2 object.
            var actualRegularWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);


            //Prepare RegularWages W2 object 
            //Second Record
            expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.FederalTaxWithholdingAmount = 10000;
            expectedRegularWagesW2Data.WagesAmount = 2000;

            // Perist RegularWages W2 object.
            taxReturnData.TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data);

            actualRegularWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);

            //Get RegularWages W2 object.
            BusinessObject.Tax1040 actualW2Data = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualRegularWagesW2Data.UserDataId);

            //Get the total wages from the work flow
            dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
            input.Tax1040Object = actualW2Data;
            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new W2WithNoValidation(), input));
            //Check the total wages is correct
            Assert.IsTrue(output.TotalWages == 3000);

        }

        /// <summary>
        /// Check the total federal with hold amount
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void CheckTotalFederalWithHold()
        {
            //Prepare RegularWages W2 object
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            // Federal TaxWith holding Amount is greater than Wages
            expectedRegularWagesW2Data.FederalTaxWithholdingAmount = 10000;
            expectedRegularWagesW2Data.WagesAmount = 1000;
            
            var taxReturnData = new TaxReturnData {TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data)};

            // Perist RegularWages W2 object.
            var actualRegularWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);

            expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            // Federal TaxWith holding Amount is greater than Wages
            expectedRegularWagesW2Data.FederalTaxWithholdingAmount = 10000;
            expectedRegularWagesW2Data.WagesAmount = 2000;

            
            taxReturnData.TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data);

            // Perist RegularWages W2 object.
            actualRegularWagesW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);

            BusinessObject.Tax1040 actualW2Data = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualRegularWagesW2Data.UserDataId);

            //Get the total Federal Tax With holding amount
            dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
            input.Tax1040Object = actualW2Data;
            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new FW2FederalTaxWithholding(), input));
            //Check the TotalW2 Federal Tax With hold
            Assert.IsTrue(output.TotalW2FederalTaxWithhold == 20000);
        }

        /// <summary>
        /// Check the total federal with hold amount
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void CheckMFJTotalFederalWithHold()
        {
            // Creates W2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            // Federal TaxWith holding Amount is greater than Wages
            w2.FederalTaxWithholdingAmount = 10000;
            w2.WagesAmount = 1000;

            // Perist W2
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            var userReturnData = mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);

            Assert.IsTrue(userReturnData.UserDataId > 0);


            w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.Spouse);
            // Federal TaxWith holding Amount is greater than Wages
            w2.FederalTaxWithholdingAmount = 10000;
            w2.WagesAmount = 2000;

            // Perist W2
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            mW2Repository.PersistW2TaxReturnData(mUserId, taxReturnData);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userReturnData.UserDataId);

            //Get the total Federal Tax With holding amount
            dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
            input.Tax1040Object = taxObject;
            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new FW2FederalTaxWithholding(), input));
            //Check the TotalW2 Federal Tax With hold
            Assert.IsTrue(output.TotalW2FederalTaxWithhold == 20000);
        }
       
        #region Eligibility Rule

        /// <summary>
        /// Allocated Tips should be reported on Form 1040
        /// </summary>
        /// 23 jun 14 vivek Eligibility Rule check for AllocatedTips
        [TestMethod]
        [TestCategory("W2")]
        public void AllocatedTipsShouldBeReportedTo1040()
        {
            //Eligibility #1
            // Prepare RegularWages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.AllocatedTipsAmount = 1;

            //Persist RegularWages W2 object with AllocatedTipsAmount
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate ALLOCATED_TIPS value.
            BusinessObject.Tax1040 actualW2Data = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(actualW2Data.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.ALLOCATED_TIPS)));
        }
        /// <summary>
        /// Box 10 Dependent care benefits Should be reported on Form 1040
        /// </summary>
        /// 23 jun 14 vivek Eligibility Rule check for Dependent Care Benefits
        [TestMethod]
        [TestCategory("W2")]
        public void ValidateDependentCareBenefitsShouldBeReportedTo1040()
        {
            //Eligibility #2
            // Prepare RegularWages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.DependentCareBenefitsAmount = 1;

            //Persist RegularWages W2 object with DependentCareBenefitsAmount
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData{TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate DEPENDENT_CARE_BENEFITS value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.DEPENDENT_CARE_BENEFITS)));
        }
        [TestMethod]
        [TestCategory("W2")]
        public void ValidateER3()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = GetW2EmployerCode(EmployerCode.AUncollectedSocSecOrRRTATaxOnTips, 100);

            //Persist RegularWages W2 object with DependentCareBenefitsAmount
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate DEPENDENT_CARE_BENEFITS value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_A_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TIPS)));
           
        }

        [TestMethod]
        [TestCategory("W2")]
        public void ValidateER4()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = GetW2EmployerCode(EmployerCode.BUncollectedMedicareTaxOnTips, 100);

            //Persist RegularWages W2 object with DependentCareBenefitsAmount
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate DEPENDENT_CARE_BENEFITS value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_B_UNCOLLECTED_MEDICARE_TAX_ON_TIPS)));
         
        }

        [TestMethod]
        [TestCategory("W2")]
        public void ValidateER5()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = GetW2EmployerCode(EmployerCode.KExciseTaxOnExcessGoldenParachutePayments, 100);

            //Persist RegularWages W2 object with DependentCareBenefitsAmount
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate DEPENDENT_CARE_BENEFITS value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_K_EXCISE_TAX_ON_GOLDEN_PARACHUTE_PAYMENTS)));

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_K_EXCISE_TAX_ON_GOLDEN_PARACHUTE_PAYMENTS)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_M_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TAXABLE_GROUP)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_N_UNCOLLECTED_MEDICARE_TAX_ON_TAXABLE_GROUP)));
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_Z_INCOME_RECEIVED_UNDER_409A)));
        }

        [TestMethod]
        [TestCategory("W2")]
        public void ValidateER6()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = GetW2EmployerCode(EmployerCode.MUncollectedSocSecOrRRTATaxOnGrpTermsLifeIns, 100);

            //Persist RegularWages W2 object with DependentCareBenefitsAmount
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate DEPENDENT_CARE_BENEFITS value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_M_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TAXABLE_GROUP)));
          
        }

        [TestMethod]
        [TestCategory("W2")]
        public void ValidateER7()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = GetW2EmployerCode(EmployerCode.NUncollectedMedicareTaxOnGroupTermLifeInsurance, 100);

            //Persist RegularWages W2 object with DependentCareBenefitsAmount
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate DEPENDENT_CARE_BENEFITS value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_N_UNCOLLECTED_MEDICARE_TAX_ON_TAXABLE_GROUP)));
       
        }

        [TestMethod]
        [TestCategory("W2")]
        public void ValidateER8()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = GetW2EmployerCode(EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan, 100);

            //Persist RegularWages W2 object with DependentCareBenefitsAmount
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate DEPENDENT_CARE_BENEFITS value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_Z_INCOME_RECEIVED_UNDER_409A)));
        }

        [TestMethod]
        [TestCategory("W2")]
        public void ValidateER9()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.HasForeignEmployment = true;

            //Persist RegularWages W2 object with DependentCareBenefitsAmount
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate DEPENDENT_CARE_BENEFITS value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.FOREIGN_EMPLOYMENT_MUST_REPORT)));

        }
      
        #endregion

        #region Required Entries

        [TestMethod]
        [TestCategory("W2")]
        public void ValidateEmployerIdentificationNumber()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF3
            expectedRegularWagesW2Data.Employer.Organization.EIN = string.Empty;

            // Perist RegularWages W2 object with  EIN as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate WAGES_EIN value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId); 
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EIN)));

        }

        /// <summary>
        /// Validates Wages_RF16 - State Identification Number should not be Empty
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidateStateLocalInfo15AStateIdRequiredOnStateCode()
        {
            // Prepare RegularWages W2 object.
            var expectedW2RegularWagesData = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            // Inputs for validating Wages_RF16
            expectedW2RegularWagesData.Employer.Organization.EIN = string.Empty;
            foreach (W2StateLocalTaxInfo w2StateLocalInfo in expectedW2RegularWagesData.W2StateLocalTaxInfo)
            {
                w2StateLocalInfo.State = new State()
                {
                    StateId = 0
                };
            }

            // Perist RegularWages W2 object filled StateId =0
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData {TaxData = JsonConvert.SerializeObject(expectedW2RegularWagesData)});

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_STATE_LOCAL_STATE_ID)));

        }


        /// <summary>
        /// Validates Wages_RF17 - State Wages Should not be Empty. If none, enter Zero.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidateStateLocalInfoStateWagesRequiredOnStateCode()
        {
            // Prepare W2 RegularWages object.
            var expectedW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            foreach (var expectedW2StateLocalTaxInfo in expectedW2Data.W2StateLocalTaxInfo)
            {
                expectedW2StateLocalTaxInfo.StateWagesAmount = null;
            }
            var expectedTaxReturnData = new TaxReturnData {TaxData = JsonConvert.SerializeObject(expectedW2Data)};

            // Persist RegularWages object with W2SateLocalTaxInfo as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);
            
            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); 
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_STATE_LOCAL_STATE_WAGES)));
        }

        #endregion


        //TODO
        #region Validation
        [TestMethod]
        //public void ValidateEmployerIdentificationNumber()
        //{
            //// Creates W2
            //var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            //w2.Employer.Organization.EIN = "123-45665455555A";

            //// Perist W2
            //TaxReturnData taxReturnData = new TaxReturnData();
            //taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            //var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            //Assert.IsTrue(userData.UserDataId > 0);

            //BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            //Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_EIN_INVALID)));

        //}
        #endregion
     
        #region Helper Methods


        /// <summary>
        /// Creates the and persist w2.
        /// </summary>
        /// <returns></returns>
        public static dynamic CreateAndPersistW2()
        {
            var userDataId = 0L;
            var primaryTaxPayer = IT_PersonalInfo.CreateAndPersistPrimaryTaxPayer(mUserId, FilingStatus.Single, ref userDataId);

            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            // var w2Json = JsonConvert.SerializeObject(w2);
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            mTaxReturnData.UserDataId = userDataId;

            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, mTaxReturnData);

            userData.UserId = mUserId;
            return userData;
        }

        /// <summary>
        /// Creates the w2.
        /// </summary>
        /// <param name="employmentType">Type of the employment.</param>
        /// <param name="ownerType">Type of the owner.</param>
        /// <returns></returns>
        public static W2 CreateW2(EmploymentType employmentType, OwnerType ownerType)
        {
            var hasEmployeeAddress = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1));
            var householdEmployeeWages = 0;
            var taxableScholarshipAmount = 0;
            mPersonalInfoRepository = mPersonalInfoRepository ?? new PersonalInfoRepository();
            var stateId = mPersonalInfoRepository.GetAllState().First().StateId;
            W2 w2 = null;

            switch (employmentType)
            {
                case EmploymentType.HouseholdEmployeeWages:
                    householdEmployeeWages = Utilities.CreateRandomNumber(0, 4000);
                    w2 = new W2()
                    {
                        W2Id = 0,
                        EmploymentType = employmentType,
                        OwnerType = ownerType,
                        Employer = new Employer
                        {
                            HouseholdEmployeeWages = householdEmployeeWages,
                            Organization = new Organization
                            {
                                Name = "Test HouseholdEmployee Name",
                                EIN = "12345",
                                Address = new Address
                                {
                                    CompanyAddress = new CompanyAddress
                                    {
                                        StreetAddress = "Test HouseholdEmployee Street Address",
                                        City = "Test HouseholdEmployee City",
                                        Zip = "123456",
                                        State = new State()
                                        {
                                            StateId = stateId
                                        }
                                    }
                                }
                            }
                        }
                    };
                    break;
                case EmploymentType.TaxableScholarshipIncome:
                    taxableScholarshipAmount = Utilities.CreateRandomNumber(0, 4000);
                    w2 = new W2()
                    {
                        W2Id = 0,
                        EmploymentType = employmentType,
                        OwnerType = ownerType,
                        Employer = new Employer
                        {
                            TaxableScholarshipAmount = taxableScholarshipAmount,
                            HouseholdEmployeeWages = householdEmployeeWages,
                            Organization = new Organization
                            {
                                Name = "Test TaxableScholarship Name",
                                EIN = "12345",
                                Address = new Address
                                {
                                    CompanyAddress = new CompanyAddress
                                    {
                                        StreetAddress = "Test TaxableScholarship Street Address",
                                        City = "Test TaxableScholarship City",
                                        Zip = "123456",
                                        State = new State()
                                        {
                                            StateId = stateId
                                        }
                                    }
                                }
                            }
                        }
                    };
                    break;
                default:
                    if (Convert.ToInt32(employmentType) > 0)
                    {
                        w2 = new W2()
                        {
                            W2Id = 0,
                            EmploymentType = employmentType,
                            OwnerType = ownerType,
                            WagesAmount = Utilities.CreateRandomNumber(10, 4000),
                            FederalTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 4000),
                            SocialSecurityWagesAmount = Utilities.CreateRandomNumber(0, 4000),
                            SocialSecurityTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 4000),
                            MedicareWagesAmount = Utilities.CreateRandomNumber(0, 4000),
                            MedicareTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 4000),
                            SocialSecurityTipsAmount = Utilities.CreateRandomNumber(0, 4000),
                            AllocatedTipsAmount = Utilities.CreateRandomNumber(0, 4000),
                            DependentCareBenefitsAmount = Utilities.CreateRandomNumber(0, 4000),
                            IsStatutoryEmployee = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                            HasRetirementPlan = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                            HasThirdPartySickPay = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                            NonQualifiedPlansAmount = Utilities.CreateRandomNumber(0, 4000),
                            HasEmployeeAddress = hasEmployeeAddress,
                            EmployeeAddress = (hasEmployeeAddress) ? new W2EmployeeAddress
                            {
                                StreetAddress = "Test Street Address",
                                City = "Test City",
                                State = new State()
                                {
                                    StateId = stateId
                                },
                                ZipCode = "123456",
                            } : null,
                            IsCorrectedW2 = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                            IsNonStandardW2 = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1)),
                            W2EmployerCodes = new List<W2EmployerCode> 
                            {
                                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.CTaxableCostofgroupTermLifeInsurance,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.DElectiveDeferralsToSection401k,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
                            },

                            OtherDeductsBenefits = new List<OtherDeductsBenefits>
                            {
                                new OtherDeductsBenefits {
                                    W2OtherId = (int)W2OtherCode.OtherInformation,
                                    Description = "Test Other Description1",
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                                new OtherDeductsBenefits {
                                    W2OtherId = (int)W2OtherCode.Section414Contributions,
                                    Description = "Test Other Description2",
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
                            },

                            W2StateLocalTaxInfo = new List<W2StateLocalTaxInfo>
                            {
                                new W2StateLocalTaxInfo 
                                {
                                    State = new State()
                                    {
                                        StateCode = "12345",
                                        StateId = stateId
                                    },
                                    StateWagesAmount = Utilities.CreateRandomNumber(0, 3000),
                                    StateTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 3000),
                                    W2LocalTaxInfo = new List<W2LocalTaxInfo>{

                                        new W2LocalTaxInfo{
                                            StateCode = stateId,
                                            LocalWagesAmount = Utilities.CreateRandomNumber(0, 3000),
                                            LocalTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 3000),
                                            LocalityName = "Test Locality Name1"
                                        },
        
                                    },
                                },

                                new W2StateLocalTaxInfo 
                                {
                                    State = new State()
                                    {
                                        StateCode = "12346",
                                        StateId = stateId,
                                    },
                                    StateWagesAmount = Utilities.CreateRandomNumber(0, 3000),
                                    StateTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 3000),
                                    W2LocalTaxInfo = new List<W2LocalTaxInfo>{

                                        new W2LocalTaxInfo{
                                            StateCode = stateId,
                                            LocalWagesAmount = Utilities.CreateRandomNumber(0, 3000),
                                            LocalTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 3000),
                                            LocalityName = "Test Locality Name1"
                                        },
                                    },
                                }
                            },

                            Employer = new Employer
                            {
                                Organization = new Organization
                                {
                                    Name = "Test Employer Name",
                                    EIN = "12345",
                                    Address = new Address
                                    {
                                        CompanyAddress = new CompanyAddress
                                        {
                                            StreetAddress = "Test Street Address",
                                            City = "Test City",
                                            Zip = "123456",
                                            State = new State()
                                            {
                                                StateId = stateId
                                            }
                                        }
                                    }
                                }
                            }
                        };
                    }
                    break;
            }

            return w2;
        }


        /// <summary>
        /// Validates the household employee wages data after persist.
        /// </summary>
        /// <param name="actualW2Data">The actual w2 data.</param>
        /// <param name="actualHouseholdEmployeeWageW2Data">The actual household employee wage w2 data.</param>
        /// <param name="givenHouseholdEmployeeWagesW2Data">The given household employee wages w2 data.</param>
        private void ValidateHouseholdEmployeeWagesDataAfterPersist(List<W2> actualW2Data,
            dynamic actualHouseholdEmployeeWageW2Data, W2 givenHouseholdEmployeeWagesW2Data)
        {
            Assert.AreEqual(2, actualW2Data.Count);
            Assert.IsTrue(actualHouseholdEmployeeWageW2Data.W2Id > 0);
            var expectedHouseholdEmployeeWagesW2Data = actualW2Data.First(w => w.W2Id == actualHouseholdEmployeeWageW2Data.W2Id);
            Assert.AreEqual(actualHouseholdEmployeeWageW2Data.W2Id, expectedHouseholdEmployeeWagesW2Data.W2Id);
            Assert.AreEqual(givenHouseholdEmployeeWagesW2Data.EmploymentType,
                expectedHouseholdEmployeeWagesW2Data.EmploymentType);
            Assert.AreEqual(givenHouseholdEmployeeWagesW2Data.OwnerType, expectedHouseholdEmployeeWagesW2Data.OwnerType);
            Assert.AreEqual(givenHouseholdEmployeeWagesW2Data.OtherDeductsBenefits,
                expectedHouseholdEmployeeWagesW2Data.OtherDeductsBenefits);
            //EmploymentType is HouseholdEmployeeWages.
            Assert.AreEqual(givenHouseholdEmployeeWagesW2Data.Employer.HouseholdEmployeeWages,
                expectedHouseholdEmployeeWagesW2Data.Employer.HouseholdEmployeeWages);
        }

        /// <summary>
        /// Validates the regular wages data after persist.
        /// </summary>
        /// <param name="actualW2Data">The actual w2 data.</param>
        /// <param name="actualregularWagesW2Data">The actualregular wages w2 data.</param>
        /// <param name="expectedRegularWagesW2Data">The expected regular wages w2 data.</param>
        private void ValidateRegularWagesDataAfterPersist(IEnumerable<W2> actualW2Data, dynamic actualregularWagesW2Data,
            W2 expectedRegularWagesW2Data)
        {
            foreach (var actualW2 in actualW2Data)
            {
                Assert.IsTrue(actualregularWagesW2Data.UserDataId > 0);
                Assert.IsTrue(actualW2.W2Id > 0);
                Assert.AreEqual(expectedRegularWagesW2Data.EmploymentType, actualW2.EmploymentType);
                Assert.AreEqual(expectedRegularWagesW2Data.OwnerType, actualW2.OwnerType);
                Assert.AreEqual(expectedRegularWagesW2Data.WagesAmount, actualW2.WagesAmount);
                Assert.AreEqual(expectedRegularWagesW2Data.FederalTaxWithholdingAmount, actualW2.FederalTaxWithholdingAmount);
                Assert.AreEqual(expectedRegularWagesW2Data.SocialSecurityWagesAmount, actualW2.SocialSecurityWagesAmount);
                Assert.AreEqual(expectedRegularWagesW2Data.MedicareWagesAmount, actualW2.MedicareWagesAmount);
                Assert.AreEqual(expectedRegularWagesW2Data.MedicareTaxWithholdingAmount, actualW2.MedicareTaxWithholdingAmount);
                Assert.AreEqual(expectedRegularWagesW2Data.SocialSecurityTipsAmount, actualW2.SocialSecurityTipsAmount);
                Assert.AreEqual(expectedRegularWagesW2Data.AllocatedTipsAmount, actualW2.AllocatedTipsAmount);
                Assert.AreEqual(expectedRegularWagesW2Data.DependentCareBenefitsAmount, actualW2.DependentCareBenefitsAmount);
                Assert.AreEqual(expectedRegularWagesW2Data.IsStatutoryEmployee, actualW2.IsStatutoryEmployee);
                Assert.AreEqual(expectedRegularWagesW2Data.HasRetirementPlan, actualW2.HasRetirementPlan);
                Assert.AreEqual(expectedRegularWagesW2Data.HasThirdPartySickPay, actualW2.HasThirdPartySickPay);
                Assert.AreEqual(expectedRegularWagesW2Data.NonQualifiedPlansAmount, actualW2.NonQualifiedPlansAmount);
                if (expectedRegularWagesW2Data.HasEmployeeAddress != null && expectedRegularWagesW2Data.HasEmployeeAddress.Value)
                {
                    Assert.AreEqual(expectedRegularWagesW2Data.EmployeeAddress.City, actualW2.EmployeeAddress.City);
                    Assert.AreEqual(expectedRegularWagesW2Data.EmployeeAddress.StreetAddress,
                        actualW2.EmployeeAddress.StreetAddress);
                    Assert.AreEqual(expectedRegularWagesW2Data.EmployeeAddress.ZipCode, actualW2.EmployeeAddress.ZipCode);
                    Assert.AreEqual(expectedRegularWagesW2Data.EmployeeAddress.State, actualW2.EmployeeAddress.State);
                }
                if (actualW2.W2EmployerCodes.Any())
                {
                    foreach (var actualW2EmployerCode in actualW2.W2EmployerCodes)
                    {
                        W2EmployerCode expectedW2EmployerCode =
                            expectedRegularWagesW2Data.W2EmployerCodes.FirstOrDefault(
                                f => f.EmployerCode == actualW2EmployerCode.EmployerCode);
                        if (expectedW2EmployerCode != null)
                            Assert.AreEqual(expectedW2EmployerCode.Amount, actualW2EmployerCode.Amount);
                    }
                }
                if (actualW2.OtherDeductsBenefits.Any())
                {
                    foreach (var actualOtherDeductBenifits in actualW2.OtherDeductsBenefits)
                    {
                        OtherDeductsBenefits expectedOtherDeductsBenefits =
                            expectedRegularWagesW2Data.OtherDeductsBenefits.FirstOrDefault(
                                f => f.W2OtherId == actualOtherDeductBenifits.W2OtherId);
                        if (expectedOtherDeductsBenefits != null)
                        {
                            Assert.AreEqual(expectedOtherDeductsBenefits.Amount, actualOtherDeductBenifits.Amount);
                            Assert.AreEqual(expectedOtherDeductsBenefits.Description,
                                actualOtherDeductBenifits.Description);
                        }
                    }
                }
                if (actualW2.W2StateLocalTaxInfo.Any())
                {
                    var expectedW2StateLocalTaxInfo = expectedRegularWagesW2Data.W2StateLocalTaxInfo.ToArray();
                    var x = 0;
                    foreach (var actualW2StateLocalTaxInfo in actualW2.W2StateLocalTaxInfo)
                    {
                        Assert.AreEqual(expectedW2StateLocalTaxInfo[x].StateTaxWithholdingAmount,
                            actualW2StateLocalTaxInfo.StateTaxWithholdingAmount);
                        Assert.AreEqual(expectedW2StateLocalTaxInfo[x].State.StateCode, actualW2StateLocalTaxInfo.State.StateCode);
                        Assert.AreEqual(expectedW2StateLocalTaxInfo[x].State.StateId, actualW2StateLocalTaxInfo.State.StateId);
                        Assert.AreEqual(expectedW2StateLocalTaxInfo[x].State.StateName, actualW2StateLocalTaxInfo.State.StateName);
                        Assert.AreEqual(expectedW2StateLocalTaxInfo[x].StateWagesAmount,
                            actualW2StateLocalTaxInfo.StateWagesAmount);
                        var expectedLocalTaxInfo =
                            expectedRegularWagesW2Data.W2StateLocalTaxInfo[x].W2LocalTaxInfo.ToArray();
                        var i = 0;
                        foreach (var actualW2LocalTaxInfo in actualW2.W2StateLocalTaxInfo[x].W2LocalTaxInfo)
                        {
                            Assert.AreEqual(expectedLocalTaxInfo[i].StateCode, actualW2LocalTaxInfo.StateCode);
                            Assert.AreEqual(expectedLocalTaxInfo[i].LocalityName, actualW2LocalTaxInfo.LocalityName);
                            Assert.AreEqual(expectedLocalTaxInfo[i].LocalWagesAmount, actualW2LocalTaxInfo.LocalWagesAmount);
                            Assert.AreEqual(expectedLocalTaxInfo[i].LocalTaxWithholdingAmount,
                                actualW2LocalTaxInfo.LocalTaxWithholdingAmount);
                            i += 1;
                        }
                        x += 1;
                    }
                }
                Assert.AreEqual(expectedRegularWagesW2Data.Employer.HouseholdEmployeeWages,
                    actualW2.Employer.HouseholdEmployeeWages);
                Assert.AreEqual(expectedRegularWagesW2Data.Employer.TaxableScholarshipAmount,
                    actualW2.Employer.TaxableScholarshipAmount);
                //Assert.AreEqual(expectedRegularWagesW2Data.Employer.Organization.Name, actualW2.Employer.Organization.Name);
                //Assert.AreEqual(expectedRegularWagesW2Data.Employer.Organization.EIN, actualW2.Employer.Organization.EIN);
            }
        }

        /// <summary>
        /// Inputs for validating BR1,BR3 And BR4 
        /// </summary>
        /// <param name="expectedRegularWagesW2Data">The expected regular wages w2 data.</param>
        private static void GivenWagesInfoForValidatingBR1BR3BR4(W2 expectedRegularWagesW2Data)
        {
            expectedRegularWagesW2Data.FederalTaxWithholdingAmount = 10000.00;
            expectedRegularWagesW2Data.WagesAmount = 1000.00;
            expectedRegularWagesW2Data.MedicareWagesAmount = 100;
            expectedRegularWagesW2Data.SocialSecurityTaxWithholdingAmount = 100;
            expectedRegularWagesW2Data.MedicareTaxWithholdingAmount = ((MEDICARE_TAXWITHHOLDING_AMOUNT_LIMIT) *
                                                                       (expectedRegularWagesW2Data.MedicareWagesAmount));
            expectedRegularWagesW2Data.SocialSecurityTaxWithholdingAmount = (SOCIALSECURITY_TAXWITHHOLDING_AMOUNT_LIMIT) *
                                                                            expectedRegularWagesW2Data.SocialSecurityWagesAmount;
        }


        /// <summary>
        /// Inputs for validating BR8
        /// </summary>
        /// <param name="expectedRegularWagesW2Data">The expected regular wages w2 data.</param>
        private static void GivenWagesInfoForValidatingBR8(W2 expectedRegularWagesW2Data)
        {
            expectedRegularWagesW2Data.WagesAmount = 100;
            expectedRegularWagesW2Data.W2StateLocalTaxInfo = new List<W2StateLocalTaxInfo>
            {
                new W2StateLocalTaxInfo
                {
                    StateTaxWithholdingAmount = 130,
                    StateWagesAmount = 120
                }
            };
        }


        /// <summary>
        /// Givens the wages information for validating state taxwith helding greather than federal wages.
        /// </summary>
        /// <param name="expectedRegularWagesW2Data">The expected regular wages w2 data.</param>
        private static void GivenWagesInfoForValidatingStateTaxwithHeldingGreatherThanFederalWages(W2 expectedRegularWagesW2Data)
        {
            expectedRegularWagesW2Data.W2StateLocalTaxInfo = new List<W2StateLocalTaxInfo>
            {
                new W2StateLocalTaxInfo
                {
                    StateTaxWithholdingAmount = 130,
                    StateWagesAmount = 120
                }
            };
        }

        /// <summary>
        /// Givens the wages information for validating state taxwith helding greather than state wages.
        /// </summary>
        /// <param name="expectedRegularWagesW2Data">The expected regular wages w2 data.</param>
        private static void GivenWagesInfoForValidatingStateTaxwithHeldingGreatherThanStateWages(W2 expectedRegularWagesW2Data)
        {
            expectedRegularWagesW2Data.WagesAmount = 100;
            expectedRegularWagesW2Data.W2StateLocalTaxInfo = new List<W2StateLocalTaxInfo>
            {
                new W2StateLocalTaxInfo
                {
                    StateTaxWithholdingAmount = 130
                }
            };
        }

        private List<W2EmployerCode> GetW2EmployerCode(EmployerCode employerCode, double amount)
        {
            return new List<W2EmployerCode>
            {
                new W2EmployerCode
                {
                    EmployerCode = employerCode,
                    Amount = amount
                },
            };
        }
        #endregion

    }
}
