
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class CCCaptureService
    {

        private string authTypeField;

        private string verbalAuthCodeField;

        private string authRequestIDField;

        private string reconciliationIDField;

        private string partialPaymentIDField;

        private string purchasingLevelField;

        private string industryDatatypeField;

        private string authRequestTokenField;

        private string merchantReceiptNumberField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string authType
        {
            get
            {
                return this.authTypeField;
            }
            set
            {
                this.authTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string verbalAuthCode
        {
            get
            {
                return this.verbalAuthCodeField;
            }
            set
            {
                this.verbalAuthCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string authRequestID
        {
            get
            {
                return this.authRequestIDField;
            }
            set
            {
                this.authRequestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string authRequestToken
        {
            get
            {
                return this.authRequestTokenField;
            }
            set
            {
                this.authRequestTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
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
