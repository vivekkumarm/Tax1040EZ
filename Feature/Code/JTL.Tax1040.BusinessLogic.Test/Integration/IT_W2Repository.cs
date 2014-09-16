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
using System.Web;

namespace JTL.Tax1040.BusinessLogic.Test
{
    [TestClass]
    public class IT_W2Repository
    {
        static IW2Repository mW2Repository;
        static ITaxReturnRepository mTaxReturnRepository;
        static IPersonalInfoRepository mPersonalInfoRepository;
        static IMessagesRepository mMessageRepository;
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
            mMessageRepository = new MessagesRepository();
            HttpRuntime.Cache["ErrorMessageCollection"] = mMessageRepository.GetErrorMessages();
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



        //Yogalakshmi - 3rd Sep 2014 - Modified BR10
        /// <summary>
        /// Wages_BR10 - Your Household employee wages should not be greater than $1,800.
        /// </summary>
        /// 23 jun 14 vivek Business Rule check for HouseholdEmployeeWages
        [TestMethod]
        [TestCategory("W2")]
        public void BusinessRuleHouseholdEmployeeWagesGreater1800Dollar()
        {
            //Create w2
            //Yogalakshmi - 1st August 2014 - Changed the employment type to household
            var expectedHouseHoldEmployeeWages = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.PrimaryTaxPayer);
            expectedHouseHoldEmployeeWages.Employer.HouseholdEmployeeWages = 1900;

