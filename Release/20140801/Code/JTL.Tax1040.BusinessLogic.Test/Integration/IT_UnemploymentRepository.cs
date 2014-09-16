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
        private long mUserDataId;
        private static long mStateId;
        private static IPersonalInfoRepository mPersonalInfoRepository = new PersonalInfoRepository();
        private static IUnemploymentRepository mUnemploymentRepository = new UnemploymentRepository();
        static TaxReturnData taxReturnData;
        private StringCollection errorMessages;
        private dynamic userInputData;
        IEnumerable<ErrorMessage> lstTaxObjectErrors = null;
        static ITaxReturnRepository mTaxReturnRepository;

        #endregion

        #region test initialize
        [TestInitialize()]
        public void TestInitialize()
        {
            mTaxReturnRepository = new TaxReturnRepository();
            //Get State. Use it all over the Test methods.
            mStateId = mPersonalInfoRepository.GetAllState().First().StateId;

            //Get UserId. Use it all over the Test methods.
            mUserId = IT_UserRepository.PersistNewUser();



            userInputData = new ExpandoObject();
            userInputData.userId = mUserId;


            taxReturnData = new TaxReturnData();

            errorMessages = new StringCollection();
        }
        #endregion

        #region Static Constructor
        static IT_UnemploymentRepository()
        {



        }

        #endregion

        #region Persist 1099G
        [TestMethod()]
        public void PersistForm1099G()
        {
            var userDataId = 0L;
            taxReturnData.UserDataId = userDataId;
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);



            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);
        }


        [TestMethod()]
        public void PersistMoreThanOneForm1099G()
        {
            Income income = new Income()
            {
                Form1099G = new List<Form1099G>()
            };

            // First 1099G
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId1 = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreNotEqual(0, form1099GId1);



            userInputData.currentForm1099GId = form1099GId1.Form1099GId;
            userInputData.userDataId = form1099GId1.UserDataId;
            Form1099G form1099G1 = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G1, null);

            Assert.AreEqual(form1099G1.Form1099GId, form1099GId1.Form1099GId);

            income.Form1099G.Add(form1099G1);


            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId2 = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreNotEqual(0, form1099GId2);

            userInputData.currentForm1099GId = form1099GId2.Form1099GId;
            userInputData.userDataId = form1099GId2.UserDataId;

            Form1099G form1099G2 = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G2, null);

            Assert.AreEqual(form1099G2.Form1099GId, form1099GId2.Form1099GId);

            income.Form1099G.Add(form1099G2);

            //Check Two 1099G Added
            Assert.AreEqual(income.Form1099G.Count, 2);

            form1099G1 = income.Form1099G.Find(frm => frm.Form1099GId == form1099GId1.Form1099GId);
            Assert.AreEqual(form1099G1.Form1099GId, form1099GId1.Form1099GId);

            form1099G2 = income.Form1099G.Find(frm => frm.Form1099GId == form1099GId2.Form1099GId);
            Assert.AreEqual(form1099G2.Form1099GId, form1099GId2.Form1099GId);

        }


        [TestMethod()]
        public void DeleteForm1099G()
        {

            //string jsonfrom1099G = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            //var form1099GId = mUnemploymentRepository.CreateAndPersist1099G(mUserId, string.Empty, jsonfrom1099G, string.Empty,
            //    mUserDataId, out errorMessageList);
            //Assert.AreNotEqual(0, form1099GId);

            //mUnemploymentRepository.DeleteAndPersist1099G(mUserId, mUserDataId, form1099GId, out errorMessageList);

            //userInputData.currentForm1099GId = form1099GId;
            //Form1099G form1099G = GetForm1099G(userInputData);
            //Assert.AreEqual(form1099G, null);
        }


        [TestMethod]
        public void DeteleAndPersistUnEmployment()
        {
            //Persist


            var userDataId = 0L;


            taxReturnData.UserDataId = userDataId;
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Delete

            UserDTO userDTO = new UserDTO();
            userDTO.UserId = mUserId;
            userDTO.UserDataId = form1099GId.UserDataId;
            userDTO.FormId = form1099GId.Form1099GId;
            mUnemploymentRepository.DeleteAndPersistUnemployment(userDTO);

            string taxObject = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(form1099GId.UserDataId, mUserId);
            var unEmploymentList = JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject).Income.Form1099G;

            //Assert
            Assert.AreNotEqual(1, unEmploymentList.Count);

        }

        [TestMethod]
        public void GetAllUnemployment()
        {
            //Persist


            var userDataId = 0L;


            taxReturnData.UserDataId = userDataId;
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);


            //Get
            UserDTO userDTO = new UserDTO();
            userDTO.UserId = mUserId;
            userDTO.UserDataId = form1099GId.UserDataId;
            userDTO.FormId = form1099GId.Form1099GId;

            var unEmploymentList = mUnemploymentRepository.GetAllUnemployment(userDTO);


            //Assert

            Assert.AreEqual(1, unEmploymentList.Item1.Count);
        }

        [TestMethod]
        public void GetUnemploymentById()
        {
            //Persist


            var userDataId = 0L;


            taxReturnData.UserDataId = userDataId;
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);


            //Get
            UserDTO userDTO = new UserDTO();
            userDTO.UserId = mUserId;
            userDTO.UserDataId = form1099GId.UserDataId;
            userDTO.FormId = form1099GId.Form1099GId;

            var unEmployment = mUnemploymentRepository.GetUnemploymentById(userDTO);


            //Assert

            Assert.IsNotNull(unEmployment);
        }

        [TestMethod()]
        public void PersistForm1099GWitOutPayerAddress()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreNotEqual(0, form1099GId);


            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            Form1099G form1099G = GetForm1099G(userInputData);
            form1099G.Payer.Address = null;

            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(form1099G);

            form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(form1099G.Form1099GId, form1099GId.Form1099GId);


            form1099G = GetForm1099G(userInputData);
            Assert.AreEqual(form1099G.Payer.Address, null);
        }

        [TestMethod()]
        public void PersistForm1099GWitOutPayer()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreNotEqual(0, form1099GId);


            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            Form1099G form1099G = GetForm1099G(userInputData);
            form1099G.Payer = null;

            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(form1099G);

            form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(form1099G.Form1099GId, form1099GId.Form1099GId);


            form1099G = GetForm1099G(userInputData);
            Assert.AreEqual(form1099G.Payer, null);
        }

        [TestMethod()]
        public void PersistForm1099GWitoutStateInformation()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreNotEqual(0, form1099GId);


            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            form1099G.Form1099StateInfo = null;

            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(form1099G);

            form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(form1099G.Form1099GId, form1099GId.Form1099GId);


            form1099G = GetForm1099G(userInputData);
            Assert.AreEqual(form1099G.Form1099StateInfo, null);
        }


        [TestMethod()]
        public void UpdateNewStateInfo()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreNotEqual(0, form1099GId);


            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            int stateInfoCount = form1099G.Form1099StateInfo.Count;

            //Add new state information
            form1099G.Form1099StateInfo.Add(CreateStatInformation());
            stateInfoCount = stateInfoCount + 1;
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(form1099G);

            form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);

            Assert.AreEqual(form1099G.Form1099GId, form1099GId.Form1099GId);



            form1099G = GetForm1099G(userInputData);
            Assert.AreEqual(stateInfoCount, form1099G.Form1099StateInfo.Count);

        }

        #endregion

        #region Helper Method

        public static Form1099G CreateForm1099G()
        {
            Form1099G form1099G = new Form1099G()
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
                PriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 20)

            };
            form1099G.OwnerType = (OwnerType)Utilities.CreateRandomNumber(0, 1);

            form1099G.Form1099StateInfo = new List<Form1099StateInformation>();

            form1099G.Form1099StateInfo.Add(CreateStatInformation());
            form1099G.Form1099StateInfo.Add(CreateStatInformation());
            form1099G.Form1099StateInfo.Add(CreateStatInformation());

            return form1099G;
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


        //Added by Prasanna on 02 July 2014
        [TestMethod()]
        public void FederalTaxWithholdingNotGreaterThan1099GBox1()
        {

            Form1099G form1099G = new Form1099G()
            {
                //Field 10
                FederalTaxWithHoldingAmount = 1000.00,
                //Field 9
                UnEmploymentCompensation = 100.00
            };
            // Persist
            PersistForm1099G();

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId,
        userInputData.userDataId);

            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            lstTaxObjectErrors = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_UNEMPLOYMENT_COMPENSATION && err.MessageType.StartsWith("BR"));

            foreach (var errorMsg in lstTaxObjectErrors)
            {
                Assert.IsNotNull(errorMsg.ErrorCode);
            }
        }

        //Added by Prasanna on 02 July 2014
        [TestMethod()]
        public void Box11NotGreaterThan1099GBox1()
        {
            Form1099G form1099G = new Form1099G()
            {
                //Field 9
                UnEmploymentCompensation = 100.00
            };
            Form1099StateInformation form1099StateInformation = new Form1099StateInformation()
            {
                //Field 14
                StateTaxWithholdingAmount = 1000.00
            };
            // Persist
            PersistForm1099G();

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId,
        userInputData.userDataId);

            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            lstTaxObjectErrors = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_UNEMPLOYMENT_COMPENSATION && err.MessageType.StartsWith("BR"));

            foreach (var errorMsg in lstTaxObjectErrors)
            {
                Assert.IsNotNull(errorMsg.ErrorCode);
            }
        }


        //Added by Prasanna on 02 July 2014
        [TestMethod()]
        public void RepaidUnemploymentCompensationReported()
        {
            Form1099G form1099G = new Form1099G()
           {
               IsPriorYearUnEmploymentRepaid = true,
               PriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 20)

           };
            // Persist
            PersistForm1099G();

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId,
      userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            lstTaxObjectErrors = taxObject.ErrorMessages.Where(err => err.Topic == Constants.TOPIC_UNEMPLOYMENT_COMPENSATION && err.MessageType.StartsWith("ER"));

            foreach (var errorMsg in lstTaxObjectErrors)
            {
                Assert.IsNotNull(errorMsg.ErrorCode);
            }

        }

        public static Form1099G CreateForm1099GForValidations()
        {
            Form1099G form1099G = new Form1099G()
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
                PriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 20)

            };
            form1099G.OwnerType = (OwnerType)Utilities.CreateRandomNumber(0, 1);

            form1099G.Form1099StateInfo = new List<Form1099StateInformation>();

            form1099G.Form1099StateInfo.Add(CreateStatInformation());
            form1099G.Form1099StateInfo.Add(CreateStatInformation());
            form1099G.Form1099StateInfo.Add(CreateStatInformation());
            return form1099G;
        }




        //Added by Prasanna on 03 July 2014
        [TestMethod()]
        public void PayerNameContainsNonAlphabeticCharacters()
        {
            var hasEligibilityDiagnostics = false;

            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);


            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);


            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_V1"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }


        //Added by Prasanna on 03 July 2014
        [TestMethod()]
        public void PayerAdressContainsNonAlphabeticCharacters()
        {
            var hasEligibilityDiagnostics = false;

            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);


            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId,
      userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_V2"));

            Assert.IsTrue(hasEligibilityDiagnostics);


        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void PayerCityContainsNonAlphabeticCharacters()
        {
            var hasEligibilityDiagnostics = false;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);


            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId,
      userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_V3"));

            Assert.IsTrue(hasEligibilityDiagnostics);


        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void InvalidZipCode()
        {
            var hasEligibilityDiagnostics = false;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            //userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_V4"));

            Assert.IsTrue(hasEligibilityDiagnostics);



        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void PayersFederalIdentificationNumberHasInvalidNumber()
        {
            var hasEligibilityDiagnostics = false;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            // userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_V4"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        public static Form1099G CreateForm1099GForRFValidations()
        {


            Form1099G form1099G = new Form1099G()
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
                PriorYearUnEmploymentRepaid = null

            };
            form1099G.OwnerType = 0;

            form1099G.Form1099StateInfo = new List<Form1099StateInformation>();

            form1099G.Form1099StateInfo.Add(CreateStatInformation1());
            form1099G.Form1099StateInfo.Add(CreateStatInformation1());
            form1099G.Form1099StateInfo.Add(CreateStatInformation1());
            return form1099G;
        }

        public static Form1099StateInformation CreateStatInformation1()
        {
            Form1099StateInformation form1099StateInformation = new Form1099StateInformation();
            form1099StateInformation.State = new State();
            form1099StateInformation.State.StateId = 0;
            form1099StateInformation.StateIdentificationNumber = "SIN" + Convert.ToString(Utilities.CreateRandomNumber(0, 20));
            form1099StateInformation.StateTaxWithholdingAmount = 1000;
            return form1099StateInformation;
        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void PayerNameNotGiven()
        {
            var hasEligibilityDiagnostics = false;

            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForRFValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            // userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF2"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void PayerAddressNotGiven()
        {
            var hasEligibilityDiagnostics = false;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForRFValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            //userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF3"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void PayerCityNotGiven()
        {
            var hasEligibilityDiagnostics = false;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForRFValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            //userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF4"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void PayerStateNotSelected()
        {
            var hasEligibilityDiagnostics = false;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForRFValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            // userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF5"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }


        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void PayerZipCodeNotGiven()
        {
            var hasEligibilityDiagnostics = false;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForRFValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            //userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF6"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }


        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void PayerFederalIdentificationNumberNotGiven()
        {
            var hasEligibilityDiagnostics = false;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForRFValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            //userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF7"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }


        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void UnEmploymentCompensationReceivedNotGiven()
        {
            var hasEligibilityDiagnostics = false;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForRFValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            //userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF8"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Removed since RF9 is removed in spec 2.3
        //Added by Prasanna on 07 July 2014
        //  [TestMethod()]
        //  public void RequiredValidation8()
        //  {

        //      var hasEligibilityDiagnostics = false;
        //      // Persist
        //      taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForRFValidations());
        //      var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
        //      Assert.AreEqual(1, form1099GId.Form1099GId);

        //      //userInputData.currentForm1099GId = form1099GId.Form1099GId;
        //      userInputData.userDataId = form1099GId.UserDataId;
        //      userInputData.currentForm1099GId = form1099GId.Form1099GId;
        //      Form1099G form1099G = GetForm1099G(userInputData);
        //      Assert.AreNotEqual(form1099G, null);  

        //      //Get
        //      BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId,
        //userInputData.userDataId);
        //      Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

        //      hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF9"));

        //      Assert.IsTrue(hasEligibilityDiagnostics);

        //  }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void RepaidUnEmploymentCompensationBenefitsReceived()
        {
            var hasEligibilityDiagnostics = false;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForRFValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            // userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF10"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }




        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void ReportedRepaidUnEmploymentCompensationBenefitsReceived()
        {
            var hasEligibilityDiagnostics = false;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForRFValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            //userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF11"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }


        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void Box11HasValueBox10aStateCodeMustBeSelected()
        {
            var hasEligibilityDiagnostics = false;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForRFValidations());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            //userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);

            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF12"));

            Assert.IsTrue(hasEligibilityDiagnostics);

        }

        //Added by Prasanna on 07 July 2014
        [TestMethod()]
        public void WhoseUnEmploymentCompensationNotSelected()
        {
            var hasEligibilityDiagnostics = false;
            var UserDateId = 0L;
            // Persist
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099GForRFValidations());

            FilingStatus filingStatus = FilingStatus.MarriedFilingJointly;

            var primaryTaxpayer = IT_PersonalInfo.CreatePrimaryTaxPayer(filingStatus);
            var userDateId = mPersonalInfoRepository.PersistPrimaryTaxPayer(primaryTaxpayer, mUserId, UserDateId, null);


            taxReturnData.UserDataId = userDateId.Item1;

            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(1, form1099GId.Form1099GId);

            // userInputData.currentForm1099GId = form1099GId.Form1099GId;
            userInputData.userDataId = form1099GId.UserDataId;
            userInputData.currentForm1099GId = form1099GId.Form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G, null);

            //Get
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId, userInputData.userDataId);
            Assert.IsTrue(taxObject.ErrorMessages.Count > 0);
            hasEligibilityDiagnostics = taxObject.ErrorMessages.Any(em => (em.ErrorCode == "UnemploymentCompensation_RF1"));
            Assert.IsTrue(hasEligibilityDiagnostics);

        }
    }

        #endregion
}

