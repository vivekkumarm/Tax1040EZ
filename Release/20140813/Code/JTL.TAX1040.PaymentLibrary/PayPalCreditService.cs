
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayPalCreditService
    {

        private string payPalPaymentRequestIDField;

        private string reconciliationIDField;

        private string payPalPaymentRequestTokenField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string payPalPaymentRequestID
        {
            get
            {
                return this.payPalPaymentRequestIDField;
            }
            set
            {
                this.payPalPaymentRequestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string payPalPaymentRequestToken
        {
            get
            {
                return this.payPalPaymentRequestTokenField;
            }
            set
            {
                this.payPalPaymentRequestTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string run
        {
            get
            {
                return this.runField;
            }
            set
            {
                this.runField = value;
            }
        }
    }

}
