namespace JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation {
    
    #line 30 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\IncomeSummaryCalculation.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\IncomeSummaryCalculation.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 31 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\IncomeSummaryCalculation.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\IncomeSummaryCalculation.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\IncomeSummaryCalculation.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\IncomeSummaryCalculation.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 32 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\IncomeSummaryCalculation.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 33 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\IncomeSummaryCalculation.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 34 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\IncomeSummaryCalculation.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 35 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\IncomeSummaryCalculation.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\IncomeSummaryCalculation.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class IncomeSummaryCalculation : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext0 = ((IncomeSummaryCalculation_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext1 = ((IncomeSummaryCalculation_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new IncomeSummaryCalculation_TypedDataContext1(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1 refDataContext2 = ((IncomeSummaryCalculation_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new IncomeSummaryCalculation_TypedDataContext1(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1 refDataContext3 = ((IncomeSummaryCalculation_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<double>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new IncomeSummaryCalculation_TypedDataContext1(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1 refDataContext4 = ((IncomeSummaryCalculation_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<string>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext5 = ((IncomeSummaryCalculation_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new IncomeSummaryCalculation_TypedDataContext2(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext2 refDataContext6 = ((IncomeSummaryCalculation_TypedDataContext2)(cachedCompiledDataContext[2]));
                return refDataContext6.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new IncomeSummaryCalculation_TypedDataContext2(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext2 refDataContext7 = ((IncomeSummaryCalculation_TypedDataContext2)(cachedCompiledDataContext[2]));
                return refDataContext7.GetLocation<double>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new IncomeSummaryCalculation_TypedDataContext2(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext2 refDataContext8 = ((IncomeSummaryCalculation_TypedDataContext2)(cachedCompiledDataContext[2]));
                return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext9 = ((IncomeSummaryCalculation_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new IncomeSummaryCalculation_TypedDataContext3(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext3 refDataContext10 = ((IncomeSummaryCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext10.GetLocation<double>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new IncomeSummaryCalculation_TypedDataContext3(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext3 refDataContext11 = ((IncomeSummaryCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext11.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new IncomeSummaryCalculation_TypedDataContext3(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext3 refDataContext12 = ((IncomeSummaryCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext12.GetLocation<double>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext13 = ((IncomeSummaryCalculation_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new IncomeSummaryCalculation_TypedDataContext1(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1 refDataContext14 = ((IncomeSummaryCalculation_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<double>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext15 = ((IncomeSummaryCalculation_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new IncomeSummaryCalculation_TypedDataContext1(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1 refDataContext16 = ((IncomeSummaryCalculation_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext16.GetLocation<double>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext17 = ((IncomeSummaryCalculation_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new IncomeSummaryCalculation_TypedDataContext4(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext4 refDataContext18 = ((IncomeSummaryCalculation_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext18.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new IncomeSummaryCalculation_TypedDataContext4(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext4 refDataContext19 = ((IncomeSummaryCalculation_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext19.GetLocation<double>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext20 = ((IncomeSummaryCalculation_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext21 = ((IncomeSummaryCalculation_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new IncomeSummaryCalculation_TypedDataContext1(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1 refDataContext22 = ((IncomeSummaryCalculation_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext22.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = IncomeSummaryCalculation_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new IncomeSummaryCalculation_TypedDataContext1(locations, activityContext, true);
                }
                IncomeSummaryCalculation_TypedDataContext1 refDataContext23 = ((IncomeSummaryCalculation_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext23.GetLocation<double>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
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
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext0 = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext1 = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                IncomeSummaryCalculation_TypedDataContext1 refDataContext2 = new IncomeSummaryCalculation_TypedDataContext1(locations, true);
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                IncomeSummaryCalculation_TypedDataContext1 refDataContext3 = new IncomeSummaryCalculation_TypedDataContext1(locations, true);
                return refDataContext3.GetLocation<double>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                IncomeSummaryCalculation_TypedDataContext1 refDataContext4 = new IncomeSummaryCalculation_TypedDataContext1(locations, true);
                return refDataContext4.GetLocation<string>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext5 = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                IncomeSummaryCalculation_TypedDataContext2 refDataContext6 = new IncomeSummaryCalculation_TypedDataContext2(locations, true);
                return refDataContext6.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                IncomeSummaryCalculation_TypedDataContext2 refDataContext7 = new IncomeSummaryCalculation_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<double>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                IncomeSummaryCalculation_TypedDataContext2 refDataContext8 = new IncomeSummaryCalculation_TypedDataContext2(locations, true);
                return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext9 = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                IncomeSummaryCalculation_TypedDataContext3 refDataContext10 = new IncomeSummaryCalculation_TypedDataContext3(locations, true);
                return refDataContext10.GetLocation<double>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                IncomeSummaryCalculation_TypedDataContext3 refDataContext11 = new IncomeSummaryCalculation_TypedDataContext3(locations, true);
                return refDataContext11.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                IncomeSummaryCalculation_TypedDataContext3 refDataContext12 = new IncomeSummaryCalculation_TypedDataContext3(locations, true);
                return refDataContext12.GetLocation<double>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext13 = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                IncomeSummaryCalculation_TypedDataContext1 refDataContext14 = new IncomeSummaryCalculation_TypedDataContext1(locations, true);
                return refDataContext14.GetLocation<double>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext15 = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                IncomeSummaryCalculation_TypedDataContext1 refDataContext16 = new IncomeSummaryCalculation_TypedDataContext1(locations, true);
                return refDataContext16.GetLocation<double>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext17 = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                IncomeSummaryCalculation_TypedDataContext4 refDataContext18 = new IncomeSummaryCalculation_TypedDataContext4(locations, true);
                return refDataContext18.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                IncomeSummaryCalculation_TypedDataContext4 refDataContext19 = new IncomeSummaryCalculation_TypedDataContext4(locations, true);
                return refDataContext19.GetLocation<double>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext20 = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                IncomeSummaryCalculation_TypedDataContext1_ForReadOnly valDataContext21 = new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                IncomeSummaryCalculation_TypedDataContext1 refDataContext22 = new IncomeSummaryCalculation_TypedDataContext1(locations, true);
                return refDataContext22.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set);
            }
            if ((expressionId == 23)) {
                IncomeSummaryCalculation_TypedDataContext1 refDataContext23 = new IncomeSummaryCalculation_TypedDataContext1(locations, true);
                return refDataContext23.GetLocation<double>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object !=null && Tax1040Object.Income !=null)") 
                        && (IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count > " +
                            "0))") 
                        && (IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (IncomeSummaryCalculation_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWagesAmount") 
                        && (IncomeSummaryCalculation_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "PrefixWages") 
                        && (IncomeSummaryCalculation_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT." +
                            "Count > 0))") 
                        && (IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (IncomeSummaryCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalExempt1099INT") 
                        && (IncomeSummaryCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Total1099INT") 
                        && (IncomeSummaryCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID." +
                            "Count > 0))") 
                        && (IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalExempt1099OID") 
                        && (IncomeSummaryCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (IncomeSummaryCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tota1099OID") 
                        && (IncomeSummaryCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tota1099OID + Total1099INT") 
                        && (IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalInterestIncomeAmount") 
                        && (IncomeSummaryCalculation_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalExempt1099INT+TotalExempt1099OID") 
                        && (IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalExemptionAmount") 
                        && (IncomeSummaryCalculation_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Coun" +
                            "t > 0))") 
                        && (IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (IncomeSummaryCalculation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalUnemploymentAmount") 
                        && (IncomeSummaryCalculation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome !=null") 
                        && (IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object" +
                            ".Income.OtherIncome.HasAlaskaPermanantFund.Value") 
                        && (IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (IncomeSummaryCalculation_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalOtherIncomeAmount") 
                        && (IncomeSummaryCalculation_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
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
                return new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new IncomeSummaryCalculation_TypedDataContext1(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new IncomeSummaryCalculation_TypedDataContext1(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new IncomeSummaryCalculation_TypedDataContext1(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new IncomeSummaryCalculation_TypedDataContext2(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new IncomeSummaryCalculation_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new IncomeSummaryCalculation_TypedDataContext2(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new IncomeSummaryCalculation_TypedDataContext3(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new IncomeSummaryCalculation_TypedDataContext3(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new IncomeSummaryCalculation_TypedDataContext3(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new IncomeSummaryCalculation_TypedDataContext1(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new IncomeSummaryCalculation_TypedDataContext1(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new IncomeSummaryCalculation_TypedDataContext4(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new IncomeSummaryCalculation_TypedDataContext4(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new IncomeSummaryCalculation_TypedDataContext1(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new IncomeSummaryCalculation_TypedDataContext1(locationReferences).@__Expr23GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class IncomeSummaryCalculation_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public IncomeSummaryCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class IncomeSummaryCalculation_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public IncomeSummaryCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class IncomeSummaryCalculation_TypedDataContext1 : IncomeSummaryCalculation_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalExempt1099INT;
            
            protected double Tota1099OID;
            
            protected double TotalExempt1099OID;
            
            protected double Total1099INT;
            
            protected double TotalInterestIncomeAmount;
            
            protected double TotalWagesAmount;
            
            protected double TotalOtherIncomeAmount;
            
            protected double TotalExemptionAmount;
            
            protected double TotalUnemploymentAmount;
            
            public IncomeSummaryCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Tax1040 Tax1040Object {
                get {
                    return ((JTL.Tax1040.BusinessObject.Tax1040)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string PrefixWages {
                get {
                    return ((string)(this.GetVariableValue((9 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((9 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 92 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr2Get() {
                
                #line 92 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 92 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 97 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          TotalWagesAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr3Get() {
                
                #line 97 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                          TotalWagesAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(double value) {
                
                #line 97 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                          TotalWagesAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 87 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          PrefixWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr4Get() {
                
                #line 87 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                          PrefixWages;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(string value) {
                
                #line 87 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                          PrefixWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 171 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    TotalInterestIncomeAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr14Get() {
                
                #line 171 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                    TotalInterestIncomeAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(double value) {
                
                #line 171 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                    TotalInterestIncomeAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 183 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    TotalExemptionAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr16Get() {
                
                #line 183 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                    TotalExemptionAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(double value) {
                
                #line 183 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                    TotalExemptionAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 247 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                              Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr22Get() {
                
                #line 247 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                              Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr22Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 247 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                              Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr22Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr22Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 242 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              TotalOtherIncomeAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr23Get() {
                
                #line 242 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                              TotalOtherIncomeAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(double value) {
                
                #line 242 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                              TotalOtherIncomeAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalExempt1099INT = ((double)(this.GetVariableValue((0 + locationsOffset))));
                this.Tota1099OID = ((double)(this.GetVariableValue((2 + locationsOffset))));
                this.TotalExempt1099OID = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.Total1099INT = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.TotalInterestIncomeAmount = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.TotalWagesAmount = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.TotalOtherIncomeAmount = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.TotalExemptionAmount = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.TotalUnemploymentAmount = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.TotalExempt1099INT);
                this.SetVariableValue((2 + locationsOffset), this.Tota1099OID);
                this.SetVariableValue((3 + locationsOffset), this.TotalExempt1099OID);
                this.SetVariableValue((4 + locationsOffset), this.Total1099INT);
                this.SetVariableValue((5 + locationsOffset), this.TotalInterestIncomeAmount);
                this.SetVariableValue((6 + locationsOffset), this.TotalWagesAmount);
                this.SetVariableValue((7 + locationsOffset), this.TotalOtherIncomeAmount);
                this.SetVariableValue((8 + locationsOffset), this.TotalExemptionAmount);
                this.SetVariableValue((10 + locationsOffset), this.TotalUnemploymentAmount);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                if (((locationReferences[(offset + 1)].Name != "Tax1040Object") 
                            || (locationReferences[(offset + 1)].Type != typeof(JTL.Tax1040.BusinessObject.Tax1040)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "PrefixWages") 
                            || (locationReferences[(offset + 9)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "TotalExempt1099INT") 
                            || (locationReferences[(offset + 0)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Tota1099OID") 
                            || (locationReferences[(offset + 2)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "TotalExempt1099OID") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Total1099INT") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "TotalInterestIncomeAmount") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "TotalWagesAmount") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "TotalOtherIncomeAmount") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "TotalExemptionAmount") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TotalUnemploymentAmount") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return IncomeSummaryCalculation_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class IncomeSummaryCalculation_TypedDataContext1_ForReadOnly : IncomeSummaryCalculation_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalExempt1099INT;
            
            protected double Tota1099OID;
            
            protected double TotalExempt1099OID;
            
            protected double Total1099INT;
            
            protected double TotalInterestIncomeAmount;
            
            protected double TotalWagesAmount;
            
            protected double TotalOtherIncomeAmount;
            
            protected double TotalExemptionAmount;
            
            protected double TotalUnemploymentAmount;
            
            public IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Tax1040 Tax1040Object {
                get {
                    return ((JTL.Tax1040.BusinessObject.Tax1040)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string PrefixWages {
                get {
                    return ((string)(this.GetVariableValue((9 + locationsOffset))));
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
                
                #line 70 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
            (Tax1040Object !=null && Tax1040Object.Income !=null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr0Get() {
                
                #line 70 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
            (Tax1040Object !=null && Tax1040Object.Income !=null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 79 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    ((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 79 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                    ((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 109 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    ((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 109 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                    ((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 140 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    ((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr9Get() {
                
                #line 140 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                    ((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 176 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tota1099OID + Total1099INT;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr13Get() {
                
                #line 176 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                    Tota1099OID + Total1099INT;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    TotalExempt1099INT+TotalExempt1099OID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr15Get() {
                
                #line 188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                    TotalExempt1099INT+TotalExempt1099OID;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 197 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    ((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr17Get() {
                
                #line 197 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                    ((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 227 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr20Get() {
                
                #line 227 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                    Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 234 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr21Get() {
                
                #line 234 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                        Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.Value;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalExempt1099INT = ((double)(this.GetVariableValue((0 + locationsOffset))));
                this.Tota1099OID = ((double)(this.GetVariableValue((2 + locationsOffset))));
                this.TotalExempt1099OID = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.Total1099INT = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.TotalInterestIncomeAmount = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.TotalWagesAmount = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.TotalOtherIncomeAmount = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.TotalExemptionAmount = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.TotalUnemploymentAmount = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                if (((locationReferences[(offset + 1)].Name != "Tax1040Object") 
                            || (locationReferences[(offset + 1)].Type != typeof(JTL.Tax1040.BusinessObject.Tax1040)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "PrefixWages") 
                            || (locationReferences[(offset + 9)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "TotalExempt1099INT") 
                            || (locationReferences[(offset + 0)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Tota1099OID") 
                            || (locationReferences[(offset + 2)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "TotalExempt1099OID") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Total1099INT") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "TotalInterestIncomeAmount") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "TotalWagesAmount") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "TotalOtherIncomeAmount") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "TotalExemptionAmount") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TotalUnemploymentAmount") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return IncomeSummaryCalculation_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class IncomeSummaryCalculation_TypedDataContext2 : IncomeSummaryCalculation_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Total1099INTAmount;
            
            public IncomeSummaryCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 120 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr6Get() {
                
                #line 120 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 120 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          TotalExempt1099INT;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr7Get() {
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                          TotalExempt1099INT;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(double value) {
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                          TotalExempt1099INT = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 125 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Total1099INT;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr8Get() {
                
                #line 125 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                          Total1099INT;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(double value) {
                
                #line 125 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                          Total1099INT = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Total1099INTAmount = ((double)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((11 + locationsOffset), this.Total1099INTAmount);
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
                if (((locationReferences[(offset + 11)].Name != "Total1099INTAmount") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                return IncomeSummaryCalculation_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class IncomeSummaryCalculation_TypedDataContext2_ForReadOnly : IncomeSummaryCalculation_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Total1099INTAmount;
            
            public IncomeSummaryCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.Total1099INTAmount = ((double)(this.GetVariableValue((11 + locationsOffset))));
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
                if (((locationReferences[(offset + 11)].Name != "Total1099INTAmount") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                return IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class IncomeSummaryCalculation_TypedDataContext3 : IncomeSummaryCalculation_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public IncomeSummaryCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string variable1 {
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
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          TotalExempt1099OID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr10Get() {
                
                #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                          TotalExempt1099OID;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(double value) {
                
                #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                          TotalExempt1099OID = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 151 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr11Get() {
                
                #line 151 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 151 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 156 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tota1099OID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr12Get() {
                
                #line 156 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                          Tota1099OID;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(double value) {
                
                #line 156 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                          Tota1099OID = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
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
                if (((locationReferences[(offset + 11)].Name != "variable1") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                return IncomeSummaryCalculation_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class IncomeSummaryCalculation_TypedDataContext3_ForReadOnly : IncomeSummaryCalculation_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public IncomeSummaryCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string variable1 {
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
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "variable1") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                return IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class IncomeSummaryCalculation_TypedDataContext4 : IncomeSummaryCalculation_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalUnemploymentCompensationAmount;
            
            public IncomeSummaryCalculation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 209 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                            Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr18Get() {
                
                #line 209 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                            Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 209 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                            Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            TotalUnemploymentAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr19Get() {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                return 
                            TotalUnemploymentAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(double value) {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\INCOMESUMMARYCALCULATION.XAML"
                
                            TotalUnemploymentAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalUnemploymentCompensationAmount = ((double)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((11 + locationsOffset), this.TotalUnemploymentCompensationAmount);
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
                if (((locationReferences[(offset + 11)].Name != "TotalUnemploymentCompensationAmount") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                return IncomeSummaryCalculation_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class IncomeSummaryCalculation_TypedDataContext4_ForReadOnly : IncomeSummaryCalculation_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalUnemploymentCompensationAmount;
            
            public IncomeSummaryCalculation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public IncomeSummaryCalculation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.TotalUnemploymentCompensationAmount = ((double)(this.GetVariableValue((11 + locationsOffset))));
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
                if (((locationReferences[(offset + 11)].Name != "TotalUnemploymentCompensationAmount") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                return IncomeSummaryCalculation_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
