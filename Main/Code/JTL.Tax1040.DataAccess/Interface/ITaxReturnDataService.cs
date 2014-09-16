/*
Copyright   : Copyright Jeevan Technologies
File Name   : ITaxReturnDataService.cs 
Description : Data Service Interface for TaxReturn. 
Author      : Ashok Kumar Created Date : 17 Mar 2014

 * Modification History:
---------------------
 * Saravanan N - 15th April, 2014 - 1) Added PersistSessionData().  2) Added GetSessionDataByUserIdAndUserDataId()
 *
 */


using JTL.Tax1040.BusinessObject;
namespace JTL.Tax1040.DataAccess
{
    /// <summary>
    /// Regarding ITaxReturnDataService : Methods need to be implemented in Tax Return DataService.
    /// </summary>
    public interface ITaxReturnDataService
    {
        /// <summary>
        /// Persists the tax return data.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="sessionData">The session data.</param>
        /// <param name="taxData">The tax data.</param>
        /// <param name="historyData">The history data.</param>
        /// <param name="sessionTerminate">if set to <c>true</c> [session terminate].</param>
        /// <param name="userDataId">The user data identifier.</param>
        /// <returns></returns>
        dynamic PersistTaxReturnData(long userId, string sessionData, string taxData, string historyData, long userDataId);

        /// <summary>
        /// Persist Tax1040 object.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <param name="taxData"></param>
        /// <returns></returns>
        long PersistTaxReturnData(long userId, long userDataId, string taxData);

        /// <summary>
        /// Persist Session Data.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <param name="taxData"></param>
        /// <returns></returns>
        void PersistSessionData(long userId, long userDataId, string sessionData);

        /// <summary>
        /// Gets the tax return data by user data identifier.
        /// </summary>
        /// <param name="userDataId">The user data identifier.</param>
        /// <returns></returns>
        dynamic GetTaxReturnDatabyUserDataId(long userDataId, long userId);

        /// <summary>
        /// Gets the userDataId by userId.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>The user data id.</returns>
        long GetUserDataIdByUserId(long userId);

        /// <summary>
        /// Get SessionData by UserId and UserDataId.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        string GetSessionDataByUserIdAndUserDataId(long userId, long userDataId);

        #region UserReferralAndRatting
        /// <summary>
        /// Get User Rating
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        UserRating GetUserRating(UserDTO userDTO);

        /// <summary>
        /// Persist User Rating
        /// </summary>
        /// <param name="userDTO"></param>
        void PersistUserRating(UserDTO userDTO, UserRating userRating);

        /// <summary>
        /// Persist User Referal
        /// </summary>
        /// <param name="userDTO"></param>
        /// <param name="userReferralEmail"></param>
        void PersistUserReferral(UserDTO userDTO, ReferralRating referralRating);
        #endregion
    }
}
