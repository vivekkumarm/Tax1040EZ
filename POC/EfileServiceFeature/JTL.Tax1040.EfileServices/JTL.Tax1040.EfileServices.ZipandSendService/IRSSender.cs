#region NameSpace

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Text;
using System.Collections;
using System.Security.Cryptography;

using Microsoft.Web.Services3.Security.Tokens;
using Microsoft.Web.Services3;
using Microsoft.Web.Services3.Design;
using JTL.Tax1040.EfileServices.Core.Process;

#endregion

namespace JTL.Tax1040.EfileServices.ZipandSendService.SenderChannel
{
    partial class IRSSender : ServiceBase
    {
        #region Declaration
        public static string SubmissionID = null;
        public static string MessageID = null;

        private static string loginresponsestatus = "session counter updated";
        private static string logoutresponsestatus = "session counter decremented";

        //private const string exSendSubmission = "SendSubmission: ";
        public UsernameToken token = null;

        private System.Timers.Timer timer = new System.Timers.Timer();

        string userName = string.Empty;
        string pwd = string.Empty;
        string eTIN = string.Empty;
        string confirmToken = string.Empty;
        string testMode = string.Empty;
        string eFIN = string.Empty;
        public string URL = string.Empty;
        public bool SubmissionError = false;
        public bool timerDisable = false;
        int timeout = 100000;
        int cmdTimeout = 120;
        bool isNotification = true;
        string notificationMessage = string.Empty;
        #endregion

        #region Constants

        internal class StringVariables
        {
            public const string UserName = "UserName";
            public const string serviceLogin = "SendSubmission-Login";
            public const string serviceLogout = "SendSubmission-Logout";
            public const string serviceAction = "SendSubmission";
        }

        internal class Errors
        {
            public const string LoginSessionErr = "Session or service connection limit reached";
        }

        #endregion

        #region Constructor

        public IRSSender()
        {
            InitializeComponent();

            //TOOD: For Testing purpose commented the below code - Saravanan N - 8th July, 2014.  -  START
            //Timer Settings
            //timer.Enabled = true;
            //timer.AutoReset = true;
            //timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            //timer.Interval = Utility.Getdouble((Utility.GetAppSettingsValue("Timer_Interval")));

            //Getting Event Log Name from App.Config
            //if (null != ConfigurationManager.AppSettings["SEND_EventLogName"])
            //{
            //    string EventLogName = ConfigurationManager.AppSettings["SEND_EventLogName"].ToString();
            //    if (!System.Diagnostics.EventLog.SourceExists(EventLogName))
            //    {
            //        System.Diagnostics.EventLog.CreateEventSource(EventLogName, EventLogName);
            //    }
            //    eventLog1.Source = EventLogName;
            //    eventLog1.Log = EventLogName;
            //}
            //else
            //{
            //    if (!System.Diagnostics.EventLog.SourceExists("7004-SEND"))
            //    {
            //        System.Diagnostics.EventLog.CreateEventSource("7004-SEND", "7004-SEND");
            //    }
            //    eventLog1.Source = "7004-SEND";
            //    eventLog1.Log = "7004-SEND";
            //}
            //TOOD: For Testing purpose commented the below code - Saravanan N - 8th July, 2014.  -  END

            
            //Commented by Sankaran Namboothiri- for WSE 3.0 upgrade
            ////Configuring Custom Filters
            //WebServicesConfiguration.FilterConfiguration.OutputFilters.Insert(0, new IRSOutputFilter());
            ////add input filter to remove saml from response
            //WebServicesConfiguration.FilterConfiguration.InputFilters.Insert(0, new IRSInputFilter());

            if (!Directory.Exists(@"c://temp"))
            {
                Directory.CreateDirectory(@"c://temp");
            }

            //get the timeout value from app settings
            int.TryParse(Utility.GetAppSettingsValue("Timeout"), out timeout);

            //get the command timeout timeout value from app settings
            int.TryParse(Utility.GetAppSettingsValue("CommandTimeout"), out cmdTimeout);
        }
        #endregion

        #region Get Security Information

