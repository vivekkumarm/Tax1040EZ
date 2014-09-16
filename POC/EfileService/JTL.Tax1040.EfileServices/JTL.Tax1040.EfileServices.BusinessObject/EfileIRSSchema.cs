using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.BusinessObject
{
    class EfileIRSSchema
    {
        public int EfileIRSSchemaId
        {
            get;
            set;
        }

        public long EFileHoldId
        {
            get;
            set;
        }

        public string EfileiIRSSchema
        {
            get;
            set;
        }

        public string ManifestXml
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
