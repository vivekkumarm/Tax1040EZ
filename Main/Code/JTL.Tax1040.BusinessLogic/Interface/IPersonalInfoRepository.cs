/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : IPersonalInfoRepository.cs
Description                 : Personal Info interface for Repository.
Author                      : Vivekkumar.M
Created Date                : 07 March 2014
 
Modification History:
---------------------
 * Saravanan N - 27th Mar, 2014 - 1) New GetXXX added to get data from TaxObject using params. UserId and UserDataId.
 *                                2) Persist methods names altered as PersistXXX as per coding standard. 
 * 24Mar2014 Bala New methods added for persist and get Ez Eligibility check values.
 * Saravanan N. - 28th mar, 2014 - PersonId param removed from Persist PT, Address and Spouse methods.
 * 11Apr2014 Sathish Changed GetPersonalDetailsByUserIdAndUserDataId to return Error Message list and personal details
 * 08May2014 Sathish Changed get all state method to have Mailing address
*/

using JTL.Tax1040.BusinessObject;
using System.Collections.Generic;
using JTL.Tax1040.Core.Object;
using System;

namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Interface methods for Personal info repository.
    /// </summary>
    public interface IPersonalInfoRepository
    {
        #region Persist Methods
        //Saravanan N - 27th Mar, 2014 - Name altered as PersistXXX per standard.
        /// <summary>
        /// Persists PrimaryTaxPayer
        /// </summary>
        /// <param name="primaryTaxPayer"></param>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <param name="topic"></param>
        /// <returns></returns>
        dynamic PersistPrimaryTaxPayer(PrimaryTaxPayer primaryTaxPayer, long userId, long userDataId, string topic = null);

        //Saravanan N - 27th Mar, 2014 - Name altered as PersistXXX per standard.
        /// <summary>
        /// Persist address and address history.
        /// </summary>
        /// <param name="address">The address details.</param>
        /// <returns></returns>
        long PersistAddress(Address address, long userId, long userDataId);

        //Saravanan N - 27th Mar, 2014 - Name altered as PersistXXX per standard.
        /// <summary>
        /// Persist the EZ Eligibility details.
        /// </summary>
        /// <param name="tax1040Object">The Tax1040 Object.</param>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        long PersistEzEligibility(BusinessObject.Tax1040 taxObject, long userId);

        //Saravanan N - 27th Mar, 2014 - Name altered as PersistXXX per standard.
        /// <summary>
        /// Persists Spouse details.
        /// </summary>
        /// <param name="Spouse">Contains Spouse object</param>
        /// <param name="userDataId">The user identifier.</param>
        /// <param name="userDataId">The user data identifier.</param>
        /// <returns></returns>
        dynamic PersistSpouse(Spouse spouse, long userId, long userDataId);
        #endregion

        #region Get
        /// <summary>
        /// Gets the PrimaryTaxPayer by PersonId.
        /// </summary>
        /// <param name="personId">The person Id from Person Table.</param>
        /// <returns></returns>
        PrimaryTaxPayer GetPersonByPersonId(long personId);

        /// <summary>
        /// Gets the PrimaryTaxPayer by UserId and UserDataId.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        PrimaryTaxPayer GetPrimaryTaxPayerByUserIdAndUserDataId(long userId, long userDataId);

        /// <summary>
        /// Gets the personal information and Required field information by userId And userDataId
        /// </summary>
        /// <param name="personalInfoId">The personal information identifier.</param>
        /// <returns></returns>
        Tuple<PrimaryTaxPayer, List<ErrorMessage>> GetPrimaryTaxPayerAndErrorList(long userId, long userDataId);

        /// <summary>
        /// Gets the Spouse by UserId and UserDataId.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        dynamic GetSpouseByUserIdAndUserDataId(long userId, long userDataId);

        /// <summary>
        /// Gets the Address by UserId and UserDataId.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        dynamic GetAddressByUserIdAndUserDataId(long userId, long userDataId);

        /// <summary>
        /// Get All State
        /// </summary>
        /// <returns></returns>
        List<State> GetAllState(bool isAdditionalMailingAddress = false);

        /// <summary>
        /// Get All Country
        /// </summary>
        /// <returns></returns>
        List<Country> GetAllCountry();

        /// <summary>
        /// Get EzEligibility By PersonalInfo Id
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        dynamic GetEzEligibilityByPersonalInfoId(long personId);

        /// <summary>
        /// Gets the personal details by user id and user data id.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        //07Aug2014 Sathish return user data id in Tuple after updating is enabled error count
        System.Tuple<PersonalDetails, List<ErrorMessage>,long> GetPersonalDetailsByUserIdAndUserDataId(long userId, long userDataId);

        /// <summary>
        /// Gets the Person id by UserId and UserDataId.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns>The person id.</returns>
        long GetPersonIdByUserIdAndUserDataId(long userId, long userDataId);

        /// <summary>
        /// Get Is Enable Error count 
        /// </summary>
        /// <param name="userDTO">The User DTO</param>
        /// <returns></returns>
        //07Aug2014 Sathish get current personal section  to show error count in personal left menu
        PersonalSection GetCurrentPersonalSection(UserDTO userDTO);

        #endregion Get
    }
}