        private bool LoadSecurityInfo()
        {
            try
            {
                IRSSenderBL objIRSSenderBL = new IRSSenderBL();
                Hashtable htSecurityInfo = objIRSSenderBL.GetSecurityInfo(FormType.Form1040EZ);
                if (htSecurityInfo != null && htSecurityInfo.Count > 0)
                {
                    if (htSecurityInfo.Contains("UserName") && !string.IsNullOrEmpty(htSecurityInfo["UserName"].ToString()))
                    {
                        userName = htSecurityInfo["UserName"].ToString();
                    }
                    else
                        return false;
                    if (htSecurityInfo.Contains("Password") && !string.IsNullOrEmpty(htSecurityInfo["Password"].ToString()) && htSecurityInfo.Contains("EncryptKey") && !string.IsNullOrEmpty(htSecurityInfo["EncryptKey"].ToString()))
                    {
                        pwd = DecryptData(htSecurityInfo["Password"].ToString(), htSecurityInfo["EncryptKey"].ToString());
                        if (string.IsNullOrEmpty(pwd))
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                    if (htSecurityInfo.Contains("ETIN") && !string.IsNullOrEmpty(htSecurityInfo["ETIN"].ToString()))
                    {
                        eTIN = htSecurityInfo["ETIN"].ToString();
                    }
                    else
                        return false;
                    if (htSecurityInfo.Contains("ConfirmationToken") && !string.IsNullOrEmpty(htSecurityInfo["ConfirmationToken"].ToString()))
                    {
                        confirmToken = htSecurityInfo["ConfirmationToken"].ToString();
                    }
                    else
                        return false;
                    if (htSecurityInfo.Contains("TestIndicator") && !string.IsNullOrEmpty(htSecurityInfo["TestIndicator"].ToString()))
                    {
                        testMode = htSecurityInfo["TestIndicator"].ToString();

                        //validate the machine name for production server.
                        //if the test mode is production check for the server name. if the server is different than prod server
                        //then don't send the return.
                        if (testMode == Constants.Production)
                        {
                            if (Environment.MachineName.ToString() != Constants.ServerName)
                            {
                                return false;
                            }
                        }
                    }
                    else
                        return false;
                    if (htSecurityInfo.Contains("EFIN") && !string.IsNullOrEmpty(htSecurityInfo["EFIN"].ToString()))
                    {
                        eFIN = htSecurityInfo["EFIN"].ToString();
                    }
                    else
                        return false;
                    if (htSecurityInfo.Contains("laURL") && !string.IsNullOrEmpty(htSecurityInfo["laURL"].ToString()))
                    {
                        URL = htSecurityInfo["laURL"].ToString();
                    }
                    else
                        return false;

                }
                else
                {
                    return false;
                }
                return true;

                //userName = ConfigurationManager.AppSettings["UserName"].ToString();
                //pwd = ConfigurationManager.AppSettings["Password"].ToString();
                //eTIN = ConfigurationManager.AppSettings["ETIN"].ToString();
                //confirmToken = ConfigurationManager.AppSettings["ConfirmationToken"].ToString();
                //testMode = ConfigurationManager.AppSettings["TestMode"].ToString();
                //eFIN = ConfigurationManager.AppSettings["EFIN"].ToString();
                //if (ConfigurationManager.AppSettings["laURL"] != null)
                //{
                //    URL = ConfigurationManager.AppSettings["laURL"].ToString();
                //}

            }
            catch (Exception ex)
            {
                //eventLog1.WriteEntry(ex.Message + " **** " + ex.ToString(), EventLogEntryType.Error);
                return false;
            }
        }
        #endregion

        #region Configure Proxy

        private void ConfigureProxy(WebServicesClientProtocol proxy)
        {

            //Commented by Sankaran Namboothiri- for WSE 3.0 upgrade 
            //this.token = new UsernameToken(userName, pwd, PasswordOption.SendPlainText);
            //proxy.RequestSoapContext.Security.Tokens.Add(token);

            //New policy settings for WSE 3.0
            RemoveAddressingHeadersAssertion assert = new RemoveAddressingHeadersAssertion(userName, pwd);
            Policy policy = new Policy();
            policy.Assertions.Add(assert);
            proxy.SetPolicy(policy);
        }
        #endregion

        #region Timer Elapsed Evet

        public void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //disabe the timer to avoid unwanted call before completion of process.
            timer.Enabled = false;

            //Start the Service for the Time Interval given
            StartService();

            //enable the timer, if the process completes.
            if (!timerDisable)
            {
                timer.Enabled = true;
            }
            else
            {
                Utility.SendMail("Timer Disabled - SendSubmission - ", null);
            }
        }
        #endregion

