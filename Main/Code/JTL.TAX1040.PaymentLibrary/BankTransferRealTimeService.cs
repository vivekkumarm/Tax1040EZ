
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class BankTransferRealTimeService
    {

        private string bankTransferRealTimeTypeField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string bankTransferRealTimeType
        {
            get
            {
                return this.bankTransferRealTimeTypeField;
            }
            set
            {
                this.bankTransferRealTimeTypeField = value;
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