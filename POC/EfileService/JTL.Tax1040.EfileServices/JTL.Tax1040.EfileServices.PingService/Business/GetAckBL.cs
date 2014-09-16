using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace JTL.Tax1040.EfileServices.PingService
{
    public class GetAckBL
    {
        #region Get list of SubmissionIDs
        public List<string> GetSubmissionIDs(string Stage, string State)
        {
            GetAckDAL getAckDAL = new GetAckDAL();
            return getAckDAL.GetSubmissionIDs(Stage, State);
        }
        #endregion

        #region Get list of Submission
        public List<GetAckDE> GetSubmissionRecords(string Stage, string State)
        {
            GetAckDAL getAckDAL = new GetAckDAL();
            return getAckDAL.GetSubmissionRecords(Stage, State);
        }
        #endregion


        #region Store Attachment
        public void SaveAckAttachment(byte[] attachment, string submissionID, string strStage, string strState)
        {
            GetAckDAL getAckDAL = new GetAckDAL();
            getAckDAL.SaveAckAttachment(attachment, submissionID, strStage, strState);
        }
        #endregion

        #region Save Acknowledgement Attachment Errors
        public void SaveAckAttachmentErrors(GetAckDE getAckDE, string strStage, string strState)
        {
            GetAckDAL getAckDAL = new GetAckDAL();
            getAckDAL.SaveAckAttachmentErrors(getAckDE, strStage, strState);
        }
        #endregion

        #region Store the Request, ResponseXML and SubmissionError
        public void StoreRequestResponseXMLSubmissionError(GetAckDE getAckDE)
        {
            GetAckDAL getAckDAL = new GetAckDAL();
            getAckDAL.SetRequestResponseXMLSubmissionError(getAckDE);
        }
        #endregion

        #region Set Status

        public void SetStatus(string SubmissionId, string Stage, string State)
        {
            GetAckDAL getAckDAL = new GetAckDAL();
            getAckDAL.SetStatus(SubmissionId, Stage, State);
        }
        #endregion

        #region Get Security Info
        public Hashtable GetSecurityInfo(string strForm)
        {
            GetAckDAL getAckDAL = new GetAckDAL();
            return getAckDAL.GetSecurityInfo(strForm);
        }
        #endregion
    }
}
