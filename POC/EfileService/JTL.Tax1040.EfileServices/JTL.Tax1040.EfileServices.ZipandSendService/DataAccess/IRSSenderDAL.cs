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
            public const string StatusUpdate = "StatusUpdate";
            public const string EfileSenderGetForIRSEfile = "EfileSenderGetOnStatus";
            public const string EfileReceiverCreate = "EfileReceiverCreate";

            public const string EfileErrorCreate = "EfileErrorCreate";
            public const string EfileReqResCreate = "EfileReqResCreate";
            public const string stcEfileCOntrolGetOnFormType = "stcEfileCOntrolGetOnFormType";
            public const string STCIRSsystemsGet = "STCIRSsystemGetAll";
        }

        // Parameters
        internal class Parameters
        {
            public const string StatusID = "StatusID";
            public const string SubmissionID = "SubmissionID";
            public const string Request = "Request";
            public const string Response = "Response";
            public const string MessageID = "MessageID";
            public const string SendSubmissionStatus = "SendSubmissionStatus";

            public const string ErrorCode = "ErrorCode";
            public const string ErrorMessage = "ErrorMessage";
            public const string ErrorClassification = "ErrorClassification";
            public const string Action = "Action";
            public const string ServiceAction = "ServiceAction";

            public const string Stage = "Stage";
            public const string State = "State";
            public const string UserName = "UserName";
            public const string IRSSystemId = "IRSSystemId";
            public const string FormType = "FormType";
        }

        #endregion

        #region Get All Efile Sender

        public DataSet GetAllEfileSender(string Stage, string State, int cmdTimeout)
        {
            DataSet ds = new DataSet();
            InitializeTaxExcise_Efile(StoredProcedure.EfileSenderGetForIRSEfile);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, Stage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, State);

            //set the command timeout
            cmd.CommandTimeout = cmdTimeout;

            return taxDB.ExecuteDataSet(cmd);
        }

        #endregion

        #region Set Request, Response XML and SubmissionError

        public void SetRequestResponseXMLSubmissionError(IRSSenderDE objIRSSenderDE)
        {
            InitializeTaxExcise_Efile(StoredProcedure.EfileReqResCreate);
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

                //taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, strStage);
                //taxDB.AddInParameter(cmd, Parameters.State, DbType.String, strState);
            }
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Set SendSubmission Status

        public void SetSendSubmissionStatus(IRSSenderDE objIRSSenderDE, string strStage, string strState)
        {
            InitializeTaxExcise_Efile(StoredProcedure.EfileReceiverCreate);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, objIRSSenderDE.SubmissionID);
            taxDB.AddInParameter(cmd, Parameters.SendSubmissionStatus, DbType.Binary, objIRSSenderDE.SendSubmissionStatus);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, objIRSSenderDE.StatusID);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, strStage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, strState);
            taxDB.AddInParameter(cmd, Parameters.IRSSystemId, DbType.String, objIRSSenderDE.UserName);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Set Status

        public void SetStatus(string SubmissionId, string Stage, string State)
        {
            InitializeTaxExcise_Efile(StoredProcedure.StatusUpdate);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, SubmissionId);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.String, 0);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, Stage);
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
            InitializeTaxExcise_Static(StoredProcedure.stcEfileCOntrolGetOnFormType);
            taxDB.AddInParameter(cmd, Parameters.FormType, DbType.String, strForm);
            using (IDataReader datareader = taxDB.ExecuteReader(cmd))
            {
                while (datareader.Read())
                {
                    htControlNames.Add(datareader["ControlName"], datareader["ControlValue"]);
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