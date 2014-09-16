
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class CCAuthReply
    {

        private string reasonCodeField;

        private string amountField;

        private string authorizationCodeField;

        private string avsCodeField;

        private string avsCodeRawField;

        private string cvCodeField;

        private string cvCodeRawField;

        private string personalIDCodeField;

        private string authorizedDateTimeField;

        private string processorResponseField;

        private string bmlAccountNumberField;

        private string authFactorCodeField;

        private string reconciliationIDField;

        private FundingTotals fundingTotalsField;

        private string fxQuoteIDField;

        private string fxQuoteRateField;

        private string fxQuoteTypeField;

        private string fxQuoteExpirationDateTimeField;

        private string authRecordField;

        private string merchantAdviceCodeField;

        private string merchantAdviceCodeRawField;

        private string cavvResponseCodeField;

        private string cavvResponseCodeRawField;

        private string authenticationXIDField;

        private string authorizationXIDField;

        private string processorCardTypeField;

        private string accountBalanceField;

        private string forwardCodeField;

        private string enhancedDataEnabledField;

        private string referralResponseNumberField;

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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string authorizationCode
        {
            get
            {
                return this.authorizationCodeField;
            }
            set
            {
                this.authorizationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string avsCode
        {
            get
            {
                return this.avsCodeField;
            }
            set
            {
                this.avsCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string avsCodeRaw
        {
            get
            {
                return this.avsCodeRawField;
            }
            set
            {
                this.avsCodeRawField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string cvCode
        {
            get
            {
                return this.cvCodeField;
            }
            set
            {
                this.cvCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string cvCodeRaw
        {
            get
            {
                return this.cvCodeRawField;
            }
            set
            {
                this.cvCodeRawField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string personalIDCode
        {
            get
            {
                return this.personalIDCodeField;
            }
            set
            {
                this.personalIDCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string authorizedDateTime
        {
            get
            {
                return this.authorizedDateTimeField;
            }
            set
            {
                this.authorizedDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string processorResponse
        {
            get
            {
                return this.processorResponseField;
            }
            set
            {
                this.processorResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string bmlAccountNumber
        {
            get
            {
                return this.bmlAccountNumberField;
            }
            set
            {
                this.bmlAccountNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string authFactorCode
        {
            get
            {
                return this.authFactorCodeField;
            }
            set
            {
                this.authFactorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string authRecord
        {
            get
            {
                return this.authRecordField;
            }
            set
            {
                this.authRecordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public string merchantAdviceCode
        {
            get
            {
                return this.merchantAdviceCodeField;
            }
            set
            {
                this.merchantAdviceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public string merchantAdviceCodeRaw
        {
            get
            {
                return this.merchantAdviceCodeRawField;
            }
            set
            {
                this.merchantAdviceCodeRawField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public string cavvResponseCode
        {
            get
            {
                return this.cavvResponseCodeField;
            }
            set
            {
                this.cavvResponseCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public string cavvResponseCodeRaw
        {
            get
            {
                return this.cavvResponseCodeRawField;
            }
            set
            {
                this.cavvResponseCodeRawField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public string authenticationXID
        {
            get
            {
                return this.authenticationXIDField;
            }
            set
            {
                this.authenticationXIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public string authorizationXID
        {
            get
            {
                return this.authorizationXIDField;
            }
            set
            {
                this.authorizationXIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
        public string processorCardType
        {
            get
            {
                return this.processorCardTypeField;
            }
            set
            {
                this.processorCardTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
        public string accountBalance
        {
            get
            {
                return this.accountBalanceField;
            }
            set
            {
                this.accountBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 27)]
        public string forwardCode
        {
            get
            {
                return this.forwardCodeField;
            }
            set
            {
                this.forwardCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 28)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
        public string referralResponseNumber
        {
            get
            {
                return this.referralResponseNumberField;
            }
            set
            {
                this.referralResponseNumberField = value;
            }
        }
    }

}
