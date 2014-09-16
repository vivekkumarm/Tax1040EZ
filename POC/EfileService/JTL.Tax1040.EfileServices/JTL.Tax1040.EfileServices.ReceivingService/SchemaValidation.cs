using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class SchemaValidation
    {
        #region Declaration
        SchemaValidationBL schemaValidationBL;
        MessagesDE messagesDE;
        #endregion


        #region Start Validation
        public void StartValidation()
        {
            try
            {
                SchemaValidationBL schemaValidationBL = new SchemaValidationBL();
                ValidateSchema validateSchema;

                //Retrieving all values for validation state=success stage=CONV
                DataSet ds = schemaValidationBL.GetHoldDATA(State.Success, Stage.CONV);
                string strHoldId = string.Empty;
                string strSubmissionId = string.Empty;
                string strIRSSchema = string.Empty;
                string strXsdPath = string.Empty;
                string strNamespace = string.Empty;
                string strTaxYear = string.Empty;
                string strTaxPeriod = string.Empty;

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            try
                            {
                                if (dr[Utilities.constants.Taxyear] != null)
                                {
                                    strTaxYear = dr[Utilities.constants.Taxyear].ToString();
                                }
                                if (dr[Utilities.constants.Taxperiod] != null)
                                {
                                    strTaxPeriod = dr[Utilities.constants.Taxperiod].ToString();
                                }

                                string ReturnType = dr[Utilities.constants.TaxReturnTypeID].ToString();

                                if (!string.IsNullOrEmpty(strTaxYear) && !string.IsNullOrEmpty(strTaxPeriod))
                                {
                                    strXsdPath = schemaValidationBL.GetSchemaVersion(ReturnType, strTaxYear, strTaxPeriod);
                                }
                                strXsdPath = schemaValidationBL.GetSchemaVersion(ReturnType, strTaxYear, strTaxPeriod);

                                if (dr[Utilities.constants.EfileHoldID] != null)
                                {
                                    strHoldId = dr[Utilities.constants.EfileHoldID].ToString();
                                }
                                if (dr[Utilities.constants.SubmissionID] != null)
                                {
                                    strSubmissionId = dr[Utilities.constants.SubmissionID].ToString();
                                }
                                if (dr[Utilities.constants.EfileIRSSchema] != null)
                                {
                                    strIRSSchema = dr[Utilities.constants.EfileIRSSchema].ToString();
                                }

                                if (ConfigurationManager.AppSettings[Utilities.constants.SchemaNamespace] != null)
                                {
                                    strNamespace = ConfigurationManager.AppSettings[Utilities.constants.SchemaNamespace].ToString();
                                }

                                if (!string.IsNullOrEmpty(strXsdPath) && !string.IsNullOrEmpty(strNamespace) && !string.IsNullOrEmpty(strIRSSchema) && !string.IsNullOrEmpty(strHoldId))
                                {
                                    validateSchema = new ValidateSchema();
                                    List<MessagesDE> lstMessageDE = new List<MessagesDE>();

                                    //Initial status update status=BLANK stage=XVAL
                                    schemaValidationBL.statusUpdate("", 0, Stage.XVAL, State.Blank, strHoldId);

                                    //Validating XML against 
                                    lstMessageDE = validateSchema.ValidateXML(strIRSSchema, strNamespace, strXsdPath);

                                    if (lstMessageDE != null && lstMessageDE.Count > 0)
                                    {
                                        //Updating Status if Validation error exists
                                        schemaValidationBL.statusUpdate("", 0, Stage.XVAL, State.Error, strHoldId);

                                        //Adding error to DB
                                        foreach (MessagesDE message in lstMessageDE)
                                        {
                                            LogEfileError(message.ErrorMessage, strSubmissionId);
                                        }

                                        //Sending Mail with all Errors
                                        SendAlertMail(lstMessageDE, strSubmissionId, ReturnType);
                                    }
                                    else
                                    {
                                        //Updating Status if Validation passed
                                        schemaValidationBL.statusUpdate("", 0, Stage.XVAL, State.Success, strHoldId);

                                    }
                                }
                                else
                                {
                                    //eventLog1.WriteEntry("Required attribute missing for submissionId: " + strSubmissionId
                                    //    + " \n XSD path: " + strXsdPath + " \n Namespace: " + strNamespace + " \n IRSSchema: " + strIRSSchema +
                                    //    " \n HoldId: " + strHoldId);
                                }
                            }
                            catch (Exception ex)
                            {
                              //  eventLog1.WriteEntry(ex.ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               // eventLog1.WriteEntry(ex.ToString());
            }

        }
        #endregion

        #region LogEfileError

        void LogEfileError(string strMessage, string strId)
        {
            messagesDE = new MessagesDE();
            schemaValidationBL = new SchemaValidationBL();
            messagesDE = new MessagesDE();
            messagesDE.ErrorMessage = strMessage;
            if (strMessage.Contains(Utilities.constants.Namespace))
            {
                int index = strMessage.IndexOf(Utilities.constants.Namespace);
                index = index + 25;
                if (strMessage.Length > index)
                {
                    string strSub = strMessage.Substring(index);
                    strSub = strSub.Substring(0, strSub.IndexOf("\'"));
                    messagesDE.ErrorType = strSub;
                }
            }
            messagesDE.Action = Utilities.constants.ActionType;
            messagesDE.SubmissionID = strId;
            schemaValidationBL.EfileIRSErrorCreate(messagesDE);
        }
        #endregion

        #region Send Alert Mail
        void SendAlertMail(List<MessagesDE> lstMessage, string strSubmissionId, string ReturnType)
        {
            try
            {
                string strMessage = string.Empty;
                strMessage = strMessage + "Schema Validation Failed for Submission ID : " + strSubmissionId;
                foreach (MessagesDE msg in lstMessage)
                {
                    strMessage = strMessage + "\n" + Utilities.constants.ActionType + ":" + msg.ErrorMessage;
                }

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
                    string Subject = string.Empty;
                    if (!string.IsNullOrEmpty(host)
                        && !string.IsNullOrEmpty(frommail)
                        && !string.IsNullOrEmpty(tomail)
                        && !string.IsNullOrEmpty(bccmail)
                        )
                    {
                        if (!string.IsNullOrEmpty(strSubmissionId))
                        {
                            Subject = "Schema Validation -" + ReturnType + " failed for Submission Id : " + strSubmissionId;
                        }

                        String mailtxt = string.Empty;
                        mailMessage = new MailMessage();
                        mailMessage.IsBodyHtml = false;
                        mailMessage.To.Add(new MailAddress(tomail));
                        mailMessage.Bcc.Add(bccmail);
                        mailMessage.From = new MailAddress(frommail);
                        mailMessage.Subject = Subject;
                        mailMessage.Body = strMessage;
                        smtpClient = new SmtpClient(host);
                        smtpClient.Send(mailMessage);
                    }
                }
            }
            catch (Exception ex)
            {
              //  eventLog1.WriteEntry(ex.ToString());
            }
        }

        #endregion
    }
}