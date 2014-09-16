using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using JTL.Tax1040.EfileServices.Core.Process;

namespace JTL.Tax1040.EfileServices.ZipandSendService
{
    public class IRSZipDAL : EfileDAL
    {
        #region Get Efile Return Data ID
        public List<long> GetEfileReturnDataId(int cmdTimeOut)
        {
            List<long> eFileHoldIDs = new List<long>();
            InitializeTaxExcise_Efile(StoredProcedures.EfileReturnDataRecordsGetOnStatus);
            //TODO: Saravanan N - For Testing purpose Stage.SchemaConversion added. But it should be 'Business Validation' stage.
            taxDB.AddInParameter(cmd, Parameters.StageId, DbType.Int32, JTL.Tax1040.EfileServices.Core.Process.Stage.SchemaConversion); 
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, State.Success);
            cmd.CommandTimeout = cmdTimeOut;
            using (IDataReader reader = taxDB.ExecuteReader(cmd))
            {
                while (reader.Read())
                {
                    long eFileReturnDataId = 0;
                    if (long.TryParse(reader[Parameters.EfileReturnDataId].ToString(), out eFileReturnDataId))
                    {
                        eFileHoldIDs.Add(eFileReturnDataId);
                    }
                }
            }
            return eFileHoldIDs;
        }
        #endregion

        #region Get IRS Schema Xml
        public DataSet GetIRSSchemaXml(long eFileReturnDataId)
        {
            InitializeTaxExcise_Efile(StoredProcedures.EfileIRSSchemaGetOnEfileReturnDataID);
            taxDB.AddInParameter(cmd, Parameters.EfileReturnDataId, DbType.Int64, eFileReturnDataId);
            return taxDB.ExecuteDataSet(cmd);
        }
        #endregion

        #region SaveIntegratedZip
        public void SaveIntegratedZip(long eFileReturnDataId, byte[] integratedZip, string submissionID)
        {
            InitializeTaxExcise_Efile(StoredProcedures.SaveIntegratedZip);
            taxDB.AddInParameter(cmd, Parameters.EfileReturnDataId, DbType.Int32, eFileReturnDataId);
            taxDB.AddInParameter(cmd, Parameters.DimeAttachment, DbType.Binary, integratedZip);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, submissionID);
            taxDB.AddInParameter(cmd, Parameters.MessageID, DbType.String, DBNull.Value);
            //taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, Status.ZipCreatedAndReadyForSubmission);
            taxDB.AddInParameter(cmd, Parameters.StageId, DbType.String, Stage.Zip);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, State.Success);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Set Error Status
        //TODO: This method nowhere used. It can be removed. - Saravanan N - 10th July, 2014
        public void SetErrorStatus(long efileHoldID)
        {
            InitializeTaxExcise_Efile(StoredProcedures.StatusUpdate);
            taxDB.AddInParameter(cmd, Parameters.EfileReturnDataId, DbType.Int64, efileHoldID);
           // taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, Status.UnSuccessToCreateZip);
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
            taxDB.AddInParameter(cmd, Parameters.EfileReturnDataId, DbType.Int64, statusBE.EfileReturnDataID);
            //taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, statusBE.StatusID);
            taxDB.AddInParameter(cmd, Parameters.StageId, DbType.Int64, statusBE.Stage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, statusBE.State);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Constants

        #region StoredProcedures
        internal struct StoredProcedures
        {
            public const string EfileReturnDataRecordsGetOnStatus = "usp_get_efile_return_data_records_on_status";
            public const string EfileIRSSchemaGetOnEfileReturnDataID = "usp_efile_irs_schema_get_on_efile_return_data_id";
            public const string SaveIntegratedZip = "usp_efile_sender_persist";
            public const string StatusUpdate = "usp_return_status_update";
            public const string UpdateStageAndState = "usp_return_status_update";

        }
        #endregion

        #region Parameters
        internal struct Parameters
        {
            //public const string StatusID = "StatusID";  TODO: Saravanan N - 10th July, 2014 - It can be removed after testing.
            public const string EfileReturnDataId = "efile_return_data_id";
            public const string DimeAttachment = "dime_attachment";
            public const string SubmissionID = "submission_id";
            public const string MessageID = "message_id";
            public const string StageId = "stage_id";
            public const string State = "state";
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
