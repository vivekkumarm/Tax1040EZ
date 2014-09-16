/*
Copyright   : Copyright Jeevan Technologies
File Name   : AuditDataService.cs 
Description : Holds the Audit functionality methods implementation.
Author      : Bhavani Rajesh
Date        : 28 Aug 2014
Modification History:
---------------------
 */

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.DataAccess.DataService
{
    public class AuditDataService : IAuditDataService
    {
        private readonly string mConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        #region Persist Audit
        /// <summary>
        /// Audits the specified audit information.
        /// </summary>
        /// <param name="auditInfo">The audit information.</param>
        public void Audit(Audit auditInfo)
        {
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "[dbo].[usp_audit_persist]";

                    sqlCommand.Parameters.AddWithValue("@user_id", auditInfo.UserId);
                    sqlCommand.Parameters.AddWithValue("@user_data_id", auditInfo.UserDataId);
                    sqlCommand.Parameters.AddWithValue("@ip_address", auditInfo.IPAddress);
                    sqlCommand.Parameters.AddWithValue("@tab_name", auditInfo.TabName);
                    sqlCommand.Parameters.AddWithValue("@topic_name", auditInfo.TopicName);
                    sqlCommand.Parameters.AddWithValue("@description", auditInfo.Description);

                    sqlCommand.ExecuteNonQuery();

                }
            }
        }

        #endregion

    }
}
