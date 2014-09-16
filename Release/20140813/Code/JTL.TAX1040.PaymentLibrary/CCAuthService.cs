
namespace JTL.Tax1040.PaymentLibrary
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class CCAuthService
    {

        private string cavvField;

        private string commerceIndicatorField;

        private string eciRawField;

        private string xidField;

        private string reconciliationIDField;

        private string avsLevelField;

        private string fxQuoteIDField;

        private string returnAuthRecordField;

        private string authTypeField;

        private string verbalAuthCodeField;

        private string billPaymentField;

        private string authenticationXIDField;

        private string authorizationXIDField;

        private string industryDatatypeField;

        private string traceNumberField;

        private string checksumKeyField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string cavv
        {
            get
            {
                return this.cavvField;
            }
            set
            {
                this.cavvField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string eciRaw
        {
            get
            {
                return this.eciRawField;
            }
            set
            {
                this.eciRawField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string xid
        {
            get
            {
                return this.xidField;
            }
            set
            {
                this.xidField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string avsLevel
        {
            get
            {
                return this.avsLevelField;
            }
            set
            {
                this.avsLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string fxQuoteID
        {
            get
            {
                return this.fxQuoteIDField;
            }
            set
            {
                this.fxQuoteIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string returnAuthRecord
        {
            get
            {
                return this.returnAuthRecordField;
            }
            set
            {
                this.returnAuthRecordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string authenticationXID
        {
            get
            {
                return this.authenticationXIDField;
            }
            set
            {
                this.authenticationXIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string traceNumber
        {
            get
            {
                return this.traceNumberField;
            }
            set
            {
                this.traceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string checksumKey
        {
            get
            {
                return this.checksumKeyField;
            }
            set
            {
                this.checksumKeyField = value;
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
