
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class MerchantSecureData
    {

        private string field1Field;

        private string field2Field;

        private string field3Field;

        private string field4Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string field1
        {
            get
            {
                return this.field1Field;
            }
            set
            {
                this.field1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string field2
        {
            get
            {
                return this.field2Field;
            }
            set
            {
                this.field2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string field3
        {
            get
            {
                return this.field3Field;
            }
            set
            {
                this.field3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string field4
        {
            get
            {
                return this.field4Field;
            }
            set
            {
                this.field4Field = value;
            }
        }
    }

}
