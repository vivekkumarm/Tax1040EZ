/*
Copyright   : Copyright Jeevan Technologies
File Name   : EFileRepository.cs 
Description : EFile Repository 
Author      : Sathish 
Created Date : 13May2014

 * Modification History:
------------------------
 * vivek 2-july-2014 persist method for the irs transmission 
 * Vincent 3July2014  Added Persist & get method for IRS Payment option.
 * Vincent 3July2014  Added GetFilingOptionSummary.
 * Vincent 11July2014 Added Business validation for IRS Tranmission.
 * Sathish 25Jul2014 Sathish changed controller based on the new BO
 */

using System.Linq;
using System.Web.Http;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;
using Newtonsoft.Json;
using JTL.Tax1040.Core.Object;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System;

namespace JTL.Tax1040.WebApi.Controllers
{
    public class EFileController : ApiController
    {
        #region Local variables
        static readonly IEFileRepository eFileRepository = new EFileRepository();
        #endregion

        /// <summary>
        /// Get the Person Detials
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns></returns>
        /// //Vincent-10JULY 2014 - Made a changes tuple method added a filing class. 
        /// //Vincent-11July2014-Added a Bool value which was missing
        ///   //25Jul2014 Sathish return only filling because filling will have IRS Transmission
        [HttpPost]
        public System.Tuple<string, PersonalDetails, Filing, bool> GetPersonAndIRSTransmission(UserDTO userDTO)
        {
            return eFileRepository.GetPersonAndIRSTransmission(userDTO);
        }


        /// <summary>
        /// Persists the IRS tranmission.
        /// </summary>
        /// <param name="UserData">The user input data.</param>
        /// <returns></returns>
        [HttpPost]
        public Tuple<long, List<ErrorMessage>, long> PersistIRSTransmission(dynamic UserData)
        {
            EfileErrorCollection efileerrorcollection = new EfileErrorCollection();

            TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(UserData.TaxReturnData.ToString());

            Tuple<BusinessObject.Tax1040, string, List<ErrorMessage>> encryptedTaxObject = eFileRepository.PersistIRSTransmissionBeforeEfile(Utilities.ConvertToLong(UserData.userId), taxReturnData);


            if (encryptedTaxObject.Item3.Count == 0 && (encryptedTaxObject.Item1.Filing.FederalFiling.IsEfile.HasValue && encryptedTaxObject.Item1.Filing.FederalFiling.IsEfile.Value))
            {
                try
                {
                    // Efile Service Call by sending Encrypted tax object
                    EfileTransmitService.ReceivingService service = new EfileTransmitService.ReceivingService();
                    var efileErrorList = service.ReceiveService(encryptedTaxObject.Item2, false);


                    efileerrorcollection.AddRange(
                        efileErrorList.Select(errorEessage => new ErrorMessage { ErrorCode = errorEessage.ErrorCode }));
                }

                catch (Exception)
                {

                }
            }

            long userDataid = eFileRepository.PersistIRSTransmissionEfile(Utilities.ConvertToLong(UserData.userId), encryptedTaxObject.Item1, efileerrorcollection);

            return new Tuple<long, List<ErrorMessage>, long>(userDataid, encryptedTaxObject.Item3, efileerrorcollection.Count);
        }

        /// <summary>
        /// Geting efile Service Error Messages
        /// </summary>
        /// <param name="UserData"></param>
        /// <returns></returns>
        /// vivek 15-july-14 Geting efile Error Messages
        [HttpPost]
        public IEnumerable<ErrorMessage> GetEfileErrorMessage(UserDTO UserData)
        {
            return eFileRepository.GetEfileErrorMessage(UserData);
        }

        /// <summary>
        /// Persit IRS Payment Option
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="taxReturnData">The Tax Return Data</param>
        /// <returns>The User Data Id</returns>
        [HttpPost]
        public System.Tuple<long, List<ErrorMessage>> PersistIRSPaymentOption(PaymentDTO paymentDTO)
        {
            return eFileRepository.PersistIRSPaymentOption(paymentDTO);
        }

        /// <summary>
        /// Get the IRS Payment Option
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns></returns>
        [HttpPost]
        public System.Tuple<double, Filing> GetIRSPaymentOption(UserDTO UserData)
        {
            return eFileRepository.GetIRSPaymentOption(UserData);
        }

