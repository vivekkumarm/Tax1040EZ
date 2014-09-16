/*
Copyright   : Copyright Jeevan Technologies
File Name   : MessagesRepository.cs 
Description : Business Logic for Error Messages  
Author      : 
Created Date : 

 * Modification History:
-------------------------
 * 
Author         : Bala
Modifiedd Date : 28 Apr 14
Decription     : Added new method "ClearErrorMessages" to clear error messages. 

Author         : Bala
Modifiedd Date : 02 May 14
Decription     : Modified code to check al type of scenario in "ClearErrorMessages" method . 
 
 * 
 */


using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Dynamic;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.Core.Process
{
   public class MessagesRepository : IMessagesRepository
    {
       private readonly string mConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        /// <summary>
        /// Gets the error messages.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, ErrorMessage> GetErrorMessages()
        {
            var errorMessages = new Dictionary<string, ErrorMessage>();
            using (var sqlConnection = new SqlConnection(mConnectionString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "usp_get_error_message";
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            var errorCodeOrdinal = sqlDataReader.GetOrdinal("error_code");
                            var fieldNameOrdinal = sqlDataReader.GetOrdinal("field_name");
                            var fieldDescriptionOrdinal = sqlDataReader.GetOrdinal("field_description");
                            var tabOrdinal = sqlDataReader.GetOrdinal("tab");
                            var topicOrdinal = sqlDataReader.GetOrdinal("topic");
                            var errorTypeOrdinal = sqlDataReader.GetOrdinal("error_type");
                            var messageTypeOrdinal = sqlDataReader.GetOrdinal("message_type");
                            //var errorTextOrdinal = sqlDataReader.GetOrdinal("error_text");
                            var shortErrorTextOrdinal = sqlDataReader.GetOrdinal("short_error_text");
                            var longErrorTextOrdinal = sqlDataReader.GetOrdinal("long_error_text");
                            var messageTargetOrdinal = sqlDataReader.GetOrdinal("message_target");
                            var errorTitleOrdinal = sqlDataReader.GetOrdinal("error_title");

                            while (sqlDataReader.Read())
                            {
                                var errorMessage = new ErrorMessage()
                                {
                                    ErrorCode = sqlDataReader.IsDBNull(errorCodeOrdinal) ? string.Empty : sqlDataReader.GetString(errorCodeOrdinal),
                                    FieldName = sqlDataReader.IsDBNull(fieldNameOrdinal) ? string.Empty : sqlDataReader.GetString(fieldNameOrdinal),
                                    FieldDescription = sqlDataReader.IsDBNull(fieldDescriptionOrdinal) ? string.Empty : sqlDataReader.GetString(fieldDescriptionOrdinal),
                                    Tab = sqlDataReader.IsDBNull(tabOrdinal) ? string.Empty : sqlDataReader.GetString(tabOrdinal),
                                    Topic = sqlDataReader.IsDBNull(topicOrdinal) ? string.Empty : sqlDataReader.GetString(topicOrdinal),
                                    ErrorType = sqlDataReader.IsDBNull(errorTypeOrdinal) ? string.Empty : sqlDataReader.GetString(errorTypeOrdinal),
                                    MessageType = sqlDataReader.IsDBNull(messageTypeOrdinal) ? string.Empty : sqlDataReader.GetString(messageTypeOrdinal),
                                    ErrorText = sqlDataReader.IsDBNull(shortErrorTextOrdinal) ? string.Empty : sqlDataReader.GetString(shortErrorTextOrdinal),
                                    LongErrorText = sqlDataReader.IsDBNull(longErrorTextOrdinal) ? string.Empty : sqlDataReader.GetString(longErrorTextOrdinal),
                                    MessageTarget = sqlDataReader.IsDBNull(messageTargetOrdinal) ? string.Empty : sqlDataReader.GetString(messageTargetOrdinal),
                                    ErrorTitle = sqlDataReader.IsDBNull(errorTitleOrdinal) ? string.Empty : sqlDataReader.GetString(errorTitleOrdinal)
                                };
                                errorMessages.Add(errorMessage.ErrorCode, errorMessage);
                            }
                        }
                    }
                    return errorMessages;
                }
            }
        }

        public void ClearErrorMessages(List<ErrorMessage> errorMessages, string topic, long formId = 0, string errorCode=null)
        {
            if (errorMessages != null)
            {
                if (formId != 0)
                {
                    if (string.IsNullOrEmpty(errorCode))
                    {
                        errorMessages.RemoveAll(errMsg => errMsg.Topic == topic && errMsg.FormId == formId);
                    }
                    else if (!string.IsNullOrEmpty(errorCode))
                    {
                        errorMessages.RemoveAll(errMsg => errMsg.Topic == topic && errMsg.FormId == formId && errMsg.ErrorCode.StartsWith(errorCode));
                    }
                }
                else if (!string.IsNullOrEmpty(errorCode))
                {
                    errorMessages.RemoveAll(errMsg => errMsg.Topic == topic && errMsg.ErrorCode.StartsWith(errorCode));
                }
                else
                {
                    errorMessages.RemoveAll(errMsg => errMsg.Topic == topic);
                }
            }
        }
    }
}
