using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml;
using System.Xml.Schema;
using System.Collections;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class TaxXMLtoIRSSchemaBL
    {
        #region Declarations
        TaxXMLtoIRSSchemaDAL taxXMLtoIRSSchemaDAL;

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
        public TaxXMLtoIRSSchemaBL()
        {
            taxXMLtoIRSSchemaDAL = new TaxXMLtoIRSSchemaDAL();
        }
        #endregion

        #region GetVendorDATA

        public DataSet GetVendorDATA(string state, string stage, int cmdTimeout)
        {
            return taxXMLtoIRSSchemaDAL.GetVendorDATA(state, stage, cmdTimeout);
        }
        #endregion

        #region Get Vendor Attachments

        public DataSet GetVendorAttachments(int EFileHoldID)
        {
            DataSet dsVendorAttachments = taxXMLtoIRSSchemaDAL.GetVendorAttachments(EFileHoldID);
            if (null != dsVendorAttachments
                && dsVendorAttachments.Tables.Count > 0
                && dsVendorAttachments.Tables[0].Rows.Count > 0)
            {
                return dsVendorAttachments;
            }
            return null;
        }
        #endregion

        #region Get Name Control
        public string GetNameControl(int eFileHoldID)
        {
            return taxXMLtoIRSSchemaDAL.GetNameControl(eFileHoldID);
        }
        #endregion

        #region Set IRS Schema

        public void SetIRSSchema(IRSSchemaDE objIRSSchemaDE, string strStage, string strState)
        {
            if (objIRSSchemaDE != null)
            {
                //Store the IRSSchema to the EfileIRSSchema Table
                taxXMLtoIRSSchemaDAL.EfileIRSSchema(objIRSSchemaDE, strStage, strState);
            }
        }
        #endregion

        #region GetTodayCount

        public long GetTodayCount()
        {
            return taxXMLtoIRSSchemaDAL.GetTodayCount();
        }
        #endregion

        #region GetCount

        public long GetCount()
        {
            return taxXMLtoIRSSchemaDAL.GetCount();
        }
        #endregion

        #region Status Update
        public void statusUpdate(string submissionId, int status, string stage, string state, string efileHoldId)
        {
            taxXMLtoIRSSchemaDAL.statusUpdate(submissionId, status, stage, state, efileHoldId);
        }
        #endregion

        #region Get Security Info
        public Hashtable GetSecurityInfo(string strForm)
        {
            TaxXMLtoIRSSchemaDAL objTaxXMLtoIRSSchemaDAL = new TaxXMLtoIRSSchemaDAL();
            return objTaxXMLtoIRSSchemaDAL.GetSecurityInfo(strForm);
        }
        #endregion

        #region Get Schema Version
        public string GetSchemaVersion(string strYear, string strQuarter, string strFormType)
        {
            return taxXMLtoIRSSchemaDAL.GetSchemaVersion(strYear, strQuarter, strFormType);
        }
        #endregion

        #region Get NameControl ByHoldId
        public string GetNameControlByHoldId(int eFileHoldID)
        {
            return taxXMLtoIRSSchemaDAL.GetNameControlByHoldId(eFileHoldID);
        }
        #endregion
    }
}