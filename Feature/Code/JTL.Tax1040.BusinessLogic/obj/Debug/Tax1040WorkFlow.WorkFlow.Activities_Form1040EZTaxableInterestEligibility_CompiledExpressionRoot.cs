namespace Tax1040WorkFlow.WorkFlow.Activities {
    
    #line 21 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZTaxableInterestEligibility.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZTaxableInterestEligibility.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 22 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZTaxableInterestEligibility.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZTaxableInterestEligibility.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZTaxableInterestEligibility.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZTaxableInterestEligibility.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 23 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZTaxableInterestEligibility.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZTaxableInterestEligibility.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZTaxableInterestEligibility.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZTaxableInterestEligibility.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZTaxableInterestEligibility.xaml"
    using JTL.Tax1040.Core.Object;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZTaxableInterestEligibility.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Form1040EZTaxableInterestEligibility : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext0 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext1 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext2 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext3 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext4 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZTaxableInterestEligibility_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2 refDataContext5 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext6 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext7 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext8 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext9 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZTaxableInterestEligibility_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2 refDataContext10 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext10.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext11 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext12 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext13 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZTaxableInterestEligibility_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZTaxableInterestEligibility_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZTaxableInterestEligibility_TypedDataContext2 refDataContext14 = ((Form1040EZTaxableInterestEligibility_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext0 = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext1 = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext2 = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext3 = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext4 = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2 refDataContext5 = new Form1040EZTaxableInterestEligibility_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext6 = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext7 = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext8 = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext9 = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2 refDataContext10 = new Form1040EZTaxableInterestEligibility_TypedDataContext2(locations, true);
                return refDataContext10.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext11 = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext12 = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly valDataContext13 = new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                Form1040EZTaxableInterestEligibility_TypedDataContext2 refDataContext14 = new Form1040EZTaxableInterestEligibility_TypedDataContext2(locations, true);
                return refDataContext14.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object != null) && (Tax1040Object.OutputForms != null))") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1 !=null") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome < TaxableIncomeLimit") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.TAXABLE_INCOME]") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest < TaxableInterestLimit") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.INTEREST_INCOME]") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (Form1040EZTaxableInterestEligibility_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Form1040EZTaxableInterestEligibility_TypedDataContext2(locationReferences).@__Expr14GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZTaxableInterestEligibility_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZTaxableInterestEligibility_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZTaxableInterestEligibility_TypedDataContext1 : Form1040EZTaxableInterestEligibility_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Tax1040 Tax1040Object {
                get {
                    return ((JTL.Tax1040.BusinessObject.Tax1040)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected JTL.Tax1040.Core.Object.ErrorMessages ErrorMessages {
                get {
                    return ((JTL.Tax1040.Core.Object.ErrorMessages)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "Tax1040Object") 
                            || (locationReferences[(offset + 0)].Type != typeof(JTL.Tax1040.BusinessObject.Tax1040)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "ErrorMessages") 
                            || (locationReferences[(offset + 1)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessages)))) {
                    return false;
                }
                return Form1040EZTaxableInterestEligibility_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZTaxableInterestEligibility_TypedDataContext1_ForReadOnly : Form1040EZTaxableInterestEligibility_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Tax1040 Tax1040Object {
                get {
                    return ((JTL.Tax1040.BusinessObject.Tax1040)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected JTL.Tax1040.Core.Object.ErrorMessages ErrorMessages {
                get {
                    return ((JTL.Tax1040.Core.Object.ErrorMessages)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "Tax1040Object") 
                            || (locationReferences[(offset + 0)].Type != typeof(JTL.Tax1040.BusinessObject.Tax1040)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "ErrorMessages") 
                            || (locationReferences[(offset + 1)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessages)))) {
                    return false;
                }
                return Form1040EZTaxableInterestEligibility_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZTaxableInterestEligibility_TypedDataContext2 : Form1040EZTaxableInterestEligibility_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TaxableIncomeLimit;
            
            protected double TaxableInterestLimit;
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.Core.Object.ErrorMessage ErrorMessage {
                get {
                    return ((JTL.Tax1040.Core.Object.ErrorMessage)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ErrorMessageList {
                get {
                    return ((System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 91 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                            ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr5Get() {
                
                #line 91 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                            ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 91 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                
                            ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 124 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                            ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr10Get() {
                
                #line 124 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                            ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 124 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                
                            ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 149 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                      Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr14Get() {
                
                #line 149 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                      Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                
                #line 149 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                
                      Tax1040Object.ErrorMessages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TaxableIncomeLimit = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.TaxableInterestLimit = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.TaxableIncomeLimit);
                this.SetVariableValue((5 + locationsOffset), this.TaxableInterestLimit);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 2)].Name != "ErrorMessage") 
                            || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "ErrorMessageList") 
                            || (locationReferences[(offset + 3)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "TaxableIncomeLimit") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "TaxableInterestLimit") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return Form1040EZTaxableInterestEligibility_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly : Form1040EZTaxableInterestEligibility_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TaxableIncomeLimit;
            
            protected double TaxableInterestLimit;
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZTaxableInterestEligibility_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.Core.Object.ErrorMessage ErrorMessage {
                get {
                    return ((JTL.Tax1040.Core.Object.ErrorMessage)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ErrorMessageList {
                get {
                    return ((System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 58 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
          Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr0Get() {
                
                #line 58 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
          Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 68 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
            ((Tax1040Object != null) && (Tax1040Object.OutputForms != null));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 68 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
            ((Tax1040Object != null) && (Tax1040Object.OutputForms != null));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 75 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                Tax1040Object.OutputForms.Tax1040EZPage1 !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr2Get() {
                
                #line 75 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                Tax1040Object.OutputForms.Tax1040EZPage1 !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 83 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome < TaxableIncomeLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr3Get() {
                
                #line 83 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome < TaxableIncomeLimit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 96 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                            ErrorMessages[Constants.TAXABLE_INCOME];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr4Get() {
                
                #line 96 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                            ErrorMessages[Constants.TAXABLE_INCOME];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 107 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                          ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr6Get() {
                
                #line 107 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                          ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 103 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                            ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr7Get() {
                
                #line 103 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                            ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 116 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest < TaxableInterestLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 116 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest < TaxableInterestLimit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 129 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                            ErrorMessages[Constants.INTEREST_INCOME];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr9Get() {
                
                #line 129 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                            ErrorMessages[Constants.INTEREST_INCOME];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 140 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                          ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr11Get() {
                
                #line 140 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                          ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                            ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr12Get() {
                
                #line 136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                            ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                      ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr13Get() {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZTAXABLEINTERESTELIGIBILITY.XAML"
                return 
                      ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TaxableIncomeLimit = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.TaxableInterestLimit = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 2)].Name != "ErrorMessage") 
                            || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "ErrorMessageList") 
                            || (locationReferences[(offset + 3)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "TaxableIncomeLimit") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "TaxableInterestLimit") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return Form1040EZTaxableInterestEligibility_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
