//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation {
    
    
    [System.Runtime.InteropServices.ComVisible(false)]
    public partial class F1040EZAdjustedGrossIncomeWithNoValidation : System.Activities.Activity, System.ComponentModel.ISupportInitialize {
        
        private bool _contentLoaded;
        
        private System.Activities.InArgument<JTL.Tax1040.BusinessObject.Tax1040> _Tax1040Object;
        
        private System.Activities.OutArgument<double> _AnnualGrossIncome;
        
        private System.Activities.OutArgument<double> _TotalW2Wages;
        
        private System.Activities.OutArgument<double> _TaxableScholarshipAmount;
        
        private System.Activities.OutArgument<double> _NonQualifiedPlansAmount;
        
partial void BeforeInitializeComponent(ref bool isInitialized);

partial void AfterInitializeComponent();

        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "4.0.0.0")]
        public F1040EZAdjustedGrossIncomeWithNoValidation() {
            this.InitializeComponent();
        }
        
        public System.Activities.InArgument<JTL.Tax1040.BusinessObject.Tax1040> Tax1040Object {
            get {
                return this._Tax1040Object;
            }
            set {
                this._Tax1040Object = value;
            }
        }
        
        public System.Activities.OutArgument<double> AnnualGrossIncome {
            get {
                return this._AnnualGrossIncome;
            }
            set {
                this._AnnualGrossIncome = value;
            }
        }
        
        public System.Activities.OutArgument<double> TotalW2Wages {
            get {
                return this._TotalW2Wages;
            }
            set {
                this._TotalW2Wages = value;
            }
        }
        
        public System.Activities.OutArgument<double> TaxableScholarshipAmount {
            get {
                return this._TaxableScholarshipAmount;
            }
            set {
                this._TaxableScholarshipAmount = value;
            }
        }
        
        public System.Activities.OutArgument<double> NonQualifiedPlansAmount {
            get {
                return this._NonQualifiedPlansAmount;
            }
            set {
                this._NonQualifiedPlansAmount = value;
            }
        }
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "4.0.0.0")]
        public void InitializeComponent() {
            if ((this._contentLoaded == true)) {
                return;
            }
            this._contentLoaded = true;
            bool isInitialized = false;
            this.BeforeInitializeComponent(ref isInitialized);
            if ((isInitialized == true)) {
                this.AfterInitializeComponent();
                return;
            }
            string resourceName = this.FindResource();
            System.IO.Stream initializeXaml = typeof(F1040EZAdjustedGrossIncomeWithNoValidation).Assembly.GetManifestResourceStream(resourceName);
            System.Xml.XmlReader xmlReader = null;
            System.Xaml.XamlReader reader = null;
            System.Xaml.XamlObjectWriter objectWriter = null;
            try {
                System.Xaml.XamlSchemaContext schemaContext = XamlStaticHelperNamespace._XamlStaticHelper.SchemaContext;
                xmlReader = System.Xml.XmlReader.Create(initializeXaml);
                System.Xaml.XamlXmlReaderSettings readerSettings = new System.Xaml.XamlXmlReaderSettings();
                readerSettings.LocalAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                readerSettings.AllowProtectedMembersOnRoot = true;
                reader = new System.Xaml.XamlXmlReader(xmlReader, schemaContext, readerSettings);
                System.Xaml.XamlObjectWriterSettings writerSettings = new System.Xaml.XamlObjectWriterSettings();
                writerSettings.RootObjectInstance = this;
                writerSettings.AccessLevel = System.Xaml.Permissions.XamlAccessLevel.PrivateAccessTo(typeof(F1040EZAdjustedGrossIncomeWithNoValidation));
                objectWriter = new System.Xaml.XamlObjectWriter(schemaContext, writerSettings);
                System.Xaml.XamlServices.Transform(reader, objectWriter);
            }
            finally {
                if ((xmlReader != null)) {
                    ((System.IDisposable)(xmlReader)).Dispose();
                }
                if ((reader != null)) {
                    ((System.IDisposable)(reader)).Dispose();
                }
                if ((objectWriter != null)) {
                    ((System.IDisposable)(objectWriter)).Dispose();
                }
            }
            this.AfterInitializeComponent();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "4.0.0.0")]
        private string FindResource() {
            string[] resources = typeof(F1040EZAdjustedGrossIncomeWithNoValidation).Assembly.GetManifestResourceNames();
            for (int i = 0; (i < resources.Length); i = (i + 1)) {
                string resource = resources[i];
                if ((resource.Contains(".F1040EZAdjustedGrossIncomeWithNoValidation.g.xaml") || resource.Equals("F1040EZAdjustedGrossIncomeWithNoValidation.g.xaml"))) {
                    return resource;
                }
            }
            throw new System.InvalidOperationException("Resource not found.");
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "4.0.0.0")]
        void System.ComponentModel.ISupportInitialize.BeginInit() {
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "4.0.0.0")]
        void System.ComponentModel.ISupportInitialize.EndInit() {
            this.InitializeComponent();
        }
    }
}