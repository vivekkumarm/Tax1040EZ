using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.BusinessObject
{
    public class InterestOnUnpaidDue
    {
        public DateTime QuarterStartDate
        {
            get;
            set;
        }

        public DateTime QuarterEndDate
        {
            get;
            set;
        }

        public double Amount
        {
            get;
            set;
        }

        public double interestRate
        {
            get;
            set;
        }

        public double NumberOfDays
        {
            get;
            set;
        }

        public double InterestAmount
        {
            get;
            set;
        }

        public double Balance
        {
            get;
            set;
        }
    }
}
