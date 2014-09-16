
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayPalDoCaptureReply
    {

        private string reasonCodeField;

        private string authorizationIdField;

        private string transactionIdField;

        private string parentTransactionIdField;

        private string paypalReceiptIdField;

        private string paypalTransactiontypeField;

        private string paypalPaymentTypeField;

        private string paypalOrderTimeField;

        private string paypalPaymentGrossAmountField;

        private string paypalFeeAmountField;

        private string paypalTaxAmountField;

        private string paypalExchangeRateField;

        private string paypalPaymentStatusField;

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
        public string authorizationId
        {
            get
            {
                return this.authorizationIdField;
            }
            set
            {
                this.authorizationIdField = value;
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
        public string parentTransactionId
        {
            get
            {
                return this.parentTransactionIdField;
            }
            set
            {
                this.parentTransactionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string paypalReceiptId
        {
            get
            {
                return this.paypalReceiptIdField;
            }
            set
            {
                this.paypalReceiptIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string paypalPaymentType
        {
            get
            {
                return this.paypalPaymentTypeField;
            }
            set
            {
                this.paypalPaymentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string paypalOrderTime
        {
            get
            {
                return this.paypalOrderTimeField;
            }
            set
            {
                this.paypalOrderTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string paypalPaymentGrossAmount
        {
            get
            {
                return this.paypalPaymentGrossAmountField;
            }
            set
            {
                this.paypalPaymentGrossAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string paypalExchangeRate
        {
            get
            {
                return this.paypalExchangeRateField;
            }
            set
            {
                this.paypalExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
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
