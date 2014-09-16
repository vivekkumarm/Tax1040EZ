/*
Copyright       : Copyright Jeevan Technologies
File Name       : ITaxesAndWrapUpRepository.cs 
Description     : Interface for Taxes And WrapUp  
Author          : Vivek
Created Date    : 28 Apr 2014

 * Modification History:
-------------------------
   27May2014 Sathish added GetTaxAndWrapupSummary method
 * 28May2014 Sathsih added Method to check taxable income is eligible for 1040EZ
 * 28May2014 Sathish added TaxableIncomeEligibilityCheck to check taxable income is eligible for 1040EZ
 */
using System.Collections.Generic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using System;
namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Interface for Taxes And WrapUp 
    /// </summary>
   public interface ITaxesAndWrapUpRepository
    {

       /// <summary>
       /// Persist Tax and wrap up
       /// </summary>
       /// <param name="userId">The User Id</param>
       /// <param name="taxReturnData">The tax return data</param>
       /// <returns>The User Id and has Hot stop</returns>
       Tuple<long, bool> PersistTaxesAndWrapUpData(long userId, TaxReturnData taxReturnData);

        /// <summary>
        /// Get Tax and Wrap up
        /// </summary>
        /// <param name="userInputData">The User Id and User Data Id</param>
        /// <returns>The Tax 1040EZ Page, Tax and Penalties and Payer Name</returns>
       System.Tuple<TaxesAndPenalties, string, DateTime> GetTaxAndWrapup(UserDTO userDTO);


       /// <summary>
       /// Get Federal Tax summary
       /// </summary>
       /// <param name="userDTO">The User DTO</param>
       /// <returns>The Tax and wrap up summary and Error Message</returns>
       Tuple<Tax1040EZPage1, List<ErrorMessage>, bool, string> GetFederalTaxSummary(UserDTO userDTO);

       /// <summary>
       /// Method to check taxable income is eligible for 1040EZ
       /// </summary>
       /// <param name="userDTO">The User DTO</param>
       /// <returns>The Tax Payer Name and Is Eligible</returns>
       //Tuple<string, bool> TaxableIncomeEligibilityCheck(UserDTO userDTO);
    }
}
