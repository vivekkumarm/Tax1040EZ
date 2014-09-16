
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class ProfileReply
    {

        private string selectedByField;

        private string nameField;

        private string destinationQueueField;

        private RuleResultItem[] rulesTriggeredField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string selectedBy
        {
            get
            {
                return this.selectedByField;
            }
            set
            {
                this.selectedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string destinationQueue
        {
            get
            {
                return this.destinationQueueField;
            }
            set
            {
                this.destinationQueueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ruleResultItem", IsNullable = false)]
        public RuleResultItem[] rulesTriggered
        {
            get
            {
                return this.rulesTriggeredField;
            }
            set
            {
                this.rulesTriggeredField = value;
            }
        }
    }
}
