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

        System.Tuple<string, PersonalDetails, IRSTransmission, Filing, bool> GetPersonAndIRSTransmission(long userId, long userDataId);
        //IRSTransmission GetIRSTranmission(long userId, long userDataId);

        Filing GetFiling(long userId, long userDataId);

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
        System.Tuple<double, IRS,Filing> GetIRSPaymentOption(UserDTO userDTO);

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
        Filing GetFilingOptionSummary(UserDTO userDTO);

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

        Filing GetEFileDetails(UserDTO UserData);
    }
}
