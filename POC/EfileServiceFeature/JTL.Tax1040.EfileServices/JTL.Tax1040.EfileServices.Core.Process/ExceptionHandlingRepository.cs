using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace JTL.Tax1040.EfileServices.Core.Process
{
    public class ExceptionHandlingRepository
    {
        private static readonly string mConnectionString = ConfigurationManager.ConnectionStrings["Tax1040_Static"].ToString();
    
        /// <summary>
        /// Logs the exception.
        /// </summary>
        /// <param name="userDataId">The user data id.</param>
        /// <param name="serviceName">Name of the service.</param>
        /// <param name="ex">The ex.</param>
        public static void LogException(long userDataId, string serviceName, Exception ex)
        {
            try
            {
                using (var connection = new SqlConnection(mConnectionString))//"Data Source=.;Initial Catalog=Tax1040_Efile;user id=sa;password=dev2005"))
                {
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "[dbo].[usp_error_log_persist]";
                        cmd.Parameters.Add(new SqlParameter("@user_id", userDataId));
                        cmd.Parameters.Add(new SqlParameter("@exception_occured_instance", serviceName));
                        cmd.Parameters.Add(new SqlParameter("@exception_message", ex.Message + ex.StackTrace));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
