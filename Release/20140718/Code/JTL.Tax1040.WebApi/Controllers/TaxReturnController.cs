/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : TaxReturnController.cs
Description                 : Tax Return Controller.
Author                      : Saravanan N
Created Date                : 14th April, 2014
 
Modification History:
---------------------
 * 28 Apr 2014 - Vincent-Added GetIncomeandErrorList method for income summary
 * 30 Apr 2014 - Vincent-Made a changes to GetIncomeandErrorList method for income summary
 * 30 Apr 2014 - Bala, Added Cmmn method to get Eligibility Diagnostics ErrorList.
 * 28 May 2014 - Ashok Kumar modified GetEligibilityDiagnosticsErrorList to return Error in 2 list. 
 * 06Jun2014 Sathish returns elgibility error count for each tab used to disable breadcrum menu
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using System.IO;

namespace JTL.Tax1040.WebApi.Controllers
{
    /// <summary>
    /// Controller contains Tax Object related methods.
    /// </summary>
    public class TaxReturnController : ApiController
    {
        #region Private variables
        private readonly ITaxReturnRepository taxReturnRepository;
        #endregion

        #region Constructor
        public TaxReturnController()
        {
            taxReturnRepository = new TaxReturnRepository();
        }
        #endregion


        #region Controller Methods
        //Persist Session Data into Tax Object
        [HttpPost]
        public void PersistSessionData(dynamic userData)
        {
            long userId = 0;
            long.TryParse(userData.userId.ToString(), out userId);

            long userDataId = 0;
            long.TryParse(userData.userDataId.ToString(), out userDataId);

            string sessionData = userData.lastVisitedUrl.ToString();

            taxReturnRepository.PersistSessionData(userId, userDataId, sessionData);
        }
        #endregion


        #region Get Income

        [HttpPost]
        // 18Jun2014 Sathish Return returned selected income to show or hide 
        public System.Tuple<double, double, double, double, string, System.Tuple<bool, bool, bool, bool>> GetIncomeSummary(dynamic userInputData)
        {
            long userDataId = 0;
            long.TryParse(userInputData.UserDataId.ToString(), out userDataId);

            long userId = 0;
            long.TryParse(userInputData.UserId.ToString(), out userId);

            return taxReturnRepository.GetIncomeSummary(userId, userDataId);
        }


        #endregion


        #region Get Eligibility Diagnostics
        [HttpPost]
        public dynamic GetEligibilityDiagnosticsErrorList(dynamic userInputData)
        {

            List<ErrorMessage> taxObjectErrorList = null;
            // 06Jun2014 Sathish added eligibilityErrorCountBasedOnTab to get eligibility error count for menu
            Dictionary<string, int> eligibilityErrorCountBasedOnTab = null;
            List<ErrorMessage> eligibilityErrorList = null;

            //Saravanan N - 26th June, 2014 - User didn't have userDataId then to avoid error this condition added.
            if (userInputData.UserDataId == null)
            {
                userInputData.UserDataId = 0;
            }

            JTL.Tax1040.BusinessObject.Tax1040 tax1040Object = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.UserId.Value, userInputData.UserDataId.Value);

