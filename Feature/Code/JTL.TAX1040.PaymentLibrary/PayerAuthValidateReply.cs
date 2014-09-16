
namespace JTL.Tax1040.PaymentLibrary
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayerAuthValidateReply
    {

        private string reasonCodeField;

        private string authenticationResultField;

        private string authenticationStatusMessageField;

        private string cavvField;

        private string commerceIndicatorField;

        private string eciField;

        private string eciRawField;

        private string xidField;

        private string ucafAuthenticationDataField;

        private string ucafCollectionIndicatorField;

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
        public string authenticationResult
        {
            get
            {
                return this.authenticationResultField;
            }
            set
            {
                this.authenticationResultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string authenticationStatusMessage
        {
            get
            {
                return this.authenticationStatusMessageField;
            }
            set
            {
                this.authenticationStatusMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string eci
        {
            get
            {
                return this.eciField;
            }
            set
            {
                this.eciField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string ucafAuthenticationData
        {
            get
            {
                return this.ucafAuthenticationDataField;
            }
            set
            {
                this.ucafAuthenticationDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string ucafCollectionIndicator
        {
            get
            {
                return this.ucafCollectionIndicatorField;
            }
            set
            {
                this.ucafCollectionIndicatorField = value;
            }
        }
    }

}
