
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class CCCreditService
    {

        private string captureRequestIDField;

        private string reconciliationIDField;

        private string partialPaymentIDField;

        private string purchasingLevelField;

        private string industryDatatypeField;

        private string commerceIndicatorField;

        private string billPaymentField;

        private string authorizationXIDField;

        private string occurrenceNumberField;

        private string authCodeField;

        private string captureRequestTokenField;

        private string merchantReceiptNumberField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string captureRequestID
        {
            get
            {
                return this.captureRequestIDField;
            }
            set
            {
                this.captureRequestIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string purchasingLevel
        {
            get
            {
                return this.purchasingLevelField;
            }
            set
            {
                this.purchasingLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string industryDatatype
        {
            get
            {
                return this.industryDatatypeField;
            }
            set
            {
                this.industryDatatypeField = value;
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
        public string billPayment
        {
            get
            {
                return this.billPaymentField;
            }
            set
            {
                this.billPaymentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string authorizationXID
        {
            get
            {
                return this.authorizationXIDField;
            }
            set
            {
                this.authorizationXIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string occurrenceNumber
        {
            get
            {
                return this.occurrenceNumberField;
            }
            set
            {
                this.occurrenceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string authCode
        {
            get
            {
                return this.authCodeField;
            }
            set
            {
                this.authCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string captureRequestToken
        {
            get
            {
                return this.captureRequestTokenField;
            }
            set
            {
                this.captureRequestTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string merchantReceiptNumber
        {
            get
            {
                return this.merchantReceiptNumberField;
            }
            set
            {
                this.merchantReceiptNumberField = value;
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
