using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;

namespace JTL.Tax1040.EfileServices.ZipandSendService
{
    public class IRSZipDAL : EfileDAL
    {
        #region Get Efile HoldID
        public List<long> GetEfileHoldID(int cmdTimeOut)
        {
            List<long> eFileHoldIDs = new List<long>();
            InitializeTaxExcise_Efile(StoredProcedures.EfileHoldRecordsGetOnStatus);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, Stage.BVAL);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, State.Success);
            cmd.CommandTimeout = cmdTimeOut;
            using (IDataReader reader = taxDB.ExecuteReader(cmd))
            {
                while (reader.Read())
                {
                    long eFileHoldID = 0;
                    if (long.TryParse(reader[Parameters.EfileHoldID].ToString(), out eFileHoldID))
                    {
                        eFileHoldIDs.Add(eFileHoldID);
                    }
                }
            }
            return eFileHoldIDs;
        }
        #endregion

        #region Get IRS Schema Xml
        public DataSet GetIRSSchemaXml(long eFileHoldID)
        {
            InitializeTaxExcise_Efile(StoredProcedures.EfileIRSSchemaGetOnEfileHoldID);
            taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int64, eFileHoldID);
            return taxDB.ExecuteDataSet(cmd);
        }
        #endregion

        #region SaveIntegratedZip
        public void SaveIntegratedZip(long eFileHoldID, byte[] integratedZip, string submissionID)
        {
            InitializeTaxExcise_Efile(StoredProcedures.SaveIntegratedZip);
            taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int32, eFileHoldID);
            taxDB.AddInParameter(cmd, Parameters.DimeAttachment, DbType.Binary, integratedZip);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, submissionID);
            taxDB.AddInParameter(cmd, Parameters.MessageID, DbType.String, DBNull.Value);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, Status.ZipCreatedAndReadyForSubmission);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, Stage.Zip);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, State.Success);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Set Error Status
        public void SetErrorStatus(long efileHoldID)
        {
            InitializeTaxExcise_Efile(StoredProcedures.StatusUpdate);
            taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int64, efileHoldID);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, Status.UnSuccessToCreateZip);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Update Status
        /// <summary>
        /// Updates the Status in the EfileLastStatus table.
        public void UpdateStatus(StatusBE statusBE)
        {
            InitializeTaxExcise_Efile(StoredProcedures.UpdateStageAndState);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, statusBE.SubmissionId);
            taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int64, statusBE.EfileHoldID);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, statusBE.StatusID);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, statusBE.Stage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, statusBE.State);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Constants

        #region StoredProcedures
        internal struct StoredProcedures
        {
            public const string EfileHoldRecordsGetOnStatus = "EfileHoldRecordsGetOnStatus";
            public const string EfileIRSSchemaGetOnEfileHoldID = "EfileIRSSchemaGetOnEfileHoldID";
            public const string SaveIntegratedZip = "EfileSenderCreate";
            public const string StatusUpdate = "StatusUpdate";
            public const string UpdateStageAndState = "StatusUpdate";

        }
        #endregion

        #region Parameters
        internal struct Parameters
        {
            public const string StatusID = "StatusID";
            public const string EfileHoldID = "EfileHoldID";
            public const string DimeAttachment = "DimeAttachment";
            public const string SubmissionID = "SubmissionID";
            public const string MessageID = "MessageID";
            public const string Stage = "Stage";
            public const string State = "State";
        }
        #endregion

        #region Constant
        internal struct Const
        {
            public const string Tax1040_Efile = "Tax1040_Efile";
        }
        #endregion

        #endregion
    }
}
