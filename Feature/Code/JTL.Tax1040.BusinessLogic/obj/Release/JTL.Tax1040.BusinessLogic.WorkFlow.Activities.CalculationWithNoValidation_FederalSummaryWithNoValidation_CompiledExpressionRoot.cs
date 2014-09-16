namespace JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation {
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 31 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
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
    
    #line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 28 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 29 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 30 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
    using JTL.Tax1040.Core.Object;
    
    #line default
    #line hidden
    
    #line 32 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\FederalSummaryWithNoValidation.xaml"
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
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext0 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext1 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext2 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.OutputForms>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext3 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext4 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<JTL.Tax1040.BusinessObject.Tax1040EZPage1>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext5 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly valDataContext6 = ((FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new FederalSummaryWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext7 = ((FederalSummaryWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext7.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new FederalSummaryWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext8 = ((FederalSummaryWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new FederalSummaryWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext9 = ((FederalSummaryWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new FederalSummaryWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext10 = ((FederalSummaryWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext10.GetLocation<double>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly valDataContext11 = ((FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new FederalSummaryWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext12 = ((FederalSummaryWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext12.GetLocation<double>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly valDataContext13 = ((FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new FederalSummaryWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext14 = ((FederalSummaryWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext14.GetLocation<string>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext15 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new FederalSummaryWithNoValidation_TypedDataContext6(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext6 refDataContext16 = ((FederalSummaryWithNoValidation_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext16.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new FederalSummaryWithNoValidation_TypedDataContext6(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext6 refDataContext17 = ((FederalSummaryWithNoValidation_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext17.GetLocation<double>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new FederalSummaryWithNoValidation_TypedDataContext6(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext6 refDataContext18 = ((FederalSummaryWithNoValidation_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext18.GetLocation<double>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext19 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext20 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext20.GetLocation<double>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext21 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext21.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext22 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext22.GetLocation<double>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext23 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext24 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext24.GetLocation<double>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext25 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext26 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext26.GetLocation<double>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext27 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext28 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext29 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext30 = ((FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new FederalSummaryWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext31 = ((FederalSummaryWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext31.GetLocation<string>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext32 = ((FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new FederalSummaryWithNoValidation_TypedDataContext8(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext33 = ((FederalSummaryWithNoValidation_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext33.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new FederalSummaryWithNoValidation_TypedDataContext8(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext34 = ((FederalSummaryWithNoValidation_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext34.GetLocation<double>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new FederalSummaryWithNoValidation_TypedDataContext8(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext35 = ((FederalSummaryWithNoValidation_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext35.GetLocation<double>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly valDataContext36 = ((FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly valDataContext37 = ((FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new FederalSummaryWithNoValidation_TypedDataContext8(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext38 = ((FederalSummaryWithNoValidation_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext38.GetLocation<string>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new FederalSummaryWithNoValidation_TypedDataContext8(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext39 = ((FederalSummaryWithNoValidation_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext39.GetLocation<string>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext40 = ((FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext41 = ((FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new FederalSummaryWithNoValidation_TypedDataContext7(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7 refDataContext42 = ((FederalSummaryWithNoValidation_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext42.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new FederalSummaryWithNoValidation_TypedDataContext7(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7 refDataContext43 = ((FederalSummaryWithNoValidation_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext43.GetLocation<double>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext44 = ((FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new FederalSummaryWithNoValidation_TypedDataContext7(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext7 refDataContext45 = ((FederalSummaryWithNoValidation_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext45.GetLocation<double>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly valDataContext46 = ((FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new FederalSummaryWithNoValidation_TypedDataContext9(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext9 refDataContext47 = ((FederalSummaryWithNoValidation_TypedDataContext9)(cachedCompiledDataContext[13]));
                return refDataContext47.GetLocation<double>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new FederalSummaryWithNoValidation_TypedDataContext10(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext10 refDataContext48 = ((FederalSummaryWithNoValidation_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext48.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new FederalSummaryWithNoValidation_TypedDataContext10(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext10 refDataContext49 = ((FederalSummaryWithNoValidation_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly valDataContext50 = ((FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new FederalSummaryWithNoValidation_TypedDataContext10(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext10 refDataContext51 = ((FederalSummaryWithNoValidation_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext51.GetLocation<double>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext52 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext53 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext54 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext54.GetLocation<double>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext55 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext55.GetLocation<double>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext56 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext56.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext57 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext57.GetLocation<double>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext58 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext58.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext59 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext59.GetLocation<double>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext60 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext60.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext61 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext61.GetLocation<double>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext62 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext62.GetLocation<double>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext63 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext63.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext64 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext64.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext65 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext65.GetLocation<double>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext66 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext66.GetLocation<double>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext67 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext67.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly valDataContext68 = ((FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new FederalSummaryWithNoValidation_TypedDataContext12(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext69 = ((FederalSummaryWithNoValidation_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext69.GetLocation<double>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new FederalSummaryWithNoValidation_TypedDataContext13(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext13 refDataContext70 = ((FederalSummaryWithNoValidation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext70.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new FederalSummaryWithNoValidation_TypedDataContext13(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext13 refDataContext71 = ((FederalSummaryWithNoValidation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext71.GetLocation<bool>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly valDataContext72 = ((FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly valDataContext73 = ((FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext74 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext74.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext74.ValueType___Expr74Get, refDataContext74.ValueType___Expr74Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext75 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext75.GetLocation<double>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext76 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext77 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext77.GetLocation<double>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext78 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext79 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext79.GetLocation<string>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext80 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext81 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext82 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext83 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext83.GetLocation<string>(refDataContext83.ValueType___Expr83Get, refDataContext83.ValueType___Expr83Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext84 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext85 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext85.GetLocation<string>(refDataContext85.ValueType___Expr85Get, refDataContext85.ValueType___Expr85Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext86 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext87 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext88 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext89 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext89.GetLocation<string>(refDataContext89.ValueType___Expr89Get, refDataContext89.ValueType___Expr89Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext90 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext90.ValueType___Expr90Get();
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext91 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext91.GetLocation<string>(refDataContext91.ValueType___Expr91Get, refDataContext91.ValueType___Expr91Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext92 = ((FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext92.ValueType___Expr92Get();
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new FederalSummaryWithNoValidation_TypedDataContext14(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext93 = ((FederalSummaryWithNoValidation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext93.GetLocation<string>(refDataContext93.ValueType___Expr93Get, refDataContext93.ValueType___Expr93Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new FederalSummaryWithNoValidation_TypedDataContext15(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext15 refDataContext94 = ((FederalSummaryWithNoValidation_TypedDataContext15)(cachedCompiledDataContext[22]));
                return refDataContext94.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new FederalSummaryWithNoValidation_TypedDataContext15(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext15 refDataContext95 = ((FederalSummaryWithNoValidation_TypedDataContext15)(cachedCompiledDataContext[22]));
                return refDataContext95.GetLocation<double>(refDataContext95.ValueType___Expr95Get, refDataContext95.ValueType___Expr95Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly valDataContext96 = ((FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new FederalSummaryWithNoValidation_TypedDataContext15(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext15 refDataContext97 = ((FederalSummaryWithNoValidation_TypedDataContext15)(cachedCompiledDataContext[22]));
                return refDataContext97.GetLocation<double>(refDataContext97.ValueType___Expr97Get, refDataContext97.ValueType___Expr97Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext98 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext99 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext100 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext100.GetLocation<double>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext101 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext102 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext102.GetLocation<double>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly valDataContext103 = ((FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext16.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new FederalSummaryWithNoValidation_TypedDataContext16(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext16 refDataContext104 = ((FederalSummaryWithNoValidation_TypedDataContext16)(cachedCompiledDataContext[25]));
                return refDataContext104.GetLocation<double>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext105 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext106 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext106.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext106.ValueType___Expr106Get, refDataContext106.ValueType___Expr106Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext107 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext108 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext108.GetLocation<double>(refDataContext108.ValueType___Expr108Get, refDataContext108.ValueType___Expr108Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext109 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext109.ValueType___Expr109Get();
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext110 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext111 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext111.GetLocation<double>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext112 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext113 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext113.GetLocation<string>(refDataContext113.ValueType___Expr113Get, refDataContext113.ValueType___Expr113Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext114 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext114.GetLocation<double>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext115 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext116 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext116.GetLocation<double>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 117)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext117 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext118 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext119 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext119.GetLocation<string>(refDataContext119.ValueType___Expr119Get, refDataContext119.ValueType___Expr119Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 120)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext120 = ((FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext121 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext121.GetLocation<string>(refDataContext121.ValueType___Expr121Get, refDataContext121.ValueType___Expr121Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 122)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FederalSummaryWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 26);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FederalSummaryWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext122 = ((FederalSummaryWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext122.GetLocation<double>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set, expressionId, this.rootActivity, activityContext);
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
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext2 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.OutputForms>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext3 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext4 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<JTL.Tax1040.BusinessObject.Tax1040EZPage1>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext5 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly valDataContext6 = new FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext7 = new FederalSummaryWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext7.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext8 = new FederalSummaryWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext9 = new FederalSummaryWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext10 = new FederalSummaryWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext10.GetLocation<double>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly valDataContext11 = new FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext12 = new FederalSummaryWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext12.GetLocation<double>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly valDataContext13 = new FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                FederalSummaryWithNoValidation_TypedDataContext4 refDataContext14 = new FederalSummaryWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext14.GetLocation<string>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext15 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                FederalSummaryWithNoValidation_TypedDataContext6 refDataContext16 = new FederalSummaryWithNoValidation_TypedDataContext6(locations, true);
                return refDataContext16.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                FederalSummaryWithNoValidation_TypedDataContext6 refDataContext17 = new FederalSummaryWithNoValidation_TypedDataContext6(locations, true);
                return refDataContext17.GetLocation<double>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                FederalSummaryWithNoValidation_TypedDataContext6 refDataContext18 = new FederalSummaryWithNoValidation_TypedDataContext6(locations, true);
                return refDataContext18.GetLocation<double>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext19 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext20 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext20.GetLocation<double>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext21 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext21.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext22 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext22.GetLocation<double>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set);
            }
            if ((expressionId == 23)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext23 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext24 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext24.GetLocation<double>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext25 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext26 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext26.GetLocation<double>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext27 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext28 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext29 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly valDataContext30 = new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                FederalSummaryWithNoValidation_TypedDataContext5 refDataContext31 = new FederalSummaryWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext31.GetLocation<string>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext32 = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext33 = new FederalSummaryWithNoValidation_TypedDataContext8(locations, true);
                return refDataContext33.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext34 = new FederalSummaryWithNoValidation_TypedDataContext8(locations, true);
                return refDataContext34.GetLocation<double>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext35 = new FederalSummaryWithNoValidation_TypedDataContext8(locations, true);
                return refDataContext35.GetLocation<double>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly valDataContext36 = new FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly valDataContext37 = new FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext38 = new FederalSummaryWithNoValidation_TypedDataContext8(locations, true);
                return refDataContext38.GetLocation<string>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
            }
            if ((expressionId == 39)) {
                FederalSummaryWithNoValidation_TypedDataContext8 refDataContext39 = new FederalSummaryWithNoValidation_TypedDataContext8(locations, true);
                return refDataContext39.GetLocation<string>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext40 = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext41 = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                FederalSummaryWithNoValidation_TypedDataContext7 refDataContext42 = new FederalSummaryWithNoValidation_TypedDataContext7(locations, true);
                return refDataContext42.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                FederalSummaryWithNoValidation_TypedDataContext7 refDataContext43 = new FederalSummaryWithNoValidation_TypedDataContext7(locations, true);
                return refDataContext43.GetLocation<double>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly valDataContext44 = new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                FederalSummaryWithNoValidation_TypedDataContext7 refDataContext45 = new FederalSummaryWithNoValidation_TypedDataContext7(locations, true);
                return refDataContext45.GetLocation<double>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly valDataContext46 = new FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                FederalSummaryWithNoValidation_TypedDataContext9 refDataContext47 = new FederalSummaryWithNoValidation_TypedDataContext9(locations, true);
                return refDataContext47.GetLocation<double>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
            }
            if ((expressionId == 48)) {
                FederalSummaryWithNoValidation_TypedDataContext10 refDataContext48 = new FederalSummaryWithNoValidation_TypedDataContext10(locations, true);
                return refDataContext48.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set);
            }
            if ((expressionId == 49)) {
                FederalSummaryWithNoValidation_TypedDataContext10 refDataContext49 = new FederalSummaryWithNoValidation_TypedDataContext10(locations, true);
                return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set);
            }
            if ((expressionId == 50)) {
                FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly valDataContext50 = new FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                FederalSummaryWithNoValidation_TypedDataContext10 refDataContext51 = new FederalSummaryWithNoValidation_TypedDataContext10(locations, true);
                return refDataContext51.GetLocation<double>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext52 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext53 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext54 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext54.GetLocation<double>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set);
            }
            if ((expressionId == 55)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext55 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext55.GetLocation<double>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set);
            }
            if ((expressionId == 56)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext56 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext56.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set);
            }
            if ((expressionId == 57)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext57 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext57.GetLocation<double>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set);
            }
            if ((expressionId == 58)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext58 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext58.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set);
            }
            if ((expressionId == 59)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext59 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext59.GetLocation<double>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext60 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext60.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set);
            }
            if ((expressionId == 61)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext61 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext61.GetLocation<double>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext62 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext62.GetLocation<double>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set);
            }
            if ((expressionId == 63)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext63 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext63.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set);
            }
            if ((expressionId == 64)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext64 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext64.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set);
            }
            if ((expressionId == 65)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext65 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext65.GetLocation<double>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set);
            }
            if ((expressionId == 66)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext66 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext66.GetLocation<double>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set);
            }
            if ((expressionId == 67)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext67 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext67.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set);
            }
            if ((expressionId == 68)) {
                FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly valDataContext68 = new FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                FederalSummaryWithNoValidation_TypedDataContext12 refDataContext69 = new FederalSummaryWithNoValidation_TypedDataContext12(locations, true);
                return refDataContext69.GetLocation<double>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set);
            }
            if ((expressionId == 70)) {
                FederalSummaryWithNoValidation_TypedDataContext13 refDataContext70 = new FederalSummaryWithNoValidation_TypedDataContext13(locations, true);
                return refDataContext70.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set);
            }
            if ((expressionId == 71)) {
                FederalSummaryWithNoValidation_TypedDataContext13 refDataContext71 = new FederalSummaryWithNoValidation_TypedDataContext13(locations, true);
                return refDataContext71.GetLocation<bool>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set);
            }
            if ((expressionId == 72)) {
                FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly valDataContext72 = new FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly valDataContext73 = new FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext74 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext74.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext74.ValueType___Expr74Get, refDataContext74.ValueType___Expr74Set);
            }
            if ((expressionId == 75)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext75 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext75.GetLocation<double>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set);
            }
            if ((expressionId == 76)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext76 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext77 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext77.GetLocation<double>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set);
            }
            if ((expressionId == 78)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext78 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext79 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext79.GetLocation<string>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set);
            }
            if ((expressionId == 80)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext80 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext80.ValueType___Expr80Get();
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
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext83 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext83.GetLocation<string>(refDataContext83.ValueType___Expr83Get, refDataContext83.ValueType___Expr83Set);
            }
            if ((expressionId == 84)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext84 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext85 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext85.GetLocation<string>(refDataContext85.ValueType___Expr85Get, refDataContext85.ValueType___Expr85Set);
            }
            if ((expressionId == 86)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext86 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext86.ValueType___Expr86Get();
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
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext89 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext89.GetLocation<string>(refDataContext89.ValueType___Expr89Get, refDataContext89.ValueType___Expr89Set);
            }
            if ((expressionId == 90)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext90 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext90.ValueType___Expr90Get();
            }
            if ((expressionId == 91)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext91 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext91.GetLocation<string>(refDataContext91.ValueType___Expr91Get, refDataContext91.ValueType___Expr91Set);
            }
            if ((expressionId == 92)) {
                FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly valDataContext92 = new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext92.ValueType___Expr92Get();
            }
            if ((expressionId == 93)) {
                FederalSummaryWithNoValidation_TypedDataContext14 refDataContext93 = new FederalSummaryWithNoValidation_TypedDataContext14(locations, true);
                return refDataContext93.GetLocation<string>(refDataContext93.ValueType___Expr93Get, refDataContext93.ValueType___Expr93Set);
            }
            if ((expressionId == 94)) {
                FederalSummaryWithNoValidation_TypedDataContext15 refDataContext94 = new FederalSummaryWithNoValidation_TypedDataContext15(locations, true);
                return refDataContext94.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set);
            }
            if ((expressionId == 95)) {
                FederalSummaryWithNoValidation_TypedDataContext15 refDataContext95 = new FederalSummaryWithNoValidation_TypedDataContext15(locations, true);
                return refDataContext95.GetLocation<double>(refDataContext95.ValueType___Expr95Get, refDataContext95.ValueType___Expr95Set);
            }
            if ((expressionId == 96)) {
                FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly valDataContext96 = new FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                FederalSummaryWithNoValidation_TypedDataContext15 refDataContext97 = new FederalSummaryWithNoValidation_TypedDataContext15(locations, true);
                return refDataContext97.GetLocation<double>(refDataContext97.ValueType___Expr97Get, refDataContext97.ValueType___Expr97Set);
            }
            if ((expressionId == 98)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext98 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext99 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext100 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext100.GetLocation<double>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set);
            }
            if ((expressionId == 101)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext101 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext102 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext102.GetLocation<double>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set);
            }
            if ((expressionId == 103)) {
                FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly valDataContext103 = new FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(locations, true);
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                FederalSummaryWithNoValidation_TypedDataContext16 refDataContext104 = new FederalSummaryWithNoValidation_TypedDataContext16(locations, true);
                return refDataContext104.GetLocation<double>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set);
            }
            if ((expressionId == 105)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext105 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext106 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext106.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext106.ValueType___Expr106Get, refDataContext106.ValueType___Expr106Set);
            }
            if ((expressionId == 107)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext107 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext108 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext108.GetLocation<double>(refDataContext108.ValueType___Expr108Get, refDataContext108.ValueType___Expr108Set);
            }
            if ((expressionId == 109)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext109 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext109.ValueType___Expr109Get();
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
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext113 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext113.GetLocation<string>(refDataContext113.ValueType___Expr113Get, refDataContext113.ValueType___Expr113Set);
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
                return refDataContext116.GetLocation<double>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set);
            }
            if ((expressionId == 117)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext117 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext118 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext119 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext119.GetLocation<string>(refDataContext119.ValueType___Expr119Get, refDataContext119.ValueType___Expr119Set);
            }
            if ((expressionId == 120)) {
                FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly valDataContext120 = new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext121 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext121.GetLocation<string>(refDataContext121.ValueType___Expr121Get, refDataContext121.ValueType___Expr121Set);
            }
            if ((expressionId == 122)) {
                FederalSummaryWithNoValidation_TypedDataContext2 refDataContext122 = new FederalSummaryWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext122.GetLocation<double>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object !=null") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new OutputForms()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Tax1040EZPage1()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income !=null") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0)" +
                            ")") 
                        && (FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWages") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "WagesPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NonQualifiedPlansAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalWages") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WagesPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT." +
                            "Count > 0))") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099INTTaxExemptInterest") 
                        && (FederalSummaryWithNoValidation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099INTTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID." +
                            "Count > 0))") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099OIDTaxExemptInterest") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099OIDTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099INTTotal + Form1099OIDTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "F1099INTTaxExemptInterest + F1099OIDTaxExemptInterest") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TEI") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TEI != null && Tax1040Object.OutputForms" +
                            ".Tax1040EZPage1.TEI > 0") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TEIPrefix + Tax1040Object.OutputForms.Tax1040EZPage1.TEI.ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Coun" +
                            "t > 0))") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "UnemploymentAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalRepaid") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalRepaid!=null&&TotalRepaid>0") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RepaidPrefix+TotalRepaid.ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear") 
                        && (FederalSummaryWithNoValidation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome !=null") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object" +
                            ".Income.OtherIncome.HasAlaskaPermanantFund.Value") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AlaskaPermanantFundAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "UnemploymentAmount + AlaskaPermanantFundAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation") 
                        && (FederalSummaryWithNoValidation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.T" +
                            "ax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.Unemplo" +
                            "ymentCompensation") 
                        && (FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome") 
                        && (FederalSummaryWithNoValidation_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalStandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalStandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome > Tax1040Object.Outp" +
                            "utForms.Tax1040EZPage1.StandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome - Tax1040Object.Outp" +
                            "utForms.Tax1040EZPage1.StandardDeduction") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
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
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "W2FederalTaxWithholdTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099INTFederalTaxWithholdTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099OIDFederalTaxWithholdTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099GFederalTaxWithholdTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
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
                        && ((expressionText == "FSSBFederalTaxWithHoldingTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "FRRBFederalTaxWithHoldingTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "W2FederalTaxWithholdTotal + Form1099INTFederalTaxWithholdTotal + Form1099OIDFeder" +
                            "alTaxWithholdTotal + Form1099GFederalTaxWithholdTotal + FSSBFederalTaxWithHoldin" +
                            "gTotal + FRRBFederalTaxWithHoldingTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "HasEarnedIncomeCredit") 
                        && (FederalSummaryWithNoValidation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome") 
                        && (FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "HasEarnedIncomeCredit") 
                        && (FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalEarnedIncomeCredit") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalEarnedIncomeCredit") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NonQualifiedPlansAmount > 0") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Utilities.IsStringEmpty(Prefix1040EZLine1)") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"DFC $\" + NonQualifiedPlansAmount.ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Prefix1040EZLine1 + \",DFC $\" + NonQualifiedPlansAmount.ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.Credits!=null) && (Tax1040Object.Credits.EIC!=null) && (Tax1040Obj" +
                            "ect.Credits.EIC.PenalInstitutionInmateWages.HasValue) &&(Tax1040Object.Credits.E" +
                            "IC.PenalInstitutionInmateWages > 0)") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Utilities.IsStringEmpty(Prefix1040EZLine1)") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"PRI $\" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Prefix1040EZLine1 + \",PRI $\" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWa" +
                            "ges.ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix") 
                        && (FederalSummaryWithNoValidation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NonTaxableCombatPayElectionTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NonTaxableCombatPayElectionTotal") 
                        && (FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection") 
                        && (FederalSummaryWithNoValidation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties != null && Tax1040Object.TaxesAndPenalties.Federa" +
                            "lExtensionAmount != null") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.HasValue ? Tax1040Object." +
                            "TaxesAndPenalties.FederalExtensionAmount.Value : 0)") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount + Tax1040Obj" +
                            "ect.OutputForms.Tax1040EZPage1.EarnedIncomeCredit+ Tax1040Object.OutputForms.Tax" +
                            "1040EZPage1.FederalExtensionAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "JTL.Tax1040.Core.Process.TaxRateCalculation.TaxCalculation(Tax1040Object.Personal" +
                            "Details.PrimaryTaxPayer.FilingStatus, Tax1040Object.OutputForms.Tax1040EZPage1.T" +
                            "axableIncome)") 
                        && (FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext16.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties != null") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest.HasValue ? Tax1040Object.Tax" +
                            "esAndPenalties.PenaltiesAndInterest.Value : 0") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.PenaltiesAndInterest") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits > Tax1040Object." +
                            "OutputForms.Tax1040EZPage1.TaxAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits - Tax1040Object." +
                            "OutputForms.Tax1040EZPage1.TaxAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.TaxOweAmountPDF") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Ta" +
                            "x1040EZPage1.TotalPaymentsAndCredits") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 116;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount >0") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 117;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Total Line 12 $\" + Math.Round(Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmo" +
                            "unt, MidpointRounding.AwayFromZero).ToString()") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 118;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.TaxOweAmountPDF") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 119;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 120;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.TaxOweAmountPDF") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 121;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount") 
                        && (FederalSummaryWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 122;
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
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new FederalSummaryWithNoValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new FederalSummaryWithNoValidation_TypedDataContext4(locationReferences).@__Expr7GetTree();
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
                return new FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new FederalSummaryWithNoValidation_TypedDataContext4(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new FederalSummaryWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new FederalSummaryWithNoValidation_TypedDataContext4(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new FederalSummaryWithNoValidation_TypedDataContext6(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new FederalSummaryWithNoValidation_TypedDataContext6(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new FederalSummaryWithNoValidation_TypedDataContext6(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new FederalSummaryWithNoValidation_TypedDataContext5(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new FederalSummaryWithNoValidation_TypedDataContext8(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new FederalSummaryWithNoValidation_TypedDataContext7(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new FederalSummaryWithNoValidation_TypedDataContext9_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new FederalSummaryWithNoValidation_TypedDataContext9(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new FederalSummaryWithNoValidation_TypedDataContext10(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new FederalSummaryWithNoValidation_TypedDataContext10(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new FederalSummaryWithNoValidation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new FederalSummaryWithNoValidation_TypedDataContext10(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr56GetTree();
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
                return new FederalSummaryWithNoValidation_TypedDataContext12_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new FederalSummaryWithNoValidation_TypedDataContext12(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new FederalSummaryWithNoValidation_TypedDataContext13(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new FederalSummaryWithNoValidation_TypedDataContext13(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new FederalSummaryWithNoValidation_TypedDataContext13_ForReadOnly(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new FederalSummaryWithNoValidation_TypedDataContext14(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new FederalSummaryWithNoValidation_TypedDataContext15(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new FederalSummaryWithNoValidation_TypedDataContext15(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new FederalSummaryWithNoValidation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new FederalSummaryWithNoValidation_TypedDataContext15(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new FederalSummaryWithNoValidation_TypedDataContext16_ForReadOnly(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new FederalSummaryWithNoValidation_TypedDataContext16(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr109GetTree();
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
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr113GetTree();
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
                return new FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr117GetTree();
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
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr121GetTree();
            }
            if ((expressionId == 122)) {
                return new FederalSummaryWithNoValidation_TypedDataContext2(locationReferences).@__Expr122GetTree();
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
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 1))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 1);
                }
                expectedLocationsCount = 1;
                if (((locationReferences[(offset + 0)].Name != "Tax1040Object") 
                            || (locationReferences[(offset + 0)].Type != typeof(JTL.Tax1040.BusinessObject.Tax1040)))) {
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
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 1))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 1);
                }
                expectedLocationsCount = 1;
                if (((locationReferences[(offset + 0)].Name != "Tax1040Object") 
                            || (locationReferences[(offset + 0)].Type != typeof(JTL.Tax1040.BusinessObject.Tax1040)))) {
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
                    return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((1 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 80 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.OutputForms>> expression = () => 
                  Tax1040Object.OutputForms;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.OutputForms @__Expr2Get() {
                
                #line 80 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                  Tax1040Object.OutputForms;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.OutputForms ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(JTL.Tax1040.BusinessObject.OutputForms value) {
                
                #line 80 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                  Tax1040Object.OutputForms = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(JTL.Tax1040.BusinessObject.OutputForms value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 92 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040EZPage1>> expression = () => 
                  Tax1040Object.OutputForms.Tax1040EZPage1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 @__Expr4Get() {
                
                #line 92 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                  Tax1040Object.OutputForms.Tax1040EZPage1;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(JTL.Tax1040.BusinessObject.Tax1040EZPage1 value) {
                
                #line 92 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                  Tax1040Object.OutputForms.Tax1040EZPage1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(JTL.Tax1040.BusinessObject.Tax1040EZPage1 value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 488 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr54Get() {
                
                #line 488 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr54Set(double value) {
                
                #line 488 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr54Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr54Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 502 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr55Get() {
                
                #line 502 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
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
                
                #line 502 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr55Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr55Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 824 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr100Get() {
                
                #line 824 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr100Set(double value) {
                
                #line 824 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr100Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr100Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 838 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr102Get() {
                
                #line 838 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr102Set(double value) {
                
                #line 838 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr102Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr102Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 876 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                            Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr106Get() {
                
                #line 876 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr106Get() {
                this.GetValueTypeValues();
                return this.@__Expr106Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr106Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 876 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr106Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr106Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 883 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.PenaltiesAndInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr108Get() {
                
                #line 883 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.PenaltiesAndInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr108Set(double value) {
                
                #line 883 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.PenaltiesAndInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr108Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr108Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr111GetTree() {
                
                #line 907 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr111Get() {
                
                #line 907 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr111Get() {
                this.GetValueTypeValues();
                return this.@__Expr111Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr111Set(double value) {
                
                #line 907 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr111Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr111Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 919 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Tax1040Object.OutputForms.TaxOweAmountPDF;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr113Get() {
                
                #line 919 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.TaxOweAmountPDF;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr113Get() {
                this.GetValueTypeValues();
                return this.@__Expr113Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr113Set(string value) {
                
                #line 919 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.TaxOweAmountPDF = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr113Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr113Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr114GetTree() {
                
                #line 931 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr114Get() {
                
                #line 931 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr114Get() {
                this.GetValueTypeValues();
                return this.@__Expr114Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr114Set(double value) {
                
                #line 931 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr114Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr114Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr116GetTree() {
                
                #line 945 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr116Get() {
                
                #line 945 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr116Get() {
                this.GetValueTypeValues();
                return this.@__Expr116Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr116Set(double value) {
                
                #line 945 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr116Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr116Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr119GetTree() {
                
                #line 964 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Tax1040Object.OutputForms.TaxOweAmountPDF;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr119Get() {
                
                #line 964 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object.OutputForms.TaxOweAmountPDF;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr119Get() {
                this.GetValueTypeValues();
                return this.@__Expr119Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr119Set(string value) {
                
                #line 964 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                  Tax1040Object.OutputForms.TaxOweAmountPDF = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr119Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr119Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr121GetTree() {
                
                #line 978 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Tax1040Object.OutputForms.TaxOweAmountPDF;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr121Get() {
                
                #line 978 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object.OutputForms.TaxOweAmountPDF;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr121Get() {
                this.GetValueTypeValues();
                return this.@__Expr121Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr121Set(string value) {
                
                #line 978 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                  Tax1040Object.OutputForms.TaxOweAmountPDF = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr121Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr121Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr122GetTree() {
                
                #line 992 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr122Get() {
                
                #line 992 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr122Get() {
                this.GetValueTypeValues();
                return this.@__Expr122Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr122Set(double value) {
                
                #line 992 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr122Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr122Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.NonQualifiedPlansAmount = ((double)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((2 + locationsOffset), this.NonQualifiedPlansAmount);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 1)].Name != "Form1099OID") 
                            || (locationReferences[(offset + 1)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "NonQualifiedPlansAmount") 
                            || (locationReferences[(offset + 2)].Type != typeof(double)))) {
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
                    return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((1 + locationsOffset))));
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
                
                #line 71 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          Tax1040Object !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr0Get() {
                
                #line 71 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
          Tax1040Object !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 85 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.OutputForms>> expression = () => 
                  new OutputForms();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.OutputForms @__Expr1Get() {
                
                #line 85 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                  new OutputForms();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.OutputForms ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 97 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040EZPage1>> expression = () => 
                  new Tax1040EZPage1();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 @__Expr3Get() {
                
                #line 97 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                  new Tax1040EZPage1();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 105 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                Tax1040Object.Income !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 105 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                Tax1040Object.Income !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 481 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome > Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr52Get() {
                
                #line 481 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome > Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 493 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome - Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr53Get() {
                
                #line 493 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome - Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 817 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.TaxesAndPenalties != null && Tax1040Object.TaxesAndPenalties.FederalExtensionAmount != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr98Get() {
                
                #line 817 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.TaxesAndPenalties != null && Tax1040Object.TaxesAndPenalties.FederalExtensionAmount != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 829 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            (Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.HasValue ? Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.Value : 0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr99Get() {
                
                #line 829 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            (Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.HasValue ? Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.Value : 0);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 843 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount + Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit+ Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr101Get() {
                
                #line 843 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount + Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit+ Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 868 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.TaxesAndPenalties != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr105Get() {
                
                #line 868 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object.TaxesAndPenalties != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 888 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest.HasValue ? Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest.Value : 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr107Get() {
                
                #line 888 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest.HasValue ? Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest.Value : 0;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 899 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits > Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr109Get() {
                
                #line 899 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits > Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr110GetTree() {
                
                #line 912 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits - Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr110Get() {
                
                #line 912 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits - Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr110Get() {
                this.GetValueTypeValues();
                return this.@__Expr110Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr112GetTree() {
                
                #line 924 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr112Get() {
                
                #line 924 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr112Get() {
                this.GetValueTypeValues();
                return this.@__Expr112Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 950 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr115Get() {
                
                #line 950 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr117GetTree() {
                
                #line 957 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount >0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr117Get() {
                
                #line 957 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount >0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr117Get() {
                this.GetValueTypeValues();
                return this.@__Expr117Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr118GetTree() {
                
                #line 969 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "Total Line 12 $" + Math.Round(Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr118Get() {
                
                #line 969 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  "Total Line 12 $" + Math.Round(Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr118Get() {
                this.GetValueTypeValues();
                return this.@__Expr118Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr120GetTree() {
                
                #line 983 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr120Get() {
                
                #line 983 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr120Get() {
                this.GetValueTypeValues();
                return this.@__Expr120Get();
            }
            
            protected override void GetValueTypeValues() {
                this.NonQualifiedPlansAmount = ((double)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 1)].Name != "Form1099OID") 
                            || (locationReferences[(offset + 1)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "NonQualifiedPlansAmount") 
                            || (locationReferences[(offset + 2)].Type != typeof(double)))) {
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
                    return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((3 + locationsOffset))));
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
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "W2") 
                            || (locationReferences[(offset + 3)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
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
                    return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 117 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        ((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 117 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        ((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "W2") 
                            || (locationReferences[(offset + 3)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
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
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
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
                
                #line 139 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                              Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr7Get() {
                
                #line 139 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 139 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 144 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr8Get() {
                
                #line 144 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(double value) {
                
                #line 144 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 134 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr9Get() {
                
                #line 134 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(string value) {
                
                #line 134 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 129 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              NonQualifiedPlansAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr10Get() {
                
                #line 129 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              NonQualifiedPlansAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(double value) {
                
                #line 129 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              NonQualifiedPlansAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 151 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr12Get() {
                
                #line 151 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(double value) {
                
                #line 151 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 163 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 163 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(string value) {
                
                #line 163 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalWages = ((double)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.TotalWages);
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
                if (((locationReferences[(offset + 5)].Name != "WagesPrefix") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "TotalWages") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
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
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 156 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr11Get() {
                
                #line 156 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 168 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 168 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalWages = ((double)(this.GetVariableValue((4 + locationsOffset))));
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
                if (((locationReferences[(offset + 5)].Name != "WagesPrefix") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "TotalWages") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
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
                    return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected string TEIPrefix {
                get {
                    return ((string)(this.GetVariableValue((10 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 239 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr20Get() {
                
                #line 239 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(double value) {
                
                #line 239 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              F1099OIDTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 229 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                              Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr21Get() {
                
                #line 229 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 229 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 234 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Form1099OIDTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr22Get() {
                
                #line 234 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Form1099OIDTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr22Set(double value) {
                
                #line 234 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Form1099OIDTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr22Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr22Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 249 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr24Get() {
                
                #line 249 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(double value) {
                
                #line 249 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 261 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TEI;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr26Get() {
                
                #line 261 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TEI;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(double value) {
                
                #line 261 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                        Tax1040Object.OutputForms.Tax1040EZPage1.TEI = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 280 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 280 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(string value) {
                
                #line 280 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 294 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr31Get() {
                
                #line 294 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(string value) {
                
                #line 294 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Totol1099OIDAmount = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.TotalWages = ((double)(this.GetVariableValue((9 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.Totol1099OIDAmount);
                this.SetVariableValue((5 + locationsOffset), this.Form1099INTTotal);
                this.SetVariableValue((6 + locationsOffset), this.Form1099OIDTotal);
                this.SetVariableValue((7 + locationsOffset), this.F1099INTTaxExemptInterest);
                this.SetVariableValue((8 + locationsOffset), this.F1099OIDTaxExemptInterest);
                this.SetVariableValue((9 + locationsOffset), this.TotalWages);
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
                if (((locationReferences[(offset + 3)].Name != "Form1099INT") 
                            || (locationReferences[(offset + 3)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TEIPrefix") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Totol1099OIDAmount") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "TotalWages") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
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
                    return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected string TEIPrefix {
                get {
                    return ((string)(this.GetVariableValue((10 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 190 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        ((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr15Get() {
                
                #line 190 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        ((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 221 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        ((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr19Get() {
                
                #line 221 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        ((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 254 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Form1099INTTotal + Form1099OIDTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr23Get() {
                
                #line 254 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Form1099INTTotal + Form1099OIDTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 266 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        F1099INTTaxExemptInterest + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr25Get() {
                
                #line 266 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        F1099INTTaxExemptInterest + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 273 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TEI != null && Tax1040Object.OutputForms.Tax1040EZPage1.TEI > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr27Get() {
                
                #line 273 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TEI != null && Tax1040Object.OutputForms.Tax1040EZPage1.TEI > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 285 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            TEIPrefix + Tax1040Object.OutputForms.Tax1040EZPage1.TEI.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr28Get() {
                
                #line 285 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            TEIPrefix + Tax1040Object.OutputForms.Tax1040EZPage1.TEI.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Totol1099OIDAmount = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.TotalWages = ((double)(this.GetVariableValue((9 + locationsOffset))));
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
                if (((locationReferences[(offset + 3)].Name != "Form1099INT") 
                            || (locationReferences[(offset + 3)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TEIPrefix") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Totol1099OIDAmount") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "TotalWages") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 201 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                              Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr16Get() {
                
                #line 201 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 201 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 211 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr17Get() {
                
                #line 211 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(double value) {
                
                #line 211 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              F1099INTTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 206 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Form1099INTTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr18Get() {
                
                #line 206 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Form1099INTTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(double value) {
                
                #line 206 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Form1099INTTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
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
                    return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((3 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 405 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                  Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr42Get() {
                
                #line 405 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 405 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                  Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 400 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr43Get() {
                
                #line 400 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(double value) {
                
                #line 400 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                  AlaskaPermanantFundAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 417 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr45Get() {
                
                #line 417 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(double value) {
                
                #line 417 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                        Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.AlaskaPermanantFundAmount = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.UnemploymentAmount = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.AlaskaPermanantFundAmount);
                this.SetVariableValue((5 + locationsOffset), this.UnemploymentAmount);
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
                if (((locationReferences[(offset + 3)].Name != "Form1099G") 
                            || (locationReferences[(offset + 3)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "AlaskaPermanantFundAmount") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "UnemploymentAmount") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
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
                    return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 315 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        ((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr32Get() {
                
                #line 315 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        ((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 385 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr40Get() {
                
                #line 385 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 392 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr41Get() {
                
                #line 392 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.Value;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 422 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        UnemploymentAmount + AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr44Get() {
                
                #line 422 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        UnemploymentAmount + AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            protected override void GetValueTypeValues() {
                this.AlaskaPermanantFundAmount = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.UnemploymentAmount = ((double)(this.GetVariableValue((5 + locationsOffset))));
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
                if (((locationReferences[(offset + 3)].Name != "Form1099G") 
                            || (locationReferences[(offset + 3)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "AlaskaPermanantFundAmount") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "UnemploymentAmount") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
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
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
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
                
                #line 329 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr33Get() {
                
                #line 329 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 329 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                UnemploymentAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr34Get() {
                
                #line 339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                UnemploymentAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(double value) {
                
                #line 339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                UnemploymentAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                TotalRepaid;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr35Get() {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                TotalRepaid;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(double value) {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                TotalRepaid = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 353 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr38Get() {
                
                #line 353 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                    Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr38Set(string value) {
                
                #line 353 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                    Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr38Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr38Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 367 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr39Get() {
                
                #line 367 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
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
                
                #line 367 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                    Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalUnemploymentCompensationAmount = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.TotalRepaid = ((double)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((6 + locationsOffset), this.TotalUnemploymentCompensationAmount);
                this.SetVariableValue((7 + locationsOffset), this.TotalRepaid);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 9))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 9);
                }
                expectedLocationsCount = 9;
                if (((locationReferences[(offset + 8)].Name != "RepaidPrefix") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "TotalUnemploymentCompensationAmount") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "TotalRepaid") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
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
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 346 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                TotalRepaid!=null&&TotalRepaid>0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr36Get() {
                
                #line 346 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                TotalRepaid!=null&&TotalRepaid>0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 358 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    RepaidPrefix+TotalRepaid.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr37Get() {
                
                #line 358 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                    RepaidPrefix+TotalRepaid.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalUnemploymentCompensationAmount = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.TotalRepaid = ((double)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 9))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 9);
                }
                expectedLocationsCount = 9;
                if (((locationReferences[(offset + 8)].Name != "RepaidPrefix") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "TotalUnemploymentCompensationAmount") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "TotalRepaid") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 435 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr47Get() {
                
                #line 435 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr47Set(double value) {
                
                #line 435 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr47Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr47Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalAdjustedGrossIncome = ((double)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((3 + locationsOffset), this.TotalAdjustedGrossIncome);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "TotalAdjustedGrossIncome") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 440 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr46Get() {
                
                #line 440 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalAdjustedGrossIncome = ((double)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "TotalAdjustedGrossIncome") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 454 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr48Get() {
                
                #line 454 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr48Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 454 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr48Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr48Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 459 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          TotalStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr49Get() {
                
                #line 459 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          TotalStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr49Set(double value) {
                
                #line 459 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          TotalStandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr49Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr49Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 466 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr51Get() {
                
                #line 466 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(double value) {
                
                #line 466 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalStandardDeduction = ((double)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((3 + locationsOffset), this.TotalStandardDeduction);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "TotalStandardDeduction") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 471 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          TotalStandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr50Get() {
                
                #line 471 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          TotalStandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalStandardDeduction = ((double)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "TotalStandardDeduction") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
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
                this.W2FederalTaxWithholdTotal = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.Form1099INTFederalTaxWithholdTotal = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.Form1099OIDFederalTaxWithholdTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.Form1099GFederalTaxWithholdTotal = ((double)(this.GetVariableValue((6 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((3 + locationsOffset), this.W2FederalTaxWithholdTotal);
                this.SetVariableValue((4 + locationsOffset), this.Form1099INTFederalTaxWithholdTotal);
                this.SetVariableValue((5 + locationsOffset), this.Form1099OIDFederalTaxWithholdTotal);
                this.SetVariableValue((6 + locationsOffset), this.Form1099GFederalTaxWithholdTotal);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 3)].Name != "W2FederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Form1099INTFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Form1099OIDFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Form1099GFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
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
                this.W2FederalTaxWithholdTotal = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.Form1099INTFederalTaxWithholdTotal = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.Form1099OIDFederalTaxWithholdTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.Form1099GFederalTaxWithholdTotal = ((double)(this.GetVariableValue((6 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 3)].Name != "W2FederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Form1099INTFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Form1099OIDFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Form1099GFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 527 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr56Get() {
                
                #line 527 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr56Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 527 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr56Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr56Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 532 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          W2FederalTaxWithholdTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr57Get() {
                
                #line 532 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          W2FederalTaxWithholdTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr57Set(double value) {
                
                #line 532 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          W2FederalTaxWithholdTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr57Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr57Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 539 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr58Get() {
                
                #line 539 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr58Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 539 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr58Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr58Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 544 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099INTFederalTaxWithholdTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr59Get() {
                
                #line 544 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Form1099INTFederalTaxWithholdTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(double value) {
                
                #line 544 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Form1099INTFederalTaxWithholdTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 551 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr60Get() {
                
                #line 551 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr60Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 551 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr60Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr60Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 556 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099OIDFederalTaxWithholdTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr61Get() {
                
                #line 556 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Form1099OIDFederalTaxWithholdTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(double value) {
                
                #line 556 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Form1099OIDFederalTaxWithholdTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 568 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099GFederalTaxWithholdTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr62Get() {
                
                #line 568 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Form1099GFederalTaxWithholdTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr62Set(double value) {
                
                #line 568 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Form1099GFederalTaxWithholdTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr62Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr62Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 563 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr63Get() {
                
                #line 563 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr63Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 563 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr63Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr63Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 575 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr64Get() {
                
                #line 575 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
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
                
                #line 575 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
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
                
                #line 580 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          FSSBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr65Get() {
                
                #line 580 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          FSSBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr65Set(double value) {
                
                #line 580 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          FSSBFederalTaxWithHoldingTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr65Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr65Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 592 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          FRRBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr66Get() {
                
                #line 592 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          FRRBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr66Set(double value) {
                
                #line 592 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          FRRBFederalTaxWithHoldingTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr66Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr66Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 587 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr67Get() {
                
                #line 587 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr67Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 587 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr67Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr67Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 599 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr69Get() {
                
                #line 599 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr69Set(double value) {
                
                #line 599 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr69Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr69Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.FSSBFederalTaxWithHoldingTotal = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.FRRBFederalTaxWithHoldingTotal = ((double)(this.GetVariableValue((8 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((7 + locationsOffset), this.FSSBFederalTaxWithHoldingTotal);
                this.SetVariableValue((8 + locationsOffset), this.FRRBFederalTaxWithHoldingTotal);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 9))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 9);
                }
                expectedLocationsCount = 9;
                if (((locationReferences[(offset + 7)].Name != "FSSBFederalTaxWithHoldingTotal") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "FRRBFederalTaxWithHoldingTotal") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 604 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          W2FederalTaxWithholdTotal + Form1099INTFederalTaxWithholdTotal + Form1099OIDFederalTaxWithholdTotal + Form1099GFederalTaxWithholdTotal + FSSBFederalTaxWithHoldingTotal + FRRBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr68Get() {
                
                #line 604 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                          W2FederalTaxWithholdTotal + Form1099INTFederalTaxWithholdTotal + Form1099OIDFederalTaxWithholdTotal + Form1099GFederalTaxWithholdTotal + FSSBFederalTaxWithHoldingTotal + FRRBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            protected override void GetValueTypeValues() {
                this.FSSBFederalTaxWithHoldingTotal = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.FRRBFederalTaxWithHoldingTotal = ((double)(this.GetVariableValue((8 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 9))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 9);
                }
                expectedLocationsCount = 9;
                if (((locationReferences[(offset + 7)].Name != "FSSBFederalTaxWithHoldingTotal") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "FRRBFederalTaxWithHoldingTotal") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
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
                    return ((System.Collections.Generic.IEnumerable<JTL.Tax1040.Core.Object.ErrorMessage>)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 629 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr70Get() {
                
                #line 629 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr70Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 629 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                        Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr70Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr70Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 624 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        HasEarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr71Get() {
                
                #line 624 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        HasEarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr71Set(bool value) {
                
                #line 624 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                        HasEarnedIncomeCredit = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr71Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr71Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalEarnedIncomeCredit = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.HasEarnedIncomeCredit = ((bool)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((3 + locationsOffset), this.TotalEarnedIncomeCredit);
                this.SetVariableValue((5 + locationsOffset), this.HasEarnedIncomeCredit);
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
                if (((locationReferences[(offset + 4)].Name != "listErrorMessage") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Collections.Generic.IEnumerable<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "TotalEarnedIncomeCredit") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "HasEarnedIncomeCredit") 
                            || (locationReferences[(offset + 5)].Type != typeof(bool)))) {
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
                    return ((System.Collections.Generic.IEnumerable<JTL.Tax1040.Core.Object.ErrorMessage>)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 619 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr72Get() {
                
                #line 619 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 636 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        HasEarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr73Get() {
                
                #line 636 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        HasEarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalEarnedIncomeCredit = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.HasEarnedIncomeCredit = ((bool)(this.GetVariableValue((5 + locationsOffset))));
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
                if (((locationReferences[(offset + 4)].Name != "listErrorMessage") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Collections.Generic.IEnumerable<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "TotalEarnedIncomeCredit") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "HasEarnedIncomeCredit") 
                            || (locationReferences[(offset + 5)].Type != typeof(bool)))) {
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
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 647 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                              Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr74Get() {
                
                #line 647 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr74Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 647 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr74Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr74Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 652 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              TotalEarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr75Get() {
                
                #line 652 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              TotalEarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr75Set(double value) {
                
                #line 652 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              TotalEarnedIncomeCredit = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr75Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr75Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 659 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr77Get() {
                
                #line 659 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr77Set(double value) {
                
                #line 659 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr77Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr77Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 671 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr79Get() {
                
                #line 671 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr79Set(string value) {
                
                #line 671 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr79Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr79Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 697 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr83Get() {
                
                #line 697 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                      Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr83Set(string value) {
                
                #line 697 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                      Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr83Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr83Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 711 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr85Get() {
                
                #line 711 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                      Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr85Set(string value) {
                
                #line 711 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                      Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr85Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr85Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 741 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr89Get() {
                
                #line 741 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                      Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr89Set(string value) {
                
                #line 741 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                      Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr89Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr89Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 755 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr91Get() {
                
                #line 755 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                      Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr91Set(string value) {
                
                #line 755 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                                      Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr91Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr91Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 771 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr93Get() {
                
                #line 771 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr93Set(string value) {
                
                #line 771 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr93Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr93Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 6)].Name != "Prefix1040EZLine1") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
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
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 664 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              TotalEarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr76Get() {
                
                #line 664 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              TotalEarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 676 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr78Get() {
                
                #line 676 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 683 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              NonQualifiedPlansAmount > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr80Get() {
                
                #line 683 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              NonQualifiedPlansAmount > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 690 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  Utilities.IsStringEmpty(Prefix1040EZLine1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr81Get() {
                
                #line 690 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  Utilities.IsStringEmpty(Prefix1040EZLine1);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 702 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      "DFC $" + NonQualifiedPlansAmount.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr82Get() {
                
                #line 702 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                      "DFC $" + NonQualifiedPlansAmount.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 716 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      Prefix1040EZLine1 + ",DFC $" + NonQualifiedPlansAmount.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr84Get() {
                
                #line 716 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                      Prefix1040EZLine1 + ",DFC $" + NonQualifiedPlansAmount.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 727 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              (Tax1040Object.Credits!=null) && (Tax1040Object.Credits.EIC!=null) && (Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.HasValue) &&(Tax1040Object.Credits.EIC.PenalInstitutionInmateWages > 0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr86Get() {
                
                #line 727 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              (Tax1040Object.Credits!=null) && (Tax1040Object.Credits.EIC!=null) && (Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.HasValue) &&(Tax1040Object.Credits.EIC.PenalInstitutionInmateWages > 0);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 734 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  Utilities.IsStringEmpty(Prefix1040EZLine1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr87Get() {
                
                #line 734 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                  Utilities.IsStringEmpty(Prefix1040EZLine1);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      "PRI $" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr88Get() {
                
                #line 746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                      "PRI $" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 760 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      Prefix1040EZLine1 + ",PRI $" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr90Get() {
                
                #line 760 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                                      Prefix1040EZLine1 + ",PRI $" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 776 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr92Get() {
                
                #line 776 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                              Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 6)].Name != "Prefix1040EZLine1") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr94GetTree() {
                
                #line 791 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr94Get() {
                
                #line 791 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr94Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 791 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                        Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr94Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr94Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 796 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        NonTaxableCombatPayElectionTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr95Get() {
                
                #line 796 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        NonTaxableCombatPayElectionTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr95Set(double value) {
                
                #line 796 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                        NonTaxableCombatPayElectionTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr95Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr95Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 803 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr97Get() {
                
                #line 803 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr97Set(double value) {
                
                #line 803 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                        Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr97Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr97Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.NonTaxableCombatPayElectionTotal = ((double)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((3 + locationsOffset), this.NonTaxableCombatPayElectionTotal);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "NonTaxableCombatPayElectionTotal") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 808 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        NonTaxableCombatPayElectionTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr96Get() {
                
                #line 808 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        NonTaxableCombatPayElectionTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            protected override void GetValueTypeValues() {
                this.NonTaxableCombatPayElectionTotal = ((double)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "NonTaxableCombatPayElectionTotal") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 855 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr104Get() {
                
                #line 855 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr104Set(double value) {
                
                #line 855 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr104Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr104Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TaxAmountTotal = ((double)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((3 + locationsOffset), this.TaxAmountTotal);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "TaxAmountTotal") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 860 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        JTL.Tax1040.Core.Process.TaxRateCalculation.TaxCalculation(Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus, Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr103Get() {
                
                #line 860 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FEDERALSUMMARYWITHNOVALIDATION.XAML"
                return 
                        JTL.Tax1040.Core.Process.TaxRateCalculation.TaxCalculation(Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus, Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TaxAmountTotal = ((double)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "TaxAmountTotal") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                return FederalSummaryWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
