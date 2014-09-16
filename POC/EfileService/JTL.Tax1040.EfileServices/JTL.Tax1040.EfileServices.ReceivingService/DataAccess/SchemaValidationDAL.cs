using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class SchemaValidationDAL : EfileDAL
    {
        #region Constants

        // Stored Procedure
        internal class StoredProcedure
        {
            public const string EfileIRSSchemaGetOnStatus = "EfileIRSSchemaGetOnStatus";
            public const string StatusUpdate = "StatusUpdate";
            public const string EfileErrorIRSSchemaCreate = "EfileErrorIRSSchemaCreate";
            public const string StcSchemaVersionGet = "StcSchemaVersionGet";
        }

        // Parameters
        internal class Parameters
        {
            public const string ReturnID = "ReturnID";
            public const string EfileHoldID = "EfileHoldID";
            public const string EfileIRSSchema = "EfileIRSSchema";
            public const string ManifestXML = "ManifestXML";
            public const string Count = "Count";
            public const string SubmissionID = "SubmissionID";
            public const string StatusID = "StatusID";
            public const string ErrorCode = "ErrorCode";
            public const string ErrorMessage = "ErrorMessage";
            public const string ErrorClassification = "ErrorClassification";
            public const string Action = "Action";
            public const string ErrorType = "ErrorType";

            public const string Stage = "Stage";
            public const string State = "State";

            public const string ReturnType = "ReturnType";
            public const string TaxYear = "TaxYear";
            public const string TaxPeriod = "TaxPeriod";
            public const string SchemaVersion = "SchemaVersion";
            public const string SchemaLocation = "SchemaLocation";


        }

        #endregion

        #region Get Hold DATA

        public DataSet GetHoldDATA(string state, string stage)
        {
            DataSet ds = new DataSet();
            InitializeTaxExcise_Efile(StoredProcedure.EfileIRSSchemaGetOnStatus);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, stage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, state);
            return taxDB.ExecuteDataSet(cmd);
        }

        #endregion

        #region Efile Error Create
        /// <summary>
        /// Efiles error create.
        /// </summary>
        /// <param name="messagesDE">MessagesDE.</param>
        public void EfileIRSErrorCreate(MessagesDE messagesDE)
        {

            InitializeTaxExcise_Efile(StoredProcedure.EfileErrorIRSSchemaCreate);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, messagesDE.SubmissionID);
            taxDB.AddInParameter(cmd, Parameters.ErrorCode, DbType.String, messagesDE.ErrorCode);
            taxDB.AddInParameter(cmd, Parameters.ErrorMessage, DbType.String, messagesDE.ErrorMessage);
            taxDB.AddInParameter(cmd, Parameters.ErrorClassification, DbType.String, messagesDE.ErrorCategory);
            taxDB.AddInParameter(cmd, Parameters.Action, DbType.String, messagesDE.Action);
            //taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, messagesDE.StatusID);
            taxDB.AddInParameter(cmd, Parameters.ErrorType, DbType.String, messagesDE.ErrorType);
            taxDB.ExecuteNonQuery(cmd);

        }
        #endregion

        #region Status Update
        public void statusUpdate(string submissionId, int status, string stage, string state, string efileHoldId)
        {
            InitializeTaxExcise_Efile(StoredProcedure.StatusUpdate);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, submissionId);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, status);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, stage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, state);
            taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int64, efileHoldId);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Get SchemaVersion

        public string GetSchemaVersion(string returnType, string taxYear, string taxPeriod)
        {
            string strSchemaVersion = string.Empty;

            DataSet ds = new DataSet();
            InitializeTaxExcise_Static(StoredProcedure.StcSchemaVersionGet);
            taxDB.AddInParameter(cmd, Parameters.ReturnType, DbType.String, returnType);
            if (!string.IsNullOrEmpty(taxYear))
            {
                taxDB.AddInParameter(cmd, Parameters.TaxYear, DbType.String, taxYear);
            }
            else
            {
                taxDB.AddInParameter(cmd, Parameters.TaxYear, DbType.String, DBNull.Value);
            }
            if (!string.IsNullOrEmpty(taxPeriod))
            {
                taxDB.AddInParameter(cmd, Parameters.TaxPeriod, DbType.String, taxPeriod);
            }
            else
            {
                taxDB.AddInParameter(cmd, Parameters.TaxPeriod, DbType.String, DBNull.Value);
            }

            using (IDataReader datareader = taxDB.ExecuteReader(cmd))
            {
                if (datareader.Read())
                {
                    if (datareader[Parameters.SchemaLocation] != null)
                    {
                        strSchemaVersion = datareader[Parameters.SchemaLocation].ToString();
                    }
                }
            }
            return strSchemaVersion;
        }

        #endregion
    }
}