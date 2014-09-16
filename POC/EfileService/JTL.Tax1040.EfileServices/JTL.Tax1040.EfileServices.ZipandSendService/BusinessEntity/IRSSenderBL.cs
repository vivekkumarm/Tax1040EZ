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

        public DataSet GetAllEfileSender(string Stage, string State, int cmdTimeout)
        {
            IRSSenderDAL objIRSSenderDAL = new IRSSenderDAL();
            return objIRSSenderDAL.GetAllEfileSender(Stage, State, cmdTimeout);
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

        public void SetSendSubmissionStatus(IRSSenderDE objIRSSenderDE, string strStage, string strState)
        {
            IRSSenderDAL objIRSSenderDAL = new IRSSenderDAL();
            objIRSSenderDAL.SetSendSubmissionStatus(objIRSSenderDE, strStage, strState);
        }
        #endregion

        #region Set Status

        public void SetStatus(string SubmissionId, string Stage, string State)
        {
            IRSSenderDAL objIRSSenderDAL = new IRSSenderDAL();
            objIRSSenderDAL.SetStatus(SubmissionId, Stage, State);
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
