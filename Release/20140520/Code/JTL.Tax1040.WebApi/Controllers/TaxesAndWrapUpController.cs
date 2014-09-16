/*
Copyright       : Copyright Jeevan Technologies
File Name       : TaxesAndWrapUpController.cs 
Description     : Controller for Taxes And WrapUp  
Author          : Vivek
Created Date    : 28 Apr 2014

 * Modification History:
-------------------------
 * 28-Apr-2014 vivek Added the get method 
 */
using JTL.Tax1040.Core.Object;
using System.Collections.Generic;
using System.Web.Http;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;
using System;
using Newtonsoft.Json;

namespace JTL.Tax1040.WebApi.Controllers
{
    public class TaxesAndWrapUpController : ApiController
    {
        static readonly ITaxReturnRepository userRepository = new TaxReturnRepository();
        static readonly ITaxesAndWrapUpRepository taxAndWrapUpRepository = new TaxesAndWrapUpRepository();

        #region Persist Method 
        /// <summary>
        /// Taxes And Wrap Up Method for Persist
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        [HttpPost]
        public dynamic PersistTaxesAndWrapUpData(dynamic userInputData)
        {

             TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(userInputData.TaxReturnData.ToString());
             return taxAndWrapUpRepository.PersistTaxesAndWrapUpData( Utilities.ConvertToLong( userInputData.userId.Value), taxReturnData);
        }
        #endregion

        #region Get Method

        /// <summary>
        /// Get Tax and Wrap up
        /// </summary>
        /// <param name="userInputData">The User Id and User Data Id</param>
        /// <returns>The Tax 1040EZ Page, Tax and Penalties and Payer Name</returns>
        [HttpPost]
        public System.Tuple<Tax1040EZPage1, TaxesAndPenalties, string> GetTaxAndWrapup(dynamic userInputData)
        {
          return taxAndWrapUpRepository.GetTaxAndWrapup(Utilities.ConvertToLong(userInputData.userId), 
                                                                        Utilities.ConvertToLong(userInputData.userDataId.Value));
        }
        #endregion

    }
}
