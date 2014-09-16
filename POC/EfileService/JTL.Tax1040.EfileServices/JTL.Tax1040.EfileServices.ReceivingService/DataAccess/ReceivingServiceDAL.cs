/* Saravanan N - 3rd July, 2014 - Newly added to store EfileReturnData values into DB */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using JTL.Tax1040.EfileServices.BusinessObject;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class ReceivingServiceDAL : EfileDAL
    {
        #region Constants

        // Stored Procedure
        internal class StoredProcedure
        {
            public const string PersistEfileReturnData = "usp_efile_return_data_persist";
            public const int ReceivingService = 1;
        }

        // Parameters
        internal class Parameters
        {
            public const string EfileReturnDataID = "efile_return_data_id";
            public const string SenderId = "sender_id";
            public const string UserDataId = "user_data_id";
            public const string ProductId = "product_id";
            public const string UserName = "user_name";
            public const string Email = "email";
            public const string NoOfAttachments = "no_of_attachments";
            public const string EncryptedTaxData = "encrypted_tax_data";
            public const string EnvIndicator = "env_indicator";
            public const string EfileTransId = "efile_trans_id";
            public const string TaxYear = "tax_year";
            public const string StageId = "stage_id";
            public const string State = "state";

            //Saravanan N - 3rd July, 2014 - At present below constants are unused.
            public const string ReturnType = "ReturnType";
            public const string TaxPeriod = "TaxPeriod";
            public const string SchemaVersion = "SchemaVersion";
            public const string SchemaLocation = "SchemaLocation";
        }

        #endregion

        // Create Efile return data into DB.
        public void PersistEfileReturnData(EfileReturnData eFileReturnData)
        {
            InitializeTaxExcise_Efile(StoredProcedure.PersistEfileReturnData);
            taxDB.AddInParameter(cmd, Parameters.SenderId, DbType.Int64, eFileReturnData.UserDataId);
            taxDB.AddInParameter(cmd, Parameters.UserDataId, DbType.Int64, eFileReturnData.UserDataId);
            taxDB.AddInParameter(cmd, Parameters.UserName, DbType.String, eFileReturnData.UserName);
            taxDB.AddInParameter(cmd, Parameters.EncryptedTaxData, DbType.String, eFileReturnData.EncryptedTaxData);
            taxDB.AddInParameter(cmd, Parameters.StageId, DbType.Int64, 1);
            taxDB.AddInParameter(cmd, Parameters.State, DbType.String, "Success");

            taxDB.ExecuteNonQuery(cmd);
        }

        //public void statusUpdate(string submissionId, int status, string stage, string state, string efileHoldId)
        //{
        //    InitializeTaxExcise_Efile(StoredProcedure.StatusUpdate);
        //    taxDB.AddInParameter(cmd, Parameters.SubmissionID, DbType.String, submissionId);
        //    taxDB.AddInParameter(cmd, Parameters.StatusID, DbType.Int32, status);
        //    taxDB.AddInParameter(cmd, Parameters.Stage, DbType.String, stage);
        //    taxDB.AddInParameter(cmd, Parameters.State, DbType.String, state);
        //    taxDB.AddInParameter(cmd, Parameters.EfileHoldID, DbType.Int64, efileHoldId);
        //    taxDB.ExecuteNonQuery(cmd);
        //}
    }
}