/*
Copyright   : Copyright Jeevan Technologies
File Name   : ITaxReturnRepository.cs 
Description : Business Logic Interface for Tax Return 
Author      : Ashok Kumar 
Created Date : 17 Mar 2014

 * Modification History:
------------------------
 * Saravanan N - 1st April, 2014 - PersistTaxReturnData() formtype param type changed from int to FORMTYPE.
 * Bala - 10Apr14 - Added DeleteAndPersistW2 method to delete and persist the w2 object.
 * Saravanan N - 14th April, 2014 - PersistSesssionData method added to store Session reltaed data into TaxObject.
 * Saravanan N - 15th April, 2014 - Added GetSessionDataByUserIdAndUserDataId()
 * Bala - 23rd April, 2014 - Moved Persist,delete and get methods for W2 to IW2Repository.cs
 * 28 Apr 2014 - Vincent-Added GetIncomeandErrorList method for income summary.
 * 30 Apr 2014 - Vincent-Made changes in GetIncomeandErrorList method for income summary.
 *
 */

using JTL.Tax1040.Core.Object;
using System.Collections.Generic;
using JTL.Tax1040.BusinessObject;
using System;

namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITaxReturnRepository
    {
        /// <summary>
        /// Gets the tax return databy user data identifier.
        /// </summary>
        /// <param name="userDataId">The user data identifier.</param>
        /// <returns></returns>
        string GetTaxReturnDatabyUserDataId(long userDataId, long userId);

        /// <summary>
        /// Get SessionData By userId and UserDataId.
        /// </summary>
        /// <param name="userDTO">The user dto.</param>
        /// <returns></returns>
        string GetSessionDatabyUserIdAndUserDataId(UserDTO userDTO);

        /// <summary>
        /// Gets the userDataId by userId.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>The user data id.</returns>
        long GetUserDataIdByUserId(long userId);

        //Saravanan N - 14th April, 2014 - Newly added to store session data  into taxObject.
        /// <summary>
        /// Persist Session Data into TaxObject.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <param name="sessionData"></param>
        void PersistSessionData(long userId, long userDataId, string sessionData);

        /// <summary>
        /// Gets the incomeand error list.
        /// </summary>
        /// <param name="userDataId">The user data identifier.</param>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Tuple<double, double, double, double> GetIncomeSummary(long userId, long userDataId);
    }
}
