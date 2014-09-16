
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayPalEcDoPaymentReply
    {

        private string reasonCodeField;

        private string paypalTokenField;

        private string transactionIdField;

        private string paypalTransactiontypeField;

        private string paymentTypeField;

        private string paypalOrdertimeField;

        private string paypalAmountField;

        private string paypalFeeAmountField;

        private string paypalTaxAmountField;

        private string paypalExchangerateField;

        private string paypalPaymentStatusField;

        private string paypalPendingReasonField;

        private string paypalReasonCodeField;

        private string amountField;

        private string currencyField;

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
        public string paypalToken
        {
            get
            {
                return this.paypalTokenField;
            }
            set
            {
                this.paypalTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string transactionId
        {
            get
            {
                return this.transactionIdField;
            }
            set
            {
                this.transactionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string paypalTransactiontype
        {
            get
            {
                return this.paypalTransactiontypeField;
            }
            set
            {
                this.paypalTransactiontypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string paymentType
        {
            get
            {
                return this.paymentTypeField;
            }
            set
            {
                this.paymentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string paypalOrdertime
        {
            get
            {
                return this.paypalOrdertimeField;
            }
            set
            {
                this.paypalOrdertimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string paypalAmount
        {
            get
            {
                return this.paypalAmountField;
            }
            set
            {
                this.paypalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string paypalFeeAmount
        {
            get
            {
                return this.paypalFeeAmountField;
            }
            set
            {
                this.paypalFeeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string paypalTaxAmount
        {
            get
            {
                return this.paypalTaxAmountField;
            }
            set
            {
                this.paypalTaxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string paypalExchangerate
        {
            get
            {
                return this.paypalExchangerateField;
            }
            set
            {
                this.paypalExchangerateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string paypalPaymentStatus
        {
            get
            {
                return this.paypalPaymentStatusField;
            }
            set
            {
                this.paypalPaymentStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string paypalPendingReason
        {
            get
            {
                return this.paypalPendingReasonField;
            }
            set
            {
                this.paypalPendingReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string paypalReasonCode
        {
            get
            {
                return this.paypalReasonCodeField;
            }
            set
            {
                this.paypalReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

}
