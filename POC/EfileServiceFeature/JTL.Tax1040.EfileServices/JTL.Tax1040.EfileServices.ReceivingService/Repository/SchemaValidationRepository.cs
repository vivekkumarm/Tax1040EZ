using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml;
using System.Xml.Schema;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class SchemaValidationBL
    {
        #region Declarations
        SchemaValidationDAL schemaValidationDAL;

        #endregion

        #region constant
        internal class Constant
        {
            public const string SchemaErrorCode = "IRSSCHVAL000001";
            public const string ActionType = "IRS Schema Validation";
            public const string Namespace = "http://www.irs.gov/efile:";
        }
        #endregion

        #region Constructor
        public SchemaValidationBL()
        {
            schemaValidationDAL = new SchemaValidationDAL();

            //listMessagesBE = new List<MessagesBE>();
        }
        #endregion

        #region GetHoldDATA

        public DataSet GetHoldDATA(string state, string stage)
        {
            return schemaValidationDAL.GetHoldDATA(state, stage);
        }
        #endregion

        #region Status Update
        public void statusUpdate(string submissionId, string Efilereturndataid, int stage_id, string state)
        {
            schemaValidationDAL.statusUpdate(submissionId, Efilereturndataid, stage_id, state);
        }
        #endregion

        #region Efile Error Create
        /// <summary>
        /// Efiles error create.
        /// </summary>
        /// <param name="messagesDE">MessagesDE.</param>
        public void EfileIRSErrorCreate(BusinessMessagesDE messagesDE)
        {
            schemaValidationDAL.EfileIRSErrorCreate(messagesDE);
        }
        #endregion

        #region GetSchemaVersion

        public string GetSchemaVersion(string returnType, string taxYear, string taxPeriod)
        {
            return schemaValidationDAL.GetSchemaVersion(returnType, taxYear, taxPeriod);
        }
        #endregion
    }
}