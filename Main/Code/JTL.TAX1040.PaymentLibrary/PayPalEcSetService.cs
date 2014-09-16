
namespace JTL.Tax1040.PaymentLibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29")]
    public partial class PayPalEcSetService
    {

        private string paypalReturnField;

        private string paypalCancelReturnField;

        private string paypalMaxamtField;

        private string paypalCustomerEmailField;

        private string paypalDescField;

        private string paypalReqconfirmshippingField;

        private string paypalNoshippingField;

        private string paypalAddressOverrideField;

        private string paypalTokenField;

        private string paypalLcField;

        private string paypalPagestyleField;

        private string paypalHdrimgField;

        private string paypalHdrbordercolorField;

        private string paypalHdrbackcolorField;

        private string paypalPayflowcolorField;

        private string paypalEcSetRequestIDField;

        private string paypalEcSetRequestTokenField;

        private string runField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string paypalReturn
        {
            get
            {
                return this.paypalReturnField;
            }
            set
            {
                this.paypalReturnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string paypalCancelReturn
        {
            get
            {
                return this.paypalCancelReturnField;
            }
            set
            {
                this.paypalCancelReturnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string paypalMaxamt
        {
            get
            {
                return this.paypalMaxamtField;
            }
            set
            {
                this.paypalMaxamtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string paypalCustomerEmail
        {
            get
            {
                return this.paypalCustomerEmailField;
            }
            set
            {
                this.paypalCustomerEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string paypalDesc
        {
            get
            {
                return this.paypalDescField;
            }
            set
            {
                this.paypalDescField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string paypalReqconfirmshipping
        {
            get
            {
                return this.paypalReqconfirmshippingField;
            }
            set
            {
                this.paypalReqconfirmshippingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string paypalNoshipping
        {
            get
            {
                return this.paypalNoshippingField;
            }
            set
            {
                this.paypalNoshippingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string paypalAddressOverride
        {
            get
            {
                return this.paypalAddressOverrideField;
            }
            set
            {
                this.paypalAddressOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string paypalLc
        {
            get
            {
                return this.paypalLcField;
            }
            set
            {
                this.paypalLcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string paypalPagestyle
        {
            get
            {
                return this.paypalPagestyleField;
            }
            set
            {
                this.paypalPagestyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string paypalHdrimg
        {
            get
            {
                return this.paypalHdrimgField;
            }
            set
            {
                this.paypalHdrimgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string paypalHdrbordercolor
        {
            get
            {
                return this.paypalHdrbordercolorField;
            }
            set
            {
                this.paypalHdrbordercolorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string paypalHdrbackcolor
        {
            get
            {
                return this.paypalHdrbackcolorField;
            }
            set
            {
                this.paypalHdrbackcolorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string paypalPayflowcolor
        {
            get
            {
                return this.paypalPayflowcolorField;
            }
            set
            {
                this.paypalPayflowcolorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string paypalEcSetRequestID
        {
            get
            {
                return this.paypalEcSetRequestIDField;
            }
            set
            {
                this.paypalEcSetRequestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string paypalEcSetRequestToken
        {
            get
            {
                return this.paypalEcSetRequestTokenField;
            }
            set
            {
                this.paypalEcSetRequestTokenField = value;
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