            //Persist HouseholdEmployeeWages W2 object with HouseholdEmployeeWages
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedHouseHoldEmployeeWages) });

            // Get W2 object and Validate HouseholdEmployeeWages value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.HOUSEHOLD_EMPLOYEE_WAGES)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added BR11
        /// <summary>
        /// Wages_BR11 -  Form W2 Box12- Code12R amount must be reported on Form 8853.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void BusinessRuleBox12BCode12R()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12B_R_EMPLOYER_CONTRIBUTIONS_TO_ARCHER_MEDICAL)));
        }


        //Yogalakshmi - 3rd Sep 2014 - Added BR12
        /// <summary>
        /// Wages_BR12 -  Form W2 Box12- Code12T amount must be reported on Form 8839.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void BusinessRuleBox12BCode12T()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.TAdoptionBenefits,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12B_T_EMPLOYER_PAID_ADOPTION_BENEFITS)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added BR13
        /// <summary>
        /// Wages_BR13 -  Form W2 Box12- Code12W should be reported on Form 8889
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void BusinessRuleBox12BCode12W()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12B_W_EMPLOYER_AND_EMPLOYEE_CONTRIBUTIONS_TO_HEALTH)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added BR14
        /// <summary>
        /// Wages_BR14 -  Form W2 Box12- Code12R amount must be reported on Form 8853.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void BusinessRuleBox12CCode12R()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12C_R_EMPLOYER_CONTRIBUTIONS_TO_ARCHER_MEDICAL)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added BR15
        /// <summary>
        /// Wages_BR15 -  Form W2 Box12- Code12T amount must be reported on Form 8839.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void BusinessRuleBox12CCode12T()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.TAdoptionBenefits,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12C_T_EMPLOYER_PAID_ADOPTION_BENEFITS)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added BR16
        /// <summary>
        /// Wages_BR16 -   Form W2 Box12- Code12W amount should be reported on Form 8889
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void BusinessRuleBox12CCode12W()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12C_W_EMPLOYER_AND_EMPLOYEE_CONTRIBUTIONS_TO_HEALTH)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added BR17
        /// <summary>
        /// Wages_BR17 -  Form W2 Box12- Code12R amount must be reported on Form 8853.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void BusinessRuleBox12DCode12R()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12D_R_EMPLOYER_CONTRIBUTIONS_TO_ARCHER_MEDICAL)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added BR18
        /// <summary>
        /// Wages_BR18 -  Form W2 Box12- Code12T amount must be reported on Form 8839.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void BusinessRuleBox12DCode12T()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.TAdoptionBenefits,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12D_T_EMPLOYER_PAID_ADOPTION_BENEFITS)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added BR19
        /// <summary>
        /// Wages_BR19 -  Form W2 Box12- Code12W  amount should be reported on Form 8889
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void BusinessRuleBox12DCode12W()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.REmployeeContributionsToAnArcherMSA,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.WEmployerAndEmployeeContributionsToAHealthSavingsAccount,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12D_W_EMPLOYER_AND_EMPLOYEE_CONTRIBUTIONS_TO_HEALTH)));
        }


        //Yogalakshmi - 3rd Sep 2014 - Added BR20
        /// <summary>
        /// Wages_BR20 -  Employer City name is Invalid
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void BusinessRuleRegularW2EmployerCity()
        {
            //TODO - SPEC 2.8 not updated in constants
            //var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.City = "ab";
            ////Persist RegularWages W2 object with W2EmployerCodes
            //var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            //// Get W2 object and Validate W2EmployerCodes value.
            //BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            //Assert.IsTrue(actualW2Data.UserDataId > 0);
            //Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12D_W_EMPLOYER_AND_EMPLOYEE_CONTRIBUTIONS_TO_HEALTH)));
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

        //Yogalakshmi - 3rd Sep 2014 - Added ER3
        /// <summary>
        /// Wages_ER3 - Form W2 from <Employer Name>: Box12- Code12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12ACode12A()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_A_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TIPS)));
           
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER4
        /// <summary>
        /// Wages_ER4 - Form W2 from <Employer Name>: Box12- Code12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12ACode12B()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_B_UNCOLLECTED_MEDICARE_TAX_ON_TIPS)));
         
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER5
        /// <summary>
        /// Wages_ER5 - Form W2 from <Employer Name>: Box12- Code12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12ACode12K()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.KExciseTaxOnExcessGoldenParachutePayments,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_K_EXCISE_TAX_ON_GOLDEN_PARACHUTE_PAYMENTS)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER6
        /// <summary>
        /// Wages_ER6 - Form W2 from <Employer Name>: Box12- Code12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on Form 1040 Line 60 other taxes. (You cannot file Form 1040EZ or Form 1040A.)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12ACode12M()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.MUncollectedSocSecOrRRTATaxOnGrpTermsLifeIns,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_M_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TAXABLE_GROUP)));
          
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER7
        /// <summary>
        /// Wages_ER7 - Form W2 from <Employer Name>: Box12- Code12N Uncollected Medicare Tax on taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other taxes. (You cannot file Form 1040EZ or Form 1040A.)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12ACode12N()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.NUncollectedMedicareTaxOnGroupTermLifeInsurance,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12A_N_UNCOLLECTED_MEDICARE_TAX_ON_TAXABLE_GROUP)));
       
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER8
        /// <summary>
        /// Wages_ER8 - Form W2 from <Employer Name>: Box12- Code12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional tax of 20% plus interest and report it on Form 1040 Line 60 other taxes. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12ACode12Z()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
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

        //Yogalakshmi - 3rd Sep 2014 - Added ER10
        /// <summary>
        /// Wages_ER10 - Form W2 from <Employer Name>: Box12- Code12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12BCode12A()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12B_A_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TIPS)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER11
        /// <summary>
        /// Wages_ER11 - Form W2 from <Employer Name>: Box12- Code12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12BCode12B()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12B_B_UNCOLLECTED_MEDICARE_TAX_ON_TIPS)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER12
        /// <summary>
        /// Wages_ER12 -  Form W2 from <Employer Name>: Box12- Code12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12BCode12K()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.KExciseTaxOnExcessGoldenParachutePayments,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12B_K_EXCISE_TAX_ON_GOLDEN_PARACHUTE_PAYMENTS)));
        }


        //Yogalakshmi - 3rd Sep 2014 - Added ER13
        /// <summary>
        /// Wages_ER13 -  Form W2 from <Employer Name>: Box12- Code12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12BCode12M()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.MUncollectedSocSecOrRRTATaxOnGrpTermsLifeIns,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12B_M_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TAXABLE_GROUP)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER14
        /// <summary>
        /// Wages_ER14 -  Form W2 from <Employer Name>: Box12- Code12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12BCode12N()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.NUncollectedMedicareTaxOnGroupTermLifeInsurance,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12B_N_UNCOLLECTED_MEDICARE_TAX_ON_TAXABLE_GROUP)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER15
        /// <summary>
        /// Wages_ER15 -  Form W2 from <Employer Name>: Box12- Code12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12BCode12Z()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12B_Z_INCOME_RECEIVED_UNDER_409A)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER16
        /// <summary>
        /// Wages_ER16 -  Form W2 from <Employer Name>: Box12- Code12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12CCode12A()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12C_A_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TIPS)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER17
        /// <summary>
        /// Wages_ER17 - Form W2 from <Employer Name>: Box12- Code12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12CCode12B()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12C_B_UNCOLLECTED_MEDICARE_TAX_ON_TIPS)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER18
        /// <summary>
        /// Wages_ER18 -  Form W2 from <Employer Name>: Box12- Code12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12CCode12K()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.KExciseTaxOnExcessGoldenParachutePayments,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12C_K_EXCISE_TAX_ON_GOLDEN_PARACHUTE_PAYMENTS)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER19
        /// <summary>
        /// Wages_ER19 -  Form W2 from <Employer Name>: Box12- Code12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12CCode12M()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.MUncollectedSocSecOrRRTATaxOnGrpTermsLifeIns,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12C_M_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TAXABLE_GROUP)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER20
        /// <summary>
        /// Wages_ER20 - Form W2 from <Employer Name>: Box12- Code12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12CCode12N()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.NUncollectedMedicareTaxOnGroupTermLifeInsurance,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12C_N_UNCOLLECTED_MEDICARE_TAX_ON_TAXABLE_GROUP)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER21
        /// <summary>
        /// Wages_ER21 - Form W2 from <Employer Name>: Box12- Code12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12CCode12Z()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12C_Z_INCOME_RECEIVED_UNDER_409A)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER22
        /// <summary>
        /// Wages_ER22 - Form W2 from <Employer Name>: Box12- Code12A Uncollected social security or RRTA Tax must be reported on Form 1040 Line 60. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12DCode12A()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12D_A_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TIPS)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER23
        /// <summary>
        /// Wages_ER23 - Form W2 from <Employer Name>: Box12- Code12B Uncollected Medicare Tax on Tips must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12DCode12B()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12D_B_UNCOLLECTED_MEDICARE_TAX_ON_TIPS)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER24
        /// <summary>
        /// Wages_ER24 -  Form W2 from <Employer Name>: Box12- Code12K Excise Tax (equal to 20%) on excess of golden parachute payment must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12DCode12K()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.KExciseTaxOnExcessGoldenParachutePayments,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12D_K_EXCISE_TAX_ON_GOLDEN_PARACHUTE_PAYMENTS)));
        }


        //Yogalakshmi - 3rd Sep 2014 - Added ER25
        /// <summary>
        /// Wages_ER25 - Form W2 from <Employer Name>: Box12- Code12M Uncollected social security or RRTA Tax on Taxable group term life insurance over 50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12DCode12M()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.MUncollectedSocSecOrRRTATaxOnGrpTermsLifeIns,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12D_M_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TAXABLE_GROUP)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added ER26
        /// <summary>
        /// Wages_ER26 - Form W2 from <Employer Name>: Box12- Code12N Uncollected Medicare Tax on Taxable group term life insurance over $50,000 for former employees must be reported on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A.)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12DCode12N()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.NUncollectedMedicareTaxOnGroupTermLifeInsurance,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12D_N_UNCOLLECTED_MEDICARE_TAX_ON_TAXABLE_GROUP)));
        }


        //Yogalakshmi - 3rd Sep 2014 - Added ER27
        /// <summary>
        /// Wages_ER27 - Form W2 from <Employer Name>: Box12- Code12Z Income received under 409A Non-qualified deferred compensation plan is subject to an additional Tax of 20% plus interest and report it on Form 1040 Line 60 other Taxes. (You cannot file Form 1040EZ or Form 1040A)
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void EligibilityRuleBox12DCode12Z()
        {
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.BUncollectedMedicareTaxOnTips,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan,
                                    Amount = Utilities.CreateRandomNumber(0, 3000)
                                }
            };
            //Persist RegularWages W2 object with W2EmployerCodes
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });

            // Get W2 object and Validate W2EmployerCodes value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); // Get tax object by user and userdataID
            Assert.IsTrue(actualW2Data.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.BOX12D_Z_INCOME_RECEIVED_UNDER_409A)));
        }


        #endregion

        #region Required Entries

        //Yogalakshmi - 3rd Sep 2014 - Added #RF1
        /// <summary>
        /// Wages_RF1 - Taxpayer or Spouse Code is missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildTaxpayerOrSpouse()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.None);
            // Perist RegularWages W2 object with  EIN as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_TAX_PAYER_OR_SPOUSE_CODE)));
        }


        //RF3
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildEmployeeIdentificationNumber()
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

        //Yogalakshmi - 2nd Sep 2014 - Added RF4
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildEmployerName()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF4
            expectedRegularWagesW2Data.Employer.Organization.Name = string.Empty;
            // Perist RegularWages W2 object with  EIN as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate WAGES_EIN value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_NAME)));
        }

        //Yogalakshmi - 2nd Sep 2014 - Added RF5
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildEmployerAddress()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF5
            expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.StreetAddress = string.Empty;
            // Perist RegularWages W2 object with  EIN as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate WAGES_EIN value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_ADDRESS)));
        }

        //Yogalakshmi - 2nd Sep 2014 - Added RF6
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildEmployerCity()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF6
            expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.City = string.Empty;
            // Perist RegularWages W2 object with  EIN as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate WAGES_EIN value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_CITY)));
        }

        //Yogalakshmi - 2nd Sep 2014 - Added RF7
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildEmployerState()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF7
            expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.State.StateId = 0;
            // Perist RegularWages W2 object with  EIN as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate WAGES_EIN value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_STATE)));
        }

        //Yogalakshmi - 2nd Sep 2014 - Added RF8
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildEmployerZipcode()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF8
            expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.Zip = string.Empty;
            // Perist RegularWages W2 object with  EIN as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate WAGES_EIN value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_ZIP)));
        }

        //Yogalakshmi - 2nd Sep 2014 - Added RF9
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildEmployeeAddress()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.HasEmployeeAddress = true;
            //Inputs for validating Wages_RF9
            if (expectedRegularWagesW2Data.HasEmployeeAddress == true)
            {
                expectedRegularWagesW2Data.EmployeeAddress = new W2EmployeeAddress
                {
                    StreetAddress = string.Empty
                };
            }
            // Perist RegularWages W2 object with  EIN as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate WAGES_EIN value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYEE_ADDRESS)));
        }

        //Yogalakshmi - 2nd Sep 2014 - Added RF10
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildEmployeeCity()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.HasEmployeeAddress = true;
            //Inputs for validating Wages_RF10
            if (expectedRegularWagesW2Data.HasEmployeeAddress == true)
            {
                expectedRegularWagesW2Data.EmployeeAddress = new W2EmployeeAddress
                {
                    City = string.Empty
                };
            }
            // Perist RegularWages W2 object with  EIN as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate WAGES_EIN value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYEE_CITY)));
        }

        //Yogalakshmi - 2nd Sep 2014 - Added RF11
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildEmployeeState()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.HasEmployeeAddress = true;
            //Inputs for validating Wages_RF11
            if (expectedRegularWagesW2Data.HasEmployeeAddress == true)
            {
                expectedRegularWagesW2Data.EmployeeAddress = new W2EmployeeAddress
                {
                    State = new State { StateId = 0 }
                };
            }
            // Perist RegularWages W2 object with  EIN as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate WAGES_EIN value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYEE_STATE)));
        }


        //Yogalakshmi - 2nd Sep 2014 - Added RF12
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildEmployeeZipcode()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.HasEmployeeAddress = true;
            //Inputs for validating Wages_RF12
            if (expectedRegularWagesW2Data.HasEmployeeAddress == true)
            {
                expectedRegularWagesW2Data.EmployeeAddress = new W2EmployeeAddress
                {
                    ZipCode = string.Empty
                };
            }
            // Perist RegularWages W2 object with  EIN as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate WAGES_EIN value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYEE_ZIP)));
        }

        //Yogalakshmi - 2nd Sep 2014 - Added RF13
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox1WageIncome()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF13
            expectedRegularWagesW2Data.WagesAmount = null;
            // Perist RegularWages W2 object with  Box1 as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Box1 value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_AMOUNT)));
        }

        //Yogalakshmi - 2nd Sep 2014 - Added RF14
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox2FederalTaxWithheld()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF14
            expectedRegularWagesW2Data.FederalTaxWithholdingAmount = null;
            // Perist RegularWages W2 object with  EIN as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate WAGES_EIN value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_FEDERAL_TAX_WITH_HOLDING_AMOUNT)));
        }

        //Yogalakshmi - 2nd Sep 2014 - Added RF15
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox15StateCode()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF15
            foreach (var stateLocalInfo in expectedRegularWagesW2Data.W2StateLocalTaxInfo)
            {
                stateLocalInfo.State = new State { StateId = 0 };
            }
            // Perist RegularWages W2 object with  State as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate State value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_STATE_LOCAL_STATE_CODE)));
        }

        //Yogalakshmi - 2nd Sep 2014 - Added RF16
        /// <summary>
        /// Wages_RF16 - State Identification Number should not be Empty
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox15AStatIdNumber()
        {
            // Prepare RegularWages W2 object.
            var expectedW2RegularWagesData = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            // Inputs for validating Wages_RF16
            foreach (W2StateLocalTaxInfo w2StateLocalInfo in expectedW2RegularWagesData.W2StateLocalTaxInfo)
            {
                w2StateLocalInfo.StateIdNumber = null;
            }
            // Perist RegularWages W2 object filled StateIdNumber 
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
        public void RequiredFeildRF17()
        {
            // Prepare W2 RegularWages object.
            var expectedW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            foreach (var expectedW2StateLocalTaxInfo in expectedW2Data.W2StateLocalTaxInfo)
            {
                expectedW2StateLocalTaxInfo.StateWagesAmount = null;
            }
            var expectedTaxReturnData = new TaxReturnData {TaxData = JsonConvert.SerializeObject(expectedW2Data)};

            // Persist RegularWages object with StateWagesAmount as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);
            
            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId); 
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_STATE_LOCAL_STATE_WAGES)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF18
        /// <summary>
        /// Wages_RF18 -  Form W2 Box 17 State Tax Withheld is missing. Enter Zero for no value.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildRBox17()
        {
            // Prepare W2 RegularWages object.
            var expectedW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            foreach (var expectedW2StateLocalTaxInfo in expectedW2Data.W2StateLocalTaxInfo)
            {
                expectedW2StateLocalTaxInfo.StateTaxWithholdingAmount = null;
            }
            var expectedTaxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedW2Data) };

            // Persist RegularWages object with StateTaxWithholdingAmount as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_STATE_LOCAL_STATE_WAGES_TAX_WITH_HOLDING_AMOUNT)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF19
        /// <summary>
        /// Wages_RF19 -  Form W2 Box 18 Local Wages should not be Empty
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildRBox18()
        {
            // Prepare W2 RegularWages object.
            var expectedW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            foreach (var expectedW2StateLocalTaxInfo in expectedW2Data.W2StateLocalTaxInfo)
            {
                foreach (var expectedLocalInfo in expectedW2StateLocalTaxInfo.W2LocalTaxInfo)
                {
                    expectedLocalInfo.LocalWagesAmount = null;
                }
            }
            var expectedTaxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedW2Data) };

            // Persist RegularWages object with LocalWagesAmount as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_LOCAL_WAGES_AMOUNT)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF20
        /// <summary>
        /// Wages_RF20 -   Form W2 Box 19 Local Tax Withheld Missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildRBox19()
        {
            // Prepare W2 RegularWages object.
            var expectedW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            foreach (var expectedW2StateLocalTaxInfo in expectedW2Data.W2StateLocalTaxInfo)
            {
                foreach (var expectedLocalInfo in expectedW2StateLocalTaxInfo.W2LocalTaxInfo)
                {
                    expectedLocalInfo.LocalTaxWithholdingAmount = null;
                }
            }
            var expectedTaxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedW2Data) };

            // Persist RegularWages object with LocalTaxWithholdingAmount as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_LOCAL_WAGES_WITH_HOLDING_AMOUNT)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF21
        /// <summary>
        /// Wages_RF21 -  Form W2 Box 20 Locality Name is missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox20()
        {
            // Prepare W2 RegularWages object.
            var expectedW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            foreach (var expectedW2StateLocalTaxInfo in expectedW2Data.W2StateLocalTaxInfo)
            {
                foreach (var expectedLocalInfo in expectedW2StateLocalTaxInfo.W2LocalTaxInfo)
                {
                    expectedLocalInfo.LocalityName = string.Empty;
                }
            }
            var expectedTaxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedW2Data) };

            // Persist RegularWages object with LocalityName as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_LOCAL_WAGES_LOCALITY_NAME)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF22
        /// <summary>
        /// Wages_RF22 -  Form W2  Box12- Code12A  benefits amount  is missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox12AAmount12A()
        {
            // Prepare W2 RegularWages object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                }
            };
            var expectedTaxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) };

            // Persist RegularWages object with W2EmployerCode Amount as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_BENEFITS_OTHER_INFORMATION_12A)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF23
        /// <summary>
        /// Wages_RF23 -   Form W2 Box12- Code12B  benefits amount  is missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox12BAmount12B()
        {
            // Prepare W2 RegularWages object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                }
            };
            var expectedTaxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) };

            // Persist RegularWages object with W2EmployerCode Amount as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_BENEFITS_OTHER_INFORMATION_12B)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF24
        /// <summary>
        /// Wages_RF24 -   Form W2 Box12- Code12C  benefits amount  is missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox12CAmount12C()
        {
            // Prepare W2 RegularWages object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                }
            };
            var expectedTaxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) };

            // Persist RegularWages object with W2EmployerCode Amount as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_BENEFITS_OTHER_INFORMATION_12C)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF25
        /// <summary>
        /// Wages_RF25 -   Form W2 Box12- Code12D  benefits amount  is missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox12DAmount12D()
        {
            // Prepare W2 RegularWages object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                }
            };
            var expectedTaxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) };

            // Persist RegularWages object with W2EmployerCode Amount as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_BENEFITS_OTHER_INFORMATION_12D)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF26
        /// <summary>
        /// Wages_RF26 - Household employee wages is missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildHouseholdEmployeeWage()
        {
            // Preare Regularwages W2 object.
            var expectedHouseholdWagesData = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF26
            expectedHouseholdWagesData.Employer.HouseholdEmployeeWages = null;
            // Perist RegularWages W2 object with  HouseholdEmployeeWages as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedHouseholdWagesData) });
            // Get W2 object and Validate HouseholdEmployeeWages value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_HOUSE_HOLD_WAGES)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF27
        /// <summary>
        /// Wages_RF27 -  Institution name is missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildInstitutionName()
        {
            // Preare Regularwages W2 object.
            var expectedTaxableScholarshipData = CreateW2(EmploymentType.TaxableScholarshipIncome, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF27
            expectedTaxableScholarshipData.Employer.Organization.Name = string.Empty;
            // Perist RegularWages W2 object with  Institution Name as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedTaxableScholarshipData) });
            // Get W2 object and Validate Institution Name value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_INSTITUITION_NAME)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF28
        /// <summary>
        /// Wages_RF28 -  Institution Address is missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildInstitutionAddress()
        {
            // Preare Regularwages W2 object.
            var expectedTaxableScholarshipData = CreateW2(EmploymentType.TaxableScholarshipIncome, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF28
            expectedTaxableScholarshipData.Employer.Organization.Address.CompanyAddress.StreetAddress = string.Empty;
            // Perist RegularWages W2 object with  Institution Address as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedTaxableScholarshipData) });
            // Get W2 object and Validate Institution Address value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_INSTITUITION_ADDRESS)));
        }


        //Yogalakshmi - 3rd Sep 2014 - Added RF29
        /// <summary>
        /// Wages_RF29 -  Institution City name is missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildInstitutionCity()
        {
            // Preare Regularwages W2 object.
            var expectedTaxableScholarshipData = CreateW2(EmploymentType.TaxableScholarshipIncome, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF28
            expectedTaxableScholarshipData.Employer.Organization.Address.CompanyAddress.City = string.Empty;
            // Perist RegularWages W2 object with  Institution Address as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedTaxableScholarshipData) });
            // Get W2 object and Validate Institution Address value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_INSTITUITION_CITY)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF30
        /// <summary>
        /// Wages_RF30 -  State Code of institution is missing

        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildInstitutionStateCode()
        {
            // Preare Regularwages W2 object.
            var expectedTaxableScholarshipData = CreateW2(EmploymentType.TaxableScholarshipIncome, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF30
            expectedTaxableScholarshipData.Employer.Organization.Address.CompanyAddress.State.StateId = 0;
            // Perist RegularWages W2 object with  Institution State Code as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedTaxableScholarshipData) });
            // Get W2 object and Validate Institution State Code value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_INSTITUITION_STATE)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF31
        /// <summary>
        /// Wages_RF31 - Zip Code of institution is missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildInstitutionZipcode()
        {
            // Preare Regularwages W2 object.
            var expectedTaxableScholarshipData = CreateW2(EmploymentType.TaxableScholarshipIncome, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF31
            expectedTaxableScholarshipData.Employer.Organization.Address.CompanyAddress.Zip = string.Empty;
            // Perist RegularWages W2 object with  Institution Zip Code as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedTaxableScholarshipData) });
            // Get W2 object and Validate Institution Zip Code value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_INSTITUITION_ZIP)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF32
        /// <summary>
        /// Wages_RF32 - Taxable Scholarship amount is missing
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildScholarshipAmount()
        {
            // Preare Regularwages W2 object.
            var expectedTaxableScholarshipData = CreateW2(EmploymentType.TaxableScholarshipIncome, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF32
            expectedTaxableScholarshipData.Employer.TaxableScholarshipAmount = null;
            // Perist RegularWages W2 object with  TaxableScholarshipAmount as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedTaxableScholarshipData) });
            // Get W2 object and Validate TaxableScholarshipAmount value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_TAX_ABLE_SCHOLARSHIP_INCOME)));
        }


        //Yogalakshmi - 3rd Sep 2014 - Added RF33
        /// <summary>
        /// Wages_RF33 - Social security Wages is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox3()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF33
            expectedRegularWagesW2Data.SocialSecurityWagesAmount= null;
            // Perist RegularWages W2 object with  SocialSecurityWagesAmount as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate SocialSecurityWagesAmount value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_SOCIAL_SECURITY)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF34
        /// <summary>
        /// Wages_RF34 - Social security tax withheld is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox4()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF34
            expectedRegularWagesW2Data.SocialSecurityTaxWithholdingAmount = null;
            // Perist RegularWages W2 object with  SocialSecurityTaxWithholdingAmount as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate SocialSecurityTaxWithholdingAmount value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_SOCIAL_SECURITY_TAX_WITHHOLDING_AMOUNT)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF35
        /// <summary>
        /// Wages_RF35 - Medicare wages is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox5()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF35
            expectedRegularWagesW2Data.MedicareWagesAmount = null;
            // Perist RegularWages W2 object with  MedicareWagesAmount as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate MedicareWagesAmount value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_MEDICARE_WAGES_AMOUNT)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF36
        /// <summary>
        /// Wages_RF36 - Medicare tax withheld is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox6()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF36
            expectedRegularWagesW2Data.MedicareTaxWithholdingAmount = null;
            // Perist RegularWages W2 object with  MedicareTaxWithholdingAmount as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate MedicareTaxWithholdingAmount value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_MEDICARE_TAX_WITHHOLDING_AMOUNT)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF37
        /// <summary>
        /// Wages_RF37 -  Form W2 Box12- Code12A benefits code is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox12ACode12A()
        {
            // Prepare W2 RegularWages object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.NoneSelected,
                                    Amount = 50
                                }
            };
            var expectedTaxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) };

            // Persist RegularWages object with W2EmployerCode Code as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_BENEFITS_OTHER_INFORMATION_12A_AMOUNT)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF38
        /// <summary>
        /// Wages_RF38 - Form W2 Box 12- Code12B benefits code is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox12BCode12B()
        {
            // Prepare W2 RegularWages object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.NoneSelected,
                                    Amount = 50
                                }
            };
            var expectedTaxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) };

            // Persist RegularWages object with W2EmployerCode Code as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_BENEFITS_OTHER_INFORMATION_12B_AMOUNT)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF39
        /// <summary>
        /// Wages_RF39 -  Form W2 Box 12- Code12C benefits code is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox12CCode12C()
        {
            // Prepare W2 RegularWages object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.NoneSelected,
                                    Amount = 100
                                }
            };
            var expectedTaxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) };

            // Persist RegularWages object with W2EmployerCode Code as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_BENEFITS_OTHER_INFORMATION_12C_AMOUNT)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF40
        /// <summary>
        /// Wages_RF40 - Form W2 Box12- Code12D benefits code is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildBox12DCode12D()
        {
            // Prepare W2 RegularWages object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.W2EmployerCodes = new List<W2EmployerCode>
            {
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.AUncollectedSocSecOrRRTATaxOnTips,
                                    Amount = null
                                },
                new W2EmployerCode
                                {
                                    EmployerCode = EmployerCode.NoneSelected,
                                    Amount = 100
                                }
            };
            var expectedTaxReturnData = new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) };

            // Persist RegularWages object with W2EmployerCode Code as null
            var actualW2Data = mW2Repository.PersistW2TaxReturnData(mUserId, expectedTaxReturnData);

            // Get W2 object 
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, actualW2Data.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_BENEFITS_OTHER_INFORMATION_12D_AMOUNT)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF41
        /// <summary>
        /// Wages_RF41 - Description for other benefits  is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildOtherInformationDescription()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF41
            foreach (var otherInformation in expectedRegularWagesW2Data.OtherDeductsBenefits)
            {
                otherInformation.Description = string.Empty;
                otherInformation.W2OtherId = 0;
            }
            // Perist RegularWages W2 object with  Other information Description as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Other information Description value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_BENEFITS_OTHER_INFORMATION)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF42
        /// <summary>
        /// Wages_RF42 - Employer Name is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildHouseholdEmployerName()
        {
            // Preare Regularwages W2 object.
            var expectedHouseholdWagesData = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF42
            expectedHouseholdWagesData.Employer.Organization.Name = string.Empty;
            // Perist RegularWages W2 object with  Employer Name as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedHouseholdWagesData) });
            // Get W2 object and Validate Employer Name value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_HOUSE_HOLD_EMPLOYER_NAME_REQUIRED)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF43
        /// <summary>
        /// Wages_RF43 - Employer Street address is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildHouseholdEmployerAddress()
        {
            // Preare Regularwages W2 object.
            var expectedHouseholdWagesData = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF43
            expectedHouseholdWagesData.Employer.Organization.Address.CompanyAddress.StreetAddress = string.Empty;
            // Perist RegularWages W2 object with  Employer Address as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedHouseholdWagesData) });
            // Get W2 object and Validate Employer Address value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_HOUSE_HOLD_ADDRESS_REQUIRED)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF44
        /// <summary>
        /// Wages_RF44 - Employer City Name is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildHouseholdEmployerCity()
        {
            // Preare Regularwages W2 object.
            var expectedHouseholdWagesData = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF44
            expectedHouseholdWagesData.Employer.Organization.Address.CompanyAddress.City = string.Empty;
            // Perist RegularWages W2 object with  Employer City as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedHouseholdWagesData) });
            // Get W2 object and Validate Employer City value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_HOUSE_HOLD_CITY_REQUIRED)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF45
        /// <summary>
        /// Wages_RF45 - Employer State is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildHouseholdEmployerState()
        {
            // Preare Regularwages W2 object.
            var expectedHouseholdWagesData = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF45
            expectedHouseholdWagesData.Employer.Organization.Address.CompanyAddress.State.StateId = 0;
            // Perist RegularWages W2 object with  Employer State as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedHouseholdWagesData) });
            // Get W2 object and Validate Employer State value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_HOUSE_HOLD_STATE_REQUIRED)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF46
        /// <summary>
        /// Wages_RF46 - Employer Zip Code is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildHouseholdEmployerZipcode()
        {
            // Preare Regularwages W2 object.
            var expectedHouseholdWagesData = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF46
            expectedHouseholdWagesData.Employer.Organization.Address.CompanyAddress.Zip = string.Empty;
            // Perist RegularWages W2 object with  Employer Zipcode as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedHouseholdWagesData) });
            // Get W2 object and Validate Employer Zipcode value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_HOUSE_HOLD_ZIP_REQUIRED)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF53
        /// <summary>
        /// Wages_RF53 - Amount for other benefits  is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildOtherInformationAmount()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF53
            foreach (var otherInformation in expectedRegularWagesW2Data.OtherDeductsBenefits)
            {
                otherInformation.Amount = null;
            }
            // Perist RegularWages W2 object with  Other Information Amount as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate  Other Information Amount value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_BENEFITS_OTHER_INFORMATION_AMOUNT)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added RF54
        /// <summary>
        /// Wages_RF54 - Foreign Employment Compensation selection is missing.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void RequiredFeildForeignEmployment()
        {
            // Preare Regularwages W2 object.
            var expectedForeignEmploymentData = CreateW2(EmploymentType.ForeignEmployment, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_RF54
            expectedForeignEmploymentData.HasForeignEmployment = null;
            // Perist RegularWages W2 object with  ForeignEmployment as empty
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedForeignEmploymentData) });
            // Get W2 object and Validate ForeignEmployment value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_MISSING_FOREIGN_EMPLOYMENT_COMPENSATION)));
        }
        #endregion

       
        #region Validation
        //Yogalakshmi - 3rd Sep 2014 - Added V1
        /// <summary>
        /// Wages_V1 - Employer Identification number is invalid
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationEmployerIdentificationNumber()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V1
            expectedRegularWagesW2Data.Employer.Organization.EIN = "12";
            // Perist RegularWages W2 object with  EIN as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate WAGES_EIN value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_EIN_INVALID)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V2
        /// <summary>
        /// Wages_V2 - Employer Name has special characters
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationEmployerName()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V2
            expectedRegularWagesW2Data.Employer.Organization.Name = "abc@##";
            // Perist RegularWages W2 object with  Employer Name as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Employer Name value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_NAME_ALPHABET)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V3
        /// <summary>
        /// Wages_V3 - Employee Address has special character
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationEmployerAddress()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V3
            expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.StreetAddress = "abc@##";
            // Perist RegularWages W2 object with  Employer Address as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Employer Address value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_ADDRESS_ALPHABET)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V4
        /// <summary>
        /// Wages_V4 - Employer city Name has special characters
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationEmployerCity()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V3
            expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.City = "abc@##";
            // Perist RegularWages W2 object with  Employer City as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Employer City value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_CITY_ALPHABET)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V5
        /// <summary>
        /// Wages_V5 - Employee Address has special character
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationEmployeeAddress()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.HasEmployeeAddress = true;
            //Inputs for validating Wages_V5
            if (expectedRegularWagesW2Data.HasEmployeeAddress == true)
            {
                expectedRegularWagesW2Data.EmployeeAddress = new W2EmployeeAddress { StreetAddress = "abc@##" };
            }
            // Perist RegularWages W2 object with  Employee Address as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Employee Address value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYEEE_ADDRESS_ALPHABET)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V6
        /// <summary>
        /// Wages_V6 - Employee city Name has special characters
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationEmployeeCity()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.HasEmployeeAddress = true;
            //Inputs for validating Wages_V6
            if (expectedRegularWagesW2Data.HasEmployeeAddress == true)
            {
                expectedRegularWagesW2Data.EmployeeAddress = new W2EmployeeAddress { City = "abc@##" };
            }
            // Perist RegularWages W2 object with  Employee City as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Employee City value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYEE_CITY_ALPHABET)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V7
        /// <summary>
        /// Wages_V7 - Employer city Name has special characters
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationEmployerCityLessthanThreeChar()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V7
            expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.City = "ab";
            // Perist RegularWages W2 object with  Employer City as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Employer City value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_CITY_VALIDATION)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V8
        /// <summary>
        /// Wages_V8 - Institution name has special characters
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationInstitutionName()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.TaxableScholarshipIncome, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V8
            expectedRegularWagesW2Data.Employer.Organization.Name = "ab##$";
            // Perist RegularWages W2 object with  Institution Name as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Institution Name value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_INSTITUITION_NAME_ALPHABET)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V9
        /// <summary>
        /// Wages_V9 - Institution name has special characters
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationInstitutionAddress()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.TaxableScholarshipIncome, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V9
            expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.StreetAddress = "ab##$";
            // Perist RegularWages W2 object with  Institution Address as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Institution Address value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_INSTITUITION_ADDRESS_ALPHABET)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V10
        /// <summary>
        /// Wages_V10 - Institution city has special characters
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationInstitutionCity()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.TaxableScholarshipIncome, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V10
            expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.City = "ab##$";
            // Perist RegularWages W2 object with  Institution City as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Institution City value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_INSTITUITION_CITY_ALPHABET)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V11
        /// <summary>
        /// Wages_V11 - Employer Name has special characters.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationHouseholdEmployerName()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V11
            expectedRegularWagesW2Data.Employer.Organization.Name = "ab##$";
            // Perist RegularWages W2 object with  Employer Name as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Employer Name value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_HOUSE_HOLD_EMPLOYER_NAME_VALIDATION)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V12
        /// <summary>
        /// Wages_V12 - Employer address has special characters.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationHouseholdEmployerAddress()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V12
            expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.StreetAddress = "ab##$";
            // Perist RegularWages W2 object with  Employer Address as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Employer Address value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_HOUSE_HOLD_ADDRESS_VALIDATION)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V13
        /// <summary>
        /// Wages_V13 - Employer city Name has special characters.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationHouseholdEmployerCity()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V13
            expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.City = "ab##$";
            // Perist RegularWages W2 object with  Employer City as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Employer City value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_HOUSE_HOLD_CITY_VALIDATION)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V14
        /// <summary>
        /// Wages_V14 - Employer Zip Code is invalid.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationRegularW2EmployerZipCode()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V14
            expectedRegularWagesW2Data.Employer.Organization.Address.CompanyAddress.Zip = "12";
            // Perist RegularWages W2 object with  Employer Zipcode as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Employer Zipcode value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYER_ZIP_VALIDATION)));
        }


        //Yogalakshmi - 3rd Sep 2014 - Added V15
        /// <summary>
        /// Wages_V15 - Employer Zip Code is invalid.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationHouseholdEmployerZipcode()
        {
            // Preare Regularwages W2 object.
            var expectedHouseholdData = CreateW2(EmploymentType.HouseholdEmployeeWages, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V15
            expectedHouseholdData.Employer.Organization.Address.CompanyAddress.Zip = "12";
            // Perist RegularWages W2 object with  Household Employer Zipcode as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedHouseholdData) });
            // Get W2 object and Validate Household Employer Zipcode value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_HOUSE_HOLD_ZIP_VALIDATION)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V16
        /// <summary>
        /// Wages_V16 -  Institution Zip Code is invalid.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationTaxableScholarshipZipcode()
        {
            // Preare Regularwages W2 object.
            var expectedTaxableScholarshipData = CreateW2(EmploymentType.TaxableScholarshipIncome, OwnerType.PrimaryTaxPayer);
            //Inputs for validating Wages_V16
            expectedTaxableScholarshipData.Employer.Organization.Address.CompanyAddress.Zip = "12";
            // Perist RegularWages W2 object with  Institution Zipcode as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedTaxableScholarshipData) });
            // Get W2 object and Validate Institution Zipcode value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_INSTITUITION_ZIP_VALIDATION)));
        }

        //Yogalakshmi - 3rd Sep 2014 - Added V17
        /// <summary>
        /// Wages_V17 - Employee Zip Code is invalid.
        /// </summary>
        [TestMethod]
        [TestCategory("W2")]
        public void ValidationRegularW2EmployeeZipcode()
        {
            // Preare Regularwages W2 object.
            var expectedRegularWagesW2Data = CreateW2(EmploymentType.RegularW2Wages, OwnerType.PrimaryTaxPayer);
            expectedRegularWagesW2Data.HasEmployeeAddress = true;
            //Inputs for validating Wages_V17
            if (expectedRegularWagesW2Data.HasEmployeeAddress == true)
            {
                expectedRegularWagesW2Data.EmployeeAddress = new W2EmployeeAddress { ZipCode = "12" };
            }
            // Perist RegularWages W2 object with  Employee Zipcode as invalid
            var userData = mW2Repository.PersistW2TaxReturnData(mUserId, new TaxReturnData { TaxData = JsonConvert.SerializeObject(expectedRegularWagesW2Data) });
            // Get W2 object and Validate Employee Zipcode value.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, userData.UserDataId);
            Assert.IsTrue(userData.UserDataId > 0);
            Assert.IsTrue(taxObject.ErrorMessages.Any(er => er.ErrorCode.Equals(Constants.WAGES_EMPLOYEE_ZIP_VALIDATION)));
        }

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
                                        
                                        StateId = stateId
                                    },
                                    StateWagesAmount = Utilities.CreateRandomNumber(0, 3000),
                                    StateTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 3000),
                                    StateIdNumber = 12345, //Saravanan N - 21st Aug, 2014 - StateIdNumber used in place of StateCode.
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
                                       
                                        StateId = stateId,
                                    },
                                    StateWagesAmount = Utilities.CreateRandomNumber(0, 3000),
                                    StateTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 3000),
                                     StateIdNumber = 12346, //Saravanan N - 21st Aug, 2014 - StateIdNumber used in place of StateCode.
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
                        Assert.AreEqual(expectedW2StateLocalTaxInfo[x].StateIdNumber, actualW2StateLocalTaxInfo.StateIdNumber);
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

        private W2EmployerCode GetW2EmployerCode(EmployerCode employerCode, double amount)
        {
            return  new W2EmployerCode
                {
                    EmployerCode = employerCode,
                    Amount = amount
               };
        }
        #endregion

    }
}
