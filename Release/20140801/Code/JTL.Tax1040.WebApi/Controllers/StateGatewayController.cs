/*
 
Modification History:
---------------------
 * 24July2014 Ashok Kumar added method to retrieve only the supporting states of Tax1040product

 */

using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Http;

namespace JTL.Tax1040.WebApi.Controllers
{
    public class StateGatewayController : ApiController
    {
        #region Local variable declaration
        private readonly IStateGatewayRepository stateGatewayRepository = new StateGatewayRepository();
        #endregion
        /// <summary>
        /// Persist State
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public void PersisttaxableState(dynamic taxablestate)
        {
            List<FilerState> lsttaxablestate = JsonConvert.DeserializeObject<List<FilerState>>(taxablestate.TaxableState.ToString());

            stateGatewayRepository.PersisttaxableState(lsttaxablestate, Utilities.ConvertToLong(taxablestate.userId.Value), Utilities.ConvertToLong(taxablestate.UserDataId.Value));
        }

        /// <summary>
        /// Get State related Information
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public dynamic GetAddressByUserIdAndUserDataId(UserDTO user)
        {
            return stateGatewayRepository.GetAddressByUserIdAndUserDataId(user.UserId, user.UserDataId);
        }

        [HttpGet]
        public List<State> GetAllSupportingState()
        {
            return stateGatewayRepository.GetAllSupportingState();
        }


    }
}