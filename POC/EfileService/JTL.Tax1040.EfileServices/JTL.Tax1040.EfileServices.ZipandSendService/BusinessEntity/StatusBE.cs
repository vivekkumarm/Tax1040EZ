using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.ZipandSendService
{
    public class StatusBE
    {
        private long _EfileHoldID;

        public long EfileHoldID
        {
            get { return _EfileHoldID; }
            set { _EfileHoldID = value; }
        }

        private string _SubmissionId;

        public string SubmissionId
        {
            get { return _SubmissionId; }
            set { _SubmissionId = value; }
        }

        private int _Status;

        public int StatusID
        {
            get { return _Status; }
            set { _Status = value; }
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
