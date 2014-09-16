
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class ECCreditService
    {

        private string referenceNumberField;

        private string settlementMethodField;

        private string transactionTokenField;

        private string debitRequestIDField;

        private string partialPaymentIDField;

        private string commerceIndicatorField;

        private string debitRequestTokenField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string referenceNumber
        {
            get
            {
                return this.referenceNumberField;
            }
            set
            {
                this.referenceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string settlementMethod
        {
            get
            {
                return this.settlementMethodField;
            }
            set
            {
                this.settlementMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string transactionToken
        {
            get
            {
                return this.transactionTokenField;
            }
            set
            {
                this.transactionTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string debitRequestID
        {
            get
            {
                return this.debitRequestIDField;
            }
            set
            {
                this.debitRequestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string partialPaymentID
        {
            get
            {
                return this.partialPaymentIDField;
            }
            set
            {
                this.partialPaymentIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string commerceIndicator
        {
            get
            {
                return this.commerceIndicatorField;
            }
            set
            {
                this.commerceIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string debitRequestToken
        {
            get
            {
                return this.debitRequestTokenField;
            }
            set
            {
                this.debitRequestTokenField = value;
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
