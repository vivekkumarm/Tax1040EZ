using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Collections;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class TaxXMLtoIRSSchemaDAL : EfileDAL
    {
        #region Constants

        // Stored Procedure
        internal class StoredProcedure
        {
            public const string sp_8849EfileHoldRecordsGetOnStatus = "EfileHoldRecordsGetOnStatus";
            public const string sp_8849StatusUpdate = "StatusUpdate";
          
            public const string sp_1040EZEfileIRSSchemaCreate ="usp_efile_irs_schema_insert";
            public const string sp_8849EfileIRSSchemaCreate = "EfileIRSSchemaCreate";
            public const string EFileNameControlGetonEfileHoldID = "EFileNameControlGetonEfileHoldID";

            public const string sp_8849EfileHoldAttachmentGetOnEfileHoldID = "EfileHoldAttachmentGetOnEfileHoldID";
            public const string EfileNameControlGet = "EFileNameControlGet";
            public const string EfileIRSSchemaCreate = "EfileIRSSchemaCreate";
            public const string EfileIRSSchemaGetTodayCount = "EfileIRSSchemaGetTodayCount";
            public const string StatusUpdate = "StatusUpdate";
            public const string EfileErrorCreate = "EfileErrorCreate";
            public const string EfileHoldGetIRSSchemaCount = "EfileHoldGetIRSSchemaCount";
            public const string EfileErrorIRSSchemaCreate = "EfileErrorIRSSchemaCreate";

            public const string HashGet = "STCStateCodeGet";

            public const string stcEfileCOntrolGetOnFormType = "stcEfileCOntrolGetOnFormType";

            //e-file schema version get
            public const string StcSchemaVersionGet = "StcSchemaVersionGet";
        }

        // Parameters
        internal class Parameters
        {
            public const string ReturnID = "ReturnID";
            public const string EfileHoldID = "efile_hold_id";
            public const string EfileIRSSchema = "efile_irs_schema";
            public const string ManifestXML = "manifest_xml";
            public const string Count = "Count";
            public const string SubmissionID = "submission_id";
            public const string StatusID = "status_id";
            public const string ErrorCode = "ErrorCode";
            public const string ErrorMessage = "ErrorMessage";
            public const string ErrorClassification = "ErrorClassification";
            public const string Action = "Action";
            public const string ErrorType = "ErrorType";
            public const string ReturnType = "ReturnType";
            public const string Stage = "stage";
            public const string State = "state";

            public const string FormType = "FormType";
            public const string NameControl = "NameControl";

            //parameters to get e-file schema version
            public const string Year = "Year";
            public const string Quarter = "Quarter";

            public const string TaxYear = "TaxYear";
            public const string TaxPeriod = "TaxPeriod";
            public const string SchemaVersion = "SchemaVersion";
            public const string SchemaLocation = "SchemaLocation";
        }

        #endregion

        #region Get Hold DATA

        public DataSet GetVendorDATA(string state, string stage, int cmdTimeout)
        {
            DataSet ds = new DataSet();
            InitializeTaxExcise_Efile(StoredProcedure.sp_8849EfileHoldRecordsGetOnStatus);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, stage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, state);
            cmd.CommandTimeout = cmdTimeout;
            return taxDB.ExecuteDataSet(cmd);
        }

        #endregion

        #region Get Name Control
        public string GetNameControl(int eFileHoldID)
        {
            InitializeTaxExcise_Efile(StoredProcedure.EfileNameControlGet);
            taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int64, eFileHoldID);
            IDataReader reader;
            reader = taxDB.ExecuteReader(cmd);
            if (reader.Read())
            {
                return reader[Parameters.NameControl].ToString();
            }
            return string.Empty;
        }
        #endregion

        #region Get Vendor Attachments

        public DataSet GetVendorAttachments(int EFileHoldID)
        {
            DataSet ds = new DataSet();
            InitializeTaxExcise_Efile(StoredProcedure.sp_8849EfileHoldAttachmentGetOnEfileHoldID);
            taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int64, EFileHoldID);
            return taxDB.ExecuteDataSet(cmd);
        }
        #endregion

        #region Set IRS Schema

        public void EfileIRSSchema(IRSSchemaDE objIRSSchemaDE, string strStage, string strState)
        {
            InitializeTaxExcise_Efile(StoredProcedure.sp_1040EZEfileIRSSchemaCreate);
            taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int32, objIRSSchemaDE.EfileHoldID);
            taxDB.AddInParameter(cmd, Parameters.EfileIRSSchema, DbType.Xml, objIRSSchemaDE.EfileIRSSchema);
            taxDB.AddInParameter(cmd, Parameters.ManifestXML, DbType.Xml, objIRSSchemaDE.IRSSubmissionManifest);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, objIRSSchemaDE.SubmissionId);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, objIRSSchemaDE.Status);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, strStage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, strState);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Get Today Count

        public long GetTodayCount()
        {
            long TodayCount = 0;
            InitializeTaxExcise_Efile(StoredProcedure.EfileIRSSchemaGetTodayCount);
            using (IDataReader datareader = taxDB.ExecuteReader(cmd))
            {
                if (datareader.Read())
                {
                    TodayCount = GetLong(datareader[Parameters.Count].ToString());
                }
            }
            return TodayCount;
        }
        #endregion

        #region Get EfileHoldGetIRSSchemaCount

        public long GetCount()
        {
            long TodayCount = 0;
            InitializeTaxExcise_Efile(StoredProcedure.EfileHoldGetIRSSchemaCount);
            using (IDataReader datareader = taxDB.ExecuteReader(cmd))
            {
                if (datareader.Read())
                {
                    TodayCount = GetLong(datareader[Parameters.Count].ToString());
                }
            }
            return TodayCount;
        }

        #endregion

        #region Set Error Status

        public void SetErrorStatus(long efileHoldID, int Status)
        {
            InitializeTaxExcise_Efile(StoredProcedure.StatusUpdate);
            taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int64, efileHoldID);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, Status);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Conversion Functions

        private int GetInt32(string value)
        {
            int iResult = 0;
            int.TryParse(value, out iResult);
            return iResult;
        }

        private long GetLong(string value)
        {
            long iResult = 0;
            long.TryParse(value, out iResult);
            return iResult;
        }
        #endregion

        #region Status Update
        public void statusUpdate(string submissionId, int status, string stage, string state, string efileHoldId)
        {
            InitializeTaxExcise_Efile(StoredProcedure.sp_8849StatusUpdate);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, submissionId);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, status);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, stage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, state);
            taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int64, efileHoldId);
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

        #region Get Schema Version
        public string GetSchemaVersion(string strYear, string taxPeriod, string returnType)
        {
            string strSchemaVersion = string.Empty;
            //initialize database
            InitializeTaxExcise_Static(StoredProcedure.StcSchemaVersionGet);
            //add parameters
            taxDB.AddInParameter(cmd, Parameters.ReturnType, DbType.String, returnType);
            taxDB.AddInParameter(cmd, Parameters.TaxYear, DbType.String, strYear);
            taxDB.AddInParameter(cmd, Parameters.TaxPeriod, DbType.String, taxPeriod);
            //execute command
            using (IDataReader dataReader = taxDB.ExecuteReader(cmd))
            {
                if(dataReader.Read())
                {
                    strSchemaVersion = dataReader["SchemaLocation"].ToString();
                }
            }

            //return value
            return strSchemaVersion;
        }
        #endregion

        #region Get Name Control
        public string GetNameControlByHoldId(int eFileHoldID)
        {
            string nameControl = string.Empty;
            InitializeTaxExcise_Efile(StoredProcedure.EFileNameControlGetonEfileHoldID);
            taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int64, eFileHoldID);

            if (taxDB.ExecuteScalar(cmd) != null)
            {
                nameControl =  taxDB.ExecuteScalar(cmd).ToString();
            }

            return nameControl;
        }
        #endregion
    }
}