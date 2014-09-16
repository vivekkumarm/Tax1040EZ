/*
Copyright    : Copyright Jeevan Technologies
File Name    : OtherIncomeController.cs 
Description  : Other Income Controller for TaxReturn
Author       : Vivek
Created Date : 7 Apr 2014

  * Modification History:
--------------------------
 */
using System;
using System.Collections.Generic;
using System.Web.Http;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using Newtonsoft.Json;

namespace JTL.Tax1040.WebApi.Controllers
{
    public class OtherIncomeController : ApiController
    {
        #region Local variable declaration
        private readonly IOtherIncomeRepository otherIncomeRepository = new OtherIncomeRepository();
        private readonly ITaxReturnRepository taxReturnRepository = new TaxReturnRepository();
        #endregion

        #region Controller Methods
        /// <summary>
        /// Persist Other Income
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public dynamic PersistOtherIncome(dynamic taxReturn)
        {
            TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(taxReturn.TaxReturnData.ToString());

            return otherIncomeRepository.PersistOtherIncome( Utilities.ConvertToLong( taxReturn.userId.Value), taxReturnData);
        }

        /// <summary>
        /// Delete Other Income
        /// </summary>
        /// <param name="userInputData"></param>
        [HttpPost]
        public void DeleteOtherIncome(dynamic userInputData)
        {
            otherIncomeRepository.DeleteAndPersistOtherIncome(Utilities.ConvertToLong(userInputData.userId.Value), 
                                                                Utilities.ConvertToLong(userInputData.userDataId),
                                                                (OtherIncomeType)Utilities.ConvertToInteger32(userInputData.otherIncomeType));
        }

        /// <summary>
        /// Get Other Income
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        [HttpPost]
        public Tuple<OtherIncome, FilingStatus> GetOtherIncome(dynamic userInputData)
        {
            FilingStatus filingStatus = FilingStatus.None;

            OtherIncome otherIncome = null;
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(Utilities.ConvertToLong(userInputData.userId.Value), 
                                                                                           Utilities.ConvertToLong(userInputData.userDataId.Value));

            if (taxObject != null)
            {
                if (taxObject.Income != null && taxObject.Income.OtherIncome != null)
                {
                    otherIncome = taxObject.Income.OtherIncome;
                }

                if (taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null)
                {
                    filingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                }
            }

            return new Tuple<OtherIncome, FilingStatus>(otherIncome, filingStatus);
        }

        /// <summary>
        /// Get Other Income Summary
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        [HttpPost]
        public System.Tuple<OtherIncome, List<ErrorMessage>, string, string, string, string> GetOtherIncomeSummary(dynamic userInputData)
        {
            string primaryFilerFirstName = "", primaryFilerLastName = "", spouseFirstName = "", spouseLastName = "";
            OtherIncome otherIncome =  null;
            List<ErrorMessage> lstErrorMessages = null;

             //Get TaxObject from Database.
            BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(Utilities.ConvertToLong(userInputData.userId.Value), Utilities.ConvertToLong(userInputData.userDataId.Value));

            if (taxObject != null)
            {
                if (taxObject.PersonalDetails != null)
                {
                    if (taxObject.PersonalDetails.PrimaryTaxPayer != null &&
                        taxObject.PersonalDetails.PrimaryTaxPayer.Person != null)
                    {
                        primaryFilerFirstName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName;
                        primaryFilerLastName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.LastName;
                    }
                    if (taxObject.PersonalDetails.Spouse != null && taxObject.PersonalDetails.Spouse.Person != null)
                    {
                        spouseFirstName = taxObject.PersonalDetails.Spouse.Person.FirstName;
                        spouseLastName = taxObject.PersonalDetails.Spouse.Person.LastName;
                    }
                }

                if (taxObject.Income != null && taxObject.Income.OtherIncome != null)
                {
                    otherIncome = taxObject.Income.OtherIncome;
                }

                if (taxObject.ErrorMessages != null)
                {
                    lstErrorMessages = taxObject.ErrorMessages;
                }
            }

            return new Tuple<OtherIncome, List<ErrorMessage>, string, string ,string, string>(otherIncome,lstErrorMessages, primaryFilerFirstName, primaryFilerLastName, spouseFirstName, spouseLastName);
        }

        #endregion
    }
}
