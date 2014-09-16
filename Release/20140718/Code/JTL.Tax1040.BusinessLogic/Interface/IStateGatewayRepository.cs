/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : IStateGatewayRepository.cs
Description                 : State repository
Author                      : Swapnesh.P
Created Date                : 20 March 2014
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
        void PersisttaxableState(List<FilingState> taxableState, long userId, long userDataId);

        /// <summary>
        /// Gets the Address and resident by UserId and UserDataId.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        dynamic GetAddressByUserIdAndUserDataId(long userId, long userDataId);
    }
}
