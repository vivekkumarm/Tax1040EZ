/*
Copyright       : Copyright Jeevan Technologies
File Name       : ITaxesAndWrapUpRepository.cs 
Description     : Interface for Taxes And WrapUp  
Author          : Vivek
Created Date    : 28 Apr 2014

 * Modification History:
-------------------------
   
 */
using System.Collections.Generic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Interface for Taxes And WrapUp 
    /// </summary>
   public interface ITaxesAndWrapUpRepository
    {
       /// <summary>
       /// Interface for Persist Method
       /// </summary>
       /// <param name="userId"></param>
       /// <param name="sessionData"></param>
       /// <param name="taxAndWrapUpData"></param>
       /// <param name="historyData"></param>
       /// <param name="userDataId"></param>
       /// <param name="errorMessages"></param>
       /// <returns></returns>
       dynamic PersistTaxesAndWrapUpData(long userId, TaxReturnData taxReturnData);

        /// <summary>
        /// Get Tax and Wrap up
        /// </summary>
        /// <param name="userInputData">The User Id and User Data Id</param>
        /// <returns>The Tax 1040EZ Page, Tax and Penalties and Payer Name</returns>
        System.Tuple<Tax1040EZPage1, TaxesAndPenalties, string> GetTaxAndWrapup(long userId, long userDataId);
    }
}
