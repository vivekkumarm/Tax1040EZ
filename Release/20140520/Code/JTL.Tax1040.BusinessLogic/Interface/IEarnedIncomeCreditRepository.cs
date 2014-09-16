
/*
Copyright   : Copyright Jeevan Technologies
File Name   : IEarnedIncomeCreditRepository.cs 
Description : Earned Income credit  
Author      : Sathish 
Created Date : 21Apr2014

 * Modification History:
------------------------
 * 23Apr2014 Sathish Changed dynamic to long in return type for PersitEarnedIncomeCredit
 * 23Apr2014 Sathish Added new method to Get Credit Summary
* 02May2014 Sathish Used TaxReturnData for persist
 */

using System.Collections.Generic;
using JTL.Tax1040.Core.Object;
using System;
using JTL.Tax1040.BusinessObject;

namespace JTL.Tax1040.BusinessLogic
{

    public interface IEarnedIncomeCreditRepository
    {
        /// <summary>
        /// Get Payer name and  Earned Income Credit by User Id and User Data Id
        /// </summary>
        /// <param name="userDataId">The user data identifier.</param>
        /// <param name="userId">The user identifier.</param>
        /// <returns>The Payer Name and Earned Income Credit </returns>
        Tuple<EIC, string, bool> GetEarnedIncomeCredit(long userId, long userDataId);

        /// <summary>
        /// Persit Earned Income Credit
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <param name="eicData">The EIC Data</param>
        /// <returns>The User Data Id</returns>
        long PersitEarnedIncomeCredit(long userId, TaxReturnData taxReturnData);

        /// <summary>
        /// Get EIC Worksheet from work flow
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns>The EIC Worksheet Value</returns>
        dynamic GetCreditSummary(long userId, long userDataId);
    }
}
