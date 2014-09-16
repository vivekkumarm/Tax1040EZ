
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class BusinessRules
    {

        private string ignoreAVSResultField;

        private string ignoreCVResultField;

        private string ignoreDAVResultField;

        private string ignoreExportResultField;

        private string ignoreValidateResultField;

        private string declineAVSFlagsField;

        private string scoreThresholdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ignoreAVSResult
        {
            get
            {
                return this.ignoreAVSResultField;
            }
            set
            {
                this.ignoreAVSResultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string ignoreCVResult
        {
            get
            {
                return this.ignoreCVResultField;
            }
            set
            {
                this.ignoreCVResultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ignoreDAVResult
        {
            get
            {
                return this.ignoreDAVResultField;
            }
            set
            {
                this.ignoreDAVResultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string ignoreExportResult
        {
            get
            {
                return this.ignoreExportResultField;
            }
            set
            {
                this.ignoreExportResultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string ignoreValidateResult
        {
            get
            {
                return this.ignoreValidateResultField;
            }
            set
            {
                this.ignoreValidateResultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string declineAVSFlags
        {
            get
            {
                return this.declineAVSFlagsField;
            }
            set
            {
                this.declineAVSFlagsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 6)]
        public string scoreThreshold
        {
            get
            {
                return this.scoreThresholdField;
            }
            set
            {
                this.scoreThresholdField = value;
            }
        }
    }

}
