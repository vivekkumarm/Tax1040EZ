﻿/*
Copyright   : Copyright Jeevan Technologies
File Name   : EarnedIncomeCreditController.cs 
Description : EarnedIncomeCreditController
Author      : Sathish
Created Date : 21Apr2014

 * Modification History:
---------------------
 * 23Apr2014 Sathish Changed dynamic to long in return type for PersitEarnedIncomeCredit
 * 23Apr2014 Sathish Added new method to Get Credit Summary
 * 02May2014 Sathish Used TaxReturnData for persist
 * Thileep changed PersistEarnedIncomeCredit method on 10July2014
 * 30July2014-Thileep changed GetEarnedIncomeCredit method to Get EligiblityInformation Messages in Credit Section
 */

using System;
using System.Web.Http;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;
using Newtonsoft.Json;
using System.Collections.Generic;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.WebApi.Controllers
{
    /// <summary>
    /// Contains EIC and Credits Summary related Controller methods.
    /// </summary>
    public class EarnedIncomeCreditController : ApiController
    {
        #region Local variables
        static readonly IEarnedIncomeCreditRepository earnedIncomeCreditRepository = new EarnedIncomeCreditRepository();
        #endregion

        #region EIC controller methods
        /// <summary>
        /// Get Earned Income Credit
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        [HttpPost]
        public Tuple<EIC, string, bool, IEnumerable<ErrorMessage>,long> GetEarnedIncomeCredit(UserDTO userDTO)
        {
            return earnedIncomeCreditRepository.GetEarnedIncomeCredit(userDTO);
        }

        /// <summary>
        /// Persit EIC
        /// </summary>
        /// <param name="userInputData">The User id and User Data Id</param>
        /// <returns></returns>
        [HttpPost]
        public long PersistEarnedIncomeCredit(dynamic userInputData)
        {
            int year = userInputData.TaxReturnData.Year;
            TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(userInputData.TaxReturnData.ToString());
            return earnedIncomeCreditRepository.PersitEarnedIncomeCredit(Utilities.ConvertToLong(userInputData.UserId.Value),taxReturnData,year);
        }
        #endregion

        #region Credit Summary Methods
        /// <summary>
        /// Get Credit Summary
        /// </summary>
        /// <param name="userInputData">The User id and User Data Id</param>
        /// <returns>The EIC Work sheet value</returns>
        [HttpPost]
        public dynamic GetCreditSummary(UserDTO userDTO)
        {
            return earnedIncomeCreditRepository.GetCreditSummary(userDTO);
        }
        #endregion

    }
}
