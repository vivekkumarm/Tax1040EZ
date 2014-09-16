//vincent-4 July 2014- Added a Description method Return status.
using JTL.Tax1040.Core.Object;
using System.ComponentModel;

namespace JTL.Tax1040.BusinessObject
{
  public  class FederalFiling
    {
        public IRSTransmission IRSTransmission { set; get; }
        public bool IsEfile { get; set; }
        public ReturnStatus ReturnStatus { get; set; }
        public string ReturnStatusDescription { 
            get{

                return TypeDescriptor.GetConverter(typeof(ReturnStatus)).ConvertToString(ReturnStatus);
            
            } 
        }
    }
}
