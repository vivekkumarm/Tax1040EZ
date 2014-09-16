using JTL.Tax1040.EfileServices.Core.Process;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Timers;
using System.Web;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class BussinessValidation
    {
        #region Constants


        string strFormType = string.Empty;
        bool testMode = false;

        string[] nameControl = { "SGFN", "PMSN", "BSCN" };
        string[] eIN = { "11-1000004", "11-1000011", "11-1000012" };
        //  EINNameControlDE eINNameControl;
        List<EINNameControlDE> lstEINNameControl = new List<EINNameControlDE>();
        //const string ConstAllZerosSSN = "000-000-000";
        //const string ConstAllNinesSSN = "999-999-999";
        //const string ConstAllNinesEIN = "99-9999999";

        //const string ConstAllZerosPTIN = "00000000";
        //const string ConstAllNinesPTIN = "99999999";

        #region ErrorType
        internal class ErrorType
        {
            public const string ApplicationError = "IRSSchemaBusinessValidation";
        }
        #endregion

        #region ErrorTypeErrorCode
        internal class ErrorCode
        {








            #region 1-20
            public const string IRSAPPCON000001 = "F8849-001";
            public const string IRSAPPCON000002 = "F8849-002";
            public const string IRSAPPCON000003 = "F8849-003";
            public const string IRSAPPCON000004 = "F8849-004";
            public const string IRSAPPCON000005 = "F8849-005";
            public const string IRSAPPCON000006 = "F8849-006";
            public const string IRSAPPCON000007 = "F8849-007";
            public const string IRSAPPCON000008 = "F8849-008";
            public const string IRSAPPCON000009 = "F8849-009";
            public const string IRSAPPCON000010 = "F8849-010";
            public const string IRSAPPCON000011 = "F8849-011";
            public const string IRSAPPCON000012 = "F8849-012";
            public const string IRSAPPCON000013 = "F8849-013";
            public const string IRSAPPCON000014 = "F8849-014";
            public const string IRSAPPCON000015 = "F8849-015";
            public const string IRSAPPCON000016 = "F8849-016";
            public const string IRSAPPCON000017 = "F8849-017";
            public const string IRSAPPCON000018 = "F8849-018";
            public const string IRSAPPCON000019 = "F8849-019";
            public const string IRSAPPCON000020 = "F8849-020";
            #endregion
            #region 21-40
            public const string IRSAPPCON000021 = "F2290-021";
            public const string IRSAPPCON000022 = "F2290-022";
            public const string IRSAPPCON000023 = "F2290-023";
            public const string IRSAPPCON000024 = "F2290-024";
            public const string IRSAPPCON000025 = "F2290-025";
            public const string IRSAPPCON000026 = "FPYMT-018";
            public const string IRSAPPCON000027 = "FPYMT-030";
            public const string IRSAPPCON000028 = "FPYMT-032";
            public const string IRSAPPCON000029 = "R0000-002";
            public const string IRSAPPCON000030 = "R0000-003";
            public const string IRSAPPCON000031 = "R0000-004";
            public const string IRSAPPCON000032 = "R0000-007";
            public const string IRSAPPCON000033 = "R0000-014";
            public const string IRSAPPCON000034 = "R0000-015";
            public const string IRSAPPCON000035 = "R0000-018";
            public const string IRSAPPCON000036 = "R0000-019";
            public const string IRSAPPCON000037 = "R0000-020";
            public const string IRSAPPCON000038 = "R0000-021";
            public const string IRSAPPCON000039 = "R0000-022";
            public const string IRSAPPCON000040 = "R0000-023";
            #endregion
            #region 41-60
            public const string IRSAPPCON000041 = "R0000-024";
            public const string IRSAPPCON000042 = "R0000-029";
            public const string IRSAPPCON000043 = "R0000-030";
            public const string IRSAPPCON000044 = "R0000-031";
            public const string IRSAPPCON000045 = "R0000-032";
            public const string IRSAPPCON000046 = "R0000-033";
            public const string IRSAPPCON000047 = "R0000-034";
            public const string IRSAPPCON000048 = "R0000-046";
            public const string IRSAPPCON000049 = "R0000-049";
            public const string IRSAPPCON000050 = "R0000-050";
            public const string IRSAPPCON000051 = "R0000-051";
            public const string IRSAPPCON000052 = "R0000-052";
            public const string IRSAPPCON000053 = "R0000-054";
            public const string IRSAPPCON000054 = "R0000-055";
            public const string IRSAPPCON000055 = "R0000-057";
            public const string IRSAPPCON000056 = "R0000-058";
            public const string IRSAPPCON000057 = "R0000-060";
            public const string IRSAPPCON000058 = "R0000-067";
            public const string IRSAPPCON000059 = "R0000-069";
            public const string IRSAPPCON000060 = "R0000-900";
            #endregion
            #region 61-80
            public const string IRSAPPCON000061 = "R0000-901";
            public const string IRSAPPCON000062 = "R0000-904";
            public const string IRSAPPCON000063 = "R0000-905";
            public const string IRSAPPCON000064 = "R0000-906";
            public const string IRSAPPCON000065 = "T0000-001";
            public const string IRSAPPCON000066 = "T0000-002";
            public const string IRSAPPCON000067 = "T0000-003";
            public const string IRSAPPCON000068 = "T0000-013";
            public const string IRSAPPCON000069 = "T0000-014";
            public const string IRSAPPCON000070 = "T0000-015";
            public const string IRSAPPCON000071 = "T0000-016";
            public const string IRSAPPCON000072 = "T0000-017";
            public const string IRSAPPCON000073 = "T0000-900";
            public const string IRSAPPCON000074 = "T0000-901";
            public const string IRSAPPCON000075 = "T0000-902";
            public const string IRSAPPCON000076 = "X0000-005";
            public const string IRSAPPCON000077 = "X0000-007";
            public const string IRSAPPCON000078 = "X0000-008";
            public const string IRSAPPCON000079 = "X0000-009";
            public const string IRSAPPCON000080 = "X0000-010";
            #endregion
            #region 81-93
            public const string IRSAPPCON000081 = "X0000-011";
            public const string IRSAPPCON000082 = "X0000-012";
            public const string IRSAPPCON000083 = "X0000-015";
            public const string IRSAPPCON000084 = "X0000-017";
            public const string IRSAPPCON000085 = "X0000-018";
            public const string IRSAPPCON000086 = "X0000-019";
            public const string IRSAPPCON000087 = "X0000-020";
            public const string IRSAPPCON000088 = "X0000-021";
            public const string IRSAPPCON000089 = "X0000-022";
            public const string IRSAPPCON000090 = "X0000-024";
            public const string IRSAPPCON000091 = "X0000-025";
            public const string IRSAPPCON000092 = "X0000-026";
            public const string IRSAPPCON000093 = "X0000-027";
            #endregion
        }
        #endregion

        #endregion

        #region Declarations
        List<BusinessMessagesDE> listMessagesDE;
        Timer timer = new Timer();
        #endregion

        #region Constructor
        public BussinessValidation()
        {
            //InitializeComponent();
            //listMessagesDE = new List<BusinessMessagesDE>();

            ////Timer Settings  
            //timer.Enabled = true;
            //timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);

            //double Interval = 0;
            //if (double.TryParse(ConfigurationManager.AppSettings["TimerInterval"], out Interval))
            //{
            //    timer.Interval = Interval;
            //}

            ////Getting Event Log Name from App.Config
            //if (null != ConfigurationManager.AppSettings["BVAL_EventLogName"])
            //{
            //    string EventLogName = ConfigurationManager.AppSettings["BVAL_EventLogName"].ToString();
            //    if (!System.Diagnostics.EventLog.SourceExists(EventLogName))
            //    {
            //        System.Diagnostics.EventLog.CreateEventSource(EventLogName, EventLogName);
            //    }
            //    //eventLog1.Source = EventLogName;
            //    //eventLog1.Log = EventLogName;
            //}
            //else
            //{
            //    if (!System.Diagnostics.EventLog.SourceExists("7004-BVAL"))
            //    {
            //        System.Diagnostics.EventLog.CreateEventSource("7004-BVAL", "7004-BVAL");
            //    }
            //    eventLog1.Source = "7004-BVAL";
            //    eventLog1.Log = "7004-BVAL";
            //}

            //for (int i = 0; i < nameControl.Length; i++)
            //{
            //    eINNameControl = new EINNameControlDE();
            //    eINNameControl.NameControl = nameControl[i];
            //    eINNameControl.EIN = eIN[i];
            //    lstEINNameControl.Add(eINNameControl);
            //}
        }
        #endregion

        //protected override void OnStart(string[] args)
        //{
        //    // TODO: Add code here to start your service.
        //}

        //protected override void OnStop()
        //{
        //    // TODO: Add code here to perform any tear-down necessary to stop your service.
        //}

        #region Timer Elapsed Evet

        public void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //disabe the timer to avoid unwanted call before completion of process.
            timer.Enabled = false;

            //   Validate();

            //enable the timer, if the process completes.
            timer.Enabled = true;
        }
        #endregion

        public List<BusinessMessagesDE> Validate(IRSSchemaDE irsSchemaDE, long efile_return_data_id, bool finaltransmit)
        {
            List<BusinessMessagesDE> listBusinessMessagesDE = new List<BusinessMessagesDE>();
            try
            {
                BusinessValidationBL businessValidationBL = new BusinessValidationBL();

                // Getting the successfully converted IRSSchema xml.
                //   List<IRSSchemaDE> listIRSSchemaBE = businessValidationBL.GetIRSSchema();


                //if (null != listIRSSchemaBE && 0 < irsSchemaDE.Count)
                //{
                //    foreach (IRSSchemaDE irsSchemaDE in listIRSSchemaBE)
                //    {
                try
                {
                    // For the picked up IRSSchema, Initially we set the State to 'Blank' &
                    // Stage to 'BVAL' in the EfileLastStatus table.
                    //irsSchemaDE.Status = 0;
                    //irsSchemaDE.State = State.Blank;
                    //irsSchemaDE.Stage = Stage.BusinessValidation;

                    if (finaltransmit)
                    {
                        businessValidationBL.statusUpdate(irsSchemaDE.SubmissionId, efile_return_data_id.ToString(), Stage.BusinessValidation, State.InProgress);
                    }
                    //  strFormType = irsSchemaDE.FormType;

                    ////getting information of return mode for testing 
                    //Hashtable htSecurityInfo = businessValidationBL.GetSecurityInfo(irsSchemaDE.FormType);
                    //if (htSecurityInfo != null && htSecurityInfo.Count > 0)
                    //{
                    //    if (htSecurityInfo.Contains("TestIndicator") && !string.IsNullOrEmpty(htSecurityInfo["TestIndicator"].ToString())
                    //        && htSecurityInfo["TestIndicator"].ToString() == "T")
                    //    {
                    //        testMode = true;
                    //    }
                    //    else
                    //    {
                    //        testMode = false;
                    //    }
                    //}

                    //Calling Validations based on the FormType

                    switch (irsSchemaDE.FormType)
                    {
                        case FormType.Form1040EZ:
                            if (irsSchemaDE.TaxYear == TaxYear.Year2014)
                            {
                                Tax1040EzBusinessValidation2014v1_0 businessValidationTax1040EZ = new Tax1040EzBusinessValidation2014v1_0();
                                listBusinessMessagesDE = businessValidationTax1040EZ.BusinessValidations(irsSchemaDE.SubmissionId,
                                                         irsSchemaDE.EfileIRSSchema, irsSchemaDE.IRSSubmissionManifest, testMode);


                                //BusinessValidation2009v2_0 businessValidation2009 = new BusinessValidation2009v2_0();
                                //listBusinessMessagesDE = businessValidation2009.BusinessValidations(irsSchemaDE.SubmissionId,
                                //                         irsSchemaDE.EfileIRSSchema, irsSchemaDE.IRSSubmissionManifest, testMode);
                            }
                            else
                            {
                                //listBusinessMessagesDE = new List<BusinessMessagesDE>();
                                //BusinessValidation70042010v2_1 businessValidation70042010v2_1 = new BusinessValidation70042010v2_1();
                                //listBusinessMessagesDE = businessValidation70042010v2_1.BusinessValidations(irsSchemaDE.SubmissionId,
                                //                         irsSchemaDE.EfileIRSSchema, irsSchemaDE.IRSSubmissionManifest, testMode);
                            }
                            break;

                        case FormType.Form8868:
                            if (irsSchemaDE.TaxYear == TaxYear.Year2009)
                            {
                                //listBusinessMessagesDE = new List<BusinessMessagesDE>();
                                //BusinessValidation2009v1_2 businessValidation8868 = new BusinessValidation2009v1_2();
                                //listBusinessMessagesDE = businessValidation8868.BusinessValidations(irsSchemaDE.SubmissionId,
                                //                         irsSchemaDE.EfileIRSSchema, irsSchemaDE.IRSSubmissionManifest, testMode);
                            }
                            else
                            {
                                //listBusinessMessagesDE = new List<BusinessMessagesDE>();
                                //BusinessValidation2010v2_0 businessValidation8868 = new BusinessValidation2010v2_0();
                                //listBusinessMessagesDE = businessValidation8868.BusinessValidations(irsSchemaDE.SubmissionId,
                                //                         irsSchemaDE.EfileIRSSchema, irsSchemaDE.IRSSubmissionManifest, testMode);
                            }
                            break;


                        case FormType.Form4868:
                            if (irsSchemaDE.TaxYear == TaxYear.Year2009)
                            {
                                //listBusinessMessagesDE = new List<BusinessMessagesDE>();
                                //BusinessValidation2009v4_1 businessValidation4868 = new BusinessValidation2009v4_1();
                                //listBusinessMessagesDE = businessValidation4868.BusinessValidations(irsSchemaDE.SubmissionId,
                                //                       irsSchemaDE.EfileIRSSchema, irsSchemaDE.IRSSubmissionManifest, testMode);
                            }
                            else
                            {
                                //listBusinessMessagesDE = new List<BusinessMessagesDE>();
                                //BusinessValidation2010v3_0 businessValidation4868 = new BusinessValidation2010v3_0();
                                //listBusinessMessagesDE = businessValidation4868.BusinessValidations(irsSchemaDE.SubmissionId,
                                //                       irsSchemaDE.EfileIRSSchema, irsSchemaDE.IRSSubmissionManifest, testMode);
                            }
                            break;

                        case FormType.Form2350:
                            if (irsSchemaDE.TaxYear == TaxYear.Year2009)
                            {
                                //listBusinessMessagesDE = new List<BusinessMessagesDE>();
                                //BusinessValidation2009v4_1 businessValidation4868 = new BusinessValidation2009v4_1();
                                //listBusinessMessagesDE = businessValidation4868.BusinessValidations(irsSchemaDE.SubmissionId,
                                //                       irsSchemaDE.EfileIRSSchema, irsSchemaDE.IRSSubmissionManifest, testMode);
                            }
                            else
                            {
                                //listBusinessMessagesDE = new List<BusinessMessagesDE>();
                                //BusinessValidation2012v1_0 businessValidation2350 = new BusinessValidation2012v1_0();
                                //listBusinessMessagesDE = businessValidation2350.BusinessValidations(irsSchemaDE.SubmissionId,
                                //                       irsSchemaDE.EfileIRSSchema, irsSchemaDE.IRSSubmissionManifest, testMode);
                            }
                            break;

                    }

                    if (finaltransmit)
                    {
                        // If there is any error then we update the State to 'ERROR' in the EfileLastStatus table.
                        if (null != listBusinessMessagesDE && 0 < listBusinessMessagesDE.Count)
                        {
                            //foreach (BusinessMessagesDE businessMessagesDE in listBusinessMessagesDE)
                            //{
                            //    businessMessagesDE.State = State.Error;
                            //    businessMessagesDE.Stage = Stage.BusinessValidation;
                            //    businessMessagesDE.SubmissionID = irsSchemaDE.SubmissionId;
                            //    // businessValidationBL.SetErrorStatus(businessMessagesDE);
                            //}
                            businessValidationBL.statusUpdate(irsSchemaDE.SubmissionId, efile_return_data_id.ToString(), Stage.BusinessValidation, State.Error);

                        }
                        else
                        {
                            irsSchemaDE.State = State.Success;
                            businessValidationBL.statusUpdate(irsSchemaDE.SubmissionId, efile_return_data_id.ToString(), Stage.BusinessValidation, State.Success);
                        }
                        if (irsSchemaDE.State == State.Error)
                        {
                            SendAlertMail("Business Validation Failed", irsSchemaDE);
                        }
                    }

                }
                catch (Exception ex)
                {
                    ExceptionHandlingRepository.LogException(0, "Receiving Service Persist", ex);
                }
                //    }
                //}


            }

            catch (Exception ex)
            {
                ExceptionHandlingRepository.LogException(0, "Receiving Service Persist", ex);
            }

            return listBusinessMessagesDE;
        }

        #region Send Alert Mail
        private void SendAlertMail(string Message, IRSSchemaDE objIRSSchemaDE)
        {
            try
            {
                string SubId = " *** ";
                if (!string.IsNullOrEmpty(objIRSSchemaDE.SubmissionId))
                {
                    SubId = objIRSSchemaDE.SubmissionId;
                }
                string exceptValues = string.Format("Submission Id= {0} *******", SubId);
                // eventLog1.WriteEntry(Message + " for" + " " + "\n" + exceptValues + "\n", EventLogEntryType.FailureAudit);

                //  Utilities.SendMail(Message, objIRSSchemaDE.SubmissionId, strFormType);
            }
            catch (Exception ex)
            {
                WriteException(objIRSSchemaDE, ex);
            }
        }
        #endregion

        #region Write Exception Log
        private void WriteException(IRSSchemaDE objIRSSchemaDE, Exception ex)
        {
            string submissionId = " *** ";
            if (!string.IsNullOrEmpty(objIRSSchemaDE.SubmissionId))
            {
                submissionId = objIRSSchemaDE.SubmissionId;
            }
            string exceptValues = string.Format("Submission Id= {0} *******", submissionId);
            // eventLog1.WriteEntry(ex.Message + " " + "\n" + exceptValues + "\n" + ex.ToString(), EventLogEntryType.Error);
        }
        #endregion
    }
}