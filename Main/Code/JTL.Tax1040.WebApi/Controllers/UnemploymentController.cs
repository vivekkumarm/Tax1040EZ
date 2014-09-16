/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : UnemploymentController.cs
Description                 : Contains Form 1099G controller methods.
Author                      : Saravanan N.
Created Date                : 2nd April, 2014
 
Modification History:
---------------------
 * Sathish N  - 28Apr2014 Changed CreateAndPersist1099G method to return user data id and form1099g ID
 * Sathish N  - 02May2014 Changed persist method to use TaxReturnData BO and Removed error message list in persist and delete 
 * Saravanan N - 6th May, 2014 - File and Class Name altered.
 * Bhavani - 23 July 2014 - Removed unused variables or objects - userDTO
 */

using System;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json;

namespace JTL.Tax1040.WebApi.Controllers
{
    /// <summary>
    /// This class contains methods called from html page.
    /// </summary>
    public class UnemploymentController : ApiController
    {
        #region Local variables declaration
        IUnemploymentRepository unemploymentRepository = new UnemploymentRepository();

        #endregion

        #region Controller Methods
        /// <summary>
        /// Store Form 1099G into TaxObject and then DB.
        /// </summary>
        /// <param name="taxReturn"></param>
        /// <returns></returns>
        [HttpPost]
        public dynamic PersistUnemployment(dynamic taxReturn)
        {
            TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(taxReturn.TaxReturnData.ToString());
            return unemploymentRepository.CreateAndPersistUnemployment(Utilities.ConvertToLong(taxReturn.userId.Value), taxReturnData);
        }

        //Saravanan N - 6th May, 2014 - Method refactored and removed unwanted parameters and code.
        /// <summary>
        /// Get Form1099G by its Form1099GId value.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public Tuple<Form1099G, string, string, FilingStatus,IEnumerable<ErrorMessage>> GetUnemploymentById(UserDTO userDTO)
        {
            return unemploymentRepository.GetUnemploymentById(userDTO);
        }

        //Saravanan N - 7th April, 2014 - GetForm1099GList for UnemploymentSummary page.
        //Saravanan N - 5th May, 2014 - Code Refactored and Unwanted variables removed.
        /// <summary>
        /// Get all Form1099G exists for this user.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public Tuple<List<Form1099G>, IEnumerable<ErrorMessage>, double?> GetAllUnemployment(UserDTO userDTO)
        {
            return unemploymentRepository.GetAllUnemployment(userDTO);
        }

        /// <summary>
        ///Delete Form1099G.
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        [HttpPost]
        public void DeleteUnemploymentById(UserDTO userDTO)
        {
            unemploymentRepository.DeleteAndPersistUnemployment(userDTO);
        }
        #endregion
    }
}
