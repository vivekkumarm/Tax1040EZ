using System;
using System.Collections.Generic;
using System.Text;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class FinalTaxXMLDE
    {
        private long _EfileHoldID;

        public long EfileHoldID
        {
            get { return _EfileHoldID; }
            set { _EfileHoldID = value; }
        }

        private long _returnID;

        public long ReturnID
        {
            get { return _returnID; }
            set { _returnID = value; }
        }

        private long _taxReturnTypeID;

        public long TaxReturnTypeID
        {
            get { return _taxReturnTypeID; }
            set { _taxReturnTypeID = value; }
        }

        private string _returnXML;

        public string ReturnXML
        {
            get { return _returnXML; }
            set { _returnXML = value; }
        }

        private bool _isIRSSchemaConverted;

        public bool IsIRSSchemaConverted
        {
            get { return _isIRSSchemaConverted; }
            set { _isIRSSchemaConverted = value; }
        }
    }
}
