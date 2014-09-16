/*
Copyright   : Copyright Jeevan Technologies
File Name   : DeductionController.cs 
Description : Standard Deduction
Author      : Sathish
Created Date : 21Apr2014

 * Modification History:
---------------------
 */

using System.Web.Http;
using JTL.Tax1040.BusinessLogic;

namespace JTL.Tax1040.WebApi.Controllers
{
    public class DeductionController : ApiController
    {
        #region Get

        static readonly IDeductionRepository deductionRepository = new DeductionRepository();

        /// <summary>
        ///  Get Person First Name or Nick Name and Total Worksheet Standard Deduction By User Id and User Data Id
        /// </summary>
        /// <param name="userInputData">UserId and UserDataId</param>
        /// <returns></returns>
        [HttpPost]
        public dynamic GetDeductionSummary(dynamic userInputData)
        {
            return deductionRepository.GetDeductionSummary(userInputData.UserId.Value, userInputData.UserDataId.Value);
        }

        #endregion


    }
}
