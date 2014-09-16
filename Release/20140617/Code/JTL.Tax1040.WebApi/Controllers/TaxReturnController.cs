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
            Dictionary<string,int>  eligibilityErrorCountBasedOnTab = null;
            List<ErrorMessage> eligibilityErrorList = null;
            JTL.Tax1040.BusinessObject.Tax1040 tax1040Object = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.UserId.Value,userInputData.UserDataId.Value);

            if (tax1040Object != null && tax1040Object.ErrorMessages != null)
            {
                //string topic = userInputData.Topic;
                //taxObjectErrorList = tax1040Object.ErrorMessages.FindAll(em => em.ErrorCode.StartsWith(topic.Trim() + "_ER"));
                string topic = userInputData.Topic;
                string tab = userInputData.Tab;
                if (!string.IsNullOrEmpty(topic))
                {
                    taxObjectErrorList = tax1040Object.ErrorMessages.FindAll(em => (em.Topic == topic) && (em.MessageType == "ER"));
                }
                else if (!string.IsNullOrEmpty(tab))
                {
                    taxObjectErrorList = tax1040Object.ErrorMessages.FindAll(em => (em.Tab == tab) && (em.MessageType == "ER"));
                }
                if (tax1040Object.PersonalDetails != null && tax1040Object.PersonalDetails.PrimaryTaxPayer !=null && tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus != FilingStatus.MarriedFilingJointly)
                {
                    topic = "Spouse";
                    if (taxObjectErrorList != null)
                    {
                        taxObjectErrorList.RemoveAll(em => em.ErrorCode.StartsWith(topic.Trim() + "_ER"));
                    }
                }

                // 06Jun2014 Sathish returns elgibility error count for each tab used to disable breadcrum menu
                eligibilityErrorList = tax1040Object.ErrorMessages.FindAll(em => em.MessageType.Equals("ER"));
                if (eligibilityErrorList != null)
                {
                     eligibilityErrorCountBasedOnTab = new Dictionary<string,int>();
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

            return new System.Tuple<List<ErrorMessage>, List<ErrorMessage>, Dictionary<string, int>>(tax1040Object.ErrorMessages, 
                                                                                                        taxObjectErrorList, 
                                                                                                        eligibilityErrorCountBasedOnTab);
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
        public HttpResponseMessage GetWorksheet(long userId,long userDataId,string worksheetName)

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

    }
}
