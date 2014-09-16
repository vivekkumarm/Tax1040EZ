using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.BusinessObject
{
    public class EfileHoldAttachment
    {
        public long EfileHoldAttachmentId
        {
            get;
            set;
        }

        public long EFileHoldId
        {
            get;
            set;
        }
        
        public string AttachmentName
        {
            get;
            set;
        }

        public byte[] EfileAttachment
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }
    }
}
