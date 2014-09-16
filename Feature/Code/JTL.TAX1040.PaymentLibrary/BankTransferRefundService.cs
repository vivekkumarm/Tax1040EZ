
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class BankTransferRefundService
    {

        private string bankTransferRequestIDField;

        private string bankTransferRealTimeRequestIDField;

        private string reconciliationIDField;

        private string bankTransferRealTimeReconciliationIDField;

        private string bankTransferRequestTokenField;

        private string bankTransferRealTimeRequestTokenField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string bankTransferRequestID
        {
            get
            {
                return this.bankTransferRequestIDField;
            }
            set
            {
                this.bankTransferRequestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string bankTransferRealTimeRequestID
        {
            get
            {
                return this.bankTransferRealTimeRequestIDField;
            }
            set
            {
                this.bankTransferRealTimeRequestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string bankTransferRealTimeReconciliationID
        {
            get
            {
                return this.bankTransferRealTimeReconciliationIDField;
            }
            set
            {
                this.bankTransferRealTimeReconciliationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string bankTransferRequestToken
        {
            get
            {
                return this.bankTransferRequestTokenField;
            }
            set
            {
                this.bankTransferRequestTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string bankTransferRealTimeRequestToken
        {
            get
            {
                return this.bankTransferRealTimeRequestTokenField;
            }
            set
            {
                this.bankTransferRealTimeRequestTokenField = value;
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
