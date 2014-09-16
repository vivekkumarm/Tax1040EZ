using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.BusinessObject
{
    public class EfileProgressStatus
    {
        public int EfileProgressId
        {
            get;
            set;
        }
        public long EFileHoldId
        {
            get;
            set;
        }
        public int ProgressStatus
        {
            get;
            set;
        }

        public string Stage
        {
            get;
            set;
        }

        public string State
        {
            get;
            set;
        }
    }
}
