//14 April 2014  Praveen T   Added New BO Form8879
using System;

namespace JTL.Tax1040.BusinessObject
{
    public class Form8879
    {
        public  string TaxpayerEROFirmName { get; set; }

        public  string SpouseEROFirmName { get; set; }

        public  DateTime TaxpayerSignatureDate { get; set; }

        public  DateTime SpouseSignatureDate { get; set; }

        public  long EROEFINPIN { get; set; }

        public  DateTime EROSignatureDate { get; set; }

    }

}
