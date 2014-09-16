
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class TaxService
    {

        private string nexusField;

        private string noNexusField;

        private string orderAcceptanceCityField;

        private string orderAcceptanceCountyField;

        private string orderAcceptanceCountryField;

        private string orderAcceptanceStateField;

        private string orderAcceptancePostalCodeField;

        private string orderOriginCityField;

        private string orderOriginCountyField;

        private string orderOriginCountryField;

        private string orderOriginStateField;

        private string orderOriginPostalCodeField;

        private string sellerRegistrationField;

        private string buyerRegistrationField;

        private string middlemanRegistrationField;

        private string pointOfTitleTransferField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string nexus
        {
            get
            {
                return this.nexusField;
            }
            set
            {
                this.nexusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string noNexus
        {
            get
            {
                return this.noNexusField;
            }
            set
            {
                this.noNexusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string orderAcceptanceCity
        {
            get
            {
                return this.orderAcceptanceCityField;
            }
            set
            {
                this.orderAcceptanceCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string orderAcceptanceCounty
        {
            get
            {
                return this.orderAcceptanceCountyField;
            }
            set
            {
                this.orderAcceptanceCountyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string orderAcceptanceCountry
        {
            get
            {
                return this.orderAcceptanceCountryField;
            }
            set
            {
                this.orderAcceptanceCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string orderAcceptanceState
        {
            get
            {
                return this.orderAcceptanceStateField;
            }
            set
            {
                this.orderAcceptanceStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string orderAcceptancePostalCode
        {
            get
            {
                return this.orderAcceptancePostalCodeField;
            }
            set
            {
                this.orderAcceptancePostalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string orderOriginCity
        {
            get
            {
                return this.orderOriginCityField;
            }
            set
            {
                this.orderOriginCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string orderOriginCounty
        {
            get
            {
                return this.orderOriginCountyField;
            }
            set
            {
                this.orderOriginCountyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string orderOriginCountry
        {
            get
            {
                return this.orderOriginCountryField;
            }
            set
            {
                this.orderOriginCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string orderOriginState
        {
            get
            {
                return this.orderOriginStateField;
            }
            set
            {
                this.orderOriginStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string orderOriginPostalCode
        {
            get
            {
                return this.orderOriginPostalCodeField;
            }
            set
            {
                this.orderOriginPostalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string sellerRegistration
        {
            get
            {
                return this.sellerRegistrationField;
            }
            set
            {
                this.sellerRegistrationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string buyerRegistration
        {
            get
            {
                return this.buyerRegistrationField;
            }
            set
            {
                this.buyerRegistrationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string middlemanRegistration
        {
            get
            {
                return this.middlemanRegistrationField;
            }
            set
            {
                this.middlemanRegistrationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string pointOfTitleTransfer
        {
            get
            {
                return this.pointOfTitleTransferField;
            }
            set
            {
                this.pointOfTitleTransferField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string run
        {
            get
            {
                return this.runField;
            }
            set
            {
                this.runField = value;
            }
        }
    }

}
