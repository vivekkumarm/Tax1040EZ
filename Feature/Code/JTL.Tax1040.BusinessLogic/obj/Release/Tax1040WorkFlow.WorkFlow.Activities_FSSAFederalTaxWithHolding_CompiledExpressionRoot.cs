namespace Tax1040WorkFlow.WorkFlow.Activities {
    
    #line 21 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\FSSAFederalTaxWithHolding.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\FSSAFederalTaxWithHolding.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 22 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\FSSAFederalTaxWithHolding.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\FSSAFederalTaxWithHolding.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\FSSAFederalTaxWithHolding.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\FSSAFederalTaxWithHolding.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 23 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\FSSAFederalTaxWithHolding.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\FSSAFederalTaxWithHolding.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\FSSAFederalTaxWithHolding.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\FSSAFederalTaxWithHolding.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\FSSAFederalTaxWithHolding.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class FSSAFederalTaxWithHolding : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext0 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext1 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext2 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext3 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext4 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext5 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext6 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FSSAFederalTaxWithHolding_TypedDataContext1(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1 refDataContext7 = ((FSSAFederalTaxWithHolding_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<double>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext8 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext9 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext10 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FSSAFederalTaxWithHolding_TypedDataContext1(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1 refDataContext11 = ((FSSAFederalTaxWithHolding_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext11.GetLocation<double>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext12 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext13 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FSSAFederalTaxWithHolding_TypedDataContext1(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1 refDataContext14 = ((FSSAFederalTaxWithHolding_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<double>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext15 = ((FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FSSAFederalTaxWithHolding_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FSSAFederalTaxWithHolding_TypedDataContext1(locations, activityContext, true);
                }
                FSSAFederalTaxWithHolding_TypedDataContext1 refDataContext16 = ((FSSAFederalTaxWithHolding_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext16.GetLocation<double>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
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
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext0 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext1 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext2 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext3 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext4 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext5 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext6 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                FSSAFederalTaxWithHolding_TypedDataContext1 refDataContext7 = new FSSAFederalTaxWithHolding_TypedDataContext1(locations, true);
                return refDataContext7.GetLocation<double>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext8 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext9 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext10 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                FSSAFederalTaxWithHolding_TypedDataContext1 refDataContext11 = new FSSAFederalTaxWithHolding_TypedDataContext1(locations, true);
                return refDataContext11.GetLocation<double>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext12 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext13 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                FSSAFederalTaxWithHolding_TypedDataContext1 refDataContext14 = new FSSAFederalTaxWithHolding_TypedDataContext1(locations, true);
                return refDataContext14.GetLocation<double>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly valDataContext15 = new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                FSSAFederalTaxWithHolding_TypedDataContext1 refDataContext16 = new FSSAFederalTaxWithHolding_TypedDataContext1(locations, true);
                return refDataContext16.GetLocation<double>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object != null) && (Tax1040Object.Income != null) && (Tax1040Object.Inco" +
                            "me.OtherIncome != null))") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.Income.OtherIncome.SSB != null)") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.Primary" +
                            "TaxPayer != null)") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld != null") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld !=null") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.HasValue ? Tax104" +
                            "0Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.Value:0") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalSSBWithHolding") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld != null") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld !=null") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.HasValue ? Tax104" +
                            "0Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.Value:0") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalSSBWithHolding") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.SSB.SpouseFederalTaxWithheld != null") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalSSBWithHolding +(Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWith" +
                            "held.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld." +
                            "Value:0)") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalSSBWithHolding") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(TotalSSBWithHolding,MidpointRounding.AwayFromZero)") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalSSBWithHolding") 
                        && (FSSAFederalTaxWithHolding_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
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
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new FSSAFederalTaxWithHolding_TypedDataContext1(locationReferences).@__Expr16GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FSSAFederalTaxWithHolding_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public FSSAFederalTaxWithHolding_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FSSAFederalTaxWithHolding_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FSSAFederalTaxWithHolding_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class FSSAFederalTaxWithHolding_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public FSSAFederalTaxWithHolding_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FSSAFederalTaxWithHolding_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FSSAFederalTaxWithHolding_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class FSSAFederalTaxWithHolding_TypedDataContext1 : FSSAFederalTaxWithHolding_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalSSBWithHolding;
            
            public FSSAFederalTaxWithHolding_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FSSAFederalTaxWithHolding_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FSSAFederalTaxWithHolding_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 104 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    TotalSSBWithHolding;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr7Get() {
                
                #line 104 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                                    TotalSSBWithHolding;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(double value) {
                
                #line 104 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                
                                    TotalSSBWithHolding = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 137 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      TotalSSBWithHolding;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr11Get() {
                
                #line 137 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                                      TotalSSBWithHolding;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(double value) {
                
                #line 137 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                
                                      TotalSSBWithHolding = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                TotalSSBWithHolding;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr14Get() {
                
                #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                                TotalSSBWithHolding;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(double value) {
                
                #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                
                                TotalSSBWithHolding = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 184 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                TotalSSBWithHolding;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr16Get() {
                
                #line 184 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                TotalSSBWithHolding;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(double value) {
                
                #line 184 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                
                TotalSSBWithHolding = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalSSBWithHolding = ((double)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.TotalSSBWithHolding);
                base.SetValueTypeValues();
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
                if (((locationReferences[(offset + 1)].Name != "TotalSSBWithHolding") 
                            || (locationReferences[(offset + 1)].Type != typeof(double)))) {
                    return false;
                }
                return FSSAFederalTaxWithHolding_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly : FSSAFederalTaxWithHolding_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalSSBWithHolding;
            
            public FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FSSAFederalTaxWithHolding_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Tax1040 Tax1040Object {
                get {
                    return ((JTL.Tax1040.BusinessObject.Tax1040)(this.GetVariableValue((0 + locationsOffset))));
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
                
                #line 61 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          ((Tax1040Object != null) && (Tax1040Object.Income != null) && (Tax1040Object.Income.OtherIncome != null));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr0Get() {
                
                #line 61 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
          ((Tax1040Object != null) && (Tax1040Object.Income != null) && (Tax1040Object.Income.OtherIncome != null));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 69 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                (Tax1040Object.Income.OtherIncome.SSB != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 69 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                (Tax1040Object.Income.OtherIncome.SSB != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 76 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    (Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr2Get() {
                
                #line 76 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                    (Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 83 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                        Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr3Get() {
                
                #line 83 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                        Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 89 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 89 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                          Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 97 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 97 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                                Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 109 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.Value:0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr6Get() {
                
                #line 109 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                                    Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.Value:0;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 122 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 122 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                            Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr9Get() {
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                                  Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.Value:0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr10Get() {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                                      Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.Value:0;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Tax1040Object.Income.OtherIncome.SSB.SpouseFederalTaxWithheld != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                            Tax1040Object.Income.OtherIncome.SSB.SpouseFederalTaxWithheld != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 166 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                TotalSSBWithHolding +(Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.Value:0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr13Get() {
                
                #line 166 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                                TotalSSBWithHolding +(Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxPayerFederalTaxWithheld.Value:0);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 189 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                Math.Round(TotalSSBWithHolding,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr15Get() {
                
                #line 189 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FSSAFEDERALTAXWITHHOLDING.XAML"
                return 
                Math.Round(TotalSSBWithHolding,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalSSBWithHolding = ((double)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
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
                if (((locationReferences[(offset + 1)].Name != "TotalSSBWithHolding") 
                            || (locationReferences[(offset + 1)].Type != typeof(double)))) {
                    return false;
                }
                return FSSAFederalTaxWithHolding_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
