
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayPalPaymentReply
    {

        private string reasonCodeField;

        private string secureDataField;

        private string amountField;

        private string requestDateTimeField;

        private string reconciliationIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 0)]
        public string reasonCode
        {
            get
            {
                return this.reasonCodeField;
            }
            set
            {
                this.reasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string secureData
        {
            get
            {
                return this.secureDataField;
            }
            set
            {
                this.secureDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string requestDateTime
        {
            get
            {
                return this.requestDateTimeField;
            }
            set
            {
                this.requestDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string reconciliationID
        {
            get
            {
                return this.reconciliationIDField;
            }
            set
            {
                this.reconciliationIDField = value;
            }
        }
    }

}
