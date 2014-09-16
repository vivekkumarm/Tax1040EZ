//vincent-4 July 2014- Added a Description method Return status.
//23Jul2014 Sathish changed IRS Transmission BO to IRS BO
using JTL.Tax1040.Core.Object;
using System.ComponentModel;

namespace JTL.Tax1040.BusinessObject
{
  public  class FederalFiling
    {
      //23Jul2014 Sathish changed IRS Transmission BO to IRS BO
        public IRS IRS { set; get; }
        public bool? IsEfile { get; set; } //28Jul2014 Sathsih changed to nullable object since this option should be selected by the user
        public ReturnStatus ReturnStatus { get; set; }
        public string ReturnStatusDescription { 
            get{

                return TypeDescriptor.GetConverter(typeof(ReturnStatus)).ConvertToString(ReturnStatus);
            
            } 
        }
    }
}
