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

namespace JTL.Tax1040.BusinessLogic.Test
{
    [TestClass]
    public class IT_IntrestIncomeForm1099OIDRepository
    {

        #region private local variables
        private long mUserId;
        private long mUserDataId = 1;
        private static long mStateId;
        private static IPersonalInfoRepository mPersonalInfoRepository = new PersonalInfoRepository();
        private static InterestIncomeRepository mInterestIncomeRepository = new InterestIncomeRepository();
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
            mUserId = IT_UserRepository.PersistNewUser();
            //Get Person Id. Use it all over the test method

            userInputData = new ExpandoObject();
            userInputData.userId = mUserId;
            userInputData.userDataId = mUserDataId;

            taxReturnData = new TaxReturnData(); 

        }
        #endregion

        #region Persist 1099OID
        [TestMethod()]
        public void PersistForm1099OID()
        {

            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099OID());
            taxReturnData.UserDataId = mUserDataId;
            var form1099OIDId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);
            Assert.AreNotEqual(0, form1099OIDId);


            userInputData.currentForm1099OIDId = form1099OIDId;
            Form1099OID form1099OID = GetForm1099OID(userInputData);
            Assert.AreNotEqual(form1099OID, null);

            Assert.AreEqual(form1099OID.Form1099OIDId, form1099OIDId);
        }


        [TestMethod()]
        public void PersistMoreThanOneForm1099OID()
        {

            Income income = new Income()
            {
                Form1099OID = new List<Form1099OID>()
            };

            // First 1099OID
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099OID());
            taxReturnData.UserDataId = mUserDataId;
            long form1099OIDId1 = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);
            Assert.AreNotEqual(0, form1099OIDId1);


            userInputData.currentForm1099OIDId = form1099OIDId1;
            Form1099OID form1099OId1 = GetForm1099OID(userInputData);
            Assert.AreNotEqual(form1099OId1, null);

            Assert.AreEqual(form1099OId1.Form1099OIDId, form1099OIDId1);

            income.Form1099OID.Add(form1099OId1);

            // Second 1099OID
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099OID());
            taxReturnData.UserDataId = mUserDataId;
            long form1099OIDId2 = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);
            Assert.AreNotEqual(0, form1099OIDId2);


            userInputData.currentForm1099OIDId = form1099OIDId2;
            Form1099OID form1099OId2 = GetForm1099OID(userInputData);
            Assert.AreNotEqual(form1099OId2, null);

            Assert.AreEqual(form1099OId2.Form1099OIDId, form1099OIDId2);

            income.Form1099OID.Add(form1099OId2);

            //Check Two 1099OID Added
            Assert.AreEqual(income.Form1099OID.Count, 2);

            form1099OId1 = income.Form1099OID.Find(frm => frm.Form1099OIDId == form1099OIDId1);
            Assert.AreEqual(form1099OId1.Form1099OIDId, form1099OIDId1);

            form1099OId2 = income.Form1099OID.Find(frm => frm.Form1099OIDId == form1099OIDId2);
            Assert.AreEqual(form1099OId2.Form1099OIDId, form1099OIDId2);
        }

        //Saravanan N - 9th May, 2014 - UserDTO added.
        [TestMethod()]
        public void DeleteForm1099OID()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099OID());
            taxReturnData.UserDataId = mUserDataId;
            var form1099OIDId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);
            Assert.AreNotEqual(0, form1099OIDId);

            UserDTO userDTO = new UserDTO();
            userDTO.UserId = mUserId;
            userDTO.UserDataId = taxReturnData.UserDataId;
            userDTO.FormId = form1099OIDId;
            mInterestIncomeRepository.DeleteAndPersist1099OID(userDTO);

            userInputData.currentForm1099OIDId = form1099OIDId;
            Form1099OID Form1099OID = GetForm1099OID(userInputData);
            Assert.AreEqual(Form1099OID, null);
        }


        [TestMethod()]
        public void PersistForm1099OIDWitOutPayerAddress()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099OID());
            taxReturnData.UserDataId = mUserDataId;
            var form1099OIDId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);
            Assert.AreNotEqual(0, form1099OIDId);

            //Delete payer address
            userInputData.currentForm1099OIDId = form1099OIDId;
            Form1099OID form1099OID = GetForm1099OID(userInputData);
            form1099OID.Payer.Address = null;

            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(form1099OID);

            form1099OIDId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);
            Assert.AreEqual(form1099OID.Form1099OIDId, form1099OIDId);


            form1099OID = GetForm1099OID(userInputData);
            Assert.AreEqual(form1099OID.Payer.Address, null);
        }

        [TestMethod()]
        public void PersistForm1099OIDWitOutPayer()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099OID());
            taxReturnData.UserDataId = mUserDataId;
            var form1099OIDId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);
            Assert.AreNotEqual(0, form1099OIDId);

            //Delete payer address
            userInputData.currentForm1099OIDId = form1099OIDId;
            Form1099OID form1099OID = GetForm1099OID(userInputData);
            form1099OID.Payer = null;

            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(form1099OID);

            form1099OIDId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);
            Assert.AreEqual(form1099OID.Form1099OIDId, form1099OIDId);


            form1099OID = GetForm1099OID(userInputData);
            Assert.AreEqual(form1099OID.Payer, null);
        }

         [TestMethod()]
        public void PersistForm1099OIDWitoutStateInformation()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099OID());
            taxReturnData.UserDataId = mUserDataId;
            var form1099OIDId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);
            Assert.AreNotEqual(0, form1099OIDId);

            //Delete State Information
            userInputData.currentForm1099OIDId = form1099OIDId;
            Form1099OID form1099OID = GetForm1099OID(userInputData);
            form1099OID.Form1099StateInfo = null;

            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(form1099OID);

            form1099OIDId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);
            Assert.AreEqual(form1099OID.Form1099OIDId, form1099OIDId);


            form1099OID = GetForm1099OID(userInputData);
            Assert.AreEqual(form1099OID.Form1099StateInfo, null);
        }

        [TestMethod()]
         public void UpdateNewStateInfo()
        {
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(CreateForm1099OID());
            taxReturnData.UserDataId = mUserDataId;
            var expectedform1099OIDId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);
            Assert.AreNotEqual(0, expectedform1099OIDId);

            userInputData.currentForm1099OIDId = expectedform1099OIDId;
            Form1099OID form1099OID = GetForm1099OID(userInputData);
            int stateInfoCount = form1099OID.Form1099StateInfo.Count;
            
            //Add new state information
            form1099OID.Form1099StateInfo.Add(CreateStatInformation());
            stateInfoCount = stateInfoCount + 1;
            taxReturnData.TaxData = Newtonsoft.Json.JsonConvert.SerializeObject(form1099OID);

            var actualform1099OIDId = mInterestIncomeRepository.PersistTaxReturnForm1099OIDData(taxReturnData);

            Assert.AreEqual(expectedform1099OIDId, actualform1099OIDId);


            //Check New sate information Added
            userInputData.currentForm1099OIDId = actualform1099OIDId;
            form1099OID = GetForm1099OID(userInputData);
            Assert.AreEqual(stateInfoCount, form1099OID.Form1099StateInfo.Count);

        }


        #endregion


        #region Helper Method

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
                            StateId = Utilities.CreateRandomNumber(0, 20),
                        }
                    }
                },
                AccountNumber = Convert.ToString( Utilities.CreateRandomNumber(0, 20)),
                OriginalIssueDiscount =Utilities.CreateRandomNumber(0, 20),
                OtherPeriodicInterest =Utilities.CreateRandomNumber(0, 20),
                EarlyWithdrawalPenalty =Utilities.CreateRandomNumber(0, 20),
                IncomeMarketDiscount =Utilities.CreateRandomNumber(0, 20),
                ForeignTaxPaid =Utilities.CreateRandomNumber(0, 20),
                ForeignCountryId= Utilities.CreateRandomNumber(0, 20),
                IsMutualFundRegulatedInvestment = Convert.ToBoolean( Utilities.CreateRandomNumber(0, 1)),
                USTreasuryObligations =Utilities.CreateRandomNumber(0, 20),
                InvestmentExpenses =Utilities.CreateRandomNumber(0, 20),
                IsStateInformationAvailable = Convert.ToBoolean( Utilities.CreateRandomNumber(0, 1)),
                InterestReceivedAsNominee =Utilities.CreateRandomNumber(0, 20),
                AdjustmentAmount =Utilities.CreateRandomNumber(0, 20),
                TaxableInterestAmount =Utilities.CreateRandomNumber(0, 20),
                FederalTaxWithHoldingAmount =Utilities.CreateRandomNumber(0, 20),
                Description = "Description" + Convert.ToString( Utilities.CreateRandomNumber(0, 20)),
                AcquisitionPremium =Utilities.CreateRandomNumber(0, 20),
                HasToReportTaxExempt=  Convert.ToBoolean( Utilities.CreateRandomNumber(0, 1)),
                HasToReportAdjustment=  Convert.ToBoolean( Utilities.CreateRandomNumber(0, 1)),
                TaxExemptInterestStateId = mStateId,
                StateExemptInterest =Utilities.CreateRandomNumber(0, 20),
                Owner =  (OwnerType) Utilities.CreateRandomNumber(1, 2),
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
            form1099StateInformation.StateId = mStateId;
            form1099StateInformation.StateIdentificationNumber = "SIN" + Convert.ToString(Utilities.CreateRandomNumber(0, 20));
            form1099StateInformation.StateTaxWithholdingAmount = Utilities.CreateRandomNumber(0, 20);
            return form1099StateInformation;
        }


        public static Form1099OID GetForm1099OID(dynamic userInputData)
        {
            Form1099OID form1099OID = null;
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.userId,
         userInputData.userDataId);
            if (taxObject != null)
            {
                if (taxObject.Income != null && taxObject.Income.Form1099OID != null)
                {
                    form1099OID = taxObject.Income.Form1099OID.Find(frm => frm.Form1099OIDId == userInputData.currentForm1099OIDId);
                }
            }
            return form1099OID;
        }

        #endregion

    }
}
