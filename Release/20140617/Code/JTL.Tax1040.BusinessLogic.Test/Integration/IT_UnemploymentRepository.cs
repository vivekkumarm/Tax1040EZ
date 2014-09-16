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

namespace JTL.Tax1040.BusinessLogic.Test
{
   
    [TestClass]
    public class IT_UnemploymentRepository
    {
        #region private local variables
        private  long mUserId;
        private  long mUserDataId = 1;
        private static long mStateId;
        private static IPersonalInfoRepository mPersonalInfoRepository = new PersonalInfoRepository();
        private static IUnemploymentRepository mUnemploymentRepository = new UnemploymentRepository();
        static TaxReturnData taxReturnData;
        List<ErrorMessage> errorMessageList;
        private dynamic userInputData;
        #endregion

        #region test initialize
        [TestInitialize()]
        public void TestInitialize()
        {

            //Get State. Use it all over the Test methods.
            mStateId = mPersonalInfoRepository.GetAllState().First().StateId;
            //Get UserId. Use it all over the Test methods.
            mUserId = IT_UserRepository.PersistNewUser();
            //Get Person Id. Use it all over the test method

            userInputData = new ExpandoObject();
            userInputData.userId = mUserId;
            userInputData.userDataId = mUserDataId;

            taxReturnData = new TaxReturnData();
            taxReturnData.UserDataId = mUserDataId;
            
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

            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId,taxReturnData);
              Assert.AreNotEqual(0, form1099GId);


              userInputData.currentForm1099GId = form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G,null);

            Assert.AreEqual(form1099G.Form1099GId, form1099GId);
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
            long form1099GId1 = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreNotEqual(0, form1099GId1);


            userInputData.currentForm1099GId = form1099GId1;
            Form1099G form1099G1 = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G1, null);

            Assert.AreEqual(form1099G1.Form1099GId, form1099GId1);

            income.Form1099G.Add(form1099G1);

            // Second 1099G
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            long form1099GId2 = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreNotEqual(0, form1099GId2);


            userInputData.currentForm1099GId = form1099GId2;
            Form1099G form1099G2 = GetForm1099G(userInputData);
            Assert.AreNotEqual(form1099G2, null);

            Assert.AreEqual(form1099G2.Form1099GId, form1099GId2);

            income.Form1099G.Add(form1099G2);

            //Check Two 1099G Added
            Assert.AreEqual(income.Form1099G.Count, 2);

           form1099G1 =  income.Form1099G.Find(frm => frm.Form1099GId == form1099GId1);
           Assert.AreEqual(form1099G1.Form1099GId, form1099GId1);

           form1099G2 = income.Form1099G.Find(frm => frm.Form1099GId == form1099GId2);
           Assert.AreEqual(form1099G2.Form1099GId, form1099GId2);

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



        [TestMethod()]
        public void PersistForm1099GWitOutPayerAddress()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreNotEqual(0, form1099GId);

            //Delete payer address
            userInputData.currentForm1099GId = form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            form1099G.Payer.Address = null;

            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(form1099G);

            form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(form1099G.Form1099GId, form1099GId);


            form1099G = GetForm1099G(userInputData);
            Assert.AreEqual(form1099G.Payer.Address,null);
        }

        [TestMethod()]
        public void PersistForm1099GWitOutPayer()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreNotEqual(0, form1099GId);

            //Delete payer address
            userInputData.currentForm1099GId = form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            form1099G.Payer = null;

            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(form1099G);

            form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(form1099G.Form1099GId, form1099GId);


            form1099G = GetForm1099G(userInputData);
            Assert.AreEqual(form1099G.Payer, null);
        }

        [TestMethod()]
        public void PersistForm1099GWitoutStateInformation()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreNotEqual(0, form1099GId);

            //Delete payer address
            userInputData.currentForm1099GId = form1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            form1099G.Form1099StateInfo = null;

            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(form1099G);

            form1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreEqual(form1099G.Form1099GId, form1099GId);


            form1099G = GetForm1099G(userInputData);
            Assert.AreEqual(form1099G.Form1099StateInfo, null);
        }


        [TestMethod()]
        public void UpdateNewStateInfo()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099G());
            var expectedform1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);
            Assert.AreNotEqual(0, expectedform1099GId);

            userInputData.currentForm1099GId = expectedform1099GId;
            Form1099G form1099G = GetForm1099G(userInputData);
            int stateInfoCount = form1099G.Form1099StateInfo.Count;

            //Add new state information
            form1099G.Form1099StateInfo.Add(CreateStatInformation());
            stateInfoCount = stateInfoCount + 1;
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(form1099G);

            var actualform1099GId = mUnemploymentRepository.CreateAndPersistUnemployment(mUserId, taxReturnData);

            Assert.AreEqual(expectedform1099GId, actualform1099GId);


            //Check New sate information Added
            userInputData.currentForm1099GId = actualform1099GId;
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
                    PayerName = "Un employment Payer Name"  + Utilities.CreateRandomNumber(0, 5),
                    PayerIdentificationNumber = Convert.ToString( Utilities.CreateRandomNumber(0, 5)),
                    Address = new Address()
                    {
                        AddressType =   AddressType.TaxPayerAddress,
                        PayerAddress = new PayerAddress()
                        {
                            City = "Payer City",
                            StreetAddress = "Payer Street Address",
                            ZipCode = Convert.ToString( Utilities.CreateRandomNumber(0, 5)),
                            StateId = Utilities.CreateRandomNumber(0, 20),
                        }
                    }
                },
                UnEmploymentCompensation = Utilities.CreateRandomNumber(0, 20),
                FederalTaxWithHoldingAmount = Utilities.CreateRandomNumber(0, 20),
                IsCurrentYearUnemploymentRepaid =  Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                CurrentYearUnemploymentRepaid = Utilities.CreateRandomNumber(0, 20),
                IsPriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 1).ConvertToBoolean(),
                PriorYearUnEmploymentRepaid = Utilities.CreateRandomNumber(0, 20)
                
            };
            form1099G.OwnerType = (OwnerType)Utilities.CreateRandomNumber(0, 1);

            form1099G.Form1099StateInfo  = new List<Form1099StateInformation>();

            form1099G.Form1099StateInfo.Add(CreateStatInformation());
            form1099G.Form1099StateInfo.Add(CreateStatInformation());
            form1099G.Form1099StateInfo.Add(CreateStatInformation());

            return form1099G;
        }

        public static Form1099StateInformation CreateStatInformation()
        {
            Form1099StateInformation form1099StateInformation = new Form1099StateInformation();
            form1099StateInformation.StateId = mStateId;
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
                    form1099G = taxObject.Income.Form1099G.Find(frm => frm.Form1099GId == userInputData. currentForm1099GId);
                }
            }
            return form1099G;
        }

        #endregion
    }
}
