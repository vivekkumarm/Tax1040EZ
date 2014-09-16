/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : PersonalInfoDataService.cs
Description                 : Personal Info interface for DataService.
Author                      : Vivekkumar.M
Created Date                : 07 March 2014
 
Modification History:
---------------------
  * 24Mar2014 Bala New methods added for persist and get Ez Eligibility check values.
  * 24Mar2014 Bala New methods added for persist and get Ez Eligibility check values.
  * saravanan n. - 27th mar, 2014 - PersistXXX method name changed as per standard.
  * 16Apr2014 Sathish added new method to check zip code is valid for state
  * 17Apr2014 Sathish Changed zipcode Datatype to long in ValidateZipCodeByStateId
*/

using JTL.Tax1040.BusinessObject;
using System.Collections.Generic;

namespace JTL.Tax1040.DataAccess
{
    /// <summary>
    /// Personal info interface data service 
    /// </summary>
    public interface IPersonalInfoDataService
    {
        #region Persist Methods
        //Saravanan N - 28th Mar, 2014 - PersonId returned from here.
        /// <summary>
        /// Persist the PrimaryTaxPayer.
        /// </summary>
        /// <param name="primaryTaxPayer">The primary tax payer details.</param>
        /// <param name="userId">The user identifier.</param>
        long PersistPrimaryTaxPayer(PrimaryTaxPayer primaryTaxPayer, long userId);

        /// <summary>
        /// Persist Address and Address History
        /// </summary>
        /// <param name="address"></param>
        /// <param name="personId"></param>
        void PersistAddress(Address address, long personId);

        /// <summary>
        /// Persists Spouse information.
        /// </summary>
        /// <param name="spouse">Contains Spouse object</param>
        /// <param name="userId">The user identifier.</param>
        void PersistSpouse(Spouse spouse, long userId);
        

        /// <summary>
        /// Persist the EZ Eligibility details.
        /// </summary>
        /// <param name="ezEligibility">The EZ Eligibility details</param>
        /// <returns></returns>
        long PersistEzEligibility(dynamic ezEligibility);
        #endregion

        #region Get Methods
        /// <summary>
        /// Gets the PrimaryTaxPayer by PersonId.
        /// </summary>
        /// <param name="PersonalInfoId">The personal information identifier.</param>
        /// <returns></returns>
        PrimaryTaxPayer GetPersonByPersonId(long personId);

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

        #endregion

        #region Validatate Zip code
        /// <summary>
        /// Validate Zip code by State Id
        /// </summary>
        /// <param name="stateId">The State Id</param>
        /// <param name="zipCode">The Zip Code</param>
        /// <returns>Status</returns>
        bool ValidateZipCodeByStateId(long stateId, long zipCode);
        #endregion



    }
}
