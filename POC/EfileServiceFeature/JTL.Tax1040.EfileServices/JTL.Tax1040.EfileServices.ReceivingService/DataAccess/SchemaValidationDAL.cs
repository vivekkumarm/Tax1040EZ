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
            public const string EfileErrorIRSSchemaCreate = "EfileErrorIRSSchemaCreate";
            public const string StcSchemaVersionGet = "usp_efile_schema_version_get";
            public const string usp_return_status_update = "usp_return_status_update";
        }

        // Parameters
        internal class Parameters
        {
            public const string ReturnID = "ReturnID";
            public const string EfileHoldID = "EfileHoldID";
            public const string Efile_return_data_id = "efile_return_data_id";
            public const string EfileIRSSchema = "EfileIRSSchema";
            public const string ManifestXML = "ManifestXML";
            public const string Count = "Count";
            public const string SubmissionID = "submission_id";
            public const string StatusID = "StatusID";
            public const string ErrorCode = "ErrorCode";
            public const string ErrorMessage = "ErrorMessage";
            public const string ErrorClassification = "ErrorClassification";
            public const string Action = "Action";
            public const string ErrorType = "ErrorType";

            public const string Stage = "Stage";
            public const string State = "State";
            public const string Stage_id = "stage_id";
            public const string ReturnType = "return_type";
            public const string TaxYear = "tax_year";
            public const string TaxPeriod = "tax_period";
            public const string SchemaVersion = "SchemaVersion";
            public const string SchemaLocation = "schema_location";


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
        public void EfileIRSErrorCreate(BusinessMessagesDE messagesDE)
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
        public void statusUpdate(string submissionId, string Efilereturndataid, int stage_id, string state)
        {
            InitializeTaxExcise_Efile(StoredProcedure.usp_return_status_update);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, submissionId);
            taxDB.AddInParameter(cmd, Parameters.Efile_return_data_id, DbType.Int64, Efilereturndataid);
            taxDB.AddInParameter(cmd, Parameters.Stage_id, DbType.String, stage_id);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, state);

            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Get SchemaVersion

        public string GetSchemaVersion(string returnType, string taxYear, string taxPeriod)
        {
            string strSchemaVersion = string.Empty;

            DataSet ds = new DataSet();
            InitializeTaxExcise_Efile(StoredProcedure.StcSchemaVersionGet);
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