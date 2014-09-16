
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayPalEcDoPaymentService
    {

        private string paypalTokenField;

        private string paypalPayerIdField;

        private string paypalCustomerEmailField;

        private string paypalDescField;

        private string paypalEcSetRequestIDField;

        private string paypalEcSetRequestTokenField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string paypalToken
        {
            get
            {
                return this.paypalTokenField;
            }
            set
            {
                this.paypalTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string paypalPayerId
        {
            get
            {
                return this.paypalPayerIdField;
            }
            set
            {
                this.paypalPayerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string paypalCustomerEmail
        {
            get
            {
                return this.paypalCustomerEmailField;
            }
            set
            {
                this.paypalCustomerEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string paypalDesc
        {
            get
            {
                return this.paypalDescField;
            }
            set
            {
                this.paypalDescField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string paypalEcSetRequestID
        {
            get
            {
                return this.paypalEcSetRequestIDField;
            }
            set
            {
                this.paypalEcSetRequestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string paypalEcSetRequestToken
        {
            get
            {
                return this.paypalEcSetRequestTokenField;
            }
            set
            {
                this.paypalEcSetRequestTokenField = value;
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