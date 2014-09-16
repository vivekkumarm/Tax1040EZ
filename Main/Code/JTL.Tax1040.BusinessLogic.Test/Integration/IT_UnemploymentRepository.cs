/*
Copyright   : Copyright Jeevan Technologies
File Name   : IT_UnemploymentRepository.cs 
Description : Business Logic for Tax Return  
Author      : Sathish N
Created Date : 16 Apr 2014

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
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace JTL.Tax1040.BusinessLogic.Test
{

    [TestClass]
    public class IT_UnemploymentRepository
    {
        #region private local variables
        private long mUserId;
        private static long mStateId;
        private static IPersonalInfoRepository mPersonalInfoRepository;
        private static IUnemploymentRepository mUnemploymentRepository;
        private static ITaxReturnRepository mTaxReturnRepository;
        static TaxReturnData mTaxReturnData;
        private StringCollection mErrorMessages;
        private dynamic mUserInputData;
        IEnumerable<ErrorMessage> mLstTaxObjectErrors = null;
        public long mUserDataId;
       

        #endregion

        #region test initialize
        [TestInitialize()]
        public void TestInitialize()
        {
            mTaxReturnRepository = new TaxReturnRepository();
            mPersonalInfoRepository = new PersonalInfoRepository();
            mUnemploymentRepository = new UnemploymentRepository();
            //Get State. Use it all over the Test methods.
            mStateId = mPersonalInfoRepository.GetAllState().First().StateId;
            //Get UserId. Use it all over the Test methods.
            mUserId = IT_UserRepository.PersistNewUser();
            mUserInputData = new ExpandoObject();
            mUserInputData.userId = mUserId;
            mTaxReturnData = new TaxReturnData();
            mErrorMessages = new StringCollection();
        }
        #endregion

        #region Persist 1099G
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PersistForm1099G()
        {
            //Prepare Form 1099G
            var expectedForm1099G = CreateForm1099G();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099G);

            //Persist Form 1099G
            var actualForm1099GData = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);
            

            //Get Form 1099G
            mUserInputData.currentForm1099GId = actualForm1099GData.Form1099GId;
            mUserInputData.userDataId = actualForm1099GData.UserDataId;
            Form1099G actualForm1099G = GetForm1099G(mUserInputData);

            Assert.AreNotEqual(actualForm1099G, null);
            Assert.AreEqual(actualForm1099G.Form1099GId, actualForm1099GData.Form1099GId);
            Assert.AreEqual(expectedForm1099G.Payer.Address.AddressId,actualForm1099G.Payer.Address.AddressId);
            Assert.AreEqual(expectedForm1099G.IsCurrentYearUnemploymentRepaid,actualForm1099G.IsCurrentYearUnemploymentRepaid);
            Assert.AreEqual(expectedForm1099G.OwnerType,actualForm1099G.OwnerType);
        }

        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PersistMoreThanOneForm1099G()
        {
            var income = new Income()
            {
                Form1099G = new List<Form1099G>()
            };

            //Prepare and Persist First Form 1099G
            var expectedForm1099G = CreateForm1099G();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099G);
            var actualForm1099GData = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Prepare and Persist Second Form 1099G
            expectedForm1099G = CreateForm1099G();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099G);
            actualForm1099GData= mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.currentForm1099GId = actualForm1099GData.Form1099GId;
            mUserInputData.userDataId = actualForm1099GData.UserDataId;
            var actualForm1099G = GetForm1099G(mUserInputData);

            //Check Two 1099G Added
            actualForm1099G = income.Form1099G.Find(frm => frm.Form1099GId == actualForm1099GData.Form1099GId);
            Assert.AreEqual(actualForm1099G.Form1099GId, actualForm1099GData.Form1099GId);
            Assert.AreEqual(expectedForm1099G.IsCurrentYearUnemploymentRepaid,actualForm1099G.IsCurrentYearUnemploymentRepaid);
            Assert.AreEqual(expectedForm1099G.Payer.Address.AddressId,actualForm1099G.Payer.Address.AddressId);
        }

        [TestMethod]
        [TestCategory("Form1099G")]
        public void DeteleAndPersistUnEmployment()
        {
            //Prepare Form 1099G
            var expectedForm1099G = CreateForm1099G();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099G);

            //Persist Form 1099G
            var actualForm1099GData = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Delete Form 1099G
            var userDTO = new UserDTO
            {
                UserId = mUserId,
                UserDataId = actualForm1099GData.UserDataId,
                FormId = actualForm1099GData.Form1099GId
            };
            mUnemploymentRepository.DeleteAndPersistUnemployment(userDTO);


            //Get Form 1099G
            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(actualForm1099GData.UserDataId, mUserId);
            var actualForm1099GList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099G;

            Assert.AreNotEqual(1, actualForm1099GList.Count);
        }

        [TestMethod]
        [TestCategory("Form1099G")]
        public void GetAllUnemployment()
        {
            //Prepare Form 1099G
            var expectedForm1099G = CreateForm1099G();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099G);

            //Persist Form 1099G
            var expectedForm1099GData = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.currentForm1099GId = expectedForm1099GData.Form1099GId;
            mUserInputData.userDataId = expectedForm1099GData.UserDataId;

            var userDTO = new UserDTO
            {
                UserId = mUserId,
                UserDataId = expectedForm1099GData.UserDataId,
                FormId = expectedForm1099GData.Form1099GId
            };

            var actualForm1099GList = mUnemploymentRepository.GetAllUnemployment(userDTO);

            Assert.AreEqual(1, actualForm1099GList.Item1.Count);
            foreach (var actualForm1099G in actualForm1099GList.Item1)
            {
                Assert.AreEqual(expectedForm1099G.Payer.Address.AddressId,actualForm1099G.Payer.Address.AddressId);
                Assert.AreEqual(expectedForm1099G.IsPriorYearUnEmploymentRepaid,actualForm1099G.IsPriorYearUnEmploymentRepaid);
            }

           
        }

        [TestMethod]
        [TestCategory("Form1099G")]
        public void GetUnemploymentById()
        {
            //Prepare Form 1099G
            var expectedForm1099G = CreateForm1099G();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099G);

            //Persist Form 1099G
            var expectedForm1099GData = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.currentForm1099GId = expectedForm1099GData.Form1099GId;
            mUserInputData.userDataId = expectedForm1099GData.UserDataId;

            var userDTO = new UserDTO
            {
                UserId = mUserId,
                UserDataId = expectedForm1099GData.UserDataId,
                FormId = expectedForm1099GData.Form1099GId
            };

            var actualForm1099GList = mUnemploymentRepository.GetUnemploymentById(userDTO);
            Assert.IsNotNull(actualForm1099GList);
            Assert.AreEqual(expectedForm1099G.Payer.Address.AddressId,actualForm1099GList.Item1.Payer.Address.AddressId);
            Assert.AreEqual(expectedForm1099G.IsPriorYearUnEmploymentRepaid,actualForm1099GList.Item1.IsPriorYearUnEmploymentRepaid);
       
            
        }


        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PersistForm1099GWitoutStateInformation()
        {
            //Prepare Form 1099G
            var expectedForm1099G = CreateForm1099G();
            expectedForm1099G.Form1099StateInfo = null;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099G);

            //Persist Form 1099G
            var actualForm1099GData = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.userDataId = actualForm1099GData.UserDataId;
            mUserInputData.currentForm1099GId = actualForm1099GData.Form1099GId;
            Form1099G actualForm1099G = GetForm1099G(mUserInputData);
            Assert.AreEqual(expectedForm1099G.Form1099StateInfo,actualForm1099G.Form1099StateInfo);
           
        }


        [TestMethod()]
        [TestCategory("Form1099G")]
        public void UpdateNewStateInfo()
        {
            //Prepare Form 1099G
            var givenForm1099G = CreateForm1099G();
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(givenForm1099G);

            //Persist Form 1099G
            var expectedForm1099GData = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);
            //Get Form 1099G
            mUserInputData.userDataId = expectedForm1099GData.UserDataId;
            mUserInputData.currentForm1099GId = expectedForm1099GData.Form1099GId;
            Form1099G expectedForm1099G= GetForm1099G(mUserInputData);

            //Add new state information
            expectedForm1099G.Form1099StateInfo.Add(CreateStatInformation());
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099G);
            mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);
            var actualForm1099G = (Form1099G)GetForm1099G(mUserInputData);
            Assert.AreEqual(expectedForm1099G.Form1099StateInfo.Count,actualForm1099G.Form1099StateInfo.Count);
        }


        [TestMethod()]
        [TestCategory("Form1099G")]
        public void FederalTaxWithholdingNotGreaterThanUnEmploymentCompensation()
        {
            //Prepare Form 1099G
            var expectedForm1099G = CreateForm1099G();
            expectedForm1099G.FederalTaxWithHoldingAmount = 1000.00;
            expectedForm1099G.UnEmploymentCompensation = 100;
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099G);

            //Persist Form 1099G
            var actualForm1099GData = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099G = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId,
            actualForm1099GData.UserDataId);
            Assert.IsTrue(actualForm1099G.ErrorMessages.Count > 0);
            mLstTaxObjectErrors = actualForm1099G.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_UNEMPLOYMENT_COMPENSATION && err.MessageType.StartsWith("BR"));
            foreach (var errorMsg in mLstTaxObjectErrors)
            {
                Assert.IsNotNull(errorMsg.ErrorCode);
            }
        }


        //Added by Prasanna on 02 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void StateTaxWithholdingAmountNotGreaterThanUnEmploymentCompensation()
        {

            //Prepare Form 1099G
            var expectedForm1099G = CreateForm1099G();
            expectedForm1099G.UnEmploymentCompensation = 100;

            foreach (var stateInfo in expectedForm1099G.Form1099StateInfo)
            {
                stateInfo.StateTaxWithholdingAmount = 1000.00;
            }
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099G);

            //Persist Form 1099G
            var actualForm1099GData = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099G = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId,
            actualForm1099GData.UserDataId);
            Assert.IsTrue(actualForm1099G.ErrorMessages.Count > 0);
            mLstTaxObjectErrors = actualForm1099G.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_UNEMPLOYMENT_COMPENSATION && err.MessageType.StartsWith("BR"));
            foreach (var errorMsg in mLstTaxObjectErrors)
            {
                Assert.IsNotNull(errorMsg.ErrorCode);
            }
        }


        //Added by Prasanna on 02 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void RepaidUnemploymentCompensationReported()
        {

            //Prepare Form 1099G
            var expectedForm1099G = CreateForm1099G();
            expectedForm1099G.IsPriorYearUnEmploymentRepaid = true;
            expectedForm1099G.PriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 20);

            mTaxReturnData.TaxData = JsonConvert.SerializeObject(expectedForm1099G);

            //Persist Form 1099G
            var actualForm1099GData = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099G = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId,
            actualForm1099GData.UserDataId);
            Assert.IsTrue(actualForm1099G.ErrorMessages.Count > 0);
            mLstTaxObjectErrors = actualForm1099G.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_UNEMPLOYMENT_COMPENSATION && err.MessageType.StartsWith("ER"));
            foreach (var errorMsg in mLstTaxObjectErrors)
            {
                Assert.IsNotNull(errorMsg.ErrorCode);
            }

        }


        //Added by Prasanna on 03 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PayerNameContainsNonAlphabeticCharacters()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);


            //Get Form 1099G 
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;
            

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_V1"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }


        //Added by Prasanna on 03 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PayerAdressContainsNonAlphabeticCharacters()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId,
            mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_V2"));
            Assert.IsTrue(hasEligibilityDiagnostics);


        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PayerCityContainsNonAlphabeticCharacters()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId,
            mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_V3"));
            Assert.IsTrue(hasEligibilityDiagnostics);


        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void InvalidZipCode()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_V4"));
            Assert.IsTrue(hasEligibilityDiagnostics);



        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PayersFederalIdentificationNumberHasInvalidNumber()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G 
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_V4"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PayerNameNotGiven()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForRFValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G 
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF2"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PayerAddressNotGiven()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForRFValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G 
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF3"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PayerCityNotGiven()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForRFValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF4"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PayerStateNotSelected()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForRFValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G 
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF5"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PayerZipCodeNotGiven()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForRFValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF6"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void PayerFederalIdentificationNumberNotGiven()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForRFValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G 
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF7"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void UnEmploymentCompensationReceivedNotGiven()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForRFValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF8"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }
       
        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void RepaidUnEmploymentCompensationBenefitsReceived()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForRFValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF10"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void ReportedRepaidUnEmploymentCompensationBenefitsReceived()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForRFValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 actualForm1099GData = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(actualForm1099GData.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = actualForm1099GData.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF11"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }


        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void StateTaxWithheldHasValueStateCodeMustBeSelected()
        {
            var hasEligibilityDiagnostics = false;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForRFValidations());

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G 
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF12"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }


        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        [TestCategory("Form1099G")]
        public void WhoseUnEmploymentCompensationNotSelected()
        {
            var hasEligibilityDiagnostics = false;
            var UserDateId = 0L;

            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForRFValidations());
            var filingStatus = FilingStatus.MarriedFilingJointly;
            var primaryTaxpayer = IT_PersonalInfo.CreatePrimaryTaxPayer(filingStatus);

            //Persist Primary Taxpayer
            var userDateId = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxpayer, mUserId, UserDateId, null);
            mTaxReturnData.UserDataId = userDateId.Item1;

            //Persist Form 1099G
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);

            //Get Form 1099G
            mUserInputData.userDataId = form1099GId.UserDataId;
            mUserInputData.currentForm1099GId = form1099GId.Form1099GId;

            //Get Form 1099G with all validations
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserInputData.userId, mUserInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF1"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        #region Eligibility Rules

        [TestMethod]
        public void ValidateUnEmploymentER1()
        {
            var hasEligibilityDiagnostics = false;
            //Prepare Form 1099G
            mTaxReturnData.TaxData = JsonConvert.SerializeObject(CreateForm1099GForERValidations());
            var primaryTaxpayer = IT_PersonalInfo.CreatePrimaryTaxPayer(FilingStatus.MarriedFilingJointly);

            //Persist Primary Taxpayer
            var userDateId = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxpayer, mUserId, mUserDataId, null);
            mTaxReturnData.UserDataId = userDateId.Item1;

            //Persist Form 1099G
             mUserInputData = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, mTaxReturnData);
            //Get Form 1099G with all validations
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(mUserId, mUserInputData.UserDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_ER1"));
            Assert.IsTrue(hasEligibilityDiagnostics);
        }

        private static Form1099G CreateForm1099GForERValidations()
        {
            var form1099G = new Form1099G
            {
                Payer = new Payer()
                {
                    PayerName = "prasana@123",
                    PayerIdentificationNumber = "1234@123",
                    Address = new Address()
                    {
                        AddressType = AddressType.TaxPayerAddress,
                        PayerAddress = new PayerAddress()
                        {
                            City = "Washington@123",
                            StreetAddress = "21/G, Gee Road",
                            ZipCode = "1234123",
                            State = new State()
                            {
                                StateId = Utilities.CreateRandomNumber(0, 20)
                            }
                        }
                    }
                },
                UnEmploymentCompensation = Utilities.CreateRandomNumber(0, 20),
                FederalTaxWithHoldingAmount = Utilities.CreateRandomNumber(0, 20),
                IsCurrentYearUnemploymentRepaid = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                CurrentYearUnemploymentRepaid = Utilities.CreateRandomNumber(0, 20),
                IsPriorYearUnEmploymentRepaid = true,
                PriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 20),
                OwnerType = (OwnerType)Utilities.CreateRandomNumber(0, 1),
                Form1099StateInfo =
                    new List<Form1099StateInformation>
                    {
                        CreateStatInformation(),
                        CreateStatInformation(),
                        CreateStatInformation()
                    }
            };

            return form1099G;
        }


        #endregion

        #endregion

        #region Helper Method

        public static Form1099G CreateForm1099G()
        {
            var form1099G = new Form1099G
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
                            City = "California",
                            StreetAddress = "Payer Street Address",
                            ZipCode = "90060",
                            State = new State()
                            {
                                StateId = Utilities.CreateRandomNumber(0, 20)
                            }
                        }
                    }
                },
                UnEmploymentCompensation = Utilities.CreateRandomNumber(0, 20),
                FederalTaxWithHoldingAmount = Utilities.CreateRandomNumber(0, 20),
                IsCurrentYearUnemploymentRepaid = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                CurrentYearUnemploymentRepaid = Utilities.CreateRandomNumber(0, 20),
                IsPriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                PriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 20),
                OwnerType = (OwnerType) Utilities.CreateRandomNumber(0, 1),
                Form1099StateInfo =
                    new List<Form1099StateInformation>
                    {
                        CreateStatInformation(),
                        CreateStatInformation(),
                        CreateStatInformation()
                    }
            };

            return form1099G;
        }

        public static Form1099StateInformation CreateStatInformation()
        {
            var form1099StateInformation = new Form1099StateInformation
            {
                State = new State()
                {
                    StateId = mStateId
                },
                StateIdentificationNumber = "SIN" + Convert.ToString(Utilities.CreateRandomNumber(0, 20)),
                StateTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 20)
            };
            return form1099StateInformation;
        }


        public static Form1099G GetForm1099G(dynamic userInputData)
        {
            Form1099G form1099G = null;
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId,
         userInputData.userDataId);

            if (taxObject != null)
            {
                if (taxObject.Income != null && taxObject.Income.Form1099G != null)
                {
                    form1099G = taxObject.Income.Form1099G.Find(frm => frm.Form1099GId == userInputData.currentForm1099GId);
                }
            }
            return form1099G;
        }

        public static Form1099G CreateForm1099GForValidations()
        {
            var form1099G = new Form1099G
            {
                Payer = new Payer()
                {
                    PayerName = "prasana@123",
                    PayerIdentificationNumber = "1234@123",
                    Address = new Address()
                    {
                        AddressType = AddressType.TaxPayerAddress,
                        PayerAddress = new PayerAddress()
                        {
                            City = "Washington@123",
                            StreetAddress = "21/G, Gee Road",
                            ZipCode = "1234123",
                            State = new State()
                            {
                                StateId = Utilities.CreateRandomNumber(0, 20)
                            }
                        }
                    }
                },
                UnEmploymentCompensation = Utilities.CreateRandomNumber(0, 20),
                FederalTaxWithHoldingAmount = Utilities.CreateRandomNumber(0, 20),
                IsCurrentYearUnemploymentRepaid = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                CurrentYearUnemploymentRepaid = Utilities.CreateRandomNumber(0, 20),
                IsPriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                PriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 20),
                OwnerType = (OwnerType) Utilities.CreateRandomNumber(0, 1),
                Form1099StateInfo =
                    new List<Form1099StateInformation>
                    {
                        CreateStatInformation(),
                        CreateStatInformation(),
                        CreateStatInformation()
                    }
            };

            return form1099G;
        }
      
        public static Form1099G CreateForm1099GForRFValidations()
        {
            var form1099G = new Form1099G
            {
                Payer = new Payer()
                {
                    PayerName = "",
                    PayerIdentificationNumber = "",
                    Address = new Address()
                    {
                        AddressType = AddressType.TaxPayerAddress,
                        PayerAddress = new PayerAddress()
                        {
                            City = "",
                            StreetAddress = "",
                            ZipCode = "",
                            State = new State()
                            {
                                StateId = 0
                            }
                        }
                    }
                },
                UnEmploymentCompensation = null,
                FederalTaxWithHoldingAmount = null,
                IsCurrentYearUnemploymentRepaid = true,
                CurrentYearUnemploymentRepaid = null,
                IsPriorYearUnEmploymentRepaid = true,
                PriorYearUnEmploymentRepaid = null,
                OwnerType = 0,
                Form1099StateInfo =
                    new List<Form1099StateInformation>
                    {
                        CreateStatInformation1(),
                        CreateStatInformation1(),
                        CreateStatInformation1()
                    }
            };

            return form1099G;
        }

        public static Form1099StateInformation CreateStatInformation1()
        {
            var form1099StateInformation = new Form1099StateInformation
            {
                State = new State {StateId = 0},
                StateIdentificationNumber = "SIN" + Convert.ToString(Utilities.CreateRandomNumber(0, 20)),
                StateTaxWithholdingAmount = 1000
            };
            return form1099StateInformation;
        }




    }

        #endregion
}

