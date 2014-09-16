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
             List<FilingState> lsttaxablestate = JsonConvert.DeserializeObject<List<FilingState>>(taxablestate.TaxableState.ToString());

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

    }
}