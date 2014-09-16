/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : PersonalInfoController.cs
Description                 : Personal Info Controller.
Author                      : 
Created Date                : 
 
Modification History:
---------------------
 * 28Mar2014 Sathish  Changed code for persist spouse and get persist spouse
 * 01Apr2014 Sathish  Changed GetPrimaryTaxPayerByUserIdAndUserDataId parameter to dynmaic and changed get to post
 * 11Apr2014 Sathish Changed GetPersonalDetailsByUserIdAndUserDataId to return Error Message list and personal details
 * 08May2014 Sathish Added new method to get us mailing address used in address
 * 12May2014 Bala Modified return type as dynamic for PersistSpouse and PersistPrimaryTaxPayer.
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

namespace JTL.Tax1040.WebApi.Controllers
{
    public class PersonalInfoController : ApiController
    {
        static readonly IPersonalInfoRepository personalInfoRepository = new PersonalInfoRepository();
        static readonly ITaxReturnRepository taxReturnRepository = new TaxReturnRepository();

        #region Persist Methods
        [HttpPost]
        public dynamic PersistPrimaryTaxPayer(dynamic personalData)
        {
            PrimaryTaxPayer primaryTaxPayer =
                JsonConvert.DeserializeObject<PrimaryTaxPayer>(personalData.PrimaryTaxPayer.ToString());

            long userDataId = personalData.UserDataId.Value; 
            long userId = personalData.UserId.Value; 

           return personalInfoRepository.PersistPrimaryTaxPayer(primaryTaxPayer, userId, userDataId, personalData.Topic.ToString());
        }

        [HttpPost]
        public dynamic PersistAddress(dynamic addressDetails)
        {
            dynamic UserDataIdAndAddressId = new ExpandoObject();
            Address address = JsonConvert.DeserializeObject<Address>(addressDetails.Address.ToString());
           UserDataIdAndAddressId.UserDataId =  personalInfoRepository.PersistAddress(address, addressDetails.UserId.Value, addressDetails.UserDataId.Value);
           UserDataIdAndAddressId.AddressId = address.AddressId;
           return UserDataIdAndAddressId;
        }

        //Vivek - 25th Mar, 2014 - Persist Spouse. 
        [HttpPost]
        public dynamic PersistSpouse(dynamic primaryTaxPayer)
        {

            Spouse spouse =
                JsonConvert.DeserializeObject<Spouse>(primaryTaxPayer.Spouse.ToString());

            long userDataId;
            long.TryParse(primaryTaxPayer.userDataId.Value.ToString(), out userDataId);

            long userId;
            long.TryParse(primaryTaxPayer.userId.Value.ToString(), out userId);

           return personalInfoRepository.PersistSpouse(spouse, userId, userDataId);
        }

        //Vivek - 25th Mar, 2014 - Persist EzEligibility.
        [HttpPost]
        public void PersistEzEligibility(BusinessObject.Tax1040 tax1040Object, long userId)
        {
            personalInfoRepository.PersistEzEligibility(tax1040Object, userId);

        }
        #endregion

        #region Get Methods
        [HttpGet]
        public List<State> GetAllLivingStates()
        {
            return personalInfoRepository.GetAllState(true);
        }

        [HttpGet]
        public List<State> GetAllState()
        {
            return personalInfoRepository.GetAllState();
        }

        [HttpGet]
        public List<Country> GetAllCountry()
        {
            return personalInfoRepository.GetAllCountry();
        }

        /// Saravanan N. - 27th Mar, 2014 - userId and userDataId added as param.
        /// Sathish N - 1 April 2014 Changed parameter to dynamic to test from UI
        [HttpPost]
        public PrimaryTaxPayer GetPrimaryTaxPayerByUserIdAndUserDataId(dynamic person)
        {
            return personalInfoRepository.GetPrimaryTaxPayerByUserIdAndUserDataId(person.UserId.Value, person.UserDataId.Value);
        }

        ///Sathish N - 28Mat2014 Get Spouse
        /// <summary>
        /// Get Spouse By User ID Aand Data ID
        /// </summary>
        /// <param name="person">the Person</param>
        /// <returns>The Spouse</returns>
        [HttpPost]
        public dynamic GetSpouseByUserIdAndUserDataId(dynamic person)
        {
            return personalInfoRepository.GetSpouseByUserIdAndUserDataId(person.UserId.Value, person.UserDataId.Value);
        }

        /// Saravanan N. - 27th Mar, 2014 - Returns Spose from TaxObject.
        [HttpGet]
        public PrimaryTaxPayer GetPrimaryTaxPayerByPersonId(long personalId)
        {
            return personalInfoRepository.GetPersonByPersonId(personalId);
        }

        /// Saravanan N. - 27th Mar, 2014 - Returns Address from TaxObject.
        [HttpPost]
        public dynamic GetAddressByUserIdAndUserDataId(dynamic person)
        {
            return personalInfoRepository.GetAddressByUserIdAndUserDataId(person.UserId.Value, person.UserDataId.Value);
        }

        ///Bala - 2Apr2014 Get PersonalDetails
        /// <summary>
        /// Get PersonalDetails By user id and user data id.
        /// </summary>
        /// <param name="person">the Person detail</param>
        /// <returns>The Personal Details</returns>
        [HttpPost]
        public System.Tuple<PersonalDetails, List<ErrorMessage>> GetPersonalDetailsByUserIdAndUserDataId(dynamic person)
        {
            return personalInfoRepository.GetPersonalDetailsByUserIdAndUserDataId(person.UserId.Value, person.UserDataId.Value);            
        }

        /// Bala - 2Apr2014 Get User data id
        ///  <summary>
        ///  Gets the userDataId by userId.
        ///  </summary>
        /// <param name="user">The user</param>
        /// <returns>The user data id.</returns>
        [HttpPost]
        public long GetUserDataIdByUserId(User user)
        {
            return taxReturnRepository.GetUserDataIdByUserId(user.UserId);
        }

        ///Bala - 2Apr2014 Get Person id
        /// <summary>
        /// Gets the Person id by UserId and UserDataId.
        /// </summary>
        /// <param name="person">the Person detail</param>
        /// <returns>The person id.</returns>
        [HttpPost]
        public long GetPersonIdByUserIdAndUserDataId(dynamic person)
        {
            return personalInfoRepository.GetPersonIdByUserIdAndUserDataId(person.UserId.Value, person.UserDataId.Value);
        }

        #endregion
    }
}
