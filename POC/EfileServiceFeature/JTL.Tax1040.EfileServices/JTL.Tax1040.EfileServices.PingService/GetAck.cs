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
using ICSharpCode.SharpZipLib.Zip;
using System.Collections;
using System.Security.Cryptography;

using Microsoft.Web.Services3.Security.Tokens;
using Microsoft.Web.Services3;
using Microsoft.Web.Services3.Design;


namespace JTL.Tax1040.EfileServices.PingService
{
    public partial class GetAck : ServiceBase
    {
        #region Declaration
        public string MessageId = string.Empty;
        public UsernameToken token = null;
        private System.Timers.Timer timer = new System.Timers.Timer();
        string userName = string.Empty;
        string pwd = string.Empty;
        string eTIN = string.Empty;
        string initalPwd = string.Empty;
        string confirmToken = string.Empty;
        string testMode = string.Empty;
        string eFIN = string.Empty;
        public string URL = string.Empty;
        string AcknowledgementStoringPath = ConfigurationManager.AppSettings["AcknowledgementPath"];
        public bool timerDisable = false;
        int timeout = 100000;
        const string serviceLogin = "GetAck-Login";
        const string serviceLogout = "GetAck-Logout";
        const string serviceAction = "GetAck";
        public bool AckError = false;

        #endregion

        internal class Errors
        {
            public const string LoginSessionErr = "Session or service connection limit reached";
        }

        #region Constructor
        public GetAck()
        {
            InitializeComponent();

            //Timer Settings
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Interval = Utilities.Getdouble(ConfigurationManager.AppSettings["Timer_Interval"]);

            //Getting Event Log Name from App.Config
            if (null != ConfigurationManager.AppSettings["GACK_EventLogName"])
            {
                string EventLogName = ConfigurationManager.AppSettings["GACK_EventLogName"].ToString();
                if (!System.Diagnostics.EventLog.SourceExists(EventLogName))
                {
                    System.Diagnostics.EventLog.CreateEventSource(EventLogName, EventLogName);
                }
                eventLog1.Source = EventLogName;
                eventLog1.Log = EventLogName;
            }
            else
            {
                if (!System.Diagnostics.EventLog.SourceExists("7004-GACK"))
                {
                    System.Diagnostics.EventLog.CreateEventSource("7004-GACK", "7004-GACK");
                }
                eventLog1.Source = "7004-GACK";
                eventLog1.Log = "7004-GACK";
            }

            //get the timeout value from app settings
            int.TryParse(Utilities.GetAppSettingsValue("Timeout"), out timeout);

            //Commented by Sankaran Namboothiri – to enable WSE3.0
            ////Configuring Custom Filters
            //WebServicesConfiguration.FilterConfiguration.OutputFilters.Insert(0, new IRSOutputFilter());
            ////add input filter to remove saml from response
            //WebServicesConfiguration.FilterConfiguration.InputFilters.Insert(0, new IRSInputFilter());

            if (!Directory.Exists(@"c://temp"))
            {
                Directory.CreateDirectory(@"c://temp");
                if (!Directory.Exists(AcknowledgementStoringPath))
                {
                    Directory.CreateDirectory(AcknowledgementStoringPath);
                }
            }
            else
            {
                if (!Directory.Exists(AcknowledgementStoringPath))
                {
                    Directory.CreateDirectory(AcknowledgementStoringPath);
                }
            }
        }
        #endregion

        #region Timer Elapsed Evet

