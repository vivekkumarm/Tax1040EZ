//23Jul2014 Sathish changed state filling BO to State BO which is used in Sate Gate way

using System.Collections.Generic;
namespace JTL.Tax1040.BusinessObject
{
    public class Filing
    {
        public bool? HaveFiledPriorYearReturnElectronically { get; set; } //11Aug2014 Sathish changed to null property to do server side validation
        public FederalFiling FederalFiling { get; set; }
        //23Jul2014 Sathish changed state filling BO to State BO which is used in Sate Gate way
        public List<StateFiling> StateFiling { get; set; } 
        public string Email { get; set; }
    }
}
