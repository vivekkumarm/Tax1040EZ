/*
Copyright   : Copyright Jeevan Technologies
File Name   : IncomeGatewayController.cs 
Description : Controller methods for Income Gateway
Author      : Saravanan N.
Created Date : 16th April, 2014.

 * Modification History:
-------------------------
  * 28Apr2014 Sathish chnaged PersistIncomeGateway method to return user data id
  * 29May2014 Ashok Kumar changed return type from Tuple to IncomeDTO for PersistIncomeGateway
 */

using System;
using System.Web.Http;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.WebApi.Security;
using JTL.Tax1040.BusinessObject;

namespace JTL.Tax1040.WebApi.Controllers
{
    /// <summary>
    /// Contains controller methods for Income Gateway.
    /// </summary>
    public class IncomeGatewayController : ApiController
    {
        #region Private Local variables.
        private readonly IIncomeGatewayRepository incomeGatewayRepository;
        private long userId;
        private long userDataId;
        #endregion

        #region Constructor
        public IncomeGatewayController()
        {
            incomeGatewayRepository = new IncomeGatewayRepository();
        }
        #endregion

        #region Get and Persist Methods
        /// <summary>
        /// Get IncomeGateway check box status from TaxObject.
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IncomeDTO GetIncomeGatewayData(dynamic userData)
        {
            //Extract UI input value.
            ExtractUserData(userData);

            //Call Repository method and return the value.
            return incomeGatewayRepository.GetIncomeGatewayData(userId, userDataId);
        }

        /// <summary>
        /// Persist IncomeGateway check box status into TaxObject.
        /// </summary>
        /// <param name="userData"></param>
        [HttpPost]
        public long PersistIncomeGateway(dynamic userData)
        {
            bool hasW2 = false, hasInterestIncome = false, hasUnemployment = false, hasOtherIncome = false;

            //Extract UI input value.
            ExtractUserData(userData);

            hasW2 = userData.hasW2;
            hasInterestIncome = userData.hasInterestIncome;
            hasUnemployment = userData.hasUnemployment;
            hasOtherIncome = userData.hasOtherIncome;
            //Extract checkbox status.
            //bool.TryParse(userData.hasW2, out hasW2);
            //bool.TryParse(userData.hasInterestIncome, out hasInterestIncome);
            //bool.TryParse(userData.hasUnemployment, out hasUnemployment);
            //bool.TryParse(userData.hasOtherIncome, out hasOtherIncome);

            return   incomeGatewayRepository.PersistIncomeGateway(userId, userDataId, new Tuple<bool, bool, bool, bool>(hasW2, hasInterestIncome, hasUnemployment, hasOtherIncome));
        }
        #endregion

        #region Common Local Methods
        /// <summary>
        /// Extract UI input value.
        /// </summary>
        /// <param name="userData"></param>
        private void ExtractUserData(dynamic userData)
        {
            userId = 0;
            long.TryParse(userData.userId.ToString(), out userId);

            userDataId = 0;
            long.TryParse(userData.userDataId.ToString(), out userDataId);
        }
        #endregion

    }
}
