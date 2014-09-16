/*
Copyright   : Copyright Jeevan Technologies
File Name   : ITaxReturnDataService.cs 
Description : Business Logic for Tax Return  
Author      : Ashok Kumar
Created Date : 18 Mar 2014

 * Modification History:
---------------------
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JTL.Tax1040.BusinessLogic.Test
{
    /// <summary>
    /// Test class for Tax Return Data
    /// </summary>
    [TestClass]
    public class IC_TaxReturnRepository
    {
        ITaxReturnRepository mTaxReturnRepository;       
        IT_PersonalInfo mITPersonalInfoRepository;


        /// <summary>
        /// Classes the initialize.
        /// </summary>
        /// <param name="test">The test.</param>
        [ClassInitialize]
        public static void ClassInitialize(TestContext test)
        {

        }

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mTaxReturnRepository = new TaxReturnRepository();
         
            mITPersonalInfoRepository = new IT_PersonalInfo();
        }

        /// <summary>
        /// Persists the tax return data.
        /// </summary>
        [TestMethod]
        public void PersistTaxReturnData()
        {
            //long userDataID = mTaxReturnRepository.PersistTaxReturnData();
        }

        /// <summary>
        /// Gets the tax return databy user data identifier.
        /// </summary>
        [TestMethod]
        public void GetTaxReturnDatabyUserDataId()
        {
            Random rnd = new Random();
            long userDataID = rnd.Next(1,100);
            long userID = rnd.Next(1, 100);
            string taxData = mTaxReturnRepository.GetTaxReturnDatabyUserDataId(userDataID, userID);
            Assert.IsNotNull(taxData);
        }

        /// <summary>
        /// Tests the clean up.
        /// </summary>
        [TestCleanup]
        public void TestCleanUp()
        {
           
        }

        #region Helper Methods

        /* Commented - its on Hold... will continue once Personal info Utility is completed

        public void CreateTaxReturn()
        {
            long userId = 0;
            
            JTL.Tax1040.BusinessObject.Tax1040 tax1040 = new JTL.Tax1040.BusinessObject.Tax1040();

            tax1040.PersonalDetails = new PersonalDetails();
            tax1040.PersonalDetails.PrimaryTaxPayer = mITPersonalInfoRepository.PersistPersonalInfo(ref userId);

            CreateW2(tax1040);
            string tax1040Json = JsonConvert.SerializeObject(tax1040);
            XmlSerializer xmlserializer = new XmlSerializer(typeof(JTL.Tax1040.BusinessObject.Tax1040));
            StringWriter stringWriter = new StringWriter();
            XmlWriter writer = XmlWriter.Create(stringWriter);
            xmlserializer.Serialize(writer, tax1040);
            string serializedXml = stringWriter.ToString();
            
            string sessionData = serializedXml;
            string taxData = serializedXml;
            string historyData = serializedXml;
            long userDataId = 0;

            mTaxReturnRepository.PersistTaxReturnData(userId, sessionData, taxData, historyData, userDataId);
        }

        public JTL.Tax1040.BusinessObject.Tax1040 CreateW2(JTL.Tax1040.BusinessObject.Tax1040 tax1040)
        {
            tax1040.Income = new Income();
            tax1040.Income.W2Wages = new List<W2>();

            var w21 = new W2();
            var w22 = new W2();
            var w23 = new W2();

            w21.WagesAmount = 10000.00;           
            w21.FederalTaxWithholdingAmount = 50.00;
            w21.SocialSecurityWagesAmount = 60.00;
            w21.SocialSecurityTaxWithholdingAmount = 39.00;
            w21.MedicareTaxWithholdingAmount = 80.00;
            w21.AllocatedTipsAmount = 50.00;
            w21.DependentCareBenefitsAmount = 500.00;
            w21.MedicareWagesAmount = 544.00;
            tax1040.Income.W2Wages.Add(w21);

            w22.WagesAmount = 20000.00;
            w22.FederalTaxWithholdingAmount = 100.00;
            w22.SocialSecurityWagesAmount = 120.00;
            w22.SocialSecurityTaxWithholdingAmount = 78.00;
            w22.MedicareTaxWithholdingAmount = 160.00;
            w22.AllocatedTipsAmount = 100.00;
            w22.DependentCareBenefitsAmount = 1000.00;
            w22.MedicareWagesAmount = 1088.00;
            tax1040.Income.W2Wages.Add(w22);

            w23.WagesAmount = 20000.00;
            w23.FederalTaxWithholdingAmount = 100.00;
            w23.SocialSecurityWagesAmount = 120.00;
            w23.SocialSecurityTaxWithholdingAmount = 78.00;
            w23.MedicareTaxWithholdingAmount = 160.00;
            w23.AllocatedTipsAmount = 100.00;
            w23.DependentCareBenefitsAmount = 1000.00;
            w23.MedicareWagesAmount = 1088.00;
            tax1040.Income.W2Wages.Add(w23);

            return tax1040;
        }
         */
        #endregion

    }
}
