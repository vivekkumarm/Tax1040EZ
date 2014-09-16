
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class AirlineData
    {

        private string agentCodeField;

        private string agentNameField;

        private string ticketIssuerCityField;

        private string ticketIssuerStateField;

        private string ticketIssuerPostalCodeField;

        private string ticketIssuerCountryField;

        private string ticketIssuerCodeField;

        private string ticketIssuerNameField;

        private string ticketNumberField;

        private string checkDigitField;

        private string restrictedTicketIndicatorField;

        private string transactionTypeField;

        private string extendedPaymentCodeField;

        private string carrierNameField;

        private string passengerNameField;

        private string customerCodeField;

        private string documentTypeField;

        private string documentNumberField;

        private string documentNumberOfPartsField;

        private string invoiceNumberField;

        private string invoiceDateField;

        private string chargeDetailsField;

        private string bookingReferenceField;

        private string totalFeeField;

        private string clearingSequenceField;

        private string clearingCountField;

        private string totalClearingAmountField;

        private Leg[] legField;

        private string numberOfPassengersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string agentCode
        {
            get
            {
                return this.agentCodeField;
            }
            set
            {
                this.agentCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string agentName
        {
            get
            {
                return this.agentNameField;
            }
            set
            {
                this.agentNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ticketIssuerCity
        {
            get
            {
                return this.ticketIssuerCityField;
            }
            set
            {
                this.ticketIssuerCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string ticketIssuerState
        {
            get
            {
                return this.ticketIssuerStateField;
            }
            set
            {
                this.ticketIssuerStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string ticketIssuerPostalCode
        {
            get
            {
                return this.ticketIssuerPostalCodeField;
            }
            set
            {
                this.ticketIssuerPostalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string ticketIssuerCountry
        {
            get
            {
                return this.ticketIssuerCountryField;
            }
            set
            {
                this.ticketIssuerCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string ticketIssuerCode
        {
            get
            {
                return this.ticketIssuerCodeField;
            }
            set
            {
                this.ticketIssuerCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string ticketIssuerName
        {
            get
            {
                return this.ticketIssuerNameField;
            }
            set
            {
                this.ticketIssuerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string ticketNumber
        {
            get
            {
                return this.ticketNumberField;
            }
            set
            {
                this.ticketNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 9)]
        public string checkDigit
        {
            get
            {
                return this.checkDigitField;
            }
            set
            {
                this.checkDigitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 10)]
        public string restrictedTicketIndicator
        {
            get
            {
                return this.restrictedTicketIndicatorField;
            }
            set
            {
                this.restrictedTicketIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string transactionType
        {
            get
            {
                return this.transactionTypeField;
            }
            set
            {
                this.transactionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string extendedPaymentCode
        {
            get
            {
                return this.extendedPaymentCodeField;
            }
            set
            {
                this.extendedPaymentCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string carrierName
        {
            get
            {
                return this.carrierNameField;
            }
            set
            {
                this.carrierNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string passengerName
        {
            get
            {
                return this.passengerNameField;
            }
            set
            {
                this.passengerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string customerCode
        {
            get
            {
                return this.customerCodeField;
            }
            set
            {
                this.customerCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string documentType
        {
            get
            {
                return this.documentTypeField;
            }
            set
            {
                this.documentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string documentNumber
        {
            get
            {
                return this.documentNumberField;
            }
            set
            {
                this.documentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string documentNumberOfParts
        {
            get
            {
                return this.documentNumberOfPartsField;
            }
            set
            {
                this.documentNumberOfPartsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public string invoiceNumber
        {
            get
            {
                return this.invoiceNumberField;
            }
            set
            {
                this.invoiceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public string invoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public string chargeDetails
        {
            get
            {
                return this.chargeDetailsField;
            }
            set
            {
                this.chargeDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public string bookingReference
        {
            get
            {
                return this.bookingReferenceField;
            }
            set
            {
                this.bookingReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public string totalFee
        {
            get
            {
                return this.totalFeeField;
            }
            set
            {
                this.totalFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public string clearingSequence
        {
            get
            {
                return this.clearingSequenceField;
            }
            set
            {
                this.clearingSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 25)]
        public string clearingCount
        {
            get
            {
                return this.clearingCountField;
            }
            set
            {
                this.clearingCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
        public string totalClearingAmount
        {
            get
            {
                return this.totalClearingAmountField;
            }
            set
            {
                this.totalClearingAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("leg", Order = 27)]
        public Leg[] leg
        {
            get
            {
                return this.legField;
            }
            set
            {
                this.legField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 28)]
        public string numberOfPassengers
        {
            get
            {
                return this.numberOfPassengersField;
            }
            set
            {
                this.numberOfPassengersField = value;
            }
        }
    }

}
