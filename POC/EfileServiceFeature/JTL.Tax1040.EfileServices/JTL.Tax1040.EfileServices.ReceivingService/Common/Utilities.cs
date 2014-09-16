using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;
using System.IO;
using System.Xml.Serialization;
using System.Collections;
using System.Net.Mail;
using System.Xml;
using System.Diagnostics;
using System.Data;
using System.Text.RegularExpressions;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class Utilities
    {
        #region Constants
        public class constants
        {
            public const string SchemaErrorCode = "IRSSCHVAL000001";
            public const string ActionType = "IRS Schema Validation";
            public const string Namespace = "http://www.irs.gov/efile:";
            public const string Form8849 = "8849";
            public const string Form720 = "720";
            public const string EfileHoldID = "EfileHoldID";
            public const string SubmissionID = "SubmissionID";
            public const string EfileIRSSchema = "EfileIRSSchema";
            public const string TaxReturnTypeID = "TaxReturnTypeID";
            public const string Form8849xsdLocation = "Form8849xsdLocation";
            public const string Form8849Sch3xsdLocation = "Form8849Sch3xsdLocation";
            public const string Form8849Sch32009xsdLocation = "Form8849Sch32009xsdLocation";

            public const string Form720xsdLocation = "Form720xsdLocation";
            public const string SchemaNamespace = "SchemaNamespace";
            public const string Taxyear = "Taxyear";
            public const string Taxperiod = "Taxperiod";
            public const string FormType = "FormType";
            public const string ProductId = "ProductId";
        }

        public enum ProductType
        {
            Tax7004 = 1,
            None = 0
        }
        #endregion

        #region Get Document ID

        public static string GetDocumentId(string DocumentName)
        {
            try
            {
                int SequenceLength = 7;
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

                while (DocumentName.Length < 4)
                {
                    DocumentName = DocumentName + 'X';
                }

                string result = DateTime.Now.ToString("MMddyyyyhh:mm:ss") + ToJDEDate(DateTime.Today) + DocumentName.Substring(0, 4) + new string(chars);
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

        public static bool IsNumeric(string Value)
        {
            int number;

            bool isNumeric = false;
            if (Value != null)
            {
                isNumeric = int.TryParse(Value, out number);
            }
            return isNumeric;
        }


        public static string IsNullReturnZeroNumeric(object Value)
        {
            if (Value != null)
            {
                return Value.ToString();
            }
            else
            {
                return "0";
            }
        }


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

        public static bool IsValidSSN(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                string ssn = RemoveCloseBracket(value);
                ssn = RemoveOpenBracket(ssn);
                ssn = RemoveHyphens(ssn);

                if (ssn.Length == Constants.SSNLength && IsNumeric(ssn))
                {

                    int areaCode = int.Parse(ssn.Substring(0, 3));
                    string areaCode1 = ssn.Substring(0, 3);
                    string groupCode = ssn.Substring(3, 2);
                    string serialNo = ssn.Substring(5, 4);
                    if (ssn == Constants.NineZeros || ssn == Constants.NineNines || ssn == Constants.NaturalNumbers || areaCode == Constants.InvalidSsnAreaCode1 || areaCode1 == Constants.InvalidSsnAreaCode2 || groupCode == Constants.InvalidSsnGroupCode || serialNo == Constants.InvalidSsnSerialNo || areaCode > Constants.InvalidSsnAreaCodeRange)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        #region Convert to decimal 1 Digits

        public static decimal GetDecimal1Digit(object Value)
        {
            decimal result = decimal.MinValue;
            if (Value != null)
            {
                decimal.TryParse(Value.ToString(), out result);
                decimal.TryParse(result.ToString("#.0"), out result);
            }
            return Math.Round(result, 1);
        }
        #endregion


        /// <summary>
        /// Minimums the DOB.
        /// </summary>
        /// <returns></returns>
        public static DateTime MinimumDOB(int taxyear)
        {
            return new DateTime(taxyear - 64, 01, 01);
        }

        /// <summary>
        /// Maximums the DOB.
        /// </summary>
        /// <returns></returns>
        public static DateTime MaximumDOB(int taxyear)
        {
            return new DateTime(taxyear - 24, 01, 02);
        }

        /// <summary>
        /// Ages the calculation.
        /// </summary>
        /// <param name="dateofbirth">The dateofbirth.</param>
        /// <returns></returns>
        public static bool AgeCalculation(DateTime dateofbirth, int taxyear)
        {
            DateTime startdate = MinimumDOB(taxyear);
            return dateofbirth > startdate;
        }


        /// <summary>
        /// EICs the age calculation.
        /// </summary>
        /// <param name="dateofbirth">The dateofbirth.</param>
        /// <returns></returns>
        public static bool EICAgeCalculation(DateTime dateofbirth, int taxyear)
        {
            DateTime startdate = MinimumDOB(taxyear);
            DateTime endDate = MaximumDOB(taxyear);

            // Age is between 65 and 25 Eligible to file 1040ez
            return dateofbirth > startdate && dateofbirth < endDate;
        }

        #region Convert to decimal 2 Digits

        public static decimal GetDecimal(object Value)
        {
            decimal result = decimal.MinValue;
            if (Value != null)
            {
                decimal.TryParse(Value.ToString(), out result);
                result = Math.Round(result, 2);
                decimal.TryParse(result.ToString("#.00"), out result);
            }
            return result;
        }
        #endregion

        #region Convert to string 2 Digits decimal points

        public static string GetDecimalString2Digits(object Value)
        {
            decimal result = decimal.MinValue;
            if (Value != null)
            {
                decimal.TryParse(Value.ToString(), out result);
                decimal.TryParse(result.ToString("#.00"), out result);
                result = Math.Round(result, 2);
                return result.ToString("#.00");
            }
            return null;
        }
        #endregion

        #region Convert to string 3 Digits decimal points

        public static string GetDecimalString3Digits(object Value)
        {
            decimal result = decimal.MinValue;
            if (Value != null)
            {
                decimal.TryParse(Value.ToString(), out result);
                decimal.TryParse(result.ToString("#.000"), out result);
                result = Math.Round(result, 3);
                return result.ToString("#.000");
            }
            return null;
        }

        #endregion

        #region Convert to string 4 Digits decimal points

        public static string GetDecimalString4Digits(object Value)
        {
            decimal result = decimal.MinValue;
            if (Value != null)
            {
                decimal.TryParse(Value.ToString(), out result);
                decimal.TryParse(result.ToString("#.0000"), out result);
                result = Math.Round(result, 4);
                return result.ToString("#.0000");
            }
            return null;
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

        #region State Value Hash Table

        public static Hashtable StateIDToStateCodeHashtable()
        {
            Hashtable StateNameToStateCodehashtable = new Hashtable(58);
            StateNameToStateCodehashtable.Add("alabama", "AL");
            StateNameToStateCodehashtable.Add("1", "AL");
            StateNameToStateCodehashtable.Add("2", "AK");
            StateNameToStateCodehashtable.Add("3", "AZ");
            StateNameToStateCodehashtable.Add("4", "AR");
            StateNameToStateCodehashtable.Add("5", "CA");
            StateNameToStateCodehashtable.Add("6", "CO");
            StateNameToStateCodehashtable.Add("7", "CT");
            StateNameToStateCodehashtable.Add("8", "DE");
            StateNameToStateCodehashtable.Add("9", "DC");
            StateNameToStateCodehashtable.Add("10", "FL");
            StateNameToStateCodehashtable.Add("11", "GA");
            StateNameToStateCodehashtable.Add("12", "HI");
            StateNameToStateCodehashtable.Add("13", "ID");
            StateNameToStateCodehashtable.Add("14", "IL");
            StateNameToStateCodehashtable.Add("15", "IN");
            StateNameToStateCodehashtable.Add("16", "IA");
            StateNameToStateCodehashtable.Add("17", "KS");
            StateNameToStateCodehashtable.Add("18", "KY");
            StateNameToStateCodehashtable.Add("19", "LA");
            StateNameToStateCodehashtable.Add("20", "ME");
            StateNameToStateCodehashtable.Add("21", "MD");
            StateNameToStateCodehashtable.Add("22", "MA");
            StateNameToStateCodehashtable.Add("23", "MI");
            StateNameToStateCodehashtable.Add("24", "MN");
            StateNameToStateCodehashtable.Add("25", "MS");
            StateNameToStateCodehashtable.Add("26", "MO");
            StateNameToStateCodehashtable.Add("27", "MT");
            StateNameToStateCodehashtable.Add("28", "NE");
            StateNameToStateCodehashtable.Add("29", "NV");
            StateNameToStateCodehashtable.Add("30", "NH");
            StateNameToStateCodehashtable.Add("31", "NJ");
            StateNameToStateCodehashtable.Add("32", "NM");
            StateNameToStateCodehashtable.Add("33", "NY");
            StateNameToStateCodehashtable.Add("34", "NC");
            StateNameToStateCodehashtable.Add("35", "ND");
            StateNameToStateCodehashtable.Add("36", "OH");
            StateNameToStateCodehashtable.Add("37", "OK");
            StateNameToStateCodehashtable.Add("38", "OR");
            StateNameToStateCodehashtable.Add("39", "PA");
            StateNameToStateCodehashtable.Add("40", "RI");
            StateNameToStateCodehashtable.Add("41", "SC");
            StateNameToStateCodehashtable.Add("42", "SD");
            StateNameToStateCodehashtable.Add("43", "TN");
            StateNameToStateCodehashtable.Add("44", "TX");
            StateNameToStateCodehashtable.Add("45", "UT");
            StateNameToStateCodehashtable.Add("46", "VT");
            StateNameToStateCodehashtable.Add("47", "VA");
            StateNameToStateCodehashtable.Add("48", "WA");
            StateNameToStateCodehashtable.Add("49", "WV");
            StateNameToStateCodehashtable.Add("50", "WI");
            StateNameToStateCodehashtable.Add("51", "WY");
            StateNameToStateCodehashtable.Add("52", "AA");
            StateNameToStateCodehashtable.Add("53", "AE");
            StateNameToStateCodehashtable.Add("54", "AE");
            StateNameToStateCodehashtable.Add("55", "AE");
            StateNameToStateCodehashtable.Add("56", "AE");
            StateNameToStateCodehashtable.Add("57", "AP");
            StateNameToStateCodehashtable.Add("58", "AS");
            StateNameToStateCodehashtable.Add("59", "FM");
            StateNameToStateCodehashtable.Add("60", "GU");
            StateNameToStateCodehashtable.Add("61", "MH");
            StateNameToStateCodehashtable.Add("62", "MP");
            StateNameToStateCodehashtable.Add("63", "MT");
            StateNameToStateCodehashtable.Add("64", "PR");
            StateNameToStateCodehashtable.Add("65", "PW");
            StateNameToStateCodehashtable.Add("66", "VI");
            return StateNameToStateCodehashtable;

        }

        public static Hashtable StateNameToStateCodeHashtable()
        {
            Hashtable StateNameToStateCodehashtable = new Hashtable(58);
            StateNameToStateCodehashtable.Add("alabama", "AL");
            StateNameToStateCodehashtable.Add("alaska", "AK");
            StateNameToStateCodehashtable.Add("arizona", "AZ");
            StateNameToStateCodehashtable.Add("arkansas", "AR");
            StateNameToStateCodehashtable.Add("california", "CA");
            StateNameToStateCodehashtable.Add("colorado", "CO");
            StateNameToStateCodehashtable.Add("connecticut", "CT");
            StateNameToStateCodehashtable.Add("delaware", "DE");
            StateNameToStateCodehashtable.Add("district of columbia", "DC");
            StateNameToStateCodehashtable.Add("florida", "FL");
            StateNameToStateCodehashtable.Add("georgia", "GA");
            StateNameToStateCodehashtable.Add("hawaii", "HI");
            StateNameToStateCodehashtable.Add("idaho", "ID");
            StateNameToStateCodehashtable.Add("illinois", "IL");
            StateNameToStateCodehashtable.Add("indiana", "IN");
            StateNameToStateCodehashtable.Add("iowa", "IA");
            StateNameToStateCodehashtable.Add("kansas", "KS");
            StateNameToStateCodehashtable.Add("kentucky", "KY");
            StateNameToStateCodehashtable.Add("louisiana", "LA");
            StateNameToStateCodehashtable.Add("maine", "ME");
            StateNameToStateCodehashtable.Add("maryland", "MD");
            StateNameToStateCodehashtable.Add("massachusetts", "MA");
            StateNameToStateCodehashtable.Add("michigan", "MI");
            StateNameToStateCodehashtable.Add("minnesota", "MN");
            StateNameToStateCodehashtable.Add("mississippi", "MS");
            StateNameToStateCodehashtable.Add("missouri", "MO");
            StateNameToStateCodehashtable.Add("montana", "MT");
            StateNameToStateCodehashtable.Add("nebraska", "NE");
            StateNameToStateCodehashtable.Add("nevada", "NV");
            StateNameToStateCodehashtable.Add("new hampshire", "NH");
            StateNameToStateCodehashtable.Add("new jersey", "NJ");
            StateNameToStateCodehashtable.Add("new mexico", "NM");
            StateNameToStateCodehashtable.Add("new york", "NY");
            StateNameToStateCodehashtable.Add("north carolina", "NC");
            StateNameToStateCodehashtable.Add("north dakota", "ND");
            StateNameToStateCodehashtable.Add("ohio", "OH");
            StateNameToStateCodehashtable.Add("oklahoma", "OK");
            StateNameToStateCodehashtable.Add("oregon", "OR");
            StateNameToStateCodehashtable.Add("pennsylvania", "PA");
            StateNameToStateCodehashtable.Add("rhode island", "RI");
            StateNameToStateCodehashtable.Add("south carolina", "SC");
            StateNameToStateCodehashtable.Add("south dakota", "SD");
            StateNameToStateCodehashtable.Add("tennessee", "TN");
            StateNameToStateCodehashtable.Add("texas", "TX");
            StateNameToStateCodehashtable.Add("utah", "UT");
            StateNameToStateCodehashtable.Add("vermont", "VT");
            StateNameToStateCodehashtable.Add("virginia", "VA");
            StateNameToStateCodehashtable.Add("washington", "WA");
            StateNameToStateCodehashtable.Add("west virginia", "WV");
            StateNameToStateCodehashtable.Add("wisconsin", "WI");
            StateNameToStateCodehashtable.Add("wyoming", "WY");
            return StateNameToStateCodehashtable;

        }
        #endregion State Value Hash Table

        #region Country Value Hash Table

        public static Hashtable CountryNameToCountryCodeHashtable()
        {
            Hashtable CountryNameToCountryCodehashtable = new Hashtable(3);
            CountryNameToCountryCodehashtable.Add("canada", "CN");
            CountryNameToCountryCodehashtable.Add("mexico", "MX");
            return CountryNameToCountryCodehashtable;
        }
        #endregion

        #region Get Months In Hashtable
        public static Hashtable GetMonthsInHashtable()
        {
            Hashtable htMonths = new Hashtable(12);
            htMonths.Add("january", "01");
            htMonths.Add("february", "02");
            htMonths.Add("march", "03");
            htMonths.Add("april", "04");
            htMonths.Add("may", "05");
            htMonths.Add("june", "06");
            htMonths.Add("july", "07");
            htMonths.Add("august", "08");
            htMonths.Add("september", "09");
            htMonths.Add("october", "10");
            htMonths.Add("november", "11");
            htMonths.Add("december", "12");
            return htMonths;
        }
        #endregion

        #region Serialize

        public static string Serialize(object seralizedObject)
        {
            string serializedData = string.Empty;
            if (seralizedObject != null)
            {
                StringWriter strWriter = new StringWriter();
                XmlSerializer serializer = new XmlSerializer((seralizedObject).GetType());
                serializer.Serialize(strWriter, seralizedObject);
                serializedData = strWriter.ToString();
                serializedData = serializedData.Replace("xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", "xmlns:efile=\"http://www.irs.gov/efile\"");
                StringReader str = new StringReader(serializedData);
                XmlDocument doc = new XmlDocument();
                doc.Load(str);
                StringWriter sw = new StringWriter();
                XmlTextWriter xw = new XmlTextWriter(sw);
                doc.WriteTo(xw);
                serializedData = sw.ToString();
            }
            return serializedData;
        }
        #endregion

        #region Deserialize

        public static Object DeSerialize(string xml, Type type)
        {
            try
            {
                object serializedObject;
                using (StringReader reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(type);
                    serializedObject = serializer.Deserialize(reader);
                }
                return serializedObject;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region String Amount Rounding
        public static string StringAmountRounding(string amount)
        {
            double dblAmount = 0;
            double.TryParse(amount, out dblAmount);
            dblAmount = Math.Round(dblAmount);
            int intAmount = 0;
            int.TryParse(dblAmount.ToString(), out intAmount);
            return intAmount.ToString();
        }
        #endregion

        #region Get Name Control
        public static string GetNameControl(string bussinessName, string businessType)
        {
            StringBuilder sb = new StringBuilder();
            string[] myBusinessArray;
            string myBusinessName = string.Empty;
            int myBusinessCount = 0;
            string nameControl = string.Empty;


            myBusinessName = bussinessName.ToUpper();

            //remove "DBA" and "FBO" from name
            if (myBusinessName.Contains("DBA"))
                myBusinessName = myBusinessName.Replace("DBA", "");

            if (myBusinessName.Contains("FBO"))
                myBusinessName = myBusinessName.Replace("FBO", "");

            for (int i = 0; i < myBusinessName.Length; i++)
            {
                if (char.IsLetterOrDigit(myBusinessName[i]) || myBusinessName[i].ToString() == "-" || myBusinessName[i].ToString() == "&")
                {
                    sb.Append(myBusinessName[i]);
                }
            }
            myBusinessArray = myBusinessName.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            myBusinessCount = myBusinessArray.Length;

            switch (businessType.ToUpper())
            {
                case "SPRO":
                    nameControl = GetNameControlForSoleProprietor(myBusinessName, myBusinessArray, sb.ToString());
                    break;

                case "CORP":
                    nameControl = GetNameControlForCorporations(myBusinessName, myBusinessArray, sb.ToString());
                    break;

                default:
                    nameControl = GetNameControlForCorporations(myBusinessName, myBusinessArray, sb.ToString());
                    break;
            }

            return nameControl;
        }

        public static string GetNameControlForCorporations(string businessName, string[] businessNameArray, string formatedBusinessName)
        {
            int myBusinessCount = 0;
            string nameControl = string.Empty;
            myBusinessCount = businessNameArray.Length;
            if (myBusinessCount <= 2)
            {
                if (businessName.Length >= 4)
                {
                    nameControl = formatedBusinessName.ToString().Substring(0, 4);
                    return nameControl;
                }
                else
                {
                    nameControl = businessName;
                    return nameControl;
                }

            }
            else if ((businessNameArray[0].ToUpper() == "THE"))
            {
                if (businessNameArray[1].Length >= 4)
                {
                    nameControl = businessNameArray[1].Substring(0, 4);
                    return nameControl;
                }
                else
                {
                    nameControl = formatedBusinessName.ToString().Substring(3, 4);
                    return nameControl;
                }
            }
            else
            {
                nameControl = formatedBusinessName.ToString().Substring(0, 4);
                return nameControl;
            }
        }

        public static string GetNameControlForSoleProprietor(string businessName, string[] businessNameArray, string formatedBusinessName)
        {
            int myBusinessCount = 0;
            string nameControl = string.Empty;
            myBusinessCount = businessNameArray.Length;

            string nameLastPart = businessNameArray[myBusinessCount - 1].ToUpper();

            if (nameLastPart.Equals("JR") || nameLastPart.Equals("SR") || nameLastPart.Equals("I") || nameLastPart.Equals("II"))
            {
                businessNameArray[myBusinessCount - 1] = null;
                myBusinessCount -= 1;
            }

            string lastName = string.Empty;

            if (myBusinessCount > 1)
            {
                lastName = businessNameArray[myBusinessCount - 1].ToString();
            }
            else
            {
                lastName = businessNameArray[0];
            }

            if (lastName.Length >= 4)
            {
                nameControl = lastName.Substring(0, 4);
            }
            else
            {
                nameControl = lastName;
            }

            //If sole properieter Name Contans (LLC/LLP/INC), consier it like a corporate
            string nameControlCorp = nameControl.ToUpper();
            if (nameControlCorp == "LLC" || nameControlCorp == "LLP" || nameControlCorp == "INC")
            {
                nameControl = GetNameControlForCorporations(businessName, businessNameArray, formatedBusinessName);
            }

            return nameControl;
        }
        #endregion

        #region Remove Hyphens
        public static string RemoveHyphens(string Value)
        {
            Value = Value.Replace("-", "");
            return Value.Trim();
        }
        #endregion

        #region Get BusinessName
        public static string GetBusinessName(string businessName)
        {
            businessName = businessName.Replace(",", "");
            businessName = businessName.Replace(".", "");
            businessName = businessName.Replace("*", "");
            businessName = businessName.Replace("  ", " ");
            return businessName.Trim();
        }
        #endregion

        #region Get Address
        public static string GetAddress(string address)
        {
            address = address.Replace(",", " ");
            address = address.Replace(":", " ");
            address = address.Replace("-", " ");
            address = address.Replace("#", " ");
            address = address.Replace(".", " ");
            address = address.Replace("   ", " ");
            address = address.Replace("  ", " ");
            address = address.Replace("  ", " ");
            return address.Trim();
        }
        #endregion

        #region Get Phone number
        public static string EditPhoneNumber(string phoneNo)
        {
            phoneNo = phoneNo.Replace("-", "");
            phoneNo = phoneNo.Replace("(", "");
            phoneNo = phoneNo.Replace(")", "");
            return phoneNo.Trim();
        }
        #endregion

        #region Get Submission ID

        public static string GetSubmissionID(string EFIN, int frmCode, string IRSUserName, long TodaysCountforSubmissionId)
        {
            string submissionID = string.Empty;
            submissionID = EFIN + DateTime.Now.Year;
            string Days = DateTime.Now.DayOfYear.ToString("000");
            submissionID = submissionID + Days;
            submissionID = submissionID + frmCode.ToString();
            IRSUserName = IRSUserName.Substring(IRSUserName.Length - 1, 1);
            submissionID = submissionID + IRSUserName;

            string Count = string.Empty;
            Count = Convert.ToString(TodaysCountforSubmissionId + 1);
            while (Count.Length < 5)
            {
                Count = '0' + Count;
            }
            submissionID = submissionID + Count;
            return submissionID;
        }
        #endregion

        #region Get Return ID

        public static string GetReturnID(string EFIN, int frmCode, string IRSUserName, long CountforReturnId)
        {
            string submissionID = string.Empty;
            submissionID = EFIN + DateTime.Now.Year;
            string Days = DateTime.Now.DayOfYear.ToString("000");
            submissionID = submissionID + Days;
            submissionID = submissionID + frmCode.ToString();
            IRSUserName = IRSUserName.Substring(IRSUserName.Length - 1, 1);
            submissionID = submissionID + IRSUserName;

            string Count = string.Empty;
            Count = Convert.ToString(CountforReturnId + 1);
            while (Count.Length < 5)
            {
                Count = '0' + Count;
            }
            submissionID = submissionID + Count;
            return submissionID;
        }
        #endregion

        #region Format Quarter Ending
        public static string FormatQuarterEnding(string quarterEnding)
        {
            if (quarterEnding.Contains("March"))
            {
                quarterEnding = quarterEnding.Replace("March ", "");
                quarterEnding = quarterEnding + "-03";
            }
            else if (quarterEnding.Contains("June"))
            {
                quarterEnding = quarterEnding.Replace("June ", "");
                quarterEnding = quarterEnding + "-06";
            }
            else if (quarterEnding.Contains("September"))
            {
                quarterEnding = quarterEnding.Replace("September ", "");
                quarterEnding = quarterEnding + "-09";
            }
            else if (quarterEnding.Contains("December"))
            {
                quarterEnding = quarterEnding.Replace("December ", "");
                quarterEnding = quarterEnding + "-12";
            }
            return quarterEnding;
        }
        #endregion

        #region Get Quarter Start Date
        public static string GetQuarterStartDate(string quarterEnding)
        {
            string startDate = string.Empty;
            if (quarterEnding.Contains("March"))
            {
                startDate = "2007-01-01";
            }
            else if (quarterEnding.Contains("June"))
            {
                startDate = "2007-04-01";
            }
            else if (quarterEnding.Contains("September"))
            {
                startDate = "2007-07-01";
            }
            else if (quarterEnding.Contains("December"))
            {
                startDate = "2007-10-01";
            }
            return startDate;
        }
        #endregion

        #region Get Quarter End Date
        public static string GetQuarterEndDate(string quarterEnding)
        {
            string endDate = string.Empty;
            if (quarterEnding.Contains("March"))
            {
                endDate = "2007-03-31";
            }
            else if (quarterEnding.Contains("June"))
            {
                endDate = "2007-06-30";
            }
            else if (quarterEnding.Contains("September"))
            {
                endDate = "2007-09-30";
            }
            else if (quarterEnding.Contains("December"))
            {
                endDate = "2007-12-31";
            }
            return endDate;
        }
        #endregion

        #region Explanation Remove Space
        public static string ExplanationRemoveSpace(string explanation)
        {
            string strSpace = explanation.Trim();

            while (strSpace.Contains("  "))
            {
                strSpace = strSpace.Replace("  ", " ");
            }
            return strSpace;
        }
        #endregion

        #region Get Software Id
        public static string GetSoftwareId()
        {
            return ConfigurationManager.AppSettings["720_SoftwareId"].ToString();
        }
        #endregion

        /// <summary>
        /// Determines whether the SSN no is valid.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified phone number is valid; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsValidITIN(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                string ssnVal = RemoveCloseBracket(value);
                ssnVal = RemoveOpenBracket(ssnVal);
                ssnVal = RemoveHiphen(ssnVal);

                if (ssnVal.Length == Constants.SSNLength && IsNumeric(ssnVal))
                {

                    int firstDigit = int.Parse(ssnVal.Substring(0, 1));
                    string fourthandFiftDigit = ssnVal.Substring(3, 2);

                    int fourthandFiftDigits = int.Parse(fourthandFiftDigit);
                    if (firstDigit == 9 && fourthandFiftDigits >= 70 && fourthandFiftDigits <= 99 && fourthandFiftDigits != 89 && fourthandFiftDigits != 93)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

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

        #region Get Software Version
        public static string GetSoftwareVersion()
        {
            return ConfigurationManager.AppSettings["SoftwareVersion"].ToString();
        }
        #endregion

        #region Convert Double To String
        public static string GetStringFromDouble(double tax)
        {
            return tax.ToString();
        }
        #endregion

        #region Write Exception Log
        public static void WriteException(IRSSchemaDE objIRSSchemaDE, Exception ex, EventLog eventLog1)
        {
            string submissionId = " *** ";
            string holdId = " *** ";
            string schemaId = " *** ";
            if (!string.IsNullOrEmpty(objIRSSchemaDE.SubmissionId))
            {
                submissionId = objIRSSchemaDE.SubmissionId;
            }
            if (objIRSSchemaDE.EfileHoldID > 0
                    && !string.IsNullOrEmpty(objIRSSchemaDE.EfileHoldID.ToString()))
            {
                holdId = objIRSSchemaDE.EfileHoldID.ToString();
            }
            schemaId = "--";
            if (objIRSSchemaDE.EfileIRSSchemaID > 0
                    && !string.IsNullOrEmpty(objIRSSchemaDE.EfileIRSSchemaID.ToString()))
            {
                schemaId = objIRSSchemaDE.EfileIRSSchemaID.ToString();
            }

            string exceptValues = string.Format("Submission Id= {0} ******* Hold Id = {1} ****** Schema Id = {2} ", submissionId, holdId, schemaId);
            eventLog1.WriteEntry(exceptValues + "\n" + ex.Message + " " + "\n" + ex.ToString() + "\n" + ex.StackTrace, EventLogEntryType.Error);
        }
        #endregion


    }

    //public struct Stage
    //{
    //    public const string XVAL = "XVAL";
    //    public const string CONV = "CONV";
    //}

    //public struct State
    //{
    //    public const string Blank = "Blank";
    //    public const string Error = "Error";
    //    public const string Success = "Success";
    //}
}