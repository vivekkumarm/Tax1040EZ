
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class ReplyMessage
    {

        private string merchantReferenceCodeField;

        private string requestIDField;

        private string decisionField;

        private string reasonCodeField;

        private string[] missingFieldField;

        private string[] invalidFieldField;

        private string requestTokenField;

        private PurchaseTotals purchaseTotalsField;

        private DeniedPartiesMatch[] deniedPartiesMatchField;

        private CCAuthReply ccAuthReplyField;

        private CCCaptureReply ccCaptureReplyField;

        private CCCreditReply ccCreditReplyField;

        private CCAuthReversalReply ccAuthReversalReplyField;

        private ECDebitReply ecDebitReplyField;

        private ECCreditReply ecCreditReplyField;

        private PayerAuthEnrollReply payerAuthEnrollReplyField;

        private PayerAuthValidateReply payerAuthValidateReplyField;

        private TaxReply taxReplyField;

        private AFSReply afsReplyField;

        private DAVReply davReplyField;

        private ExportReply exportReplyField;

        private FXRatesReply fxRatesReplyField;

        private BankTransferReply bankTransferReplyField;

        private BankTransferRefundReply bankTransferRefundReplyField;

        private BankTransferRealTimeReply bankTransferRealTimeReplyField;

        private DirectDebitMandateReply directDebitMandateReplyField;

        private DirectDebitReply directDebitReplyField;

        private DirectDebitValidateReply directDebitValidateReplyField;

        private DirectDebitRefundReply directDebitRefundReplyField;

        private PaySubscriptionCreateReply paySubscriptionCreateReplyField;

        private PaySubscriptionUpdateReply paySubscriptionUpdateReplyField;

        private PaySubscriptionEventUpdateReply paySubscriptionEventUpdateReplyField;

        private PaySubscriptionRetrieveReply paySubscriptionRetrieveReplyField;

        private PayPalPaymentReply payPalPaymentReplyField;

        private PayPalCreditReply payPalCreditReplyField;

        private VoidReply voidReplyField;

        private PinlessDebitReply pinlessDebitReplyField;

        private PinlessDebitValidateReply pinlessDebitValidateReplyField;

        private PayPalButtonCreateReply payPalButtonCreateReplyField;

        private PayPalPreapprovedPaymentReply payPalPreapprovedPaymentReplyField;

        private PayPalPreapprovedUpdateReply payPalPreapprovedUpdateReplyField;

        private RiskUpdateReply riskUpdateReplyField;

        private DecisionReply decisionReplyField;

        private System.Xml.XmlElement reservedField;

        private PayPalRefundReply payPalRefundReplyField;

        private PayPalAuthReversalReply payPalAuthReversalReplyField;

        private PayPalDoCaptureReply payPalDoCaptureReplyField;

        private PayPalEcDoPaymentReply payPalEcDoPaymentReplyField;

        private PayPalEcGetDetailsReply payPalEcGetDetailsReplyField;

        private PayPalEcSetReply payPalEcSetReplyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string merchantReferenceCode
        {
            get
            {
                return this.merchantReferenceCodeField;
            }
            set
            {
                this.merchantReferenceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string requestID
        {
            get
            {
                return this.requestIDField;
            }
            set
            {
                this.requestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string decision
        {
            get
            {
                return this.decisionField;
            }
            set
            {
                this.decisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute("missingField", Order = 4)]
        public string[] missingField
        {
            get
            {
                return this.missingFieldField;
            }
            set
            {
                this.missingFieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("invalidField", Order = 5)]
        public string[] invalidField
        {
            get
            {
                return this.invalidFieldField;
            }
            set
            {
                this.invalidFieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string requestToken
        {
            get
            {
                return this.requestTokenField;
            }
            set
            {
                this.requestTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public PurchaseTotals purchaseTotals
        {
            get
            {
                return this.purchaseTotalsField;
            }
            set
            {
                this.purchaseTotalsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deniedPartiesMatch", Order = 8)]
        public DeniedPartiesMatch[] deniedPartiesMatch
        {
            get
            {
                return this.deniedPartiesMatchField;
            }
            set
            {
                this.deniedPartiesMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public CCAuthReply ccAuthReply
        {
            get
            {
                return this.ccAuthReplyField;
            }
            set
            {
                this.ccAuthReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public CCCaptureReply ccCaptureReply
        {
            get
            {
                return this.ccCaptureReplyField;
            }
            set
            {
                this.ccCaptureReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public CCCreditReply ccCreditReply
        {
            get
            {
                return this.ccCreditReplyField;
            }
            set
            {
                this.ccCreditReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public CCAuthReversalReply ccAuthReversalReply
        {
            get
            {
                return this.ccAuthReversalReplyField;
            }
            set
            {
                this.ccAuthReversalReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public ECDebitReply ecDebitReply
        {
            get
            {
                return this.ecDebitReplyField;
            }
            set
            {
                this.ecDebitReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public ECCreditReply ecCreditReply
        {
            get
            {
                return this.ecCreditReplyField;
            }
            set
            {
                this.ecCreditReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public PayerAuthEnrollReply payerAuthEnrollReply
        {
            get
            {
                return this.payerAuthEnrollReplyField;
            }
            set
            {
                this.payerAuthEnrollReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public PayerAuthValidateReply payerAuthValidateReply
        {
            get
            {
                return this.payerAuthValidateReplyField;
            }
            set
            {
                this.payerAuthValidateReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public TaxReply taxReply
        {
            get
            {
                return this.taxReplyField;
            }
            set
            {
                this.taxReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public AFSReply afsReply
        {
            get
            {
                return this.afsReplyField;
            }
            set
            {
                this.afsReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public DAVReply davReply
        {
            get
            {
                return this.davReplyField;
            }
            set
            {
                this.davReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public ExportReply exportReply
        {
            get
            {
                return this.exportReplyField;
            }
            set
            {
                this.exportReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public FXRatesReply fxRatesReply
        {
            get
            {
                return this.fxRatesReplyField;
            }
            set
            {
                this.fxRatesReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public BankTransferReply bankTransferReply
        {
            get
            {
                return this.bankTransferReplyField;
            }
            set
            {
                this.bankTransferReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public BankTransferRefundReply bankTransferRefundReply
        {
            get
            {
                return this.bankTransferRefundReplyField;
            }
            set
            {
                this.bankTransferRefundReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public BankTransferRealTimeReply bankTransferRealTimeReply
        {
            get
            {
                return this.bankTransferRealTimeReplyField;
            }
            set
            {
                this.bankTransferRealTimeReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
        public DirectDebitMandateReply directDebitMandateReply
        {
            get
            {
                return this.directDebitMandateReplyField;
            }
            set
            {
                this.directDebitMandateReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
        public DirectDebitReply directDebitReply
        {
            get
            {
                return this.directDebitReplyField;
            }
            set
            {
                this.directDebitReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 27)]
        public DirectDebitValidateReply directDebitValidateReply
        {
            get
            {
                return this.directDebitValidateReplyField;
            }
            set
            {
                this.directDebitValidateReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 28)]
        public DirectDebitRefundReply directDebitRefundReply
        {
            get
            {
                return this.directDebitRefundReplyField;
            }
            set
            {
                this.directDebitRefundReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
        public PaySubscriptionCreateReply paySubscriptionCreateReply
        {
            get
            {
                return this.paySubscriptionCreateReplyField;
            }
            set
            {
                this.paySubscriptionCreateReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
        public PaySubscriptionUpdateReply paySubscriptionUpdateReply
        {
            get
            {
                return this.paySubscriptionUpdateReplyField;
            }
            set
            {
                this.paySubscriptionUpdateReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
        public PaySubscriptionEventUpdateReply paySubscriptionEventUpdateReply
        {
            get
            {
                return this.paySubscriptionEventUpdateReplyField;
            }
            set
            {
                this.paySubscriptionEventUpdateReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 32)]
        public PaySubscriptionRetrieveReply paySubscriptionRetrieveReply
        {
            get
            {
                return this.paySubscriptionRetrieveReplyField;
            }
            set
            {
                this.paySubscriptionRetrieveReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 33)]
        public PayPalPaymentReply payPalPaymentReply
        {
            get
            {
                return this.payPalPaymentReplyField;
            }
            set
            {
                this.payPalPaymentReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 34)]
        public PayPalCreditReply payPalCreditReply
        {
            get
            {
                return this.payPalCreditReplyField;
            }
            set
            {
                this.payPalCreditReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 35)]
        public VoidReply voidReply
        {
            get
            {
                return this.voidReplyField;
            }
            set
            {
                this.voidReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 36)]
        public PinlessDebitReply pinlessDebitReply
        {
            get
            {
                return this.pinlessDebitReplyField;
            }
            set
            {
                this.pinlessDebitReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 37)]
        public PinlessDebitValidateReply pinlessDebitValidateReply
        {
            get
            {
                return this.pinlessDebitValidateReplyField;
            }
            set
            {
                this.pinlessDebitValidateReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 38)]
        public PayPalButtonCreateReply payPalButtonCreateReply
        {
            get
            {
                return this.payPalButtonCreateReplyField;
            }
            set
            {
                this.payPalButtonCreateReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 39)]
        public PayPalPreapprovedPaymentReply payPalPreapprovedPaymentReply
        {
            get
            {
                return this.payPalPreapprovedPaymentReplyField;
            }
            set
            {
                this.payPalPreapprovedPaymentReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 40)]
        public PayPalPreapprovedUpdateReply payPalPreapprovedUpdateReply
        {
            get
            {
                return this.payPalPreapprovedUpdateReplyField;
            }
            set
            {
                this.payPalPreapprovedUpdateReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 41)]
        public RiskUpdateReply riskUpdateReply
        {
            get
            {
                return this.riskUpdateReplyField;
            }
            set
            {
                this.riskUpdateReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 42)]
        public DecisionReply decisionReply
        {
            get
            {
                return this.decisionReplyField;
            }
            set
            {
                this.decisionReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 43)]
        public System.Xml.XmlElement reserved
        {
            get
            {
                return this.reservedField;
            }
            set
            {
                this.reservedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 44)]
        public PayPalRefundReply payPalRefundReply
        {
            get
            {
                return this.payPalRefundReplyField;
            }
            set
            {
                this.payPalRefundReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 45)]
        public PayPalAuthReversalReply payPalAuthReversalReply
        {
            get
            {
                return this.payPalAuthReversalReplyField;
            }
            set
            {
                this.payPalAuthReversalReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 46)]
        public PayPalDoCaptureReply payPalDoCaptureReply
        {
            get
            {
                return this.payPalDoCaptureReplyField;
            }
            set
            {
                this.payPalDoCaptureReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 47)]
        public PayPalEcDoPaymentReply payPalEcDoPaymentReply
        {
            get
            {
                return this.payPalEcDoPaymentReplyField;
            }
            set
            {
                this.payPalEcDoPaymentReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 48)]
        public PayPalEcGetDetailsReply payPalEcGetDetailsReply
        {
            get
            {
                return this.payPalEcGetDetailsReplyField;
            }
            set
            {
                this.payPalEcGetDetailsReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 49)]
        public PayPalEcSetReply payPalEcSetReply
        {
            get
            {
                return this.payPalEcSetReplyField;
            }
            set
            {
                this.payPalEcSetReplyField = value;
            }
        }
    }

}
