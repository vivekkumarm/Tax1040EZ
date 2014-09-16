//vincent-4 July 2014- Added a Description method Return status.
//Sathish 25Jul2014 added payment option and bank detail in state filing
using JTL.Tax1040.Core.Object;
using System.ComponentModel;
using System;

namespace JTL.Tax1040.BusinessObject
{
    public class StateFiling
    {
        public BankDetails BankDetails { get; set; }

        public double Amount { get; set; }

        public PaymentOption PaymentOption { get; set; }

        public DateTime PaymentDate { get; set; }

        public bool IsIRSPaymentOptionAgreed { get; set; }

        //23Jul2014 Sathish added IRS Transmission BO
        public StateTransmission StateTransmission { set; get; }
     //   public IRSTransmission IRSTransmission { set; get; }
        public bool? IsEfile { get; set; } //28Jul2014 Sathsih changed to nullable object since this option should be selected by the user
        public ReturnStatus ReturnStatus { get; set; }
        public State State { get; set; }
        public string ReturnStatusDescription
        {
            get
            {
                return TypeDescriptor.GetConverter(typeof(ReturnStatus)).ConvertToString(ReturnStatus);
            }
        }

    }
}
