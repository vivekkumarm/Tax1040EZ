using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Xml;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using System.Configuration;
using System.Collections;
using System.Timers;

namespace JTL.Tax1040.EfileServices.ZipandSendService
{
    partial class IRSSubmissionZip : ServiceBase
    {
        #region Declaration
        IRSZipDAL iRSZipDAL;
        string SchemaXmlStoringPath = ConfigurationManager.AppSettings["SchemaXmlStoringPath"];
        string ManifestXmlStoringPath = ConfigurationManager.AppSettings["ManifestXmlStoringPath"];
        string PdfStoringPath = ConfigurationManager.AppSettings["PdfStoringPath"];
        string ZipPath = ConfigurationManager.AppSettings["ZipPath"];
        string ZipStoringPath = ConfigurationManager.AppSettings["ZipStoringPath"];
        List<string> attachmentList;

        string AttachmentFolderName = ConfigurationManager.AppSettings["AttachmentFolderName"];
        string XmlFolderName = ConfigurationManager.AppSettings["XmlFolderName"];
        string ManifestFolderName = ConfigurationManager.AppSettings["ManifestFolderName"];
        string strFileName = string.Empty;
        int cmdTimeout = 120;
        Timer timer = new Timer();
        #endregion

        #region Constants
        const string ZipExtension = ".zip";
        const string PDFExtension = ".pdf";
        const string Attachment = "attachment";
        #endregion

        #region Constructor
        public IRSSubmissionZip()
        {
            InitializeComponent(); 

            // Timer Settings
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);

            double Interval = 0;
            if (double.TryParse(ConfigurationManager.AppSettings["TimerInterval"], out Interval))
            {
                timer.Interval = Interval;
            }

            //TODO: Saravanan N - 4th July, 2014 - EventLog part will be done later.
            //Getting Event Log Name from App.Config
            //if (null != ConfigurationManager.AppSettings["ZIPP_EventLogName"])
            //{
            //    string EventLogName = ConfigurationManager.AppSettings["ZIPP_EventLogName"].ToString();
            //    if (!System.Diagnostics.EventLog.SourceExists(EventLogName))
            //    {
            //        System.Diagnostics.EventLog.CreateEventSource(EventLogName, EventLogName);
            //    }
            //    eventLog1.Source = EventLogName;
            //    eventLog1.Log = EventLogName;
            //}
            //else
            //{
            //    if (!System.Diagnostics.EventLog.SourceExists("Tax1040-ZIPP"))
            //    {
            //        System.Diagnostics.EventLog.CreateEventSource("Tax1040-ZIPP", "Tax1040-ZIPP");
            //    }
            //    eventLog1.Source = "Tax1040-ZIPP";
            //    eventLog1.Log = "Tax1040-ZIPP";
            //}

            iRSZipDAL = new IRSZipDAL();
            attachmentList = new List<string>();
            Prerequisites();
            GetEfileReturnDataId();
        }
        #endregion

        #region On Start and On Stop Events
        protected override void OnStart(string[] args)
        {
            //timer.Start();
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
        #endregion

        #region Timer Elapsed Evet

        public void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //disabe the timer to avoid unwanted call before completion of process.
            timer.Enabled = false;
            try
            {
                GetEfileReturnDataId();
            }
            catch (Exception ex)
            {
                eventLog1.WriteEntry(ex.Message + " " + ex.StackTrace, EventLogEntryType.Error);
            }

            //enable the timer, if the process completes.
            timer.Enabled = true;
        }
        #endregion

        #region GetEfileHoldID
        /// <summary>
        /// gets all HoldIds from Efile hold Table.
        /// </summary>
        public void GetEfileReturnDataId()
        {
            try
            {
                int.TryParse(ConfigurationManager.AppSettings["CommandTimeout"].ToString(), out cmdTimeout);

                List<long> eFileReturnDataIds = iRSZipDAL.GetEfileReturnDataId(cmdTimeout);
                 
                foreach (long eFileReturnDataId in eFileReturnDataIds)
                {
                    DataSet iRSSchemaDataSet = iRSZipDAL.GetIRSSchemaXml(eFileReturnDataId);
                    DoZipIRSXml(iRSSchemaDataSet, eFileReturnDataId);
                }
            }
            catch (Exception ex)
            {
               // eventLog1.WriteEntry(ex.ToString(), EventLogEntryType.Error);
            }
        }
        #endregion

