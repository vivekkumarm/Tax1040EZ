/*
Copyright   : Copyright Jeevan Technologies
File Name   : ExceptionHandling.cs 
Description : Catching Error to the database
Author      : Swapnesh
 */

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace JTL.Tax1040.Core.Process
{
    public static class ExceptionHandling
    {
        private static readonly string mConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        /// <summary>
        /// Gets the error messages.
        /// </summary>
        /// <returns></returns>
        public static void LogException(long userid, string methodname, Exception ex)
        {
            try
            {
                using (var connection = new SqlConnection(mConnectionString))
                {
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "[dbo].[usp_error_log_persist]";
                        cmd.Parameters.Add(new SqlParameter("@user_id", userid));
                        cmd.Parameters.Add(new SqlParameter("@exception_occured_instance", methodname));
                        cmd.Parameters.Add(new SqlParameter("@exception_message", ex.Message + ex.StackTrace));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                Utilities.SendMail(ex.Message + ex.StackTrace + "  " +  Environment.UserName  +"  ");
                throw ex;
            }
        }
    }
}
