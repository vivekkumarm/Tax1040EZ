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
 */
using System.Web.Http;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Process;
using Newtonsoft.Json;
using JTL.Tax1040.Core.Object;
using System.Collections.Generic;

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
        [HttpPost]
        public System.Tuple<string, PersonalDetails, IRSTransmission,Filing,bool> GetPersonAndIRSTransmission(dynamic UserInputData)
        {
            return eFileRepository.GetPersonAndIRSTransmission(Utilities.ConvertToLong(UserInputData.UserId.Value),
                                                 Utilities.ConvertToLong(UserInputData.UserDataId.Value));
        }

        [HttpPost]
        public Filing GetFiling(dynamic UserInputData)
        {
            //return eFileRepository.GetIRSTranmission(Utilities.ConvertToLong(UserInputData.UserId.Value),
                                                //Utilities.ConvertToLong(UserInputData.UserDataId.Value));

            return eFileRepository.GetFiling(Utilities.ConvertToLong(UserInputData.UserId.Value),
                                                Utilities.ConvertToLong(UserInputData.UserDataId.Value));
        }

        /// <summary>
        /// Persist Method for the IRS Transmission
        /// </summary>
        /// <param name="UserInputDate"></param>
        /// <returns></returns>
        ///  vivek 2-july-2014 persist method for the irs transmission 
        [HttpPost]
        public dynamic PersistIRSTranmission(dynamic UserInputDate)
        {
            TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(UserInputDate.TaxReturnData.ToString());
            return eFileRepository.PersistIRSTranmission(Utilities.ConvertToLong(UserInputDate.userId), taxReturnData);
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
        public System.Tuple<double, IRS,Filing> GetIRSPaymentOption(UserDTO UserData)
        {
            return eFileRepository.GetIRSPaymentOption(UserData);
        }

        /// <summary>
        /// Gets the filing option summary.
        /// </summary>
        /// <param name="UserData">The user data.</param>
        /// <returns></returns>
        [HttpPost]
        public Filing GetFilingOptionSummary(UserDTO UserData)
        {
            return eFileRepository.GetFilingOptionSummary(UserData);
        }
        /// <summary>
        /// Persist Method for the IRS Transmission
        /// </summary>
        /// <param name="UserInputDate"></param>
        /// <returns></returns>
        ///  vivek 2-july-2014 persist method for the irs transmission 
        [HttpPost]
        public dynamic PersistFiling(dynamic UserInputDate)
        {
            TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(UserInputDate.TaxReturnData.ToString());
            return eFileRepository.PersistFiling(Utilities.ConvertToLong(UserInputDate.userId), taxReturnData);
        }

        [HttpPost]
        public dynamic EMail(dynamic UserInputDate)
        {
            //TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(UserInputDate.TaxReturnData.ToString());
            return eFileRepository.SendEMail(Utilities.ConvertToLong(UserInputDate.UserId), Utilities.ConvertToLong(UserInputDate.UserDataId));
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

        [HttpPost]
        public Filing GetEFileDetails(UserDTO UserData)
        {
            return eFileRepository.GetEFileDetails(UserData);
        }
    }
}
