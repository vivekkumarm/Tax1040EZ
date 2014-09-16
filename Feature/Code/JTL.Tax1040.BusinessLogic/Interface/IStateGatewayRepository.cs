/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : IStateGatewayRepository.cs
Description                 : State repository
Author                      : Swapnesh.P
Created Date                : 20 March 2014
 
Modification History:
---------------------
 * 24July2014 Ashok Kumar added method to retrieve only the supporting states of Tax1040product
*/

using JTL.Tax1040.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Interface methods for StateGateway.
    /// </summary>
    public interface IStateGatewayRepository
    {
        //25Jul2014 Sathish Changed BO name from Filing state to filer state
        //08Aug2014 Sathish return user data id after persist
        long PersisttaxableState(List<FilerState> taxableState, long userId, long userDataId);


        /// <summary>
        /// Persists the resident type confirmation.
        /// </summary>
        /// <param name="residentTypeconfirmation">The resident typeconfirmation.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="userDataId">The user data id.</param>
        /// <returns></returns>
        long PersistResidentTypeConfirmation(FilerState residentTypeconfirmation, long userId, long userDataId);

        /// <summary>
        /// Gets the Address and resident by UserId and UserDataId.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        dynamic GetAddressByUserIdAndUserDataId(long userId, long userDataId);

        /// <summary>
        /// Get All Supporting State
        /// </summary>
        /// <returns></returns>
        List<State> GetAllSupportingState();

    }
}
