using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Efile.SubmissionManifest
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.irs.gov/efile", IsNullable = false)]
    public partial class IRSSubmissionManifest
    {

        private string submissionIdField;

        private string eFINField;

        private string taxYearField;

        private GovernmentCodeType governmentCodeField;

        private IRSSubmissionManifestFederalSubmissionType federalSubmissionTypeField;

        private System.DateTime taxPeriodBeginDateField;

        private bool taxPeriodBeginDateFieldSpecified;

        private System.DateTime taxPeriodEndDateField;

        private bool taxPeriodEndDateFieldSpecified;

        private string tINField;

        /// <remarks/>
        public string SubmissionId
        {
            get
            {
                return this.submissionIdField;
            }
            set
            {
                this.submissionIdField = value;
            }
        }

        /// <remarks/>
        public string EFIN
        {
            get
            {
                return this.eFINField;
            }
            set
            {
                this.eFINField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "gYear")]
        public string TaxYear
        {
            get
            {
                return this.taxYearField;
            }
            set
            {
                this.taxYearField = value;
            }
        }

        /// <remarks/>
        public GovernmentCodeType GovernmentCode
        {
            get
            {
                return this.governmentCodeField;
            }
            set
            {
                this.governmentCodeField = value;
            }
        }

        /// <remarks/>
        public IRSSubmissionManifestFederalSubmissionType FederalSubmissionType
        {
            get
            {
                return this.federalSubmissionTypeField;
            }
            set
            {
                this.federalSubmissionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime TaxPeriodBeginDate
        {
            get
            {
                return this.taxPeriodBeginDateField;
            }
            set
            {
                this.taxPeriodBeginDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxPeriodBeginDateSpecified
        {
            get
            {
                return this.taxPeriodBeginDateFieldSpecified;
            }
            set
            {
                this.taxPeriodBeginDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime TaxPeriodEndDate
        {
            get
            {
                return this.taxPeriodEndDateField;
            }
            set
            {
                this.taxPeriodEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxPeriodEndDateSpecified
        {
            get
            {
                return this.taxPeriodEndDateFieldSpecified;
            }
            set
            {
                this.taxPeriodEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string TIN
        {
            get
            {
                return this.tINField;
            }
            set
            {
                this.tINField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.irs.gov/efile")]
    public enum GovernmentCodeType
    {

        /// <remarks/>
        IRS,

        /// <remarks/>
        ALST,

        /// <remarks/>
        AKST,

        /// <remarks/>
        AZST,

        /// <remarks/>
        ARST,

        /// <remarks/>
        CAST,

        /// <remarks/>
        COST,

        /// <remarks/>
        CTST,

        /// <remarks/>
        DEST,

        /// <remarks/>
        DCST,

        /// <remarks/>
        FLST,

        /// <remarks/>
        GAST,

        /// <remarks/>
        HIST,

        /// <remarks/>
        IDST,

        /// <remarks/>
        ILST,

        /// <remarks/>
        INST,

        /// <remarks/>
        IAST,

        /// <remarks/>
        KSST,

        /// <remarks/>
        KYST,

        /// <remarks/>
        LAST,

        /// <remarks/>
        MEST,

        /// <remarks/>
        MDST,

        /// <remarks/>
        MAST,

        /// <remarks/>
        MIST,

        /// <remarks/>
        MNST,

        /// <remarks/>
        MSST,

        /// <remarks/>
        MOST,

        /// <remarks/>
        MTST,

        /// <remarks/>
        NEST,

        /// <remarks/>
        NVST,

        /// <remarks/>
        NHST,

        /// <remarks/>
        NJST,

        /// <remarks/>
        NMST,

        /// <remarks/>
        NYST,

        /// <remarks/>
        NCST,

        /// <remarks/>
        NDST,

        /// <remarks/>
        OHST,

        /// <remarks/>
        OKST,

        /// <remarks/>
        ORST,

        /// <remarks/>
        PAST,

        /// <remarks/>
        RIST,

        /// <remarks/>
        SCST,

        /// <remarks/>
        SDST,

        /// <remarks/>
        TNST,

        /// <remarks/>
        TXST,

        /// <remarks/>
        UTST,

        /// <remarks/>
        VTST,

        /// <remarks/>
        VAST,

        /// <remarks/>
        WAST,

        /// <remarks/>
        WVST,

        /// <remarks/>
        WIST,

        /// <remarks/>
        WYST,

        /// <remarks/>
        NYCT,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    public enum IRSSubmissionManifestFederalSubmissionType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1040")]
        Item1040,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1120")]
        Item1120,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1120F")]
        Item1120F,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1120POL")]
        Item1120POL,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1120S")]
        Item1120S,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1065")]
        Item1065,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1065B")]
        Item1065B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2290")]
        Item2290,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4868")]
        Item4868,

        // <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2350")]
        Item2350,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7004")]
        Item7004,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("720")]
        Item720,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8849")]
        Item8849,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8868")]
        Item8868,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("990")]
        Item990,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("990EZ")]
        Item990EZ,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("990N")]
        Item990N,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("990PF")]
        Item990PF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.irs.gov/efile")]
    public partial class ValidationAlertListType
    {

        private ValidationAlertListTypeAlert[] alertField;

        private string alertCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alert")]
        public ValidationAlertListTypeAlert[] Alert
        {
            get
            {
                return this.alertField;
            }
            set
            {
                this.alertField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string alertCount
        {
            get
            {
                return this.alertCountField;
            }
            set
            {
                this.alertCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    public partial class ValidationAlertListTypeAlert
    {

        private string documentIDField;

        private string xPathField;

        private string alertCategoryField;

        private string alertMessageField;

        private string ruleNumberField;

        private string severityField;

        private string dataValueField;

        private string alertIdField;

        /// <remarks/>
        public string DocumentID
        {
            get
            {
                return this.documentIDField;
            }
            set
            {
                this.documentIDField = value;
            }
        }

        /// <remarks/>
        public string XPath
        {
            get
            {
                return this.xPathField;
            }
            set
            {
                this.xPathField = value;
            }
        }

        /// <remarks/>
        public string AlertCategory
        {
            get
            {
                return this.alertCategoryField;
            }
            set
            {
                this.alertCategoryField = value;
            }
        }

        /// <remarks/>
        public string AlertMessage
        {
            get
            {
                return this.alertMessageField;
            }
            set
            {
                this.alertMessageField = value;
            }
        }

        /// <remarks/>
        public string RuleNumber
        {
            get
            {
                return this.ruleNumberField;
            }
            set
            {
                this.ruleNumberField = value;
            }
        }

        /// <remarks/>
        public string Severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
            }
        }

        /// <remarks/>
        public string DataValue
        {
            get
            {
                return this.dataValueField;
            }
            set
            {
                this.dataValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string alertId
        {
            get
            {
                return this.alertIdField;
            }
            set
            {
                this.alertIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.irs.gov/efile")]
    public partial class ValidationErrorListType
    {

        private ValidationErrorListTypeError[] errorField;

        private string errorCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Error")]
        public ValidationErrorListTypeError[] Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string errorCount
        {
            get
            {
                return this.errorCountField;
            }
            set
            {
                this.errorCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    public partial class ValidationErrorListTypeError
    {

        private string documentIDField;

        private string xPathField;

        private string errorCategoryField;

        private string errorMessageField;

        private string ruleNumberField;

        private string severityField;

        private string dataValueField;

        private string errorIdField;

        /// <remarks/>
        public string DocumentID
        {
            get
            {
                return this.documentIDField;
            }
            set
            {
                this.documentIDField = value;
            }
        }

        /// <remarks/>
        public string XPath
        {
            get
            {
                return this.xPathField;
            }
            set
            {
                this.xPathField = value;
            }
        }

        /// <remarks/>
        public string ErrorCategory
        {
            get
            {
                return this.errorCategoryField;
            }
            set
            {
                this.errorCategoryField = value;
            }
        }

        /// <remarks/>
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }

        /// <remarks/>
        public string RuleNumber
        {
            get
            {
                return this.ruleNumberField;
            }
            set
            {
                this.ruleNumberField = value;
            }
        }

        /// <remarks/>
        public string Severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
            }
        }

        /// <remarks/>
        public string DataValue
        {
            get
            {
                return this.dataValueField;
            }
            set
            {
                this.dataValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string errorId
        {
            get
            {
                return this.errorIdField;
            }
            set
            {
                this.errorIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.irs.gov/efile", IsNullable = false)]
    public partial class StateSubmissionManifest
    {

        private string submissionIdField;

        private string eFINField;

        private string taxYearField;

        private GovernmentCodeType governmentCodeField;

        private string stateSubmissionTypeField;

        private SubmissionCategoryType submissionCategoryField;

        private string[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private string iRSSubmissionIdField;

        private string stateSchemaVersionField;

        /// <remarks/>
        public string SubmissionId
        {
            get
            {
                return this.submissionIdField;
            }
            set
            {
                this.submissionIdField = value;
            }
        }

        /// <remarks/>
        public string EFIN
        {
            get
            {
                return this.eFINField;
            }
            set
            {
                this.eFINField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "gYear")]
        public string TaxYear
        {
            get
            {
                return this.taxYearField;
            }
            set
            {
                this.taxYearField = value;
            }
        }

        /// <remarks/>
        public GovernmentCodeType GovernmentCode
        {
            get
            {
                return this.governmentCodeField;
            }
            set
            {
                this.governmentCodeField = value;
            }
        }

        /// <remarks/>
        public string StateSubmissionType
        {
            get
            {
                return this.stateSubmissionTypeField;
            }
            set
            {
                this.stateSubmissionTypeField = value;
            }
        }

        /// <remarks/>
        public SubmissionCategoryType SubmissionCategory
        {
            get
            {
                return this.submissionCategoryField;
            }
            set
            {
                this.submissionCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FederalEIN", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("NameControl", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PrimaryNameControl", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PrimarySSN", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SpouseNameControl", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SpouseSSN", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TempID", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public string IRSSubmissionId
        {
            get
            {
                return this.iRSSubmissionIdField;
            }
            set
            {
                this.iRSSubmissionIdField = value;
            }
        }

        /// <remarks/>
        public string StateSchemaVersion
        {
            get
            {
                return this.stateSchemaVersionField;
            }
            set
            {
                this.stateSchemaVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.irs.gov/efile")]
    public enum SubmissionCategoryType
    {

        /// <remarks/>
        CORP,

        /// <remarks/>
        EO,

        /// <remarks/>
        ETEC,

        /// <remarks/>
        IND,

        /// <remarks/>
        PART,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.irs.gov/efile", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        FederalEIN,

        /// <remarks/>
        NameControl,

        /// <remarks/>
        PrimaryNameControl,

        /// <remarks/>
        PrimarySSN,

        /// <remarks/>
        SpouseNameControl,

        /// <remarks/>
        SpouseSSN,

        /// <remarks/>
        TempID,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.irs.gov/efile", IsNullable = false)]
    public partial class SubmissionReceiptList
    {

        private string countField;

        private SubmissionReceiptListSubmissionReceipt[] submissionReceiptField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubmissionReceipt")]
        public SubmissionReceiptListSubmissionReceipt[] SubmissionReceipt
        {
            get
            {
                return this.submissionReceiptField;
            }
            set
            {
                this.submissionReceiptField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    public partial class SubmissionReceiptListSubmissionReceipt
    {

        private string submissionIdField;

        private System.DateTime timestampField;

        /// <remarks/>
        public string SubmissionId
        {
            get
            {
                return this.submissionIdField;
            }
            set
            {
                this.submissionIdField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.irs.gov/efile", IsNullable = false)]
    public partial class Acknowledgement
    {

        private string submissionIdField;

        private string eFINField;

        private string taxYearField;

        private string governmentCodeField;

        private string submissionTypeField;

        private string submissionCategoryField;

        private System.DateTime electronicPostmarkField;

        private bool electronicPostmarkFieldSpecified;

        private string acceptanceStatusField;

        private bool containedAlertsField;

        private System.DateTime statusDateField;

        private string iRSSubmissionIdField;

        private string stateSubmissionCopyCountField;

        private string itemField;

        private ItemChoiceType itemElementNameField;

        private System.DateTime iRSReceivedDateField;

        private bool iRSReceivedDateFieldSpecified;

        private string filingTypeDescriptionField;

        private System.DateTime taxPeriodEndDateField;

        private bool taxPeriodEndDateFieldSpecified;

        private AcknowledgementPaymentIndicator paymentIndicatorField;

        private bool paymentIndicatorFieldSpecified;

        private bool completedValidationField;

        private bool completedValidationFieldSpecified;

        private string embeddedCRC32Field;

        private string computedCRC32Field;

        private string taxableIncomeField;

        private string totalTaxField;

        private string netIncomeLossField;

        private string reservedIPAddressCdField;

        private string item1Field;

        private Item1ChoiceType item1ElementNameField;

        private string dateOfBirthValidityCdField;

        private string pINPresenceCdField;

        private string iTINMismatchCdField;

        private ValidationErrorListType errorListField;

        private ValidationAlertListType alertListField;

        private string submissionVersionField;

        private string validatingSchemaVersionField;

        /// <remarks/>
        public string SubmissionId
        {
            get
            {
                return this.submissionIdField;
            }
            set
            {
                this.submissionIdField = value;
            }
        }

        /// <remarks/>
        public string EFIN
        {
            get
            {
                return this.eFINField;
            }
            set
            {
                this.eFINField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "gYear")]
        public string TaxYear
        {
            get
            {
                return this.taxYearField;
            }
            set
            {
                this.taxYearField = value;
            }
        }

        /// <remarks/>
        public string GovernmentCode
        {
            get
            {
                return this.governmentCodeField;
            }
            set
            {
                this.governmentCodeField = value;
            }
        }

        /// <remarks/>
        public string SubmissionType
        {
            get
            {
                return this.submissionTypeField;
            }
            set
            {
                this.submissionTypeField = value;
            }
        }

        /// <remarks/>
        public string SubmissionCategory
        {
            get
            {
                return this.submissionCategoryField;
            }
            set
            {
                this.submissionCategoryField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ElectronicPostmark
        {
            get
            {
                return this.electronicPostmarkField;
            }
            set
            {
                this.electronicPostmarkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ElectronicPostmarkSpecified
        {
            get
            {
                return this.electronicPostmarkFieldSpecified;
            }
            set
            {
                this.electronicPostmarkFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string AcceptanceStatus
        {
            get
            {
                return this.acceptanceStatusField;
            }
            set
            {
                this.acceptanceStatusField = value;
            }
        }

        /// <remarks/>
        public bool ContainedAlerts
        {
            get
            {
                return this.containedAlertsField;
            }
            set
            {
                this.containedAlertsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime StatusDate
        {
            get
            {
                return this.statusDateField;
            }
            set
            {
                this.statusDateField = value;
            }
        }

        /// <remarks/>
        public string IRSSubmissionId
        {
            get
            {
                return this.iRSSubmissionIdField;
            }
            set
            {
                this.iRSSubmissionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string StateSubmissionCopyCount
        {
            get
            {
                return this.stateSubmissionCopyCountField;
            }
            set
            {
                this.stateSubmissionCopyCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TIN", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TempID", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IRSReceivedDate
        {
            get
            {
                return this.iRSReceivedDateField;
            }
            set
            {
                this.iRSReceivedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IRSReceivedDateSpecified
        {
            get
            {
                return this.iRSReceivedDateFieldSpecified;
            }
            set
            {
                this.iRSReceivedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string FilingTypeDescription
        {
            get
            {
                return this.filingTypeDescriptionField;
            }
            set
            {
                this.filingTypeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime TaxPeriodEndDate
        {
            get
            {
                return this.taxPeriodEndDateField;
            }
            set
            {
                this.taxPeriodEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxPeriodEndDateSpecified
        {
            get
            {
                return this.taxPeriodEndDateFieldSpecified;
            }
            set
            {
                this.taxPeriodEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AcknowledgementPaymentIndicator PaymentIndicator
        {
            get
            {
                return this.paymentIndicatorField;
            }
            set
            {
                this.paymentIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentIndicatorSpecified
        {
            get
            {
                return this.paymentIndicatorFieldSpecified;
            }
            set
            {
                this.paymentIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool CompletedValidation
        {
            get
            {
                return this.completedValidationField;
            }
            set
            {
                this.completedValidationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CompletedValidationSpecified
        {
            get
            {
                return this.completedValidationFieldSpecified;
            }
            set
            {
                this.completedValidationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string EmbeddedCRC32
        {
            get
            {
                return this.embeddedCRC32Field;
            }
            set
            {
                this.embeddedCRC32Field = value;
            }
        }

        /// <remarks/>
        public string ComputedCRC32
        {
            get
            {
                return this.computedCRC32Field;
            }
            set
            {
                this.computedCRC32Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string TaxableIncome
        {
            get
            {
                return this.taxableIncomeField;
            }
            set
            {
                this.taxableIncomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string TotalTax
        {
            get
            {
                return this.totalTaxField;
            }
            set
            {
                this.totalTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NetIncomeLoss
        {
            get
            {
                return this.netIncomeLossField;
            }
            set
            {
                this.netIncomeLossField = value;
            }
        }

        /// <remarks/>
        public string ReservedIPAddressCd
        {
            get
            {
                return this.reservedIPAddressCdField;
            }
            set
            {
                this.reservedIPAddressCdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BalanceDue", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlElementAttribute("ExpectedRefund", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
        public string Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item1ChoiceType Item1ElementName
        {
            get
            {
                return this.item1ElementNameField;
            }
            set
            {
                this.item1ElementNameField = value;
            }
        }

        /// <remarks/>
        public string DateOfBirthValidityCd
        {
            get
            {
                return this.dateOfBirthValidityCdField;
            }
            set
            {
                this.dateOfBirthValidityCdField = value;
            }
        }

        /// <remarks/>
        public string PINPresenceCd
        {
            get
            {
                return this.pINPresenceCdField;
            }
            set
            {
                this.pINPresenceCdField = value;
            }
        }

        /// <remarks/>
        public string ITINMismatchCd
        {
            get
            {
                return this.iTINMismatchCdField;
            }
            set
            {
                this.iTINMismatchCdField = value;
            }
        }

        /// <remarks/>
        public ValidationErrorListType ErrorList
        {
            get
            {
                return this.errorListField;
            }
            set
            {
                this.errorListField = value;
            }
        }

        /// <remarks/>
        public ValidationAlertListType AlertList
        {
            get
            {
                return this.alertListField;
            }
            set
            {
                this.alertListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string submissionVersion
        {
            get
            {
                return this.submissionVersionField;
            }
            set
            {
                this.submissionVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validatingSchemaVersion
        {
            get
            {
                return this.validatingSchemaVersionField;
            }
            set
            {
                this.validatingSchemaVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.irs.gov/efile", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        TIN,

        /// <remarks/>
        TempID,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    public enum AcknowledgementPaymentIndicator
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Payment Request Received")]
        PaymentRequestReceived,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.irs.gov/efile", IncludeInSchema = false)]
    public enum Item1ChoiceType
    {

        /// <remarks/>
        BalanceDue,

        /// <remarks/>
        ExpectedRefund,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.irs.gov/efile", IsNullable = false)]
    public partial class AcknowledgementList
    {

        private string countField;

        private Acknowledgement[] acknowledgementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Acknowledgement")]
        public Acknowledgement[] Acknowledgement
        {
            get
            {
                return this.acknowledgementField;
            }
            set
            {
                this.acknowledgementField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.irs.gov/efile", IsNullable = false)]
    public partial class StatusRecordList
    {

        private string countField;

        private StatusRecordListStatusRecord[] statusRecordField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StatusRecord")]
        public StatusRecordListStatusRecord[] StatusRecord
        {
            get
            {
                return this.statusRecordField;
            }
            set
            {
                this.statusRecordField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    public partial class StatusRecordListStatusRecord
    {

        private string submissionIdField;

        private string submissionStatusField;

        private System.DateTime statusDateField;

        private string disclaimerField;

        /// <remarks/>
        public string SubmissionId
        {
            get
            {
                return this.submissionIdField;
            }
            set
            {
                this.submissionIdField = value;
            }
        }

        /// <remarks/>
        public string SubmissionStatus
        {
            get
            {
                return this.submissionStatusField;
            }
            set
            {
                this.submissionStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime StatusDate
        {
            get
            {
                return this.statusDateField;
            }
            set
            {
                this.statusDateField = value;
            }
        }

        /// <remarks/>
        public string Disclaimer
        {
            get
            {
                return this.disclaimerField;
            }
            set
            {
                this.disclaimerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.irs.gov/efile", IsNullable = false)]
    public partial class AckNotification
    {

        private string submissionIdField;

        private System.DateTime timestampField;

        /// <remarks/>
        public string SubmissionId
        {
            get
            {
                return this.submissionIdField;
            }
            set
            {
                this.submissionIdField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.irs.gov/efile")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.irs.gov/efile", IsNullable = false)]
    public partial class AckNotificationList
    {

        private string countField;

        private AckNotification[] ackNotificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AckNotification")]
        public AckNotification[] AckNotification
        {
            get
            {
                return this.ackNotificationField;
            }
            set
            {
                this.ackNotificationField = value;
            }
        }
    }

}