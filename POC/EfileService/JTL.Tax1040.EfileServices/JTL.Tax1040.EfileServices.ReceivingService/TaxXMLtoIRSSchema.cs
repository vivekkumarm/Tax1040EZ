using Efile.SubmissionManifest;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;


namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class TaxXMLtoIRSSchema
    {
        string strUserName = string.Empty;
        string strEFIN = string.Empty;
        int cmdTimeout = 120;
        public TaxXMLtoIRSSchema()
        {
            //InitializeComponent();

            ////Timer Settings   
            //timer.Enabled = true;
            //timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            //timer.Interval = Utilities.Getdouble(ConfigurationManager.AppSettings["Timer_Interval"]);

            ////Getting Event Log Name from App.Config
            //if (null != ConfigurationManager.AppSettings["CONV_EventLogName"])
            //{
            //    string EventLogName = ConfigurationManager.AppSettings["CONV_EventLogName"].ToString();
            //    if (!System.Diagnostics.EventLog.SourceExists(EventLogName))
            //    {
            //        System.Diagnostics.EventLog.CreateEventSource(EventLogName, EventLogName);
            //    }
            //    eventLog1.Source = EventLogName;
            //    eventLog1.Log = EventLogName;
            //}
            //else
            //{
            //    if (!System.Diagnostics.EventLog.SourceExists("ExtensionTax-CONV"))
            //    {
            //        System.Diagnostics.EventLog.CreateEventSource("ExtensionTax-CONV", "ExtensionTax-CONV");
            //    }
            //    eventLog1.Source = "ExtensionTax-CONV";
            //    eventLog1.Log = "ExtensionTax-CONV";
            //}
        }

        #region StartService Function
        //StartService Method - Gets all the Data from EfileHold table, Converts to IRSSchema, Stores it into IRSSchema Table.
        public void StartService(string UserData)
        {
            try
            {

                // sWAPNSH

                ConverttoIRSSchema(UserData);

                //    if (GetSecurityInfo())
                //    {
                //        TaxXMLtoIRSSchemaBL taxXMLtoIRSSchemaBL = new TaxXMLtoIRSSchemaBL();
                //        //Gets all the XML which are not converted to IRS Schema
                //        //get the command timeout timeout value from app settings
                //        int.TryParse(Utilities.GetAppSettingsValue("CommandTimeout"), out cmdTimeout);

                //        DataSet dsVendorData = taxXMLtoIRSSchemaBL.GetVendorDATA(State.Success, Stage.Initial, cmdTimeout);

                //        if (dsVendorData != null && dsVendorData.Tables.Count > 0 && dsVendorData.Tables[0].Rows.Count > 0)
                //        {
                //            foreach (DataRow dr in dsVendorData.Tables[0].Rows)
                //            {
                //                if (null != dr["EfileHoldID"] && null != dr["TaxObject"])
                //                {
                //                    taxXMLtoIRSSchemaBL.statusUpdate(string.Empty, 0, Stage.SchemaConversion, State.Blank, dr["EfileHoldID"].ToString());
                //                    ConverttoIRSSchema(dr);
                //                }
                //            }
                //        }
                //    }
                //    else
                //    {
                //        //  timerDisable = true;
                //    }
            }
            catch (Exception)
            {
                //    // eventLog1.WriteEntry(ex.Message + " .... " + ex.StackTrace + " .... " + ex.ToString(), EventLogEntryType.Error);
            }
        }
        #endregion

        #region Get Security Info from Web.Config

        private bool GetSecurityInfo()
        {
            try
            {
                TaxXMLtoIRSSchemaBL objTaxXMLtoIRSSchemaBL = new TaxXMLtoIRSSchemaBL();
                Hashtable htSecurityInfo = objTaxXMLtoIRSSchemaBL.GetSecurityInfo(FormType.Form7004);
                if (htSecurityInfo != null && htSecurityInfo.Count > 0)
                {
                    if (htSecurityInfo.Contains("UserName") && !string.IsNullOrEmpty(htSecurityInfo["UserName"].ToString()))
                    {
                        strUserName = htSecurityInfo["UserName"].ToString();
                    }
                    else
                    {
                        return false;
                    }

                    if (htSecurityInfo.Contains("EFIN") && !string.IsNullOrEmpty(htSecurityInfo["EFIN"].ToString()))
                    {
                        strEFIN = htSecurityInfo["EFIN"].ToString();
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
                return true;
            }
            catch (Exception ex)
            {
                //  eventLog1.WriteEntry(ex.Message, EventLogEntryType.Error);
                return false;
            }
        }
        #endregion

        #region Convert a submission to IRSSchema

        //  newly added by swapnesh
        private void ConverttoIRSSchema(string UserData)
        {
            //bool SuccessFullyConverted = false;
            IRSSchemaDE objIRSSchemaDE = new IRSSchemaDE();
            TaxXMLtoIRSSchemaBL taxXMLtoIRSSchemaBL = new TaxXMLtoIRSSchemaBL();
            try
            {
                objIRSSchemaDE.EfileHoldID = 1;// Utilities.GetInt32(dr["EfileHoldID"]);
                objIRSSchemaDE.AttachmentsCount = "0";  // dr["NoOfAttachments"].ToString();
                objIRSSchemaDE.VendorXML = UserData;// dr["TaxObject"].ToString();

                //get the tax year and tax period from the database
                objIRSSchemaDE.TaxYear = "2014"; //TO DO: get this value from DB.
                objIRSSchemaDE.TaxPeriod = "2014";//dr["TaxPeriod"].ToString(); //TO DO: get this value from DB.

                string IRSUserName = "00";
                if (!string.IsNullOrEmpty(strUserName))
                {
                    IRSUserName = strUserName;
                }

                string EFIN = "000000";
                if (!string.IsNullOrEmpty(strEFIN))
                {
                    EFIN = strEFIN;
                }

                //assign EFIN and IRS user name into schema object.
                objIRSSchemaDE.Originator_EFIN = strEFIN;
                if (ConfigurationSettings.AppSettings["originator_EFIN"] != null)
                {
                    objIRSSchemaDE.IRSUserName = ConfigurationSettings.AppSettings["originator_EFIN"].ToString();
                }
                JTL.Tax1040.BusinessObject.Tax1040 objTaxEngineBO = new JTL.Tax1040.BusinessObject.Tax1040();

                string formType ="1040EZ"; //dr["TaxReturnTypeID"].ToString();

                //Check the form type and load the conversion logic
                switch (formType)
                {
                    case FormType.Form1040EZ:
                        if (objIRSSchemaDE.TaxYear == TaxYear.Year2014)
                        {
                            ////call the conversion logic for Tax Year 2014
                            Tax1040EZConversion_TY2014 tax1040EZConversion_TY2014 = new Tax1040EZConversion_TY2014();
                            objIRSSchemaDE = tax1040EZConversion_TY2014.CreateTax1040EZchema(objIRSSchemaDE);
                        }
                        else if (objIRSSchemaDE.TaxYear == TaxYear.Year2013)
                        {
                            ////call the conversion logic for Tax Year 2009 & 2010
                            //Tax7004Conversion_TY2010 tax7004Conversion_TY2010 = new Tax7004Conversion_TY2010();
                            //objIRSSchemaDE = tax7004Conversion_TY2010.CreateTax7004Schema(objIRSSchemaDE);
                        }
                        break;

                    case FormType.Form1040A:

                        //generating IRSReturn xml based on the TaxYear and Quarter of the Return filed
                        if (objIRSSchemaDE.TaxYear == TaxYear.Year2009)
                        {
                            //call the conversion logic for Tax Year 2009 & 2010
                            //Tax7004Conversion_TY2009 tax7004Conversion_TY2009 = new Tax7004Conversion_TY2009();
                            //objIRSSchemaDE = tax7004Conversion_TY2009.CreateTax7004Schema(objIRSSchemaDE);
                        }

                        break;


                    case FormType.Form1040:

                        //generating IRSReturn xml based on the TaxYear and Quarter of the Return filed
                        if (objIRSSchemaDE.TaxYear == TaxYear.Year2014)
                        {
                            //call the conversion logic for Tax Year  2009 & 2010
                            Tax1040EZConversion_TY2014 tax1040EZConversion_TY2014 = new Tax1040EZConversion_TY2014();
                            objIRSSchemaDE = tax1040EZConversion_TY2014.CreateTax1040EZchema(objIRSSchemaDE);
                        } //generating IRSReturn xml based on the TaxYear and Quarter of the Return filed
                        else if (objIRSSchemaDE.TaxYear == TaxYear.Year2013)
                        {
                            ////call the conversion logic for Tax Year  2009 & 2010
                            //Tax1040EZConversion_TY2014 tax2350Conversion_TY2013 = new Tax2350Conversion_TY2013();
                            //objIRSSchemaDE = tax2350Conversion_TY2013.CreateTax2350Schema(objIRSSchemaDE);
                        }
                        break;

                }

                if (objIRSSchemaDE.IsIRSSchemaConverted)
                {
                    objIRSSchemaDE = GenerateIRSSubmissionManifest(objIRSSchemaDE, formType, EFIN);
                    if (objIRSSchemaDE.IsManifestGenerated)
                    {
                        objIRSSchemaDE.Status = Status.Converted2290XmlToIRSSchema;
                        SetIRSShema(objIRSSchemaDE, Stage.SchemaConversion, State.Success);
                        //taxXMLtoIRSSchemaBL.statusUpdate(string.Empty, 0, Stage.SchemaConversion, State.Success, dr["EfileHoldID"].ToString());
                    }
                    else
                    {
                        SendAlertMail("Manifest Generation Failed", objIRSSchemaDE);
                        taxXMLtoIRSSchemaBL.statusUpdate(string.Empty, 0, Stage.SchemaConversion, State.Error,objIRSSchemaDE.EfileHoldID.ToString());// dr["EfileHoldID"].ToString());
                    }
                }
                else
                {
                    SendAlertMail("Schema Conversion Failed", objIRSSchemaDE);
                    taxXMLtoIRSSchemaBL.statusUpdate(string.Empty, 0, Stage.SchemaConversion, State.Error, objIRSSchemaDE.EfileHoldID.ToString());// dr["EfileHoldID"].ToString());
                }
            }
            catch (Exception ex)
            {
                // Utilities.WriteException(objIRSSchemaDE, ex, eventLog1);
            }
        }

        private void ConverttoIRSSchema(DataRow dr)
        {
            //bool SuccessFullyConverted = false;
            IRSSchemaDE objIRSSchemaDE = new IRSSchemaDE();
            TaxXMLtoIRSSchemaBL taxXMLtoIRSSchemaBL = new TaxXMLtoIRSSchemaBL();
            try
            {
                objIRSSchemaDE.EfileHoldID = Utilities.GetInt32(dr["EfileHoldID"]);
                objIRSSchemaDE.AttachmentsCount = dr["NoOfAttachments"].ToString();
                objIRSSchemaDE.VendorXML = dr["TaxObject"].ToString();

                //get the tax year and tax period from the database
                objIRSSchemaDE.TaxYear = "2013"; //TO DO: get this value from DB.
                objIRSSchemaDE.TaxPeriod = dr["TaxPeriod"].ToString(); //TO DO: get this value from DB.

                string IRSUserName = "00";
                if (!string.IsNullOrEmpty(strUserName))
                {
                    IRSUserName = strUserName;
                }

                string EFIN = "000000";
                if (!string.IsNullOrEmpty(strEFIN))
                {
                    EFIN = strEFIN;
                }

                //assign EFIN and IRS user name into schema object.
                objIRSSchemaDE.Originator_EFIN = strEFIN;
                if (ConfigurationSettings.AppSettings["originator_EFIN"] != null)
                {
                    objIRSSchemaDE.IRSUserName = ConfigurationSettings.AppSettings["originator_EFIN"].ToString();
                }
                JTL.Tax1040.BusinessObject.Tax1040 objTaxEngineBO = new JTL.Tax1040.BusinessObject.Tax1040();

                string formType = dr["TaxReturnTypeID"].ToString();

                //Check the form type and load the conversion logic
                switch (formType)
                {
                    case FormType.Form1040EZ:
                        if (objIRSSchemaDE.TaxYear == TaxYear.Year2014)
                        {
                            ////call the conversion logic for Tax Year 2014
                            Tax1040EZConversion_TY2014 tax1040EZConversion_TY2014 = new Tax1040EZConversion_TY2014();
                            objIRSSchemaDE = tax1040EZConversion_TY2014.CreateTax1040EZchema(objIRSSchemaDE);
                        }
                        else if (objIRSSchemaDE.TaxYear == TaxYear.Year2013)
                        {
                            ////call the conversion logic for Tax Year 2009 & 2010
                            //Tax7004Conversion_TY2010 tax7004Conversion_TY2010 = new Tax7004Conversion_TY2010();
                            //objIRSSchemaDE = tax7004Conversion_TY2010.CreateTax7004Schema(objIRSSchemaDE);
                        }
                        break;

                    case FormType.Form1040A:

                        //generating IRSReturn xml based on the TaxYear and Quarter of the Return filed
                        if (objIRSSchemaDE.TaxYear == TaxYear.Year2009)
                        {
                            //call the conversion logic for Tax Year 2009 & 2010
                            //Tax7004Conversion_TY2009 tax7004Conversion_TY2009 = new Tax7004Conversion_TY2009();
                            //objIRSSchemaDE = tax7004Conversion_TY2009.CreateTax7004Schema(objIRSSchemaDE);
                        }

                        break;


                    case FormType.Form1040:

                        //generating IRSReturn xml based on the TaxYear and Quarter of the Return filed
                        if (objIRSSchemaDE.TaxYear == TaxYear.Year2014)
                        {
                            //call the conversion logic for Tax Year  2009 & 2010
                            Tax1040EZConversion_TY2014 tax1040EZConversion_TY2014 = new Tax1040EZConversion_TY2014();
                            objIRSSchemaDE = tax1040EZConversion_TY2014.CreateTax1040EZchema(objIRSSchemaDE);
                        } //generating IRSReturn xml based on the TaxYear and Quarter of the Return filed
                        else if (objIRSSchemaDE.TaxYear == TaxYear.Year2013)
                        {
                            ////call the conversion logic for Tax Year  2009 & 2010
                            //Tax1040EZConversion_TY2014 tax2350Conversion_TY2013 = new Tax2350Conversion_TY2013();
                            //objIRSSchemaDE = tax2350Conversion_TY2013.CreateTax2350Schema(objIRSSchemaDE);
                        }
                        break;

                }

                if (objIRSSchemaDE.IsIRSSchemaConverted)
                {
                    objIRSSchemaDE = GenerateIRSSubmissionManifest(objIRSSchemaDE, formType, EFIN);
                    if (objIRSSchemaDE.IsManifestGenerated)
                    {
                        objIRSSchemaDE.Status = Status.Converted2290XmlToIRSSchema;
                        SetIRSShema(objIRSSchemaDE, Stage.SchemaConversion, State.Success);
                        //taxXMLtoIRSSchemaBL.statusUpdate(string.Empty, 0, Stage.SchemaConversion, State.Success, dr["EfileHoldID"].ToString());
                    }
                    else
                    {
                        SendAlertMail("Manifest Generation Failed", objIRSSchemaDE);
                        taxXMLtoIRSSchemaBL.statusUpdate(string.Empty, 0, Stage.SchemaConversion, State.Error, dr["EfileHoldID"].ToString());
                    }
                }
                else
                {
                    SendAlertMail("Schema Conversion Failed", objIRSSchemaDE);
                    taxXMLtoIRSSchemaBL.statusUpdate(string.Empty, 0, Stage.SchemaConversion, State.Error, dr["EfileHoldID"].ToString());
                }
            }
            catch (Exception ex)
            {
                // Utilities.WriteException(objIRSSchemaDE, ex, eventLog1);
            }
        }
        #endregion

        #region Set IRSSchema Data

        private void SetIRSShema(IRSSchemaDE objIRSSchemaDE, string strStage, string strState)
        {
            try
            {
                TaxXMLtoIRSSchemaBL objTaxXMLtoIRSSchemaBL = new TaxXMLtoIRSSchemaBL();
                objTaxXMLtoIRSSchemaBL.SetIRSSchema(objIRSSchemaDE, strStage, strState);
            }
            catch (Exception ex)
            {
                //  Utilities.WriteException(objIRSSchemaDE, ex, eventLog1);
            }
        }
        #endregion

        #region Generate IRS Schema Submission Manifest

        private IRSSchemaDE GenerateIRSSubmissionManifest(IRSSchemaDE objIRSSchemaDE, string formType, string eFIN)
        {
            try
            {
                //For getting the Submission Manifest 
                IRSSubmissionManifest objIRSSubmissionManifest = new IRSSubmissionManifest();

                //get the xml and convert as a return object.
             //   JTL.Tax1040.BusinessObject.Tax1040 objTaxEngineBO = (JTL.Tax1040.BusinessObject.Tax1040)Utilities.DeSerialize(objIRSSchemaDE.VendorXML, typeof(JTL.Tax1040.BusinessObject.Tax1040));

                // Create tax engine object from Json string
                JTL.Tax1040.BusinessObject.Tax1040 objTaxEngineBO = JsonConvert.DeserializeObject<JTL.Tax1040.BusinessObject.Tax1040>(objIRSSchemaDE.VendorXML);


                objIRSSubmissionManifest.SubmissionId = objIRSSchemaDE.SubmissionId;
                if (string.IsNullOrEmpty(objIRSSchemaDE.Originator_EFIN))
                {
                    objIRSSubmissionManifest.EFIN = eFIN;
                }
                else
                {
                    objIRSSubmissionManifest.EFIN = objIRSSchemaDE.Originator_EFIN;
                }
                objIRSSubmissionManifest.GovernmentCode = GovernmentCodeType.IRS;



                if (formType == FormType.Form7004)
                {
                    objIRSSubmissionManifest.FederalSubmissionType = IRSSubmissionManifestFederalSubmissionType.Item1040;
                }

                //else if (formType == FormType.Form8868)
                //{
                //    objIRSSubmissionManifest.FederalSubmissionType = IRSSubmissionManifestFederalSubmissionType.Item8868;
                //}


                //else if (formType == FormType.Form4868)
                //{
                //    objIRSSubmissionManifest.FederalSubmissionType = IRSSubmissionManifestFederalSubmissionType.Item4868;
                //}
                //else if (formType == FormType.Form2350)
                //{
                //    objIRSSubmissionManifest.FederalSubmissionType = IRSSubmissionManifestFederalSubmissionType.Item2350;
                //}

                objIRSSubmissionManifest.TaxYear = DateTime.Now.Year.ToString();

                if (formType == FormType.Form1040EZ)
                {
                    Manifest1040EZ(objIRSSubmissionManifest, objTaxEngineBO);
                }                //Manifest 7004
                else if (formType == FormType.Form7004)
                {
                    Manifest7004(objIRSSubmissionManifest, objTaxEngineBO);
                }
                //Manifest8868
                else if (formType == FormType.Form8868)
                {
                    Manifest8868(objIRSSubmissionManifest, objTaxEngineBO);
                }

                 //Manifest4868
                else if (formType == FormType.Form4868)
                {
                    Manifest4868(objIRSSubmissionManifest, objTaxEngineBO);
                }
                //Manifest2350
                else if (formType == FormType.Form2350)
                {
                    Manifest2350(objIRSSubmissionManifest, objTaxEngineBO);
                }
                //AssignsEIN
                AssignsEIN(objIRSSubmissionManifest, objTaxEngineBO);

                //AssignsManifestXML
                string ManifestXML = AssignsManifestXML(objIRSSubmissionManifest);

                objIRSSchemaDE.IRSSubmissionManifest = ManifestXML;
                objIRSSchemaDE.IsManifestGenerated = true;
            }
            catch (Exception ex)
            {
                objIRSSchemaDE.IsManifestGenerated = false;
                //Utilities.WriteException(objIRSSchemaDE, ex, eventLog1);
            }
            return objIRSSchemaDE;
        }

        private static string AssignsManifestXML(IRSSubmissionManifest objIRSSubmissionManifest)
        {
            StringWriter strWriter = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(typeof(IRSSubmissionManifest));
            serializer.Serialize(strWriter, objIRSSubmissionManifest);
            string ManifestXML = string.Empty;
            ManifestXML = strWriter.ToString();

            //ManifestXML = ManifestXML.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
            //ManifestXML = ManifestXML.Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"", "xmlns=\"http://www.irs.gov/efile\"");
            //ManifestXML = ManifestXML.Replace("xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", "xmlns:efile=\"http://www.irs.gov/efile\"");

            ManifestXML = ManifestXML.Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" ", "");
            ManifestXML = ManifestXML.Replace("xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" ", "");

            //added this line to add xmlns namespace with prefix 'efile'
            ManifestXML = ManifestXML.Replace("<IRSSubmissionManifest xmlns=\"http://www.irs.gov/efile\">", "<IRSSubmissionManifest xmlns=\"http://www.irs.gov/efile\" xmlns:efile=\"http://www.irs.gov/efile\">");
            return ManifestXML;
        }

        private static void AssignsEIN(IRSSubmissionManifest objIRSSubmissionManifest, JTL.Tax1040.BusinessObject.Tax1040 objTaxEngineBO)
        {

            //assign EIN

            if (objIRSSubmissionManifest.FederalSubmissionType == IRSSubmissionManifestFederalSubmissionType.Item4868)
            {
                //if (objTaxEngineBO != null
                //   && objTaxEngineBO.Tax4868BO != null
                //    && objTaxEngineBO.Tax4868BO.Tax4868Part1BO != null)
                //{
                //    if (!string.IsNullOrEmpty(objTaxEngineBO.Tax4868BO.Tax4868Part1BO.SSN))
                //    {
                //        objIRSSubmissionManifest.TIN = Utilities.RemoveHyphens(objTaxEngineBO.Tax4868BO.Tax4868Part1BO.SSN);
                //    }
                //}
            }
            else if (objIRSSubmissionManifest.FederalSubmissionType == IRSSubmissionManifestFederalSubmissionType.Item2350)
            {
                //if (objTaxEngineBO != null
                //  && objTaxEngineBO.Tax2350BO != null
                //   && objTaxEngineBO.Tax2350BO.Tax2350Part1BO != null)
                //{
                //    if (!string.IsNullOrEmpty(objTaxEngineBO.Tax2350BO.Tax2350Part1BO.SSN))
                //    {
                //        objIRSSubmissionManifest.TIN = Utilities.RemoveHyphens(objTaxEngineBO.Tax2350BO.Tax2350Part1BO.SSN);
                //    }
                //}
            }
            else
            {
                //if (objTaxEngineBO != null
                //   && objTaxEngineBO.BusinessInformationBO != null)
                //{
                //    if (!string.IsNullOrEmpty(objTaxEngineBO.BusinessInformationBO.Ein))
                //    {
                //        objIRSSubmissionManifest.TIN = Utilities.RemoveHyphens(objTaxEngineBO.BusinessInformationBO.Ein);
                //    }
                //    else if (!string.IsNullOrEmpty(objTaxEngineBO.BusinessInformationBO.Ssn))
                //    {
                //        objIRSSubmissionManifest.TIN = Utilities.RemoveHyphens(objTaxEngineBO.BusinessInformationBO.Ssn).Trim();
                //    }
                //    else if (!string.IsNullOrEmpty(objTaxEngineBO.BusinessInformationBO.Itin))
                //    {
                //        objIRSSubmissionManifest.TIN = Utilities.RemoveHyphens(objTaxEngineBO.BusinessInformationBO.Itin).Trim();
                //    }
                //}
            }


        }

        #region Manifest4868
        private static void Manifest4868(IRSSubmissionManifest objIRSSubmissionManifest, JTL.Tax1040.BusinessObject.Tax1040 objTaxEngineBO)
        {
            //if (objTaxEngineBO != null && objTaxEngineBO.Tax4868BO != null)
            //{
            //    //assign tax period start date
            //    if (objTaxEngineBO.Tax4868BO.CalendarYear > 0)
            //    {
            //        objIRSSubmissionManifest.TaxPeriodBeginDate = Convert.ToDateTime("01/01/2013");
            //        objIRSSubmissionManifest.TaxPeriodEndDate = Convert.ToDateTime("12/31/2013");
            //        objIRSSubmissionManifest.TaxPeriodEndDateSpecified = true;
            //        objIRSSubmissionManifest.TaxPeriodBeginDateSpecified = true;
            //    }
            //    objIRSSubmissionManifest.TaxYear = "2013";

            //}
        }
        #endregion

        #region Manifest2350
        private static void Manifest2350(IRSSubmissionManifest objIRSSubmissionManifest, JTL.Tax1040.BusinessObject.Tax1040 objTaxEngineBO)
        {
            //if (objTaxEngineBO != null && objTaxEngineBO.Tax2350BO != null)
            //{
            //    //assign tax period start date
            //    if (objTaxEngineBO.Tax2350BO.CalendarYear > 0)
            //    {
            //        objIRSSubmissionManifest.TaxPeriodBeginDate = Convert.ToDateTime("01/01/2013");
            //        objIRSSubmissionManifest.TaxPeriodEndDate = Convert.ToDateTime("12/31/2013");
            //        objIRSSubmissionManifest.TaxPeriodEndDateSpecified = true;
            //        objIRSSubmissionManifest.TaxPeriodBeginDateSpecified = true;
            //    }
            //    objIRSSubmissionManifest.TaxYear = "2013";

            // }
        }
        #endregion

        #region Manifest8868
        private static void Manifest8868(IRSSubmissionManifest objIRSSubmissionManifest, JTL.Tax1040.BusinessObject.Tax1040 objTaxEngineBO)
        {
            //if (objTaxEngineBO != null && objTaxEngineBO.Tax8868BO != null)
            //{
            //    //assign tax period start date
            //    if (objTaxEngineBO.Tax8868BO.TaxPeriodBeginDateSpecified)
            //    {
            //        objIRSSubmissionManifest.TaxPeriodBeginDate = objTaxEngineBO.Tax8868BO.TaxPeriodBeginDate;
            //        objIRSSubmissionManifest.TaxPeriodBeginDateSpecified = true;
            //    }

            //    else
            //    {
            //        if (objTaxEngineBO.Tax8868BO.Calendaryear > 0)
            //        {
            //            objIRSSubmissionManifest.TaxPeriodBeginDate = Convert.ToDateTime("01/01/2013");
            //            objIRSSubmissionManifest.TaxPeriodBeginDateSpecified = true;
            //        }
            //    }
            //    //assign tax period end date
            //    if (objTaxEngineBO.Tax8868BO.TaxPeriodEndDateSpecified)
            //    {
            //        objIRSSubmissionManifest.TaxPeriodEndDate = objTaxEngineBO.Tax8868BO.TaxPeriodEndDate;
            //        objIRSSubmissionManifest.TaxPeriodEndDateSpecified = true;
            //    }

            //    else
            //    {
            //        if (objTaxEngineBO.Tax8868BO.Calendaryear > 0)
            //        {
            //            objIRSSubmissionManifest.TaxPeriodEndDate = Convert.ToDateTime("12/31/2013");
            //            objIRSSubmissionManifest.TaxPeriodEndDateSpecified = true;
            //        }
            //    }
            //    objIRSSubmissionManifest.TaxYear = "2013";

            //}
        }
        #endregion


        #region Manifest7004
        private static void Manifest1040EZ(IRSSubmissionManifest objIRSSubmissionManifest, JTL.Tax1040.BusinessObject.Tax1040 objTaxEngineBO)
        {
            //if (objTaxEngineBO != null && objTaxEngineBO. != null)
            //{

            //}

        }
        #endregion


        #region Manifest7004
        private static void Manifest7004(IRSSubmissionManifest objIRSSubmissionManifest, JTL.Tax1040.BusinessObject.Tax1040 objTaxEngineBO)
        {
            //if (objTaxEngineBO != null && objTaxEngineBO.Tax7004BO != null)
            //{
            //    if (objTaxEngineBO.Tax7004BO.Part3BO != null)
            //    {
            //        //assign tax period start date
            //        if (objTaxEngineBO.Tax7004BO.Part3BO.TaxPeriodBeginDateSpecified)
            //        {
            //            objIRSSubmissionManifest.TaxPeriodBeginDate = objTaxEngineBO.Tax7004BO.Part3BO.TaxPeriodBeginDate;
            //            objIRSSubmissionManifest.TaxPeriodBeginDateSpecified = true;
            //        }

            //        else
            //        {
            //            if (objTaxEngineBO.Tax7004BO.Part3BO.CalendarYear > 0)
            //            {
            //                objIRSSubmissionManifest.TaxPeriodBeginDate = Convert.ToDateTime("01/01/2013");
            //                objIRSSubmissionManifest.TaxPeriodBeginDateSpecified = true;
            //            }
            //        }
            //        //assign tax period end date
            //        if (objTaxEngineBO.Tax7004BO.Part3BO.TaxPeriodEndDateSpecified)
            //        {
            //            objIRSSubmissionManifest.TaxPeriodEndDate = objTaxEngineBO.Tax7004BO.Part3BO.TaxPeriodEndDate;
            //            objIRSSubmissionManifest.TaxPeriodEndDateSpecified = true;
            //        }

            //        else
            //        {
            //            if (objTaxEngineBO.Tax7004BO.Part3BO.CalendarYear > 0)
            //            {
            //                objIRSSubmissionManifest.TaxPeriodEndDate = Convert.ToDateTime("12/31/2013");
            //                objIRSSubmissionManifest.TaxPeriodEndDateSpecified = true;
            //            }
            //        }

            //        //assign Tax Year-- hard coded by Ravi to test 2008 schema 
            //        //if (!string.IsNullOrEmpty(objTaxEngineBO.Tax7004BO.CreateReturnBO.TaxYear))
            //        //{
            //        //objIRSSubmissionManifest.TaxYear = objTaxEngineBO.Tax7004BO.CreateReturnBO.TaxYear;
            //        objIRSSubmissionManifest.TaxYear = "2013";
            //        //}
            //    }
            //}
        }
        #endregion
        #endregion

        #region Send Alert Mail
        private void SendAlertMail(string Message, IRSSchemaDE objIRSSchemaDE)
        {
            try
            {
                string SubId = " *** ";
                string HoldId = " *** ";
                if (!string.IsNullOrEmpty(objIRSSchemaDE.SubmissionId))
                {
                    SubId = objIRSSchemaDE.SubmissionId;
                }
                if (objIRSSchemaDE.EfileHoldID > 0
                    && !string.IsNullOrEmpty(objIRSSchemaDE.EfileHoldID.ToString()))
                {
                    HoldId = objIRSSchemaDE.EfileHoldID.ToString();
                }
                string exceptValues = string.Format("Submission Id= {0} ******* Hold Id = {1} ", SubId, HoldId);
                // eventLog1.WriteEntry(Message + " for" + " " + "\n" + exceptValues + "\n", EventLogEntryType.FailureAudit);

                Utilities.SendMail(Message, objIRSSchemaDE.SubmissionId);
            }
            catch (Exception ex)
            {
                //    Utilities.WriteException(objIRSSchemaDE, ex, eventLog1);
            }
        }
        #endregion


        #region On Start and On Stop Events

        //protected override void OnStart(string[] args)
        //{
        //    //System.Threading.Thread.Sleep(sleepInterval);
        //    timer.Start();
        //}

        //protected override void OnStop()
        //{
        //    // TODO: Add code here to perform any tear-down necessary to stop your service.
        //}
        #endregion
    }
}