        #region ZipIRSSubmissions (DoZipIRSXml Function)
        /// <summary>
        /// method to zip IRSxml, Manifestxml and Attachments which need to be sent to the IRS.
        /// </summary>
        /// <param name="iRSSchemaDataSet">DataSet.</param>
        /// <param name="eFileHoldID">long.</param>
        private void DoZipIRSXml(DataSet iRSSchemaDataSet, long eFileHoldID)
        {
            string iRSSchemaXml = string.Empty;
            string manifestXml = string.Empty;
            string submissionId = string.Empty;

            try
            {
                if (IsDataSetValid(iRSSchemaDataSet) && null != iRSSchemaDataSet.Tables[0].Rows
                    && 0 < iRSSchemaDataSet.Tables[0].Rows.Count)
                {
                    if (null != iRSSchemaDataSet.Tables[0].Rows[0][1]
                        && null != iRSSchemaDataSet.Tables[0].Rows[0][2]
                        && null != iRSSchemaDataSet.Tables[0].Rows[0][3])
                    {

                        iRSSchemaXml = iRSSchemaDataSet.Tables[0].Rows[0][2].ToString();  //Get column [efile_irs_schema]

                        if (iRSSchemaXml.Contains("<?xml version=\"1.0\" encoding=\"UTF-16\"?>"))
                        {
                            iRSSchemaXml = iRSSchemaXml.Replace("<?xml version=\"1.0\" encoding=\"UTF-16\"?>", "<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                        }
                        else if (!iRSSchemaXml.Contains("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"))
                        {
                            iRSSchemaXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" + iRSSchemaXml;
                        }
                        manifestXml = iRSSchemaDataSet.Tables[0].Rows[0][3].ToString();   //Get column ManifestXML
                        manifestXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" + manifestXml;

                        submissionId = iRSSchemaDataSet.Tables[0].Rows[0][4].ToString();   //Get column SubmissionID

                        // For the picked up IRSSchema, Initially we set the State to 'Blank' &
                        // Stage to 'ZIPP' in the EfileLastStatus table.
                        UpdateStatus(eFileHoldID, submissionId, State.Blank);

                        if (!String.IsNullOrEmpty(iRSSchemaXml))
                        {
                            StreamWriter SW;
                            SW = File.CreateText(SchemaXmlStoringPath);
                            SW.Write(iRSSchemaXml);
                            SW.Close();
                        }

                        if (!String.IsNullOrEmpty(manifestXml))
                        {
                            //XmlDocument manifestXmlDocument = new XmlDocument();
                            //manifestXmlDocument.LoadXml(manifestXml);
                            //manifestXmlDocument.Save(ManifestXmlStoringPath);
                            

                            StreamWriter SWManifestXml;
                            SWManifestXml = File.CreateText(ManifestXmlStoringPath);
                            SWManifestXml.Write(manifestXml);
                            SWManifestXml.Close();
                        }
                    }

                    if (iRSSchemaDataSet.Tables.Count > 1)
                    {
                        foreach (DataRow dr in iRSSchemaDataSet.Tables[1].Rows)
                        {
                            if (null != dr["AttachementName"] && null != dr["EfileAttachment"])
                            {
                                attachmentList.Add(PdfStoringPath + dr["AttachementName"].ToString() + PDFExtension);
                                WriteAttachments((byte[])(dr["EfileAttachment"]), PdfStoringPath + dr["AttachementName"].ToString() + ".pdf");
                            }
                        }
                    }
                    ZipHelper(submissionId, eFileHoldID);
                }
            }
            catch (Exception ex)
            {
                eventLog1.WriteEntry(ex.ToString(), EventLogEntryType.Error);
            }
        }

        #endregion

        #region Update Status
        private void UpdateStatus(long efileTaxReturnID, string submissionID, string state)
        {
            StatusBE statusBE = new StatusBE();
            statusBE.EfileReturnDataID = efileTaxReturnID;
            statusBE.SubmissionId = submissionID;
            statusBE.Stage = JTL.Tax1040.EfileServices.Core.Process.Stage.Zip; 
            statusBE.State = state;
            iRSZipDAL.UpdateStatus(statusBE);
        }
        #endregion

        #region ReadZip
        /// <summary>
        /// Reads the zipped content from a physical location
        /// </summary>
        /// <param name="submissionId">The submission id.</param>
        /// <returns></returns>
        private byte[] ReadZip(string submissionId)
        {
            byte[] buff = new byte[0];
            FileStream sReader = null;
            try
            {
                sReader = File.OpenRead(ZipStoringPath + submissionId + ZipExtension);
                buff = new byte[GetInt32(sReader.Length)];
                sReader.Read(buff, 0, buff.Length);
            }
            catch (Exception ex)
            {
                eventLog1.WriteEntry(ex.ToString(), EventLogEntryType.Error);
            }
            finally
            {
                sReader.Flush();
                sReader.Close();
            }
            return buff;
        }
        #endregion

        #region IsDataSetValid
        /// <summary>
        /// checks whether the data set has values.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        /// <returns>bool</returns>
        private bool IsDataSetValid(DataSet dataSet)
        {
            if (null != dataSet && null != dataSet.Tables &&
                0 < dataSet.Tables.Count)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region ZipHelper
        /// <summary>
        /// Helper method for zip the files.
        /// </summary>
        /// <param name="submissionId">string.</param>
        private void ZipHelper(string submissionId, long eFileHoldID)
        {
            bool zippedSuccessfully = false;
            try
            {
                if (ZipFiles(submissionId, eFileHoldID))
                {
                    if (FinalZip(submissionId, eFileHoldID))
                    {
                        byte[] finalZip = ReadZip(submissionId);
                        if (null != finalZip && 0 < finalZip.Length)
                        {
                            iRSZipDAL.SaveIntegratedZip(eFileHoldID, finalZip, submissionId);
                            zippedSuccessfully = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                eventLog1.WriteEntry(ex.ToString(), EventLogEntryType.Error);
            }
            finally
            {
                string strState = State.Error;
                DeletePreviousFiles();
                if (zippedSuccessfully)
                {
                    strState = State.Success;
                }
                // If there is any error then we update the State to 'Error' or 'Success' in the EfileLastStatus table.
                UpdateStatus(eFileHoldID, submissionId, strState);

                if (File.Exists(ZipStoringPath + submissionId + ZipExtension))
                {
                    if (null != ConfigurationManager.AppSettings["ZipMovePath"] && !string.IsNullOrEmpty(strFileName))
                    {
                        if (Directory.Exists(ConfigurationManager.AppSettings["ZipMovePath"].ToString()))
                        {
                            if (!File.Exists(ConfigurationManager.AppSettings["ZipMovePath"].ToString() + strFileName))
                            {
                                File.Move(ZipStoringPath + submissionId + ZipExtension, ConfigurationManager.AppSettings["ZipMovePath"].ToString() + strFileName);
                            }
                        }
                        else
                        {
                            if (!File.Exists(ConfigurationManager.AppSettings["ZipMovePath"].ToString() + strFileName))
                            {
                                Directory.CreateDirectory(ConfigurationManager.AppSettings["ZipMovePath"].ToString());
                                File.Move(ZipStoringPath + submissionId + ZipExtension, ConfigurationManager.AppSettings["ZipMovePath"].ToString() + strFileName);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region ZipFiles
        /// <summary>
        ///Zips the IRS xml, Manifest xml and Attachments
        /// </summary>
        public bool ZipFiles(string submissionId, long eFileHoldID)
        {
            bool zippedSuccessfully = false;
            try
            {
                List<string> paths = new List<string>();
                paths.Add(SchemaXmlStoringPath);
                paths.Add(ManifestXmlStoringPath);
                foreach (string attachment in attachmentList)
                {
                    paths.Add(attachment);
                }

                attachmentList = new List<string>();

                using (ZipOutputStream zipOut = new ZipOutputStream(File.Create(ZipPath + submissionId + ZipExtension)))
                {
                    foreach (string filePath in paths)
                    {
                        ZipEntry entry2 = new ZipEntry(filePath.Replace(ZipPath, ""));
                        FileStream sReader = File.OpenRead(filePath);
                        byte[] buff = new byte[Convert.ToInt32(sReader.Length)];
                        sReader.Read(buff, 0, (int)sReader.Length);
                        entry2.Size = sReader.Length;
                        sReader.Close();
                        zipOut.PutNextEntry(entry2);
                        zipOut.Write(buff, 0, buff.Length);
                    }
                    zipOut.Finish();
                    zipOut.Close();
                    zippedSuccessfully = true;
                }
            }
            catch (Exception ex)
            {
                eventLog1.WriteEntry(ex.ToString(), EventLogEntryType.Error);

            }
            return zippedSuccessfully;
        }
        #endregion

        #region DeletePreviousFiles
        /// <summary>
        ///deletes ths original files of a submission after zipping
        /// </summary>
        private void DeletePreviousFiles()
        {
            if (File.Exists(SchemaXmlStoringPath))
            {
                File.Delete(SchemaXmlStoringPath);
            }
            if (File.Exists(ManifestXmlStoringPath))
            {
                File.Delete(ManifestXmlStoringPath);
            }
            foreach (string fileName in Directory.GetFiles(PdfStoringPath))
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
            }
        }
        #endregion

        #region FinalZip
        /// <summary>
        /// Zips the prior zipped content
        /// </summary>
        /// <param name="submissionId">The submission id.</param>
        private bool FinalZip(string submissionId, long eFileHoldID)
        {
            bool zippedSuccessfully = false;
            ZipOutputStream zipOut = null;
            try
            {
                zipOut = new ZipOutputStream(File.Create(ZipStoringPath + submissionId + ZipExtension));

                FileInfo fileInfo = new FileInfo(ZipPath + submissionId + ZipExtension);
                ZipEntry entry2 = new ZipEntry(fileInfo.Name);
                strFileName = fileInfo.Name;
                FileStream sReader = null;
                byte[] buff = new byte[0];
                try
                {
                    sReader = File.OpenRead(ZipPath + submissionId + ZipExtension);
                    buff = new byte[Convert.ToInt32(sReader.Length)];
                    sReader.Read(buff, 0, (int)sReader.Length);
                    entry2.DateTime = fileInfo.LastWriteTime;
                    entry2.Size = sReader.Length;
                }
                catch (Exception ex)
                {
                    eventLog1.WriteEntry(ex.ToString(), EventLogEntryType.Error);

                }
                finally
                {
                    sReader.Close();
                }

                zipOut.PutNextEntry(entry2);
                zipOut.Write(buff, 0, buff.Length);
                zippedSuccessfully = true;
            }
            catch (Exception ex)
            {
                eventLog1.WriteEntry(ex.ToString(), EventLogEntryType.Error);

            }
            finally
            {
                zipOut.Finish();
                zipOut.Close();
                if (File.Exists(ZipPath + submissionId + ZipExtension))
                {
                    File.Delete(ZipPath + submissionId + ZipExtension);
                }

            }
            return zippedSuccessfully;
        }
        #endregion

        #region WriteAttachments
        /// <summary>
        ///writes the attachment to a physical path
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <param name="attachmentName">Name of the attachment.</param>
        private void WriteAttachments(byte[] attachment, string attachmentName)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = File.Create(attachmentName);
                fileStream.Write(attachment, 0, attachment.Length);
            }
            catch (Exception ex)
            {
                eventLog1.WriteEntry(ex.ToString(), EventLogEntryType.Error);
            }
            finally
            {
                fileStream.Close();
            }
        }
        #endregion

        #region Prerequisites
        private void Prerequisites()
        {
            if (!Directory.Exists(ZipPath))
            {
                Directory.CreateDirectory(ZipPath);
            }
            if (!Directory.Exists(AttachmentFolderName))
            {
                Directory.CreateDirectory(AttachmentFolderName);
            }
            if (!Directory.Exists(XmlFolderName))
            {
                Directory.CreateDirectory(XmlFolderName);
            }
            if (!Directory.Exists(ManifestFolderName))
            {
                Directory.CreateDirectory(ManifestFolderName);
            }
        }
        #endregion

        #region Convert to Int32

        private Int32 GetInt32(object Value)
        {
            Int32 result = 0;
            if (Value != null)
            {
                Int32.TryParse(Value.ToString(), out result);
            }
            return result;
        }
        #endregion
    }
}
