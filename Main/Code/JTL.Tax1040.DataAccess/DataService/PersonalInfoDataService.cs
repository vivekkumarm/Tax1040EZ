/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : PersonalInfoDataService.cs
Description                 : This class handles Personal Info DAL methods.
Author                      : Vivekkumar.M
Created Date                : 07 March 2014
 
Modification History:
---------------------
 * 24Mar2014  Bala New methods added for persist and get Ez Eligibility check values.
 * saravanan n. - 27th mar, 2014 - PersistXXX method name changed as per standard.
 * 24Mar2014  Bala New methods added for persist and get Ez Eligibility check values.
 * 04Apr2014 Sathis Changed code Persist Address removed is modified and parameter while pasing to SP
 * 07Apr2014 Changed code in Persist Spouse not to pass zero
 * 16Apr2014 Sathish added new method to check zip code is valid for state
 * 17Apr2014 Sathish changed zip code to long while db read
 * 08May2014 Sathish changed get state method to pass is Mailing address
 * 16May2014 Sathish Changed address persist data service to check countryid is zero and set null
 * 02Jun2014 Sathish Added method to delete spouse using spouse id
 * 24July2014 Ashok Kumar added method to retrieve only the supporting states of Tax1040product
*/

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Dynamic;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.BusinessObject;
using System.Collections.Generic;

namespace JTL.Tax1040.DataAccess
{
    /// <summary>
    /// personal data service with interface 
    /// </summary>
    public class PersonalInfoDataService : IPersonalInfoDataService
    {
        #region Local variable declaration

        private readonly string mConnectionString;

        #endregion

        #region Constructor

