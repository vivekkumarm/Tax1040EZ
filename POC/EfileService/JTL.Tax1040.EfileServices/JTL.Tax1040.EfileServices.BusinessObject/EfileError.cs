using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.BusinessObject
{
    public class EfileError
    {
        public string Action
        {
            get;
            set;
        }

        public string ErrorClassification
        {
            get;
            set;
        }

        public string ErrorCode
        {
            get;
            set;
        }

        public int ErrorFixed
        {
            get;
            set;
        }

        public string ErrorMessage
        {
            get;
            set;
        }

        public int ErrorPickedUp
        {
            get;
            set;
        }

        public string SubmissionId
        {
            get;
            set;
        }
    }
}
