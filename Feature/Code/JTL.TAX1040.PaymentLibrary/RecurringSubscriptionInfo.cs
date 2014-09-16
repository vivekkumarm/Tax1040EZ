
namespace JTL.Tax1040.PaymentLibrary
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class RecurringSubscriptionInfo
    {

        private string subscriptionIDField;

        private string statusField;

        private string amountField;

        private string numberOfPaymentsField;

        private string numberOfPaymentsToAddField;

        private string automaticRenewField;

        private string frequencyField;

        private string startDateField;

        private string endDateField;

        private string approvalRequiredField;

        private PaySubscriptionEvent eventField;

        private string billPaymentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string subscriptionID
        {
            get
            {
                return this.subscriptionIDField;
            }
            set
            {
                this.subscriptionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 3)]
        public string numberOfPayments
        {
            get
            {
                return this.numberOfPaymentsField;
            }
            set
            {
                this.numberOfPaymentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 4)]
        public string numberOfPaymentsToAdd
        {
            get
            {
                return this.numberOfPaymentsToAddField;
            }
            set
            {
                this.numberOfPaymentsToAddField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string automaticRenew
        {
            get
            {
                return this.automaticRenewField;
            }
            set
            {
                this.automaticRenewField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string frequency
        {
            get
            {
                return this.frequencyField;
            }
            set
            {
                this.frequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string startDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string endDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string approvalRequired
        {
            get
            {
                return this.approvalRequiredField;
            }
            set
            {
                this.approvalRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public PaySubscriptionEvent @event
        {
            get
            {
                return this.eventField;
            }
            set
            {
                this.eventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string billPayment
        {
            get
            {
                return this.billPaymentField;
            }
            set
            {
                this.billPaymentField = value;
            }
        }
    }

}
