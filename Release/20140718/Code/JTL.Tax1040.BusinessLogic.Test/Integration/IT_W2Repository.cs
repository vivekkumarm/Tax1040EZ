/*
Copyright   : Copyright Jeevan Technologies
File Name   : IT_W2Repository.cs 
Description : Business Logic testing for W2 
Author      : Bala
Created Date : 16 Apr 2014

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
using Tax1040WorkFlow.WorkFlow.Activities;
using System.Activities;
using System.Dynamic;
using JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation;

namespace JTL.Tax1040.BusinessLogic.Test
{
    [TestClass]
    public class IT_W2Repository
    {
        static IW2Repository mW2Repository;
        static IPersonalInfoRepository mPersonalInfoRepository;
        static TaxReturnData taxReturnData;

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mW2Repository = new W2Repository();
            mPersonalInfoRepository = new PersonalInfoRepository();
            taxReturnData = new TaxReturnData();
        }

        /// <summary>
        /// Persist the W2 list data.
        /// </summary>
        [TestMethod]
        public void PersistW2Data()
        {
            var userId = IT_UserRepository.PersistNewUser();
            //  var userDataId = 0L;
            List<ErrorMessage> errorMessageList;

            //var primaryTaxPayer = IT_PersonalInfo.CreateAndPersistPrimaryTaxPayer(userId, FilingStatus.Single, ref userDataId);

            //Persist first w2
            var w21 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            //   var w2Json1 = JsonConvert.SerializeObject(w21);
            taxReturnData.TaxData = JsonConvert.SerializeObject(w21);
            taxReturnData.UserDataId = 0L;

            //Before persist in tax object
            Assert.AreEqual(0, taxReturnData.UserDataId);
            Assert.AreEqual(0, w21.W2Id);

            Assert.AreEqual(null, w21.Employer.TaxableScholarshipAmount);
            Assert.AreEqual(null, w21.Employer.HouseholdEmployeeWages);

            var userData1 = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            //After Persist
            Assert.IsTrue(userData1.UserDataId > 0);
            Assert.IsTrue(userData1.W2Id > 0);

            //Saravanan N - 13th May, 2014 - UserDTO implemented.
            UserDTO userDTO = new UserDTO();
            userDTO.UserId = userId;
            userDTO.UserDataId = userData1.UserDataId;

            List<W2> w2ListObject = mW2Repository.GetTaxReturnW2List(userDTO);

            Assert.AreEqual(1, w2ListObject.Count);

            Assert.AreEqual(userData1.W2Id, w2ListObject[0].W2Id);

            Assert.AreEqual(w21.EmploymentType, w2ListObject[0].EmploymentType);


            Assert.AreEqual(w21.OwnerType, w2ListObject[0].OwnerType);
            Assert.AreEqual(w21.OtherDeductsBenefits.Count, w2ListObject[0].OtherDeductsBenefits.Count);

            //EmploymentType is RegularW2Wages
            Assert.AreEqual(w21.FederalTaxWithholdingAmount, w2ListObject[0].FederalTaxWithholdingAmount);
            Assert.AreEqual(null, w2ListObject[0].Employer.TaxableScholarshipAmount);
            Assert.AreEqual(null, w2ListObject[0].Employer.HouseholdEmployeeWages);

            //Persist second w2
            var w22 = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.Spouse);

            // var w2Json2 = JsonConvert.SerializeObject(w22);
            taxReturnData.TaxData = JsonConvert.SerializeObject(w22);
            taxReturnData.UserDataId = userData1.UserDataId;

            var userData2 = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData2.W2Id > 0);

            w2ListObject = mW2Repository.GetTaxReturnW2List(userDTO);

            Assert.AreEqual(2, w2ListObject.Count);

            var w2 = w2ListObject.First(w => w.W2Id == userData2.W2Id);

            Assert.AreEqual(userData2.W2Id, w2.W2Id);

            Assert.AreEqual(w22.EmploymentType, w2.EmploymentType);


            Assert.AreEqual(w22.OwnerType, w2.OwnerType);
            Assert.AreEqual(w22.OtherDeductsBenefits, w2.OtherDeductsBenefits);

            //EmploymentType is HouseholdEmployeeWages.
            Assert.AreEqual(w22.Employer.HouseholdEmployeeWages, w2.Employer.HouseholdEmployeeWages);
            //Assert.AreEqual(null, w22.Employer.TaxableScholarshipAmount);
            //Assert.AreEqual(null, w2.FederalTaxWithholdingAmount);


        }

        /// <summary>
        /// Persists and delete the W2 list data.
        /// </summary>
        [TestMethod]
        public void PersistAndDeleteW2Data()
        {
            var userId = IT_UserRepository.PersistNewUser();
            //var userDataId = 0L;
            List<ErrorMessage> errorMessageList;

            //Persist first w2
            var w2_1 = CreateW2(EmploymentType.ActiveDutyMilitaryWages, OwnerType.PrimaryTaxPayer);

            var w2Json1 = JsonConvert.SerializeObject(w2_1);
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2_1);
            taxReturnData.UserDataId = 0L;

            //Before persist in tax object
            Assert.AreEqual(0, taxReturnData.UserDataId);
            Assert.AreEqual(0, w2_1.W2Id);

            var userData1 = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            //After Persist
            Assert.IsTrue(userData1.UserDataId > 0);
            Assert.IsTrue(userData1.W2Id > 0);

            //Persist second w2
            var w2_2 = CreateW2(EmploymentType.TaxableScholarshipIncome, OwnerType.Spouse);

            var w2Json2 = JsonConvert.SerializeObject(w2_2);
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2_2);
            taxReturnData.UserDataId = userData1.UserDataId;

            var userData2 = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData2.W2Id > 0);
            Assert.AreEqual(userData1.UserDataId, userData2.UserDataId);
            Assert.AreNotEqual(userData1.W2Id, userData2.W2Id);

            UserDTO userDTO = new UserDTO();
            userDTO.UserId = userId;
            userDTO.UserDataId = userData1.UserDataId;

            List<W2> w2ListObject1 = mW2Repository.GetTaxReturnW2List(userDTO);

            Assert.AreEqual(2, w2ListObject1.Count);

            var w21 = w2ListObject1.First(w => w.W2Id == userData1.W2Id);

            Assert.AreEqual(userData1.W2Id, w21.W2Id);

            Assert.AreEqual(w2_1.EmploymentType, w21.EmploymentType);

            Assert.AreEqual(w2_1.OwnerType, w21.OwnerType);
            Assert.AreEqual(w2_1.OtherDeductsBenefits.Count, w21.OtherDeductsBenefits.Count);

            //EmploymentType is ActiveDutyMilitaryWages
            Assert.AreEqual(w2_1.FederalTaxWithholdingAmount, w21.FederalTaxWithholdingAmount);
            //Assert.AreEqual(0, w21.Employer.TaxableScholarshipAmount);
            //Assert.AreEqual(0, w21.Employer.HouseholdEmployeeWages);

            var w22 = w2ListObject1.First(w => w.W2Id == userData2.W2Id);

            Assert.AreEqual(userData2.W2Id, w22.W2Id);

            Assert.AreEqual(w2_2.EmploymentType, w22.EmploymentType);

            Assert.AreEqual(w2_2.OwnerType, w22.OwnerType);
            Assert.AreEqual(w2_2.OtherDeductsBenefits, w22.OtherDeductsBenefits);

            //EmploymentType is TaxableScholarshipIncome
            Assert.AreEqual(w2_2.Employer.TaxableScholarshipAmount, w22.Employer.TaxableScholarshipAmount);
            //Assert.AreEqual(0, w22.Employer.HouseholdEmployeeWages);
            //Assert.AreEqual(0, w22.FederalTaxWithholdingAmount);

            //Delete 1st W2 wages
            userDTO.FormId = w21.W2Id;
            mW2Repository.DeleteAndPersistW2(userDTO);


            List<W2> w2ListObject2 = mW2Repository.GetTaxReturnW2List(userDTO);

            Assert.AreEqual(1, w2ListObject2.Count);
            // Assert.AreNotEqual(w2ListObject1.Count, w2ListObject2.Count);

            // Deleted 1st W2 wages
            var w2First = w2ListObject2.FirstOrDefault(w => w.W2Id == w21.W2Id);

            Assert.IsNull(w2First);

            // Exist 2nd W2 wages
            var w2Second = w2ListObject2.FirstOrDefault(w => w.W2Id == w22.W2Id);

            Assert.IsNotNull(w2Second);

        }

        #region Business Rule

        [TestMethod]
        public void FederalTaxWithHeldGreaterThanWages()
        {
            var userId = IT_UserRepository.PersistNewUser();

            // Creates W2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            // Federal TaxWith holding Amount is greater than Wages
            Random federalTaxWithHoldingAmount = new Random(5);
            w2.FederalTaxWithholdingAmount = federalTaxWithHoldingAmount.ConvertToDouble() * 10000.00;
            w2.WagesAmount = 1000;

            // Perist W2
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            var userReturnData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userReturnData.UserDataId > 0);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userReturnData.UserDataId);

            // Check weather business rule Federal Tax With Holding should not be greater than wages
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_FEDERAL_WITHHOLDING)));
        }

        /// <summary>
        /// Check weather Medicare With Held is greater than Medicare wages
        /// </summary>
        [TestMethod]
        public void MedicareWithHeldGreaterThanMedicareWages()
        {
            var userId = IT_UserRepository.PersistNewUser();
            // Creates W2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            // Assign the medicare with holding amount greater than 1.45 % medicare wages amount
            w2.MedicareTaxWithholdingAmount = ((2.00 / 100) * (w2.MedicareWagesAmount));

            // Perist W2
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            var userReturnData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userReturnData.UserDataId > 0);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userReturnData.UserDataId);

            // Check weather business rule Medicare with holding amount greater than 1.45 % medicare wages amount
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR4")));

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void SocialSecurityWithHeldGreaterSocialSecurityTax()
        {
            var userId = IT_UserRepository.PersistNewUser();

            //Create w2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            w2.SocialSecurityTaxWithholdingAmount = (9.00 / 100) * w2.SocialSecurityWagesAmount;
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR3")));
        }


        /// <summary>
        /// Check the box 12a business rule validaiton
        /// </summary>
        [TestMethod]
        public void HasBox12AArcherMedicalSavingsAmount()
        {
            var userId = IT_UserRepository.PersistNewUser();

            //Create w2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            w2.W2EmployerCodes = new List<W2EmployerCode>();

            w2.W2EmployerCodes.Add(new W2EmployerCode()
            {
                EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips
            });

            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR5")));

            UserDTO userDTO = new UserDTO();
            userDTO.UserDataId = userData.UserDataId;
            userDTO.FormId = userData.W2Id;
            userDTO.UserId = userId;
            System.Tuple<W2, dynamic> w2Data = mW2Repository.GetW2Data(userDTO);
            Assert.IsNotNull(w2Data);

            w2Data.Item1.W2EmployerCodes = new List<W2EmployerCode>();


            w2Data.Item1.W2EmployerCodes.Add(new W2EmployerCode()
            {
                EmployerCode = EmployerCode.TAdoptionBenefits
            });

            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR6")));


            w2Data = mW2Repository.GetW2Data(userDTO);
            Assert.IsNotNull(w2Data);

            w2Data.Item1.W2EmployerCodes = new List<W2EmployerCode>();


            w2Data.Item1.W2EmployerCodes.Add(new W2EmployerCode()
            {
                EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount
            });

            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR7")));

        }



        /// <summary>
        /// State Wages should not be more than Box 1 Federal Wages.
        /// </summary>
        /// 23 Jun 14 vivek created for business rule 
        [TestMethod]
        public void StateWagesGreaterthanFederalWages()
        {
            //Business #6 
            var userId = IT_UserRepository.PersistNewUser();

            //Create w2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            //Assenting the values to the federal tax with held Amount
            w2.WagesAmount = 100;
            w2.W2StateLocalTaxInfo = new List<W2StateLocalTaxInfo>();
            w2.W2StateLocalTaxInfo.Add(new W2StateLocalTaxInfo
            {
                StateTaxWithholdingAmount = 130,
                StateWagesAmount = 120
            });

            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR8")));
        }

        /// <summary>
        /// Box 17 State Tax Withheld should be greater than Box 16 State wages or Box 1 Federal wages
        /// </summary>
        /// 23 Jun 14 vivek created for business rule
        [TestMethod]
        public void StateTaxWithheldGreaterStateTaxAndWages()
        {
            //Business #7
            var userId = IT_UserRepository.PersistNewUser();


            //Create w2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            w2.WagesAmount = 100;
            w2.W2StateLocalTaxInfo = new List<W2StateLocalTaxInfo>();
            w2.W2StateLocalTaxInfo.Add(new W2StateLocalTaxInfo
            {
                StateTaxWithholdingAmount = 130
            });

            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR9")));


            w2.W2StateLocalTaxInfo = new List<W2StateLocalTaxInfo>();
            w2.W2StateLocalTaxInfo.Add(new W2StateLocalTaxInfo
            {
                StateTaxWithholdingAmount = 130,
                StateWagesAmount = 120
            });

            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            var userData1 = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            BusinessObject.Tax1040 taxObject1 = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData1.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject1.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR9")));

        }

        /// <summary>
        /// Your Household employee wages should not be greater than $1,800.
        /// </summary>
        /// 23 jun 14 vivek Business Rule check for HouseholdEmployeeWages
        [TestMethod]
        public void HouseholdEmployeeWagesGreater1800Dollar()
        {
            //Business #8 
            var userId = IT_UserRepository.PersistNewUser();

            //Create w2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            w2.Employer = new Employer();
            w2.Employer.HouseholdEmployeeWages = 1900;

            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_BR10")));

        }

        #endregion

        /// <summary>
        /// Check the Total wages
        /// </summary>
        [TestMethod]
        public void CheckTotalWages()
        {
            var userId = IT_UserRepository.PersistNewUser();

            // Creates W2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            w2.FederalTaxWithholdingAmount = 10000;
            w2.WagesAmount = 1000;

            // Perist W2
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            var userReturnData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userReturnData.UserDataId > 0);


            w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            w2.FederalTaxWithholdingAmount = 10000;
            w2.WagesAmount = 2000;

            // Perist W2
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userReturnData.UserDataId);

            //Get the total wages from the work flow
            dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
            input.Tax1040Object = taxObject;
            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new W2WithNoValidation(), input));
            //Check the total wages is correct
            Assert.IsTrue(output.TotalWages == 3000);

        }
        /// <summary>
        /// Check the total federal with hold amount
        /// </summary>
        [TestMethod]
        public void CheckTotalFederalWithHold()
        {
            var userId = IT_UserRepository.PersistNewUser();

            // Creates W2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            // Federal TaxWith holding Amount is greater than Wages
            w2.FederalTaxWithholdingAmount = 10000;
            w2.WagesAmount = 1000;

            // Perist W2
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            var userReturnData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userReturnData.UserDataId > 0);


            w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            // Federal TaxWith holding Amount is greater than Wages
            w2.FederalTaxWithholdingAmount = 10000;
            w2.WagesAmount = 2000;

            // Perist W2
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userReturnData.UserDataId);

            //Get the total Federal Tax With holding amount
            dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
            input.Tax1040Object = taxObject;
            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new FW2FederalTaxWithholding(), input));
            //Check the TotalW2 Federal Tax With hold
            Assert.IsTrue(output.TotalW2FederalTaxWithhold == 20000);
        }


        /// <summary>
        /// Check the total federal with hold amount
        /// </summary>
        [TestMethod]
        public void CheckMFJTotalFederalWithHold()
        {
            var userId = IT_UserRepository.PersistNewUser();

            // Creates W2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            // Federal TaxWith holding Amount is greater than Wages
            w2.FederalTaxWithholdingAmount = 10000;
            w2.WagesAmount = 1000;

            // Perist W2
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            var userReturnData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userReturnData.UserDataId > 0);


            w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.Spouse);
            // Federal TaxWith holding Amount is greater than Wages
            w2.FederalTaxWithholdingAmount = 10000;
            w2.WagesAmount = 2000;

            // Perist W2
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userReturnData.UserDataId);

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
        public void AllocatedTipsShouldBeReportedTo1040()
        {
            //Eligibility #1
            var userId = IT_UserRepository.PersistNewUser();

            //Create w2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            w2.AllocatedTipsAmount = 1;
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_ER1")));
        }
        /// <summary>
        /// Box 10 Dependent care benefits Should be reported on Form 1040
        /// </summary>
        /// 23 jun 14 vivek Eligibility Rule check for Dependent Care Benefits
        [TestMethod]
        public void DependentCareBenefitsShouldBeReportedTo1040()
        {
            ////Eligibility #2
            var userId = IT_UserRepository.PersistNewUser();

            //Create w2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            w2.DependentCareBenefitsAmount = 1;
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals("Wages_ER2")));
        }


        #endregion

        #region Required Entries

        [TestMethod]
        public void EmployerIdentificationNumber()
        {
            var userId = IT_UserRepository.PersistNewUser();

            // Creates W2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            w2.Employer.Organization.EIN = string.Empty;

            // Perist W2
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EIN)));

        }

        [TestMethod]
        public void StateLocalInfo15AStateIdRequiredOnStateCode()
        {
            var userId = IT_UserRepository.PersistNewUser();

            // Creates W2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            w2.Employer.Organization.EIN = string.Empty;

            foreach (W2StateLocalTaxInfo w2StateLocalInfo in w2.W2StateLocalTaxInfo)
            {
                w2StateLocalInfo.State = new State()
                {
                    StateId = 0
                };
            }

            // Perist W2
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);


            var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_STATE_LOCAL_STATE_ID)));

        }

        [TestMethod]
        public void StateLocalInfoStateWagesRequiredOnStateCode()
        {
            var userId = IT_UserRepository.PersistNewUser();

            // Creates W2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            foreach (W2StateLocalTaxInfo w2StateLocalInfo in w2.W2StateLocalTaxInfo)
            {
                w2StateLocalInfo.StateWagesAmount = null;
            }

            // Perist W2
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_STATE_LOCAL_STATE_WAGES)));


        }

        #endregion


        #region Validation
        [TestMethod]
        public void ValidateEmployerIdentificationNumber()
        {
            var userId = IT_UserRepository.PersistNewUser();

            // Creates W2
            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            w2.Employer.Organization.EIN = "123-45665455555A";

            // Perist W2
            TaxReturnData taxReturnData = new TaxReturnData();
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);

            var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            Assert.IsTrue(userData.UserDataId > 0);

            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userData.UserDataId); // Get tax object by user and userdataID

            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_EIN_INVALID)));

        }
        #endregion


        /// <summary>
        /// Tests the clean up.
        /// </summary>
        [TestCleanup]
        public void TestCleanUp()
        {

        }

        #region Helper Methods


        public static dynamic CreateAndPersistW2()
        {
            var userId = IT_UserRepository.PersistNewUser();
            var userDataId = 0L;
            List<ErrorMessage> errorMessageList;
            var primaryTaxPayer = IT_PersonalInfo.CreateAndPersistPrimaryTaxPayer(userId, FilingStatus.Single, ref userDataId);

            var w2 = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);

            // var w2Json = JsonConvert.SerializeObject(w2);
            taxReturnData.TaxData = JsonConvert.SerializeObject(w2);
            taxReturnData.UserDataId = userDataId;

            var userData = mW2Repository.PersistW2TaxReturnData(userId, taxReturnData);

            userData.UserId = userId;
            return userData;
        }

        public static W2 CreateW2(EmploymentType employmentType, OwnerType ownerType)
        {
            var hasEmployeeAddress = Convert.ToBoolean(Utilities.CreateRandomNumber(0, 1));
            var householdEmployeeWages = 0;
            var taxableScholarshipAmount = 0;
            var stateId = mPersonalInfoRepository.GetAllState().First().StateId;
            W2 w2 = null;

            if (employmentType == EmploymentType.HouseholdEmployeeWages)
            {
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
            }
            else if (employmentType == EmploymentType.TaxableScholarshipIncome)
            {

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
            }
            else if (Convert.ToInt32(employmentType) > 0)
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

                    OtherDeductsBenefits = new List<OtherDeductsBenefits>{

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

                    W2StateLocalTaxInfo = new List<W2StateLocalTaxInfo>{
            new W2StateLocalTaxInfo {
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

         new W2StateLocalTaxInfo {
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

            return w2;
        }

        #endregion

    }
}
