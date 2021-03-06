﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace JTL.Tax1040.PaymentLibrary
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data:TransactionProcessor", ConfigurationName = "ITransactionProcessor")]
    public interface ITransactionProcessor
    {

        // CODEGEN: Generating message contract since the operation runTransaction is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action = "runTransaction", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        outputMessageOut runTransaction(inputMessageIn request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class RequestMessage
    {

        private string merchantIDField;

        private string merchantReferenceCodeField;

        private string clientLibraryField;

        private string clientLibraryVersionField;

        private string clientEnvironmentField;

        private string clientSecurityLibraryVersionField;

        private string clientApplicationField;

        private string clientApplicationVersionField;

        private string clientApplicationUserField;

        private string routingCodeField;

        private string commentsField;

        private InvoiceHeader invoiceHeaderField;

        private BillTo billToField;

        private ShipTo shipToField;

        private ShipFrom shipFromField;

        private Item[] itemField;

        private PurchaseTotals purchaseTotalsField;

        private FundingTotals fundingTotalsField;

        private Pos posField;

        private Installment installmentField;

        private Card cardField;

        private Check checkField;

        private BML bmlField;

        private GECC geccField;

        private UCAF ucafField;

        private FundTransfer fundTransferField;

        private BankInfo bankInfoField;

        private Subscription subscriptionField;

        private RecurringSubscriptionInfo recurringSubscriptionInfoField;

        private DecisionManager decisionManagerField;

        private OtherTax otherTaxField;

        private PayPal paypalField;

        private MerchantDefinedData merchantDefinedDataField;

        private MerchantSecureData merchantSecureDataField;

        private JPO jpoField;

        private CCAuthService ccAuthServiceField;

        private CCCaptureService ccCaptureServiceField;

        private CCCreditService ccCreditServiceField;

        private CCAuthReversalService ccAuthReversalServiceField;

        private ECDebitService ecDebitServiceField;

        private ECCreditService ecCreditServiceField;

        private PayerAuthEnrollService payerAuthEnrollServiceField;

        private PayerAuthValidateService payerAuthValidateServiceField;

        private TaxService taxServiceField;

        private AFSService afsServiceField;

        private DAVService davServiceField;

        private ExportService exportServiceField;

        private FXRatesService fxRatesServiceField;

        private BankTransferService bankTransferServiceField;

        private BankTransferRefundService bankTransferRefundServiceField;

        private BankTransferRealTimeService bankTransferRealTimeServiceField;

        private DirectDebitMandateService directDebitMandateServiceField;

        private DirectDebitService directDebitServiceField;

        private DirectDebitRefundService directDebitRefundServiceField;

        private DirectDebitValidateService directDebitValidateServiceField;

        private PaySubscriptionCreateService paySubscriptionCreateServiceField;

        private PaySubscriptionUpdateService paySubscriptionUpdateServiceField;

        private PaySubscriptionEventUpdateService paySubscriptionEventUpdateServiceField;

        private PaySubscriptionRetrieveService paySubscriptionRetrieveServiceField;

        private PayPalPaymentService payPalPaymentServiceField;

        private PayPalCreditService payPalCreditServiceField;

        private VoidService voidServiceField;

        private BusinessRules businessRulesField;

        private PinlessDebitService pinlessDebitServiceField;

        private PinlessDebitValidateService pinlessDebitValidateServiceField;

        private Batch batchField;

        private AirlineData airlineDataField;

        private PayPalButtonCreateService payPalButtonCreateServiceField;

        private PayPalPreapprovedPaymentService payPalPreapprovedPaymentServiceField;

        private PayPalPreapprovedUpdateService payPalPreapprovedUpdateServiceField;

        private RiskUpdateService riskUpdateServiceField;

        private RequestReserved[] reservedField;

        private string deviceFingerprintIDField;

        private PayPalRefundService payPalRefundServiceField;

        private PayPalAuthReversalService payPalAuthReversalServiceField;

        private PayPalDoCaptureService payPalDoCaptureServiceField;

        private PayPalEcDoPaymentService payPalEcDoPaymentServiceField;

        private PayPalEcGetDetailsService payPalEcGetDetailsServiceField;

        private PayPalEcSetService payPalEcSetServiceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string merchantID
        {
            get
            {
                return this.merchantIDField;
            }
            set
            {
                this.merchantIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string clientLibrary
        {
            get
            {
                return this.clientLibraryField;
            }
            set
            {
                this.clientLibraryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string clientLibraryVersion
        {
            get
            {
                return this.clientLibraryVersionField;
            }
            set
            {
                this.clientLibraryVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string clientEnvironment
        {
            get
            {
                return this.clientEnvironmentField;
            }
            set
            {
                this.clientEnvironmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string clientSecurityLibraryVersion
        {
            get
            {
                return this.clientSecurityLibraryVersionField;
            }
            set
            {
                this.clientSecurityLibraryVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string clientApplication
        {
            get
            {
                return this.clientApplicationField;
            }
            set
            {
                this.clientApplicationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string clientApplicationVersion
        {
            get
            {
                return this.clientApplicationVersionField;
            }
            set
            {
                this.clientApplicationVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string clientApplicationUser
        {
            get
            {
                return this.clientApplicationUserField;
            }
            set
            {
                this.clientApplicationUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string routingCode
        {
            get
            {
                return this.routingCodeField;
            }
            set
            {
                this.routingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public InvoiceHeader invoiceHeader
        {
            get
            {
                return this.invoiceHeaderField;
            }
            set
            {
                this.invoiceHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public BillTo billTo
        {
            get
            {
                return this.billToField;
            }
            set
            {
                this.billToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public ShipTo shipTo
        {
            get
            {
                return this.shipToField;
            }
            set
            {
                this.shipToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public ShipFrom shipFrom
        {
            get
            {
                return this.shipFromField;
            }
            set
            {
                this.shipFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item", Order = 15)]
        public Item[] item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public Pos pos
        {
            get
            {
                return this.posField;
            }
            set
            {
                this.posField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public Installment installment
        {
            get
            {
                return this.installmentField;
            }
            set
            {
                this.installmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public Card card
        {
            get
            {
                return this.cardField;
            }
            set
            {
                this.cardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public Check check
        {
            get
            {
                return this.checkField;
            }
            set
            {
                this.checkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public BML bml
        {
            get
            {
                return this.bmlField;
            }
            set
            {
                this.bmlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public GECC gecc
        {
            get
            {
                return this.geccField;
            }
            set
            {
                this.geccField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public UCAF ucaf
        {
            get
            {
                return this.ucafField;
            }
            set
            {
                this.ucafField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
        public FundTransfer fundTransfer
        {
            get
            {
                return this.fundTransferField;
            }
            set
            {
                this.fundTransferField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
        public BankInfo bankInfo
        {
            get
            {
                return this.bankInfoField;
            }
            set
            {
                this.bankInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 27)]
        public Subscription subscription
        {
            get
            {
                return this.subscriptionField;
            }
            set
            {
                this.subscriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 28)]
        public RecurringSubscriptionInfo recurringSubscriptionInfo
        {
            get
            {
                return this.recurringSubscriptionInfoField;
            }
            set
            {
                this.recurringSubscriptionInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
        public DecisionManager decisionManager
        {
            get
            {
                return this.decisionManagerField;
            }
            set
            {
                this.decisionManagerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
        public OtherTax otherTax
        {
            get
            {
                return this.otherTaxField;
            }
            set
            {
                this.otherTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
        public PayPal paypal
        {
            get
            {
                return this.paypalField;
            }
            set
            {
                this.paypalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 32)]
        public MerchantDefinedData merchantDefinedData
        {
            get
            {
                return this.merchantDefinedDataField;
            }
            set
            {
                this.merchantDefinedDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 33)]
        public MerchantSecureData merchantSecureData
        {
            get
            {
                return this.merchantSecureDataField;
            }
            set
            {
                this.merchantSecureDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 34)]
        public JPO jpo
        {
            get
            {
                return this.jpoField;
            }
            set
            {
                this.jpoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 35)]
        public CCAuthService ccAuthService
        {
            get
            {
                return this.ccAuthServiceField;
            }
            set
            {
                this.ccAuthServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 36)]
        public CCCaptureService ccCaptureService
        {
            get
            {
                return this.ccCaptureServiceField;
            }
            set
            {
                this.ccCaptureServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 37)]
        public CCCreditService ccCreditService
        {
            get
            {
                return this.ccCreditServiceField;
            }
            set
            {
                this.ccCreditServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 38)]
        public CCAuthReversalService ccAuthReversalService
        {
            get
            {
                return this.ccAuthReversalServiceField;
            }
            set
            {
                this.ccAuthReversalServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 39)]
        public ECDebitService ecDebitService
        {
            get
            {
                return this.ecDebitServiceField;
            }
            set
            {
                this.ecDebitServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 40)]
        public ECCreditService ecCreditService
        {
            get
            {
                return this.ecCreditServiceField;
            }
            set
            {
                this.ecCreditServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 41)]
        public PayerAuthEnrollService payerAuthEnrollService
        {
            get
            {
                return this.payerAuthEnrollServiceField;
            }
            set
            {
                this.payerAuthEnrollServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 42)]
        public PayerAuthValidateService payerAuthValidateService
        {
            get
            {
                return this.payerAuthValidateServiceField;
            }
            set
            {
                this.payerAuthValidateServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 43)]
        public TaxService taxService
        {
            get
            {
                return this.taxServiceField;
            }
            set
            {
                this.taxServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 44)]
        public AFSService afsService
        {
            get
            {
                return this.afsServiceField;
            }
            set
            {
                this.afsServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 45)]
        public DAVService davService
        {
            get
            {
                return this.davServiceField;
            }
            set
            {
                this.davServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 46)]
        public ExportService exportService
        {
            get
            {
                return this.exportServiceField;
            }
            set
            {
                this.exportServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 47)]
        public FXRatesService fxRatesService
        {
            get
            {
                return this.fxRatesServiceField;
            }
            set
            {
                this.fxRatesServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 48)]
        public BankTransferService bankTransferService
        {
            get
            {
                return this.bankTransferServiceField;
            }
            set
            {
                this.bankTransferServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 49)]
        public BankTransferRefundService bankTransferRefundService
        {
            get
            {
                return this.bankTransferRefundServiceField;
            }
            set
            {
                this.bankTransferRefundServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 50)]
        public BankTransferRealTimeService bankTransferRealTimeService
        {
            get
            {
                return this.bankTransferRealTimeServiceField;
            }
            set
            {
                this.bankTransferRealTimeServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 51)]
        public DirectDebitMandateService directDebitMandateService
        {
            get
            {
                return this.directDebitMandateServiceField;
            }
            set
            {
                this.directDebitMandateServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 52)]
        public DirectDebitService directDebitService
        {
            get
            {
                return this.directDebitServiceField;
            }
            set
            {
                this.directDebitServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 53)]
        public DirectDebitRefundService directDebitRefundService
        {
            get
            {
                return this.directDebitRefundServiceField;
            }
            set
            {
                this.directDebitRefundServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 54)]
        public DirectDebitValidateService directDebitValidateService
        {
            get
            {
                return this.directDebitValidateServiceField;
            }
            set
            {
                this.directDebitValidateServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 55)]
        public PaySubscriptionCreateService paySubscriptionCreateService
        {
            get
            {
                return this.paySubscriptionCreateServiceField;
            }
            set
            {
                this.paySubscriptionCreateServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 56)]
        public PaySubscriptionUpdateService paySubscriptionUpdateService
        {
            get
            {
                return this.paySubscriptionUpdateServiceField;
            }
            set
            {
                this.paySubscriptionUpdateServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 57)]
        public PaySubscriptionEventUpdateService paySubscriptionEventUpdateService
        {
            get
            {
                return this.paySubscriptionEventUpdateServiceField;
            }
            set
            {
                this.paySubscriptionEventUpdateServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 58)]
        public PaySubscriptionRetrieveService paySubscriptionRetrieveService
        {
            get
            {
                return this.paySubscriptionRetrieveServiceField;
            }
            set
            {
                this.paySubscriptionRetrieveServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 59)]
        public PayPalPaymentService payPalPaymentService
        {
            get
            {
                return this.payPalPaymentServiceField;
            }
            set
            {
                this.payPalPaymentServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 60)]
        public PayPalCreditService payPalCreditService
        {
            get
            {
                return this.payPalCreditServiceField;
            }
            set
            {
                this.payPalCreditServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 61)]
        public VoidService voidService
        {
            get
            {
                return this.voidServiceField;
            }
            set
            {
                this.voidServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 62)]
        public BusinessRules businessRules
        {
            get
            {
                return this.businessRulesField;
            }
            set
            {
                this.businessRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 63)]
        public PinlessDebitService pinlessDebitService
        {
            get
            {
                return this.pinlessDebitServiceField;
            }
            set
            {
                this.pinlessDebitServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 64)]
        public PinlessDebitValidateService pinlessDebitValidateService
        {
            get
            {
                return this.pinlessDebitValidateServiceField;
            }
            set
            {
                this.pinlessDebitValidateServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 65)]
        public Batch batch
        {
            get
            {
                return this.batchField;
            }
            set
            {
                this.batchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 66)]
        public AirlineData airlineData
        {
            get
            {
                return this.airlineDataField;
            }
            set
            {
                this.airlineDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 67)]
        public PayPalButtonCreateService payPalButtonCreateService
        {
            get
            {
                return this.payPalButtonCreateServiceField;
            }
            set
            {
                this.payPalButtonCreateServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 68)]
        public PayPalPreapprovedPaymentService payPalPreapprovedPaymentService
        {
            get
            {
                return this.payPalPreapprovedPaymentServiceField;
            }
            set
            {
                this.payPalPreapprovedPaymentServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 69)]
        public PayPalPreapprovedUpdateService payPalPreapprovedUpdateService
        {
            get
            {
                return this.payPalPreapprovedUpdateServiceField;
            }
            set
            {
                this.payPalPreapprovedUpdateServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 70)]
        public RiskUpdateService riskUpdateService
        {
            get
            {
                return this.riskUpdateServiceField;
            }
            set
            {
                this.riskUpdateServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reserved", Order = 71)]
        public RequestReserved[] reserved
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 72)]
        public string deviceFingerprintID
        {
            get
            {
                return this.deviceFingerprintIDField;
            }
            set
            {
                this.deviceFingerprintIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 73)]
        public PayPalRefundService payPalRefundService
        {
            get
            {
                return this.payPalRefundServiceField;
            }
            set
            {
                this.payPalRefundServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 74)]
        public PayPalAuthReversalService payPalAuthReversalService
        {
            get
            {
                return this.payPalAuthReversalServiceField;
            }
            set
            {
                this.payPalAuthReversalServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 75)]
        public PayPalDoCaptureService payPalDoCaptureService
        {
            get
            {
                return this.payPalDoCaptureServiceField;
            }
            set
            {
                this.payPalDoCaptureServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 76)]
        public PayPalEcDoPaymentService payPalEcDoPaymentService
        {
            get
            {
                return this.payPalEcDoPaymentServiceField;
            }
            set
            {
                this.payPalEcDoPaymentServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 77)]
        public PayPalEcGetDetailsService payPalEcGetDetailsService
        {
            get
            {
                return this.payPalEcGetDetailsServiceField;
            }
            set
            {
                this.payPalEcGetDetailsServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 78)]
        public PayPalEcSetService payPalEcSetService
        {
            get
            {
                return this.payPalEcSetServiceField;
            }
            set
            {
                this.payPalEcSetServiceField = value;
            }
        }
    }
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ITransactionProcessorChannel : ITransactionProcessor, System.ServiceModel.IClientChannel
    {
    }


}