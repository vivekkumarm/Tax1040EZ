
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayPalButtonCreateService
    {

        private string buttonTypeField;

        private string reconciliationIDField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string buttonType
        {
            get
            {
                return this.buttonTypeField;
            }
            set
            {
                this.buttonTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
