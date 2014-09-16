namespace JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation {
    
    #line 22 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZStandardDeductionWithNoValidation.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZStandardDeductionWithNoValidation.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 23 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZStandardDeductionWithNoValidation.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZStandardDeductionWithNoValidation.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZStandardDeductionWithNoValidation.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZStandardDeductionWithNoValidation.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZStandardDeductionWithNoValidation.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZStandardDeductionWithNoValidation.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZStandardDeductionWithNoValidation.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZStandardDeductionWithNoValidation.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZStandardDeductionWithNoValidation.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class F1040EZStandardDeductionWithNoValidation : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext0 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext1 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext2 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext3 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<JTL.Tax1040.BusinessObject.F1040EZ>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext4 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext5 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext6 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext7 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<JTL.Tax1040.BusinessObject.DeductionsWorkSheet>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext8 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext9 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext10 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext10.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext11 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext12 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext12.GetLocation<JTL.Tax1040.BusinessObject.DeductionsWorkSheet>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext13 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext14 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext15 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext16 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext17 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext17.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext18 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext18.GetLocation<double>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext19 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext19.GetLocation<string>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext20 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext21 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext21.GetLocation<double>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext22 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext23 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext23.GetLocation<double>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext24 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext25 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext25.GetLocation<double>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext26 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext27 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext27.GetLocation<double>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext28 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext29 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext29.GetLocation<double>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext30 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext31 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext31.GetLocation<double>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext32 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext33 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext33.GetLocation<double>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext34 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext35 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext35.GetLocation<double>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext36 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext37 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext37.GetLocation<double>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext38 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext39 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext40 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext41 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext41.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext42 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext42.GetLocation<double>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext43 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext43.GetLocation<string>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext44 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext45 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext45.GetLocation<double>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext46 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext47 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext47.GetLocation<double>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext48 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext49 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext50 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext51 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext51.GetLocation<double>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext52 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext53 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext53.GetLocation<double>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext54 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext55 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext55.GetLocation<double>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext56 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext57 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext57.GetLocation<double>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext58 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext59 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext59.GetLocation<double>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext60 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext61 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext61.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext62 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext62.GetLocation<double>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext63 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext63.GetLocation<string>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext64 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext65 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext65.GetLocation<double>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext66 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext67 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext67.GetLocation<double>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext68 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext69 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext69.GetLocation<double>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext70 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext71 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext71.GetLocation<double>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext72 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext73 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext73.GetLocation<double>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext74 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext75 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext75.GetLocation<double>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext76 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext77 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext77.GetLocation<double>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext78 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext79 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext79.GetLocation<double>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext80 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext81 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext81.GetLocation<double>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext82 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext83 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext84 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext84.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext85 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext85.GetLocation<double>(refDataContext85.ValueType___Expr85Get, refDataContext85.ValueType___Expr85Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext86 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext86.GetLocation<string>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext87 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext88 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext88.GetLocation<double>(refDataContext88.ValueType___Expr88Get, refDataContext88.ValueType___Expr88Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext89 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext90 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext90.GetLocation<double>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext91 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext92 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext92.GetLocation<double>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext93 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext94 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext94.GetLocation<double>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext95 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext96 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext96.GetLocation<double>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext97 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext98 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext98.GetLocation<double>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext99 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext100 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext100.GetLocation<double>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext101 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext102 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext102.GetLocation<double>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext103 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext104 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext104.GetLocation<double>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext105 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext106 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext107 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext107.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext107.ValueType___Expr107Get, refDataContext107.ValueType___Expr107Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext108 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext108.GetLocation<double>(refDataContext108.ValueType___Expr108Get, refDataContext108.ValueType___Expr108Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext109 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext109.GetLocation<string>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext110 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext111 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext111.GetLocation<double>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext112 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext113 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext113.GetLocation<double>(refDataContext113.ValueType___Expr113Get, refDataContext113.ValueType___Expr113Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext114 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext114.ValueType___Expr114Get();
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext115 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext115.GetLocation<double>(refDataContext115.ValueType___Expr115Get, refDataContext115.ValueType___Expr115Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 116)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext116 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext116.ValueType___Expr116Get();
            }
            if ((expressionId == 117)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext117 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext117.GetLocation<double>(refDataContext117.ValueType___Expr117Get, refDataContext117.ValueType___Expr117Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 118)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext118 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext119 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext119.GetLocation<double>(refDataContext119.ValueType___Expr119Get, refDataContext119.ValueType___Expr119Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 120)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext120 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext121 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext121.GetLocation<double>(refDataContext121.ValueType___Expr121Get, refDataContext121.ValueType___Expr121Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 122)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext122 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext122.ValueType___Expr122Get();
            }
            if ((expressionId == 123)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext123 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext123.GetLocation<double>(refDataContext123.ValueType___Expr123Get, refDataContext123.ValueType___Expr123Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 124)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext124 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext124.ValueType___Expr124Get();
            }
            if ((expressionId == 125)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext125 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext125.GetLocation<double>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 126)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext126 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZStandardDeductionWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext127 = ((F1040EZStandardDeductionWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext127.GetLocation<double>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set, expressionId, this.rootActivity, activityContext);
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
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext0 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext1 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext2 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext3 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext3.GetLocation<JTL.Tax1040.BusinessObject.F1040EZ>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext4 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext5 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext6 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext7 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<JTL.Tax1040.BusinessObject.DeductionsWorkSheet>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext8 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext9 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext10 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext10.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext11 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext12 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<JTL.Tax1040.BusinessObject.DeductionsWorkSheet>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext13 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext14 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext15 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext16 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext17 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext17.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext18 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext18.GetLocation<double>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext19 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext19.GetLocation<string>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext20 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext21 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext21.GetLocation<double>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext22 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext23 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext23.GetLocation<double>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext24 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext25 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext25.GetLocation<double>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext26 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext27 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext27.GetLocation<double>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext28 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext29 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext29.GetLocation<double>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext30 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext31 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext31.GetLocation<double>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext32 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext33 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext33.GetLocation<double>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext34 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext35 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext35.GetLocation<double>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext36 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext37 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext37.GetLocation<double>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set);
            }
            if ((expressionId == 38)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext38 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext39 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext40 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext41 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext41.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set);
            }
            if ((expressionId == 42)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext42 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext42.GetLocation<double>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext43 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext43.GetLocation<string>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext44 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext45 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext45.GetLocation<double>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext46 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext47 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext47.GetLocation<double>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
            }
            if ((expressionId == 48)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext48 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext49 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set);
            }
            if ((expressionId == 50)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext50 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext51 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext51.GetLocation<double>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext52 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext53 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext53.GetLocation<double>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set);
            }
            if ((expressionId == 54)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext54 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext55 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext55.GetLocation<double>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set);
            }
            if ((expressionId == 56)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext56 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext57 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext57.GetLocation<double>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set);
            }
            if ((expressionId == 58)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext58 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext59 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext59.GetLocation<double>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext60 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext61 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext61.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext62 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext62.GetLocation<double>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set);
            }
            if ((expressionId == 63)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext63 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext63.GetLocation<string>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set);
            }
            if ((expressionId == 64)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext64 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext65 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext65.GetLocation<double>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set);
            }
            if ((expressionId == 66)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext66 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext67 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext67.GetLocation<double>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set);
            }
            if ((expressionId == 68)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext68 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext69 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext69.GetLocation<double>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set);
            }
            if ((expressionId == 70)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext70 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext71 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext71.GetLocation<double>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set);
            }
            if ((expressionId == 72)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext72 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext73 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext73.GetLocation<double>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set);
            }
            if ((expressionId == 74)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext74 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext75 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext75.GetLocation<double>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set);
            }
            if ((expressionId == 76)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext76 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext77 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext77.GetLocation<double>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set);
            }
            if ((expressionId == 78)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext78 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext79 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext79.GetLocation<double>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set);
            }
            if ((expressionId == 80)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext80 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext81 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext81.GetLocation<double>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set);
            }
            if ((expressionId == 82)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext82 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext83 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext84 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext84.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set);
            }
            if ((expressionId == 85)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext85 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext85.GetLocation<double>(refDataContext85.ValueType___Expr85Get, refDataContext85.ValueType___Expr85Set);
            }
            if ((expressionId == 86)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext86 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext86.GetLocation<string>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set);
            }
            if ((expressionId == 87)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext87 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext88 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext88.GetLocation<double>(refDataContext88.ValueType___Expr88Get, refDataContext88.ValueType___Expr88Set);
            }
            if ((expressionId == 89)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext89 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext90 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext90.GetLocation<double>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set);
            }
            if ((expressionId == 91)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext91 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext92 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext92.GetLocation<double>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set);
            }
            if ((expressionId == 93)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext93 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext94 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext94.GetLocation<double>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set);
            }
            if ((expressionId == 95)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext95 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext96 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext96.GetLocation<double>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set);
            }
            if ((expressionId == 97)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext97 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext98 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext98.GetLocation<double>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set);
            }
            if ((expressionId == 99)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext99 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext100 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext100.GetLocation<double>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set);
            }
            if ((expressionId == 101)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext101 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext102 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext102.GetLocation<double>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set);
            }
            if ((expressionId == 103)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext103 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext104 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext104.GetLocation<double>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set);
            }
            if ((expressionId == 105)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext105 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext106 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext107 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext107.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext107.ValueType___Expr107Get, refDataContext107.ValueType___Expr107Set);
            }
            if ((expressionId == 108)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext108 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext108.GetLocation<double>(refDataContext108.ValueType___Expr108Get, refDataContext108.ValueType___Expr108Set);
            }
            if ((expressionId == 109)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext109 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext109.GetLocation<string>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set);
            }
            if ((expressionId == 110)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext110 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext111 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext111.GetLocation<double>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set);
            }
            if ((expressionId == 112)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext112 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext113 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext113.GetLocation<double>(refDataContext113.ValueType___Expr113Get, refDataContext113.ValueType___Expr113Set);
            }
            if ((expressionId == 114)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext114 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext114.ValueType___Expr114Get();
            }
            if ((expressionId == 115)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext115 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext115.GetLocation<double>(refDataContext115.ValueType___Expr115Get, refDataContext115.ValueType___Expr115Set);
            }
            if ((expressionId == 116)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext116 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext116.ValueType___Expr116Get();
            }
            if ((expressionId == 117)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext117 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext117.GetLocation<double>(refDataContext117.ValueType___Expr117Get, refDataContext117.ValueType___Expr117Set);
            }
            if ((expressionId == 118)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext118 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext119 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext119.GetLocation<double>(refDataContext119.ValueType___Expr119Get, refDataContext119.ValueType___Expr119Set);
            }
            if ((expressionId == 120)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext120 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext121 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext121.GetLocation<double>(refDataContext121.ValueType___Expr121Get, refDataContext121.ValueType___Expr121Set);
            }
            if ((expressionId == 122)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext122 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext122.ValueType___Expr122Get();
            }
            if ((expressionId == 123)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext123 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext123.GetLocation<double>(refDataContext123.ValueType___Expr123Get, refDataContext123.ValueType___Expr123Set);
            }
            if ((expressionId == 124)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext124 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext124.ValueType___Expr124Get();
            }
            if ((expressionId == 125)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext125 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext125.GetLocation<double>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set);
            }
            if ((expressionId == 126)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly valDataContext126 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                F1040EZStandardDeductionWithNoValidation_TypedDataContext2 refDataContext127 = new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext127.GetLocation<double>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object != null) && (Tax1040Object.PersonalDetails != null))") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ==null)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new F1040EZ()") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new F1040EZWorkSheets()") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new DeductionsWorkSheet()") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ.F1040EZWorkSheets==null)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new F1040EZWorkSheets()") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new DeductionsWorkSheet()") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person !=null") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasVal" +
                            "ue ?Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.V" +
                            "alue:false") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWages") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "WagesPrefix") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalWages + DeductionWorksheetLine1DefaultAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorksheetMinimunStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount," +
                            " Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorkSheetSingleStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount," +
                            " Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorkSheetDefaultExemption") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040" +
                            "Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmoun" +
                            "t,MidpointRounding.AwayFromZero)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWorksheetStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(DeductionWorksheetSingleDefaultStandardDeduction,MidpointRounding.Away" +
                            "FromZero)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWorksheetStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person !=null) || (Tax1040Object." +
                            "PersonalDetails.Spouse !=null))") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object" +
                            ".PersonalDetails.Spouse != null))") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value : false) && (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value : false))") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWages") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "WagesPrefix") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalWages + DeductionWorksheetLine1DefaultAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorksheetMinimunStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount," +
                            " Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorkSheetMFJStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount," +
                            " Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorkSheetDefaultExemption") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040" +
                            "Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmoun" +
                            "t,MidpointRounding.AwayFromZero)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWorksheetStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value : false) || (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value : false))") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWages") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "WagesPrefix") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalWages + DeductionWorksheetLine1DefaultAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorksheetMinimunStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount," +
                            " Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorkSheetMFJStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount," +
                            " Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorkSheetMFJExemption") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040" +
                            "Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmoun" +
                            "t,MidpointRounding.AwayFromZero)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWorksheetStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(DeductionWorksheetMFJDefaultStandardDeduction,MidpointRounding.AwayFro" +
                            "mZero)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWorksheetStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasVa" +
                            "lue ? Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent" +
                            ".Value : false)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWages") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "WagesPrefix") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalWages + DeductionWorksheetLine1DefaultAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorksheetMinimunStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount," +
                            " Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorkSheetMFJStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount," +
                            " Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorkSheetMFJExemption") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040" +
                            "Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmoun" +
                            "t,MidpointRounding.AwayFromZero)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWorksheetStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(DeductionWorksheetMFJDefaultStandardDeduction,MidpointRounding.AwayFro" +
                            "mZero)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWorksheetStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.PersonalDetails.Spouse.Person != null)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue ? Tax" +
                            "1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value : false)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWages") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "WagesPrefix") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalWages + DeductionWorksheetLine1DefaultAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorksheetMinimunStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount," +
                            " Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorkSheetMFJStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 116;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 117;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount," +
                            " Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 118;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 119;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DeductionWorkSheetMFJExemption") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 120;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 121;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040" +
                            "Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 122;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 123;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmoun" +
                            "t,MidpointRounding.AwayFromZero)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 124;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWorksheetStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 125;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(DeductionWorksheetMFJDefaultStandardDeduction,MidpointRounding.AwayFro" +
                            "mZero)") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 126;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWorksheetStandardDeduction") 
                        && (F1040EZStandardDeductionWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 127;
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
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr109GetTree();
            }
            if ((expressionId == 110)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr110GetTree();
            }
            if ((expressionId == 111)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr111GetTree();
            }
            if ((expressionId == 112)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr112GetTree();
            }
            if ((expressionId == 113)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr113GetTree();
            }
            if ((expressionId == 114)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr114GetTree();
            }
            if ((expressionId == 115)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr115GetTree();
            }
            if ((expressionId == 116)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr116GetTree();
            }
            if ((expressionId == 117)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr117GetTree();
            }
            if ((expressionId == 118)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr118GetTree();
            }
            if ((expressionId == 119)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr119GetTree();
            }
            if ((expressionId == 120)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr120GetTree();
            }
            if ((expressionId == 121)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr121GetTree();
            }
            if ((expressionId == 122)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr122GetTree();
            }
            if ((expressionId == 123)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr123GetTree();
            }
            if ((expressionId == 124)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr124GetTree();
            }
            if ((expressionId == 125)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr125GetTree();
            }
            if ((expressionId == 126)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr126GetTree();
            }
            if ((expressionId == 127)) {
                return new F1040EZStandardDeductionWithNoValidation_TypedDataContext2(locationReferences).@__Expr127GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZStandardDeductionWithNoValidation_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZStandardDeductionWithNoValidation_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZStandardDeductionWithNoValidation_TypedDataContext1 : F1040EZStandardDeductionWithNoValidation_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWorksheetStandardDeduction;
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            protected override void GetValueTypeValues() {
                this.TotalWorksheetStandardDeduction = ((double)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.TotalWorksheetStandardDeduction);
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
                if (((locationReferences[(offset + 1)].Name != "TotalWorksheetStandardDeduction") 
                            || (locationReferences[(offset + 1)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZStandardDeductionWithNoValidation_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZStandardDeductionWithNoValidation_TypedDataContext1_ForReadOnly : F1040EZStandardDeductionWithNoValidation_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWorksheetStandardDeduction;
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            protected override void GetValueTypeValues() {
                this.TotalWorksheetStandardDeduction = ((double)(this.GetVariableValue((1 + locationsOffset))));
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
                if (((locationReferences[(offset + 1)].Name != "TotalWorksheetStandardDeduction") 
                            || (locationReferences[(offset + 1)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZStandardDeductionWithNoValidation_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZStandardDeductionWithNoValidation_TypedDataContext2 : F1040EZStandardDeductionWithNoValidation_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double DeductionWorkSheetSingleStandardDeduction;
            
            protected double DeductionWorkSheetMFJStandardDeduction;
            
            protected double DeductionWorkSheetMFJExemption;
            
            protected double DeductionWorkSheetDefaultExemption;
            
            protected double DeductionWorksheetSingleDefaultStandardDeduction;
            
            protected double DeductionWorksheetMFJDefaultStandardDeduction;
            
            protected double DeductionWorksheetMinimunStandardDeduction;
            
            protected double DeductionWorksheetLine1DefaultAmount;
            
            protected double TotalWages;
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string WagesPrefix {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((11 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 91 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZ>> expression = () => 
                        Tax1040Object.F1040EZ;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZ @__Expr3Get() {
                
                #line 91 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.F1040EZ;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZ ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(JTL.Tax1040.BusinessObject.F1040EZ value) {
                
                #line 91 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                        Tax1040Object.F1040EZ = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(JTL.Tax1040.BusinessObject.F1040EZ value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 103 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                        Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr5Get() {
                
                #line 103 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                
                #line 103 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                        Tax1040Object.F1040EZ.F1040EZWorkSheets = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 115 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.DeductionsWorkSheet>> expression = () => 
                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.DeductionsWorkSheet @__Expr7Get() {
                
                #line 115 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.DeductionsWorkSheet ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(JTL.Tax1040.BusinessObject.DeductionsWorkSheet value) {
                
                #line 115 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(JTL.Tax1040.BusinessObject.DeductionsWorkSheet value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 138 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                            Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr10Get() {
                
                #line 138 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                
                #line 138 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                            Tax1040Object.F1040EZ.F1040EZWorkSheets = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 156 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.DeductionsWorkSheet>> expression = () => 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.DeductionsWorkSheet @__Expr12Get() {
                
                #line 156 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.DeductionsWorkSheet ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(JTL.Tax1040.BusinessObject.DeductionsWorkSheet value) {
                
                #line 156 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(JTL.Tax1040.BusinessObject.DeductionsWorkSheet value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 205 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                    Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr17Get() {
                
                #line 205 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                    Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 205 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                    Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 210 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr18Get() {
                
                #line 210 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                    TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(double value) {
                
                #line 210 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                    TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 200 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 200 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                    WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(string value) {
                
                #line 200 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                    WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 217 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr21Get() {
                
                #line 217 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(double value) {
                
                #line 217 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 230 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr23Get() {
                
                #line 230 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(double value) {
                
                #line 230 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 242 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr25Get() {
                
                #line 242 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(double value) {
                
                #line 242 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 254 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr27Get() {
                
                #line 254 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(double value) {
                
                #line 254 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 266 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr29Get() {
                
                #line 266 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(double value) {
                
                #line 266 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr31Get() {
                
                #line 278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(double value) {
                
                #line 278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 290 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr33Get() {
                
                #line 290 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(double value) {
                
                #line 290 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 302 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr35Get() {
                
                #line 302 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(double value) {
                
                #line 302 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                  TotalWorksheetStandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 317 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr37Get() {
                
                #line 317 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr37Set(double value) {
                
                #line 317 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                TotalWorksheetStandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr37Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr37Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 364 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr41Get() {
                
                #line 364 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr41Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 364 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr41Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr41Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 369 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr42Get() {
                
                #line 369 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(double value) {
                
                #line 369 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                          TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 359 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr43Get() {
                
                #line 359 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(string value) {
                
                #line 359 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                          WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 376 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr45Get() {
                
                #line 376 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(double value) {
                
                #line 376 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 389 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr47Get() {
                
                #line 389 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr47Set(double value) {
                
                #line 389 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr47Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr47Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 401 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr49Get() {
                
                #line 401 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr49Set(double value) {
                
                #line 401 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr49Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr49Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr51Get() {
                
                #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(double value) {
                
                #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 425 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr53Get() {
                
                #line 425 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr53Set(double value) {
                
                #line 425 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr53Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr53Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 437 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr55Get() {
                
                #line 437 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr55Set(double value) {
                
                #line 437 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr55Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr55Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 449 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr57Get() {
                
                #line 449 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr57Set(double value) {
                
                #line 449 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr57Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr57Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 461 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr59Get() {
                
                #line 461 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(double value) {
                
                #line 461 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                        TotalWorksheetStandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 490 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                              Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr61Get() {
                
                #line 490 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 490 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                              Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 495 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr62Get() {
                
                #line 495 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr62Set(double value) {
                
                #line 495 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                              TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr62Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr62Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 485 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr63Get() {
                
                #line 485 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr63Set(string value) {
                
                #line 485 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                              WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr63Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr63Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 502 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr65Get() {
                
                #line 502 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr65Set(double value) {
                
                #line 502 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr65Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr65Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 515 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr67Get() {
                
                #line 515 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr67Set(double value) {
                
                #line 515 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr67Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr67Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 527 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr69Get() {
                
                #line 527 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr69Set(double value) {
                
                #line 527 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr69Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr69Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 539 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr71Get() {
                
                #line 539 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr71Set(double value) {
                
                #line 539 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr71Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr71Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 551 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr73Get() {
                
                #line 551 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr73Set(double value) {
                
                #line 551 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr73Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr73Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 563 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr75Get() {
                
                #line 563 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr75Set(double value) {
                
                #line 563 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr75Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr75Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 575 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr77Get() {
                
                #line 575 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr77Set(double value) {
                
                #line 575 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr77Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr77Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 587 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr79Get() {
                
                #line 587 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr79Set(double value) {
                
                #line 587 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                            TotalWorksheetStandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr79Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr79Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 602 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr81Get() {
                
                #line 602 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr81Set(double value) {
                
                #line 602 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                          TotalWorksheetStandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr81Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr81Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                            Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr84Get() {
                
                #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr84Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                            Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr84Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr84Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 647 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr85Get() {
                
                #line 647 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr85Set(double value) {
                
                #line 647 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                            TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr85Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr85Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 637 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr86Get() {
                
                #line 637 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr86Set(string value) {
                
                #line 637 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                            WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr86Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr86Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 654 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr88Get() {
                
                #line 654 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr88Set(double value) {
                
                #line 654 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr88Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr88Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 667 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr90Get() {
                
                #line 667 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr90Set(double value) {
                
                #line 667 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr90Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr90Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 679 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr92Get() {
                
                #line 679 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr92Set(double value) {
                
                #line 679 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr92Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr92Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr94GetTree() {
                
                #line 691 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr94Get() {
                
                #line 691 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr94Set(double value) {
                
                #line 691 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr94Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr94Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 703 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr96Get() {
                
                #line 703 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr96Set(double value) {
                
                #line 703 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr96Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr96Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 715 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr98Get() {
                
                #line 715 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr98Set(double value) {
                
                #line 715 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr98Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr98Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 727 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr100Get() {
                
                #line 727 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr100Set(double value) {
                
                #line 727 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr100Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr100Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 739 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr102Get() {
                
                #line 739 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr102Set(double value) {
                
                #line 739 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                          TotalWorksheetStandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr102Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr102Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 754 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr104Get() {
                
                #line 754 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr104Set(double value) {
                
                #line 754 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                        TotalWorksheetStandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr104Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr104Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 791 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                                Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr107Get() {
                
                #line 791 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                                Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr107Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 791 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                                Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr107Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr107Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 796 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr108Get() {
                
                #line 796 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                                TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr108Set(double value) {
                
                #line 796 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                                TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr108Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr108Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 786 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr109Get() {
                
                #line 786 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                                WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr109Set(string value) {
                
                #line 786 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                                WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr109Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr109Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr111GetTree() {
                
                #line 803 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr111Get() {
                
                #line 803 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                                Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr111Get() {
                this.GetValueTypeValues();
                return this.@__Expr111Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr111Set(double value) {
                
                #line 803 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                                Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr111Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr111Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 816 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr113Get() {
                
                #line 816 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr113Get() {
                this.GetValueTypeValues();
                return this.@__Expr113Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr113Set(double value) {
                
                #line 816 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr113Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr113Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 828 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr115Get() {
                
                #line 828 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr115Set(double value) {
                
                #line 828 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr115Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr115Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr117GetTree() {
                
                #line 840 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr117Get() {
                
                #line 840 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr117Get() {
                this.GetValueTypeValues();
                return this.@__Expr117Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr117Set(double value) {
                
                #line 840 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr117Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr117Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr119GetTree() {
                
                #line 852 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr119Get() {
                
                #line 852 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr119Get() {
                this.GetValueTypeValues();
                return this.@__Expr119Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr119Set(double value) {
                
                #line 852 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr119Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr119Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr121GetTree() {
                
                #line 864 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr121Get() {
                
                #line 864 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr121Get() {
                this.GetValueTypeValues();
                return this.@__Expr121Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr121Set(double value) {
                
                #line 864 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr121Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr121Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr123GetTree() {
                
                #line 876 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr123Get() {
                
                #line 876 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr123Get() {
                this.GetValueTypeValues();
                return this.@__Expr123Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr123Set(double value) {
                
                #line 876 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr123Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr123Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr125GetTree() {
                
                #line 888 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr125Get() {
                
                #line 888 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr125Get() {
                this.GetValueTypeValues();
                return this.@__Expr125Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr125Set(double value) {
                
                #line 888 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                              TotalWorksheetStandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr125Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr125Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr127GetTree() {
                
                #line 903 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr127Get() {
                
                #line 903 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            TotalWorksheetStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr127Get() {
                this.GetValueTypeValues();
                return this.@__Expr127Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr127Set(double value) {
                
                #line 903 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                
                                            TotalWorksheetStandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr127Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr127Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.DeductionWorkSheetSingleStandardDeduction = ((double)(this.GetVariableValue((2 + locationsOffset))));
                this.DeductionWorkSheetMFJStandardDeduction = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.DeductionWorkSheetMFJExemption = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.DeductionWorkSheetDefaultExemption = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.DeductionWorksheetSingleDefaultStandardDeduction = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.DeductionWorksheetMFJDefaultStandardDeduction = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.DeductionWorksheetMinimunStandardDeduction = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.DeductionWorksheetLine1DefaultAmount = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.TotalWages = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((2 + locationsOffset), this.DeductionWorkSheetSingleStandardDeduction);
                this.SetVariableValue((3 + locationsOffset), this.DeductionWorkSheetMFJStandardDeduction);
                this.SetVariableValue((4 + locationsOffset), this.DeductionWorkSheetMFJExemption);
                this.SetVariableValue((5 + locationsOffset), this.DeductionWorkSheetDefaultExemption);
                this.SetVariableValue((6 + locationsOffset), this.DeductionWorksheetSingleDefaultStandardDeduction);
                this.SetVariableValue((7 + locationsOffset), this.DeductionWorksheetMFJDefaultStandardDeduction);
                this.SetVariableValue((8 + locationsOffset), this.DeductionWorksheetMinimunStandardDeduction);
                this.SetVariableValue((9 + locationsOffset), this.DeductionWorksheetLine1DefaultAmount);
                this.SetVariableValue((10 + locationsOffset), this.TotalWages);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "WagesPrefix") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "DeductionWorkSheetSingleStandardDeduction") 
                            || (locationReferences[(offset + 2)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "DeductionWorkSheetMFJStandardDeduction") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "DeductionWorkSheetMFJExemption") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "DeductionWorkSheetDefaultExemption") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "DeductionWorksheetSingleDefaultStandardDeduction") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "DeductionWorksheetMFJDefaultStandardDeduction") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "DeductionWorksheetMinimunStandardDeduction") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "DeductionWorksheetLine1DefaultAmount") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TotalWages") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZStandardDeductionWithNoValidation_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly : F1040EZStandardDeductionWithNoValidation_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double DeductionWorkSheetSingleStandardDeduction;
            
            protected double DeductionWorkSheetMFJStandardDeduction;
            
            protected double DeductionWorkSheetMFJExemption;
            
            protected double DeductionWorkSheetDefaultExemption;
            
            protected double DeductionWorksheetSingleDefaultStandardDeduction;
            
            protected double DeductionWorksheetMFJDefaultStandardDeduction;
            
            protected double DeductionWorksheetMinimunStandardDeduction;
            
            protected double DeductionWorksheetLine1DefaultAmount;
            
            protected double TotalWages;
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZStandardDeductionWithNoValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string WagesPrefix {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
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
                
                #line 74 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          ((Tax1040Object != null) && (Tax1040Object.PersonalDetails != null));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr0Get() {
                
                #line 74 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
          ((Tax1040Object != null) && (Tax1040Object.PersonalDetails != null));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 83 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  (Tax1040Object.F1040EZ==null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 83 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                  (Tax1040Object.F1040EZ==null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 96 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZ>> expression = () => 
                        new F1040EZ();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZ @__Expr2Get() {
                
                #line 96 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                        new F1040EZ();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZ ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 108 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                        new F1040EZWorkSheets();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr4Get() {
                
                #line 108 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                        new F1040EZWorkSheets();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 120 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.DeductionsWorkSheet>> expression = () => 
                        new DeductionsWorkSheet();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.DeductionsWorkSheet @__Expr6Get() {
                
                #line 120 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                        new DeductionsWorkSheet();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.DeductionsWorkSheet ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      (Tax1040Object.F1040EZ.F1040EZWorkSheets==null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                      (Tax1040Object.F1040EZ.F1040EZWorkSheets==null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 143 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                            new F1040EZWorkSheets();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr9Get() {
                
                #line 143 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                            new F1040EZWorkSheets();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.DeductionsWorkSheet>> expression = () => 
                    new DeductionsWorkSheet();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.DeductionsWorkSheet @__Expr11Get() {
                
                #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                    new DeductionsWorkSheet();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.DeductionsWorkSheet ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 170 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 170 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 177 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                    Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr14Get() {
                
                #line 177 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                    Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 184 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr15Get() {
                
                #line 184 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 191 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue ?Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value:false;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr16Get() {
                
                #line 191 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue ?Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value:false;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 222 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    TotalWages + DeductionWorksheetLine1DefaultAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr20Get() {
                
                #line 222 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                    TotalWages + DeductionWorksheetLine1DefaultAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  DeductionWorksheetMinimunStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr22Get() {
                
                #line 235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  DeductionWorksheetMinimunStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 247 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr24Get() {
                
                #line 247 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 259 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  DeductionWorkSheetSingleStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr26Get() {
                
                #line 259 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  DeductionWorkSheetSingleStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 271 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr28Get() {
                
                #line 271 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 283 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  DeductionWorkSheetDefaultExemption;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr30Get() {
                
                #line 283 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  DeductionWorkSheetDefaultExemption;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 295 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr32Get() {
                
                #line 295 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 307 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr34Get() {
                
                #line 307 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 322 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Math.Round(DeductionWorksheetSingleDefaultStandardDeduction,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr36Get() {
                
                #line 322 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                Math.Round(DeductionWorksheetSingleDefaultStandardDeduction,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 335 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person !=null) || (Tax1040Object.PersonalDetails.Spouse !=null));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr38Get() {
                
                #line 335 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                        ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person !=null) || (Tax1040Object.PersonalDetails.Spouse !=null));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 342 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.Spouse != null));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr39Get() {
                
                #line 342 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                            ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.Spouse != null));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 350 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value : false) && (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value : false));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr40Get() {
                
                #line 350 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                  ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value : false) && (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value : false));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 381 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          TotalWages + DeductionWorksheetLine1DefaultAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr44Get() {
                
                #line 381 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          TotalWages + DeductionWorksheetLine1DefaultAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 394 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        DeductionWorksheetMinimunStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr46Get() {
                
                #line 394 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        DeductionWorksheetMinimunStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 406 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr48Get() {
                
                #line 406 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 418 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        DeductionWorkSheetMFJStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr50Get() {
                
                #line 418 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        DeductionWorkSheetMFJStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 430 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr52Get() {
                
                #line 430 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 442 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        DeductionWorkSheetDefaultExemption;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr54Get() {
                
                #line 442 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        DeductionWorkSheetDefaultExemption;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 454 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr56Get() {
                
                #line 454 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 466 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr58Get() {
                
                #line 466 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 476 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value : false) || (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value : false));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr60Get() {
                
                #line 476 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                      ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value : false) || (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value : false));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 507 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              TotalWages + DeductionWorksheetLine1DefaultAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr64Get() {
                
                #line 507 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              TotalWages + DeductionWorksheetLine1DefaultAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 520 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            DeductionWorksheetMinimunStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr66Get() {
                
                #line 520 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            DeductionWorksheetMinimunStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 532 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr68Get() {
                
                #line 532 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 544 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            DeductionWorkSheetMFJStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr70Get() {
                
                #line 544 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            DeductionWorkSheetMFJStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 556 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr72Get() {
                
                #line 556 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 568 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            DeductionWorkSheetMFJExemption;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr74Get() {
                
                #line 568 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            DeductionWorkSheetMFJExemption;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 580 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr76Get() {
                
                #line 580 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 592 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr78Get() {
                
                #line 592 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 607 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Math.Round(DeductionWorksheetMFJDefaultStandardDeduction,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr80Get() {
                
                #line 607 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Math.Round(DeductionWorksheetMFJDefaultStandardDeduction,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 621 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr82Get() {
                
                #line 621 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 628 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value : false);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr83Get() {
                
                #line 628 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                    (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value : false);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 659 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            TotalWages + DeductionWorksheetLine1DefaultAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr87Get() {
                
                #line 659 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            TotalWages + DeductionWorksheetLine1DefaultAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 672 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          DeductionWorksheetMinimunStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr89Get() {
                
                #line 672 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          DeductionWorksheetMinimunStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 684 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr91Get() {
                
                #line 684 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 696 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          DeductionWorkSheetMFJStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr93Get() {
                
                #line 696 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          DeductionWorkSheetMFJStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 708 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr95Get() {
                
                #line 708 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 720 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          DeductionWorkSheetMFJExemption;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr97Get() {
                
                #line 720 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          DeductionWorkSheetMFJExemption;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 732 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr99Get() {
                
                #line 732 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 744 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr101Get() {
                
                #line 744 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                          Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 759 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Math.Round(DeductionWorksheetMFJDefaultStandardDeduction,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr103Get() {
                
                #line 759 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        Math.Round(DeductionWorksheetMFJDefaultStandardDeduction,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 770 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    (Tax1040Object.PersonalDetails.Spouse.Person != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr105Get() {
                
                #line 770 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                    (Tax1040Object.PersonalDetails.Spouse.Person != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 777 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value : false);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr106Get() {
                
                #line 777 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                        (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue ? Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value : false);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr106Get() {
                this.GetValueTypeValues();
                return this.@__Expr106Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr110GetTree() {
                
                #line 808 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                TotalWages + DeductionWorksheetLine1DefaultAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr110Get() {
                
                #line 808 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                                TotalWages + DeductionWorksheetLine1DefaultAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr110Get() {
                this.GetValueTypeValues();
                return this.@__Expr110Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr112GetTree() {
                
                #line 821 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              DeductionWorksheetMinimunStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr112Get() {
                
                #line 821 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              DeductionWorksheetMinimunStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr112Get() {
                this.GetValueTypeValues();
                return this.@__Expr112Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr114GetTree() {
                
                #line 833 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr114Get() {
                
                #line 833 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              Math.Max(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineAAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineBAmount);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr114Get() {
                this.GetValueTypeValues();
                return this.@__Expr114Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr116GetTree() {
                
                #line 845 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              DeductionWorkSheetMFJStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr116Get() {
                
                #line 845 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              DeductionWorkSheetMFJStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr116Get() {
                this.GetValueTypeValues();
                return this.@__Expr116Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr118GetTree() {
                
                #line 857 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr118Get() {
                
                #line 857 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineCAmount, Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineDAmount);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr118Get() {
                this.GetValueTypeValues();
                return this.@__Expr118Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr120GetTree() {
                
                #line 869 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              DeductionWorkSheetMFJExemption;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr120Get() {
                
                #line 869 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              DeductionWorkSheetMFJExemption;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr120Get() {
                this.GetValueTypeValues();
                return this.@__Expr120Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr122GetTree() {
                
                #line 881 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr122Get() {
                
                #line 881 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineEAmount + Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineFAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr122Get() {
                this.GetValueTypeValues();
                return this.@__Expr122Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr124GetTree() {
                
                #line 893 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr124Get() {
                
                #line 893 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                              Math.Round(Tax1040Object.F1040EZ.F1040EZWorkSheets.DeductionsWorkSheet.LineGAmount,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr124Get() {
                this.GetValueTypeValues();
                return this.@__Expr124Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr126GetTree() {
                
                #line 908 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                            Math.Round(DeductionWorksheetMFJDefaultStandardDeduction,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr126Get() {
                
                #line 908 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZSTANDARDDEDUCTIONWITHNOVALIDATION.XAML"
                return 
                                            Math.Round(DeductionWorksheetMFJDefaultStandardDeduction,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr126Get() {
                this.GetValueTypeValues();
                return this.@__Expr126Get();
            }
            
            protected override void GetValueTypeValues() {
                this.DeductionWorkSheetSingleStandardDeduction = ((double)(this.GetVariableValue((2 + locationsOffset))));
                this.DeductionWorkSheetMFJStandardDeduction = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.DeductionWorkSheetMFJExemption = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.DeductionWorkSheetDefaultExemption = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.DeductionWorksheetSingleDefaultStandardDeduction = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.DeductionWorksheetMFJDefaultStandardDeduction = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.DeductionWorksheetMinimunStandardDeduction = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.DeductionWorksheetLine1DefaultAmount = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.TotalWages = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "WagesPrefix") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "DeductionWorkSheetSingleStandardDeduction") 
                            || (locationReferences[(offset + 2)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "DeductionWorkSheetMFJStandardDeduction") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "DeductionWorkSheetMFJExemption") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "DeductionWorkSheetDefaultExemption") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "DeductionWorksheetSingleDefaultStandardDeduction") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "DeductionWorksheetMFJDefaultStandardDeduction") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "DeductionWorksheetMinimunStandardDeduction") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "DeductionWorksheetLine1DefaultAmount") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TotalWages") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZStandardDeductionWithNoValidation_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
