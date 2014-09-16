using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.BusinessObject
{
    public class EfileRequestResponse
    {
        public long EfileReqResId
        {
            get;
            set;
        }

        public string SubmissionId
        {
            get;
            set;
        }

        public string MessageId
        {
            get;
            set;
        }

        public string Request
        {
            get;
            set;
        }

        public string Response
        {
            get;
            set;
        }

        public string Action
        {
            get;
            set;
        }

        public string StatusID
        {
            get;
            set;
        }
    }
}
