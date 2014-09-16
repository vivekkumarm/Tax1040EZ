
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class DirectDebitService
    {

        private string dateCollectField;

        private string directDebitTextField;

        private string authorizationIDField;

        private string transactionTypeField;

        private string directDebitTypeField;

        private string validateRequestIDField;

        private string recurringTypeField;

        private string mandateIDField;

        private string validateRequestTokenField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string dateCollect
        {
            get
            {
                return this.dateCollectField;
            }
            set
            {
                this.dateCollectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string directDebitText
        {
            get
            {
                return this.directDebitTextField;
            }
            set
            {
                this.directDebitTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string authorizationID
        {
            get
            {
                return this.authorizationIDField;
            }
            set
            {
                this.authorizationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string transactionType
        {
            get
            {
                return this.transactionTypeField;
            }
            set
            {
                this.transactionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string directDebitType
        {
            get
            {
                return this.directDebitTypeField;
            }
            set
            {
                this.directDebitTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string validateRequestID
        {
            get
            {
                return this.validateRequestIDField;
            }
            set
            {
                this.validateRequestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string recurringType
        {
            get
            {
                return this.recurringTypeField;
            }
            set
            {
                this.recurringTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string mandateID
        {
            get
            {
                return this.mandateIDField;
            }
            set
            {
                this.mandateIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string validateRequestToken
        {
            get
            {
                return this.validateRequestTokenField;
            }
            set
            {
                this.validateRequestTokenField = value;
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
