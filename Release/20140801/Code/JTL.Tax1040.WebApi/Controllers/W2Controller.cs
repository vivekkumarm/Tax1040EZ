/*
Copyright   : Copyright Jeevan Technologies
File Name   : W2Controller.cs 
Description : WebAPI Controller for Tax Return  
Author      : Ashok Kumar
Created Date : 21 Mar 2014

 * Modification History:
---------------------
 * 26 Mar 2014 Ashok Kumar Modficiation on passing Parameter W2 instead of whole TaxObject.
 * 28 Mar 2014 Ashok Kumar Added new Controller methods for retrieving Error List and W2 List.
 * 10 Apr 2014 Bala Added new Controller methods("DeleteW2ById" & "GetW2OtherCode") for deleting W2 object from W2 List and Get W2OtherCode list.
 * 11 Apr 2014 Bala Methods modified for W2 persist and get methods.
 * 15 Apr 2014 Sathish Checked taxObject is null in GetTaxReturnW2List.
 * 23 Apr 2014 Bala moved the (Json to Object) conversion into repository methods and corresponding functionality.
 * 28 Apr 2014 Sathish Added TaxReturnData for PersistW2Data Used common method for conversation.
 * 13th May, 2014 - Saravanan N - Param changed to UserDTO.
 * 14th May 2014-Vincent - Change the HttpPost to HttpGet In GetW2otherCode method.
 */

using System.Collections.Generic;
using System.Web.Http;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.Core.Object;
using Newtonsoft.Json;
using JTL.Tax1040.BusinessObject;
using System.Linq;
using System.Web.WebPages.Html;
using System;
using System.ComponentModel;
using System.Dynamic;
using JTL.Tax1040.Core.Process;
/*
 Modification History:
---------------------
 * 23 July 2014 - Removed unused variables taxReturnData
 */
namespace JTL.Tax1040.WebApi.Controllers
{
    public class W2Controller : ApiController
    {
        static readonly IW2Repository w2Repository = new W2Repository();

        /// <summary>
        /// Persists the W2 data.
        /// </summary>
        /// <param name="userInputData">The User Input Data.</param>
        /// <returns></returns>
        //[AcceptVerbs("GET", "POST")]
        [HttpPost]
        public dynamic PersistW2Data(dynamic userInputData)
        {
            TaxReturnData taxReturnData = JsonConvert.DeserializeObject<TaxReturnData>(userInputData.TaxReturnData.ToString());

            return w2Repository.PersistW2TaxReturnData(Utilities.ConvertToLong(userInputData.userId), taxReturnData);
        }

        //Saravanan N - 13th May, 2014 - Param changed to UserDTO.
        /// <summary>
        /// Get the W2 data
        /// </summary>
        /// <param name="userInputData">The User Input Data.</param>
        /// <returns></returns>
        [HttpPost]
        public System.Tuple<W2, dynamic> GetW2Data(UserDTO userDTO)
        {
            return w2Repository.GetW2Data(userDTO);  
        }

        /// <summary>
        /// Get the Emloyee code.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<SelectListItem> GetEmployeeCode()
        {
            var employerCodeItems = new List<SelectListItem>();

            foreach (var value in Enum.GetValues(typeof(EmployerCode)).Cast<int>())
            {
                var type = typeof(EmployerCode);

                var memInfo = type.GetMember(Enum.GetName(typeof(EmployerCode), value));
                var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                var name = ((DescriptionAttribute)attributes[0]).Description;
                employerCodeItems.Add(new SelectListItem() { Value = value.ToString(), Text = name });

            }
            return employerCodeItems;
        }

        //Saravanan N - 13th May, 2014 - Param altered as UserDTO.
        //Added to Retrieve both W2 list and Error Message List togther for summary Page by Ashok
        /// <summary>
        /// Get the W2 list and corresponding error list.
        /// </summary>
        /// <param name="userInputData">The User Input Data</param>
        /// <returns></returns>
        [HttpPost]
        public System.Tuple<List<W2>, IEnumerable<ErrorMessage>, dynamic> GetW2ListandErrorList(UserDTO userDTO)
        {
            return w2Repository.GetW2ListandErrorList(userDTO);
        }

        //Saravanan N - 13th May, 2014 - Param altered as UserDTO.
        /// <summary>
        ///Delete W2 wages.
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        [HttpPost]
        public void DeleteW2ById(UserDTO userDTO)
        {
            w2Repository.DeleteAndPersistW2(userDTO);
        }

        /// <summary>
        /// Get W2 OtherCode
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<SelectListItem> GetW2OtherCode()
        {
            var otherCodeItems = new List<SelectListItem>();
            if (typeof(W2OtherCode).IsEnum)
            {
                var type = typeof(W2OtherCode);

                foreach (var value in Enum.GetValues(typeof(W2OtherCode)).Cast<int>())
                {
                    var memInfo = type.GetMember(Enum.GetName(typeof(W2OtherCode), value));
                    var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                    var name = ((DescriptionAttribute)attributes[0]).Description;
                    otherCodeItems.Add(new SelectListItem() { Value = value.ToString(), Text = name });
                }
            }
            return otherCodeItems;
        }
    }
}
