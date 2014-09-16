/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : CAController.cs
Description                 : California state Controller.
Author                      : Bala
Created Date                : 03-Sep-2014
 
Modification History:
---------------------
*/

using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using JTL.Tax1040.WebApi.Security;
using Newtonsoft.Json;
using System.Dynamic;
using System;

namespace JTL.Tax1040.WebApi.Controllers
{
    public class CAController : ApiController
    {
        static readonly ITaxReturnRepository userRepository = new TaxReturnRepository();
        //TODO : Have to create instance for CARepository
        //static readonly ITaxesAndWrapUpRepository taxAndWrapUpRepository = new TaxesAndWrapUpRepository();

        //TODO : Have to implement persist and get methods for CA State.

        #region Persist Method

        /// <summary>
        /// Persist CA Basic Info
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        [HttpPost]
        public void PersistCABasicInfo(dynamic userInputData)
        {
        }

        #endregion

        #region Get Method

        /// <summary>
        /// Get CA Basic Info
        /// </summary>
        /// <param name="userInputData">The User Id and User Data Id</param>
        /// <returns>CA Basic Info</returns>
        [HttpPost]
        public void GetCABasicInfo(UserDTO userDTO)
        {
        }

        #endregion


    }
}