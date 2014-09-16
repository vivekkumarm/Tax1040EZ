/*
Copyright   : Copyright Jeevan Technologies
File Name   : TaxReturnDataService.cs 
Description : Data Service for Tax Return. 
Author      : Ashok Kumar Created Date : 17 Mar 2014

 * Modification History:
---------------------
 * 
Author        : Ashok Kumar
Modifeid Date : 17 Mar 2014
Decription    : Added input parameter to Get Method - GetTaxReturnDatabyUserDataId
 * 
 * Saravanan N - 15th April, 2014 - PersistSessionData() added.
 */
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;


namespace JTL.Tax1040.DataAccess
{
    /// <summary>
    /// Data Access class for Tax Return Data
    /// </summary>
    public class TaxReturnDataService : ITaxReturnDataService
    {
        #region Connection String
        /// <summary>
        /// The m connection string
        /// </summary>
        private readonly string mConnectionString = ConfigurationManager.AppSettings["TaxReturnConnectionString"];
        #endregion

        #region Persit Tax Return Data

        /// <summary>
        /// Persists the tax return.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="sessionData">The session data.</param>
        /// <param name="taxData">The tax data.</param>
        /// <param name="historyData">The history data.</param>
        /// <param name="sessionTerminate">if set to <c>true</c> [session terminate].</param>
        /// <param name="userDataId">The user data identifier.</param>
        /// <returns></returns>
        public dynamic PersistTaxReturnData(long userId, string sessionData, string taxData, string historyData, long userDataId)
        {
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_user_data_persist]";
                    sqlCommand.Parameters.AddWithValue("@user_data_id", userDataId);
                    sqlCommand.Parameters.AddWithValue("@user_id", userId);
                    sqlCommand.Parameters.AddWithValue("@session_data", sessionData);
                    sqlCommand.Parameters.AddWithValue("@tax_data", taxData);
                    sqlCommand.Parameters.AddWithValue("@history_data", historyData);
                    var id = sqlCommand.ExecuteScalar();
                    userDataId = Convert.ToInt64(id);                 
                }
            }
            return userDataId;
        }

        /// <summary>
        /// Saravanan N. - 26th Mar, 2014  - Persist JSON into DB.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <param name="taxData"></param>
        /// <returns>UserDataID</returns>
        public long PersistTaxReturnData(long userId, long userDataId, string taxData)
        {
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_user_data_persist]";
                    sqlCommand.Parameters.AddWithValue("@user_data_id", userDataId);
                    sqlCommand.Parameters.AddWithValue("@user_id", userId);
                    sqlCommand.Parameters.AddWithValue("@tax_data", taxData);
                    var id = sqlCommand.ExecuteScalar();
                    userDataId = (userDataId == 0 ? Convert.ToInt64(id) : userDataId);
                }
            }
            return userDataId;
        }

        /// <summary>
        /// Persist SessionData of particular User.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <param name="sessionData"></param>
        public void PersistSessionData(long userId, long userDataId, string sessionData)
        {
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_session_data_persist]";
                    sqlCommand.Parameters.AddWithValue("@user_id", userId);
                    sqlCommand.Parameters.AddWithValue("@user_data_id", userDataId);
                    sqlCommand.Parameters.AddWithValue("@session_data", sessionData);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Get Method for Return Data
        /// <summary>
        /// Gets the tax return databy user data identifier.
        /// </summary>
        /// <param name="userDataId">The user data identifier.</param>
        /// <returns></returns>
        /// Added userId parameter after discussion... Need to discuss futher to make Final Call
        public dynamic GetTaxReturnDatabyUserDataId(long userDataId, long userId)
        {
            var taxData = string.Empty;

            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_user_data_get_by_user_data_id]";
                    sqlCommand.Parameters.AddWithValue("@user_data_id", userDataId);
                    sqlCommand.Parameters.AddWithValue("@user_id", userId);

                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var sessionDataOrdinal = dataReader.GetOrdinal("session_data");
                            var taxDataOrdinal = dataReader.GetOrdinal("tax_data");
                            var historyDataOrdinal = dataReader.GetOrdinal("history_data");
                            while (dataReader.Read())
                            {
                                //sessionData = dataReader.GetString(sessionDataOrdinal);
                                taxData = dataReader.GetString(taxDataOrdinal);
                                //historyData = dataReader.GetString(historyDataOrdinal);
                            }
                        }
                    }
                }
            }

            return taxData;
        }

        /// <summary>
        /// Gets the SessionData by UserId and UserDataId.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="userDataId">The user data identifier.</param>
        /// <returns></returns>
        public string GetSessionDataByUserIdAndUserDataId(long userId, long userDataId)
        {
            var sessionData = string.Empty;

            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_user_data_get_by_user_data_id]";
                    sqlCommand.Parameters.AddWithValue("@user_data_id", userDataId);
                    sqlCommand.Parameters.AddWithValue("@user_id", userId);

                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            var sessionDataOrdinal = dataReader.GetOrdinal("session_data");
                            while (dataReader.Read())
                            {
                                //Saravanan N - 8th May, 2014 - DBNull check added.
                                sessionData = dataReader.IsDBNull(sessionDataOrdinal) ? string.Empty : dataReader.GetString(sessionDataOrdinal);
                            }
                        }
                    }
                }
            }

            return sessionData;
        }

        /// <summary>
        /// Gets the userDataId by userId.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>The user data id.</returns>
        public long GetUserDataIdByUserId(long userId)
        {
            var userDataId = 0L;
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_get_user_data_id_by_user_id]";
                    sqlCommand.Parameters.AddWithValue("@user_id", userId);

                    userDataId = Convert.ToInt64(sqlCommand.ExecuteScalar());
                }
            }

            return userDataId;
        }
        #endregion
    }
}
