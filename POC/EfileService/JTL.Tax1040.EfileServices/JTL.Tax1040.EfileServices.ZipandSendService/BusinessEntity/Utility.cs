using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Mail;
using System.Configuration;
using System.Security.Cryptography;

namespace JTL.Tax1040.EfileServices.ZipandSendService.SenderChannel
{
    public static class Utility
    {
        #region Get MessageID

        public static string GetMessageID(string ETIN)
        {
            try
            {
                int SequenceLength = 8;
                String _allowedChars = "abcdefghijkmnopqrstuvwxyz0123456789";
                Byte[] randomBytes = new Byte[SequenceLength];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetBytes(randomBytes);
                char[] chars = new char[SequenceLength];
                int allowedCharCount = _allowedChars.Length;

                for (int i = 0; i < SequenceLength; i++)
                {
                    chars[i] = _allowedChars[(int)randomBytes[i] % allowedCharCount];
                }
                string result = ETIN + ToJDEDate(DateTime.Today) + new string(chars);
                return result;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Get Julian Date
        public static string ToJDEDate(DateTime d)
        {
            return d.Year.ToString() + d.DayOfYear.ToString("000");
        }
        #endregion

        #region Send Mail

        public static void SendMail(string Message, string SubmissionId)
        {
            if (null != ConfigurationManager.AppSettings["MailServerHost"]
                && null != ConfigurationManager.AppSettings["FromAddress"]
                && null != ConfigurationManager.AppSettings["ToAddress"]
                && null != ConfigurationManager.AppSettings["BccAddress"]
                && null != ConfigurationManager.AppSettings["DefaultSubject"])
            {
                SmtpClient smtpClient = new SmtpClient();
                MailMessage mailMessage;
                string host = ConfigurationManager.AppSettings["MailServerHost"].ToString();
                string frommail = ConfigurationManager.AppSettings["FromAddress"].ToString();
                string tomail = ConfigurationManager.AppSettings["ToAddress"].ToString();
                string bccmail = ConfigurationManager.AppSettings["BccAddress"].ToString();
                string Subject = ConfigurationManager.AppSettings["DefaultSubject"].ToString();
                if (!string.IsNullOrEmpty(host)
                    && !string.IsNullOrEmpty(frommail)
                    && !string.IsNullOrEmpty(tomail)
                    && !string.IsNullOrEmpty(bccmail)
                    && !string.IsNullOrEmpty(Subject))
                {
                    if (!string.IsNullOrEmpty(SubmissionId))
                    {
                        Subject = Subject + " for Submission Id : " + SubmissionId;
                    }
                    else
                    {
                        Subject = Message.ToString();
                    }

                    String mailtxt = string.Empty;
                    mailMessage = new MailMessage();
                    mailMessage.IsBodyHtml = false;
                    mailMessage.To.Add(new MailAddress(tomail));
                    mailMessage.Bcc.Add(bccmail);
                    mailMessage.From = new MailAddress(frommail);
                    mailMessage.Subject = Subject;
                    mailMessage.Body = Message;
                    smtpClient = new SmtpClient(host);
                    smtpClient.Send(mailMessage);
                }
            }
        }
        #endregion

        #region Convert to Int32

        public static Int32 GetInt32(object Value)
        {
            Int32 result = 0;
            if (Value != null)
            {
                Int32.TryParse(Value.ToString(), out result);
            }
            return result;
        }
        #endregion

        #region Convert to double

        public static double Getdouble(object Value)
        {
            double result = 0;
            if (Value != null)
            {
                double.TryParse(Value.ToString(), out result);
            }
            return result;
        }
        #endregion

        #region Convert to decimal

        public static decimal GetDecimal(object Value)
        {
            decimal result = decimal.MinValue;
            if (Value != null)
            {
                decimal.TryParse(Value.ToString(), out result);
            }
            return result;
        }
        #endregion

        #region Convert to DateTime

        public static DateTime GetDateTime(object Value)
        {
            DateTime result = DateTime.MinValue;
            if (Value != null)
            {
                DateTime.TryParse(Value.ToString(), out result);
            }
            return result;
        }
        #endregion

        #region Get Appsettings Value

        public static string GetAppSettingsValue(string key)
        {
            if (ConfigurationManager.AppSettings[key] != null)
            {
                return ConfigurationManager.AppSettings[key].ToString();
            }
            return string.Empty;
        }
        #endregion
    }
}