
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayerAuthEnrollReply
    {

        private string reasonCodeField;

        private string acsURLField;

        private string commerceIndicatorField;

        private string paReqField;

        private string proxyPANField;

        private string xidField;

        private string proofXMLField;

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
        public string acsURL
        {
            get
            {
                return this.acsURLField;
            }
            set
            {
                this.acsURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string paReq
        {
            get
            {
                return this.paReqField;
            }
            set
            {
                this.paReqField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string proxyPAN
        {
            get
            {
                return this.proxyPANField;
            }
            set
            {
                this.proxyPANField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string proofXML
        {
            get
            {
                return this.proofXMLField;
            }
            set
            {
                this.proofXMLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
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
