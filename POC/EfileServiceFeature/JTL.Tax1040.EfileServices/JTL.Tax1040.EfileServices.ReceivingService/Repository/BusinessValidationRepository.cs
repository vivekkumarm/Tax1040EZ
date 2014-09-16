using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class BusinessValidationBL
    {
        #region Declarations
        BusinessValidationDAL businessValidationDAL;
        #endregion

        #region Constructor
        public BusinessValidationBL()
        {
            businessValidationDAL = new BusinessValidationDAL();
        }
        #endregion

        #region Set Error Status
        public void SetErrorStatus(BusinessMessagesDE businessMessagesDE)
        {
            businessValidationDAL.SetErrorStatus(businessMessagesDE);
        }
        #endregion

        #region Get IRS Schema
        public List<IRSSchemaDE> GetIRSSchema()
        {
            return businessValidationDAL.GetIRSSchema();
        }

        #endregion

        #region Update Schema State
        public void statusUpdate(string submissionId, string Efilereturndataid, int stage_id, string state)
        {
            businessValidationDAL.statusUpdate(submissionId, Efilereturndataid, stage_id, state);
        }
        #endregion

        #region Get Security Info
        public Hashtable GetSecurityInfo(string strForm)
        {
            return businessValidationDAL.GetSecurityInfo(strForm);
        }
        #endregion

    }
}