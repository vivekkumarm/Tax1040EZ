using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.BusinessObject
{
    public class EfileReceiver
    {
        public int EfileReceiverId
        {
            get;
            set;
        }

        public string SubmissionId
        {
            get;
            set;
        }

        public byte[] SendSubmissionStatus
        {
            get;
            set;
        }

        public byte[] GetAckStatus
        {
            get;
            set;
        }

        public string AckXml
        {
            get;
            set;
        }

        public byte[] SubmissionStatus
        {
            get;
            set;
        }

        public byte[] Schedule1
        {
            get;
            set;
        }

        public string SystemId
        {
            get;
            set;
        }
    }
}