        public void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
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
                    Utilities.SendMail("Timer Disabled  - Get Acknowledgement", null);
                }
            }
            catch (Exception ex)
            {
                WriteException(null, ex);
            }
        }
        #endregion

        #region StartService Function

        //StartService Method - 
        public void StartService()
        {
            if (GetSecurityInfo())
            {
                GetAckBL getAckBL = new GetAckBL();
                List<string> subIds = getAckBL.GetSubmissionIDs(Stage.SendSubmission, State.Success);
                if (subIds != null && subIds.Count > 0)
                {
                    if (Login())
                    {
                        GetAcknowledgement(subIds);
                        LogOut();
                    }
                    else
                    {
                        Utilities.SendMail("Login Failed - Get Acknowledgement", null);
                        eventLog1.WriteEntry("Login Failed");
                    }
                }
            }
            else
            {
                timerDisable = true;
            }
        }
        #endregion

        #region Get Get Security Info from Web.Config

        private bool GetSecurityInfo()
        {
            try
            {
                GetAckBL getAckBL = new GetAckBL();
                Hashtable htSecurityInfo = getAckBL.GetSecurityInfo(FormType.Form7004);
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
                //initalPwd = ConfigurationManager.AppSettings["InitialPassword"].ToString();
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
                eventLog1.WriteEntry(ex.Message, EventLogEntryType.Error);
                return false;
            }
        }
        #endregion

        #region Configure Proxy

        private void ConfigureProxy(WebServicesClientProtocol proxy)
        {
            //Commented by Sankaran Namboothiri – to enable WSE3.0
            //this.token = new UsernameToken(userName, pwd, PasswordOption.SendPlainText);
            //proxy.RequestSoapContext.Security.Tokens.Add(token);

            //New policy settings for WSE 3.0
            RemoveAddressingHeadersAssertion assert = new RemoveAddressingHeadersAssertion(userName, pwd);
            Policy policy = new Policy();
            policy.Assertions.Add(assert);
            proxy.SetPolicy(policy);
        }
        #endregion

        #region Fill MefHeader Login
        // Fills the mef header for Login.

        private JTL.Tax1040.EfileServices.PingService.MeFMSIServices.MeFHeaderType FillMefHeaderLogin()
        {
            //this methodfills the values for Mef header(Login).
            MeFMSIServices.MeFHeaderType meF = new MeFMSIServices.MeFHeaderType();
            meF.MessageID = Utilities.GetMessageID(eTIN);
            MessageId = meF.MessageID;
            meF.Action = Constants.Login;
            meF.Timestamp = DateTime.Now;
            meF.ETIN = eTIN;
            meF.SessionIndicator = MeFMSIServices.SessionIndicatorType.Y;
            meF.SessionIndicatorSpecified = true;
            //if the test mode is ON
            if (testMode.ToUpper() == TestMode.Prod)
            {
                meF.TestIndicator = MeFMSIServices.TestIndicatorType.P;
            }
            else
            {
                meF.TestIndicator = MeFMSIServices.TestIndicatorType.T;
            }
            meF.TestIndicatorSpecified = true;
            meF.AppSysID = userName;
            return meF;
        }
        #endregion

        #region Login

        private bool Login()
        {
            bool IsAuthenticated = false;
            try
            {
                IRSInputFilter.SAMLDocument = null;

                MeFMSIServices.Login loginService = new MeFMSIServices.Login();
                ConfigureProxy(loginService);
                loginService.Url = URL + "Login";
                loginService.MeF = FillMefHeaderLogin();
                MeFMSIServices.LoginRequestType loginRequest = new MeFMSIServices.LoginRequestType();
                MeFMSIServices.LoginResponseType loginResponse = new MeFMSIServices.LoginResponseType();
                //Calls the Web Method "CallLogin"
                loginResponse = loginService.CallLogin(loginRequest);
                //Gets the response status
                if (!string.IsNullOrEmpty(loginResponse.Status))
                {
                    if (loginResponse.Status.ToLower() == "session counter updated")
                    {
                        IsAuthenticated = true;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteException(null, ex);
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
            try
            {
                //Store the Request XML, Response XML and Error to DB
                GetAckDE getAckDE = new GetAckDE();
                getAckDE.RequestXML = IRSOutputFilter.RequestXML;
                getAckDE.ResponseXML = IRSInputFilter.ResponseXML;
                getAckDE.MessageID = MessageId;

                IRSErrorDE objIRSErrorDE = new IRSErrorDE();
                objIRSErrorDE = GetErrorMessageforLoginLogout(getAckDE, objIRSErrorDE);

                if (!IsAuthenticated) //TRUE - IF Exception Occurs
                {
                    getAckDE.StatusID = Status.UnSuccessfullLogin;
                }
                else
                {
                    if (objIRSErrorDE.IsErrorPresent)
                    {
                        getAckDE.StatusID = Status.UnSuccessfullLogin;
                    }
                    else
                    {
                        getAckDE.StatusID = Status.SuccessfullLogin;
                    }
                }
                if (objIRSErrorDE.IsErrorPresent)
                {
                    getAckDE.Action = "Login";
                }
                getAckDE.Error = objIRSErrorDE;
                getAckDE.ServiceAction = serviceLogin;
                StoreRequestResponseXMLSubmissionError(getAckDE);
                if (string.IsNullOrEmpty(IRSInputFilter.ResponseXML))
                {
                    timerDisable = true;
                }
                NULLRequestXMLResponseXML();
            }
            catch (Exception ex)
            {
                WriteException(null, ex);
            }
        }
        #endregion

        #region Get Error from XML for Login

        private IRSErrorDE GetErrorMessageforLoginLogout(GetAckDE getAckDE, IRSErrorDE objIRSErrorDE)
        {
            try
            {
                XmlTextReader reader = null;
                // load the file from the URL
                if (!string.IsNullOrEmpty(getAckDE.ResponseXML))
                {
                    Stream XMLstream = new MemoryStream(ASCIIEncoding.Default.GetBytes(getAckDE.ResponseXML));
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
                    eventLog1.WriteEntry(getAckDE.SubmissionID + "Response XML is NULL", EventLogEntryType.FailureAudit);
                }
            }
            catch (Exception ex)
            {
                objIRSErrorDE.IsErrorPresent = true;
                WriteException(getAckDE.SubmissionID, ex);
            }
            return objIRSErrorDE;
        }
        #endregion

        #region Fill MefHeader Logout

        private MeFMSIServices.MeFHeaderType FillMefHeaderLogout()
        {
            //this methodfills the values for Mef header(Logout).
            MeFMSIServices.MeFHeaderType meF = new MeFMSIServices.MeFHeaderType();
            meF.MessageID = Utilities.GetMessageID(eTIN);
            MessageId = meF.MessageID;
            meF.Action = "Logout";
            meF.Timestamp = DateTime.Now;
            meF.ETIN = eTIN;
            meF.SessionIndicator = MeFMSIServices.SessionIndicatorType.N;
            meF.SessionIndicatorSpecified = true;
            if (testMode.ToUpper() == TestMode.Prod)
            {
                meF.TestIndicator = MeFMSIServices.TestIndicatorType.P;
            }
            else
            {
                meF.TestIndicator = MeFMSIServices.TestIndicatorType.T;
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
                MeFMSIServices.Logout logoutService = new MeFMSIServices.Logout();
                logoutService.Url = URL + "Logout";
                ConfigureProxy(logoutService);
                //add mef header
                logoutService.MeF = FillMefHeaderLogout();
                // call login web method
                MeFMSIServices.LogoutRequestType logoutRequest = new MeFMSIServices.LogoutRequestType();

                MeFMSIServices.LogoutResponseType logoutResponse = new MeFMSIServices.LogoutResponseType();
                logoutResponse = logoutService.CallLogout(logoutRequest);

                if (logoutResponse != null && !string.IsNullOrEmpty(logoutResponse.Status))
                {
                    if (logoutResponse.Status.ToUpper() == "")
                    {
                        IsLoggedOut = true;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteException(null, ex);
            }
            finally
            {
                SetRequestResponseforLogOut(IsLoggedOut);
            }
        }
        #endregion

        #region Set Request, Response for LogOut
        private void SetRequestResponseforLogOut(bool IsAuthenticated)
        {
            try
            {
                //Store the Request XML, Response XML and Error to DB
                GetAckDE getAckDE = new GetAckDE();
                getAckDE.RequestXML = IRSOutputFilter.RequestXML;
                getAckDE.ResponseXML = IRSInputFilter.ResponseXML;
                getAckDE.MessageID = MessageId;

                if (!IsAuthenticated) //TRUE - IF Exception Occurs
                {
                    getAckDE.StatusID = Status.UnSuccessfullLogOut;
                }
                else
                {
                    getAckDE.StatusID = Status.SuccessfullLogOut;
                }
                getAckDE.ServiceAction = serviceLogout;
                StoreRequestResponseXMLSubmissionError(getAckDE);
                NULLRequestXMLResponseXML();
            }
            catch (Exception ex)
            {
                WriteException(null, ex);
            }
        }
        #endregion

        #region NULL RequestXML, ResponseXML

        private void NULLRequestXMLResponseXML()
        {
            IRSOutputFilter.RequestXML = null;
            IRSInputFilter.ResponseXML = null;
        }
        #endregion

        #region Fill MEF Acknowledgement header
        public JTL.Tax1040.EfileServices.PingService.MeFTransmitterServicesMTOM.MeFHeaderType FillMefHeaderGetAcks()
        {
            JTL.Tax1040.EfileServices.PingService.MeFTransmitterServicesMTOM.MeFHeaderType meF = new JTL.Tax1040.EfileServices.PingService.MeFTransmitterServicesMTOM.MeFHeaderType();
            meF.MessageID = Utilities.GetMessageID(eTIN);
            MessageId = meF.MessageID;
            meF.Action = "GetAck";
            meF.Timestamp = DateTime.Now;
            meF.ETIN = eTIN;
            meF.SessionIndicator = JTL.Tax1040.EfileServices.PingService.MeFTransmitterServicesMTOM.SessionIndicatorType.Y;
            meF.SessionIndicatorSpecified = true;
            //if the test mode is ON
            if (testMode.ToUpper() == TestMode.Prod)
            {
                meF.TestIndicator = JTL.Tax1040.EfileServices.PingService.MeFTransmitterServicesMTOM.TestIndicatorType.P;
            }
            else
            {
                meF.TestIndicator = JTL.Tax1040.EfileServices.PingService.MeFTransmitterServicesMTOM.TestIndicatorType.T;
            }
            meF.TestIndicatorSpecified = true;
            meF.AppSysID = userName;
            return meF;
        }
        #endregion

        #region Get Acknowledgement
        //gets the Acknowledgement for a submitted return
        private void GetAcknowledgement(List<string> subIds)
        {
            try
            {
                GetAckBL getAckBL = new GetAckBL();
                foreach (string subID in subIds)
                {
                    AckError = false;
                    getAckBL.SetStatus(subID, Stage.GetAcknowledgement, State.Blank);
                    bool ISFailedAck = false;
                    bool iRSReceivedSucc = false;
                    byte[] ackArray = null;
                    MeFTransmitterServicesMTOM.GetAck getAck = new MeFTransmitterServicesMTOM.GetAck();
                    try
                    {
                        ConfigureProxy(getAck);
                        getAck.Url = URL + "mtom/GetAck";
                        getAck.MeF = FillMefHeaderGetAcks();
                        MeFTransmitterServicesMTOM.GetAckRequestType getAcksRequest = new MeFTransmitterServicesMTOM.GetAckRequestType();

                        getAck.RequireMtom = true;
                        getAck.Timeout = timeout;

                        getAcksRequest.SubmissionId = subID;
                        MeFTransmitterServicesMTOM.GetAckResponseType getAckResponse = new MeFTransmitterServicesMTOM.GetAckResponseType();
                        //invokes getAck method of IRS service
                        getAckResponse = getAck.CallGetAck(getAcksRequest);


                        GetAckDE getAckDE;
                        if (getAckResponse != null)
                        {
                            ackArray = getAckResponse.AcknowledgementAttachmentMTOM.Value;
                            FileStream fileStream = null;
                            fileStream = File.Create(AcknowledgementStoringPath + subID + ".Zip");
                            fileStream.Write(ackArray, 0, ackArray.Length);
                            fileStream.Close();

                            //unzips the attachment
                            using (ZipInputStream zipIn = new ZipInputStream(File.OpenRead(AcknowledgementStoringPath + subID + ".Zip")))
                            {
                                ZipEntry entry1;
                                string attachment = string.Empty;
                                while ((entry1 = zipIn.GetNextEntry()) != null)
                                {
                                    long size = entry1.Size;
                                    byte[] data = new byte[ackArray.Length * 12];
                                    size = zipIn.Read(data, 0, data.Length);
                                    System.Text.ASCIIEncoding enc = new ASCIIEncoding();
                                    attachment = enc.GetString(data);
                                    attachment = attachment.Replace("\0", "");
                                    getAckDE = new GetAckDE();
                                    getAckDE.SubmissionID = subID;
                                    getAckDE = GetAttachmentError(getAckDE, attachment, subID);
                                    if (!string.IsNullOrEmpty(getAckDE.AcceptanceStatus))
                                    {
                                        if (getAckDE.AcceptanceStatus.ToLower() == "rejected")
                                        {
                                            getAckDE.Action = "GetAck";
                                            getAckDE.StatusID = Status.RejectedFromIRS;
                                            getAckBL.SaveAckAttachmentErrors(getAckDE, Stage.GetAcknowledgement, State.Rejected);
                                        }
                                        else if (getAckDE.AcceptanceStatus.ToLower() == "accepted")
                                        {
                                            iRSReceivedSucc = true;
                                        }
                                    }
                                    //Commented By Peter on Nov-04-2009 
                                    //Uncommented By Prabhu on Nov-09-2009
                                    //FilingStatus was missing in responseXML
                                    if (!string.IsNullOrEmpty(getAckDE.FilingStatus))
                                    {
                                        if (getAckDE.FilingStatus.ToLower() == "rejected")
                                        {
                                            getAckDE.Action = "GetAck";
                                            getAckDE.StatusID = Status.RejectedFromIRS;
                                            getAckBL.SaveAckAttachmentErrors(getAckDE, Stage.GetAcknowledgement, State.Rejected);
                                        }
                                        else if (getAckDE.FilingStatus.ToLower() == "accepted")
                                        {
                                            iRSReceivedSucc = true;
                                        }
                                    }
                                }
                            }
                        }

                        //checks for an empty 'GetAckResponse' node of the soap body
                        ISFailedAck = true;
                        if (getAck.ResponseSoapContext.Envelope.Body != null)
                        {
                            XmlTextReader reader = null;

                            Stream XMLstream = new MemoryStream(ASCIIEncoding.Default.GetBytes(getAck.ResponseSoapContext.Envelope.Body.InnerXml));
                            reader = new XmlTextReader(XMLstream);
                            object AckResponse1 = reader.NameTable.Add("ns9:GetAckResponse");
                            object AckResponse2 = reader.NameTable.Add("ns10:GetAckResponse");
                            object AckResponse3 = reader.NameTable.Add("ns11:GetAckResponse");
                            reader.WhitespaceHandling = WhitespaceHandling.None;
                            while (reader.Read())
                            {
                                if (reader.NodeType == XmlNodeType.Element)
                                {
                                    if (reader.Name.Equals(AckResponse1) || reader.Name.Equals(AckResponse2) || reader.Name.Equals(AckResponse3))
                                    {

                                        ISFailedAck = false;
                                        break;
                                    }
                                    else
                                    {
                                        ISFailedAck = true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            ISFailedAck = true;
                        }
                    }

                    catch (Exception ex)
                    {
                        ISFailedAck = true;
                        WriteException(subID, ex);
                    }
                    finally
                    {
                        string strState = State.Error;
                        GetAckDE getAckDE = new GetAckDE();
                        getAckDE.RequestXML = IRSOutputFilter.RequestXML;
                        getAckDE.ResponseXML = IRSInputFilter.ResponseXML;
                        getAckDE.MessageID = MessageId;

                        IRSErrorDE iRSRespErrorDE = new IRSErrorDE();
                        iRSRespErrorDE = GetErrorMessage(getAckDE.ResponseXML, iRSRespErrorDE, subID);


                        if (ISFailedAck)
                        {
                            strState = State.Error;

                            getAckDE.StatusID = Status.FailedToGetAckFromIRS;
                        }
                        else
                        {
                            if (iRSReceivedSucc)
                            {
                                strState = State.Success;
                                getAckDE.StatusID = Status.IRSSubmissionAccepted;
                            }
                            else if (iRSRespErrorDE.IsErrorPresent)
                            {
                                strState = State.Error;
                                getAckDE.Action = "GetAck";
                                getAckDE.StatusID = Status.FailedToGetAckFromIRS;
                                SendAlertMail(getAckDE.ResponseXML, subID);
                            }
                            else if (AckError)
                            {
                                strState = State.Error;
                            }
                            else
                            {
                                strState = State.Rejected;
                                getAckDE.StatusID = Status.RejectedFromIRS;
                            }
                        }


                        getAckDE.Error = iRSRespErrorDE;
                        getAckDE.SubmissionID = subID;
                        getAckDE.ServiceAction = serviceAction;
                        StoreRequestResponseXMLSubmissionError(getAckDE);
                        try
                        {
                            if (ackArray != null && ackArray.Length > 0)
                            {
                                getAckBL.SaveAckAttachment(ackArray, subID, Stage.GetAcknowledgement, strState);
                            }
                            else
                            {
                                getAckBL.SetStatus(subID, Stage.GetAcknowledgement, strState);
                            }
                        }
                        catch (Exception ex)
                        {
                            WriteException(subID, ex);
                        }
                        IRSOutputFilter.RequestXML = null;
                        IRSInputFilter.ResponseXML = null;
                    }
                }
            }
            catch (Exception exp)
            {
                eventLog1.WriteEntry(exp.ToString(), EventLogEntryType.Error);
            }
        }
        #endregion

        #region Gets Attachment errors
        public GetAckDE GetAttachmentError(GetAckDE getAckDE, string attachment, string SubID)
        {
            try
            {
                if (!string.IsNullOrEmpty(attachment))
                {
                    XmlDocument doc = new XmlDocument();
                    //Stream XMLstream = new MemoryStream(ASCIIEncoding.Default.GetBytes(attachment));
                    doc.LoadXml(attachment);
                    XmlNode element = doc.ChildNodes.Item(1).ChildNodes[1];
                    XmlNode errNode, childErrnode;
                    IRSErrorDE irsErrorDE = new IRSErrorDE();
                    foreach (XmlNode node in element)
                    {
                        if (node.Name == "ErrorList")
                        {
                            for (int i = 0; i < node.ChildNodes.Count; i++)
                            {
                                errNode = node.ChildNodes[i];
                                for (int j = 0; j < errNode.ChildNodes.Count; j++)
                                {
                                    childErrnode = errNode.ChildNodes[j];
                                    if (childErrnode.Name.Equals("ErrorMessage"))
                                    {
                                        irsErrorDE.ErrorMessage = childErrnode.InnerXml;
                                    }
                                    else if (childErrnode.Name.Equals("ErrorCategory"))
                                    {
                                        irsErrorDE.ErrorClassification = childErrnode.InnerXml;
                                    }
                                    else if (childErrnode.Name.Equals("RuleNumber"))
                                    {
                                        irsErrorDE.ErrorCode = childErrnode.InnerXml;
                                    }
                                }
                            }
                        }
                        if (node.Name == "AcceptanceStatus")
                        {
                            getAckDE.AcceptanceStatus = node.InnerXml;
                        }
                        //Commented by Prabhu on 04 Nov for Schema Change
                        //if (node.Name == "FilingStatus")
                        //{
                        //    getAckDE.FilingStatus = node.InnerXml;
                        //}
                    }
                    getAckDE.Error = irsErrorDE;
                }
            }
            catch (Exception ex)
            {
                WriteException(SubID, ex);
            }
            return getAckDE;
        }
        #endregion

        #region Get Response error
        public IRSErrorDE GetErrorMessage(string responseXml, IRSErrorDE iRSErrorDE, string SubId)
        {
            try
            {
                XmlTextReader reader = null;
                // load the file from the URL
                if (!string.IsNullOrEmpty(responseXml))
                {
                    Stream XMLstream = new MemoryStream(ASCIIEncoding.Default.GetBytes(responseXml));
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
                                iRSErrorDE.ErrorMessage = reader.ReadString();
                            }
                            else if (reader.Name.Equals(objErrorClassification))
                            {
                                iRSErrorDE.ErrorClassification = reader.ReadString();
                            }
                            else if (reader.Name.Equals(objErrorCode))
                            {
                                iRSErrorDE.ErrorCode = reader.ReadString();
                                iRSErrorDE.IsErrorPresent = true;
                                if (iRSErrorDE.ErrorCode == "MEF00005")
                                {
                                    AckError = true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    eventLog1.WriteEntry(SubId + " Response XML is NULL", EventLogEntryType.FailureAudit);
                }
            }
            catch (Exception ex)
            {
                WriteException(SubId, ex);
            }
            return iRSErrorDE;
        }
        #endregion

        #region Store the Request, ResponseXML and SubmissionError

        private void StoreRequestResponseXMLSubmissionError(GetAckDE getAckDE)
        {
            try
            {
                GetAckBL getAckBL = new GetAckBL();
                getAckBL.StoreRequestResponseXMLSubmissionError(getAckDE);
            }
            catch (Exception ex)
            {
                WriteException(getAckDE.SubmissionID, ex);
            }
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

                Utilities.SendMail(Message, SubId);
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
            // TODO: Add code here to start your service.
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
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
