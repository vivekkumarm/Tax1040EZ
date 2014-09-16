/*
Copyright    : Copyright Jeevan Technologies
File Name    : InterestIncomeController.cs 
Description  : Interest Income Controller for 1099INT & 1099OID 
Author       : Vincent 
Created Date : 31 Mar 2014

  * Modification History:
---------------------
 * 2Apr2014 Vincent  New method added for retrieving  1099INT 1099OID and ErrorList using Tuple
 * 8Apr2014 Vincent Added the null check for tax object in 1099OID.
 * 9Apr2014 Vincent Added the null check for GetTaxReturn1099INTListandErrorList and GetTaxReturn1099OIDListandErrorList.
 * 10Apr2014 Vincent Added the Delete method for F1099INT and F1099OID
 * 22Apr2014 Bala Added persist and Get methods for InterestIncomeEligibility
 * 29Apr2014 Bala Added method to Get InterestIncomeEligibilityDiagnosticsErrorList.
 * 30Apr2014 Bala Removed method to Get InterestIncomeEligibilityDiagnosticsErrorList.
 * 02May2014 Sathish Added TaxReturnData for PersistTaxReturnForm1099INTData
 */


using JTL.Tax1040.Core.Object;
using Newtonsoft.Json;
using JTL.Tax1040.BusinessObject;
using System.Web.Http;
using JTL.Tax1040.BusinessLogic;
using System.Collections.Generic;
using JTL.Tax1040.Core.Process;

namespace JTL.Tax1040.WebApi.Controllers
{
    public class InterestIncomeController : ApiController
    {
        readonly IInterestIncomeRepository interestIncomeRepository = new InterestIncomeRepository();

        #region 1099INT
        [HttpPost]
        public dynamic PersistTaxReturnForm1099INTData(dynamic taxReturn)
        {
            TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(taxReturn.TaxReturnData.ToString());

            return interestIncomeRepository.PersistTaxReturnForm1099INTData(Utilities.ConvertToLong( taxReturn.userId.Value), taxReturnData);
        }

        //Saravanan N - 9th May, 2014 - Refactored and method logics moved to Repository
        /// <summary>
        /// Returns INT Data.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public Form1099INT GetTaxReturn1099INTData(UserDTO userDTO)
        {
            return interestIncomeRepository.GetTaxReturn1099INTData(userDTO);
        }

        //Saravanan N - 9th May, 2014 - Refactored and method logics moved to Repository
        /// <summary>
        /// Returns List of INT and Error Messages.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public System.Tuple<List<Form1099INT>, List<ErrorMessage>> GetTaxReturn1099INTListandErrorList(UserDTO userDTO)
        {
            return interestIncomeRepository.GetTaxReturn1099INTListandErrorList(userDTO);
        }

        /// <summary>
        /// Deletes the form1099INT by identifier.
        /// </summary>
        /// <param name="userInputData">The user input data.</param>
        [HttpPost]
        public void DeleteForm1099INTById(UserDTO userDTO)
        {
            interestIncomeRepository.DeleteAndPersist1099INT(userDTO);
        }
        #endregion

        #region 1099OID
        [HttpPost]
        public dynamic PersistTaxReturnForm1099OIDData(dynamic taxReturn)
        {
            TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(taxReturn.TaxReturnData.ToString());

            return interestIncomeRepository.PersistTaxReturnForm1099OIDData( Utilities.ConvertToLong( taxReturn.userId.Value), taxReturnData);
        }

        //Saravanan N - 9th May, 2014 - Refactored and method logics moved to Repository
        /// <summary>
        /// Returns OID Data by FormID.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public Form1099OID GetTaxReturn1099OIDData(UserDTO userDTO)
        {
            return interestIncomeRepository.GetTaxReturn1099OIDData(userDTO);
        }

        //Saravanan N - 9th May, 2014 - Refactored and method logics moved to Repository
        /// <summary>
        /// Returns all OID with ErrorList.
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public System.Tuple<List<Form1099OID>, List<ErrorMessage>> GetTaxReturn1099OIDListandErrorList(UserDTO userDTO)
        {
            return interestIncomeRepository.GetTaxReturn1099OIDListandErrorList(userDTO);
        }

        //Saravanan N - 9th May, 2014 - Param changed to UserDTO
        /// <summary>
        /// Deletes the form1099OID by identifier.
        /// </summary>
        /// <param name="userInputData">The user input data.</param>
        [HttpPost]
        public void DeleteForm1099OIDById(UserDTO userDTO)
        {
            List<ErrorMessage> errorMessages = new List<ErrorMessage>();
            interestIncomeRepository.DeleteAndPersist1099OID(userDTO);
        }
        #endregion

        #region InterestIncomeEligibility

        [HttpPost]
        public dynamic PersistTaxReturnInterestIncomeEligibilityData(dynamic taxReturn)
        {
            string intIncomeEligibilityData = taxReturn.TaxData.ToString();
            string sessionData = intIncomeEligibilityData;
            string historyData = intIncomeEligibilityData;

            long userDataId = 0;
            long.TryParse(taxReturn.UserDataId.Value.ToString(), out userDataId);

            long userId = 0;
            long.TryParse(taxReturn.UserId.Value.ToString(), out userId);

            List<ErrorMessage> errorMessages = new List<ErrorMessage>();

            return interestIncomeRepository.PersistInterestIncomeEligibilityData(userId, sessionData, intIncomeEligibilityData, historyData, userDataId, out errorMessages);


        }
        
        //Saravanan N - 9th May, 2014 - Param changed to UserDTO type.
        [HttpPost]
        public InterestIncomeEligibility GetTaxReturnInterestIncomeEligibilityData(UserDTO userDTO)
        {
            return interestIncomeRepository.GetTaxReturnInterestIncomeEligibilityData(userDTO);
        }
        #endregion
    }
}
