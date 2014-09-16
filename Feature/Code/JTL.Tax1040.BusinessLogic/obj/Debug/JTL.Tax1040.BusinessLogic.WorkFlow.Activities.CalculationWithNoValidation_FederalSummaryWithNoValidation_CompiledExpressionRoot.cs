namespace JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation {
    
    #line 29 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 36 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 30 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 31 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 32 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 33 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 34 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 35 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using JTL.Tax1040.Core.Object;
    
    #line default
    #line hidden
    
    #line 37 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using JTL.Tax1040.Core.Process;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class FederalSummaryWithNoValidation : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext0 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext1 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext2 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext3 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<JTL.Tax1040.BusinessObject.OutputForms>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext4 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext5 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<JTL.Tax1040.BusinessObject.Tax1040EZPage1>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext6 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly valDataContext7 = ((FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new FederalSummaryWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext8 = ((FederalSummaryWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext8.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new FederalSummaryWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext9 = ((FederalSummaryWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext9.GetLocation<double>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new FederalSummaryWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext10 = ((FederalSummaryWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext10.GetLocation<string>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new FederalSummaryWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext11 = ((FederalSummaryWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext11.GetLocation<double>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly valDataContext12 = ((FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new FederalSummaryWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext13 = ((FederalSummaryWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext13.GetLocation<double>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly valDataContext14 = ((FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new FederalSummaryWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext15 = ((FederalSummaryWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext15.GetLocation<string>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext16 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new FederalSummaryWithNoValidation_TypedDataContext6(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext6 refDataContext17 = ((FederalSummaryWithNoValidation_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext17.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new FederalSummaryWithNoValidation_TypedDataContext6(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext6 refDataContext18 = ((FederalSummaryWithNoValidation_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext18.GetLocation<double>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new FederalSummaryWithNoValidation_TypedDataContext6(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext6 refDataContext19 = ((FederalSummaryWithNoValidation_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext19.GetLocation<double>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext20 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext21 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext21.GetLocation<double>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext22 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext22.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext23 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext23.GetLocation<double>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext24 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext25 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext25.GetLocation<double>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext26 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext27 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext27.GetLocation<double>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext28 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext29 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext30 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext30.GetLocation<string>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext31 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext32 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext32.GetLocation<string>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext33 = ((FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new FederalSummaryWithNoValidation_TypedDataContext8(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext34 = ((FederalSummaryWithNoValidation_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext34.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new FederalSummaryWithNoValidation_TypedDataContext8(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext35 = ((FederalSummaryWithNoValidation_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext35.GetLocation<double>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new FederalSummaryWithNoValidation_TypedDataContext8(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext36 = ((FederalSummaryWithNoValidation_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext36.GetLocation<double>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly valDataContext37 = ((FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly valDataContext38 = ((FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new FederalSummaryWithNoValidation_TypedDataContext8(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext39 = ((FederalSummaryWithNoValidation_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext39.GetLocation<string>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new FederalSummaryWithNoValidation_TypedDataContext8(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext40 = ((FederalSummaryWithNoValidation_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext40.GetLocation<string>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext41 = ((FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext42 = ((FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new FederalSummaryWithNoValidation_TypedDataContext7(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7 refDataContext43 = ((FederalSummaryWithNoValidation_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext43.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new FederalSummaryWithNoValidation_TypedDataContext7(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7 refDataContext44 = ((FederalSummaryWithNoValidation_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext45 = ((FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new FederalSummaryWithNoValidation_TypedDataContext7(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7 refDataContext46 = ((FederalSummaryWithNoValidation_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext46.GetLocation<double>(refDataContext46.ValueType___Expr46Get, refDataContext46.ValueType___Expr46Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly valDataContext47 = ((FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new FederalSummaryWithNoValidation_TypedDataContext9(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext9 refDataContext48 = ((FederalSummaryWithNoValidation_TypedDataContext9)(cachedCompiledDataContext[13]));
                return refDataContext48.GetLocation<double>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new FederalSummaryWithNoValidation_TypedDataContext10(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext10 refDataContext49 = ((FederalSummaryWithNoValidation_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext49.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new FederalSummaryWithNoValidation_TypedDataContext10(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext10 refDataContext50 = ((FederalSummaryWithNoValidation_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext50.GetLocation<double>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly valDataContext51 = ((FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new FederalSummaryWithNoValidation_TypedDataContext10(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext10 refDataContext52 = ((FederalSummaryWithNoValidation_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext52.GetLocation<double>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext53 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext54 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext55 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext55.GetLocation<double>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext56 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext56.GetLocation<double>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext57 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext57.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext58 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext58.GetLocation<double>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext59 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext59.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext60 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext60.GetLocation<double>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext61 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext61.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext62 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext62.GetLocation<double>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext63 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext63.GetLocation<double>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext64 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext64.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext65 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext65.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext66 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext66.GetLocation<double>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext67 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext67.GetLocation<double>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext68 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext68.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext68.ValueType___Expr68Get, refDataContext68.ValueType___Expr68Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly valDataContext69 = ((FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext70 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext70.GetLocation<double>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new FederalSummaryWithNoValidation_TypedDataContext13(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext13 refDataContext71 = ((FederalSummaryWithNoValidation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext71.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new FederalSummaryWithNoValidation_TypedDataContext13(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext13 refDataContext72 = ((FederalSummaryWithNoValidation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext72.GetLocation<bool>(refDataContext72.ValueType___Expr72Get, refDataContext72.ValueType___Expr72Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly valDataContext73 = ((FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly valDataContext74 = ((FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext75 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext75.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext76 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext76.GetLocation<double>(refDataContext76.ValueType___Expr76Get, refDataContext76.ValueType___Expr76Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext77 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext78 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext78.GetLocation<double>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext79 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext79.ValueType___Expr79Get();
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext80 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext80.GetLocation<string>(refDataContext80.ValueType___Expr80Get, refDataContext80.ValueType___Expr80Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext81 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext82 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext83 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext84 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext84.GetLocation<string>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext85 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext86 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext86.GetLocation<string>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext87 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext88 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext89 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext90 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext90.GetLocation<string>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext91 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext92 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext92.GetLocation<string>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext93 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext94 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext94.GetLocation<string>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new FederalSummaryWithNoValidation_TypedDataContext15(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext15 refDataContext95 = ((FederalSummaryWithNoValidation_TypedDataContext15)(cachedCompiledDataContext[22]));
                return refDataContext95.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext95.ValueType___Expr95Get, refDataContext95.ValueType___Expr95Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new FederalSummaryWithNoValidation_TypedDataContext15(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext15 refDataContext96 = ((FederalSummaryWithNoValidation_TypedDataContext15)(cachedCompiledDataContext[22]));
                return refDataContext96.GetLocation<double>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly valDataContext97 = ((FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new FederalSummaryWithNoValidation_TypedDataContext15(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext15 refDataContext98 = ((FederalSummaryWithNoValidation_TypedDataContext15)(cachedCompiledDataContext[22]));
                return refDataContext98.GetLocation<double>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext99 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext100 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext100.ValueType___Expr100Get();
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext101 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext101.GetLocation<double>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext102 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext103 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext103.GetLocation<double>(refDataContext103.ValueType___Expr103Get, refDataContext103.ValueType___Expr103Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly valDataContext104 = ((FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly valDataContext105 = ((FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly valDataContext106 = ((FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext16.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new FederalSummaryWithNoValidation_TypedDataContext16(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext16 refDataContext107 = ((FederalSummaryWithNoValidation_TypedDataContext16)(cachedCompiledDataContext[25]));
                return refDataContext107.GetLocation<double>(refDataContext107.ValueType___Expr107Get, refDataContext107.ValueType___Expr107Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext108 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext109 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext109.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext110 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext111 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext111.GetLocation<double>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext112 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext113 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext114 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext114.GetLocation<double>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext115 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext116 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext116.GetLocation<string>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 117)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext117 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext117.GetLocation<double>(refDataContext117.ValueType___Expr117Get, refDataContext117.ValueType___Expr117Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 118)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext118 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext119 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext119.GetLocation<double>(refDataContext119.ValueType___Expr119Get, refDataContext119.ValueType___Expr119Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 120)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext120 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext121 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext122 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext122.GetLocation<string>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 123)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext123 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext124 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext124.GetLocation<string>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 125)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext125 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext125.GetLocation<double>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 126)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext17.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[26] == null)) {
                    cachedCompiledDataContext[26] = new FederalSummaryWithNoValidation_TypedDataContext17(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext17 refDataContext126 = ((FederalSummaryWithNoValidation_TypedDataContext17)(cachedCompiledDataContext[26]));
                return refDataContext126.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext126.ValueType___Expr126Get, refDataContext126.ValueType___Expr126Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 127)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext17.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[26] == null)) {
                    cachedCompiledDataContext[26] = new FederalSummaryWithNoValidation_TypedDataContext17(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext17 refDataContext127 = ((FederalSummaryWithNoValidation_TypedDataContext17)(cachedCompiledDataContext[26]));
                return refDataContext127.GetLocation<double>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 128)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext17_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[27] == null)) {
                    cachedCompiledDataContext[27] = new FederalSummaryWithNoValidation_TypedDataContext17_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext17_ForReadOnly valDataContext128 = ((FederalSummaryWithNoValidation_TypedDataContext17_ForReadOnly)(cachedCompiledDataContext[27]));
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext17.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[26] == null)) {
                    cachedCompiledDataContext[26] = new FederalSummaryWithNoValidation_TypedDataContext17(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext17 refDataContext129 = ((FederalSummaryWithNoValidation_TypedDataContext17)(cachedCompiledDataContext[26]));
                return refDataContext129.GetLocation<double>(refDataContext129.ValueType___Expr129Get, refDataContext129.ValueType___Expr129Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 130)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[28] == null)) {
                    cachedCompiledDataContext[28] = new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly valDataContext130 = ((FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[28]));
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[28] == null)) {
                    cachedCompiledDataContext[28] = new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly valDataContext131 = ((FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[28]));
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[28] == null)) {
                    cachedCompiledDataContext[28] = new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly valDataContext132 = ((FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[28]));
                return valDataContext132.ValueType___Expr132Get();
            }
            if ((expressionId == 133)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[28] == null)) {
                    cachedCompiledDataContext[28] = new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly valDataContext133 = ((FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[28]));
                return valDataContext133.ValueType___Expr133Get();
            }
            if ((expressionId == 134)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext18.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new FederalSummaryWithNoValidation_TypedDataContext18(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext18 refDataContext134 = ((FederalSummaryWithNoValidation_TypedDataContext18)(cachedCompiledDataContext[29]));
                return refDataContext134.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext134.ValueType___Expr134Get, refDataContext134.ValueType___Expr134Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 135)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[28] == null)) {
                    cachedCompiledDataContext[28] = new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly valDataContext135 = ((FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[28]));
                return valDataContext135.ValueType___Expr135Get();
            }
            if ((expressionId == 136)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[28] == null)) {
                    cachedCompiledDataContext[28] = new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly valDataContext136 = ((FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[28]));
                return valDataContext136.ValueType___Expr136Get();
            }
            if ((expressionId == 137)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext137 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext138 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext139 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext139.ValueType___Expr139Get();
            }
            if ((expressionId == 140)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext140 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext140.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext140.ValueType___Expr140Get, refDataContext140.ValueType___Expr140Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 141)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext141 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext142 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext142.ValueType___Expr142Get();
            }
            if ((expressionId == 143)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext143 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext143.ValueType___Expr143Get();
            }
            if ((expressionId == 144)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext144 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext144.ValueType___Expr144Get();
            }
            if ((expressionId == 145)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext145 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext145.ValueType___Expr145Get();
            }
            if ((expressionId == 146)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext146 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext146.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext146.ValueType___Expr146Get, refDataContext146.ValueType___Expr146Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 147)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext147 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext147.ValueType___Expr147Get();
            }
            if ((expressionId == 148)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext148 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext148.ValueType___Expr148Get();
            }
            if ((expressionId == 149)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext149 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext149.ValueType___Expr149Get();
            }
            if ((expressionId == 150)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext150 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext150.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext150.ValueType___Expr150Get, refDataContext150.ValueType___Expr150Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 151)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext151 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext151.ValueType___Expr151Get();
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
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext0 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext1 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext2 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext3 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext3.GetLocation<JTL.Tax1040.BusinessObject.OutputForms>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext4 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext5 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<JTL.Tax1040.BusinessObject.Tax1040EZPage1>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext6 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly valDataContext7 = new FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext8 = new FederalSummaryWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext8.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext9 = new FederalSummaryWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext9.GetLocation<double>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext10 = new FederalSummaryWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext10.GetLocation<string>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext11 = new FederalSummaryWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext11.GetLocation<double>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly valDataContext12 = new FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext13 = new FederalSummaryWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext13.GetLocation<double>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly valDataContext14 = new FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext15 = new FederalSummaryWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext15.GetLocation<string>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext16 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                FederalSummaryWithNoValidation_TypedDataContext6 refDataContext17 = new FederalSummaryWithNoValidation_TypedDataContext6(locations, true);
                return refDataContext17.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                FederalSummaryWithNoValidation_TypedDataContext6 refDataContext18 = new FederalSummaryWithNoValidation_TypedDataContext6(locations, true);
                return refDataContext18.GetLocation<double>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                FederalSummaryWithNoValidation_TypedDataContext6 refDataContext19 = new FederalSummaryWithNoValidation_TypedDataContext6(locations, true);
                return refDataContext19.GetLocation<double>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext20 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext21 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext21.GetLocation<double>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext22 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext22.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set);
            }
            if ((expressionId == 23)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext23 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext23.GetLocation<double>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext24 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext25 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext25.GetLocation<double>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext26 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext27 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext27.GetLocation<double>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext28 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext29 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext30 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext30.GetLocation<string>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext31 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext32 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext32.GetLocation<string>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext33 = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext34 = new FederalSummaryWithNoValidation_TypedDataContext8(locations, true);
                return refDataContext34.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext35 = new FederalSummaryWithNoValidation_TypedDataContext8(locations, true);
                return refDataContext35.GetLocation<double>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext36 = new FederalSummaryWithNoValidation_TypedDataContext8(locations, true);
                return refDataContext36.GetLocation<double>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
            }
            if ((expressionId == 37)) {
                FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly valDataContext37 = new FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly valDataContext38 = new FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext39 = new FederalSummaryWithNoValidation_TypedDataContext8(locations, true);
                return refDataContext39.GetLocation<string>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext40 = new FederalSummaryWithNoValidation_TypedDataContext8(locations, true);
                return refDataContext40.GetLocation<string>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set);
            }
            if ((expressionId == 41)) {
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext41 = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext42 = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                FederalSummaryWithNoValidation_TypedDataContext7 refDataContext43 = new FederalSummaryWithNoValidation_TypedDataContext7(locations, true);
                return refDataContext43.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                FederalSummaryWithNoValidation_TypedDataContext7 refDataContext44 = new FederalSummaryWithNoValidation_TypedDataContext7(locations, true);
                return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
            }
            if ((expressionId == 45)) {
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext45 = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                FederalSummaryWithNoValidation_TypedDataContext7 refDataContext46 = new FederalSummaryWithNoValidation_TypedDataContext7(locations, true);
                return refDataContext46.GetLocation<double>(refDataContext46.ValueType___Expr46Get, refDataContext46.ValueType___Expr46Set);
            }
            if ((expressionId == 47)) {
                FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly valDataContext47 = new FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                FederalSummaryWithNoValidation_TypedDataContext9 refDataContext48 = new FederalSummaryWithNoValidation_TypedDataContext9(locations, true);
                return refDataContext48.GetLocation<double>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set);
            }
            if ((expressionId == 49)) {
                FederalSummaryWithNoValidation_TypedDataContext10 refDataContext49 = new FederalSummaryWithNoValidation_TypedDataContext10(locations, true);
                return refDataContext49.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set);
            }
            if ((expressionId == 50)) {
                FederalSummaryWithNoValidation_TypedDataContext10 refDataContext50 = new FederalSummaryWithNoValidation_TypedDataContext10(locations, true);
                return refDataContext50.GetLocation<double>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set);
            }
            if ((expressionId == 51)) {
                FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly valDataContext51 = new FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                FederalSummaryWithNoValidation_TypedDataContext10 refDataContext52 = new FederalSummaryWithNoValidation_TypedDataContext10(locations, true);
                return refDataContext52.GetLocation<double>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set);
            }
            if ((expressionId == 53)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext53 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext54 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext55 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext55.GetLocation<double>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set);
            }
            if ((expressionId == 56)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext56 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext56.GetLocation<double>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set);
            }
            if ((expressionId == 57)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext57 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext57.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set);
            }
            if ((expressionId == 58)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext58 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext58.GetLocation<double>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set);
            }
            if ((expressionId == 59)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext59 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext59.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext60 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext60.GetLocation<double>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set);
            }
            if ((expressionId == 61)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext61 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext61.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext62 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext62.GetLocation<double>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set);
            }
            if ((expressionId == 63)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext63 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext63.GetLocation<double>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set);
            }
            if ((expressionId == 64)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext64 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext64.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set);
            }
            if ((expressionId == 65)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext65 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext65.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set);
            }
            if ((expressionId == 66)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext66 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext66.GetLocation<double>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set);
            }
            if ((expressionId == 67)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext67 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext67.GetLocation<double>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set);
            }
            if ((expressionId == 68)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext68 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext68.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext68.ValueType___Expr68Get, refDataContext68.ValueType___Expr68Set);
            }
            if ((expressionId == 69)) {
                FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly valDataContext69 = new FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext70 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext70.GetLocation<double>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set);
            }
            if ((expressionId == 71)) {
                FederalSummaryWithNoValidation_TypedDataContext13 refDataContext71 = new FederalSummaryWithNoValidation_TypedDataContext13(locations, true);
                return refDataContext71.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set);
            }
            if ((expressionId == 72)) {
                FederalSummaryWithNoValidation_TypedDataContext13 refDataContext72 = new FederalSummaryWithNoValidation_TypedDataContext13(locations, true);
                return refDataContext72.GetLocation<bool>(refDataContext72.ValueType___Expr72Get, refDataContext72.ValueType___Expr72Set);
            }
            if ((expressionId == 73)) {
                FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly valDataContext73 = new FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly valDataContext74 = new FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext75 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext75.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set);
            }
            if ((expressionId == 76)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext76 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext76.GetLocation<double>(refDataContext76.ValueType___Expr76Get, refDataContext76.ValueType___Expr76Set);
            }
            if ((expressionId == 77)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext77 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext78 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext78.GetLocation<double>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set);
            }
            if ((expressionId == 79)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext79 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext79.ValueType___Expr79Get();
            }
            if ((expressionId == 80)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext80 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext80.GetLocation<string>(refDataContext80.ValueType___Expr80Get, refDataContext80.ValueType___Expr80Set);
            }
            if ((expressionId == 81)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext81 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext82 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext83 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext84 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext84.GetLocation<string>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set);
            }
            if ((expressionId == 85)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext85 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext86 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext86.GetLocation<string>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set);
            }
            if ((expressionId == 87)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext87 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext88 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext89 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext90 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext90.GetLocation<string>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set);
            }
            if ((expressionId == 91)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext91 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext92 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext92.GetLocation<string>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set);
            }
            if ((expressionId == 93)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext93 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext94 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext94.GetLocation<string>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set);
            }
            if ((expressionId == 95)) {
                FederalSummaryWithNoValidation_TypedDataContext15 refDataContext95 = new FederalSummaryWithNoValidation_TypedDataContext15(locations, true);
                return refDataContext95.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext95.ValueType___Expr95Get, refDataContext95.ValueType___Expr95Set);
            }
            if ((expressionId == 96)) {
                FederalSummaryWithNoValidation_TypedDataContext15 refDataContext96 = new FederalSummaryWithNoValidation_TypedDataContext15(locations, true);
                return refDataContext96.GetLocation<double>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set);
            }
            if ((expressionId == 97)) {
                FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly valDataContext97 = new FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                FederalSummaryWithNoValidation_TypedDataContext15 refDataContext98 = new FederalSummaryWithNoValidation_TypedDataContext15(locations, true);
                return refDataContext98.GetLocation<double>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set);
            }
            if ((expressionId == 99)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext99 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext100 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext100.ValueType___Expr100Get();
            }
            if ((expressionId == 101)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext101 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext101.GetLocation<double>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set);
            }
            if ((expressionId == 102)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext102 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext103 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext103.GetLocation<double>(refDataContext103.ValueType___Expr103Get, refDataContext103.ValueType___Expr103Set);
            }
            if ((expressionId == 104)) {
                FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly valDataContext104 = new FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(locations, true);
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly valDataContext105 = new FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(locations, true);
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly valDataContext106 = new FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(locations, true);
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                FederalSummaryWithNoValidation_TypedDataContext16 refDataContext107 = new FederalSummaryWithNoValidation_TypedDataContext16(locations, true);
                return refDataContext107.GetLocation<double>(refDataContext107.ValueType___Expr107Get, refDataContext107.ValueType___Expr107Set);
            }
            if ((expressionId == 108)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext108 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext109 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext109.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set);
            }
            if ((expressionId == 110)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext110 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext111 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext111.GetLocation<double>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set);
            }
            if ((expressionId == 112)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext112 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext113 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext114 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext114.GetLocation<double>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set);
            }
            if ((expressionId == 115)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext115 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext116 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext116.GetLocation<string>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set);
            }
            if ((expressionId == 117)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext117 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext117.GetLocation<double>(refDataContext117.ValueType___Expr117Get, refDataContext117.ValueType___Expr117Set);
            }
            if ((expressionId == 118)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext118 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext119 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext119.GetLocation<double>(refDataContext119.ValueType___Expr119Get, refDataContext119.ValueType___Expr119Set);
            }
            if ((expressionId == 120)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext120 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext121 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext122 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext122.GetLocation<string>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set);
            }
            if ((expressionId == 123)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext123 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext124 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext124.GetLocation<string>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set);
            }
            if ((expressionId == 125)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext125 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext125.GetLocation<double>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set);
            }
            if ((expressionId == 126)) {
                FederalSummaryWithNoValidation_TypedDataContext17 refDataContext126 = new FederalSummaryWithNoValidation_TypedDataContext17(locations, true);
                return refDataContext126.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext126.ValueType___Expr126Get, refDataContext126.ValueType___Expr126Set);
            }
            if ((expressionId == 127)) {
                FederalSummaryWithNoValidation_TypedDataContext17 refDataContext127 = new FederalSummaryWithNoValidation_TypedDataContext17(locations, true);
                return refDataContext127.GetLocation<double>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set);
            }
            if ((expressionId == 128)) {
                FederalSummaryWithNoValidation_TypedDataContext17_ForReadOnly valDataContext128 = new FederalSummaryWithNoValidation_TypedDataContext17_ForReadOnly(locations, true);
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                FederalSummaryWithNoValidation_TypedDataContext17 refDataContext129 = new FederalSummaryWithNoValidation_TypedDataContext17(locations, true);
                return refDataContext129.GetLocation<double>(refDataContext129.ValueType___Expr129Get, refDataContext129.ValueType___Expr129Set);
            }
            if ((expressionId == 130)) {
                FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly valDataContext130 = new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locations, true);
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly valDataContext131 = new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locations, true);
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly valDataContext132 = new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locations, true);
                return valDataContext132.ValueType___Expr132Get();
            }
            if ((expressionId == 133)) {
                FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly valDataContext133 = new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locations, true);
                return valDataContext133.ValueType___Expr133Get();
            }
            if ((expressionId == 134)) {
                FederalSummaryWithNoValidation_TypedDataContext18 refDataContext134 = new FederalSummaryWithNoValidation_TypedDataContext18(locations, true);
                return refDataContext134.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext134.ValueType___Expr134Get, refDataContext134.ValueType___Expr134Set);
            }
            if ((expressionId == 135)) {
                FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly valDataContext135 = new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locations, true);
                return valDataContext135.ValueType___Expr135Get();
            }
            if ((expressionId == 136)) {
                FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly valDataContext136 = new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locations, true);
                return valDataContext136.ValueType___Expr136Get();
            }
            if ((expressionId == 137)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext137 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext138 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext139 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext139.ValueType___Expr139Get();
            }
            if ((expressionId == 140)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext140 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext140.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext140.ValueType___Expr140Get, refDataContext140.ValueType___Expr140Set);
            }
            if ((expressionId == 141)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext141 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext142 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext142.ValueType___Expr142Get();
            }
            if ((expressionId == 143)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext143 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext143.ValueType___Expr143Get();
            }
            if ((expressionId == 144)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext144 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext144.ValueType___Expr144Get();
            }
            if ((expressionId == 145)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext145 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext145.ValueType___Expr145Get();
            }
            if ((expressionId == 146)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext146 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext146.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext146.ValueType___Expr146Get, refDataContext146.ValueType___Expr146Set);
            }
            if ((expressionId == 147)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext147 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext147.ValueType___Expr147Get();
            }
            if ((expressionId == 148)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext148 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext148.ValueType___Expr148Get();
            }
            if ((expressionId == 149)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext149 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext149.ValueType___Expr149Get();
            }
            if ((expressionId == 150)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext150 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext150.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext150.ValueType___Expr150Get, refDataContext150.ValueType___Expr150Set);
            }
            if ((expressionId == 151)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext151 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext151.ValueType___Expr151Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object !=null") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new OutputForms()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Tax1040EZPage1()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income !=null") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0)" +
                            ")") 
                        && (FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWages") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "WagesPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NonQualifiedPlansAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalWages") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WagesPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT." +
                            "Count > 0))") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099INTTaxExemptInterest") 
                        && (FederalSummaryWithNoValidation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099INTTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID." +
                            "Count > 0))") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099OIDTaxExemptInterest") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099OIDTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099INTTotal + Form1099OIDTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "F1099INTTaxExemptInterest + F1099OIDTaxExemptInterest") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TEI") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TEI != null && Tax1040Object.OutputForms" +
                            ".Tax1040EZPage1.TEI > 0") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TEIPrefix + Tax1040Object.OutputForms.Tax1040EZPage1.TEI.ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Coun" +
                            "t > 0))") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "UnemploymentAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalRepaid") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalRepaid!=null&&TotalRepaid>0") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RepaidPrefix+TotalRepaid.ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome !=null") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object" +
                            ".Income.OtherIncome.HasAlaskaPermanantFund.Value") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AlaskaPermanantFundAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "UnemploymentAmount + AlaskaPermanantFundAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.T" +
                            "ax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.Unemplo" +
                            "ymentCompensation") 
                        && (FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome") 
                        && (FederalSummaryWithNoValidation_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalStandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalStandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome > Tax1040Object.Outp" +
                            "utForms.Tax1040EZPage1.StandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome - Tax1040Object.Outp" +
                            "utForms.Tax1040EZPage1.StandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "W2FederalTaxWithholdTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099INTFederalTaxWithholdTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099OIDFederalTaxWithholdTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099GFederalTaxWithholdTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "FSSBFederalTaxWithHoldingTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "FRRBFederalTaxWithHoldingTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "W2FederalTaxWithholdTotal + Form1099INTFederalTaxWithholdTotal + Form1099OIDFeder" +
                            "alTaxWithholdTotal + Form1099GFederalTaxWithholdTotal + FSSBFederalTaxWithHoldin" +
                            "gTotal + FRRBFederalTaxWithHoldingTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "HasEarnedIncomeCredit") 
                        && (FederalSummaryWithNoValidation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome") 
                        && (FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "HasEarnedIncomeCredit") 
                        && (FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalEarnedIncomeCredit") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalEarnedIncomeCredit") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NonQualifiedPlansAmount > 0") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Utilities.IsStringEmpty(Prefix1040EZLine1)") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"DFC $\" + NonQualifiedPlansAmount.ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Prefix1040EZLine1 + \",DFC $\" + NonQualifiedPlansAmount.ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.Credits!=null) && (Tax1040Object.Credits.EIC!=null) && (Tax1040Obj" +
                            "ect.Credits.EIC.PenalInstitutionInmateWages.HasValue) &&(Tax1040Object.Credits.E" +
                            "IC.PenalInstitutionInmateWages > 0)") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Utilities.IsStringEmpty(Prefix1040EZLine1)") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"PRI $\" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Prefix1040EZLine1 + \",PRI $\" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWa" +
                            "ges.ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NonTaxableCombatPayElectionTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NonTaxableCombatPayElectionTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection") 
                        && (FederalSummaryWithNoValidation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties != null && Tax1040Object.TaxesAndPenalties.Federa" +
                            "lExtensionAmount != null") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.HasValue ? Tax1040Object." +
                            "TaxesAndPenalties.FederalExtensionAmount.Value : 0)") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount + Tax1040Obj" +
                            "ect.OutputForms.Tax1040EZPage1.EarnedIncomeCredit+ Tax1040Object.OutputForms.Tax" +
                            "1040EZPage1.FederalExtensionAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails != null && Tax1040Object.PersonalDetails.PrimaryTax" +
                            "Payer != null && Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus !=nu" +
                            "ll") 
                        && (FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms != null && Tax1040Object.OutputForms.Tax1040EZPage1 != " +
                            "null && Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome !=null") 
                        && (FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "JTL.Tax1040.Core.Process.TaxRateCalculation.TaxCalculation(Tax1040Object.Personal" +
                            "Details.PrimaryTaxPayer.FilingStatus, Tax1040Object.OutputForms.Tax1040EZPage1.T" +
                            "axableIncome)") 
                        && (FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext16.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties != null") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest.HasValue ? Tax1040Object.Tax" +
                            "esAndPenalties.PenaltiesAndInterest.Value : 0") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.PenaltiesAndInterest") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits > Tax1040Object." +
                            "OutputForms.Tax1040EZPage1.TaxAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits - Tax1040Object." +
                            "OutputForms.Tax1040EZPage1.TaxAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.TaxOweAmountPDF") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 116;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 117;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Ta" +
                            "x1040EZPage1.TotalPaymentsAndCredits") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 118;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 119;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount >0") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 120;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Total Line 12 $\" + Math.Round(Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmo" +
                            "unt, MidpointRounding.AwayFromZero).ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 121;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.TaxOweAmountPDF") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 122;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 123;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.TaxOweAmountPDF") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 124;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 125;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext17.Validate(locations, true, 0) == true)))) {
                expressionId = 126;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalStandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext17.Validate(locations, true, 0) == true)))) {
                expressionId = 127;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalStandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext17_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 128;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext17.Validate(locations, true, 0) == true)))) {
                expressionId = 129;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Constants.TAXABLE_INCOME_ELIGIBILITY_AMOUNT") 
                        && (FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 130;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsTaxableIncomeExceedCheck == true") 
                        && (FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 131;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > TaxableIncomeEligibility" +
                            "Amount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 132;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME]") 
                        && (FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 133;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (FederalSummaryWithNoValidation_TypedDataContext18.Validate(locations, true, 0) == true)))) {
                expressionId = 134;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 135;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 136;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsRefundAvailableCheck == true") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 137;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount > Constants.intZero && (Tax" +
                            "1040Object.TaxesAndPenalties == null || Tax1040Object.TaxesAndPenalties.HasToDep" +
                            "ositTaxRefundsToBankAccount == null)") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 138;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.TAX_AND_WRAP_UP_REQUIRED_REFUND_DETAIL]") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 139;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 140;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 141;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 142;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsIncomeAndRefundAllZeros == true") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 143;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= Constants.intZero && Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits <= Constants.intZero && Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount <= Constants.intZero && Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount <= Constants.intZero") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 144;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.TAX_AND_WRAP_UP_MISSING_INCOME]") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 145;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 146;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 147;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 148;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsSSBAndRRBCheck==true") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 149;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 150;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 151;
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
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new FederalSummaryWithNoValidation_TypedDataContext4(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new FederalSummaryWithNoValidation_TypedDataContext4(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new FederalSummaryWithNoValidation_TypedDataContext4(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new FederalSummaryWithNoValidation_TypedDataContext4(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new FederalSummaryWithNoValidation_TypedDataContext4(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new FederalSummaryWithNoValidation_TypedDataContext4(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new FederalSummaryWithNoValidation_TypedDataContext6(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new FederalSummaryWithNoValidation_TypedDataContext6(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new FederalSummaryWithNoValidation_TypedDataContext6(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new FederalSummaryWithNoValidation_TypedDataContext9(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new FederalSummaryWithNoValidation_TypedDataContext10(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new FederalSummaryWithNoValidation_TypedDataContext10(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new FederalSummaryWithNoValidation_TypedDataContext10(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new FederalSummaryWithNoValidation_TypedDataContext13(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new FederalSummaryWithNoValidation_TypedDataContext13(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new FederalSummaryWithNoValidation_TypedDataContext15(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new FederalSummaryWithNoValidation_TypedDataContext15(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new FederalSummaryWithNoValidation_TypedDataContext15(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new FederalSummaryWithNoValidation_TypedDataContext16(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr109GetTree();
            }
            if ((expressionId == 110)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr110GetTree();
            }
            if ((expressionId == 111)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr111GetTree();
            }
            if ((expressionId == 112)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr112GetTree();
            }
            if ((expressionId == 113)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr113GetTree();
            }
            if ((expressionId == 114)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr114GetTree();
            }
            if ((expressionId == 115)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr115GetTree();
            }
            if ((expressionId == 116)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr116GetTree();
            }
            if ((expressionId == 117)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr117GetTree();
            }
            if ((expressionId == 118)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr118GetTree();
            }
            if ((expressionId == 119)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr119GetTree();
            }
            if ((expressionId == 120)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr120GetTree();
            }
            if ((expressionId == 121)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr121GetTree();
            }
            if ((expressionId == 122)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr122GetTree();
            }
            if ((expressionId == 123)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr123GetTree();
            }
            if ((expressionId == 124)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr124GetTree();
            }
            if ((expressionId == 125)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr125GetTree();
            }
            if ((expressionId == 126)) {
                return new FederalSummaryWithNoValidation_TypedDataContext17(locationReferences).@__Expr126GetTree();
            }
            if ((expressionId == 127)) {
                return new FederalSummaryWithNoValidation_TypedDataContext17(locationReferences).@__Expr127GetTree();
            }
            if ((expressionId == 128)) {
                return new FederalSummaryWithNoValidation_TypedDataContext17_ForReadOnly(locationReferences).@__Expr128GetTree();
            }
            if ((expressionId == 129)) {
                return new FederalSummaryWithNoValidation_TypedDataContext17(locationReferences).@__Expr129GetTree();
            }
            if ((expressionId == 130)) {
                return new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locationReferences).@__Expr130GetTree();
            }
            if ((expressionId == 131)) {
                return new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locationReferences).@__Expr131GetTree();
            }
            if ((expressionId == 132)) {
                return new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locationReferences).@__Expr132GetTree();
            }
            if ((expressionId == 133)) {
                return new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locationReferences).@__Expr133GetTree();
            }
            if ((expressionId == 134)) {
                return new FederalSummaryWithNoValidation_TypedDataContext18(locationReferences).@__Expr134GetTree();
            }
            if ((expressionId == 135)) {
                return new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locationReferences).@__Expr135GetTree();
            }
            if ((expressionId == 136)) {
                return new FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(locationReferences).@__Expr136GetTree();
            }
            if ((expressionId == 137)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr137GetTree();
            }
            if ((expressionId == 138)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr138GetTree();
            }
            if ((expressionId == 139)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr139GetTree();
            }
            if ((expressionId == 140)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr140GetTree();
            }
            if ((expressionId == 141)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr141GetTree();
            }
            if ((expressionId == 142)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr142GetTree();
            }
            if ((expressionId == 143)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr143GetTree();
            }
            if ((expressionId == 144)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr144GetTree();
            }
            if ((expressionId == 145)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr145GetTree();
            }
            if ((expressionId == 146)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr146GetTree();
            }
            if ((expressionId == 147)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr147GetTree();
            }
            if ((expressionId == 148)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr148GetTree();
            }
            if ((expressionId == 149)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr149GetTree();
            }
            if ((expressionId == 150)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr150GetTree();
            }
            if ((expressionId == 151)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr151GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public FederalSummaryWithNoValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class FederalSummaryWithNoValidation_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public FederalSummaryWithNoValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class FederalSummaryWithNoValidation_TypedDataContext1 : FederalSummaryWithNoValidation_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool IsSSBAndRRBCheck;
            
            protected bool IsRefundAvailableCheck;
            
            protected bool IsTaxableIncomeExceedCheck;
            
            protected bool IsIncomeAndRefundAllZeros;
            
            public FederalSummaryWithNoValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                    return ((JTL.Tax1040.Core.Object.ErrorMessages)(this.GetVariableValue((3 + locationsOffset))));
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
            
            protected override void GetValueTypeValues() {
                this.IsSSBAndRRBCheck = ((bool)(this.GetVariableValue((1 + locationsOffset))));
                this.IsRefundAvailableCheck = ((bool)(this.GetVariableValue((2 + locationsOffset))));
                this.IsTaxableIncomeExceedCheck = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                this.IsIncomeAndRefundAllZeros = ((bool)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.IsSSBAndRRBCheck);
                this.SetVariableValue((2 + locationsOffset), this.IsRefundAvailableCheck);
                this.SetVariableValue((4 + locationsOffset), this.IsTaxableIncomeExceedCheck);
                this.SetVariableValue((5 + locationsOffset), this.IsIncomeAndRefundAllZeros);
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
                if (((locationReferences[(offset + 0)].Name != "Tax1040Object") 
                            || (locationReferences[(offset + 0)].Type != typeof(JTL.Tax1040.BusinessObject.Tax1040)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "ErrorMessages") 
                            || (locationReferences[(offset + 3)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessages)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "IsSSBAndRRBCheck") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "IsRefundAvailableCheck") 
                            || (locationReferences[(offset + 2)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "IsTaxableIncomeExceedCheck") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "IsIncomeAndRefundAllZeros") 
                            || (locationReferences[(offset + 5)].Type != typeof(bool)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext1_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool IsSSBAndRRBCheck;
            
            protected bool IsRefundAvailableCheck;
            
            protected bool IsTaxableIncomeExceedCheck;
            
            protected bool IsIncomeAndRefundAllZeros;
            
            public FederalSummaryWithNoValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Tax1040 Tax1040Object {
                get {
                    return ((JTL.Tax1040.BusinessObject.Tax1040)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected JTL.Tax1040.Core.Object.ErrorMessages ErrorMessages {
                get {
                    return ((JTL.Tax1040.Core.Object.ErrorMessages)(this.GetVariableValue((3 + locationsOffset))));
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
                this.IsSSBAndRRBCheck = ((bool)(this.GetVariableValue((1 + locationsOffset))));
                this.IsRefundAvailableCheck = ((bool)(this.GetVariableValue((2 + locationsOffset))));
                this.IsTaxableIncomeExceedCheck = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                this.IsIncomeAndRefundAllZeros = ((bool)(this.GetVariableValue((5 + locationsOffset))));
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
                if (((locationReferences[(offset + 0)].Name != "Tax1040Object") 
                            || (locationReferences[(offset + 0)].Type != typeof(JTL.Tax1040.BusinessObject.Tax1040)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "ErrorMessages") 
                            || (locationReferences[(offset + 3)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessages)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "IsSSBAndRRBCheck") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "IsRefundAvailableCheck") 
                            || (locationReferences[(offset + 2)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "IsTaxableIncomeExceedCheck") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "IsIncomeAndRefundAllZeros") 
                            || (locationReferences[(offset + 5)].Type != typeof(bool)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext2 : FederalSummaryWithNoValidation_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double NonQualifiedPlansAmount;
            
            public FederalSummaryWithNoValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected JTL.Tax1040.Core.Object.ErrorMessage ErrorMessage {
                get {
                    return ((JTL.Tax1040.Core.Object.ErrorMessage)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ErrorMessageList {
                get {
                    return ((System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)(this.GetVariableValue((9 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 93 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.OutputForms>> expression = () => 
                    Tax1040Object.OutputForms;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.OutputForms @__Expr3Get() {
                
                #line 93 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                    Tax1040Object.OutputForms;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.OutputForms ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(JTL.Tax1040.BusinessObject.OutputForms value) {
                
                #line 93 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                    Tax1040Object.OutputForms = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(JTL.Tax1040.BusinessObject.OutputForms value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 105 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040EZPage1>> expression = () => 
                    Tax1040Object.OutputForms.Tax1040EZPage1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 @__Expr5Get() {
                
                #line 105 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                    Tax1040Object.OutputForms.Tax1040EZPage1;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(JTL.Tax1040.BusinessObject.Tax1040EZPage1 value) {
                
                #line 105 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                    Tax1040Object.OutputForms.Tax1040EZPage1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(JTL.Tax1040.BusinessObject.Tax1040EZPage1 value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 501 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr55Get() {
                
                #line 501 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr55Set(double value) {
                
                #line 501 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr55Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr55Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 515 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr56Get() {
                
                #line 515 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr56Set(double value) {
                
                #line 515 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr56Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr56Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 837 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr101Get() {
                
                #line 837 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr101Set(double value) {
                
                #line 837 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr101Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr101Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 851 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr103Get() {
                
                #line 851 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr103Set(double value) {
                
                #line 851 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr103Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr103Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 907 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                              Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr109Get() {
                
                #line 907 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr109Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 907 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr109Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr109Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr111GetTree() {
                
                #line 914 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.PenaltiesAndInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr111Get() {
                
                #line 914 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.PenaltiesAndInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr111Get() {
                this.GetValueTypeValues();
                return this.@__Expr111Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr111Set(double value) {
                
                #line 914 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.PenaltiesAndInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr111Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr111Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr114GetTree() {
                
                #line 938 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr114Get() {
                
                #line 938 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr114Get() {
                this.GetValueTypeValues();
                return this.@__Expr114Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr114Set(double value) {
                
                #line 938 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr114Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr114Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr116GetTree() {
                
                #line 950 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Tax1040Object.OutputForms.TaxOweAmountPDF;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr116Get() {
                
                #line 950 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.TaxOweAmountPDF;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr116Get() {
                this.GetValueTypeValues();
                return this.@__Expr116Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr116Set(string value) {
                
                #line 950 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Tax1040Object.OutputForms.TaxOweAmountPDF = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr116Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr116Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr117GetTree() {
                
                #line 962 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr117Get() {
                
                #line 962 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr117Get() {
                this.GetValueTypeValues();
                return this.@__Expr117Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr117Set(double value) {
                
                #line 962 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr117Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr117Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr119GetTree() {
                
                #line 976 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr119Get() {
                
                #line 976 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr119Get() {
                this.GetValueTypeValues();
                return this.@__Expr119Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr119Set(double value) {
                
                #line 976 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr119Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr119Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr122GetTree() {
                
                #line 995 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.TaxOweAmountPDF;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr122Get() {
                
                #line 995 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                    Tax1040Object.OutputForms.TaxOweAmountPDF;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr122Get() {
                this.GetValueTypeValues();
                return this.@__Expr122Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr122Set(string value) {
                
                #line 995 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                    Tax1040Object.OutputForms.TaxOweAmountPDF = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr122Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr122Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr124GetTree() {
                
                #line 1009 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.TaxOweAmountPDF;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr124Get() {
                
                #line 1009 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                    Tax1040Object.OutputForms.TaxOweAmountPDF;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr124Get() {
                this.GetValueTypeValues();
                return this.@__Expr124Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr124Set(string value) {
                
                #line 1009 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                    Tax1040Object.OutputForms.TaxOweAmountPDF = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr124Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr124Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr125GetTree() {
                
                #line 1023 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr125Get() {
                
                #line 1023 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr125Get() {
                this.GetValueTypeValues();
                return this.@__Expr125Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr125Set(double value) {
                
                #line 1023 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr125Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr125Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr140GetTree() {
                
                #line 1141 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                            ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr140Get() {
                
                #line 1141 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr140Get() {
                this.GetValueTypeValues();
                return this.@__Expr140Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr140Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 1141 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr140Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr140Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr146GetTree() {
                
                #line 1183 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                            ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr146Get() {
                
                #line 1183 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr146Get() {
                this.GetValueTypeValues();
                return this.@__Expr146Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr146Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 1183 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr146Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr146Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr150GetTree() {
                
                #line 1222 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                      Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr150Get() {
                
                #line 1222 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr150Get() {
                this.GetValueTypeValues();
                return this.@__Expr150Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr150Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 1222 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                      Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr150Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr150Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.NonQualifiedPlansAmount = ((double)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((7 + locationsOffset), this.NonQualifiedPlansAmount);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                if (((locationReferences[(offset + 6)].Name != "Form1099OID") 
                            || (locationReferences[(offset + 6)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "ErrorMessage") 
                            || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "ErrorMessageList") 
                            || (locationReferences[(offset + 9)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "NonQualifiedPlansAmount") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double NonQualifiedPlansAmount;
            
            public FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected JTL.Tax1040.Core.Object.ErrorMessage ErrorMessage {
                get {
                    return ((JTL.Tax1040.Core.Object.ErrorMessage)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ErrorMessageList {
                get {
                    return ((System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)(this.GetVariableValue((9 + locationsOffset))));
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
                
                #line 76 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
          Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr0Get() {
                
                #line 76 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
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
                
                #line 83 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          Tax1040Object !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 83 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
          Tax1040Object !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 98 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.OutputForms>> expression = () => 
                    new OutputForms();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.OutputForms @__Expr2Get() {
                
                #line 98 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                    new OutputForms();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.OutputForms ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 110 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040EZPage1>> expression = () => 
                    new Tax1040EZPage1();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 @__Expr4Get() {
                
                #line 110 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                    new Tax1040EZPage1();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 118 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.Income !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 118 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                  Tax1040Object.Income !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 494 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome > Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr53Get() {
                
                #line 494 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome > Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 506 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome - Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr54Get() {
                
                #line 506 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome - Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 830 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.TaxesAndPenalties != null && Tax1040Object.TaxesAndPenalties.FederalExtensionAmount != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr99Get() {
                
                #line 830 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.TaxesAndPenalties != null && Tax1040Object.TaxesAndPenalties.FederalExtensionAmount != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 842 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              (Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.HasValue ? Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.Value : 0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr100Get() {
                
                #line 842 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              (Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.HasValue ? Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.Value : 0);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 856 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount + Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit+ Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr102Get() {
                
                #line 856 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount + Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit+ Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 899 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.TaxesAndPenalties != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr108Get() {
                
                #line 899 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.TaxesAndPenalties != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr110GetTree() {
                
                #line 919 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest.HasValue ? Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest.Value : 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr110Get() {
                
                #line 919 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest.HasValue ? Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest.Value : 0;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr110Get() {
                this.GetValueTypeValues();
                return this.@__Expr110Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr112GetTree() {
                
                #line 930 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits > Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr112Get() {
                
                #line 930 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits > Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr112Get() {
                this.GetValueTypeValues();
                return this.@__Expr112Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 943 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits - Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr113Get() {
                
                #line 943 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits - Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr113Get() {
                this.GetValueTypeValues();
                return this.@__Expr113Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 955 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr115Get() {
                
                #line 955 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr118GetTree() {
                
                #line 981 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr118Get() {
                
                #line 981 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr118Get() {
                this.GetValueTypeValues();
                return this.@__Expr118Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr120GetTree() {
                
                #line 988 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount >0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr120Get() {
                
                #line 988 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount >0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr120Get() {
                this.GetValueTypeValues();
                return this.@__Expr120Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr121GetTree() {
                
                #line 1000 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    "Total Line 12 $" + Math.Round(Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr121Get() {
                
                #line 1000 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                    "Total Line 12 $" + Math.Round(Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr121Get() {
                this.GetValueTypeValues();
                return this.@__Expr121Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr123GetTree() {
                
                #line 1014 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr123Get() {
                
                #line 1014 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                    string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr123Get() {
                this.GetValueTypeValues();
                return this.@__Expr123Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr137GetTree() {
                
                #line 1126 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  IsRefundAvailableCheck == true;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr137Get() {
                
                #line 1126 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                  IsRefundAvailableCheck == true;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr137Get() {
                this.GetValueTypeValues();
                return this.@__Expr137Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr138GetTree() {
                
                #line 1133 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount > Constants.intZero && (Tax1040Object.TaxesAndPenalties == null || Tax1040Object.TaxesAndPenalties.HasToDepositTaxRefundsToBankAccount == null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr138Get() {
                
                #line 1133 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount > Constants.intZero && (Tax1040Object.TaxesAndPenalties == null || Tax1040Object.TaxesAndPenalties.HasToDepositTaxRefundsToBankAccount == null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr138Get() {
                this.GetValueTypeValues();
                return this.@__Expr138Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr139GetTree() {
                
                #line 1146 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                            ErrorMessages[Constants.TAX_AND_WRAP_UP_REQUIRED_REFUND_DETAIL];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr139Get() {
                
                #line 1146 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            ErrorMessages[Constants.TAX_AND_WRAP_UP_REQUIRED_REFUND_DETAIL];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr139Get() {
                this.GetValueTypeValues();
                return this.@__Expr139Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr141GetTree() {
                
                #line 1157 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                          ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr141Get() {
                
                #line 1157 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr141Get() {
                this.GetValueTypeValues();
                return this.@__Expr141Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr142GetTree() {
                
                #line 1153 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                            ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr142Get() {
                
                #line 1153 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr142Get() {
                this.GetValueTypeValues();
                return this.@__Expr142Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr143GetTree() {
                
                #line 1168 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  IsIncomeAndRefundAllZeros == true;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr143Get() {
                
                #line 1168 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                  IsIncomeAndRefundAllZeros == true;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr143Get() {
                this.GetValueTypeValues();
                return this.@__Expr143Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr144GetTree() {
                
                #line 1175 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= Constants.intZero && Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits <= Constants.intZero && Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount <= Constants.intZero && Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount <= Constants.intZero;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr144Get() {
                
                #line 1175 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= Constants.intZero && Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits <= Constants.intZero && Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount <= Constants.intZero && Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount <= Constants.intZero;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr144Get() {
                this.GetValueTypeValues();
                return this.@__Expr144Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr145GetTree() {
                
                #line 1188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                            ErrorMessages[Constants.TAX_AND_WRAP_UP_MISSING_INCOME];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr145Get() {
                
                #line 1188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            ErrorMessages[Constants.TAX_AND_WRAP_UP_MISSING_INCOME];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr145Get() {
                this.GetValueTypeValues();
                return this.@__Expr145Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr147GetTree() {
                
                #line 1199 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                          ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr147Get() {
                
                #line 1199 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr147Get() {
                this.GetValueTypeValues();
                return this.@__Expr147Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr148GetTree() {
                
                #line 1195 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                            ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr148Get() {
                
                #line 1195 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr148Get() {
                this.GetValueTypeValues();
                return this.@__Expr148Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr149GetTree() {
                
                #line 1210 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  IsSSBAndRRBCheck==true;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr149Get() {
                
                #line 1210 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                  IsSSBAndRRBCheck==true;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr149Get() {
                this.GetValueTypeValues();
                return this.@__Expr149Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr151GetTree() {
                
                #line 1217 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                      ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr151Get() {
                
                #line 1217 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                      ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr151Get() {
                this.GetValueTypeValues();
                return this.@__Expr151Get();
            }
            
            protected override void GetValueTypeValues() {
                this.NonQualifiedPlansAmount = ((double)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                if (((locationReferences[(offset + 6)].Name != "Form1099OID") 
                            || (locationReferences[(offset + 6)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "ErrorMessage") 
                            || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "ErrorMessageList") 
                            || (locationReferences[(offset + 9)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "NonQualifiedPlansAmount") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext3 : FederalSummaryWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public FederalSummaryWithNoValidation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.W2 W2 {
                get {
                    return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((10 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((10 + locationsOffset), value);
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
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                if (((locationReferences[(offset + 10)].Name != "W2") 
                            || (locationReferences[(offset + 10)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.W2 W2 {
                get {
                    return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((10 + locationsOffset))));
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
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          ((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr7Get() {
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          ((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
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
                if (((locationReferences[(offset + 10)].Name != "W2") 
                            || (locationReferences[(offset + 10)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext4 : FederalSummaryWithNoValidation_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWages;
            
            public FederalSummaryWithNoValidation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string WagesPrefix {
                get {
                    return ((string)(this.GetVariableValue((12 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((12 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr8Get() {
                
                #line 152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 157 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr9Get() {
                
                #line 157 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(double value) {
                
                #line 157 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr10Get() {
                
                #line 147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(string value) {
                
                #line 147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                NonQualifiedPlansAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr11Get() {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                NonQualifiedPlansAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(double value) {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                NonQualifiedPlansAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 164 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr13Get() {
                
                #line 164 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(double value) {
                
                #line 164 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 176 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 176 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(string value) {
                
                #line 176 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalWages = ((double)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((11 + locationsOffset), this.TotalWages);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 12)].Name != "WagesPrefix") 
                            || (locationReferences[(offset + 12)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "TotalWages") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWages;
            
            public FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string WagesPrefix {
                get {
                    return ((string)(this.GetVariableValue((12 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 169 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr12Get() {
                
                #line 169 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 181 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 181 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalWages = ((double)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 12)].Name != "WagesPrefix") 
                            || (locationReferences[(offset + 12)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "TotalWages") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext5 : FederalSummaryWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Totol1099OIDAmount;
            
            protected double Form1099INTTotal;
            
            protected double Form1099OIDTotal;
            
            protected double F1099INTTaxExemptInterest;
            
            protected double F1099OIDTaxExemptInterest;
            
            protected double TotalWages;
            
            public FederalSummaryWithNoValidation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099INT Form1099INT {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((10 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((10 + locationsOffset), value);
                }
            }
            
            protected string TEIPrefix {
                get {
                    return ((string)(this.GetVariableValue((17 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((17 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 252 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr21Get() {
                
                #line 252 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(double value) {
                
                #line 252 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                F1099OIDTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 242 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr22Get() {
                
                #line 242 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
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
                
                #line 242 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
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
                
                #line 247 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Form1099OIDTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr23Get() {
                
                #line 247 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Form1099OIDTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(double value) {
                
                #line 247 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Form1099OIDTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 262 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr25Get() {
                
                #line 262 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(double value) {
                
                #line 262 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 274 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TEI;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr27Get() {
                
                #line 274 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TEI;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(double value) {
                
                #line 274 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.OutputForms.Tax1040EZPage1.TEI = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 293 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 293 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(string value) {
                
                #line 293 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 307 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr32Get() {
                
                #line 307 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(string value) {
                
                #line 307 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Totol1099OIDAmount = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((12 + locationsOffset))));
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((15 + locationsOffset))));
                this.TotalWages = ((double)(this.GetVariableValue((16 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((11 + locationsOffset), this.Totol1099OIDAmount);
                this.SetVariableValue((12 + locationsOffset), this.Form1099INTTotal);
                this.SetVariableValue((13 + locationsOffset), this.Form1099OIDTotal);
                this.SetVariableValue((14 + locationsOffset), this.F1099INTTaxExemptInterest);
                this.SetVariableValue((15 + locationsOffset), this.F1099OIDTaxExemptInterest);
                this.SetVariableValue((16 + locationsOffset), this.TotalWages);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                if (((locationReferences[(offset + 10)].Name != "Form1099INT") 
                            || (locationReferences[(offset + 10)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "TEIPrefix") 
                            || (locationReferences[(offset + 17)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Totol1099OIDAmount") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "TotalWages") 
                            || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Totol1099OIDAmount;
            
            protected double Form1099INTTotal;
            
            protected double Form1099OIDTotal;
            
            protected double F1099INTTaxExemptInterest;
            
            protected double F1099OIDTaxExemptInterest;
            
            protected double TotalWages;
            
            public FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099INT Form1099INT {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((10 + locationsOffset))));
                }
            }
            
            protected string TEIPrefix {
                get {
                    return ((string)(this.GetVariableValue((17 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 203 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          ((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr16Get() {
                
                #line 203 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          ((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 234 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          ((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr20Get() {
                
                #line 234 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          ((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 267 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099INTTotal + Form1099OIDTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr24Get() {
                
                #line 267 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Form1099INTTotal + Form1099OIDTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 279 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          F1099INTTaxExemptInterest + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr26Get() {
                
                #line 279 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          F1099INTTaxExemptInterest + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 286 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TEI != null && Tax1040Object.OutputForms.Tax1040EZPage1.TEI > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr28Get() {
                
                #line 286 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TEI != null && Tax1040Object.OutputForms.Tax1040EZPage1.TEI > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 298 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              TEIPrefix + Tax1040Object.OutputForms.Tax1040EZPage1.TEI.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 298 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              TEIPrefix + Tax1040Object.OutputForms.Tax1040EZPage1.TEI.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 312 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr31Get() {
                
                #line 312 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Totol1099OIDAmount = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((12 + locationsOffset))));
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((15 + locationsOffset))));
                this.TotalWages = ((double)(this.GetVariableValue((16 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                if (((locationReferences[(offset + 10)].Name != "Form1099INT") 
                            || (locationReferences[(offset + 10)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "TEIPrefix") 
                            || (locationReferences[(offset + 17)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Totol1099OIDAmount") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "TotalWages") 
                            || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext6 : FederalSummaryWithNoValidation_TypedDataContext5 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Total1099INTAmount;
            
            public FederalSummaryWithNoValidation_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr17Get() {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
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
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
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
                
                #line 224 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr18Get() {
                
                #line 224 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(double value) {
                
                #line 224 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                F1099INTTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 219 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Form1099INTTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr19Get() {
                
                #line 219 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Form1099INTTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(double value) {
                
                #line 219 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Form1099INTTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Total1099INTAmount = ((double)(this.GetVariableValue((18 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((18 + locationsOffset), this.Total1099INTAmount);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                if (((locationReferences[(offset + 18)].Name != "Total1099INTAmount") 
                            || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext5.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext6_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Total1099INTAmount;
            
            public FederalSummaryWithNoValidation_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.Total1099INTAmount = ((double)(this.GetVariableValue((18 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                if (((locationReferences[(offset + 18)].Name != "Total1099INTAmount") 
                            || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext7 : FederalSummaryWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double AlaskaPermanantFundAmount;
            
            protected double UnemploymentAmount;
            
            public FederalSummaryWithNoValidation_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099G Form1099G {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((10 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((10 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 418 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                    Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr43Get() {
                
                #line 418 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                    Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 418 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                    Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr44Get() {
                
                #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                    AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr44Set(double value) {
                
                #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                    AlaskaPermanantFundAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr44Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr44Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 430 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr46Get() {
                
                #line 430 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr46Set(double value) {
                
                #line 430 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr46Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr46Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.AlaskaPermanantFundAmount = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.UnemploymentAmount = ((double)(this.GetVariableValue((12 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((11 + locationsOffset), this.AlaskaPermanantFundAmount);
                this.SetVariableValue((12 + locationsOffset), this.UnemploymentAmount);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 10)].Name != "Form1099G") 
                            || (locationReferences[(offset + 10)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "AlaskaPermanantFundAmount") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "UnemploymentAmount") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double AlaskaPermanantFundAmount;
            
            protected double UnemploymentAmount;
            
            public FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099G Form1099G {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((10 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 328 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          ((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr33Get() {
                
                #line 328 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          ((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 398 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr41Get() {
                
                #line 398 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 405 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr42Get() {
                
                #line 405 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.Value;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 435 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          UnemploymentAmount + AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr45Get() {
                
                #line 435 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          UnemploymentAmount + AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            protected override void GetValueTypeValues() {
                this.AlaskaPermanantFundAmount = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.UnemploymentAmount = ((double)(this.GetVariableValue((12 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 10)].Name != "Form1099G") 
                            || (locationReferences[(offset + 10)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "AlaskaPermanantFundAmount") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "UnemploymentAmount") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext8 : FederalSummaryWithNoValidation_TypedDataContext7 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalUnemploymentCompensationAmount;
            
            protected double TotalRepaid;
            
            public FederalSummaryWithNoValidation_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string RepaidPrefix {
                get {
                    return ((string)(this.GetVariableValue((15 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((15 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 342 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                  Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr34Get() {
                
                #line 342 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 342 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                  Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 352 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  UnemploymentAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr35Get() {
                
                #line 352 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  UnemploymentAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(double value) {
                
                #line 352 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                  UnemploymentAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 347 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  TotalRepaid;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr36Get() {
                
                #line 347 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  TotalRepaid;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr36Set(double value) {
                
                #line 347 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                  TotalRepaid = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 366 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr39Get() {
                
                #line 366 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                      Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(string value) {
                
                #line 366 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                      Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 380 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr40Get() {
                
                #line 380 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                      Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr40Set(string value) {
                
                #line 380 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                      Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr40Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr40Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalUnemploymentCompensationAmount = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.TotalRepaid = ((double)(this.GetVariableValue((14 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((13 + locationsOffset), this.TotalUnemploymentCompensationAmount);
                this.SetVariableValue((14 + locationsOffset), this.TotalRepaid);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 16))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 16);
                }
                expectedLocationsCount = 16;
                if (((locationReferences[(offset + 15)].Name != "RepaidPrefix") 
                            || (locationReferences[(offset + 15)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "TotalUnemploymentCompensationAmount") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "TotalRepaid") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext7.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalUnemploymentCompensationAmount;
            
            protected double TotalRepaid;
            
            public FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string RepaidPrefix {
                get {
                    return ((string)(this.GetVariableValue((15 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 359 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  TotalRepaid!=null&&TotalRepaid>0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr37Get() {
                
                #line 359 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  TotalRepaid!=null&&TotalRepaid>0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 371 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      RepaidPrefix+TotalRepaid.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr38Get() {
                
                #line 371 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                      RepaidPrefix+TotalRepaid.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalUnemploymentCompensationAmount = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.TotalRepaid = ((double)(this.GetVariableValue((14 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 16))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 16);
                }
                expectedLocationsCount = 16;
                if (((locationReferences[(offset + 15)].Name != "RepaidPrefix") 
                            || (locationReferences[(offset + 15)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "TotalUnemploymentCompensationAmount") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "TotalRepaid") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext9 : FederalSummaryWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalAdjustedGrossIncome;
            
            public FederalSummaryWithNoValidation_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext9(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 448 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr48Get() {
                
                #line 448 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr48Set(double value) {
                
                #line 448 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr48Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr48Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalAdjustedGrossIncome = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.TotalAdjustedGrossIncome);
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
                if (((locationReferences[(offset + 10)].Name != "TotalAdjustedGrossIncome") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalAdjustedGrossIncome;
            
            public FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 453 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr47Get() {
                
                #line 453 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalAdjustedGrossIncome = ((double)(this.GetVariableValue((10 + locationsOffset))));
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
                if (((locationReferences[(offset + 10)].Name != "TotalAdjustedGrossIncome") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext10 : FederalSummaryWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalStandardDeduction;
            
            public FederalSummaryWithNoValidation_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext10(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 467 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                            Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr49Get() {
                
                #line 467 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr49Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 467 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr49Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr49Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 472 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            TotalStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr50Get() {
                
                #line 472 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            TotalStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr50Set(double value) {
                
                #line 472 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            TotalStandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr50Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr50Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 479 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr52Get() {
                
                #line 479 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr52Set(double value) {
                
                #line 479 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr52Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr52Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalStandardDeduction = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.TotalStandardDeduction);
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
                if (((locationReferences[(offset + 10)].Name != "TotalStandardDeduction") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalStandardDeduction;
            
            public FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 484 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            TotalStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr51Get() {
                
                #line 484 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            TotalStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalStandardDeduction = ((double)(this.GetVariableValue((10 + locationsOffset))));
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
                if (((locationReferences[(offset + 10)].Name != "TotalStandardDeduction") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext11 : FederalSummaryWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double W2FederalTaxWithholdTotal;
            
            protected double Form1099INTFederalTaxWithholdTotal;
            
            protected double Form1099OIDFederalTaxWithholdTotal;
            
            protected double Form1099GFederalTaxWithholdTotal;
            
            public FederalSummaryWithNoValidation_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext11(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.W2FederalTaxWithholdTotal = ((double)(this.GetVariableValue((10 + locationsOffset))));
                this.Form1099INTFederalTaxWithholdTotal = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.Form1099OIDFederalTaxWithholdTotal = ((double)(this.GetVariableValue((12 + locationsOffset))));
                this.Form1099GFederalTaxWithholdTotal = ((double)(this.GetVariableValue((13 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.W2FederalTaxWithholdTotal);
                this.SetVariableValue((11 + locationsOffset), this.Form1099INTFederalTaxWithholdTotal);
                this.SetVariableValue((12 + locationsOffset), this.Form1099OIDFederalTaxWithholdTotal);
                this.SetVariableValue((13 + locationsOffset), this.Form1099GFederalTaxWithholdTotal);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 14))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 14);
                }
                expectedLocationsCount = 14;
                if (((locationReferences[(offset + 10)].Name != "W2FederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Form1099INTFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "Form1099OIDFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Form1099GFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext11_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double W2FederalTaxWithholdTotal;
            
            protected double Form1099INTFederalTaxWithholdTotal;
            
            protected double Form1099OIDFederalTaxWithholdTotal;
            
            protected double Form1099GFederalTaxWithholdTotal;
            
            public FederalSummaryWithNoValidation_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.W2FederalTaxWithholdTotal = ((double)(this.GetVariableValue((10 + locationsOffset))));
                this.Form1099INTFederalTaxWithholdTotal = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.Form1099OIDFederalTaxWithholdTotal = ((double)(this.GetVariableValue((12 + locationsOffset))));
                this.Form1099GFederalTaxWithholdTotal = ((double)(this.GetVariableValue((13 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 14))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 14);
                }
                expectedLocationsCount = 14;
                if (((locationReferences[(offset + 10)].Name != "W2FederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Form1099INTFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "Form1099OIDFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Form1099GFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext12 : FederalSummaryWithNoValidation_TypedDataContext11 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double FSSBFederalTaxWithHoldingTotal;
            
            protected double FRRBFederalTaxWithHoldingTotal;
            
            public FederalSummaryWithNoValidation_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext12(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 540 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                            Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr57Get() {
                
                #line 540 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr57Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 540 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr57Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr57Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 545 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            W2FederalTaxWithholdTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr58Get() {
                
                #line 545 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            W2FederalTaxWithholdTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr58Set(double value) {
                
                #line 545 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            W2FederalTaxWithholdTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr58Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr58Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 552 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                            Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr59Get() {
                
                #line 552 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 552 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 557 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Form1099INTFederalTaxWithholdTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr60Get() {
                
                #line 557 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Form1099INTFederalTaxWithholdTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr60Set(double value) {
                
                #line 557 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Form1099INTFederalTaxWithholdTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr60Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr60Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 564 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                            Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr61Get() {
                
                #line 564 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
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
                
                #line 564 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
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
                
                #line 569 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Form1099OIDFederalTaxWithholdTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr62Get() {
                
                #line 569 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Form1099OIDFederalTaxWithholdTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr62Set(double value) {
                
                #line 569 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Form1099OIDFederalTaxWithholdTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr62Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr62Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 581 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Form1099GFederalTaxWithholdTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr63Get() {
                
                #line 581 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Form1099GFederalTaxWithholdTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr63Set(double value) {
                
                #line 581 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Form1099GFederalTaxWithholdTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr63Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr63Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 576 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                            Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr64Get() {
                
                #line 576 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr64Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 576 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr64Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr64Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 588 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                            Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr65Get() {
                
                #line 588 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr65Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 588 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr65Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr65Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 593 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            FSSBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr66Get() {
                
                #line 593 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            FSSBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr66Set(double value) {
                
                #line 593 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            FSSBFederalTaxWithHoldingTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr66Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr66Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 605 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            FRRBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr67Get() {
                
                #line 605 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            FRRBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr67Set(double value) {
                
                #line 605 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            FRRBFederalTaxWithHoldingTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr67Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr67Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 600 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                            Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr68Get() {
                
                #line 600 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr68Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 600 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr68Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr68Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 612 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr70Get() {
                
                #line 612 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr70Set(double value) {
                
                #line 612 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr70Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr70Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.FSSBFederalTaxWithHoldingTotal = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.FRRBFederalTaxWithHoldingTotal = ((double)(this.GetVariableValue((15 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((14 + locationsOffset), this.FSSBFederalTaxWithHoldingTotal);
                this.SetVariableValue((15 + locationsOffset), this.FRRBFederalTaxWithHoldingTotal);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 16))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 16);
                }
                expectedLocationsCount = 16;
                if (((locationReferences[(offset + 14)].Name != "FSSBFederalTaxWithHoldingTotal") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "FRRBFederalTaxWithHoldingTotal") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext11.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext11_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double FSSBFederalTaxWithHoldingTotal;
            
            protected double FRRBFederalTaxWithHoldingTotal;
            
            public FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 617 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            W2FederalTaxWithholdTotal + Form1099INTFederalTaxWithholdTotal + Form1099OIDFederalTaxWithholdTotal + Form1099GFederalTaxWithholdTotal + FSSBFederalTaxWithHoldingTotal + FRRBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr69Get() {
                
                #line 617 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            W2FederalTaxWithholdTotal + Form1099INTFederalTaxWithholdTotal + Form1099OIDFederalTaxWithholdTotal + Form1099GFederalTaxWithholdTotal + FSSBFederalTaxWithHoldingTotal + FRRBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            protected override void GetValueTypeValues() {
                this.FSSBFederalTaxWithHoldingTotal = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.FRRBFederalTaxWithHoldingTotal = ((double)(this.GetVariableValue((15 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 16))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 16);
                }
                expectedLocationsCount = 16;
                if (((locationReferences[(offset + 14)].Name != "FSSBFederalTaxWithHoldingTotal") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "FRRBFederalTaxWithHoldingTotal") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext11_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext13 : FederalSummaryWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalEarnedIncomeCredit;
            
            protected bool HasEarnedIncomeCredit;
            
            public FederalSummaryWithNoValidation_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext13(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.IEnumerable<JTL.Tax1040.Core.Object.ErrorMessage> listErrorMessage {
                get {
                    return ((System.Collections.Generic.IEnumerable<JTL.Tax1040.Core.Object.ErrorMessage>)(this.GetVariableValue((11 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr71Get() {
                
                #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr71Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr71Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr71Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 637 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          HasEarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr72Get() {
                
                #line 637 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          HasEarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr72Set(bool value) {
                
                #line 637 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          HasEarnedIncomeCredit = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr72Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr72Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalEarnedIncomeCredit = ((double)(this.GetVariableValue((10 + locationsOffset))));
                this.HasEarnedIncomeCredit = ((bool)(this.GetVariableValue((12 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.TotalEarnedIncomeCredit);
                this.SetVariableValue((12 + locationsOffset), this.HasEarnedIncomeCredit);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 11)].Name != "listErrorMessage") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.Collections.Generic.IEnumerable<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TotalEarnedIncomeCredit") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "HasEarnedIncomeCredit") 
                            || (locationReferences[(offset + 12)].Type != typeof(bool)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalEarnedIncomeCredit;
            
            protected bool HasEarnedIncomeCredit;
            
            public FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.IEnumerable<JTL.Tax1040.Core.Object.ErrorMessage> listErrorMessage {
                get {
                    return ((System.Collections.Generic.IEnumerable<JTL.Tax1040.Core.Object.ErrorMessage>)(this.GetVariableValue((11 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 632 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr73Get() {
                
                #line 632 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 649 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          HasEarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr74Get() {
                
                #line 649 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          HasEarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalEarnedIncomeCredit = ((double)(this.GetVariableValue((10 + locationsOffset))));
                this.HasEarnedIncomeCredit = ((bool)(this.GetVariableValue((12 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 11)].Name != "listErrorMessage") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.Collections.Generic.IEnumerable<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TotalEarnedIncomeCredit") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "HasEarnedIncomeCredit") 
                            || (locationReferences[(offset + 12)].Type != typeof(bool)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext14 : FederalSummaryWithNoValidation_TypedDataContext13 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public FederalSummaryWithNoValidation_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext14(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string Prefix1040EZLine1 {
                get {
                    return ((string)(this.GetVariableValue((13 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((13 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 660 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr75Get() {
                
                #line 660 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr75Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 660 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr75Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr75Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 665 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                TotalEarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr76Get() {
                
                #line 665 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                TotalEarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr76Set(double value) {
                
                #line 665 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                TotalEarnedIncomeCredit = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr76Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr76Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 672 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr78Get() {
                
                #line 672 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr78Set(double value) {
                
                #line 672 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr78Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr78Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 684 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr80Get() {
                
                #line 684 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr80Set(string value) {
                
                #line 684 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr80Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr80Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 710 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr84Get() {
                
                #line 710 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                        Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr84Set(string value) {
                
                #line 710 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                        Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr84Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr84Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 724 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr86Get() {
                
                #line 724 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                        Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr86Set(string value) {
                
                #line 724 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                        Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr86Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr86Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 754 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr90Get() {
                
                #line 754 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                        Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr90Set(string value) {
                
                #line 754 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                        Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr90Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr90Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 768 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr92Get() {
                
                #line 768 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                        Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr92Set(string value) {
                
                #line 768 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                        Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr92Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr92Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr94GetTree() {
                
                #line 784 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr94Get() {
                
                #line 784 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr94Set(string value) {
                
                #line 784 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr94Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr94Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 14))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 14);
                }
                expectedLocationsCount = 14;
                if (((locationReferences[(offset + 13)].Name != "Prefix1040EZLine1") 
                            || (locationReferences[(offset + 13)].Type != typeof(string)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext13.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string Prefix1040EZLine1 {
                get {
                    return ((string)(this.GetVariableValue((13 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 677 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                TotalEarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr77Get() {
                
                #line 677 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                TotalEarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 689 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr79Get() {
                
                #line 689 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 696 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                NonQualifiedPlansAmount > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr81Get() {
                
                #line 696 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                NonQualifiedPlansAmount > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 703 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Utilities.IsStringEmpty(Prefix1040EZLine1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr82Get() {
                
                #line 703 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                    Utilities.IsStringEmpty(Prefix1040EZLine1);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 715 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        "DFC $" + NonQualifiedPlansAmount.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr83Get() {
                
                #line 715 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                        "DFC $" + NonQualifiedPlansAmount.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 729 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Prefix1040EZLine1 + ",DFC $" + NonQualifiedPlansAmount.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr85Get() {
                
                #line 729 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                        Prefix1040EZLine1 + ",DFC $" + NonQualifiedPlansAmount.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 740 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                (Tax1040Object.Credits!=null) && (Tax1040Object.Credits.EIC!=null) && (Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.HasValue) &&(Tax1040Object.Credits.EIC.PenalInstitutionInmateWages > 0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr87Get() {
                
                #line 740 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                (Tax1040Object.Credits!=null) && (Tax1040Object.Credits.EIC!=null) && (Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.HasValue) &&(Tax1040Object.Credits.EIC.PenalInstitutionInmateWages > 0);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 747 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Utilities.IsStringEmpty(Prefix1040EZLine1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr88Get() {
                
                #line 747 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                    Utilities.IsStringEmpty(Prefix1040EZLine1);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 759 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        "PRI $" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr89Get() {
                
                #line 759 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                        "PRI $" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 773 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Prefix1040EZLine1 + ",PRI $" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr91Get() {
                
                #line 773 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                        Prefix1040EZLine1 + ",PRI $" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 789 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr93Get() {
                
                #line 789 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 14))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 14);
                }
                expectedLocationsCount = 14;
                if (((locationReferences[(offset + 13)].Name != "Prefix1040EZLine1") 
                            || (locationReferences[(offset + 13)].Type != typeof(string)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext15 : FederalSummaryWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double NonTaxableCombatPayElectionTotal;
            
            public FederalSummaryWithNoValidation_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext15(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 804 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr95Get() {
                
                #line 804 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr95Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 804 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr95Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr95Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 809 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          NonTaxableCombatPayElectionTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr96Get() {
                
                #line 809 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          NonTaxableCombatPayElectionTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr96Set(double value) {
                
                #line 809 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          NonTaxableCombatPayElectionTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr96Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr96Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 816 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr98Get() {
                
                #line 816 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr98Set(double value) {
                
                #line 816 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr98Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr98Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.NonTaxableCombatPayElectionTotal = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.NonTaxableCombatPayElectionTotal);
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
                if (((locationReferences[(offset + 10)].Name != "NonTaxableCombatPayElectionTotal") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double NonTaxableCombatPayElectionTotal;
            
            public FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 821 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          NonTaxableCombatPayElectionTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr97Get() {
                
                #line 821 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          NonTaxableCombatPayElectionTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            protected override void GetValueTypeValues() {
                this.NonTaxableCombatPayElectionTotal = ((double)(this.GetVariableValue((10 + locationsOffset))));
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
                if (((locationReferences[(offset + 10)].Name != "NonTaxableCombatPayElectionTotal") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext16 : FederalSummaryWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TaxAmountTotal;
            
            public FederalSummaryWithNoValidation_TypedDataContext16(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext16(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext16(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 882 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr107Get() {
                
                #line 882 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr107Set(double value) {
                
                #line 882 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                  Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr107Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr107Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TaxAmountTotal = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.TaxAmountTotal);
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
                if (((locationReferences[(offset + 10)].Name != "TaxAmountTotal") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TaxAmountTotal;
            
            public FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 868 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.PersonalDetails != null && Tax1040Object.PersonalDetails.PrimaryTaxPayer != null && Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr104Get() {
                
                #line 868 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.PersonalDetails != null && Tax1040Object.PersonalDetails.PrimaryTaxPayer != null && Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 875 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.OutputForms != null && Tax1040Object.OutputForms.Tax1040EZPage1 != null && Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr105Get() {
                
                #line 875 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms != null && Tax1040Object.OutputForms.Tax1040EZPage1 != null && Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 887 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  JTL.Tax1040.Core.Process.TaxRateCalculation.TaxCalculation(Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus, Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr106Get() {
                
                #line 887 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  JTL.Tax1040.Core.Process.TaxRateCalculation.TaxCalculation(Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus, Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr106Get() {
                this.GetValueTypeValues();
                return this.@__Expr106Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TaxAmountTotal = ((double)(this.GetVariableValue((10 + locationsOffset))));
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
                if (((locationReferences[(offset + 10)].Name != "TaxAmountTotal") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext17 : FederalSummaryWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalStandardDeduction;
            
            public FederalSummaryWithNoValidation_TypedDataContext17(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext17(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext17(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr126GetTree() {
                
                #line 1045 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr126Get() {
                
                #line 1045 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr126Get() {
                this.GetValueTypeValues();
                return this.@__Expr126Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr126Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 1045 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr126Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr126Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr127GetTree() {
                
                #line 1050 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          TotalStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr127Get() {
                
                #line 1050 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          TotalStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr127Get() {
                this.GetValueTypeValues();
                return this.@__Expr127Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr127Set(double value) {
                
                #line 1050 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          TotalStandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr127Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr127Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr129GetTree() {
                
                #line 1057 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr129Get() {
                
                #line 1057 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr129Get() {
                this.GetValueTypeValues();
                return this.@__Expr129Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr129Set(double value) {
                
                #line 1057 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr129Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr129Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalStandardDeduction = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.TotalStandardDeduction);
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
                if (((locationReferences[(offset + 10)].Name != "TotalStandardDeduction") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext17_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalStandardDeduction;
            
            public FederalSummaryWithNoValidation_TypedDataContext17_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext17_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext17_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr128GetTree() {
                
                #line 1062 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          TotalStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr128Get() {
                
                #line 1062 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          TotalStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr128Get() {
                this.GetValueTypeValues();
                return this.@__Expr128Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalStandardDeduction = ((double)(this.GetVariableValue((10 + locationsOffset))));
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
                if (((locationReferences[(offset + 10)].Name != "TotalStandardDeduction") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext18 : FederalSummaryWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TaxableIncomeEligibilityAmount;
            
            public FederalSummaryWithNoValidation_TypedDataContext18(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext18(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext18(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr134GetTree() {
                
                #line 1098 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr134Get() {
                
                #line 1098 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr134Get() {
                this.GetValueTypeValues();
                return this.@__Expr134Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr134Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 1098 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr134Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr134Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TaxableIncomeEligibilityAmount = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.TaxableIncomeEligibilityAmount);
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
                if (((locationReferences[(offset + 10)].Name != "TaxableIncomeEligibilityAmount") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly : FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TaxableIncomeEligibilityAmount;
            
            public FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FederalSummaryWithNoValidation_TypedDataContext18_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr130GetTree() {
                
                #line 1076 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Constants.TAXABLE_INCOME_ELIGIBILITY_AMOUNT;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr130Get() {
                
                #line 1076 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                    Constants.TAXABLE_INCOME_ELIGIBILITY_AMOUNT;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr130Get() {
                this.GetValueTypeValues();
                return this.@__Expr130Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr131GetTree() {
                
                #line 1083 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    IsTaxableIncomeExceedCheck == true;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr131Get() {
                
                #line 1083 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                    IsTaxableIncomeExceedCheck == true;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr131Get() {
                this.GetValueTypeValues();
                return this.@__Expr131Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr132GetTree() {
                
                #line 1090 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > TaxableIncomeEligibilityAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr132Get() {
                
                #line 1090 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > TaxableIncomeEligibilityAmount;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr132Get() {
                this.GetValueTypeValues();
                return this.@__Expr132Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr133GetTree() {
                
                #line 1103 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessages[Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr133Get() {
                
                #line 1103 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              ErrorMessages[Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr133Get() {
                this.GetValueTypeValues();
                return this.@__Expr133Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr135GetTree() {
                
                #line 1114 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                            ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr135Get() {
                
                #line 1114 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr135Get() {
                this.GetValueTypeValues();
                return this.@__Expr135Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr136GetTree() {
                
                #line 1110 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr136Get() {
                
                #line 1110 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr136Get() {
                this.GetValueTypeValues();
                return this.@__Expr136Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TaxableIncomeEligibilityAmount = ((double)(this.GetVariableValue((10 + locationsOffset))));
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
                if (((locationReferences[(offset + 10)].Name != "TaxableIncomeEligibilityAmount") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
