using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace JTL.Tax1040.EfileServices.ZipandSendService.SenderChannel
{
    public class IRSSenderDAL : EfileDAL
    {
        #region Constants

        // Stored Procedure
        internal class StoredProcedure
        {
            public const string StatusUpdate = "usp_return_status_update";
            public const string GetEfileSenderOnStatus = "usp_get_efile_sender_on_status";
            public const string PersistEfileReceiver = "usp_efile_receiver_persist";

            public const string EfileErrorCreate = "EfileErrorCreate";
            public const string PersistEfileRequestResponse = "usp_efile_request_response_persist";
            public const string GetEfileControlOnFormType = "usp_efile_control_get_on_form_type";
            public const string STCIRSsystemsGet = "STCIRSsystemGetAll";
        }

        // Parameters
        internal class Parameters
        {
            public const string StatusID = "status_id";
            public const string SubmissionID = "submission_id";
            public const string Request = "request";
            public const string Response = "response";
            public const string MessageID = "message_id";
            public const string SendSubmissionStatus = "send_submission_status";
            public const string ErrorCode = "error_code";
            public const string ErrorMessage = "error_message";
            public const string ErrorClassification = "error_classification";
            public const string Action = "action";
            public const string ServiceAction = "service_action";
            public const string StageId = "stage_id";
            public const string State = "state";

            public const string UserName = "UserName";
            public const string IRSSystemId = "IRSSystemId";
            public const string FormType = "FormType";

            public const string ControlName = "Control_Name";
            public const string ControlValue = "Control_Value";
        }

        #endregion

        #region Get All Efile Sender

        public DataSet GetAllEfileSender(int StageId, string State, int cmdTimeout)
        {
            DataSet ds = new DataSet();
            InitializeTaxExcise_Efile(StoredProcedure.GetEfileSenderOnStatus);
            taxDB.AddInParameter(cmd, Parameters.StageId, DbType.Int16, StageId);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, State);

            //set the command timeout
            cmd.CommandTimeout = cmdTimeout;

            return taxDB.ExecuteDataSet(cmd);
        }

        #endregion

        #region Set Request, Response XML and SubmissionError

        public void SetRequestResponseXMLSubmissionError(IRSSenderDE objIRSSenderDE)
        {
            InitializeTaxExcise_Efile(StoredProcedure.PersistEfileRequestResponse);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, objIRSSenderDE.SubmissionID);
            taxDB.AddInParameter(cmd, Parameters.Request, DbType.String, objIRSSenderDE.RequestXML);
            taxDB.AddInParameter(cmd, Parameters.Response, DbType.String, objIRSSenderDE.ResponseXML);
            taxDB.AddInParameter(cmd, Parameters.MessageID, DbType.String, objIRSSenderDE.MessageID);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, objIRSSenderDE.StatusID);
            taxDB.AddInParameter(cmd, Parameters.ServiceAction, DbType.String, objIRSSenderDE.ServiceAction);

            if (null != objIRSSenderDE.Error)
            {
                taxDB.AddInParameter(cmd, Parameters.ErrorCode, DbType.String, objIRSSenderDE.Error.ErrorCode);
                taxDB.AddInParameter(cmd, Parameters.ErrorMessage, DbType.String, objIRSSenderDE.Error.ErrorMessage);
                taxDB.AddInParameter(cmd, Parameters.ErrorClassification, DbType.String, objIRSSenderDE.Error.ErrorClassification);
                taxDB.AddInParameter(cmd, Parameters.Action, DbType.String, objIRSSenderDE.Error.Action);
                //taxDB.AddInParameter(cmd, Parameters.Stage, DbType.Int32, strStage);
                //taxDB.AddInParameter(cmd, Parameters.State, DbType.String, strState);
            }
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Set SendSubmission Status

        public void SetSendSubmissionStatus(IRSSenderDE objIRSSenderDE, int stageId, string strState)
        {
            InitializeTaxExcise_Efile(StoredProcedure.PersistEfileReceiver);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, objIRSSenderDE.SubmissionID);
            taxDB.AddInParameter(cmd, Parameters.SendSubmissionStatus, DbType.Binary, objIRSSenderDE.SendSubmissionStatus);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, objIRSSenderDE.StatusID);
            taxDB.AddInParameter(cmd, Parameters.StageId, DbType.Int32, stageId);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, strState);
            taxDB.AddInParameter(cmd, Parameters.IRSSystemId, DbType.String, objIRSSenderDE.UserName);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Set Status

        public void SetStatus(string SubmissionId, int stageId, string State)
        {
            InitializeTaxExcise_Efile(StoredProcedure.StatusUpdate);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, SubmissionId);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.String, 0);
            taxDB.AddInParameter(cmd, Parameters.StageId, DbType.String, stageId);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, State);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Set Submission Error  // Commented

        //public void SetSubmissionError(IRSErrorDE objIRSErrorDE)
        //{
        //    try
        //    {
        //        InitializeTax(StoredProcedure.EfileErrorCreate);
        //        taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, objIRSErrorDE.SubmissionID);
        //        taxDB.AddInParameter(cmd, Parameters.ErrorCode, DbType.String, objIRSErrorDE.ErrorCode);
        //        taxDB.AddInParameter(cmd, Parameters.ErrorMessage, DbType.String, objIRSErrorDE.ErrorMessage);
        //        taxDB.AddInParameter(cmd, Parameters.ErrorClassification, DbType.String, objIRSErrorDE.ErrorClassification);
        //        taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, objIRSErrorDE.StatusID);
        //        taxDB.AddInParameter(cmd, Parameters.Action, DbType.String, objIRSErrorDE.Action);
        //        taxDB.AddInParameter(cmd, Parameters.MessageID, DbType.String, objIRSErrorDE.MessageID);
        //        taxDB.ExecuteNonQuery(cmd);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        #endregion

        #region Get Security Info
        public Hashtable GetSecurityInfo(string strForm)
        {
            Hashtable htControlNames = new Hashtable();
            InitializeTaxExcise_Static(StoredProcedure.GetEfileControlOnFormType);
            taxDB.AddInParameter(cmd, Parameters.FormType, DbType.String, strForm);
            using (IDataReader datareader = taxDB.ExecuteReader(cmd))
            {
                while (datareader.Read())
                {
                    htControlNames.Add(datareader[Parameters.ControlName], datareader[Parameters.ControlValue]);
                }
            }
            return htControlNames;
        }
        #endregion

        #region Get All Efile Sender

        public DataSet GetAlIRSSystems()
        {
            DataSet ds = new DataSet();
            InitializeTaxExcise_Static(StoredProcedure.STCIRSsystemsGet);
            return taxDB.ExecuteDataSet(cmd);
        }
        #endregion
    }
}