        #region StartService Function

        //StartService Method - 
        public void StartService()
        {
            if (LoadSecurityInfo())
            {
                SendSubmission();
            }
            else
            {
                timerDisable = true;
            }
        }
        #endregion

        #region Fill MefHeader Login
        // Fills the mef header for Login.

        private JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.MeFHeaderType FillMefHeaderLogin()
        {
            //this methodfills the values for Mef header(Login).
            JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.MeFHeaderType meF = new JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.MeFHeaderType();
            meF.MessageID = Utility.GetMessageID(eTIN);
            MessageID = meF.MessageID;
            meF.Action = Constants.Login;
            meF.Timestamp = DateTime.Now;
            meF.ETIN = eTIN;
            meF.SessionIndicator = JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.SessionIndicatorType.Y;
            meF.SessionIndicatorSpecified = true;
            //if the test mode is ON
            if (testMode.ToUpper() == TestMode.Prod)
            {
                meF.TestIndicator = JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.TestIndicatorType.P;
            }
            else
            {
                meF.TestIndicator = JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.TestIndicatorType.T;
            }
            meF.TestIndicatorSpecified = true;
            meF.AppSysID = userName;
            return meF;
        }
        #endregion

        #region Login
        //Login() will not update 
                //efile_current_status or
                //efile_progress tables.
        private bool Login()
        {
            bool IsAuthenticated = false;
            try
            {
                IRSInputFilter.SAMLDocument = null;
                JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.Login loginService = new JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.Login();
                loginService.Url = URL + "Login";
                ConfigureProxy(loginService);
                loginService.MeF = FillMefHeaderLogin();
                JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.LoginRequestType loginRequest = new JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.LoginRequestType();
                JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.LoginResponseType loginResponse = new JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.LoginResponseType();
                //Calls the Web Method "CallLogin"
                loginResponse = loginService.CallLogin(loginRequest);
                //Gets the response status
                if (!string.IsNullOrEmpty(loginResponse.Status))
                {
                    if (loginResponse.Status.ToLower() == loginresponsestatus)
                    {
                        if (loginService.MeF != null && loginService.MeF.NotificationResponse != null)
                        {
                            if (!string.IsNullOrEmpty(loginService.MeF.NotificationResponse.NotificationType))
                            {
                                notificationMessage = loginService.MeF.NotificationResponse.NotificationType;
                                isNotification = true;
                            }
                        }
                        IsAuthenticated = true;
                    }
                }
            }
            catch (Exception ex)
            {
                eventLog1.WriteEntry(ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                SetRequestResponseforLogin(IsAuthenticated);
            }
            return IsAuthenticated;
        }
        #endregion

        #region Set Request, Response for Login
        private void SetRequestResponseforLogin(bool IsAuthenticated)
        {
            //Store the Request XML, Response XML and Error to DB
            IRSSenderDE objIRSSenderDE = new IRSSenderDE();
            objIRSSenderDE.RequestXML = IRSOutputFilter.RequestXML;
            objIRSSenderDE.ResponseXML = IRSInputFilter.ResponseXML;


            objIRSSenderDE.MessageID = MessageID;
            IRSErrorDE objIRSErrorDE = new IRSErrorDE();
            
            //Store the IRSResponseXML error messages into DB.
            objIRSErrorDE = GetErrorMessageforLoginLogout(objIRSSenderDE, objIRSErrorDE);

            if (!IsAuthenticated) //TRUE - IF Exception Occurs
            {
                objIRSSenderDE.StatusID = StatusCodes.UnSuccessfullLogin;
            }
            else
            {
                if (objIRSErrorDE.IsErrorPresent)
                {
                    objIRSSenderDE.StatusID = StatusCodes.UnSuccessfullLogin;
                }
                else
                {
                    objIRSSenderDE.StatusID = StatusCodes.SuccessfullLogin;
                }
            }
            if (objIRSErrorDE.IsErrorPresent)
            {
                objIRSErrorDE.Action = "Login";
            }
            objIRSSenderDE.Error = objIRSErrorDE;
            objIRSSenderDE.ServiceAction = StringVariables.serviceLogin;
            StoreRequestResponseXMLSubmissionError(objIRSSenderDE);
            if (string.IsNullOrEmpty(IRSInputFilter.ResponseXML))
            {
                timerDisable = true;
            }
            NULLRequestXMLResponseXML();
        }
        #endregion

        #region Get Error from XML for Login

        private IRSErrorDE GetErrorMessageforLoginLogout(IRSSenderDE objIRSSenderDE, IRSErrorDE objIRSErrorDE)
        {
            try
            {
                XmlTextReader reader = null;
                // load the file from the URL
                if (!string.IsNullOrEmpty(objIRSSenderDE.ResponseXML))
                {
                    Stream XMLstream = new MemoryStream(ASCIIEncoding.Default.GetBytes(objIRSSenderDE.ResponseXML));
                    reader = new XmlTextReader(XMLstream);
                    object objErrorMessage = reader.NameTable.Add("wn1:ErrorMessage");
                    object objErrorClassification = reader.NameTable.Add("wn1:ErrorClassification");
                    object objErrorCode = reader.NameTable.Add("wn1:ErrorCode");

                    reader.WhitespaceHandling = WhitespaceHandling.None;
                    // Moves the reader to the root element.
                    reader.MoveToContent();

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name.Equals(objErrorMessage))
                            {
                                objIRSErrorDE.ErrorMessage = reader.ReadString();
                                if (objIRSErrorDE.ErrorMessage == Errors.LoginSessionErr)
                                {
                                    timerDisable = true;
                                }
                            }
                            else if (reader.Name.Equals(objErrorClassification))
                            {
                                objIRSErrorDE.ErrorClassification = reader.ReadString();
                            }
                            else if (reader.Name.Equals(objErrorCode))
                            {
                                objIRSErrorDE.ErrorCode = reader.ReadString();
                                objIRSErrorDE.IsErrorPresent = true;
                            }
                        }
                    }
                }
                else
                {
                    eventLog1.WriteEntry(objIRSSenderDE.SubmissionID + "Response XML is NULL", EventLogEntryType.FailureAudit);
                }
            }
            catch (Exception ex)
            {
                objIRSErrorDE.IsErrorPresent = true;
                eventLog1.WriteEntry(ex.Message + " " + ex.ToString(), EventLogEntryType.Error);
            }
            return objIRSErrorDE;
        }
        #endregion

        #region NULL RequestXML, ResponseXML

        private void NULLRequestXMLResponseXML()
        {
            IRSOutputFilter.RequestXML = null;
            IRSInputFilter.ResponseXML = null;
        }
        #endregion

        #region Fill MefHeader Send Submission

        /// Fills the mef header send submissions.
        private JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.MeFHeaderType FillMefHeaderSendSubmissions(string messageID)
        {
            //this methodfills the values for Mef header(InitialLogin).
            JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.MeFHeaderType meF = new JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.MeFHeaderType();
            meF.MessageID = messageID;
            MessageID = messageID;
            meF.Action = "SendSubmissions";
            meF.Timestamp = DateTime.Now;
            meF.ETIN = eTIN;
            meF.SessionIndicator = JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.SessionIndicatorType.Y;
            meF.SessionIndicatorSpecified = true;
            if (testMode.ToUpper() == TestMode.Prod)
            {
                meF.TestIndicator = JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.TestIndicatorType.P;
            }
            else
            {
                meF.TestIndicator = JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.TestIndicatorType.T;
            }
            meF.TestIndicatorSpecified = true;
            meF.AppSysID = userName;
            return meF;
        }
        #endregion

        #region Send Submissions

        private void SendSubmission()
        {
            try
            {
                IRSSenderBL objIRSSenderBL = new IRSSenderBL();
                DataSet dsEfileSender = new DataSet();
                dsEfileSender = objIRSSenderBL.GetAllEfileSender(Constants.Zipp, State.Success, cmdTimeout);
                if (dsEfileSender != null && dsEfileSender.Tables.Count > 0 && dsEfileSender.Tables[0].Rows.Count > 0)
                {
                    if (Login())
                    {
                        timer.Enabled = false;
                        foreach (DataRow dr in dsEfileSender.Tables[0].Rows)
                        {
                            if (dr["DimeAttachment"] != null && dr["SubmissionID"] != null)
                            {
                                if (isNotification)
                                {
                                    string strSubmissionID = dr["SubmissionID"].ToString();
                                    strSubmissionID = strSubmissionID.Substring(strSubmissionID.Length - 4);
                                    long subID = 0;
                                    long.TryParse(strSubmissionID.ToString(), out subID);
                                    if (subID == 1)
                                    {
                                        Utility.SendMail(notificationMessage, string.Empty);
                                    }
                                }


                                objIRSSenderBL.SetStatus(dr["SubmissionID"].ToString(), JTL.Tax1040.EfileServices.Core.Process.Stage.Send, State.Blank);
                                Submit(dr);
                            }
                        }
                        LogOut();
                    }
                    else
                    {
                        Utility.SendMail("Login Failed - SendSubmission", string.Empty);
                        eventLog1.WriteEntry("Login Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                WriteException(IRSSender.SubmissionID, ex);
            }
        }
        #endregion


        #region Send a Submission

        private void Submit(DataRow dr)
        {
            bool IsSubmitted = false;
            try
            {
                IRSSenderDE objIRSSenderDE = new IRSSenderDE();
                objIRSSenderDE.MessageID = Utility.GetMessageID(eTIN);
                objIRSSenderDE.SubmissionID = dr["SubmissionID"].ToString();
                MessageID = objIRSSenderDE.MessageID;
                SubmissionID = objIRSSenderDE.SubmissionID; // Storing Globally to get the value in the OutPut Filter

                mSendSubmissions sendSubmissions = new mSendSubmissions();
                sendSubmissions.Url = URL + "mtom/SendSubmissions";
                ConfigureProxy(sendSubmissions);
                sendSubmissions.MeF = FillMefHeaderSendSubmissions(objIRSSenderDE.MessageID);

                JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.SendSubmissionsRequestType request = CreateRequest(dr);
                if (request.SubmissionsAttachmentMTOM != null)
                {
                    JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.SendSubmissionsResponseType response = new JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.SendSubmissionsResponseType();

                    //assign proxy timeout 
                    sendSubmissions.Timeout = timeout;
                    sendSubmissions.RequireMtom = true;

                    response = sendSubmissions.CallSendSubmissions(request);
                    //get the submission attachment from IRS
                    if (response != null)
                    {
                        if (response.SubmissionReceiptListAttachmentMTOM != null)
                        {
                            objIRSSenderDE.StatusID = StatusCodes.ZipSentToIRS;
                            objIRSSenderDE.SendSubmissionStatus = response.SubmissionReceiptListAttachmentMTOM.Value;
                            
                            //SEND STATE initial status will be updated here.
                            StoreSendSubmissionStatus(objIRSSenderDE, JTL.Tax1040.EfileServices.Core.Process.Stage.Send, State.Success);
                            IsSubmitted = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //IsSubmitted = false;
                string submissionId = string.Empty;
                if (null != dr["SubmissionID"])
                {
                    submissionId = dr["SubmissionID"].ToString();
                }
                WriteException(submissionId, ex);
            }
            finally
            {
                //SEND STATE final status will be updated here.
                SetRequestResponseforSubmission(IsSubmitted);
            }
        }



        private JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.SendSubmissionsRequestType CreateRequest(DataRow dr)
        {
            IRSSenderDE objIRSSenderDE = new IRSSenderDE();
            objIRSSenderDE.MessageID = Utility.GetMessageID(eTIN);
            objIRSSenderDE.SubmissionID = dr["SubmissionID"].ToString();
            MessageID = objIRSSenderDE.MessageID;
            SubmissionID = objIRSSenderDE.SubmissionID;
            JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.SendSubmissionsRequestType request = new JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.SendSubmissionsRequestType();
            List<JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.SubmissionDataType> submissionDataList = new List<JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.SubmissionDataType>();
            JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.SubmissionDataType submissionData = new JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.SubmissionDataType();

            //assign submission id
            submissionData.SubmissionId = objIRSSenderDE.SubmissionID;
            submissionData.ElectronicPostmarkSpecified = true;
            submissionData.ElectronicPostmark = DateTime.Now;
            submissionDataList.Add(submissionData);

            request.SubmissionDataList = submissionDataList.ToArray();
            request.SubmissionsAttachmentMTOM = new JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM.base64Binary
            {
                Value = (byte[])dr["DimeAttachment"]
            };



            return request;
        }
        #endregion

        #region Set Request, Response for Submission
        private void SetRequestResponseforSubmission(bool IsSubmitted)
        {
            try
            {
                string strState = State.Error;

                //Store the Request XML, Response XML and Error to DB
                IRSSenderDE objIRSSenderDE = new IRSSenderDE();
                objIRSSenderDE.SubmissionID = IRSSender.SubmissionID;
                objIRSSenderDE.MessageID = IRSSender.MessageID;
                objIRSSenderDE.RequestXML = IRSOutputFilter.RequestXML;
                objIRSSenderDE.ResponseXML = IRSInputFilter.ResponseXML;

                IRSErrorDE objIRSErrorDE = new IRSErrorDE();
                objIRSErrorDE = GetErrorMessage(objIRSSenderDE, objIRSErrorDE);

                if (!IsSubmitted || objIRSErrorDE.IsErrorPresent) //TRUE - IF Exception Occurs or Error Present
                {
                    objIRSSenderDE.StatusID = StatusCodes.UnSuccessToSendEfile;
                }
                else
                {
                    strState = State.Success;
                    objIRSSenderDE.StatusID = StatusCodes.ZipSentToIRS;
                }
                if (objIRSErrorDE.IsErrorPresent)
                {
                    objIRSErrorDE.Action = "SendSubmission";
                    SendAlertMail(objIRSSenderDE.ResponseXML, objIRSSenderDE.SubmissionID);
                }
                if (SubmissionError)
                {
                    strState = State.Error;
                }
                objIRSSenderDE.Error = objIRSErrorDE;
                objIRSSenderDE.ServiceAction = StringVariables.serviceAction;
                StoreRequestResponseXMLSubmissionError(objIRSSenderDE);

                IRSSenderBL objIRSSenderBL = new IRSSenderBL();
                objIRSSenderBL.SetStatus(objIRSSenderDE.SubmissionID, JTL.Tax1040.EfileServices.Core.Process.Stage.Send, strState);
                NULLSubmissionIDRequestXMLResponseXML();
            }
            catch (Exception ex)
            {
                WriteException(IRSSender.SubmissionID, ex);
            }
        }
        #endregion

        #region Get Error from XML

        private IRSErrorDE GetErrorMessage(IRSSenderDE objIRSSenderDE, IRSErrorDE objIRSErrorDE)
        {
            try
            {
                XmlTextReader reader = null;
                // load the file from the URL
                if (!string.IsNullOrEmpty(objIRSSenderDE.ResponseXML))
                {
                    Stream XMLstream = new MemoryStream(ASCIIEncoding.Default.GetBytes(objIRSSenderDE.ResponseXML));
                    reader = new XmlTextReader(XMLstream);
                    object objErrorMessage = reader.NameTable.Add("ns1:ErrorMessage");
                    object objErrorClassification = reader.NameTable.Add("ns2:ErrorClassification");
                    object objErrorCode = reader.NameTable.Add("ns3:ErrorCode");

                    reader.WhitespaceHandling = WhitespaceHandling.None;
                    // Moves the reader to the root element.
                    reader.MoveToContent();

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name.Equals(objErrorMessage))
                            {
                                objIRSErrorDE.ErrorMessage = reader.ReadString();
                            }
                            else if (reader.Name.Equals(objErrorClassification))
                            {
                                objIRSErrorDE.ErrorClassification = reader.ReadString();
                            }
                            else if (reader.Name.Equals(objErrorCode))
                            {
                                objIRSErrorDE.ErrorCode = reader.ReadString();
                                objIRSErrorDE.IsErrorPresent = true;
                                if (objIRSErrorDE.ErrorCode == "X0000-015")
                                {
                                    SubmissionError = true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    eventLog1.WriteEntry(objIRSSenderDE.SubmissionID + "Response XML is NULL", EventLogEntryType.FailureAudit);
                }
            }
            catch (Exception ex)
            {
                objIRSErrorDE.IsErrorPresent = true;
                WriteException(objIRSSenderDE.SubmissionID, ex);
            }
            return objIRSErrorDE;
        }
        #endregion

        #region NULL SubmissionID, RequestXML, ResponseXML

        private void NULLSubmissionIDRequestXMLResponseXML()
        {
            IRSSender.SubmissionID = null;
            IRSSender.MessageID = null;
            IRSOutputFilter.RequestXML = null;
            IRSInputFilter.ResponseXML = null;
        }
        #endregion

        #region Store the Request, ResponseXML and SubmissionError

        //This method called from   1) SetRequestResponseforLogin (from Login() method) 
            //                      2) SetRequestResponseforLogout (from Logout() method)
            //                      3) SetRequestResponseforSubmission (from Submit() after successful Login()).
        private void StoreRequestResponseXMLSubmissionError(IRSSenderDE objIRSSenderDE)
        {
            try
            {
                IRSSenderBL objIRSSenderBL = new IRSSenderBL();
                objIRSSenderBL.SetRequestResponseXMLSubmissionError(objIRSSenderDE);
            }
            catch (Exception ex)
            {
                WriteException(objIRSSenderDE.SubmissionID, ex);
            }
        }
        #endregion

        #region Store the SendSubmission Status

        private void StoreSendSubmissionStatus(IRSSenderDE objIRSSenderDE, int stageId, string strState)
        {
            try
            {
                IRSSenderBL objIRSSenderBL = new IRSSenderBL();
                objIRSSenderBL.SetSendSubmissionStatus(objIRSSenderDE, stageId, strState);
            }
            catch (Exception ex)
            {
                WriteException(objIRSSenderDE.SubmissionID, ex);
            }
        }
        #endregion

        #region Fill MefHeader Logout

        private JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.MeFHeaderType FillMefHeaderLogout()
        {
            //this methodfills the values for Mef header(Logout).
            JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.MeFHeaderType meF = new JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.MeFHeaderType();
            meF.MessageID = Utility.GetMessageID(eTIN);
            MessageID = meF.MessageID;
            meF.Action = "Logout";
            meF.Timestamp = DateTime.Now;
            meF.ETIN = eTIN;
            meF.SessionIndicator = JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.SessionIndicatorType.N;
            meF.SessionIndicatorSpecified = true;
            if (testMode.ToUpper() == TestMode.Prod)
            {
                meF.TestIndicator = JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.TestIndicatorType.P;
            }
            else
            {
                meF.TestIndicator = JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.TestIndicatorType.T;
            }
            meF.TestIndicatorSpecified = true;
            meF.AppSysID = userName;
            return meF;
        }
        #endregion

        #region Logout

        private void LogOut()
        {
            bool IsLoggedOut = false;
            try
            {
                JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.Logout logoutService = new JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.Logout();
                logoutService.Url = URL + "Logout";
                ConfigureProxy(logoutService);
                logoutService.MeF = FillMefHeaderLogout();  //add mef header
                JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.LogoutRequestType logoutRequest = new JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.LogoutRequestType();
                JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.LogoutResponseType logoutResponse = new JTL.Tax1040.EfileServices.ZipandSendService.MeFMSIServices.LogoutResponseType();
                logoutResponse = logoutService.CallLogout(logoutRequest);  // call login web method

                if (logoutResponse != null && !string.IsNullOrEmpty(logoutResponse.Status))
                {
                    if (logoutResponse.Status.ToLower() == logoutresponsestatus)
                    {
                        IsLoggedOut = true;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteException(IRSSender.SubmissionID, ex);
            }
            finally
            {
                SetRequestResponseforLogOut(IsLoggedOut);
            }
        }
        #endregion

        #region Set Request, Response for Login
        private void SetRequestResponseforLogOut(bool IsAuthenticated)
        {
            //Store the Request XML, Response XML and Error to DB
            IRSSenderDE objIRSSenderDE = new IRSSenderDE();
            objIRSSenderDE.RequestXML = IRSOutputFilter.RequestXML;
            objIRSSenderDE.ResponseXML = IRSInputFilter.ResponseXML;
            objIRSSenderDE.MessageID = MessageID;

            if (!IsAuthenticated) //TRUE - IF Exception Occurs
            {
                objIRSSenderDE.StatusID = StatusCodes.UnSuccessfullLogOut;
            }
            else
            {
                objIRSSenderDE.StatusID = StatusCodes.SuccessfullLogOut;
            }
            objIRSSenderDE.ServiceAction = StringVariables.serviceLogout;
            StoreRequestResponseXMLSubmissionError(objIRSSenderDE);
            NULLRequestXMLResponseXML();
        }
        #endregion

        #region Send Alert Mail
        private void SendAlertMail(string Message, string SubId)
        {
            try
            {
                if (string.IsNullOrEmpty(SubId))
                {
                    SubId = " *** ";
                }
                string exceptValues = string.Format("Submission Id= {0} ******* ", SubId);
                eventLog1.WriteEntry(exceptValues + "\n" + Message, EventLogEntryType.FailureAudit);

                Utility.SendMail(Message, SubId);
            }
            catch (Exception ex)
            {
                WriteException(SubId, ex);
            }
        }
        #endregion

        #region OnStart and OnStop Events

        protected override void OnStart(string[] args)
        {
            timer.Start();
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
        #endregion

        #region Write Exception to EventLog
        private void WriteException(string exSubmissionId, Exception ex)
        {
            string exceptValues = string.Empty;
            if (!string.IsNullOrEmpty(exSubmissionId))
            {
                exceptValues = string.Format("Submission Id= {0} ******* ", exSubmissionId);
            }
            eventLog1.WriteEntry(ex.Message + " " + "\n" + exceptValues + "\n" + ex.ToString(), EventLogEntryType.Error);
        }
        #endregion

        #region DecryptData
        /// <summary>
        /// Decrypts the data.
        /// </summary>
        /// <param name="strText">The STR text.</param>
        /// <param name="strEncrKey">The STR encr key.</param>
        /// <returns></returns>
        private static string DecryptData(String strText, String strEncrKey)
        {
            DESCryptoServiceProvider des = null;
            Byte[] inputByteArray = null;
            MemoryStream ms = null;
            System.Text.Encoding encoding = null;
            try
            {

                //Code added to prevent "System.ArgumentOutOfRangeException: Index and length must refer to alocation within the string".
                if (!string.IsNullOrEmpty(strText) && !string.IsNullOrEmpty(strEncrKey) && (strEncrKey.Length > 7))
                {
                    byte[] bKey = new byte[8];
                    byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
                    bKey = System.Text.Encoding.UTF8.GetBytes(strEncrKey.Substring(0, 8));
                    des = new DESCryptoServiceProvider();
                    inputByteArray = inputByteArray = Convert.FromBase64String(strText);
                    ms = new MemoryStream();
                    CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(bKey, IV), CryptoStreamMode.Write);
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    encoding = System.Text.Encoding.UTF8;
                    return encoding.GetString(ms.ToArray());
                }
                else
                    return "";

            }
            finally
            {
                des = null;
                inputByteArray = null;
                ms = null;
                encoding = null;
            }
        }
        #endregion
    }
}
