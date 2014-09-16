/*
Copyright   : Copyright Jeevan Technologies
File Name   : IEFileRepository.cs 
Description : Interface EFile Repository 
Author      : Sathish 
Created Date : 13May2014

 * Modification History:
------------------------
 * vivek 7-july-14 added the persist method 
 * Vincent 3July2014  Added GetFilingOptionSummary & IRS Payment option method.
 * Vincent-10JULY 2014 - Made a changes tuple method added a filing class. 
 */


using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using System;
using System.Collections.Generic;
namespace JTL.Tax1040.BusinessLogic
{
    public interface IEFileRepository
    {
        /// <summary>
        /// Get the Person Detials
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns>Tax Payer Name, Personal Details and IRSTransmission</returns>
        //25Jul2014 Sathish return only filling because filling will have IRS Transmission
        Tuple<string, PersonalDetails,  Filing, bool> GetPersonAndIRSTransmission(UserDTO userDTO);

        /// <summary>
        /// Persist for IRS Transmission
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taxReturnData"></param>
        /// <returns></returns>
        dynamic PersistIRSTranmission(long userId, TaxReturnData taxReturnData);

        /// <summary>
        /// Get the IRS Payment Option
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns></returns>
        /// 25Jul2014 Sathish removed IRS in the tuple and return only filing
        System.Tuple<double, Filing> GetIRSPaymentOption(UserDTO userDTO);

        /// <summary>
        /// Persit IRS Payment Option
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="taxReturnData">The Tax Return Data</param>
        /// <returns>The User Data Id</returns>
        System.Tuple<long, List<ErrorMessage>> PersistIRSPaymentOption(PaymentDTO paymentDTO);

        /// <summary>
        /// Gets the filing option summary.
        /// </summary>
        /// <param name="userDTO">The user dto.</param>
        /// <returns></returns>
        /// 25Jul2014 Sathish return dynamic object contain filing and state filing
        dynamic GetFilingOptionSummary(UserDTO userDTO);

        /// <summary>
        /// Persist for IRS Transmission
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="taxReturnData"></param>
        /// <returns></returns>
        dynamic PersistFiling(long userId, TaxReturnData taxReturnData);

        /// <summary>
        /// send email based on the user id
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        bool SendEMail(long userId, long userDataId);
        /// <summary>
        ///  Geting efile Error Messages
        /// </summary>
        /// <param name="UserData"></param>
        /// <returns></returns>
        /// vivek 15-july-14 Geting efile Error Messages
        IEnumerable<ErrorMessage> GetErrorMessage(UserDTO UserData);

        /// <summary>
        /// Delete Efile Information
        /// </summary>
        /// <param name="UserData"></param>
        /// <returns></returns>
        /// vivek 15-July-14 Efile Deletion
        bool DeleteEfileInformation(UserDTO UserData);

        /// <summary>
        /// Gets the E file details.
        /// </summary>
        /// <param name="UserData">The user data.</param>
        /// <returns></returns>
        /// 25Jul2014 Sathish changed method name and return dynamic object which contain Filing
        dynamic GetEFilingOption(UserDTO UserData);

        /// <summary>
        /// Get IRS Return status
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        /// 22Jul2014 Sathish Added the method to Get IRS Return status
        ReturnStatus GetIRSReturnStatus(UserDTO userDTO);

        #region StateFiling
        /// <summary>
        /// Get State filing detail
        /// </summary>
        /// <param name="stateDTO"></param>
        /// <returns></returns>
        /// 31Jul2014 Sathish Added the method to Get state filing detail
        System.Tuple<double, StateFiling> GetStatePaymentDetail(StateDTO stateDTO);

        /// <summary>
        /// Get Person and State Transmission 
        /// </summary>
        /// <param name="userDTO">User Id, User Data Id and State Id</param>
        /// <returns>Person Detail and State Transmission</returns>
        /// 31Jul2014 Sathish Get Person and State Transmission 
        System.Tuple<string, PersonalDetails, StateFiling, bool,bool> GetPersonAndStateTransmission(StateDTO userDTO);

        /// <summary>
        /// Persist Sate Transmission
        /// </summary>
        /// <param name="stateDTO"></param>
        /// <returns></returns>
        /// 31Jul2014 Sathish Get Persist state transmission
        dynamic PersistStateTranmission(StateDTO stateDTO);

        /// <summary>
        /// Persist State payment detail
        /// </summary>
        /// <param name="stateDTO">The State DTO</param>
        /// <returns>The User Date Id and Payment Detail Error Message</returns>
        Tuple<long, List<ErrorMessage>> PersistStatePaymentDetail(StateDTO stateDTO);
        #endregion
    }
}
