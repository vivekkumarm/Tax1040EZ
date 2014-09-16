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
        public System.Tuple<double, double, double, double> GetIncomeSummary(dynamic userInputData)
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
        public List<ErrorMessage> GetEligibilityDiagnosticsErrorList(dynamic userInputData)
        {

            List<ErrorMessage> taxObjectErrorList = null;
            JTL.Tax1040.BusinessObject.Tax1040 tax1040Object = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.UserId.Value,userInputData.UserDataId.Value);

            if (tax1040Object != null && tax1040Object.ErrorMessages != null)
            {
                string topic = userInputData.Topic;
                taxObjectErrorList = tax1040Object.ErrorMessages.FindAll(em => em.ErrorCode.StartsWith(topic.Trim() + "_ER"));
            }

            return taxObjectErrorList;
        }

        #endregion



    }
}
