/*
Copyright    : Copyright Jeevan Technologies
File Name    : OtherIncomeController.cs 
Description  : Other Income Controller for TaxReturn
Author       : Vivek
Created Date : 7 Apr 2014

  * Modification History:
--------------------------
 * Saravanan N - 20th May, 2014 - Methods refacotred and logics moved to its Repository.
 * Vincent-22 May,2014- Maded a changes in get other income summary method. 
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

            return otherIncomeRepository.PersistOtherIncome(Utilities.ConvertToLong(taxReturn.userId.Value), taxReturnData);
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

        //Saravanan N - 20th May, 2014 - Method refactored.
        /// <summary>
        /// Get Other Income
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        [HttpPost]
        public Tuple<OtherIncome, FilingStatus> GetOtherIncome(UserDTO userDTO)
        {
            return otherIncomeRepository.GetOtherIncome(userDTO);
        }

        //Saravanan N - 20th May, 2014 - Method refactored.
        /// <summary>
        /// Get Other Income Summary
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        [HttpPost]
        public System.Tuple<OtherIncome, IEnumerable<ErrorMessage>, string, string, string, string> GetOtherIncomeSummary(dynamic userInputData)
        {
            return otherIncomeRepository.GetOtherIncomeSummary(userInputData);
        }

        #endregion
    }
}
