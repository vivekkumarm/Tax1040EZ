﻿/*
Copyright   : Copyright Jeevan Technologies
File Name   : Utilities.cs 
Description : Utilitiy file which contains all the common methods. 
Author      : ******** Created Date : 

 * Modification History:
 * 17Mar2014 Bala 'EncryptMessage' Method added to implement the encryption of given value.  
 * 25Mar2014 Bala Methods added for regular expression and remove given symbols from the given value. 
 * 08Apr2014 Sathish Added new method GetEnumDescription to get enum description
 * 10th April, 2014 - Saravanan N - IsAlphabet function name corrected and RegExpression changed.
 * 11th April, 2014 - Sathish N - Changed IsAlphabet,IsValidRegexPattern function to check isnulorempty before comparing.
 * 06th May,   2014 - Sathish Changed is string empty method to check null 
 * 6th May, 2014 - Saravanan N - Added methods in CommonMethods region for GetUserDTO and GetTaxPayerAndSpouseNames.
 * 9th May, 2014 - Saravanan N - GetTaxObjectByUserIdAndUserDataId() returns new Tax1040 if no object already exists in the userData table.
---------------------
 */
using System;
using System.ComponentModel;
using System.Net.Mail;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Security;
using JTL.Tax1040.BusinessObject;
using System.Configuration;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.DataAccess;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace JTL.Tax1040.Core.Process
{
   public static class Utilities
    {

        #region Date type convertion
     
            /// <summary>
           /// Convert to double
           /// </summary>
           /// <param name="value">The Value</param>
            /// <returns>The Double
            /// On conversation exception return zero</returns>
            public static double ConvertToDouble(this object value)
            {
                double convertedDobuleValue;
                double.TryParse(Convert.ToString(value), out convertedDobuleValue);
                return convertedDobuleValue;
            }

           /// <summary>
           /// Convert to long
           /// </summary>
           /// <param name="value">The Value</param>
           /// <returns>The Long
           /// On conversation exception return zero</returns>
            public static long ConvertToLong(this object value)
            {
                long convertedLongValue;
                long.TryParse(Convert.ToString(value), out convertedLongValue);
                return convertedLongValue;
            }

           /// <summary>
           /// Convert to boolean
           /// </summary>
           /// <param name="value">The Value</param>
            /// <returns>The Boolean
            /// On conversation exception return zero</returns>
            public static bool ConvertToBoolean(this object value)
            {
                bool convertedBooleanValue;
                bool.TryParse(Convert.ToString(value), out convertedBooleanValue);
                return convertedBooleanValue;
            }

           /// <summary>
           /// Convert to Integer32
           /// </summary>
           /// <param name="value">The Value</param>
            /// <returns>The Integer
            /// On conversation exception return zero</returns>
            public static int ConvertToInteger32(this object value)
            {
                int convertedInteger32Value;
                int.TryParse(Convert.ToString(value), out convertedInteger32Value);
                return convertedInteger32Value;
            }

        #endregion

        #region Send Mail

               /// <summary>
               /// Send the Email.
               /// </summary>
               /// <param name="fromAddress">From Address</param>
                /// <param name="toAddress">To  Address</param>
               /// <param name="subject">Subject of the  mail</param>
               /// <param name="bodyMessage">Body of the mail</param>
               /// <param name="hostIp">The Host Ip</param>
               public static void SendMail(string fromAddress, string toAddress, string subject, string bodyMessage,
                   string hostIp)
               {
                   // Create email code
                   var fromMailAddress = new MailAddress(fromAddress, "Service Provider");
            var client = new SmtpClient { Host = hostIp };
            var message = new MailMessage { From = fromMailAddress };
                   message.To.Add(toAddress);
                   message.Subject = subject;
                   message.Body = bodyMessage;
                   client.Send(message);
               }



       /// <summary>
       /// Send the email
       /// </summary>
       /// <param name="emailData">The Email Data</param>
       /// <returns></returns>
        public static void SendMail(string errormessage)
        {
            SmtpClient smtpClient;
            MailMessage mailMessage;

            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_FROM_MAIL]) &&
                !string.IsNullOrEmpty(ConfigurationManager.AppSettings[Constants.APP_SETTING_EXCEPTIONGROUPMAIL]) &&
                !string.IsNullOrEmpty(ConfigurationManager.AppSettings[Constants.APP_SETTING_ERROR_FROM_WHICH_SERVER]) &&
                !string.IsNullOrEmpty(ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_MAIL_HOST])
                )
            {
                try
                {
                    mailMessage = new MailMessage();
                    mailMessage.To.Add(new MailAddress(ConfigurationManager.AppSettings[Constants.APP_SETTING_EXCEPTIONGROUPMAIL]));
                    mailMessage.From = new MailAddress(ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_FROM_MAIL]);
                    mailMessage.Subject = ConfigurationManager.AppSettings[Constants.APP_SETTING_ERROR_FROM_WHICH_SERVER];
                    mailMessage.Body = errormessage + " " + DateTime.Now.ToString();
                    smtpClient = new SmtpClient(ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_MAIL_HOST]);
                    smtpClient.Send(mailMessage);
                }
                catch (Exception ex)
                {

                }
            }

        }






        /// <summary>
        /// Send the email
        /// </summary>
        /// <param name="emailData">The Email Data</param>
        /// <returns></returns>
       public static bool SendMail(EmailData emailData)
       {
           SmtpClient smtpClient;
           MailMessage mailMessage;
           var status = false;
           emailData.FromEmailID = ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_FROM_MAIL];
           string host = ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_MAIL_HOST];
            string adminMail = ConfigurationManager.AppSettings[Constants.APP_SETTING_KEY_ADMIN_MAIL];

           if (!string.IsNullOrEmpty(emailData.FromEmailID) &&
               !string.IsNullOrEmpty(emailData.ToEmailID))
           {
               try
               {
                   mailMessage = new MailMessage();
                   mailMessage.To.Add(new MailAddress(emailData.ToEmailID));
                   mailMessage.From = new MailAddress(emailData.FromEmailID);
                   mailMessage.Bcc.Add(new MailAddress(adminMail));
                   mailMessage.IsBodyHtml = true;
                   mailMessage.Subject = emailData.Subject;
                   mailMessage.Body = emailData.TemplateContent;
                   smtpClient = new SmtpClient(host);
                   smtpClient.Send(mailMessage);
                   status = true;
               }
               catch (Exception ex)
               {
                   status = false;
               }
           }
           
           return status;
       }

            #endregion

        #region Check for Reg Ex Pattern
       public static bool IsValidRegexPattern(string valueToCheck, string pattern)
       {
           if (!string.IsNullOrEmpty(valueToCheck))
           {
               Regex regex = new Regex(pattern);
               Match match = regex.Match(valueToCheck);
               //Check the Match value and compare with value to check,
               //if Matches return true, else false
               if (match.Value == valueToCheck)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           return false;
       }
       #endregion

        #region Check Empty String
       /// <summary>
       /// Compare string for empty value
       /// </summary>
       /// <param name="value">string to check empty</param>
       /// <returns>bool status</returns>
       public static bool IsStringEmpty(string value)
       {
            if (value != null)
            return string.IsNullOrEmpty(value);
           else
               return true;
       }
       #endregion

        #region Remove Hiphen
       /// <summary>
       /// Removes the hiphen.
       /// </summary>
       /// <param name="value">The value.</param>
       /// <returns></returns>
       public static string RemoveHiphen(string strValue)
       {
           if (strValue != null)
           {
               return strValue.Replace("-", "");
           }
           else
           {
               return string.Empty;
           }
       }
       #endregion

        #region Remove Underscore
       /// <summary>
       /// Removes the Underscore.
       /// </summary>
       /// <param name="value">The value.</param>
       /// <returns></returns>
       public static string RemoveUnderscore(string strValue)
       {
           if (strValue != null)
           {
               return strValue.Replace("_", "");
           }
           else
           {
               return string.Empty;
           }
       }
            #endregion

        #region Remove Open Bracket
       /// <summary>
       /// Removes the Open Bracket.
       /// </summary>
       /// <param name="value">The value.</param>
       /// <returns></returns>
       public static string RemoveOpenBracket(string strValue)
       {
           if (strValue != null)
           {
               return strValue.Replace("(", "");
           }
           else
           {
               return string.Empty;
           }
       }
       #endregion

        #region Remove Close Bracket
       /// <summary>
       /// Removes the Close Bracket.
       /// </summary>
       /// <param name="value">The value.</param>
       /// <returns></returns>
       public static string RemoveCloseBracket(string strValue)
       {
           if (strValue != null)
           {
               return strValue.Replace(")", "");
           }
           else
           {
               return string.Empty;
           }
       }
       #endregion

        #region Check Numeric
       /// <summary>
       /// Determines whether the specified value is numeric.
       /// </summary>
       /// <param name="value">The value.</param>
       /// <returns>
       ///   <c>true</c> if the specified value is numeric; otherwise, <c>false</c>.
       /// </returns>
       public static bool IsNumeric(string value)
       {
           Regex regex = new Regex(@"^\d+$");
           if (regex.IsMatch(value))
           {
               return true;
           }
           else
           {
               return false;
           }
       }
       #endregion

        #region Check Alphapet
       /// <summary>
       /// Determines whether the specified value is Alhapet only.
       /// </summary>
       /// <param name="value">The value.</param>
       /// <returns>
       ///   <c>true</c> if the specified value is numeric; otherwise, <c>false</c>.
       /// </returns>
       public static bool IsAlphabet(string value)
       {
           //Saravanan N - 10th April, 2014 - Reg. expression changed. 
           if (!string.IsNullOrEmpty(value))
           {
               var regex = new Regex(@"(?i)^[a-zA-Z ]+$"); // 15May2014 Sathish Changed rejex to allow space character
               return regex.IsMatch(value);
           }
           return false;
       }

       /// <summary>
       /// Determines whether the specified value is Alhapet only.
       /// </summary>
       /// <param name="value">The value.</param>
       /// <returns>
       ///   <c>true</c> if the specified value is numeric; otherwise, <c>false</c>.
       /// </returns>
       public static bool IsAlphabet(char value)
       {
           //Saravanan N - 10th April, 2014 - Reg. expression changed.
           var regex = new Regex(@"(?i)^[a-z]+$");
           return regex.IsMatch(Convert.ToString(value));
       }

       #endregion

        #region Object Serializing Methods
       /// <summary>
       /// Saravanan N. - 26th Mar, 2014 - Convert Object to JSON.
       /// </summary>
       /// <param name="tax1040Object"></param>
       /// <returns></returns>
       public static string ConvertTaxObjectToJSON(BusinessObject.Tax1040 taxObject)
       {
           return JsonConvert.SerializeObject(taxObject);
       }

       /// <summary>
       /// Saravanan N. - 26th Mar, 2014 - Convert JSON to Object.
       /// </summary>
       /// <param name="tax1040Object"></param>
       /// <returns></returns>
       public static BusinessObject.Tax1040 ConvertJsonToTaxObject(string taxObject)
       {
           return JsonConvert.DeserializeObject<BusinessObject.Tax1040>(taxObject);
       }

       /// <summary>
       /// Saravanan N. - 26th Mar, 2014 - Get TaxData by UserId and UserDataId.
       /// </summary>
       /// <param name="userDataId"></param>
       /// <param name="userId"></param>
       /// <returns></returns>
       public static BusinessObject.Tax1040 GetTaxObjectByUserIdAndUserDataId(long userId, long userDataId)
       {
           BusinessObject.Tax1040 taxObject = null;
           try
           {
               TaxReturnDataService taxReturnDataService = new TaxReturnDataService();

               //Get TaxObject from DB for the current User.
               string strTax1040 = taxReturnDataService.GetTaxReturnDatabyUserDataId(userDataId, userId);

               if (strTax1040.Trim().Length > 0)
               {
                   //Tax1040 object already exists for this user.
                   taxObject = ConvertJsonToTaxObject(strTax1040);
                 
               }
               else
               {
                   //Tax1040 object not exists for this user.
                   taxObject = new BusinessObject.Tax1040();
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }

           return taxObject;
       }

       /// <summary>
       /// Saravanan N. - 26th Mar, 2014 - Persist TaxObject into DB.
       /// </summary>
       /// <param name="userId"></param>
       /// <param name="userDataId"></param>
       /// <param name="taxData"></param>
       /// <returns></returns>
       public static long PersistTaxObject(long userId, long userDataId, BusinessObject.Tax1040 taxData)
       {
           TaxReturnDataService taxReturnDataService = new TaxReturnDataService();

           if (taxData.UserDataId == 0)
           {
               taxData.UserDataId = userDataId;
           }
           string strTaxObject = ConvertTaxObjectToJSON(taxData);
           return taxReturnDataService.PersistTaxReturnData(userId, userDataId, strTaxObject);
       }
       #endregion

        #region GetEnumDescription
       /// <summary>
       /// Get Enum Description by Enum Value
       /// </summary>
       /// <param name="value">The Enum Value</param>
       /// <returns>The Enum Descrption</returns>
       public static string GetEnumDescription(Enum value)
       {
           FieldInfo field = value.GetType().GetField(value.ToString());

           DescriptionAttribute attribute
                   = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))
                       as DescriptionAttribute;

           return attribute == null ? value.ToString() : attribute.Description;
       }
        #endregion

        #region Common Methods
        //Extension method to rounding off Double value with 2 decimal places
        public static double RoundDouble(this double value)
       {
           double roundOffValue = Math.Round(value, 2, MidpointRounding.AwayFromZero);
           return roundOffValue;
       }

        /// <summary>
       /// Checks whether given email address is valid
       /// </summary>
       /// <param name="emailaddress">The email address.</param>
       /// <returns></returns>
        public static bool IsValidEmail(string emailaddress)
       {
           try
           {
               var m = new MailAddress(emailaddress);
               return true;
           }
           catch (FormatException)
           {
               return false;
           }
       }

        public static string EncryptMessage(string message, string salt = "")
        {
            var saltMessage = String.IsNullOrEmpty(salt) ? message : String.Concat(message, salt);
            var encryptedMessage = FormsAuthentication.HashPasswordForStoringInConfigFile(saltMessage, "SHA1");
            return encryptedMessage;
        }

       //Saravanan N - 6th May, 2014 - New common method added.
        /// <summary>
       /// Get TaxPayer and Spouse Names
       /// </summary>
       /// <param name="taxObject"></param>
       /// <returns></returns>
        public static Tuple<string, string, string, string> GetTaxPayerAndSpouseName(JTL.Tax1040.BusinessObject.Tax1040 taxObject)
        {
            string primaryTaxPayerFirstName = "", primaryTaxPayerLastName = "", spouseFirstName = "", spouseLastName = "";

            //Added Get PrimaryTax Filer / Spouse Names.
            if (taxObject != null && taxObject.PersonalDetails != null)
            {
                if (taxObject.PersonalDetails.PrimaryTaxPayer != null && taxObject.PersonalDetails.PrimaryTaxPayer.Person != null)
                {
                    primaryTaxPayerFirstName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName;
                    primaryTaxPayerLastName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.LastName;
                }

                if (taxObject.PersonalDetails.Spouse != null && taxObject.PersonalDetails.Spouse.Person != null)
                {
                    spouseFirstName = taxObject.PersonalDetails.Spouse.Person.FirstName;
                    spouseLastName = taxObject.PersonalDetails.Spouse.Person.LastName;
                }
            }

            return new Tuple<string, string, string, string>(primaryTaxPayerFirstName, primaryTaxPayerLastName, spouseFirstName, spouseLastName);
        }

        //Saravanan N - 6th May, 2014 - New common method added.
        /// <summary>
       /// Add errorMessages to errorMessagesList in TaxObject.
       /// </summary>
       /// <param name="errorMessageListInTaxObject"></param>
       /// <param name="formId"></param>
       /// <param name="errorMessage"></param>
        public static void AddErrorToTaxObjectWithFormId(List<ErrorMessage> errorMessageListInTaxObject, long formId, ErrorMessage errorMessage)
        {
            if (errorMessage != null)
            {
                errorMessage.FormId = formId;
                errorMessageListInTaxObject.Add(errorMessage);
            }
        }

        /// <summary>
        /// Create Random Numbers
        /// </summary>
        /// <param name="minimumSize">The minimum size</param>
        /// <param name="maximumSize">The maximum size</param>
        /// <returns>The random number</returns>
        public static int CreateRandomNumber(int minimumSize, int maximumSize)
        {
            var randomNumber = new Random();
            return randomNumber.Next(minimumSize, maximumSize);
        }
        #endregion
    }
}
