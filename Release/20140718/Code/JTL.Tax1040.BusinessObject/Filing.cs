using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.BusinessObject
{
    public class Filing
    {

        public bool HaveFiledPriorYearReturnElectronically { get; set; }
        public FederalFiling FederalFiling { get; set; }
        public List<StateFiling> StateFiling { get; set; }
        public string Email { get; set; }
    }
}