        /// <summary>
        /// Gets the filing option summary.
        /// </summary>
        /// <param name="UserData">The user data.</param>
        /// <returns></returns>
        /// //25Jul2014 Sathish return dynamic for filling and filling state
        [HttpPost]
        public dynamic GetFilingOptionSummary(UserDTO UserData)
        {
            return eFileRepository.GetFilingOptionSummary(UserData);
        }
        /// <summary>
        /// Persist Method for the IRS Transmission
        /// </summary>
        /// <param name="UserData"></param>
        /// <returns></returns>
        ///  vivek 2-july-2014 persist method for the irs transmission 
        [HttpPost]
        public dynamic PersistFiling(dynamic UserData)
        {
            TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(UserData.TaxReturnData.ToString());
            return eFileRepository.PersistFiling(Utilities.ConvertToLong(UserData.userId), taxReturnData);
        }

        [HttpPost]
        public dynamic EMail(dynamic UserData)
        {
            //TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(UserInputDate.TaxReturnData.ToString());
            return eFileRepository.SendEMail(Utilities.ConvertToLong(UserData.UserId), Utilities.ConvertToLong(UserData.UserDataId));
        }
        /// <summary>
        /// Geting efile Error Messages
        /// </summary>
        /// <param name="UserData"></param>
        /// <returns></returns>
        /// vivek 15-july-14 Geting efile Error Messages
        [HttpPost]
        public IEnumerable<ErrorMessage> GetErrorMessage(UserDTO UserData)
        {
            return eFileRepository.GetErrorMessage(UserData);
        }
        /// <summary>
        /// Delete Functionality
        /// </summary>
        /// <param name="UserData"></param>
        /// <returns></returns>
        /// vivek 15-July-14 for the delete Functionality
        [HttpPost]
        public bool DeleteEfileInformation(UserDTO UserData)
        {
            return eFileRepository.DeleteEfileInformation(UserData);
        }

        /// <summary>
        /// Delete transmission detail
        /// </summary>
        /// <param name="UserData">The User DTO</param>
        /// <returns>The Status</returns>
        /// 05Aug2014 Sathish delete the IRS Transmission detail
        [HttpPost]
        public bool DeleteIRSTransmissionDetail(UserDTO UserData)
        {
            return eFileRepository.DeleteIRSTransmissionDetail(UserData);
        }

        [HttpPost]
        public dynamic GetEFilingOption(UserDTO UserData)
        {
            return eFileRepository.GetEFilingOption(UserData);
        }

        /// <summary>
        /// Get IRS Return Status
        /// </summary>
        /// <param name="UserData"></param>
        /// <returns></returns>
        /// 22Jul2014 Sathish Get IRS Return Status
        [HttpPost]
        public ReturnStatus GetIRSReturnStatus(UserDTO userData)
        {
            return eFileRepository.GetIRSReturnStatus(userData);
        }


        #region StateFiling
        /// <summary>
        /// Get State filing detail
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        /// 31Jul2014 Sathish Added the method to Get state filing detail
        [HttpPost]
        public System.Tuple<double, StateFiling> GetStatePaymentDetail(StateDTO stateDTO)
        {
            return eFileRepository.GetStatePaymentDetail(stateDTO);
        }

        /// <summary>
        /// Get Person and State Transmission 
        /// </summary>
        /// <param name="userDTO">User Id, User Data Id and State Id</param>
        /// <returns>Person Detail and State Transmission</returns>
        /// 31Jul2014 Sathish Get Person and State Transmission 
        [HttpPost]
        public System.Tuple<string, PersonalDetails, StateFiling, bool, bool> GetPersonAndStateTransmission(StateDTO stateDTO)
        {
            return eFileRepository.GetPersonAndStateTransmission(stateDTO);
        }

        /// <summary>
        /// Persist State payment detail
        /// </summary>
        /// <param name="stateDTO">The State DTO</param>
        /// <returns>The User Date Id and Payment Detail Error Message</returns>
        /// 31Jul2014  Persist State payment detail
        [HttpPost]
        public System.Tuple<long, List<ErrorMessage>> PersistStatePaymentDetail(StateDTO stateDTO)
        {
            return eFileRepository.PersistStatePaymentDetail(stateDTO);
        }

        /// <summary>
        /// Persist Sate Transmission
        /// </summary>
        /// <param name="stateDTO"></param>
        /// <returns></returns>
        /// 31Jul2014 Sathish Get Persist state transmission
        [HttpPost]
        public dynamic PersistStateTranmission(StateDTO stateDTO)
        {
            return eFileRepository.PersistStateTranmission(stateDTO);
        }

        #endregion StateFiling

    }
}
