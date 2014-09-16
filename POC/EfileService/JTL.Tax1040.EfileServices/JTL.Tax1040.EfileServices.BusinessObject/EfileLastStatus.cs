using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.BusinessObject
{
    public class EfileLastStatus
    {
        public int EfileLastStatusId
        {
            get;
            set;
        }

        public long EFileHoldId
        {
            get;
            set;
        }

        public int StatusId
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
