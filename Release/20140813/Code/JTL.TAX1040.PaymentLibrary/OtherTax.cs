
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class OtherTax
    {

        private string vatTaxAmountField;

        private string vatTaxRateField;

        private string alternateTaxAmountField;

        private string alternateTaxIndicatorField;

        private string alternateTaxIDField;

        private string localTaxAmountField;

        private string localTaxIndicatorField;

        private string nationalTaxAmountField;

        private string nationalTaxIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string vatTaxAmount
        {
            get
            {
                return this.vatTaxAmountField;
            }
            set
            {
                this.vatTaxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vatTaxRate
        {
            get
            {
                return this.vatTaxRateField;
            }
            set
            {
                this.vatTaxRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string alternateTaxAmount
        {
            get
            {
                return this.alternateTaxAmountField;
            }
            set
            {
                this.alternateTaxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string alternateTaxIndicator
        {
            get
            {
                return this.alternateTaxIndicatorField;
            }
            set
            {
                this.alternateTaxIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string alternateTaxID
        {
            get
            {
                return this.alternateTaxIDField;
            }
            set
            {
                this.alternateTaxIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string localTaxAmount
        {
            get
            {
                return this.localTaxAmountField;
            }
            set
            {
                this.localTaxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 6)]
        public string localTaxIndicator
        {
            get
            {
                return this.localTaxIndicatorField;
            }
            set
            {
                this.localTaxIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string nationalTaxAmount
        {
            get
            {
                return this.nationalTaxAmountField;
            }
            set
            {
                this.nationalTaxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 8)]
        public string nationalTaxIndicator
        {
            get
            {
                return this.nationalTaxIndicatorField;
            }
            set
            {
                this.nationalTaxIndicatorField = value;
            }
        }
    }

}
