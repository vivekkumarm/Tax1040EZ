using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace JTL.Tax1040.EfileServices.ZipandSendService.SenderChannel
{
    public class IRSSenderBL
    {
        #region Get All Efile Sender

        public DataSet GetAllEfileSender(int StageId, string State, int cmdTimeout)
        {
            IRSSenderDAL objIRSSenderDAL = new IRSSenderDAL();
            return objIRSSenderDAL.GetAllEfileSender(StageId, State, cmdTimeout);
        }
        #endregion

        #region Set Request, Response XML and SubmissionError

        public void SetRequestResponseXMLSubmissionError(IRSSenderDE objIRSSenderDE)
        {
            IRSSenderDAL objIRSSenderDAL = new IRSSenderDAL();
            objIRSSenderDAL.SetRequestResponseXMLSubmissionError(objIRSSenderDE);
        }
        #endregion

        #region Set SendSubmission Status

        public void SetSendSubmissionStatus(IRSSenderDE objIRSSenderDE, int stageId, string strState)
        {
            IRSSenderDAL objIRSSenderDAL = new IRSSenderDAL();
            objIRSSenderDAL.SetSendSubmissionStatus(objIRSSenderDE, stageId, strState);
        }
        #endregion

        #region Set Status

        public void SetStatus(string SubmissionId, int stageId, string State)
        {
            IRSSenderDAL objIRSSenderDAL = new IRSSenderDAL();
            objIRSSenderDAL.SetStatus(SubmissionId, stageId, State);
        }
        #endregion

        #region Set Submission Error // Commented

        //public void SetSubmissionError(IRSErrorDE objIRSErrorDE)
        //{
        //    try
        //    {
        //        IRSSenderDAL objIRSSenderDAL = new IRSSenderDAL();
        //        objIRSSenderDAL.SetSubmissionError(objIRSErrorDE);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        #endregion

        #region Get Security Info
        public Hashtable GetSecurityInfo(string strForm)
        {
            IRSSenderDAL objIRSSenderDAL = new IRSSenderDAL();
            return objIRSSenderDAL.GetSecurityInfo(strForm);
        }
        #endregion

        #region Get All IRSSystems

        public DataSet GetAllIRSSystems()
        {
            IRSSenderDAL objIRSSenderDAL = new IRSSenderDAL();
            return objIRSSenderDAL.GetAlIRSSystems();
        }
        #endregion
    }
}
