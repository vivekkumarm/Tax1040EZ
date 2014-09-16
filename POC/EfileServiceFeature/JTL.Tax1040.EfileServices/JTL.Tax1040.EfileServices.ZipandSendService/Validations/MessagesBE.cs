using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.ZipandSendService
{
    public class MessagesDE
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
    }
}
