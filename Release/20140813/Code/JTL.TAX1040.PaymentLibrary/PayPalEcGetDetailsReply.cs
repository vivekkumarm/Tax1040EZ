
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayPalEcGetDetailsReply
    {

        private string reasonCodeField;

        private string paypalTokenField;

        private string payerField;

        private string payerIdField;

        private string payerStatusField;

        private string payerSalutationField;

        private string payerFirstnameField;

        private string payerMiddlenameField;

        private string payerLastnameField;

        private string paypalSuffixField;

        private string payerCountryField;

        private string payerBusinessField;

        private string shipToNameField;

        private string shipToAddress1Field;

        private string shipToAddress2Field;

        private string shipToCityField;

        private string shipToStateField;

        private string shipToCountryField;

        private string shipToZipField;

        private string addressStatusField;

        private string payerPhoneField;

        private string avsCodeField;

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
        public string payer
        {
            get
            {
                return this.payerField;
            }
            set
            {
                this.payerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string payerId
        {
            get
            {
                return this.payerIdField;
            }
            set
            {
                this.payerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string payerStatus
        {
            get
            {
                return this.payerStatusField;
            }
            set
            {
                this.payerStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string payerSalutation
        {
            get
            {
                return this.payerSalutationField;
            }
            set
            {
                this.payerSalutationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string payerFirstname
        {
            get
            {
                return this.payerFirstnameField;
            }
            set
            {
                this.payerFirstnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string payerMiddlename
        {
            get
            {
                return this.payerMiddlenameField;
            }
            set
            {
                this.payerMiddlenameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string payerLastname
        {
            get
            {
                return this.payerLastnameField;
            }
            set
            {
                this.payerLastnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string paypalSuffix
        {
            get
            {
                return this.paypalSuffixField;
            }
            set
            {
                this.paypalSuffixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string payerCountry
        {
            get
            {
                return this.payerCountryField;
            }
            set
            {
                this.payerCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string payerBusiness
        {
            get
            {
                return this.payerBusinessField;
            }
            set
            {
                this.payerBusinessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string shipToName
        {
            get
            {
                return this.shipToNameField;
            }
            set
            {
                this.shipToNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string shipToAddress1
        {
            get
            {
                return this.shipToAddress1Field;
            }
            set
            {
                this.shipToAddress1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string shipToAddress2
        {
            get
            {
                return this.shipToAddress2Field;
            }
            set
            {
                this.shipToAddress2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string shipToCity
        {
            get
            {
                return this.shipToCityField;
            }
            set
            {
                this.shipToCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string shipToState
        {
            get
            {
                return this.shipToStateField;
            }
            set
            {
                this.shipToStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string shipToCountry
        {
            get
            {
                return this.shipToCountryField;
            }
            set
            {
                this.shipToCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string shipToZip
        {
            get
            {
                return this.shipToZipField;
            }
            set
            {
                this.shipToZipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public string addressStatus
        {
            get
            {
                return this.addressStatusField;
            }
            set
            {
                this.addressStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public string payerPhone
        {
            get
            {
                return this.payerPhoneField;
            }
            set
            {
                this.payerPhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
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
    }

}
