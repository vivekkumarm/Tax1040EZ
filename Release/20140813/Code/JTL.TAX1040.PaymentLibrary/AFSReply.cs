
namespace JTL.Tax1040.PaymentLibrary
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class AFSReply
    {

        private string reasonCodeField;

        private string afsResultField;

        private string hostSeverityField;

        private string consumerLocalTimeField;

        private string afsFactorCodeField;

        private string addressInfoCodeField;

        private string hotlistInfoCodeField;

        private string internetInfoCodeField;

        private string phoneInfoCodeField;

        private string suspiciousInfoCodeField;

        private string velocityInfoCodeField;

        private string identityInfoCodeField;

        private string ipCountryField;

        private string ipStateField;

        private string ipCityField;

        private string ipRoutingMethodField;

        private string scoreModelUsedField;

        private string binCountryField;

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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 1)]
        public string afsResult
        {
            get
            {
                return this.afsResultField;
            }
            set
            {
                this.afsResultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 2)]
        public string hostSeverity
        {
            get
            {
                return this.hostSeverityField;
            }
            set
            {
                this.hostSeverityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string consumerLocalTime
        {
            get
            {
                return this.consumerLocalTimeField;
            }
            set
            {
                this.consumerLocalTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string afsFactorCode
        {
            get
            {
                return this.afsFactorCodeField;
            }
            set
            {
                this.afsFactorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string addressInfoCode
        {
            get
            {
                return this.addressInfoCodeField;
            }
            set
            {
                this.addressInfoCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string hotlistInfoCode
        {
            get
            {
                return this.hotlistInfoCodeField;
            }
            set
            {
                this.hotlistInfoCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string internetInfoCode
        {
            get
            {
                return this.internetInfoCodeField;
            }
            set
            {
                this.internetInfoCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string phoneInfoCode
        {
            get
            {
                return this.phoneInfoCodeField;
            }
            set
            {
                this.phoneInfoCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string suspiciousInfoCode
        {
            get
            {
                return this.suspiciousInfoCodeField;
            }
            set
            {
                this.suspiciousInfoCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string velocityInfoCode
        {
            get
            {
                return this.velocityInfoCodeField;
            }
            set
            {
                this.velocityInfoCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string identityInfoCode
        {
            get
            {
                return this.identityInfoCodeField;
            }
            set
            {
                this.identityInfoCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string ipCountry
        {
            get
            {
                return this.ipCountryField;
            }
            set
            {
                this.ipCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string ipState
        {
            get
            {
                return this.ipStateField;
            }
            set
            {
                this.ipStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string ipCity
        {
            get
            {
                return this.ipCityField;
            }
            set
            {
                this.ipCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string ipRoutingMethod
        {
            get
            {
                return this.ipRoutingMethodField;
            }
            set
            {
                this.ipRoutingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string scoreModelUsed
        {
            get
            {
                return this.scoreModelUsedField;
            }
            set
            {
                this.scoreModelUsedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string binCountry
        {
            get
            {
                return this.binCountryField;
            }
            set
            {
                this.binCountryField = value;
            }
        }
    }

}
