
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayPalRefundService
    {

        private string paypalDoCaptureRequestIDField;

        private string paypalDoCaptureRequestTokenField;

        private string paypalCaptureIdField;

        private string paypalNoteField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string paypalDoCaptureRequestID
        {
            get
            {
                return this.paypalDoCaptureRequestIDField;
            }
            set
            {
                this.paypalDoCaptureRequestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string paypalDoCaptureRequestToken
        {
            get
            {
                return this.paypalDoCaptureRequestTokenField;
            }
            set
            {
                this.paypalDoCaptureRequestTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string paypalCaptureId
        {
            get
            {
                return this.paypalCaptureIdField;
            }
            set
            {
                this.paypalCaptureIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string paypalNote
        {
            get
            {
                return this.paypalNoteField;
            }
            set
            {
                this.paypalNoteField = value;
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
