
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class DecisionReply
    {

        private ProfileReply activeProfileReplyField;

        private string velocityInfoCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ProfileReply activeProfileReply
        {
            get
            {
                return this.activeProfileReplyField;
            }
            set
            {
                this.activeProfileReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
    }

}
