
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayerAuthEnrollService
    {

        private string httpAcceptField;

        private string httpUserAgentField;

        private string merchantNameField;

        private string merchantURLField;

        private string purchaseDescriptionField;

        private string purchaseTimeField;

        private string countryCodeField;

        private string acquirerBinField;

        private string loginIDField;

        private string passwordField;

        private string merchantIDField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string httpAccept
        {
            get
            {
                return this.httpAcceptField;
            }
            set
            {
                this.httpAcceptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string httpUserAgent
        {
            get
            {
                return this.httpUserAgentField;
            }
            set
            {
                this.httpUserAgentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string merchantName
        {
            get
            {
                return this.merchantNameField;
            }
            set
            {
                this.merchantNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string merchantURL
        {
            get
            {
                return this.merchantURLField;
            }
            set
            {
                this.merchantURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string purchaseDescription
        {
            get
            {
                return this.purchaseDescriptionField;
            }
            set
            {
                this.purchaseDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string purchaseTime
        {
            get
            {
                return this.purchaseTimeField;
            }
            set
            {
                this.purchaseTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string countryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string acquirerBin
        {
            get
            {
                return this.acquirerBinField;
            }
            set
            {
                this.acquirerBinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string loginID
        {
            get
            {
                return this.loginIDField;
            }
            set
            {
                this.loginIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string merchantID
        {
            get
            {
                return this.merchantIDField;
            }
            set
            {
                this.merchantIDField = value;
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
