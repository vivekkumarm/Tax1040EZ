using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class BusinessMessagesDE
    {
        string errorMessage;

        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; }
        }

        string errorCode;

        public string ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
        }

        string errorCategory;

        public string ErrorCategory
        {
            get { return errorCategory; }
            set { errorCategory = value; }
        }

        string submissionID;

        public string SubmissionID
        {
            get { return submissionID; }
            set { submissionID = value; }
        }

        string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        int statusID;

        public int StatusID
        {
            get { return statusID; }
            set { statusID = value; }
        }

        string errortype;
        public string ErrorType
        {
            get { return errortype; }
            set { errortype = value; }

        }

        private string stage;

        public string Stage
        {
            get { return stage; }
            set { stage = value; }
        }

        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
    }
}