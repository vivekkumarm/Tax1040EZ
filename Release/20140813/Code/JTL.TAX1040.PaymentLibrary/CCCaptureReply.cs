
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class CCCaptureReply
    {

        private string reasonCodeField;

        private string requestDateTimeField;

        private string amountField;

        private string reconciliationIDField;

        private FundingTotals fundingTotalsField;

        private string fxQuoteIDField;

        private string fxQuoteRateField;

        private string fxQuoteTypeField;

        private string fxQuoteExpirationDateTimeField;

        private string purchasingLevel3EnabledField;

        private string enhancedDataEnabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 0)]
        public string reasonCode
        {
            get
            {
                return this.reasonCodeField;
            }
            set
            {
                this.reasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string requestDateTime
        {
            get
            {
                return this.requestDateTimeField;
            }
            set
            {
                this.requestDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public FundingTotals fundingTotals
        {
            get
            {
                return this.fundingTotalsField;
            }
            set
            {
                this.fundingTotalsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string fxQuoteID
        {
            get
            {
                return this.fxQuoteIDField;
            }
            set
            {
                this.fxQuoteIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string fxQuoteRate
        {
            get
            {
                return this.fxQuoteRateField;
            }
            set
            {
                this.fxQuoteRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string fxQuoteType
        {
            get
            {
                return this.fxQuoteTypeField;
            }
            set
            {
                this.fxQuoteTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string fxQuoteExpirationDateTime
        {
            get
            {
                return this.fxQuoteExpirationDateTimeField;
            }
            set
            {
                this.fxQuoteExpirationDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string purchasingLevel3Enabled
        {
            get
            {
                return this.purchasingLevel3EnabledField;
            }
            set
            {
                this.purchasingLevel3EnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string enhancedDataEnabled
        {
            get
            {
                return this.enhancedDataEnabledField;
            }
            set
            {
                this.enhancedDataEnabledField = value;
            }
        }
    }

}