            if (tax1040Object != null && tax1040Object.ErrorMessages != null)
            {
                //string topic = userInputData.Topic;
                //taxObjectErrorList = tax1040Object.ErrorMessages.FindAll(em => em.ErrorCode.StartsWith(topic.Trim() + "_ER"));
                string topic = userInputData.Topic;
                string tab = userInputData.Tab;
                // 20Jun2014 Sathish removed hard coded value in message type and used constant
                if (!string.IsNullOrEmpty(topic))
                {
                    taxObjectErrorList = tax1040Object.ErrorMessages.FindAll(em => (em.Topic == topic) && (em.MessageType == Constants.MESSAGE_TYPE_ER));
                }
                else if (!string.IsNullOrEmpty(tab))
                {
                    taxObjectErrorList = tax1040Object.ErrorMessages.FindAll(em => (em.Tab == tab) && (em.MessageType == Constants.MESSAGE_TYPE_ER));
                }
                if (tax1040Object.PersonalDetails != null && tax1040Object.PersonalDetails.PrimaryTaxPayer != null && tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus != FilingStatus.MarriedFilingJointly)
                {
                    topic = "Spouse";
                    if (taxObjectErrorList != null)
                    {
                        taxObjectErrorList.RemoveAll(em => em.ErrorCode.StartsWith(topic.Trim() + "_" + Constants.MESSAGE_TYPE_ER));
                    }
                }

                if (taxObjectErrorList != null)
                {
                    taxObjectErrorList.RemoveAll(em => em.Topic.StartsWith(Constants.TOPIC_EFILE));
                }
                tax1040Object.ErrorMessages.RemoveAll((em => em.Topic.StartsWith(Constants.TOPIC_EFILE)));


                // 06Jun2014 Sathish returns elgibility error count for each tab used to disable breadcrum menu
                eligibilityErrorList = tax1040Object.ErrorMessages.FindAll(em => em.MessageType.Equals(Constants.MESSAGE_TYPE_ER));
                if (eligibilityErrorList != null)
                {
                    eligibilityErrorCountBasedOnTab = new Dictionary<string, int>();
                    var eligibilityError = from em in eligibilityErrorList
                                           group em.Tab by em.Tab into g // Group error list by tab
                                           select new
                                           {
                                               Tab = g.Key, // Get tab name
                                               EligiblityErrorCount = g.ToList() // Get record count for each table
                                           };

                    // add Tab and EligiblityErrorCount in direcotryused in return
                    foreach (var em in eligibilityError)
                    {
                        eligibilityErrorCountBasedOnTab.Add(em.Tab, em.EligiblityErrorCount.Count);
                    }
                }

            }
       
          
            // 18Jul2014 Sathish created payment DTO for user data 
            PaymentDTO paymentDTO = new PaymentDTO()
            {
                UserDataId = userInputData.UserDataId.Value,
                UserId = userInputData.UserId.Value
            };

            return new System.Tuple<List<ErrorMessage>, List<ErrorMessage>, Dictionary<string, int>, bool>(tax1040Object.ErrorMessages,
                                                                                                        taxObjectErrorList,
                                                                                                        eligibilityErrorCountBasedOnTab,
                                                                                                        taxReturnRepository.IsOrderExistByUserDataId(paymentDTO)); //18Jul2014 Sathish get order exist by user data id
        }

        #endregion


        #region GetWorksheet

        /// <summary>
        /// Get the work sheet
        /// will be removed after testing
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage GetWorksheet(long userId, long userDataId, string worksheetName)
        {
            UserDTO userDTO = new UserDTO() { UserId = userId, UserDataId = userDataId };
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            var stream = new MemoryStream(taxReturnRepository.GetWorksheet(userDTO, worksheetName));
            result.Content = new StreamContent(stream);
            result.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/pdf");
            result.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment")
            {
                FileName = worksheetName + ".pdf"
            };
            //Bind Pdf controls -- Finished//
            return result;
        }

        #endregion


        /// <summary>
        /// Calculation for tax meter
        /// </summary>
        /// <param name="userId">The User Id</param>
        /// <param name="userDataId">The User Data Id</param>
        /// <returns></returns>
        [HttpPost]
        public double GetFederalSummaryDetails(UserDTO UserData)
        {
            return taxReturnRepository.GetFederalSummaryDetails(UserData);
        }

        [HttpPost]
        public JTL.Tax1040.BusinessObject.Tax1040 GetTaxSummary(UserDTO UserData)
        {
            JTL.Tax1040.BusinessObject.Tax1040 tax1040Object = Utilities.GetTaxObjectByUserIdAndUserDataId(UserData.UserId, UserData.UserDataId);
            return tax1040Object;
        }
    }
}
