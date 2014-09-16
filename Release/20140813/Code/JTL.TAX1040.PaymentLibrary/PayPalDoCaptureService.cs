
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayPalDoCaptureService
    {

        private string paypalAuthorizationIdField;

        private string completeTypeField;

        private string paypalEcDoPaymentRequestIDField;

        private string paypalEcDoPaymentRequestTokenField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string paypalAuthorizationId
        {
            get
            {
                return this.paypalAuthorizationIdField;
            }
            set
            {
                this.paypalAuthorizationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string completeType
        {
            get
            {
                return this.completeTypeField;
            }
            set
            {
                this.completeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string paypalEcDoPaymentRequestID
        {
            get
            {
                return this.paypalEcDoPaymentRequestIDField;
            }
            set
            {
                this.paypalEcDoPaymentRequestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string paypalEcDoPaymentRequestToken
        {
            get
            {
                return this.paypalEcDoPaymentRequestTokenField;
            }
            set
            {
                this.paypalEcDoPaymentRequestTokenField = value;
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
