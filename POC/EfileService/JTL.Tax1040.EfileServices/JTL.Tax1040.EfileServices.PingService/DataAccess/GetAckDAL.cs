using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using System.Collections;


namespace JTL.Tax1040.EfileServices.PingService
{
    public class GetAckDAL : EfileDAL
    {
        #region Constants

        // Stored Procedure
        internal class StoredProcedure
        {
            public const string StatusUpdate = "StatusUpdate";
            //public const string GetSubmissionIDs = "EfileSenderGetOnStatus";
            //Created a new SP for getting SubmissionId - Peter
            public const string GetSubmissionIDs = "EfileGetAckGetOnStatus";
            public const string StoreEfileAttachments = "EfileReceiverUpdate";
            public const string EfileErrorCreate = "EfileErrorCreate";
            public const string EfileReqResCreate = "EfileReqResCreate";

            public const string stcEfileCOntrolGetOnFormType = "stcEfileCOntrolGetOnFormType";

        }

        // Parameters
        internal class Parameters
        {
            public const string statusID = "StatusID";
            public const string ReceiverType = "ReceiverType";
            public const string SubmissionID = "SubmissionID";
            public const string EfileAttachment = "AttachmentStatus";
            public const string ErrorCode = "ErrorCode";
            public const string ErrorMessage = "ErrorMessage";
            public const string ErrorClassification = "ErrorClassification";
            public const string Action = "Action";
            public const string Request = "Request";
            public const string Response = "Response";
            public const string MessageID = "MessageID";
            public const string ServiceAction = "ServiceAction";

            public const string Stage = "Stage";
            public const string State = "State";

            public const string FormType = "FormType";
        }

        internal class ReceiverType
        {
            public const string Acknowledgement = "GetAckStatus";
            public const string SubmissionStatus = "SendSubmissionStatus";
            public const string Schedule1Status = "GetSchedule1";
        }
        #endregion

        #region Get list of SubmissionIDs
        public List<string> GetSubmissionIDs(string Stage, string State)
        {
            List<string> submissionIDs = new List<string>();
            InitializeTaxExcise_Efile(StoredProcedure.GetSubmissionIDs);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, Stage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, State);
            using (IDataReader reader = taxDB.ExecuteReader(cmd))
            {
                while (reader.Read())
                {
                    submissionIDs.Add(reader["SubmissionID"].ToString());
                }
            }
            return submissionIDs;
        }
        #endregion

        #region Get list of Submission
        public List<GetAckDE> GetSubmissionRecords(string Stage, string State)
        {
            List<GetAckDE> getAckDEList = new List<GetAckDE>();

            InitializeTaxExcise_Efile(StoredProcedure.GetSubmissionIDs);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, Stage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, State);
            using (IDataReader reader = taxDB.ExecuteReader(cmd))
            {
                while (reader.Read())
                {
                    GetAckDE getAckDE = new GetAckDE();

                    if (!string.IsNullOrEmpty(reader["IRSSystemId"].ToString()))
                    {
                        getAckDE.UserName = reader["IRSSystemId"].ToString();
                    }

                    getAckDE.SubmissionID = reader["SubmissionID"].ToString();

                    getAckDEList.Add(getAckDE);
                }
            }
            return getAckDEList;
        }
        #endregion


        #region Save Acknowledgement Attachment
        public void SaveAckAttachment(byte[] attachment, string submissionID, string strStage, string strState)
        {
            InitializeTaxExcise_Efile(StoredProcedure.StoreEfileAttachments);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, submissionID);
            taxDB.AddInParameter(cmd, Parameters.ReceiverType, DbType.Binary, System.Text.Encoding.ASCII.GetBytes(ReceiverType.Acknowledgement));
            taxDB.AddInParameter(cmd, Parameters.EfileAttachment, DbType.Binary, attachment);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, strStage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, strState);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Set Request, Response XML and SubmissionError

        public void SetRequestResponseXMLSubmissionError(GetAckDE getAckDE)
        {
            InitializeTaxExcise_Efile(StoredProcedure.EfileReqResCreate);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, getAckDE.SubmissionID);
            taxDB.AddInParameter(cmd, Parameters.Request, DbType.String, getAckDE.RequestXML);
            taxDB.AddInParameter(cmd, Parameters.Response, DbType.String, getAckDE.ResponseXML);
            taxDB.AddInParameter(cmd, Parameters.MessageID, DbType.String, getAckDE.MessageID);
            taxDB.AddInParameter(cmd, Parameters.statusID, DbType.Int32, getAckDE.StatusID);
            taxDB.AddInParameter(cmd, Parameters.ServiceAction, DbType.String, getAckDE.ServiceAction);

            if (null != getAckDE.Error)
            {
                taxDB.AddInParameter(cmd, Parameters.ErrorCode, DbType.String, getAckDE.Error.ErrorCode);
                taxDB.AddInParameter(cmd, Parameters.ErrorMessage, DbType.String, getAckDE.Error.ErrorMessage);
                taxDB.AddInParameter(cmd, Parameters.ErrorClassification, DbType.String, getAckDE.Error.ErrorClassification);
                taxDB.AddInParameter(cmd, Parameters.Action, DbType.String, getAckDE.Action);
            }
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Save Acknowledgement Attachment Errors
        public void SaveAckAttachmentErrors(GetAckDE getAckDE, string strStage, string strState)
        {
            InitializeTaxExcise_Efile(StoredProcedure.EfileErrorCreate);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, getAckDE.SubmissionID);
            taxDB.AddInParameter(cmd, Parameters.ErrorCode, DbType.String, getAckDE.Error.ErrorCode);
            taxDB.AddInParameter(cmd, Parameters.ErrorMessage, DbType.String, getAckDE.Error.ErrorMessage);
            taxDB.AddInParameter(cmd, Parameters.ErrorClassification, DbType.String, getAckDE.Error.ErrorClassification);
            taxDB.AddInParameter(cmd, Parameters.Action, DbType.String, getAckDE.Action);
            taxDB.AddInParameter(cmd, Parameters.statusID, DbType.Int32, 0);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, strStage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, strState);

            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Set Status

        public void SetStatus(string SubmissionId, string Stage, string State)
        {
            InitializeTaxExcise_Efile(StoredProcedure.StatusUpdate);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, SubmissionId);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, Stage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, State);
            taxDB.ExecuteNonQuery(cmd);
        }
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
    }
}