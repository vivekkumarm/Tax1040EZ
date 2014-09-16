/*
Copyright   : Copyright Jeevan Technologies
File Name   : EmailDataService.cs 
Description : Business object for EmailData. 
Author      : Sathish Natarajan
Date        : 13 Mar 2014
Modification History:
---------------------
 */


using JTL.Tax1040.BusinessObject;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.DataAccess
{
   public class EmailDataService : IEmailDataService
    {

       private readonly string mConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

       public EmailData GetEmailTemplateById(EmailTemplate templateId)
       {
           EmailData emailData = null;
           using (var sqlConnection = new SqlConnection(mConnectionString))
           {
               using (var sqlCommand = sqlConnection.CreateCommand())
               {
                   sqlConnection.Open();
                   sqlCommand.CommandType = CommandType.StoredProcedure;
                   sqlCommand.CommandText = "[dbo].[usp_get_email_template_by_id]";
                   sqlCommand.Parameters.AddWithValue("@template_id", templateId);

                   using (var dataReader = sqlCommand.ExecuteReader())
                   {
                       if (dataReader.HasRows)
                       {
                           emailData = new EmailData();
                           var templateName = dataReader.GetOrdinal("template_name");
                           var templateContent = dataReader.GetOrdinal("template_Content");

                           while (dataReader.Read())
                           {
                               emailData.TemplateName = dataReader.GetString(templateName);
                               emailData.TemplateContent = dataReader.GetString(templateContent);
                           }
                       }
                   }
               }
           }

           return emailData;
       }
    }
}