        public PersonalInfoDataService()
        {
            mConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        #endregion

        #region Persist Methods

        //Saravanan N - 28th Mar, 2014 - 1) PersonId returned. 2) primaryTaxPayerDetails changed as primaryTaxPayer.
        /// <summary>
        /// Persist the PrimaryTaxPayer.
        /// </summary>
        /// <param name="primaryTaxPayer">The primary tax payer details.</param>
        /// <param name="userId">The user identifier.</param>
        public long PersistPrimaryTaxPayer(PrimaryTaxPayer primaryTaxPayer, long userId)
        {
            long personId = 0L; //Saravanan N - 28th Mar, 2014 - New variable added.

            if ((primaryTaxPayer != null))
            {
                using (var sqlConnection = new SqlConnection(mConnectionString))
                {
                    using (var sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlConnection.Open();

                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "[dbo].[usp_personal_info_persist]";
                        sqlCommand.Parameters.AddWithValue("@filing_status_id", primaryTaxPayer.FilingStatus);
                        sqlCommand.Parameters.AddWithValue("@user_id", userId); //Saravanan N - 28th Mar, 2014 - Moved out of the Person object.

                        if (primaryTaxPayer.Person != null)
                        {
                            sqlCommand.Parameters.AddWithValue("@personal_info_id",
                                primaryTaxPayer.Person.PersonId);
                            sqlCommand.Parameters.AddWithValue("@first_name", primaryTaxPayer.Person.FirstName);
                            sqlCommand.Parameters.AddWithValue("@middle_initial",
                                primaryTaxPayer.Person.MiddleInitial);
                            sqlCommand.Parameters.AddWithValue("@last_name", primaryTaxPayer.Person.LastName);
                            sqlCommand.Parameters.AddWithValue("@nick_name", primaryTaxPayer.Person.NickName);
                            sqlCommand.Parameters.AddWithValue("@occupation", primaryTaxPayer.Person.Occupation);
                            if (primaryTaxPayer.Person.DateOfBirth != DateTime.MinValue)
                                sqlCommand.Parameters.AddWithValue("@date_of_birth",
                                    primaryTaxPayer.Person.DateOfBirth);
                            sqlCommand.Parameters.AddWithValue("@social_security_number",
                                primaryTaxPayer.Person.SSN);
                            if (primaryTaxPayer.Person.PersonType != 0)
                                sqlCommand.Parameters.AddWithValue("@person_type_id",
                                    primaryTaxPayer.Person.PersonType);
                            sqlCommand.Parameters.AddWithValue("@has_primaryfiler_ecf_contributed",
                                primaryTaxPayer.Person.HasPrimaryFilerEcfContributed);
                            sqlCommand.Parameters.AddWithValue("@has_spouse_ecf_contributed",
                                primaryTaxPayer.Person.HasSpouseEcfContributed);
                            sqlCommand.Parameters.AddWithValue("@is_legally_blind",
                                primaryTaxPayer.Person.IsLegallyBlind);
                            sqlCommand.Parameters.AddWithValue("@is_disabled", primaryTaxPayer.Person.IsDisabled);
                            sqlCommand.Parameters.AddWithValue("@has_claimed_as_dependent",
                                primaryTaxPayer.Person.HasClaimedAsDependent);
                            sqlCommand.Parameters.AddWithValue("@is_died", primaryTaxPayer.Person.IsDied);
                            if (primaryTaxPayer.Person.DateOfDeath != DateTime.MinValue)
                                sqlCommand.Parameters.AddWithValue("@date_of_death",
                                    primaryTaxPayer.Person.DateOfDeath);
                            sqlCommand.Parameters.AddWithValue("@is_student", primaryTaxPayer.Person.IsStudent);
                            sqlCommand.Parameters.AddWithValue("@is_fulltime_student",
                                primaryTaxPayer.Person.IsFullTimeStudent);
                            //sqlCommand.Parameters.AddWithValue("@is_other_info_none",
                            //    primaryTaxPayer.Person.IsOtherInfoNone);
                        }

                        //Get ID from DB.
                        //Saravanan N - 28th Mar, 2014 - Get PersonId from DB and return to Repository.
                        personId = (long)sqlCommand.ExecuteScalar();
                    }
                }
            }
            return personId;
        }

        /// <summary>
        ///  1) Persist Address 
        ///  2) Inserts new AddressHistory record for each Address persist.
        /// </summary>
        /// <param name="address">This param. contains Person's Address details.</param>
        /// <returns>AddressID</returns>
        public void PersistAddress(Address address, long personId)
        {
            if (address != null)
            {
                using (var sqlConnection = new SqlConnection(mConnectionString))
                {
                    using (var sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlConnection.Open();
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "[dbo].[usp_address_and_address_history_persist]";
                        sqlCommand.Parameters.AddWithValue("@address_id", address.AddressId);
                        sqlCommand.Parameters.AddWithValue("@personal_info_id", personId);
                        //if(address.ObjectState == ObjectState.Modified)
                        //    sqlCommand.Parameters.AddWithValue("@is_Address_Modified", 1 );
                        //else
                        //    sqlCommand.Parameters.AddWithValue("@is_Address_Modified", 0);
                        if (address.ResidenceState.StateId != 0)
                            sqlCommand.Parameters.AddWithValue("@residence_state_id", address.ResidenceState.StateId);
                        sqlCommand.Parameters.AddWithValue("@has_lived_in_more_than_one_state",
                                                           address.HasLivedInMoreThanOneState);
                        sqlCommand.Parameters.AddWithValue("@has_earned_income_from_non_lived_state",
                                                           address.HasEarnedIncomeFromNonLivedState);
                        
                        // TODO: Code will be removed once spec is updated
                        
                        //if (address.LivedInAnotherState != null && address.LivedInAnotherState.StateId != 0) //10Jul2014 Sathish checked nullable object and checked to new state bo
                        //    sqlCommand.Parameters.AddWithValue("@lived_in_another_state_id", address.LivedInAnotherState.StateId);

                        //sqlCommand.Parameters.AddWithValue("@lived_in_another_state_from",
                        //                                   address.LivedInAnotherStateFrom);
                        //sqlCommand.Parameters.AddWithValue("@lived_in_another_state_to", address.LivedInAnotherStateTo);

                        //if (address.EarnedIncomeFromNonLivedState != null && address.EarnedIncomeFromNonLivedState.StateId != 0) //10Jul2014 Sathish checked nullable object and checked to new state bo
                        //sqlCommand.Parameters.AddWithValue("@earned_income_from_non_lived_state_id",
                        //                                   address.EarnedIncomeFromNonLivedState.StateId); //10Jul2014 Sathish checked nullable object and checked to new state bo

                        //Bala, 28,Jul 2014, Code modified to store more state ids
                        if (address.LivedInAnotherStates != null) 
                        {
                            sqlCommand.Parameters.AddWithValue("@lived_in_another_state_id", String.Join(",", address.LivedInAnotherStates.Select(st => st.StateId.ToString())));
                        }

                        if (address.EarnedIncomeFromNonLivedStates != null)
                        {
                            sqlCommand.Parameters.AddWithValue("@earned_income_from_non_lived_state_id",
                                                               String.Join(",",address.EarnedIncomeFromNonLivedStates.Select(st=> st.StateId.ToString()))); 
                        }

                        sqlCommand.Parameters.AddWithValue("@address_type", address.AddressType);

                        if (address.AddressType == AddressType.PersonalAddress)
                        {
                            sqlCommand.Parameters.AddWithValue("@street_address",
                                                               address.PersonalAddress.StreetAddress);
                            sqlCommand.Parameters.AddWithValue("@apartment_number",
                                                               address.PersonalAddress.ApartmentNumber);
                            sqlCommand.Parameters.AddWithValue("@country_id",
                                                               1);
                            sqlCommand.Parameters.AddWithValue("@city", address.PersonalAddress.City);
                            if (address.PersonalAddress.State != null && address.PersonalAddress.State.StateId != 0) //10Jul2014 Sathish checked nullable object and checked to new state bo
                            sqlCommand.Parameters.AddWithValue("@personal_address_state_id",
                                                               address.PersonalAddress.State.StateId);
                            sqlCommand.Parameters.AddWithValue("@zip_code", address.PersonalAddress.ZipCode);
                            sqlCommand.Parameters.AddWithValue("@phone", address.PersonalAddress.PhoneNumber);
                        }
                        else if (address.AddressType == AddressType.ForeignAddress)
                        {
                            sqlCommand.Parameters.AddWithValue("@foreign_state",
                                                               address.ForeignAddress.StateOrProvince);
                            if (address.ForeignAddress.Country != null && address.ForeignAddress.Country.CountryId == 0) //10Jul2014 Sathish checked nullable object and checked to new state bo
                                sqlCommand.Parameters.AddWithValue("@country_id", DBNull.Value);
                            else
                                sqlCommand.Parameters.AddWithValue("@country_id", address.ForeignAddress.Country.CountryId); //10Jul2014 Sathish checked nullable object and checked to new state bo
                            sqlCommand.Parameters.AddWithValue("@street_address",
                                                               address.ForeignAddress.StreetAddress);
                            sqlCommand.Parameters.AddWithValue("@apartment_number",
                                                               address.ForeignAddress.ApartmentNumber);
                            sqlCommand.Parameters.AddWithValue("@city", address.ForeignAddress.City);
                            sqlCommand.Parameters.AddWithValue("@postal_code", address.ForeignAddress.PostalCode);
                            sqlCommand.Parameters.AddWithValue("@phone",
                                                               address.ForeignAddress.PhoneNumber);
                        }
                        //Get ID from DB.
                        address.AddressId = (long)sqlCommand.ExecuteScalar();
                    }
                }
            }
        }

        /// <summary>
        /// Persist Spouse.
        /// </summary>
        /// <param name="spouse"></param>
        /// <param name="userId"></param>
        public void PersistSpouse(Spouse spouse, long userId)
        {
            if ((spouse != null) && (spouse.Person != null))
            {
                using (var sqlConnection = new SqlConnection(mConnectionString))
                {
                    using (var sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlConnection.Open();

                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "[dbo].[usp_personal_info_persist]";
                        //sqlCommand.Parameters.AddWithValue("@filing_status_id", spouse.FilingStatus);

                        sqlCommand.Parameters.AddWithValue("@personal_info_id", spouse.Person.PersonId);
                        sqlCommand.Parameters.AddWithValue("@user_id", userId);
                        sqlCommand.Parameters.AddWithValue("@first_name", spouse.Person.FirstName);
                        sqlCommand.Parameters.AddWithValue("@middle_initial", spouse.Person.MiddleInitial);
                        sqlCommand.Parameters.AddWithValue("@last_name", spouse.Person.LastName);
                        sqlCommand.Parameters.AddWithValue("@nick_name", spouse.Person.NickName);
                        sqlCommand.Parameters.AddWithValue("@occupation", spouse.Person.Occupation);
                        sqlCommand.Parameters.AddWithValue("@date_of_birth", spouse.Person.DateOfBirth);
                        sqlCommand.Parameters.AddWithValue("@social_security_number", spouse.Person.SSN);
                        sqlCommand.Parameters.AddWithValue("@person_type_id", spouse.Person.PersonType);
                        sqlCommand.Parameters.AddWithValue("@has_primaryfiler_ecf_contributed",
                                                           spouse.Person.HasPrimaryFilerEcfContributed);
                        sqlCommand.Parameters.AddWithValue("@has_spouse_ecf_contributed",
                                                           spouse.Person.HasSpouseEcfContributed);
                        sqlCommand.Parameters.AddWithValue("@is_legally_blind", spouse.Person.IsLegallyBlind);
                        sqlCommand.Parameters.AddWithValue("@is_disabled", spouse.Person.IsDisabled);
                        sqlCommand.Parameters.AddWithValue("@has_claimed_as_dependent",
                                                           spouse.Person.HasClaimedAsDependent);
                        sqlCommand.Parameters.AddWithValue("@is_died", spouse.Person.IsDied);
                        sqlCommand.Parameters.AddWithValue("@date_of_death", spouse.Person.DateOfDeath);
                        sqlCommand.Parameters.AddWithValue("@is_student", spouse.Person.IsStudent);
                        sqlCommand.Parameters.AddWithValue("@is_fulltime_student",
                                                           spouse.Person.IsFullTimeStudent);
                        //sqlCommand.Parameters.AddWithValue("@is_other_info_none", spouse.Person.IsOtherInfoNone);
                        //Below two fields are Spouse  related fields. Apart from this all other fields are common as PrimaryTaxPayer.
                        sqlCommand.Parameters.AddWithValue("@has_lived_in_another_state", spouse.HasLivedInAnotherState);
                        if (spouse.LivedInAnotherState != null && spouse.LivedInAnotherState.StateId != 0) //10Jul2014 Sathish checked nullable object and checked to new state bo
                            sqlCommand.Parameters.AddWithValue("@lived_in_another_state_id", spouse.LivedInAnotherState.StateId);

                        //Get ID from DB.
                        spouse.Person.PersonId = (long)sqlCommand.ExecuteScalar();
                    }
                }
            }
        }

        /// <summary>
        /// Persist the EZ Eligibility details.
        /// </summary>
        /// <param name="ezEligibility">The EZ Eligibility details</param>
        /// <returns></returns>
        public long PersistEzEligibility(dynamic ezEligibility)
        {
            var ezEligibilityId = 0L;
            if (ezEligibility != null)
            {
                using (var sqlConnection = new SqlConnection(mConnectionString))
                {
                    using (var sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlConnection.Open();
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "[dbo].[usp_ez_eligibility_persist]";
                        sqlCommand.Parameters.AddWithValue("@user_id", ezEligibility.UserId);
                        sqlCommand.Parameters.AddWithValue("@personal_info_id", ezEligibility.PersonalInfoId);
                        sqlCommand.Parameters.AddWithValue("@has_dependent", ezEligibility.HasDependent);
                        sqlCommand.Parameters.AddWithValue("@has_received_other_income",
                                                           ezEligibility.HasReceivedOtherIncome);
                        sqlCommand.Parameters.AddWithValue("@has_adjusted_gross_income",
                                                           ezEligibility.HasAdjustedGrossIncome);
                        sqlCommand.Parameters.AddWithValue("@has_claimed_itemized_deduction",
                                                           ezEligibility.HasClaimedItemizedDeduction);
                        sqlCommand.Parameters.AddWithValue("@has_claimed_credit", ezEligibility.HasClaimedCredit);
                        sqlCommand.Parameters.AddWithValue("@has_hired_person", ezEligibility.HasHiredPerson);
                        sqlCommand.Parameters.AddWithValue("@has_claimed_prior_year_tax",
                                                           ezEligibility.HasClaimedPriorYearTax);
                        sqlCommand.Parameters.AddWithValue("@has_paid_any_estimate", ezEligibility.HasPaidAnyEstimate);
                        sqlCommand.Parameters.AddWithValue("@has_claimed_as_Debtor", ezEligibility.HasClaimedAsDebtor);

                        //Get ID from DB.
                        ezEligibilityId = (long)sqlCommand.ExecuteScalar();
                    }
                }
            }

            return ezEligibilityId;
        }

        #endregion

        #region Get Methods

        /// <summary>
        /// Gets the personal information by personal information identifier.
        /// </summary>
        /// <param name="PersonalInfoID">The personal information identifier.</param>
        /// <returns></returns>
        public PrimaryTaxPayer GetPersonByPersonId(long personId)
        {
            var primaryTaxPayer = new PrimaryTaxPayer();

            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_personal_info_get_by_personal_info_id]";
                    sqlCommand.Parameters.AddWithValue("@personal_info_id", personId);

                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            //var userIdOrdinal = dataReader.GetOrdinal("[user_id]");
                            var firstnameOrdinal = dataReader.GetOrdinal("first_name");
                            var middleInitialOrdinal = dataReader.GetOrdinal("middle_initial");
                            var lastNameOrdinal = dataReader.GetOrdinal("last_name");
                            var nickNameOrdinal = dataReader.GetOrdinal("nick_name");
                            var occupationOrdinal = dataReader.GetOrdinal("occupation");
                            var dateOfBirthOrdinal = dataReader.GetOrdinal("date_of_birth");
                            var socialSecurityNumberOrdinal = dataReader.GetOrdinal("social_security_number");
                            var filingStatusIdOrdinal = dataReader.GetOrdinal("filing_status_id");
                            var personTypeIdOrdinal = dataReader.GetOrdinal("person_type_id");
                            var hasPrimaryFilerEcfContributedOrdinal =
                                dataReader.GetOrdinal("has_primaryfiler_ecf_contributed");
                            var hasSpouseEcfContributedOrdinal = dataReader.GetOrdinal("has_spouse_ecf_contributed");
                            var isLegallyBlindOrdinal = dataReader.GetOrdinal("is_legally_blind");
                            var isDisabledOrdinal = dataReader.GetOrdinal("is_disabled");
                            var isDiedOrdinal = dataReader.GetOrdinal("is_died");
                            var dateOfDeathOrdinal = dataReader.GetOrdinal("date_of_death");
                            var isStudentOrdinal = dataReader.GetOrdinal("is_student");
                            var isFulltimeStudentOrdinal = dataReader.GetOrdinal("is_fulltime_student");
                            var isOtherInfoNoneOrdinal = dataReader.GetOrdinal("is_other_info_none");
                            var streetAddressOrdinal = dataReader.GetOrdinal("street_address");
                            var cityOrdinal = dataReader.GetOrdinal("city");
                            var personalAddressStateIdOrdinal = dataReader.GetOrdinal("personal_address_state_id");
                            var foreignStateOrdinal = dataReader.GetOrdinal("foreign_state");
                            var countryIdOrdinal = dataReader.GetOrdinal("country_id");
                            var zipCodeOrdinal = dataReader.GetOrdinal("zip_code");
                            var phoneOrdinal = dataReader.GetOrdinal("phone");
                            var addressTypeOrdinal = dataReader.GetOrdinal("address_type");
                            var residenceStateIdOrdinal = dataReader.GetOrdinal("residence_state_id");
                            var hasLivedInMorethanOneStateOrdinal =
                                dataReader.GetOrdinal("has_lived_in_more_than_one_state");
                            var hasEarnedIncomeFromNonLivedStateOrdinal =
                                dataReader.GetOrdinal("has_earned_income_from_non_lived_state");
                            var livedInAnotherStateFromOrdinal = dataReader.GetOrdinal("lived_in_another_state_from");
                            var livedInAnotherStateToOrdinal = dataReader.GetOrdinal("lived_in_another_state_to");
                            var livedInAnotherStateIdOrdinal = dataReader.GetOrdinal("lived_in_another_state_id");
                            var earnedIncomeFromNonLivedStateIdOrdinal =
                                dataReader.GetOrdinal("earned_income_from_non_lived_state_id");
                            var apartmentNumberOrdinal = dataReader.GetOrdinal("apartment_number");
                            var postalCodeOrdinal = dataReader.GetOrdinal("postal_code");
                            //Spouse specific property.
                            var hasLivedInAnotherStateOrdinal = dataReader.GetOrdinal("has_lived_in_another_state");

                            while (dataReader.Read())
                            {
                                primaryTaxPayer = new PrimaryTaxPayer()
                                    {
                                        FilingStatus =
                                            (!dataReader.IsDBNull(filingStatusIdOrdinal)
                                                 ? ((FilingStatus)dataReader.GetInt64(filingStatusIdOrdinal))
                                                 : 0),
                                        Person = new Person()
                                            {
                                                FirstName =
                                                    (!dataReader.IsDBNull(firstnameOrdinal)
                                                         ? dataReader.GetString(firstnameOrdinal)
                                                         : string.Empty),
                                                //MiddleInitial = (!dataReader.IsDBNull(middleInitialOrdinal) ? dataReader.GetChar(middleInitialOrdinal) : char.MinValue),
                                                LastName =
                                                    (!dataReader.IsDBNull(lastNameOrdinal)
                                                         ? dataReader.GetString(lastNameOrdinal)
                                                         : string.Empty),
                                                NickName =
                                                    (!dataReader.IsDBNull(nickNameOrdinal)
                                                         ? dataReader.GetString(nickNameOrdinal)
                                                         : string.Empty),
                                                Occupation =
                                                    (!dataReader.IsDBNull(occupationOrdinal)
                                                         ? dataReader.GetString(occupationOrdinal)
                                                         : string.Empty),
                                                DateOfBirth =
                                                    (!dataReader.IsDBNull(dateOfBirthOrdinal)
                                                         ? dataReader.GetDateTime(dateOfBirthOrdinal)
                                                         : DateTime.Now),
                                                SSN =
                                                    (!dataReader.IsDBNull(socialSecurityNumberOrdinal)
                                                         ? dataReader.GetString(socialSecurityNumberOrdinal)
                                                         : string.Empty),
                                                PersonType =
                                                    (!dataReader.IsDBNull(personTypeIdOrdinal)
                                                         ? (PersonType)dataReader.GetInt64(personTypeIdOrdinal)
                                                         : 0),
                                                HasPrimaryFilerEcfContributed =
                                                    (!dataReader.IsDBNull(hasPrimaryFilerEcfContributedOrdinal)
                                                         ? dataReader.GetBoolean(hasPrimaryFilerEcfContributedOrdinal)
                                                         : false),
                                                HasSpouseEcfContributed =
                                                    (!dataReader.IsDBNull(hasSpouseEcfContributedOrdinal)
                                                         ? dataReader.GetBoolean(hasSpouseEcfContributedOrdinal)
                                                         : false),
                                                IsLegallyBlind =
                                                    (!dataReader.IsDBNull(isLegallyBlindOrdinal)
                                                         ? dataReader.GetBoolean(isLegallyBlindOrdinal)
                                                         : false),
                                                IsDied =
                                                    (!dataReader.IsDBNull(isDiedOrdinal)
                                                         ? dataReader.GetBoolean(isDiedOrdinal)
                                                         : false),
                                                DateOfDeath =
                                                    (!dataReader.IsDBNull(dateOfDeathOrdinal)
                                                         ? dataReader.GetDateTime(dateOfDeathOrdinal)
                                                         : DateTime.MinValue),
                                                IsStudent =
                                                    (!dataReader.IsDBNull(isStudentOrdinal)
                                                         ? dataReader.GetBoolean(isStudentOrdinal)
                                                         : false),
                                                IsFullTimeStudent =
                                                    (!dataReader.IsDBNull(isFulltimeStudentOrdinal)
                                                         ? dataReader.GetBoolean(isFulltimeStudentOrdinal)
                                                         : false),
                                                //IsOtherInfoNone =
                                                //    (!dataReader.IsDBNull(isOtherInfoNoneOrdinal)
                                                //         ? dataReader.GetBoolean(isOtherInfoNoneOrdinal)
                                                //         : false),
                                                IsDisabled =
                                                    (!dataReader.IsDBNull(isDisabledOrdinal)
                                                         ? dataReader.GetBoolean(isDisabledOrdinal)
                                                         : false),
                                                PersonId = personId

                                            }
                                    };

                                AddressType addressType = (AddressType)dataReader.GetInt32(addressTypeOrdinal);

                                var livedInAnotherStateIds = (!dataReader.IsDBNull(livedInAnotherStateIdOrdinal)
                                                     ? dataReader.GetString(livedInAnotherStateIdOrdinal)
                                                     : string.Empty);
                                var livedInAnotherStates = new List<State>();
                               foreach(var stateId in livedInAnotherStateIds.Split(','))
                               {
                                   var state = new State()
                                   {
                                       StateId = long.Parse(stateId)
                                   };
                                   livedInAnotherStates.Add(state);
                               }
                                                     var nonLivedStateIds = (!dataReader.IsDBNull(earnedIncomeFromNonLivedStateIdOrdinal)
                                                     ? dataReader.GetString(earnedIncomeFromNonLivedStateIdOrdinal)
                                                     : string.Empty);

                                var nonLivedStates = new List<State>();
                                foreach (var stateId in nonLivedStateIds.Split(','))
                               {
                                   var state = new State()
                                   {
                                       StateId = long.Parse(stateId)
                                   };
                                   nonLivedStates.Add(state);
                               }

                                primaryTaxPayer.Person.Address = new Address
                                    {
                                        //Basic Address Properties.
                                        ResidenceState = new State()
                                        {
                                            StateId = (!dataReader.IsDBNull(residenceStateIdOrdinal)
                                                                ? dataReader.GetInt64(residenceStateIdOrdinal)
                                                                : 0L)
                                        },
                                        //IsForeignAddress = (!dataReader.IsDBNull(hasLivedInAnotherStateOrdinal)
                                        //                        ? dataReader.GetBoolean(hasLivedInAnotherStateOrdinal)
                                        //                        : false),
                                        HasLivedInMoreThanOneState =
                                            (!dataReader.IsDBNull(hasLivedInMorethanOneStateOrdinal)
                                                 ? dataReader.GetBoolean(hasLivedInMorethanOneStateOrdinal)
                                                 : false),


                                        HasEarnedIncomeFromNonLivedState =
                                                                                    (!dataReader.IsDBNull(hasEarnedIncomeFromNonLivedStateOrdinal)
                                                                                         ? dataReader.GetBoolean(hasEarnedIncomeFromNonLivedStateOrdinal)
                                                                                         : false),
                                       //TODO : Have to remove once spec is updated
                                        //LivedInAnotherState = new State() //10Jul2014 Sathish changed to new state bo
                                        //{
                                        //    StateId =
                                        //        (!dataReader.IsDBNull(livedInAnotherStateIdOrdinal)
                                        //             ? dataReader.GetInt64(livedInAnotherStateIdOrdinal)
                                        //             : 0L)
                                        //},
                                        //LivedInAnotherStateFrom =
                                        //    (!dataReader.IsDBNull(livedInAnotherStateFromOrdinal)
                                        //         ? dataReader.GetDateTime(livedInAnotherStateFromOrdinal)
                                        //         : DateTime.MinValue),
                                        //LivedInAnotherStateTo =
                                        //    (!dataReader.IsDBNull(livedInAnotherStateToOrdinal)
                                        //         ? dataReader.GetDateTime(livedInAnotherStateToOrdinal)
                                        //         : DateTime.MinValue),

                                        //EarnedIncomeFromNonLivedState = new State()  //10Jul2014 Sathish changed to new state bo
                                        //{
                                        //    StateId =
                                        //        (!dataReader.IsDBNull(earnedIncomeFromNonLivedStateIdOrdinal)
                                        //             ? dataReader.GetInt64(earnedIncomeFromNonLivedStateIdOrdinal)
                                        //             : 0L)
                                        //},

                                        LivedInAnotherStates = livedInAnotherStates,

                                        EarnedIncomeFromNonLivedStates = nonLivedStates
                                    };

                                if (addressType == AddressType.PersonalAddress)
                                {
                                    primaryTaxPayer.Person.Address.PersonalAddress = new PersonalAddress()
                                        {
                                            //PersonalAddress specific properties.
                                            StreetAddress =
                                                (!dataReader.IsDBNull(streetAddressOrdinal)
                                                     ? dataReader.GetString(streetAddressOrdinal)
                                                     : string.Empty),
                                            ApartmentNumber =
                                                (!dataReader.IsDBNull(apartmentNumberOrdinal)
                                                     ? dataReader.GetString(apartmentNumberOrdinal)
                                                     : string.Empty),
                                            City =
                                                (!dataReader.IsDBNull(cityOrdinal)
                                                     ? dataReader.GetString(cityOrdinal)
                                                     : string.Empty),
                                            State = new State()  //10Jul2014 Sathish changed to new state bo
                                            {
                                                StateId =
                                                    (!dataReader.IsDBNull(personalAddressStateIdOrdinal)
                                                         ? dataReader.GetInt64(personalAddressStateIdOrdinal)
                                                         : 0L)
                                            },
                                            ZipCode =
                                                (!dataReader.IsDBNull(zipCodeOrdinal)
                                                     ? dataReader.GetString(zipCodeOrdinal)
                                                     : string.Empty),
                                            PhoneNumber =
                                                (!dataReader.IsDBNull(phoneOrdinal)
                                                     ? dataReader.GetString(phoneOrdinal)
                                                     : string.Empty)
                                        };
                                }
                                else if (addressType == AddressType.ForeignAddress)
                                {
                                    primaryTaxPayer.Person.Address.ForeignAddress = new ForeignAddress()
                                        {
                                            StreetAddress =
                                                (!dataReader.IsDBNull(streetAddressOrdinal)
                                                     ? dataReader.GetString(streetAddressOrdinal)
                                                     : string.Empty),
                                            ApartmentNumber =
                                                (!dataReader.IsDBNull(apartmentNumberOrdinal)
                                                     ? dataReader.GetString(apartmentNumberOrdinal)
                                                     : string.Empty),
                                            City =
                                                (!dataReader.IsDBNull(cityOrdinal)
                                                     ? dataReader.GetString(cityOrdinal)
                                                     : string.Empty),

                                            StateOrProvince =
                                                (!dataReader.IsDBNull(foreignStateOrdinal)
                                                     ? dataReader.GetString(foreignStateOrdinal)
                                                     : string.Empty),
                                            Country = new Country()  //10Jul2014 Sathish changed to new country bo
                                            {
                                                CountryId =
                                                    (!dataReader.IsDBNull(countryIdOrdinal)
                                                         ? dataReader.GetInt64(countryIdOrdinal)
                                                         : 0L)
                                            },
                                            PostalCode = (!dataReader.IsDBNull(postalCodeOrdinal)
                                                              ? dataReader.GetString(postalCodeOrdinal)
                                                              : string.Empty),
                                            PhoneNumber = (!dataReader.IsDBNull(phoneOrdinal)
                                                               ? dataReader.GetString(phoneOrdinal)
                                                               : string.Empty),
                                        };
                                }
                            }
                        }
                    }
                }
            }
            return primaryTaxPayer;
        }

        /// <summary>
        /// Get EzEligibility By PersonalInfo Id
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public dynamic GetEzEligibilityByPersonalInfoId(long personId)
        {
            dynamic ezEligibility = new ExpandoObject();
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_ez_eligibility_by_personal_info_id]";
                    sqlCommand.Parameters.AddWithValue("@personal_info_id", personId);
                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var userIdOrdinal = dataReader.GetOrdinal("user_id");
                            var ezEligibilityIdOrdinal = dataReader.GetOrdinal("ez_eligibility_id");
                            var hasDependentOrdinal = dataReader.GetOrdinal("has_dependent");
                            var hasReceivedOtherIncomeOrdinal = dataReader.GetOrdinal("has_received_other_income");
                            var hasAdjustedGrossIncomeOrdinal = dataReader.GetOrdinal("has_adjusted_gross_income");
                            var hasClaimedItemizedDeductionOrdinal =
                                dataReader.GetOrdinal("has_claimed_itemized_deduction");
                            var hasClaimedCreditOrdinal = dataReader.GetOrdinal("has_claimed_credit");
                            var hasHiredPersonOrdinal = dataReader.GetOrdinal("has_hired_person");
                            var hasClaimedPriorYearTaxOrdinal = dataReader.GetOrdinal("has_claimed_prior_year_tax");
                            var hasPaidAnyEstimateOrdinal = dataReader.GetOrdinal("has_paid_any_estimate");
                            var hasClaimedAsDebtorOrdinal = dataReader.GetOrdinal("has_claimed_as_Debtor");
                            while (dataReader.Read())
                            {

                                ezEligibility.UserId = dataReader.GetInt64(userIdOrdinal);
                                ezEligibility.EligibilityId = dataReader.GetInt64(ezEligibilityIdOrdinal);
                                ezEligibility.HasDependent = dataReader.GetBoolean(hasDependentOrdinal);
                                ezEligibility.HasReceivedOtherIncome =
                                    dataReader.GetBoolean(hasReceivedOtherIncomeOrdinal);
                                ezEligibility.HasAdjustedGrossIncome =
                                    dataReader.GetBoolean(hasAdjustedGrossIncomeOrdinal);
                                ezEligibility.HasClaimedItemizedDeduction =
                                    dataReader.GetBoolean(hasClaimedItemizedDeductionOrdinal);
                                ezEligibility.HasClaimedCredit = dataReader.GetBoolean(hasClaimedCreditOrdinal);
                                ezEligibility.HasHiredPerson = dataReader.GetBoolean(hasHiredPersonOrdinal);
                                ezEligibility.HasClaimedPriorYearTax =
                                    dataReader.GetBoolean(hasClaimedPriorYearTaxOrdinal);
                                ezEligibility.HasPaidAnyEstimate = dataReader.GetBoolean(hasPaidAnyEstimateOrdinal);
                                ezEligibility.HasClaimedAsDebtor = dataReader.GetBoolean(hasClaimedAsDebtorOrdinal);
                            }
                        }
                    }
                }
            }
            return ezEligibility;
        }


        /// <summary>
        /// Get All States
        /// </summary>
        /// <returns></returns>
        public List<State> GetAllState(bool isAdditionalMailingAddress = false)
        {
            var lstState = new List<State>();
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_all_state]";
                    sqlCommand.Parameters.AddWithValue("@is_additional_mailing_address", isAdditionalMailingAddress);
                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var stateIdOrdinal = dataReader.GetOrdinal("state_id");
                            var stateCodeOrdinal = dataReader.GetOrdinal("state_code");
                            var stateNameOrdinal = dataReader.GetOrdinal("state_name");
                            while (dataReader.Read())
                            {
                                var state = new State
                                    {
                                        StateId =
                                            (!dataReader.IsDBNull(stateIdOrdinal)
                                                 ? dataReader.GetInt64(stateIdOrdinal)
                                                 : 0L),
                                        StateCode =
                                            (!dataReader.IsDBNull(stateCodeOrdinal)
                                                 ? dataReader.GetString(stateCodeOrdinal)
                                                 : string.Empty),
                                        StateName =
                                            (!dataReader.IsDBNull(stateNameOrdinal)
                                                 ? dataReader.GetString(stateNameOrdinal)
                                                 : string.Empty),
                                    };
                                lstState.Add(state);
                            }
                        }
                    }
                }
            }
            return lstState;
        }

        /// <summary>
        /// Get All Country
        /// </summary>
        /// <returns></returns>
        public List<Country> GetAllCountry()
        {
            var lstCountry = new List<Country>();
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_all_country]";
                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var countryIdOrdinal = dataReader.GetOrdinal("country_id");
                            var countryCodeOrdinal = dataReader.GetOrdinal("country_code");
                            var countryNameOrdinal = dataReader.GetOrdinal("country_name");
                            while (dataReader.Read())
                            {
                                var country = new Country
                                    {
                                        CountryId =
                                            (!dataReader.IsDBNull(countryIdOrdinal)
                                                 ? dataReader.GetInt64(countryIdOrdinal)
                                                 : 0L),
                                        CountryCode =
                                            (!dataReader.IsDBNull(countryCodeOrdinal)
                                                 ? dataReader.GetString(countryCodeOrdinal)
                                                 : string.Empty),
                                        CountryName =
                                            (!dataReader.IsDBNull(countryNameOrdinal)
                                                 ? dataReader.GetString(countryNameOrdinal)
                                                 : string.Empty)

                                    };

                                lstCountry.Add(country);
                            }
                        }
                    }
                }
            }
            return lstCountry;
        }

        /// <summary>
        /// Get All Supporting States
        /// </summary>
        /// <returns></returns>
        public List<State> GetAllSupportingState()
        {
            var lstState = new List<State>();
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_all_supporting_state]";
                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var stateIdOrdinal = dataReader.GetOrdinal("state_id");
                            var stateCodeOrdinal = dataReader.GetOrdinal("state_code");
                            var stateNameOrdinal = dataReader.GetOrdinal("state_name");
                            while (dataReader.Read())
                            {
                                var state = new State
                                {
                                    StateId =
                                        (!dataReader.IsDBNull(stateIdOrdinal)
                                             ? dataReader.GetInt64(stateIdOrdinal)
                                             : 0L),
                                    StateCode =
                                        (!dataReader.IsDBNull(stateCodeOrdinal)
                                             ? dataReader.GetString(stateCodeOrdinal)
                                             : string.Empty),
                                    StateName =
                                        (!dataReader.IsDBNull(stateNameOrdinal)
                                             ? dataReader.GetString(stateNameOrdinal)
                                             : string.Empty),
                                };
                                lstState.Add(state);
                            }
                        }
                    }
                }
            }
            return lstState;
        }
        #endregion

        #region Validatate Zip code
        public bool ValidateZipCodeByStateId(long stateId, long zipCode)
        {
            bool isValidZipCode = false;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_validate_zip_code_by_state_id]";
                    sqlCommand.Parameters.AddWithValue("@state_id", stateId);
                    sqlCommand.Parameters.AddWithValue("@zip_code", zipCode);

                    isValidZipCode = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                }
            }

            return isValidZipCode;
        }
        #endregion

        #region Delete
        public void DeleteSpouseByPersonId(long personId)
        {
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_delete_spouse_by_person_id]";
                    sqlCommand.Parameters.AddWithValue("@personal_info_id", personId);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        #endregion

    }
}


