/*
Copyright    : Copyright Jeevan Technologies
File Name    : IW2Repository.cs 
Description  : Business Logic Interface for W2 tax return 
Author       : Bala 
Created Date : 23 Apr 2014

 * Modification History:
------------------------
 * Saravanan N - 29th Apr, 2014 - BusinessValidation no need to delcare here, hence removed from here.
 * 28Apr2014 Sathish Added TaxReturnData for PersistW2Data 
 * 13th May, 2014 - Saravanan N - GetEmployeeCode(), GetW2OtherCode added.
 */
using System;
using JTL.Tax1040.Core.Object;
using System.Collections.Generic;
using JTL.Tax1040.BusinessObject;

namespace JTL.Tax1040.BusinessLogic
{
    public interface IW2Repository
    {
        /// <summary>
        /// Delete and then Persist W2.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="sessionData"></param>
        /// <param name="w2Id"></param>
        /// <param name="historyData"></param>
        /// <param name="userDataId"></param>
        /// <param name="errorMessageList"></param>
        void DeleteAndPersistW2(UserDTO userDTO, Tax1040.BusinessObject.Tax1040 refTaxObject = null);

        /// <summary>
        /// Get the W2 list
        /// </summary>
        /// <param name="userDataId">The user data id.</param>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        List<JTL.Tax1040.BusinessObject.W2> GetTaxReturnW2List(UserDTO userDTO);

        /// <summary>
        /// Get the W2 data.
        /// </summary>
        /// <param name="userDataId">The user data id.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="w2Id">The w2 id.</param>
        /// <returns></returns>
        Tuple<JTL.Tax1040.BusinessObject.W2, dynamic> GetW2Data(UserDTO userDTO);

        /// <summary>
        /// Get the W2 list, corresponding error list and Taxpayer and spouse name.
        /// </summary>
        /// <param name="userDataId">The user data id.</param>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        System.Tuple<List<W2>, IEnumerable<ErrorMessage>, dynamic> GetW2ListandErrorList(UserDTO userDTO);

        /// <summary>
        /// Persists the W2 tax return data.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="sessionData">The session data.</param>
        /// <param name="taxData">The tax data.</param>
        /// <param name="historyData">The history data.</param>
        /// <param name="userDataId">The user data identifier.</param>
        /// <param name="errorMessageList">The error message list.</param>
        /// <returns></returns>
        dynamic PersistW2TaxReturnData(long userId, TaxReturnData taxReturnData);

        
    }
}
