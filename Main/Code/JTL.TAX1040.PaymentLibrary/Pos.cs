
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class Pos
    {

        private string entryModeField;

        private string cardPresentField;

        private string terminalCapabilityField;

        private string trackDataField;

        private string terminalIDField;

        private string terminalTypeField;

        private string terminalLocationField;

        private string transactionSecurityField;

        private string catLevelField;

        private string conditionCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string entryMode
        {
            get
            {
                return this.entryModeField;
            }
            set
            {
                this.entryModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string cardPresent
        {
            get
            {
                return this.cardPresentField;
            }
            set
            {
                this.cardPresentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string terminalCapability
        {
            get
            {
                return this.terminalCapabilityField;
            }
            set
            {
                this.terminalCapabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string trackData
        {
            get
            {
                return this.trackDataField;
            }
            set
            {
                this.trackDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string terminalID
        {
            get
            {
                return this.terminalIDField;
            }
            set
            {
                this.terminalIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string terminalType
        {
            get
            {
                return this.terminalTypeField;
            }
            set
            {
                this.terminalTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string terminalLocation
        {
            get
            {
                return this.terminalLocationField;
            }
            set
            {
                this.terminalLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string transactionSecurity
        {
            get
            {
                return this.transactionSecurityField;
            }
            set
            {
                this.transactionSecurityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string catLevel
        {
            get
            {
                return this.catLevelField;
            }
            set
            {
                this.catLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string conditionCode
        {
            get
            {
                return this.conditionCodeField;
            }
            set
            {
                this.conditionCodeField = value;
            }
        }
    }

}
