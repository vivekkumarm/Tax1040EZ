/*
Copyright   : Copyright Jeevan Technologies
File Name   : IInterestIncomeRepository.cs 
Description : Business Logic Interface for Interest Income (1099INT/1099OID)
Author      : Vincent
Created Date : 31 Mar 2014

 * Modification History:
------------------------
 * 10 Apr 14 Vincent Added Interface for DeleteAndPersist1099INT and DeleteAndPersist1099OID
 * 17Apr2014 Sathish - DeleteAndPersist1099OID changed int to long in parameter for FormOIDId
 * 02May2014 Sathish Added TaxReturnData for PersistTaxReturnForm1099INTData
 * Saravanan N - 9th May, 2014 - Methods moved from Controller for refactoring. GetTaxReturn1099INTData, GetTaxReturn1099INTListandErrorList, 
 * Saravanan N - 9th May, 2014 - GetTaxReturnInterestIncomeEligibilityData(), DeleteAndPersist1099OID methods param changed to UserDTO
 * */

using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using System;
using System.Collections.Generic;

namespace JTL.Tax1040.BusinessLogic
{
   
    public interface IInterestIncomeRepository
    {
        /// <summary>
        /// Returns INT Data
        /// </summary>
        /// <returns></returns>
        Form1099INT GetTaxReturn1099INTData(UserDTO userDTO);

        /// <summary>
        /// Returns List of INT and ErrorMessages.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        Tuple<List<Form1099INT>, List<ErrorMessage>> GetTaxReturn1099INTListandErrorList(UserDTO userDTO);

        /// <summary>
        /// Returns OID data by FormID.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        Form1099OID GetTaxReturn1099OIDData(UserDTO userDTO);

        /// <summary>
        /// Returns All OID with Error List.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        System.Tuple<List<Form1099OID>, List<ErrorMessage>> GetTaxReturn1099OIDListandErrorList(UserDTO userDTO);

        /// <summary>
        /// Persists the tax return data.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="sessionData">The session data.</param>
        /// <param name="?">The ?.</param>
        /// <returns></returns>
        dynamic PersistTaxReturnForm1099INTData(long userId, TaxReturnData taxReturnData);

        /// <summary>
        /// Persists the tax return form1099 oid data.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="sessionData">The session data.</param>
        /// <param name="F1099OIDData">The F1099 oid data.</param>
        /// <param name="historyData">The history data.</param>
        /// <param name="userDataId">The user data identifier.</param>
        /// <param name="errorMessageList">The error message list.</param>
        /// <returns></returns>
        dynamic PersistTaxReturnForm1099OIDData(long userId, TaxReturnData taxReturnData);

        /// <summary>
        /// Persists the InterestIncomeEligibility data.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="sessionData">The session data.</param>
        /// <param name="intIncomeEligibilityData">The Interest Income Eligibility data.</param>
        /// <param name="historyData">The history data.</param>
        /// <param name="userDataId">The user data identifier.</param>
        /// <param name="errorMessageList">The error message list.</param>
        /// <returns></returns>
        dynamic PersistInterestIncomeEligibilityData(long userId, string sessionData, string intIncomeEligibilityData, string historyData, long userDataId, out List<ErrorMessage> errorMessageList);

        /// <summary>
        /// Get the InterestIncome Eligibility data.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="userDataId">The user data identifier.</param>
        /// <returns></returns>
        InterestIncomeEligibility GetTaxReturnInterestIncomeEligibilityData(UserDTO userDTO);

        /// <summary>
        /// Deletes the and persist1099 int.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="sessionData">The session data.</param>
        /// <param name="form1099INTId">The form1099 int identifier.</param>
        /// <param name="historyData">The history data.</param>
        /// <param name="userDataId">The user data identifier.</param>
        /// <param name="errorMessageList">The error message list.</param>
        void DeleteAndPersist1099INT(UserDTO userDTO);

        /// <summary>
        /// Deletes the and persist1099 oid.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="sessionData">The session data.</param>
        /// <param name="form1099OIDId">The form1099 oid identifier.</param>
        /// <param name="historyData">The history data.</param>
        /// <param name="userDataId">The user data identifier.</param>
        /// <param name="errorMessageList">The error message list.</param>
        void DeleteAndPersist1099OID(UserDTO userDTO);

    }
}
