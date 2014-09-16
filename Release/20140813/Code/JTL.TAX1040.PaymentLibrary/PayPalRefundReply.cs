
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayPalRefundReply
    {

        private string reasonCodeField;

        private string transactionIdField;

        private string paypalNetRefundAmountField;

        private string paypalFeeRefundAmountField;

        private string paypalGrossRefundAmountField;

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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string paypalNetRefundAmount
        {
            get
            {
                return this.paypalNetRefundAmountField;
            }
            set
            {
                this.paypalNetRefundAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string paypalFeeRefundAmount
        {
            get
            {
                return this.paypalFeeRefundAmountField;
            }
            set
            {
                this.paypalFeeRefundAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string paypalGrossRefundAmount
        {
            get
            {
                return this.paypalGrossRefundAmountField;
            }
            set
            {
                this.paypalGrossRefundAmountField = value;
            }
        }
    }

}
