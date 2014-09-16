using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class BusinessValidationDAL : EfileDAL
    {
        #region Constants

        // Stored Procedure
        internal class StoredProcedure
        {
            public const string CreateError = "EfileErrorCreate";
            //public const string HashGet = "STCStateCodeGet";
            public const string EfileIRSSchemaGet = "EfileIRSSchemaGetOnStatus";
            public const string UpdateSchemaState = "StatusUpdate";
            public const string stcEfileCOntrolGetOnFormType = "usp_efile_control_get_on_form_type";
            public const string usp_return_status_update = "usp_return_status_update";
        }

        // Parameters
        internal class Parameters
        {
            public const string EfileHoldID = "EfileHoldID";
            public const string StatusID = "StatusID";
            public const string Efile_return_data_id = "efile_return_data_id";
            public const string Stage_id = "stage_id";
            public const string Stage = "Stage";
            public const string State = "State";
            public const string EfileIRSSchema = "EfileIRSSchema";
            public const string ManifestXML = "ManifestXML";
            public const string SubmissionID = "submission_id";
            public const string ProductID = "ProductId";
            public const string ErrorCode = "ErrorCode";
            public const string ErrorMessage = "ErrorMessage";
            public const string ErrorClassification = "ErrorClassification";
            public const string Action = "Action";
            public const string ErrorType = "ErrorType";
            public const string ReturnType = "return_type";
            public const string TaxReturnTypeID = "TaxReturnTypeID";
            public const string TaxYear = "Taxyear";
            public const string TaxPeriod = "Taxperiod";
            public const string FormType = "FormType";

        }

        #endregion

        #region Set Error Status
        public void SetErrorStatus(BusinessMessagesDE businessMessagesDE)
        {
            InitializeTaxExcise_Efile(StoredProcedure.CreateError);
            taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, businessMessagesDE.SubmissionID);
            taxDB.AddInParameter(cmd, Parameters.ErrorCode, DbType.String, businessMessagesDE.ErrorCode);
            taxDB.AddInParameter(cmd, Parameters.Action, DbType.String, businessMessagesDE.Action);
            taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, 0);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, businessMessagesDE.Stage);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, businessMessagesDE.State);
            taxDB.ExecuteNonQuery(cmd);
        }
        #endregion

        #region Get IRS Schema
        public List<IRSSchemaDE> GetIRSSchema()
        {
            List<IRSSchemaDE> listIRSSchemaBE = new List<IRSSchemaDE>();
            IRSSchemaDE iRSSchemaBE = null;
            InitializeTaxExcise_Efile(StoredProcedure.EfileIRSSchemaGet);
            taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, Stage.IRSSchemaValidation);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, State.Success);
            using (IDataReader reader = taxDB.ExecuteReader(cmd))
            {
                while (reader.Read())
                {
                    iRSSchemaBE = new IRSSchemaDE();
                    int eFileHoldID = 0;
                    if (int.TryParse(reader[Parameters.EfileHoldID].ToString(), out eFileHoldID))
                    {
                        iRSSchemaBE.EfileHoldID = eFileHoldID;
                    }
                    iRSSchemaBE.SubmissionId = reader[Parameters.SubmissionID].ToString();
                    iRSSchemaBE.EfileIRSSchema = reader[Parameters.EfileIRSSchema].ToString();
                    iRSSchemaBE.IRSSubmissionManifest = reader[Parameters.ManifestXML].ToString();
                    iRSSchemaBE.FormType = reader[Parameters.TaxReturnTypeID].ToString();
                    iRSSchemaBE.TaxYear = reader[Parameters.TaxYear].ToString();
                    iRSSchemaBE.TaxPeriod = reader[Parameters.TaxPeriod].ToString();
                    int productId = 0;
                    if (int.TryParse(reader[Parameters.ProductID].ToString(), out productId))
                    {
                        iRSSchemaBE.ProductID = productId;
                    }

                    listIRSSchemaBE.Add(iRSSchemaBE);
                }
            }
            return listIRSSchemaBE;
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


        //#region Update Schema State
        //// Updates the state of the schema.
        //public void UpdateSchemaState(IRSSchemaDE iRSSchemaDE)
        //{
        //    InitializeTaxExcise_Efile(StoredProcedure.UpdateSchemaState);
        //    taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, iRSSchemaDE.SubmissionId);
        //    taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int64, iRSSchemaDE.EfileHoldID);
        //    taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, iRSSchemaDE.Status);
        //    taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, iRSSchemaDE.Stage);
        //    taxDB.AddInParameter(cmd, Parameters.State, DbType.String, iRSSchemaDE.State);
        //    taxDB.ExecuteNonQuery(cmd);

        //}
        //#endregion


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
                    htControlNames.Add(datareader["control_name"], datareader["control_value"]);
                }
            }
            return htControlNames;
        }
        #endregion

    }
}