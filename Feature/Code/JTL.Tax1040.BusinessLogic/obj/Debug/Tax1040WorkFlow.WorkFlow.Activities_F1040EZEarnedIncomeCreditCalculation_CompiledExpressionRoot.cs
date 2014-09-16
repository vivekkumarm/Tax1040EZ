namespace Tax1040WorkFlow.WorkFlow.Activities {
    
    #line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 28 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 29 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 30 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 31 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 32 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 33 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using System.Collections.Concurrent;
    
    #line default
    #line hidden
    
    #line 34 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using JTL.Tax1040.Core.Object;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEarnedIncomeCreditCalculation.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class F1040EZEarnedIncomeCreditCalculation : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext0 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext1 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext2 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext3 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext4 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext5 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext6 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext7 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<JTL.Tax1040.BusinessObject.F1040EZ>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext8 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext9 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext9.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext10 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext11 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext11.GetLocation<JTL.Tax1040.BusinessObject.EICWorkSheet>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext12 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext13 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext14 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext15 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext16 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext16.GetLocation<JTL.Tax1040.BusinessObject.EICWorkSheet>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext17 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext18 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext19 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext19.GetLocation<System.Nullable<bool>>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext20 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext21 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext22 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext23 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext24 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext24.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext25 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext25.GetLocation<double>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext26 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext27 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext28 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext28.GetLocation<double>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext29 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext30 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext30.GetLocation<double>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext31 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext32 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext32.GetLocation<double>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext33 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext34 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext34.GetLocation<double>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext35 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext36 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext37 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext37.GetLocation<double>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext38 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext39 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext39.GetLocation<int>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext40 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext41 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext41.GetLocation<int>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext42 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext43 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext43.GetLocation<int>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext44 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext45 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext46 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext47 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext47.GetLocation<double>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext48 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext49 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext50 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext50.GetLocation<string>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext51 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext52 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext52.GetLocation<System.Nullable<bool>>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext53 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext54 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext54.GetLocation<double>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext55 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext56 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext56.GetLocation<bool>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext57 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext58 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext58.GetLocation<double>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext59 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext60 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext60.GetLocation<bool>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext61 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext61.GetLocation<bool>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext62 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext63 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext63.GetLocation<double>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext64 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext65 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext65.GetLocation<double>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext66 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext67 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext67.GetLocation<bool>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext68 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext69 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext69.GetLocation<double>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext70 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext71 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext71.GetLocation<int>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext72 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext73 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext73.GetLocation<int>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext74 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext75 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext75.GetLocation<int>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext76 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext77 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext78 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext79 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext79.GetLocation<double>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext80 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext81 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext81.GetLocation<double>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext82 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext83 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext83.GetLocation<double>(refDataContext83.ValueType___Expr83Get, refDataContext83.ValueType___Expr83Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly valDataContext84 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly valDataContext85 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4 refDataContext86 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext86.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4 refDataContext87 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext87.GetLocation<double>(refDataContext87.ValueType___Expr87Get, refDataContext87.ValueType___Expr87Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly valDataContext88 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly valDataContext89 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4 refDataContext90 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext90.GetLocation<double>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly valDataContext91 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4 refDataContext92 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext92.GetLocation<double>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext93 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext94 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext94.GetLocation<double>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext95 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext96 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext96.GetLocation<double>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext97 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext98 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext99 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext99.GetLocation<double>(refDataContext99.ValueType___Expr99Get, refDataContext99.ValueType___Expr99Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext100 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext100.ValueType___Expr100Get();
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext101 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext101.GetLocation<int>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext102 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext103 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext103.GetLocation<int>(refDataContext103.ValueType___Expr103Get, refDataContext103.ValueType___Expr103Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext104 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext105 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext105.GetLocation<int>(refDataContext105.ValueType___Expr105Get, refDataContext105.ValueType___Expr105Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext106 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext107 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext108 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext109 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext109.GetLocation<double>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext110 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext111 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext111.GetLocation<double>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext112 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext112.GetLocation<string>(refDataContext112.ValueType___Expr112Get, refDataContext112.ValueType___Expr112Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext113 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext114 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext114.GetLocation<System.Nullable<bool>>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext115 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext116 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext116.GetLocation<double>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 117)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext117 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext118 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext118.GetLocation<bool>(refDataContext118.ValueType___Expr118Get, refDataContext118.ValueType___Expr118Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 119)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext119 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext119.ValueType___Expr119Get();
            }
            if ((expressionId == 120)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext120 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext120.GetLocation<double>(refDataContext120.ValueType___Expr120Get, refDataContext120.ValueType___Expr120Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 121)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext121 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext122 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext122.GetLocation<bool>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 123)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext123 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext123.GetLocation<bool>(refDataContext123.ValueType___Expr123Get, refDataContext123.ValueType___Expr123Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 124)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext124 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext124.ValueType___Expr124Get();
            }
            if ((expressionId == 125)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext125 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext125.GetLocation<double>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 126)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext126 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext127 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext127.GetLocation<double>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 128)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext128 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext129 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext129.GetLocation<bool>(refDataContext129.ValueType___Expr129Get, refDataContext129.ValueType___Expr129Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 130)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext130 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext131 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext131.GetLocation<double>(refDataContext131.ValueType___Expr131Get, refDataContext131.ValueType___Expr131Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 132)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext132 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext132.ValueType___Expr132Get();
            }
            if ((expressionId == 133)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext133 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext133.GetLocation<int>(refDataContext133.ValueType___Expr133Get, refDataContext133.ValueType___Expr133Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 134)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext134 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext135 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext135.GetLocation<int>(refDataContext135.ValueType___Expr135Get, refDataContext135.ValueType___Expr135Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 136)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext136 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext136.ValueType___Expr136Get();
            }
            if ((expressionId == 137)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext137 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext137.GetLocation<int>(refDataContext137.ValueType___Expr137Get, refDataContext137.ValueType___Expr137Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 138)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext138 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext139 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext139.ValueType___Expr139Get();
            }
            if ((expressionId == 140)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext140 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext141 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext141.GetLocation<double>(refDataContext141.ValueType___Expr141Get, refDataContext141.ValueType___Expr141Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 142)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext142 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext142.ValueType___Expr142Get();
            }
            if ((expressionId == 143)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext143 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext143.GetLocation<double>(refDataContext143.ValueType___Expr143Get, refDataContext143.ValueType___Expr143Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 144)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext144 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext144.ValueType___Expr144Get();
            }
            if ((expressionId == 145)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext145 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext145.GetLocation<double>(refDataContext145.ValueType___Expr145Get, refDataContext145.ValueType___Expr145Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 146)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext146 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext146.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext146.ValueType___Expr146Get, refDataContext146.ValueType___Expr146Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 147)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext147 = ((F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext147.ValueType___Expr147Get();
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
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext0 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext1 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext2 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext3 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext4 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext5 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext6 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext7 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<JTL.Tax1040.BusinessObject.F1040EZ>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext8 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext9 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, true);
                return refDataContext9.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext10 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext11 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, true);
                return refDataContext11.GetLocation<JTL.Tax1040.BusinessObject.EICWorkSheet>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext12 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext13 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext14 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, true);
                return refDataContext14.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext15 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext16 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, true);
                return refDataContext16.GetLocation<JTL.Tax1040.BusinessObject.EICWorkSheet>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext17 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext18 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext19 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, true);
                return refDataContext19.GetLocation<System.Nullable<bool>>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext20 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext21 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext22 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext23 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext24 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, true);
                return refDataContext24.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext25 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, true);
                return refDataContext25.GetLocation<double>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext26 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext27 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext28 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, true);
                return refDataContext28.GetLocation<double>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext29 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext30 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, true);
                return refDataContext30.GetLocation<double>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext31 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext32 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext32.GetLocation<double>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext33 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext34 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext34.GetLocation<double>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext35 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext36 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext37 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext37.GetLocation<double>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set);
            }
            if ((expressionId == 38)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext38 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext39 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext39.GetLocation<int>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext40 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext41 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext41.GetLocation<int>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set);
            }
            if ((expressionId == 42)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext42 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext43 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext43.GetLocation<int>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext44 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext45 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext46 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext47 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext47.GetLocation<double>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
            }
            if ((expressionId == 48)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext48 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext49 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set);
            }
            if ((expressionId == 50)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext50 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext50.GetLocation<string>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set);
            }
            if ((expressionId == 51)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext51 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext52 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext52.GetLocation<System.Nullable<bool>>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set);
            }
            if ((expressionId == 53)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext53 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext54 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext54.GetLocation<double>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set);
            }
            if ((expressionId == 55)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext55 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext56 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext56.GetLocation<bool>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set);
            }
            if ((expressionId == 57)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext57 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext58 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext58.GetLocation<double>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set);
            }
            if ((expressionId == 59)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext59 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext60 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext60.GetLocation<bool>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set);
            }
            if ((expressionId == 61)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext61 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext61.GetLocation<bool>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext62 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext63 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext63.GetLocation<double>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set);
            }
            if ((expressionId == 64)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext64 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext65 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext65.GetLocation<double>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set);
            }
            if ((expressionId == 66)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext66 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext67 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext67.GetLocation<bool>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set);
            }
            if ((expressionId == 68)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext68 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext69 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext69.GetLocation<double>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set);
            }
            if ((expressionId == 70)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext70 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext71 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext71.GetLocation<int>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set);
            }
            if ((expressionId == 72)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext72 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext73 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext73.GetLocation<int>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set);
            }
            if ((expressionId == 74)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext74 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext75 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext75.GetLocation<int>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set);
            }
            if ((expressionId == 76)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext76 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext77 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext78 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext79 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext79.GetLocation<double>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set);
            }
            if ((expressionId == 80)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext80 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext81 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext81.GetLocation<double>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set);
            }
            if ((expressionId == 82)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly valDataContext82 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 refDataContext83 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locations, true);
                return refDataContext83.GetLocation<double>(refDataContext83.ValueType___Expr83Get, refDataContext83.ValueType___Expr83Set);
            }
            if ((expressionId == 84)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly valDataContext84 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly valDataContext85 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4 refDataContext86 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(locations, true);
                return refDataContext86.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set);
            }
            if ((expressionId == 87)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4 refDataContext87 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(locations, true);
                return refDataContext87.GetLocation<double>(refDataContext87.ValueType___Expr87Get, refDataContext87.ValueType___Expr87Set);
            }
            if ((expressionId == 88)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly valDataContext88 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly valDataContext89 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4 refDataContext90 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(locations, true);
                return refDataContext90.GetLocation<double>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set);
            }
            if ((expressionId == 91)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly valDataContext91 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext4 refDataContext92 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(locations, true);
                return refDataContext92.GetLocation<double>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set);
            }
            if ((expressionId == 93)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext93 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext94 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext94.GetLocation<double>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set);
            }
            if ((expressionId == 95)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext95 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext96 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext96.GetLocation<double>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set);
            }
            if ((expressionId == 97)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext97 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext98 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext99 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext99.GetLocation<double>(refDataContext99.ValueType___Expr99Get, refDataContext99.ValueType___Expr99Set);
            }
            if ((expressionId == 100)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext100 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext100.ValueType___Expr100Get();
            }
            if ((expressionId == 101)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext101 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext101.GetLocation<int>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set);
            }
            if ((expressionId == 102)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext102 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext103 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext103.GetLocation<int>(refDataContext103.ValueType___Expr103Get, refDataContext103.ValueType___Expr103Set);
            }
            if ((expressionId == 104)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext104 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext105 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext105.GetLocation<int>(refDataContext105.ValueType___Expr105Get, refDataContext105.ValueType___Expr105Set);
            }
            if ((expressionId == 106)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext106 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext107 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext108 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext109 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext109.GetLocation<double>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set);
            }
            if ((expressionId == 110)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext110 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext111 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext111.GetLocation<double>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set);
            }
            if ((expressionId == 112)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext112 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext112.GetLocation<string>(refDataContext112.ValueType___Expr112Get, refDataContext112.ValueType___Expr112Set);
            }
            if ((expressionId == 113)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext113 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext114 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext114.GetLocation<System.Nullable<bool>>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set);
            }
            if ((expressionId == 115)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext115 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext116 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext116.GetLocation<double>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set);
            }
            if ((expressionId == 117)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext117 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext118 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext118.GetLocation<bool>(refDataContext118.ValueType___Expr118Get, refDataContext118.ValueType___Expr118Set);
            }
            if ((expressionId == 119)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext119 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext119.ValueType___Expr119Get();
            }
            if ((expressionId == 120)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext120 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext120.GetLocation<double>(refDataContext120.ValueType___Expr120Get, refDataContext120.ValueType___Expr120Set);
            }
            if ((expressionId == 121)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext121 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext122 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext122.GetLocation<bool>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set);
            }
            if ((expressionId == 123)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext123 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext123.GetLocation<bool>(refDataContext123.ValueType___Expr123Get, refDataContext123.ValueType___Expr123Set);
            }
            if ((expressionId == 124)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext124 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext124.ValueType___Expr124Get();
            }
            if ((expressionId == 125)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext125 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext125.GetLocation<double>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set);
            }
            if ((expressionId == 126)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext126 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext127 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext127.GetLocation<double>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set);
            }
            if ((expressionId == 128)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext128 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext129 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext129.GetLocation<bool>(refDataContext129.ValueType___Expr129Get, refDataContext129.ValueType___Expr129Set);
            }
            if ((expressionId == 130)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext130 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext131 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext131.GetLocation<double>(refDataContext131.ValueType___Expr131Get, refDataContext131.ValueType___Expr131Set);
            }
            if ((expressionId == 132)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext132 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext132.ValueType___Expr132Get();
            }
            if ((expressionId == 133)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext133 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext133.GetLocation<int>(refDataContext133.ValueType___Expr133Get, refDataContext133.ValueType___Expr133Set);
            }
            if ((expressionId == 134)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext134 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext135 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext135.GetLocation<int>(refDataContext135.ValueType___Expr135Get, refDataContext135.ValueType___Expr135Set);
            }
            if ((expressionId == 136)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext136 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext136.ValueType___Expr136Get();
            }
            if ((expressionId == 137)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext137 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext137.GetLocation<int>(refDataContext137.ValueType___Expr137Get, refDataContext137.ValueType___Expr137Set);
            }
            if ((expressionId == 138)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext138 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext139 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext139.ValueType___Expr139Get();
            }
            if ((expressionId == 140)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext140 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext141 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext141.GetLocation<double>(refDataContext141.ValueType___Expr141Get, refDataContext141.ValueType___Expr141Set);
            }
            if ((expressionId == 142)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext142 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext142.ValueType___Expr142Get();
            }
            if ((expressionId == 143)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext143 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext143.GetLocation<double>(refDataContext143.ValueType___Expr143Get, refDataContext143.ValueType___Expr143Set);
            }
            if ((expressionId == 144)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly valDataContext144 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext144.ValueType___Expr144Get();
            }
            if ((expressionId == 145)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 refDataContext145 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locations, true);
                return refDataContext145.GetLocation<double>(refDataContext145.ValueType___Expr145Get, refDataContext145.ValueType___Expr145Set);
            }
            if ((expressionId == 146)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 refDataContext146 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locations, true);
                return refDataContext146.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext146.ValueType___Expr146Get, refDataContext146.ValueType___Expr146Set);
            }
            if ((expressionId == 147)) {
                F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly valDataContext147 = new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext147.ValueType___Expr147Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "new ConcurrentDictionary<int, int>(\n       new Dictionary<int, int>\n       {\n {1," +
                            "2},{50,6},{100,10},{150,13},{200,17},{250,21},{300,25},{350,29},{400,33},{450,36" +
                            "},{500,40},{550,44},{600,48},{650,52},{700,55},{750,59},{800,63},\n{850,67},{900," +
                            "71},{950,75},{1000,78},{1050,82},{1100,86},{1150,90},{1200,94},{1250,98},{1300,1" +
                            "01},{1350,105},{1400,109},{1450,113},{1500,117},{1550,120},\n{1600,124},{1650,128" +
                            "},{1700,132},{1750,136},{1800,140},{1850,143},{1900,147},{1950,151},{2000,155},{" +
                            "2050,159},{2100,163},{2150,166},{2200,170},{2250,174},\n{2300,178},{2350,182},{24" +
                            "00,186},{2450,189},{2500,193},{2550,197},{2600,201},{2650,205},{2700,208},{2750," +
                            "212},{2800,216},{2850,220},{2900,224},{2950,228},\n{3000,231},{3050,235},{3100,23" +
                            "9},{3150,243},{3200,247},{3250,251},{3300,254},{3350,258},{3400,262},{3450,266}," +
                            "{3500,270},{3550,273},{3600,277},{3650,281},\n{3700,285},{3750,289},{3800,293},{3" +
                            "850,296},{3900,300},{3950,304},{4000,308},{4050,312},{4100,316},{4150,319},{4200" +
                            ",323},{4250,327},{4300,331},{4350,335},\n{4400,339},{4450,342},{4500,346},{4550,3" +
                            "50},{4600,354},{4650,358},{4700,361},{4750,365},{4800,369},{4850,373},{4900,377}" +
                            ",{4950,381},{5000,384},{5050,388},\n{5100,392},{5150,396},{5200,400},{5250,404},{" +
                            "5300,407},{5350,411},{5400,415},{5450,419},{5500,423},{5550,426},{5600,430},{565" +
                            "0,434},{5700,438},{5750,442},\n{5800,446},{5850,449},{5900,453},{5950,457},{6000," +
                            "461},{6050,465},{6100,469},{6150,472},{6200,476},{6250,480},{6300,484},{6350,487" +
                            "},{6400,487},{6450,487},\n{6500,487},{6550,487},{6600,487},{6650,487},{6700,487}," +
                            "{6750,487},{6800,487},{6850,487},{6900,487},{6950,487},{7000,487},{7050,487},{71" +
                            "00,487},{7150,487},\n{7200,487},{7250,487},{7300,487},{7350,487},{7400,487},{7450" +
                            ",487},{7500,487},{7550,487},{7600,487},{7650,487},{7700,487},{7750,487},{7800,48" +
                            "7},{7850,487},\n{7900,487},{7950,487},{8000,483},{8050,479},{8100,475},{8150,472}" +
                            ",{8200,468},{8250,464},{8300,460},{8350,456},{8400,452},{8450,449},{8500,445},{8" +
                            "550,441},\n{8600,437},{8650,433},{8700,430},{8750,426},{8800,422},{8850,418},{890" +
                            "0,414},{8950,410},{9000,407},{9050,403},{9100,399},{9150,395},{9200,391},{9250,3" +
                            "87},\n{9300,384},{9350,380},{9400,376},{9450,372},{9500,368},{9550,365},{9600,361" +
                            "},{9650,357},{9700,353},{9750,349},{9800,345},{9850,342},{9900,338},{9950,334},\n" +
                            "{10000,330},{10050,326},{10100,322},{10150,319},{10200,315},{10250,311},{10300,3" +
                            "07},{10350,303},{10400,299},{10450,296},{10500,292},{10550,288},{10600,284},\n{10" +
                            "650,280},{10700,277},{10750,273},{10800,269},{10850,265},{10900,261},{10950,257}" +
                            ",{11000,254},{11050,250},{11100,246},{11150,242},{11200,238},{11250,234},\n{11300" +
                            ",231},{11350,227},{11400,223},{11450,219},{11500,215},{11550,212},{11600,208},{1" +
                            "1650,204},{11700,200},{11750,196},{11800,192},{11850,189},{11900,185},\n{11950,18" +
                            "1},{12000,177},{12050,173},{12100,169},{12150,166},{12200,162},{12250,158},{1230" +
                            "0,154},{12350,150},{12400,146},{12450,143},{12500,139},{12550,135},\n{12600,131}," +
                            "{12650,127},{12700,124},{12750,120},{12800,116},{12850,112},{12900,108},{12950,1" +
                            "04},{13000,101},{13050,97},{13100,93},{13150,89},{13200,85},{13250,81},\n{13300,7" +
                            "8},{13350,74},{13400,70},{13450,66},{13500,62},{13550,59},{13600,55},{13650,51}," +
                            "{13700,47},{13750,43},{13800,39},{13850,36},{13900,32},{13950,28},{14000,24},\n{1" +
                            "4050,20},{14100,16},{14150,13},{14200,9},{14250,5},{14300,2},{14350,2},{14400,0}" +
                            ",{14450,0},{14500,0},{14550,0},{14600,0},{14650,0},{14700,0},{14750,0},{14800,0}" +
                            ",\n{14850,0},{14900,0},{14950,0},{15000,0},{15050,0},{15100,0},{15150,0},{15200,0" +
                            "},{15250,0},{15300,0},{15350,0},{15400,0},{15450,0},{15500,0},{15550,0},{15600,0" +
                            "},\n{15650,0},{15700,0},{15750,0},{15800,0},{15850,0},{15900,0},{15950,0},{16000," +
                            "0},{16050,0},{16100,0},{16150,0},{16200,0},{16250,0},{16300,0},{16350,0},{16400," +
                            "0},\n{16450,0},{16500,0},{16550,0},{16600,0},{16650,0},{16700,0},{16750,0},{16800" +
                            ",0},{16850,0},{16900,0},{16950,0},{17000,0},{17050,0},{17100,0},{17150,0},{17200" +
                            ",0},\n{17250,0},{17300,0},{17350,0},{17400,0},{17450,0},{17500,0},{17550,0},{1760" +
                            "0,0},{17650,0},{17700,0},{17750,0},{17800,0},{17850,0},{17900,0},{17950,0},{1800" +
                            "0,0},\n{18050,0},{18100,0},{18150,0},{18200,0},{18250,0},{18300,0},{18350,0},{184" +
                            "00,0},{18450,0},{18500,0},{18550,0},{18600,0},{18650,0},{18700,0},{18750,0},{188" +
                            "00,0},\n{18850,0},{18900,0},{18950,0},{19000,0},{19050,0},{19100,0},{19150,0},{19" +
                            "200,0},{19250,0},{19300,0},{19350,0},{19400,0},{19450,0},{19500,0},{19550,0},{19" +
                            "600,0},\n{19650,0},{19680,0}\n       }\n    );") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new ConcurrentDictionary<int, int>(\n       new Dictionary<int, int>\n       {\n{1,2" +
                            "},\n\n{50,6},\n\n{100,10},{150,13},{200,17},\n{250,21},{300,25},{350,29},\n{400,33},{4" +
                            "50,36},{500,40},\n{550,44},{600,48},{650,52},\n{700,55},{750,59},{800,63},\n{850,67" +
                            "},{900,71},{950,75},\n\n{1000,78},{1050,82},{1100,86},\n{1150,90},{1200,94},{1250,9" +
                            "8},\n\n{1300,101},{1350,105},{1400,109},\n{1450,113},{1500,117},{1550,120},\n{1600,1" +
                            "24},{1650,128},{1700,132},\n{1750,136},{1800,140},{1850,143},\n{1900,147},{1950,15" +
                            "1},{2000,155},\n{2050,159},{2100,163},{2150,166},\n{2200,170},{2250,174},{2300,178" +
                            "},\n{2350,182},{2400,186},{2450,189},\n{2500,193},{2550,197},{2600,201},\n{2650,205" +
                            "},{2700,208},{2750,212},\n{2800,216},{2850,220},{2900,224},\n\n{2950,228},{3000,231" +
                            "},{3050,235},\n{3100,239},{3150,243},{3200,247},\n{3250,251},{3300,254},{3350,258}" +
                            ",\n{3400,262},{3450,266},{3500,270},\n{3550,273},{3600,277},{3650,281},\n{3700,285}" +
                            ",{3750,289},{3800,293},\n{3850,296},{3900,300},{3950,304},\n{4000,308},{4050,312}," +
                            "{4100,316},\n{4150,319},{4200,323},{4250,327},\n{4300,331},{4350,335},{4400,339},\n" +
                            "{4450,342},{4500,346},{4550,350},\n{4600,354},{4650,358},{4700,361},\n{4750,365},{" +
                            "4800,369},{4850,373},\n{4900,377},{4950,381},{5000,384},\n{5050,388},{5100,392},{5" +
                            "150,396},\n\n{5200,400},{5250,404},{5300,407},\n{5350,411},{5400,415},{5450,419},\n{" +
                            "5500,423},{5550,426},{5600,430},\n{5650,434},{5700,438},{5750,442},\n{5800,446},{5" +
                            "850,449},{5900,453},\n{5950,457},{6000,461},{6050,465},\n{6100,469},{6150,472},{62" +
                            "00,476},\n{6250,480},{6300,484},{6350,487},\n{6400,487},{6450,487},{6500,487},\n{65" +
                            "50,487},{6600,487},{6650,487},\n{6700,487},{6750,487},{6800,487},\n{6850,487},{690" +
                            "0,487},{6950,487},\n\n{7000,487},{7050,487},{7100,487},\n{7150,487},{7200,487},{725" +
                            "0,487},\n{7300,487},{7350,487},{7400,487},\n{7450,487},{7500,487},{7550,487},\n{760" +
                            "0,487},{7650,487},{7700,487},\n{7750,487},{7800,487},{7850,487},\n{7900,487},{7950" +
                            ",487},{8000,487},\n{8050,487},{8100,487},{8150,487},\n{8200,487},{8250,487},{8300," +
                            "487},\n{8350,487},{8400,487},{8450,487},\n\n{8500,487},{8550,487},{8600,487},\n{8650" +
                            ",487},{8700,487},{8750,487},\n{8800,487},{8850,487},{8900,487},\n{8950,487},{9000," +
                            "487},{9050,487},\n{9100,487},{9150,487},{9200,487},\n{9250,387},{9300,487},{9350,4" +
                            "87},\n{9400,487},{9450,487},{9500,487},\n{9550,487},{9600,487},{9650,487},\n{9700,4" +
                            "87},{9750,487},{9800,487},\n{9850,487},{9900,487},{9950,487},\n\n\n{10000,487},{1005" +
                            "0,487},{10100,487},\n{10150,487},{10200,487},{10250,487},\n{10300,487},{10350,487}" +
                            ",{10400,487},\n{10450,487},{10500,487},{10550,487},\n{10600,487},{10650,487},{1070" +
                            "0,487},\n{10750,487},{10800,487},{10850,487},\n{10900,487},{10950,487},{11000,487}" +
                            ",\n{11050,487},{11100,487},{11150,487},\n{11200,487},{11250,487},{11300,487},\n{113" +
                            "50,487},{11400,487},{11450,487},\n{11500,487},{11550,487},{11600,487},\n{11650,487" +
                            "},{11700,487},{11750,487},\n{11800,487},{11850,487},{11900,487},\n{11950,487},{120" +
                            "00,487},{12050,487},\n{12100,487},{12150,487},{12200,487},\n{12250,487},{12300,487" +
                            "},{12350,487},\n{12400,487},{12450,487},{12500,487},\n{12550,487},{12600,487},{126" +
                            "50,487},\n{12700,487},{12750,487},{12800,487},\n{12850,487},{12900,487},{12950,487" +
                            "},\n{13000,487},{13050,487},{13100,487},\n{13150,487},{13200,487},{13250,487},\n\n{1" +
                            "3300,487},{13350,482},{13400,479},\n{13450,475},{13500,471},{13550,467},\n{13600,4" +
                            "63},{13650,459},{13700,456},\n{13750,452},{13800,448},{13850,444},\n{13900,440},{1" +
                            "3950,436},{14000,433},\n{14050,429},{14100,425},{14150,421},\n{14200,417},{14250,4" +
                            "13},{14300,410},\n{14350,406},{14400,402},{14450,398},\n{14500,394},{14550,391},{1" +
                            "4600,387},\n{14650,383},{14700,379},{14750,375},\n{14800,371},{14850,368},{14900,3" +
                            "64},\n{14950,360},{15000,356},{15050,352},\n{15100,348},{15150,345},{15200,341},\n{" +
                            "15250,337},{15300,333},{15350,329},\n{15400,326},{15450,322},{15500,318},\n{15550," +
                            "314},{15600,310},{15650,306},\n{15700,303},{15750,299},{15800,295},\n{15850,291},{" +
                            "15900,287},{15950,283},\n\n{16000,280},{16050,276},{16100,272},\n{16150,268},{16200" +
                            ",264},{16250,260},\n{16300,257},{16350,253},{16400,249},\n{16450,245},{16500,241}," +
                            "{16550,238},\n{16600,234},{16650,230},{16700,226},\n{16750,222},{16800,218},{16850" +
                            ",215},\n{16900,211},{16950,207},{17000,203},\n{17050,199},{17100,195},{17150,192}," +
                            "\n{17200,188},{17250,184},{17300,180},\n{17350,176},{17400,173},{17450,169},\n{1750" +
                            "0,165},{17550,161},{17600,157},\n{17650,153},{17700,150},{17750,146},\n{17800,142}" +
                            ",{17850,138},{17900,134},\n{17950,130},{18000,127},{18050,123},\n{18100,119},{1815" +
                            "0,115},{18200,111},\n{18250,107},{18300,104},{18350,100},\n\n{18400,96},{18450,92}," +
                            "{18500,88},\n{18550,85},{18600,81},{18650,77},\n{18700,73},{18750,69},{18800,65},\n" +
                            "{18850,62},{18900,58},{18950,54},\n{19000,50},{19050,46},{19100,42},\n{19150,39},{" +
                            "19200,35},{19250,31},\n{19300,27},{19350,23},{19400,20},\n{19450,16},{19500,12},\n\n" +
                            "{19550,8},{19600,4},\n{19650,1},{19680,1}\n\n\t}\n  );") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object != null) &&(Tax1040Object.ErrorMessages.Count>0))") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ==null)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new F1040EZ()") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new F1040EZWorkSheets()") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new EICWorkSheet()") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ.F1040EZWorkSheets==null)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new F1040EZWorkSheets()") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new EICWorkSheet()") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.Credits!=null) && (Tax1040Object.Credits.HasEarnedIncomeCredits.Ha" +
                            "sValue)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits.HasEarnedIncomeCredits.Value") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.Primar" +
                            "yTaxPayer != null))") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income !=null") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Any()))") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Line8Step2W2NonTaxableCombatPay") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Credits != null) && (Tax1040Object.Credits.EIC != null))") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"((Tax1040Object.Credits.EIC.PensionAnnuity.HasValue) ? Tax1040Object.Credits.EIC.PensionAnnuity.Value : 0) + ((Tax1040Object.Credits.EIC.TaxableScholarshipCredit.HasValue) ? Tax1040Object.Credits.EIC.TaxableScholarshipCredit.Value : 0) + ((Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.HasValue) ? Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.Value : 0)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Line8Step2W2NonQualifiedPlansTotal") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages - Line8Step2W2NonQualifiedPla" +
                            "nsTotal + Line8Step2W2NonTaxableCombatPay") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Line8Step2EarnedIncome") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(int)Line8Step2EarnedIncome") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount >=14300  && Tax1" +
                            "040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount <= 14339") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount > EICInitialRang" +
                            "eStartValue && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount " +
                            "<= EICInitialRangeEndValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EICRateInitialValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount % EICModule" +
                            "Value;") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EICModuleDifference") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"(int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount != EICModuleDifference ? (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount - EICModuleDifference : (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EICStartingValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EICOut") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1040ezEICCollection") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EICStartingValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EICOut") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount == 0") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCreditPrefix") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "false") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(int)Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount == Tax1040Object" +
                            ".F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount < EICSingleLimi" +
                            "t)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine5Blank") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount >=14300 && Tax10" +
                            "40Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount <= 14339") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount > EICInitialRang" +
                            "eStartValue && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount " +
                            "<= EICInitialRangeEndValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EICRateInitialValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount % EICModule" +
                            "Value;") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EICModuleDifference") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"(int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount != EICModuleDifference ? (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount - EICModuleDifference : (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EICStartingValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EICOut") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1040ezEICCollection") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EICStartingValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EICOut") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount,Tax1040" +
                            "Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalEIC") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income !=null") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Any())") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Line8Step2W2NonTaxableCombatPay") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Credits != null) && (Tax1040Object.Credits.EIC != null))") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"((Tax1040Object.Credits.EIC.PensionAnnuity.HasValue) ? Tax1040Object.Credits.EIC.PensionAnnuity.Value : 0) + ((Tax1040Object.Credits.EIC.TaxableScholarshipCredit.HasValue) ? Tax1040Object.Credits.EIC.TaxableScholarshipCredit.Value : 0) + ((Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.HasValue) ? Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.Value : 0)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Line8Step2W2NonQualifiedPlansTotal") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages - Line8Step2W2NonQualifiedPla" +
                            "nsTotal + Line8Step2W2NonTaxableCombatPay") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Line8Step2EarnedIncome") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(int)Line8Step2EarnedIncome") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount >= 19650 && Tax1" +
                            "040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount <= 19679") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount > EICInitialRang" +
                            "eStartValue && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount " +
                            "<= EICInitialRangeEndValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EICRateInitialValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount % EICModule" +
                            "Value;") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EICModuleDifference") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"(int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount != EICModuleDifference ? (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount - EICModuleDifference : (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EICStartingValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EICOut") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1040ezMFJEICCollection") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EICStartingValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EICOut") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount == 0") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCreditPrefix") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "false") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(int)Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 116;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount == Tax1040Object" +
                            ".F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 117;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 118;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 119;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 120;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount < EICMFJLimit)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 121;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 122;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine5Blank") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 123;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 124;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 125;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount >= 19650 && Tax1" +
                            "040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount <= 19679") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 126;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 127;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount > EICInitialRang" +
                            "eStartValue && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount " +
                            "<= EICInitialRangeEndValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 128;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 129;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EICRateInitialValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 130;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 131;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount % EICModule" +
                            "Value;") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 132;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EICModuleDifference") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 133;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"(int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount != EICModuleDifference ? (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount - EICModuleDifference : (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 134;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EICStartingValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 135;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 136;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EICOut") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 137;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1040ezMFJEICCollection") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 138;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EICStartingValue") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 139;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EICOut") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 140;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 141;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount,Tax1040" +
                            "Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount)") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 142;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 143;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 144;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalEIC") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 145;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 146;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 147;
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
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr109GetTree();
            }
            if ((expressionId == 110)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr110GetTree();
            }
            if ((expressionId == 111)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr111GetTree();
            }
            if ((expressionId == 112)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr112GetTree();
            }
            if ((expressionId == 113)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr113GetTree();
            }
            if ((expressionId == 114)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr114GetTree();
            }
            if ((expressionId == 115)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr115GetTree();
            }
            if ((expressionId == 116)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr116GetTree();
            }
            if ((expressionId == 117)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr117GetTree();
            }
            if ((expressionId == 118)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr118GetTree();
            }
            if ((expressionId == 119)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr119GetTree();
            }
            if ((expressionId == 120)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr120GetTree();
            }
            if ((expressionId == 121)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr121GetTree();
            }
            if ((expressionId == 122)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr122GetTree();
            }
            if ((expressionId == 123)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr123GetTree();
            }
            if ((expressionId == 124)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr124GetTree();
            }
            if ((expressionId == 125)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr125GetTree();
            }
            if ((expressionId == 126)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr126GetTree();
            }
            if ((expressionId == 127)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr127GetTree();
            }
            if ((expressionId == 128)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr128GetTree();
            }
            if ((expressionId == 129)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr129GetTree();
            }
            if ((expressionId == 130)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr130GetTree();
            }
            if ((expressionId == 131)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr131GetTree();
            }
            if ((expressionId == 132)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr132GetTree();
            }
            if ((expressionId == 133)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr133GetTree();
            }
            if ((expressionId == 134)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr134GetTree();
            }
            if ((expressionId == 135)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr135GetTree();
            }
            if ((expressionId == 136)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr136GetTree();
            }
            if ((expressionId == 137)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr137GetTree();
            }
            if ((expressionId == 138)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr138GetTree();
            }
            if ((expressionId == 139)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr139GetTree();
            }
            if ((expressionId == 140)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr140GetTree();
            }
            if ((expressionId == 141)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr141GetTree();
            }
            if ((expressionId == 142)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr142GetTree();
            }
            if ((expressionId == 143)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr143GetTree();
            }
            if ((expressionId == 144)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr144GetTree();
            }
            if ((expressionId == 145)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(locationReferences).@__Expr145GetTree();
            }
            if ((expressionId == 146)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(locationReferences).@__Expr146GetTree();
            }
            if ((expressionId == 147)) {
                return new F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr147GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEarnedIncomeCreditCalculation_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZEarnedIncomeCreditCalculation_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZEarnedIncomeCreditCalculation_TypedDataContext1 : F1040EZEarnedIncomeCreditCalculation_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalEIC;
            
            protected int EICOut;
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                    return ((JTL.Tax1040.Core.Object.ErrorMessages)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
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
                this.TotalEIC = ((double)(this.GetVariableValue((1 + locationsOffset))));
                this.EICOut = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.TotalEIC);
                this.SetVariableValue((3 + locationsOffset), this.EICOut);
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
                if (((locationReferences[(offset + 0)].Name != "Tax1040Object") 
                            || (locationReferences[(offset + 0)].Type != typeof(JTL.Tax1040.BusinessObject.Tax1040)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "ErrorMessages") 
                            || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessages)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "TotalEIC") 
                            || (locationReferences[(offset + 1)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "EICOut") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZEarnedIncomeCreditCalculation_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEarnedIncomeCreditCalculation_TypedDataContext1_ForReadOnly : F1040EZEarnedIncomeCreditCalculation_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalEIC;
            
            protected int EICOut;
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Tax1040 Tax1040Object {
                get {
                    return ((JTL.Tax1040.BusinessObject.Tax1040)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected JTL.Tax1040.Core.Object.ErrorMessages ErrorMessages {
                get {
                    return ((JTL.Tax1040.Core.Object.ErrorMessages)(this.GetVariableValue((2 + locationsOffset))));
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
                this.TotalEIC = ((double)(this.GetVariableValue((1 + locationsOffset))));
                this.EICOut = ((int)(this.GetVariableValue((3 + locationsOffset))));
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
                if (((locationReferences[(offset + 0)].Name != "Tax1040Object") 
                            || (locationReferences[(offset + 0)].Type != typeof(JTL.Tax1040.BusinessObject.Tax1040)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "ErrorMessages") 
                            || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessages)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "TotalEIC") 
                            || (locationReferences[(offset + 1)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "EICOut") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZEarnedIncomeCreditCalculation_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 : F1040EZEarnedIncomeCreditCalculation_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Range1TaxRate;
            
            protected JTL.Tax1040.Core.Object.EmployerCode W2EmployerCode;
            
            protected double TaxableScholarShipTotal;
            
            protected double PensionAnnuityTotal;
            
            protected double PenalInstitutionIncomeTotal;
            
            protected double Line8Step2W2NonQualifiedPlansTotal;
            
            protected double Line8Step2EarnedIncome;
            
            protected double Line8Step2W2NonQualifiedPlans;
            
            protected double Line8Step2W2NonTaxableCombatPay;
            
            protected double EICSingleLimit;
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Concurrent.ConcurrentDictionary<int, int> Form1040ezEICCollection {
                get {
                    return ((System.Collections.Concurrent.ConcurrentDictionary<int, int>)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Concurrent.ConcurrentDictionary<int, int> Form1040ezMFJEICCollection {
                get {
                    return ((System.Collections.Concurrent.ConcurrentDictionary<int, int>)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected JTL.Tax1040.BusinessObject.EIC EIC {
                get {
                    return ((JTL.Tax1040.BusinessObject.EIC)(this.GetVariableValue((11 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((11 + locationsOffset), value);
                }
            }
            
            protected JTL.Tax1040.BusinessObject.W2 W2 {
                get {
                    return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((12 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 283 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr2Get() {
                
                #line 283 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
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
                
                #line 283 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 307 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZ>> expression = () => 
                        Tax1040Object.F1040EZ;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZ @__Expr7Get() {
                
                #line 307 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                        Tax1040Object.F1040EZ;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZ ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(JTL.Tax1040.BusinessObject.F1040EZ value) {
                
                #line 307 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                        Tax1040Object.F1040EZ = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(JTL.Tax1040.BusinessObject.F1040EZ value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 319 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                        Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr9Get() {
                
                #line 319 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                        Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                
                #line 319 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                        Tax1040Object.F1040EZ.F1040EZWorkSheets = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 331 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.EICWorkSheet>> expression = () => 
                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.EICWorkSheet @__Expr11Get() {
                
                #line 331 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.EICWorkSheet ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(JTL.Tax1040.BusinessObject.EICWorkSheet value) {
                
                #line 331 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(JTL.Tax1040.BusinessObject.EICWorkSheet value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 354 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                            Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr14Get() {
                
                #line 354 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                            Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                
                #line 354 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                            Tax1040Object.F1040EZ.F1040EZWorkSheets = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 371 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.EICWorkSheet>> expression = () => 
                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.EICWorkSheet @__Expr16Get() {
                
                #line 371 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.EICWorkSheet ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(JTL.Tax1040.BusinessObject.EICWorkSheet value) {
                
                #line 371 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(JTL.Tax1040.BusinessObject.EICWorkSheet value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 390 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                      Tax1040Object.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr19Get() {
                
                #line 390 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                      Tax1040Object.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(System.Nullable<bool> value) {
                
                #line 390 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                      Tax1040Object.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(System.Nullable<bool> value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 436 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                      Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr24Get() {
                
                #line 436 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                      Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 436 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                      Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 441 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      Line8Step2W2NonTaxableCombatPay;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr25Get() {
                
                #line 441 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                      Line8Step2W2NonTaxableCombatPay;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(double value) {
                
                #line 441 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                      Line8Step2W2NonTaxableCombatPay = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 460 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Line8Step2W2NonQualifiedPlansTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr28Get() {
                
                #line 460 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                Line8Step2W2NonQualifiedPlansTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(double value) {
                
                #line 460 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                Line8Step2W2NonQualifiedPlansTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 474 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Line8Step2EarnedIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr30Get() {
                
                #line 474 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                            Line8Step2EarnedIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(double value) {
                
                #line 474 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                            Line8Step2EarnedIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr146GetTree() {
                
                #line 1407 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                      Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr146Get() {
                
                #line 1407 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                      Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr146Get() {
                this.GetValueTypeValues();
                return this.@__Expr146Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr146Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 1407 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                      Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr146Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr146Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Range1TaxRate = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.W2EmployerCode = ((JTL.Tax1040.Core.Object.EmployerCode)(this.GetVariableValue((7 + locationsOffset))));
                this.TaxableScholarShipTotal = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.PensionAnnuityTotal = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.PenalInstitutionIncomeTotal = ((double)(this.GetVariableValue((10 + locationsOffset))));
                this.Line8Step2W2NonQualifiedPlansTotal = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.Line8Step2EarnedIncome = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.Line8Step2W2NonQualifiedPlans = ((double)(this.GetVariableValue((15 + locationsOffset))));
                this.Line8Step2W2NonTaxableCombatPay = ((double)(this.GetVariableValue((16 + locationsOffset))));
                this.EICSingleLimit = ((double)(this.GetVariableValue((17 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.Range1TaxRate);
                this.SetVariableValue((7 + locationsOffset), this.W2EmployerCode);
                this.SetVariableValue((8 + locationsOffset), this.TaxableScholarShipTotal);
                this.SetVariableValue((9 + locationsOffset), this.PensionAnnuityTotal);
                this.SetVariableValue((10 + locationsOffset), this.PenalInstitutionIncomeTotal);
                this.SetVariableValue((13 + locationsOffset), this.Line8Step2W2NonQualifiedPlansTotal);
                this.SetVariableValue((14 + locationsOffset), this.Line8Step2EarnedIncome);
                this.SetVariableValue((15 + locationsOffset), this.Line8Step2W2NonQualifiedPlans);
                this.SetVariableValue((16 + locationsOffset), this.Line8Step2W2NonTaxableCombatPay);
                this.SetVariableValue((17 + locationsOffset), this.EICSingleLimit);
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
                if (((locationReferences[(offset + 4)].Name != "Form1040ezEICCollection") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Collections.Concurrent.ConcurrentDictionary<int, int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Form1040ezMFJEICCollection") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Collections.Concurrent.ConcurrentDictionary<int, int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "EIC") 
                            || (locationReferences[(offset + 11)].Type != typeof(JTL.Tax1040.BusinessObject.EIC)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "W2") 
                            || (locationReferences[(offset + 12)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Range1TaxRate") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "W2EmployerCode") 
                            || (locationReferences[(offset + 7)].Type != typeof(JTL.Tax1040.Core.Object.EmployerCode)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "TaxableScholarShipTotal") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "PensionAnnuityTotal") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "PenalInstitutionIncomeTotal") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Line8Step2W2NonQualifiedPlansTotal") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "Line8Step2EarnedIncome") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "Line8Step2W2NonQualifiedPlans") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "Line8Step2W2NonTaxableCombatPay") 
                            || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "EICSingleLimit") 
                            || (locationReferences[(offset + 17)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEarnedIncomeCreditCalculation_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly : F1040EZEarnedIncomeCreditCalculation_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Range1TaxRate;
            
            protected JTL.Tax1040.Core.Object.EmployerCode W2EmployerCode;
            
            protected double TaxableScholarShipTotal;
            
            protected double PensionAnnuityTotal;
            
            protected double PenalInstitutionIncomeTotal;
            
            protected double Line8Step2W2NonQualifiedPlansTotal;
            
            protected double Line8Step2EarnedIncome;
            
            protected double Line8Step2W2NonQualifiedPlans;
            
            protected double Line8Step2W2NonTaxableCombatPay;
            
            protected double EICSingleLimit;
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Concurrent.ConcurrentDictionary<int, int> Form1040ezEICCollection {
                get {
                    return ((System.Collections.Concurrent.ConcurrentDictionary<int, int>)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected System.Collections.Concurrent.ConcurrentDictionary<int, int> Form1040ezMFJEICCollection {
                get {
                    return ((System.Collections.Concurrent.ConcurrentDictionary<int, int>)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected JTL.Tax1040.BusinessObject.EIC EIC {
                get {
                    return ((JTL.Tax1040.BusinessObject.EIC)(this.GetVariableValue((11 + locationsOffset))));
                }
            }
            
            protected JTL.Tax1040.BusinessObject.W2 W2 {
                get {
                    return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((12 + locationsOffset))));
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
                
                #line 69 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Concurrent.ConcurrentDictionary<int, int>>> expression = () => 
          new ConcurrentDictionary<int, int>(
       new Dictionary<int, int>
       {
 {1,2},{50,6},{100,10},{150,13},{200,17},{250,21},{300,25},{350,29},{400,33},{450,36},{500,40},{550,44},{600,48},{650,52},{700,55},{750,59},{800,63},
{850,67},{900,71},{950,75},{1000,78},{1050,82},{1100,86},{1150,90},{1200,94},{1250,98},{1300,101},{1350,105},{1400,109},{1450,113},{1500,117},{1550,120},
{1600,124},{1650,128},{1700,132},{1750,136},{1800,140},{1850,143},{1900,147},{1950,151},{2000,155},{2050,159},{2100,163},{2150,166},{2200,170},{2250,174},
{2300,178},{2350,182},{2400,186},{2450,189},{2500,193},{2550,197},{2600,201},{2650,205},{2700,208},{2750,212},{2800,216},{2850,220},{2900,224},{2950,228},
{3000,231},{3050,235},{3100,239},{3150,243},{3200,247},{3250,251},{3300,254},{3350,258},{3400,262},{3450,266},{3500,270},{3550,273},{3600,277},{3650,281},
{3700,285},{3750,289},{3800,293},{3850,296},{3900,300},{3950,304},{4000,308},{4050,312},{4100,316},{4150,319},{4200,323},{4250,327},{4300,331},{4350,335},
{4400,339},{4450,342},{4500,346},{4550,350},{4600,354},{4650,358},{4700,361},{4750,365},{4800,369},{4850,373},{4900,377},{4950,381},{5000,384},{5050,388},
{5100,392},{5150,396},{5200,400},{5250,404},{5300,407},{5350,411},{5400,415},{5450,419},{5500,423},{5550,426},{5600,430},{5650,434},{5700,438},{5750,442},
{5800,446},{5850,449},{5900,453},{5950,457},{6000,461},{6050,465},{6100,469},{6150,472},{6200,476},{6250,480},{6300,484},{6350,487},{6400,487},{6450,487},
{6500,487},{6550,487},{6600,487},{6650,487},{6700,487},{6750,487},{6800,487},{6850,487},{6900,487},{6950,487},{7000,487},{7050,487},{7100,487},{7150,487},
{7200,487},{7250,487},{7300,487},{7350,487},{7400,487},{7450,487},{7500,487},{7550,487},{7600,487},{7650,487},{7700,487},{7750,487},{7800,487},{7850,487},
{7900,487},{7950,487},{8000,483},{8050,479},{8100,475},{8150,472},{8200,468},{8250,464},{8300,460},{8350,456},{8400,452},{8450,449},{8500,445},{8550,441},
{8600,437},{8650,433},{8700,430},{8750,426},{8800,422},{8850,418},{8900,414},{8950,410},{9000,407},{9050,403},{9100,399},{9150,395},{9200,391},{9250,387},
{9300,384},{9350,380},{9400,376},{9450,372},{9500,368},{9550,365},{9600,361},{9650,357},{9700,353},{9750,349},{9800,345},{9850,342},{9900,338},{9950,334},
{10000,330},{10050,326},{10100,322},{10150,319},{10200,315},{10250,311},{10300,307},{10350,303},{10400,299},{10450,296},{10500,292},{10550,288},{10600,284},
{10650,280},{10700,277},{10750,273},{10800,269},{10850,265},{10900,261},{10950,257},{11000,254},{11050,250},{11100,246},{11150,242},{11200,238},{11250,234},
{11300,231},{11350,227},{11400,223},{11450,219},{11500,215},{11550,212},{11600,208},{11650,204},{11700,200},{11750,196},{11800,192},{11850,189},{11900,185},
{11950,181},{12000,177},{12050,173},{12100,169},{12150,166},{12200,162},{12250,158},{12300,154},{12350,150},{12400,146},{12450,143},{12500,139},{12550,135},
{12600,131},{12650,127},{12700,124},{12750,120},{12800,116},{12850,112},{12900,108},{12950,104},{13000,101},{13050,97},{13100,93},{13150,89},{13200,85},{13250,81},
{13300,78},{13350,74},{13400,70},{13450,66},{13500,62},{13550,59},{13600,55},{13650,51},{13700,47},{13750,43},{13800,39},{13850,36},{13900,32},{13950,28},{14000,24},
{14050,20},{14100,16},{14150,13},{14200,9},{14250,5},{14300,2},{14350,2},{14400,0},{14450,0},{14500,0},{14550,0},{14600,0},{14650,0},{14700,0},{14750,0},{14800,0},
{14850,0},{14900,0},{14950,0},{15000,0},{15050,0},{15100,0},{15150,0},{15200,0},{15250,0},{15300,0},{15350,0},{15400,0},{15450,0},{15500,0},{15550,0},{15600,0},
{15650,0},{15700,0},{15750,0},{15800,0},{15850,0},{15900,0},{15950,0},{16000,0},{16050,0},{16100,0},{16150,0},{16200,0},{16250,0},{16300,0},{16350,0},{16400,0},
{16450,0},{16500,0},{16550,0},{16600,0},{16650,0},{16700,0},{16750,0},{16800,0},{16850,0},{16900,0},{16950,0},{17000,0},{17050,0},{17100,0},{17150,0},{17200,0},
{17250,0},{17300,0},{17350,0},{17400,0},{17450,0},{17500,0},{17550,0},{17600,0},{17650,0},{17700,0},{17750,0},{17800,0},{17850,0},{17900,0},{17950,0},{18000,0},
{18050,0},{18100,0},{18150,0},{18200,0},{18250,0},{18300,0},{18350,0},{18400,0},{18450,0},{18500,0},{18550,0},{18600,0},{18650,0},{18700,0},{18750,0},{18800,0},
{18850,0},{18900,0},{18950,0},{19000,0},{19050,0},{19100,0},{19150,0},{19200,0},{19250,0},{19300,0},{19350,0},{19400,0},{19450,0},{19500,0},{19550,0},{19600,0},
{19650,0},{19680,0}
       }
    );;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Concurrent.ConcurrentDictionary<int, int> @__Expr0Get() {
                
                #line 69 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
          new ConcurrentDictionary<int, int>(
       new Dictionary<int, int>
       {
 {1,2},{50,6},{100,10},{150,13},{200,17},{250,21},{300,25},{350,29},{400,33},{450,36},{500,40},{550,44},{600,48},{650,52},{700,55},{750,59},{800,63},
{850,67},{900,71},{950,75},{1000,78},{1050,82},{1100,86},{1150,90},{1200,94},{1250,98},{1300,101},{1350,105},{1400,109},{1450,113},{1500,117},{1550,120},
{1600,124},{1650,128},{1700,132},{1750,136},{1800,140},{1850,143},{1900,147},{1950,151},{2000,155},{2050,159},{2100,163},{2150,166},{2200,170},{2250,174},
{2300,178},{2350,182},{2400,186},{2450,189},{2500,193},{2550,197},{2600,201},{2650,205},{2700,208},{2750,212},{2800,216},{2850,220},{2900,224},{2950,228},
{3000,231},{3050,235},{3100,239},{3150,243},{3200,247},{3250,251},{3300,254},{3350,258},{3400,262},{3450,266},{3500,270},{3550,273},{3600,277},{3650,281},
{3700,285},{3750,289},{3800,293},{3850,296},{3900,300},{3950,304},{4000,308},{4050,312},{4100,316},{4150,319},{4200,323},{4250,327},{4300,331},{4350,335},
{4400,339},{4450,342},{4500,346},{4550,350},{4600,354},{4650,358},{4700,361},{4750,365},{4800,369},{4850,373},{4900,377},{4950,381},{5000,384},{5050,388},
{5100,392},{5150,396},{5200,400},{5250,404},{5300,407},{5350,411},{5400,415},{5450,419},{5500,423},{5550,426},{5600,430},{5650,434},{5700,438},{5750,442},
{5800,446},{5850,449},{5900,453},{5950,457},{6000,461},{6050,465},{6100,469},{6150,472},{6200,476},{6250,480},{6300,484},{6350,487},{6400,487},{6450,487},
{6500,487},{6550,487},{6600,487},{6650,487},{6700,487},{6750,487},{6800,487},{6850,487},{6900,487},{6950,487},{7000,487},{7050,487},{7100,487},{7150,487},
{7200,487},{7250,487},{7300,487},{7350,487},{7400,487},{7450,487},{7500,487},{7550,487},{7600,487},{7650,487},{7700,487},{7750,487},{7800,487},{7850,487},
{7900,487},{7950,487},{8000,483},{8050,479},{8100,475},{8150,472},{8200,468},{8250,464},{8300,460},{8350,456},{8400,452},{8450,449},{8500,445},{8550,441},
{8600,437},{8650,433},{8700,430},{8750,426},{8800,422},{8850,418},{8900,414},{8950,410},{9000,407},{9050,403},{9100,399},{9150,395},{9200,391},{9250,387},
{9300,384},{9350,380},{9400,376},{9450,372},{9500,368},{9550,365},{9600,361},{9650,357},{9700,353},{9750,349},{9800,345},{9850,342},{9900,338},{9950,334},
{10000,330},{10050,326},{10100,322},{10150,319},{10200,315},{10250,311},{10300,307},{10350,303},{10400,299},{10450,296},{10500,292},{10550,288},{10600,284},
{10650,280},{10700,277},{10750,273},{10800,269},{10850,265},{10900,261},{10950,257},{11000,254},{11050,250},{11100,246},{11150,242},{11200,238},{11250,234},
{11300,231},{11350,227},{11400,223},{11450,219},{11500,215},{11550,212},{11600,208},{11650,204},{11700,200},{11750,196},{11800,192},{11850,189},{11900,185},
{11950,181},{12000,177},{12050,173},{12100,169},{12150,166},{12200,162},{12250,158},{12300,154},{12350,150},{12400,146},{12450,143},{12500,139},{12550,135},
{12600,131},{12650,127},{12700,124},{12750,120},{12800,116},{12850,112},{12900,108},{12950,104},{13000,101},{13050,97},{13100,93},{13150,89},{13200,85},{13250,81},
{13300,78},{13350,74},{13400,70},{13450,66},{13500,62},{13550,59},{13600,55},{13650,51},{13700,47},{13750,43},{13800,39},{13850,36},{13900,32},{13950,28},{14000,24},
{14050,20},{14100,16},{14150,13},{14200,9},{14250,5},{14300,2},{14350,2},{14400,0},{14450,0},{14500,0},{14550,0},{14600,0},{14650,0},{14700,0},{14750,0},{14800,0},
{14850,0},{14900,0},{14950,0},{15000,0},{15050,0},{15100,0},{15150,0},{15200,0},{15250,0},{15300,0},{15350,0},{15400,0},{15450,0},{15500,0},{15550,0},{15600,0},
{15650,0},{15700,0},{15750,0},{15800,0},{15850,0},{15900,0},{15950,0},{16000,0},{16050,0},{16100,0},{16150,0},{16200,0},{16250,0},{16300,0},{16350,0},{16400,0},
{16450,0},{16500,0},{16550,0},{16600,0},{16650,0},{16700,0},{16750,0},{16800,0},{16850,0},{16900,0},{16950,0},{17000,0},{17050,0},{17100,0},{17150,0},{17200,0},
{17250,0},{17300,0},{17350,0},{17400,0},{17450,0},{17500,0},{17550,0},{17600,0},{17650,0},{17700,0},{17750,0},{17800,0},{17850,0},{17900,0},{17950,0},{18000,0},
{18050,0},{18100,0},{18150,0},{18200,0},{18250,0},{18300,0},{18350,0},{18400,0},{18450,0},{18500,0},{18550,0},{18600,0},{18650,0},{18700,0},{18750,0},{18800,0},
{18850,0},{18900,0},{18950,0},{19000,0},{19050,0},{19100,0},{19150,0},{19200,0},{19250,0},{19300,0},{19350,0},{19400,0},{19450,0},{19500,0},{19550,0},{19600,0},
{19650,0},{19680,0}
       }
    );;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Concurrent.ConcurrentDictionary<int, int> ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 107 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Concurrent.ConcurrentDictionary<int, int>>> expression = () => 
          new ConcurrentDictionary<int, int>(
       new Dictionary<int, int>
       {
{1,2},

{50,6},

{100,10},{150,13},{200,17},
{250,21},{300,25},{350,29},
{400,33},{450,36},{500,40},
{550,44},{600,48},{650,52},
{700,55},{750,59},{800,63},
{850,67},{900,71},{950,75},

{1000,78},{1050,82},{1100,86},
{1150,90},{1200,94},{1250,98},

{1300,101},{1350,105},{1400,109},
{1450,113},{1500,117},{1550,120},
{1600,124},{1650,128},{1700,132},
{1750,136},{1800,140},{1850,143},
{1900,147},{1950,151},{2000,155},
{2050,159},{2100,163},{2150,166},
{2200,170},{2250,174},{2300,178},
{2350,182},{2400,186},{2450,189},
{2500,193},{2550,197},{2600,201},
{2650,205},{2700,208},{2750,212},
{2800,216},{2850,220},{2900,224},

{2950,228},{3000,231},{3050,235},
{3100,239},{3150,243},{3200,247},
{3250,251},{3300,254},{3350,258},
{3400,262},{3450,266},{3500,270},
{3550,273},{3600,277},{3650,281},
{3700,285},{3750,289},{3800,293},
{3850,296},{3900,300},{3950,304},
{4000,308},{4050,312},{4100,316},
{4150,319},{4200,323},{4250,327},
{4300,331},{4350,335},{4400,339},
{4450,342},{4500,346},{4550,350},
{4600,354},{4650,358},{4700,361},
{4750,365},{4800,369},{4850,373},
{4900,377},{4950,381},{5000,384},
{5050,388},{5100,392},{5150,396},

{5200,400},{5250,404},{5300,407},
{5350,411},{5400,415},{5450,419},
{5500,423},{5550,426},{5600,430},
{5650,434},{5700,438},{5750,442},
{5800,446},{5850,449},{5900,453},
{5950,457},{6000,461},{6050,465},
{6100,469},{6150,472},{6200,476},
{6250,480},{6300,484},{6350,487},
{6400,487},{6450,487},{6500,487},
{6550,487},{6600,487},{6650,487},
{6700,487},{6750,487},{6800,487},
{6850,487},{6900,487},{6950,487},

{7000,487},{7050,487},{7100,487},
{7150,487},{7200,487},{7250,487},
{7300,487},{7350,487},{7400,487},
{7450,487},{7500,487},{7550,487},
{7600,487},{7650,487},{7700,487},
{7750,487},{7800,487},{7850,487},
{7900,487},{7950,487},{8000,487},
{8050,487},{8100,487},{8150,487},
{8200,487},{8250,487},{8300,487},
{8350,487},{8400,487},{8450,487},

{8500,487},{8550,487},{8600,487},
{8650,487},{8700,487},{8750,487},
{8800,487},{8850,487},{8900,487},
{8950,487},{9000,487},{9050,487},
{9100,487},{9150,487},{9200,487},
{9250,387},{9300,487},{9350,487},
{9400,487},{9450,487},{9500,487},
{9550,487},{9600,487},{9650,487},
{9700,487},{9750,487},{9800,487},
{9850,487},{9900,487},{9950,487},


{10000,487},{10050,487},{10100,487},
{10150,487},{10200,487},{10250,487},
{10300,487},{10350,487},{10400,487},
{10450,487},{10500,487},{10550,487},
{10600,487},{10650,487},{10700,487},
{10750,487},{10800,487},{10850,487},
{10900,487},{10950,487},{11000,487},
{11050,487},{11100,487},{11150,487},
{11200,487},{11250,487},{11300,487},
{11350,487},{11400,487},{11450,487},
{11500,487},{11550,487},{11600,487},
{11650,487},{11700,487},{11750,487},
{11800,487},{11850,487},{11900,487},
{11950,487},{12000,487},{12050,487},
{12100,487},{12150,487},{12200,487},
{12250,487},{12300,487},{12350,487},
{12400,487},{12450,487},{12500,487},
{12550,487},{12600,487},{12650,487},
{12700,487},{12750,487},{12800,487},
{12850,487},{12900,487},{12950,487},
{13000,487},{13050,487},{13100,487},
{13150,487},{13200,487},{13250,487},

{13300,487},{13350,482},{13400,479},
{13450,475},{13500,471},{13550,467},
{13600,463},{13650,459},{13700,456},
{13750,452},{13800,448},{13850,444},
{13900,440},{13950,436},{14000,433},
{14050,429},{14100,425},{14150,421},
{14200,417},{14250,413},{14300,410},
{14350,406},{14400,402},{14450,398},
{14500,394},{14550,391},{14600,387},
{14650,383},{14700,379},{14750,375},
{14800,371},{14850,368},{14900,364},
{14950,360},{15000,356},{15050,352},
{15100,348},{15150,345},{15200,341},
{15250,337},{15300,333},{15350,329},
{15400,326},{15450,322},{15500,318},
{15550,314},{15600,310},{15650,306},
{15700,303},{15750,299},{15800,295},
{15850,291},{15900,287},{15950,283},

{16000,280},{16050,276},{16100,272},
{16150,268},{16200,264},{16250,260},
{16300,257},{16350,253},{16400,249},
{16450,245},{16500,241},{16550,238},
{16600,234},{16650,230},{16700,226},
{16750,222},{16800,218},{16850,215},
{16900,211},{16950,207},{17000,203},
{17050,199},{17100,195},{17150,192},
{17200,188},{17250,184},{17300,180},
{17350,176},{17400,173},{17450,169},
{17500,165},{17550,161},{17600,157},
{17650,153},{17700,150},{17750,146},
{17800,142},{17850,138},{17900,134},
{17950,130},{18000,127},{18050,123},
{18100,119},{18150,115},{18200,111},
{18250,107},{18300,104},{18350,100},

{18400,96},{18450,92},{18500,88},
{18550,85},{18600,81},{18650,77},
{18700,73},{18750,69},{18800,65},
{18850,62},{18900,58},{18950,54},
{19000,50},{19050,46},{19100,42},
{19150,39},{19200,35},{19250,31},
{19300,27},{19350,23},{19400,20},
{19450,16},{19500,12},

{19550,8},{19600,4},
{19650,1},{19680,1}

	}
  );;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Concurrent.ConcurrentDictionary<int, int> @__Expr1Get() {
                
                #line 107 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
          new ConcurrentDictionary<int, int>(
       new Dictionary<int, int>
       {
{1,2},

{50,6},

{100,10},{150,13},{200,17},
{250,21},{300,25},{350,29},
{400,33},{450,36},{500,40},
{550,44},{600,48},{650,52},
{700,55},{750,59},{800,63},
{850,67},{900,71},{950,75},

{1000,78},{1050,82},{1100,86},
{1150,90},{1200,94},{1250,98},

{1300,101},{1350,105},{1400,109},
{1450,113},{1500,117},{1550,120},
{1600,124},{1650,128},{1700,132},
{1750,136},{1800,140},{1850,143},
{1900,147},{1950,151},{2000,155},
{2050,159},{2100,163},{2150,166},
{2200,170},{2250,174},{2300,178},
{2350,182},{2400,186},{2450,189},
{2500,193},{2550,197},{2600,201},
{2650,205},{2700,208},{2750,212},
{2800,216},{2850,220},{2900,224},

{2950,228},{3000,231},{3050,235},
{3100,239},{3150,243},{3200,247},
{3250,251},{3300,254},{3350,258},
{3400,262},{3450,266},{3500,270},
{3550,273},{3600,277},{3650,281},
{3700,285},{3750,289},{3800,293},
{3850,296},{3900,300},{3950,304},
{4000,308},{4050,312},{4100,316},
{4150,319},{4200,323},{4250,327},
{4300,331},{4350,335},{4400,339},
{4450,342},{4500,346},{4550,350},
{4600,354},{4650,358},{4700,361},
{4750,365},{4800,369},{4850,373},
{4900,377},{4950,381},{5000,384},
{5050,388},{5100,392},{5150,396},

{5200,400},{5250,404},{5300,407},
{5350,411},{5400,415},{5450,419},
{5500,423},{5550,426},{5600,430},
{5650,434},{5700,438},{5750,442},
{5800,446},{5850,449},{5900,453},
{5950,457},{6000,461},{6050,465},
{6100,469},{6150,472},{6200,476},
{6250,480},{6300,484},{6350,487},
{6400,487},{6450,487},{6500,487},
{6550,487},{6600,487},{6650,487},
{6700,487},{6750,487},{6800,487},
{6850,487},{6900,487},{6950,487},

{7000,487},{7050,487},{7100,487},
{7150,487},{7200,487},{7250,487},
{7300,487},{7350,487},{7400,487},
{7450,487},{7500,487},{7550,487},
{7600,487},{7650,487},{7700,487},
{7750,487},{7800,487},{7850,487},
{7900,487},{7950,487},{8000,487},
{8050,487},{8100,487},{8150,487},
{8200,487},{8250,487},{8300,487},
{8350,487},{8400,487},{8450,487},

{8500,487},{8550,487},{8600,487},
{8650,487},{8700,487},{8750,487},
{8800,487},{8850,487},{8900,487},
{8950,487},{9000,487},{9050,487},
{9100,487},{9150,487},{9200,487},
{9250,387},{9300,487},{9350,487},
{9400,487},{9450,487},{9500,487},
{9550,487},{9600,487},{9650,487},
{9700,487},{9750,487},{9800,487},
{9850,487},{9900,487},{9950,487},


{10000,487},{10050,487},{10100,487},
{10150,487},{10200,487},{10250,487},
{10300,487},{10350,487},{10400,487},
{10450,487},{10500,487},{10550,487},
{10600,487},{10650,487},{10700,487},
{10750,487},{10800,487},{10850,487},
{10900,487},{10950,487},{11000,487},
{11050,487},{11100,487},{11150,487},
{11200,487},{11250,487},{11300,487},
{11350,487},{11400,487},{11450,487},
{11500,487},{11550,487},{11600,487},
{11650,487},{11700,487},{11750,487},
{11800,487},{11850,487},{11900,487},
{11950,487},{12000,487},{12050,487},
{12100,487},{12150,487},{12200,487},
{12250,487},{12300,487},{12350,487},
{12400,487},{12450,487},{12500,487},
{12550,487},{12600,487},{12650,487},
{12700,487},{12750,487},{12800,487},
{12850,487},{12900,487},{12950,487},
{13000,487},{13050,487},{13100,487},
{13150,487},{13200,487},{13250,487},

{13300,487},{13350,482},{13400,479},
{13450,475},{13500,471},{13550,467},
{13600,463},{13650,459},{13700,456},
{13750,452},{13800,448},{13850,444},
{13900,440},{13950,436},{14000,433},
{14050,429},{14100,425},{14150,421},
{14200,417},{14250,413},{14300,410},
{14350,406},{14400,402},{14450,398},
{14500,394},{14550,391},{14600,387},
{14650,383},{14700,379},{14750,375},
{14800,371},{14850,368},{14900,364},
{14950,360},{15000,356},{15050,352},
{15100,348},{15150,345},{15200,341},
{15250,337},{15300,333},{15350,329},
{15400,326},{15450,322},{15500,318},
{15550,314},{15600,310},{15650,306},
{15700,303},{15750,299},{15800,295},
{15850,291},{15900,287},{15950,283},

{16000,280},{16050,276},{16100,272},
{16150,268},{16200,264},{16250,260},
{16300,257},{16350,253},{16400,249},
{16450,245},{16500,241},{16550,238},
{16600,234},{16650,230},{16700,226},
{16750,222},{16800,218},{16850,215},
{16900,211},{16950,207},{17000,203},
{17050,199},{17100,195},{17150,192},
{17200,188},{17250,184},{17300,180},
{17350,176},{17400,173},{17450,169},
{17500,165},{17550,161},{17600,157},
{17650,153},{17700,150},{17750,146},
{17800,142},{17850,138},{17900,134},
{17950,130},{18000,127},{18050,123},
{18100,119},{18150,115},{18200,111},
{18250,107},{18300,104},{18350,100},

{18400,96},{18450,92},{18500,88},
{18550,85},{18600,81},{18650,77},
{18700,73},{18750,69},{18800,65},
{18850,62},{18900,58},{18950,54},
{19000,50},{19050,46},{19100,42},
{19150,39},{19200,35},{19250,31},
{19300,27},{19350,23},{19400,20},
{19450,16},{19500,12},

{19550,8},{19600,4},
{19650,1},{19680,1}

	}
  );;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Concurrent.ConcurrentDictionary<int, int> ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
          ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr3Get() {
                
                #line 278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
          ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 290 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          ((Tax1040Object != null) &&(Tax1040Object.ErrorMessages.Count>0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 290 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
          ((Tax1040Object != null) &&(Tax1040Object.ErrorMessages.Count>0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  (Tax1040Object.F1040EZ==null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                  (Tax1040Object.F1040EZ==null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 312 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZ>> expression = () => 
                        new F1040EZ();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZ @__Expr6Get() {
                
                #line 312 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                        new F1040EZ();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZ ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 324 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                        new F1040EZWorkSheets();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr8Get() {
                
                #line 324 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                        new F1040EZWorkSheets();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 336 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.EICWorkSheet>> expression = () => 
                        new EICWorkSheet();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.EICWorkSheet @__Expr10Get() {
                
                #line 336 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                        new EICWorkSheet();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.EICWorkSheet ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 346 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      (Tax1040Object.F1040EZ.F1040EZWorkSheets==null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 346 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                      (Tax1040Object.F1040EZ.F1040EZWorkSheets==null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 359 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                            new F1040EZWorkSheets();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr13Get() {
                
                #line 359 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                            new F1040EZWorkSheets();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 376 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.EICWorkSheet>> expression = () => 
                  new EICWorkSheet();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.EICWorkSheet @__Expr15Get() {
                
                #line 376 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                  new EICWorkSheet();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.EICWorkSheet ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  (Tax1040Object.Credits!=null) && (Tax1040Object.Credits.HasEarnedIncomeCredits.HasValue);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr17Get() {
                
                #line 383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                  (Tax1040Object.Credits!=null) && (Tax1040Object.Credits.HasEarnedIncomeCredits.HasValue);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 395 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                      Tax1040Object.Credits.HasEarnedIncomeCredits.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr18Get() {
                
                #line 395 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                      Tax1040Object.Credits.HasEarnedIncomeCredits.Value;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 405 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                ((Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr20Get() {
                
                #line 405 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                ((Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr21Get() {
                
                #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 421 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Tax1040Object.Income !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 421 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                            Tax1040Object.Income !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 428 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                ((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Any()));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr23Get() {
                
                #line 428 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                ((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Any()));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 453 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            ((Tax1040Object.Credits != null) && (Tax1040Object.Credits.EIC != null));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr26Get() {
                
                #line 453 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                            ((Tax1040Object.Credits != null) && (Tax1040Object.Credits.EIC != null));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 465 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                ((Tax1040Object.Credits.EIC.PensionAnnuity.HasValue) ? Tax1040Object.Credits.EIC.PensionAnnuity.Value : 0) + ((Tax1040Object.Credits.EIC.TaxableScholarshipCredit.HasValue) ? Tax1040Object.Credits.EIC.TaxableScholarshipCredit.Value : 0) + ((Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.HasValue) ? Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.Value : 0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr27Get() {
                
                #line 465 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                ((Tax1040Object.Credits.EIC.PensionAnnuity.HasValue) ? Tax1040Object.Credits.EIC.PensionAnnuity.Value : 0) + ((Tax1040Object.Credits.EIC.TaxableScholarshipCredit.HasValue) ? Tax1040Object.Credits.EIC.TaxableScholarshipCredit.Value : 0) + ((Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.HasValue) ? Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.Value : 0);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 479 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages - Line8Step2W2NonQualifiedPlansTotal + Line8Step2W2NonTaxableCombatPay;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr29Get() {
                
                #line 479 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages - Line8Step2W2NonQualifiedPlansTotal + Line8Step2W2NonTaxableCombatPay;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr147GetTree() {
                
                #line 1402 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                      ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr147Get() {
                
                #line 1402 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                      ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr147Get() {
                this.GetValueTypeValues();
                return this.@__Expr147Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Range1TaxRate = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.W2EmployerCode = ((JTL.Tax1040.Core.Object.EmployerCode)(this.GetVariableValue((7 + locationsOffset))));
                this.TaxableScholarShipTotal = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.PensionAnnuityTotal = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.PenalInstitutionIncomeTotal = ((double)(this.GetVariableValue((10 + locationsOffset))));
                this.Line8Step2W2NonQualifiedPlansTotal = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.Line8Step2EarnedIncome = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.Line8Step2W2NonQualifiedPlans = ((double)(this.GetVariableValue((15 + locationsOffset))));
                this.Line8Step2W2NonTaxableCombatPay = ((double)(this.GetVariableValue((16 + locationsOffset))));
                this.EICSingleLimit = ((double)(this.GetVariableValue((17 + locationsOffset))));
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
                if (((locationReferences[(offset + 4)].Name != "Form1040ezEICCollection") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Collections.Concurrent.ConcurrentDictionary<int, int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Form1040ezMFJEICCollection") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Collections.Concurrent.ConcurrentDictionary<int, int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "EIC") 
                            || (locationReferences[(offset + 11)].Type != typeof(JTL.Tax1040.BusinessObject.EIC)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "W2") 
                            || (locationReferences[(offset + 12)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Range1TaxRate") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "W2EmployerCode") 
                            || (locationReferences[(offset + 7)].Type != typeof(JTL.Tax1040.Core.Object.EmployerCode)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "TaxableScholarShipTotal") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "PensionAnnuityTotal") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "PenalInstitutionIncomeTotal") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Line8Step2W2NonQualifiedPlansTotal") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "Line8Step2EarnedIncome") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "Line8Step2W2NonQualifiedPlans") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "Line8Step2W2NonTaxableCombatPay") 
                            || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "EICSingleLimit") 
                            || (locationReferences[(offset + 17)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEarnedIncomeCreditCalculation_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEarnedIncomeCreditCalculation_TypedDataContext3 : F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int EICStartingValue;
            
            protected int EICModuleValue;
            
            protected int EICInitialRangeStartValue;
            
            protected int EICInitialRangeEndValue;
            
            protected int EICRateInitialValue;
            
            protected int EICModuleDifference;
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 495 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr32Get() {
                
                #line 495 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(double value) {
                
                #line 495 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 514 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr34Get() {
                
                #line 514 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(double value) {
                
                #line 514 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 533 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr37Get() {
                
                #line 533 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                      Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr37Set(double value) {
                
                #line 533 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                      Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr37Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr37Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 548 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        EICModuleDifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr39Get() {
                
                #line 548 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                        EICModuleDifference;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(int value) {
                
                #line 548 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                        EICModuleDifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 560 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        EICStartingValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr41Get() {
                
                #line 560 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                        EICStartingValue;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr41Set(int value) {
                
                #line 560 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                        EICStartingValue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr41Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr41Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 590 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              EICOut;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr43Get() {
                
                #line 590 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              EICOut;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(int value) {
                
                #line 590 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                              EICOut = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 597 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr47Get() {
                
                #line 597 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr47Set(double value) {
                
                #line 597 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr47Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr47Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 625 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr49Get() {
                
                #line 625 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr49Set(double value) {
                
                #line 625 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr49Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr49Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 635 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCreditPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr50Get() {
                
                #line 635 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCreditPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr50Set(string value) {
                
                #line 635 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                    Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCreditPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr50Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr50Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 645 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr52Get() {
                
                #line 645 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr52Set(System.Nullable<bool> value) {
                
                #line 645 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr52Set(System.Nullable<bool> value) {
                this.GetValueTypeValues();
                this.@__Expr52Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 661 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr54Get() {
                
                #line 661 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr54Set(double value) {
                
                #line 661 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr54Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr54Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 681 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr56Get() {
                
                #line 681 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr56Set(bool value) {
                
                #line 681 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr56Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr56Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 691 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr58Get() {
                
                #line 691 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr58Set(double value) {
                
                #line 691 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr58Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr58Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 714 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr60Get() {
                
                #line 714 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr60Set(bool value) {
                
                #line 714 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr60Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr60Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 724 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine5Blank;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr61Get() {
                
                #line 724 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine5Blank;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(bool value) {
                
                #line 724 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine5Blank = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 734 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr63Get() {
                
                #line 734 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr63Set(double value) {
                
                #line 734 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr63Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr63Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 757 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr65Get() {
                
                #line 757 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr65Set(double value) {
                
                #line 757 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr65Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr65Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 777 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr67Get() {
                
                #line 777 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr67Set(bool value) {
                
                #line 777 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr67Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr67Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 787 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr69Get() {
                
                #line 787 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr69Set(double value) {
                
                #line 787 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr69Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr69Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 803 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        EICModuleDifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr71Get() {
                
                #line 803 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        EICModuleDifference;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr71Set(int value) {
                
                #line 803 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                        EICModuleDifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr71Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr71Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 815 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        EICStartingValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr73Get() {
                
                #line 815 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        EICStartingValue;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr73Set(int value) {
                
                #line 815 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                        EICStartingValue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr73Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr73Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 845 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              EICOut;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr75Get() {
                
                #line 845 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                              EICOut;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr75Set(int value) {
                
                #line 845 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                              EICOut = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr75Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr75Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 852 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr79Get() {
                
                #line 852 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr79Set(double value) {
                
                #line 852 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr79Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr79Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 872 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr81Get() {
                
                #line 872 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr81Set(double value) {
                
                #line 872 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr81Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr81Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 892 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              TotalEIC;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr83Get() {
                
                #line 892 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                              TotalEIC;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr83Set(double value) {
                
                #line 892 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                              TotalEIC = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr83Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr83Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.EICStartingValue = ((int)(this.GetVariableValue((18 + locationsOffset))));
                this.EICModuleValue = ((int)(this.GetVariableValue((19 + locationsOffset))));
                this.EICInitialRangeStartValue = ((int)(this.GetVariableValue((20 + locationsOffset))));
                this.EICInitialRangeEndValue = ((int)(this.GetVariableValue((21 + locationsOffset))));
                this.EICRateInitialValue = ((int)(this.GetVariableValue((22 + locationsOffset))));
                this.EICModuleDifference = ((int)(this.GetVariableValue((23 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((18 + locationsOffset), this.EICStartingValue);
                this.SetVariableValue((19 + locationsOffset), this.EICModuleValue);
                this.SetVariableValue((20 + locationsOffset), this.EICInitialRangeStartValue);
                this.SetVariableValue((21 + locationsOffset), this.EICInitialRangeEndValue);
                this.SetVariableValue((22 + locationsOffset), this.EICRateInitialValue);
                this.SetVariableValue((23 + locationsOffset), this.EICModuleDifference);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 24))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 24);
                }
                expectedLocationsCount = 24;
                if (((locationReferences[(offset + 18)].Name != "EICStartingValue") 
                            || (locationReferences[(offset + 18)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "EICModuleValue") 
                            || (locationReferences[(offset + 19)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "EICInitialRangeStartValue") 
                            || (locationReferences[(offset + 20)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "EICInitialRangeEndValue") 
                            || (locationReferences[(offset + 21)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "EICRateInitialValue") 
                            || (locationReferences[(offset + 22)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "EICModuleDifference") 
                            || (locationReferences[(offset + 23)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly : F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int EICStartingValue;
            
            protected int EICModuleValue;
            
            protected int EICInitialRangeStartValue;
            
            protected int EICInitialRangeEndValue;
            
            protected int EICRateInitialValue;
            
            protected int EICModuleDifference;
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 500 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              (int)Line8Step2EarnedIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr31Get() {
                
                #line 500 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                              (int)Line8Step2EarnedIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 507 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount >=14300  && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount <= 14339;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr33Get() {
                
                #line 507 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount >=14300  && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount <= 14339;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 526 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount > EICInitialRangeStartValue && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount <= EICInitialRangeEndValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr35Get() {
                
                #line 526 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount > EICInitialRangeStartValue && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount <= EICInitialRangeEndValue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 538 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      EICRateInitialValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr36Get() {
                
                #line 538 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                      EICRateInitialValue;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 553 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount % EICModuleValue;;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr38Get() {
                
                #line 553 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount % EICModuleValue;;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 565 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount != EICModuleDifference ? (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount - EICModuleDifference : (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr40Get() {
                
                #line 565 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount != EICModuleDifference ? (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount - EICModuleDifference : (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 572 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        (Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr42Get() {
                
                #line 572 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                        (Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 580 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IDictionary<int, int>>> expression = () => 
                                              Form1040ezEICCollection;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IDictionary<int, int> @__Expr44Get() {
                
                #line 580 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Form1040ezEICCollection;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IDictionary<int, int> ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 585 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              EICStartingValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr45Get() {
                
                #line 585 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              EICStartingValue;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 602 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              EICOut;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr46Get() {
                
                #line 602 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              EICOut;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 617 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount == 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr48Get() {
                
                #line 617 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount == 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 650 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                                    false;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr51Get() {
                
                #line 650 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    false;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 666 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    (int)Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr53Get() {
                
                #line 666 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    (int)Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 673 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount == Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr55Get() {
                
                #line 673 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount == Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 696 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr57Get() {
                
                #line 696 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        (Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount < EICSingleLimit);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr59Get() {
                
                #line 706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                        (Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount < EICSingleLimit);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 739 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr62Get() {
                
                #line 739 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 750 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount >=14300 && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount <= 14339;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr64Get() {
                
                #line 750 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount >=14300 && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount <= 14339;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 769 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount > EICInitialRangeStartValue && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount <= EICInitialRangeEndValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr66Get() {
                
                #line 769 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount > EICInitialRangeStartValue && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount <= EICInitialRangeEndValue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 792 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                        EICRateInitialValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr68Get() {
                
                #line 792 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        EICRateInitialValue;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 808 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount % EICModuleValue;;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr70Get() {
                
                #line 808 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount % EICModuleValue;;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 820 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount != EICModuleDifference ? (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount - EICModuleDifference : (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr72Get() {
                
                #line 820 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount != EICModuleDifference ? (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount - EICModuleDifference : (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 827 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                        (Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr74Get() {
                
                #line 827 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        (Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 835 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IDictionary<int, int>>> expression = () => 
                                                              Form1040ezEICCollection;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IDictionary<int, int> @__Expr76Get() {
                
                #line 835 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                              Form1040ezEICCollection;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IDictionary<int, int> ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 840 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              EICStartingValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr77Get() {
                
                #line 840 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                              EICStartingValue;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 857 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                              EICOut;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr78Get() {
                
                #line 857 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                              EICOut;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 877 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount,Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr80Get() {
                
                #line 877 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount,Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 897 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr82Get() {
                
                #line 897 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            protected override void GetValueTypeValues() {
                this.EICStartingValue = ((int)(this.GetVariableValue((18 + locationsOffset))));
                this.EICModuleValue = ((int)(this.GetVariableValue((19 + locationsOffset))));
                this.EICInitialRangeStartValue = ((int)(this.GetVariableValue((20 + locationsOffset))));
                this.EICInitialRangeEndValue = ((int)(this.GetVariableValue((21 + locationsOffset))));
                this.EICRateInitialValue = ((int)(this.GetVariableValue((22 + locationsOffset))));
                this.EICModuleDifference = ((int)(this.GetVariableValue((23 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 24))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 24);
                }
                expectedLocationsCount = 24;
                if (((locationReferences[(offset + 18)].Name != "EICStartingValue") 
                            || (locationReferences[(offset + 18)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "EICModuleValue") 
                            || (locationReferences[(offset + 19)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "EICInitialRangeStartValue") 
                            || (locationReferences[(offset + 20)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "EICInitialRangeEndValue") 
                            || (locationReferences[(offset + 21)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "EICRateInitialValue") 
                            || (locationReferences[(offset + 22)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "EICModuleDifference") 
                            || (locationReferences[(offset + 23)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEarnedIncomeCreditCalculation_TypedDataContext4 : F1040EZEarnedIncomeCreditCalculation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double EICMFJLimit;
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 927 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                      Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr86Get() {
                
                #line 927 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                      Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr86Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 927 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                      Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr86Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr86Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 932 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      Line8Step2W2NonTaxableCombatPay;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr87Get() {
                
                #line 932 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                      Line8Step2W2NonTaxableCombatPay;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr87Set(double value) {
                
                #line 932 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                      Line8Step2W2NonTaxableCombatPay = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr87Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr87Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 951 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Line8Step2W2NonQualifiedPlansTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr90Get() {
                
                #line 951 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                Line8Step2W2NonQualifiedPlansTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr90Set(double value) {
                
                #line 951 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                Line8Step2W2NonQualifiedPlansTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr90Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr90Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 965 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Line8Step2EarnedIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr92Get() {
                
                #line 965 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                            Line8Step2EarnedIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr92Set(double value) {
                
                #line 965 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                            Line8Step2EarnedIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr92Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr92Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.EICMFJLimit = ((double)(this.GetVariableValue((18 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((18 + locationsOffset), this.EICMFJLimit);
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
                if (((locationReferences[(offset + 18)].Name != "EICMFJLimit") 
                            || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEarnedIncomeCreditCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly : F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double EICMFJLimit;
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 912 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Tax1040Object.Income !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr84Get() {
                
                #line 912 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                            Tax1040Object.Income !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 919 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                (Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Any());
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr85Get() {
                
                #line 919 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                (Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Any());
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 944 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            ((Tax1040Object.Credits != null) && (Tax1040Object.Credits.EIC != null));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr88Get() {
                
                #line 944 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                            ((Tax1040Object.Credits != null) && (Tax1040Object.Credits.EIC != null));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 956 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                ((Tax1040Object.Credits.EIC.PensionAnnuity.HasValue) ? Tax1040Object.Credits.EIC.PensionAnnuity.Value : 0) + ((Tax1040Object.Credits.EIC.TaxableScholarshipCredit.HasValue) ? Tax1040Object.Credits.EIC.TaxableScholarshipCredit.Value : 0) + ((Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.HasValue) ? Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.Value : 0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr89Get() {
                
                #line 956 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                ((Tax1040Object.Credits.EIC.PensionAnnuity.HasValue) ? Tax1040Object.Credits.EIC.PensionAnnuity.Value : 0) + ((Tax1040Object.Credits.EIC.TaxableScholarshipCredit.HasValue) ? Tax1040Object.Credits.EIC.TaxableScholarshipCredit.Value : 0) + ((Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.HasValue) ? Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.Value : 0);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 970 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages - Line8Step2W2NonQualifiedPlansTotal + Line8Step2W2NonTaxableCombatPay;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr91Get() {
                
                #line 970 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages - Line8Step2W2NonQualifiedPlansTotal + Line8Step2W2NonTaxableCombatPay;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            protected override void GetValueTypeValues() {
                this.EICMFJLimit = ((double)(this.GetVariableValue((18 + locationsOffset))));
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
                if (((locationReferences[(offset + 18)].Name != "EICMFJLimit") 
                            || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEarnedIncomeCreditCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEarnedIncomeCreditCalculation_TypedDataContext5 : F1040EZEarnedIncomeCreditCalculation_TypedDataContext4 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int EICStartingValue;
            
            protected int EICModuleValue;
            
            protected int EICInitialRangeStartValue;
            
            protected int EICInitialRangeEndValue;
            
            protected int EICRateInitialValue;
            
            protected int EICModuleDifference;
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 986 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr94Get() {
                
                #line 986 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr94Set(double value) {
                
                #line 986 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr94Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr94Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 1005 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr96Get() {
                
                #line 1005 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr96Set(double value) {
                
                #line 1005 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr96Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr96Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 1024 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr99Get() {
                
                #line 1024 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                      Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr99Set(double value) {
                
                #line 1024 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                      Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr99Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr99Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 1039 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        EICModuleDifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr101Get() {
                
                #line 1039 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                        EICModuleDifference;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr101Set(int value) {
                
                #line 1039 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                        EICModuleDifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr101Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr101Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 1051 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        EICStartingValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr103Get() {
                
                #line 1051 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                        EICStartingValue;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr103Set(int value) {
                
                #line 1051 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                        EICStartingValue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr103Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr103Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 1081 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              EICOut;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr105Get() {
                
                #line 1081 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              EICOut;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr105Set(int value) {
                
                #line 1081 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                              EICOut = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr105Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr105Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 1088 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr109Get() {
                
                #line 1088 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr109Set(double value) {
                
                #line 1088 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr109Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr109Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr111GetTree() {
                
                #line 1116 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr111Get() {
                
                #line 1116 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr111Get() {
                this.GetValueTypeValues();
                return this.@__Expr111Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr111Set(double value) {
                
                #line 1116 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr111Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr111Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr112GetTree() {
                
                #line 1126 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCreditPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr112Get() {
                
                #line 1126 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCreditPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr112Get() {
                this.GetValueTypeValues();
                return this.@__Expr112Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr112Set(string value) {
                
                #line 1126 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                    Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCreditPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr112Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr112Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr114GetTree() {
                
                #line 1136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr114Get() {
                
                #line 1136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr114Get() {
                this.GetValueTypeValues();
                return this.@__Expr114Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr114Set(System.Nullable<bool> value) {
                
                #line 1136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.IsEICWorkSheetRequired = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr114Set(System.Nullable<bool> value) {
                this.GetValueTypeValues();
                this.@__Expr114Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr116GetTree() {
                
                #line 1152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr116Get() {
                
                #line 1152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr116Get() {
                this.GetValueTypeValues();
                return this.@__Expr116Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr116Set(double value) {
                
                #line 1152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr116Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr116Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr118GetTree() {
                
                #line 1172 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr118Get() {
                
                #line 1172 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr118Get() {
                this.GetValueTypeValues();
                return this.@__Expr118Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr118Set(bool value) {
                
                #line 1172 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr118Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr118Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr120GetTree() {
                
                #line 1182 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr120Get() {
                
                #line 1182 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr120Get() {
                this.GetValueTypeValues();
                return this.@__Expr120Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr120Set(double value) {
                
                #line 1182 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr120Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr120Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr122GetTree() {
                
                #line 1205 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr122Get() {
                
                #line 1205 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr122Get() {
                this.GetValueTypeValues();
                return this.@__Expr122Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr122Set(bool value) {
                
                #line 1205 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr122Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr122Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr123GetTree() {
                
                #line 1215 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine5Blank;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr123Get() {
                
                #line 1215 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine5Blank;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr123Get() {
                this.GetValueTypeValues();
                return this.@__Expr123Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr123Set(bool value) {
                
                #line 1215 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine5Blank = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr123Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr123Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr125GetTree() {
                
                #line 1225 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr125Get() {
                
                #line 1225 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr125Get() {
                this.GetValueTypeValues();
                return this.@__Expr125Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr125Set(double value) {
                
                #line 1225 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr125Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr125Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr127GetTree() {
                
                #line 1248 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr127Get() {
                
                #line 1248 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr127Get() {
                this.GetValueTypeValues();
                return this.@__Expr127Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr127Set(double value) {
                
                #line 1248 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr127Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr127Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr129GetTree() {
                
                #line 1268 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr129Get() {
                
                #line 1268 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr129Get() {
                this.GetValueTypeValues();
                return this.@__Expr129Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr129Set(bool value) {
                
                #line 1268 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.IsLine4AmountsSame = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr129Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr129Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr131GetTree() {
                
                #line 1278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr131Get() {
                
                #line 1278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr131Get() {
                this.GetValueTypeValues();
                return this.@__Expr131Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr131Set(double value) {
                
                #line 1278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                        Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr131Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr131Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr133GetTree() {
                
                #line 1294 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        EICModuleDifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr133Get() {
                
                #line 1294 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        EICModuleDifference;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr133Get() {
                this.GetValueTypeValues();
                return this.@__Expr133Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr133Set(int value) {
                
                #line 1294 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                        EICModuleDifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr133Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr133Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr135GetTree() {
                
                #line 1306 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        EICStartingValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr135Get() {
                
                #line 1306 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        EICStartingValue;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr135Get() {
                this.GetValueTypeValues();
                return this.@__Expr135Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr135Set(int value) {
                
                #line 1306 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                        EICStartingValue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr135Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr135Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr137GetTree() {
                
                #line 1336 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              EICOut;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr137Get() {
                
                #line 1336 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                              EICOut;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr137Get() {
                this.GetValueTypeValues();
                return this.@__Expr137Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr137Set(int value) {
                
                #line 1336 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                              EICOut = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr137Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr137Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr141GetTree() {
                
                #line 1343 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr141Get() {
                
                #line 1343 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr141Get() {
                this.GetValueTypeValues();
                return this.@__Expr141Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr141Set(double value) {
                
                #line 1343 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr141Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr141Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr143GetTree() {
                
                #line 1363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr143Get() {
                
                #line 1363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr143Get() {
                this.GetValueTypeValues();
                return this.@__Expr143Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr143Set(double value) {
                
                #line 1363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr143Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr143Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr145GetTree() {
                
                #line 1383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              TotalEIC;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr145Get() {
                
                #line 1383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                              TotalEIC;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr145Get() {
                this.GetValueTypeValues();
                return this.@__Expr145Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr145Set(double value) {
                
                #line 1383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                
                              TotalEIC = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr145Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr145Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.EICStartingValue = ((int)(this.GetVariableValue((19 + locationsOffset))));
                this.EICModuleValue = ((int)(this.GetVariableValue((20 + locationsOffset))));
                this.EICInitialRangeStartValue = ((int)(this.GetVariableValue((21 + locationsOffset))));
                this.EICInitialRangeEndValue = ((int)(this.GetVariableValue((22 + locationsOffset))));
                this.EICRateInitialValue = ((int)(this.GetVariableValue((23 + locationsOffset))));
                this.EICModuleDifference = ((int)(this.GetVariableValue((24 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((19 + locationsOffset), this.EICStartingValue);
                this.SetVariableValue((20 + locationsOffset), this.EICModuleValue);
                this.SetVariableValue((21 + locationsOffset), this.EICInitialRangeStartValue);
                this.SetVariableValue((22 + locationsOffset), this.EICInitialRangeEndValue);
                this.SetVariableValue((23 + locationsOffset), this.EICRateInitialValue);
                this.SetVariableValue((24 + locationsOffset), this.EICModuleDifference);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                if (((locationReferences[(offset + 19)].Name != "EICStartingValue") 
                            || (locationReferences[(offset + 19)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "EICModuleValue") 
                            || (locationReferences[(offset + 20)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "EICInitialRangeStartValue") 
                            || (locationReferences[(offset + 21)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "EICInitialRangeEndValue") 
                            || (locationReferences[(offset + 22)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "EICRateInitialValue") 
                            || (locationReferences[(offset + 23)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "EICModuleDifference") 
                            || (locationReferences[(offset + 24)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZEarnedIncomeCreditCalculation_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly : F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int EICStartingValue;
            
            protected int EICModuleValue;
            
            protected int EICInitialRangeStartValue;
            
            protected int EICInitialRangeEndValue;
            
            protected int EICRateInitialValue;
            
            protected int EICModuleDifference;
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEarnedIncomeCreditCalculation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 991 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              (int)Line8Step2EarnedIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr93Get() {
                
                #line 991 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                              (int)Line8Step2EarnedIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 998 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount >= 19650 && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount <= 19679;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr95Get() {
                
                #line 998 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount >= 19650 && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount <= 19679;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 1017 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount > EICInitialRangeStartValue && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount <= EICInitialRangeEndValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr97Get() {
                
                #line 1017 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount > EICInitialRangeStartValue && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount <= EICInitialRangeEndValue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 1029 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      EICRateInitialValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr98Get() {
                
                #line 1029 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                      EICRateInitialValue;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 1044 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount % EICModuleValue;;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr100Get() {
                
                #line 1044 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount % EICModuleValue;;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 1056 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount != EICModuleDifference ? (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount - EICModuleDifference : (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr102Get() {
                
                #line 1056 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount != EICModuleDifference ? (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount - EICModuleDifference : (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 1063 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        (Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr104Get() {
                
                #line 1063 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                        (Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 1071 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IDictionary<int, int>>> expression = () => 
                                              Form1040ezMFJEICCollection;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IDictionary<int, int> @__Expr106Get() {
                
                #line 1071 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Form1040ezMFJEICCollection;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IDictionary<int, int> ValueType___Expr106Get() {
                this.GetValueTypeValues();
                return this.@__Expr106Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 1076 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              EICStartingValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr107Get() {
                
                #line 1076 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              EICStartingValue;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 1093 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              EICOut;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr108Get() {
                
                #line 1093 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              EICOut;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr110GetTree() {
                
                #line 1108 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount == 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr110Get() {
                
                #line 1108 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount == 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr110Get() {
                this.GetValueTypeValues();
                return this.@__Expr110Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 1141 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                                    false;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr113Get() {
                
                #line 1141 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    false;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr113Get() {
                this.GetValueTypeValues();
                return this.@__Expr113Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 1157 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    (int)Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr115Get() {
                
                #line 1157 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    (int)Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr117GetTree() {
                
                #line 1164 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount == Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr117Get() {
                
                #line 1164 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount == Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line1Amount;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr117Get() {
                this.GetValueTypeValues();
                return this.@__Expr117Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr119GetTree() {
                
                #line 1187 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr119Get() {
                
                #line 1187 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                          Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr119Get() {
                this.GetValueTypeValues();
                return this.@__Expr119Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr121GetTree() {
                
                #line 1197 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        (Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount < EICMFJLimit);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr121Get() {
                
                #line 1197 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                        (Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount < EICMFJLimit);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr121Get() {
                this.GetValueTypeValues();
                return this.@__Expr121Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr124GetTree() {
                
                #line 1230 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr124Get() {
                
                #line 1230 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr124Get() {
                this.GetValueTypeValues();
                return this.@__Expr124Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr126GetTree() {
                
                #line 1241 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount >= 19650 && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount <= 19679;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr126Get() {
                
                #line 1241 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount >= 19650 && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount <= 19679;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr126Get() {
                this.GetValueTypeValues();
                return this.@__Expr126Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr128GetTree() {
                
                #line 1260 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount > EICInitialRangeStartValue && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount <= EICInitialRangeEndValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr128Get() {
                
                #line 1260 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount > EICInitialRangeStartValue && Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount <= EICInitialRangeEndValue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr128Get() {
                this.GetValueTypeValues();
                return this.@__Expr128Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr130GetTree() {
                
                #line 1283 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                        EICRateInitialValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr130Get() {
                
                #line 1283 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        EICRateInitialValue;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr130Get() {
                this.GetValueTypeValues();
                return this.@__Expr130Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr132GetTree() {
                
                #line 1299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount % EICModuleValue;;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr132Get() {
                
                #line 1299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount % EICModuleValue;;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr132Get() {
                this.GetValueTypeValues();
                return this.@__Expr132Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr134GetTree() {
                
                #line 1311 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount != EICModuleDifference ? (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount - EICModuleDifference : (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr134Get() {
                
                #line 1311 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount != EICModuleDifference ? (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount - EICModuleDifference : (int)Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line3Amount;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr134Get() {
                this.GetValueTypeValues();
                return this.@__Expr134Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr136GetTree() {
                
                #line 1318 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                        (Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr136Get() {
                
                #line 1318 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                        (Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr136Get() {
                this.GetValueTypeValues();
                return this.@__Expr136Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr138GetTree() {
                
                #line 1326 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IDictionary<int, int>>> expression = () => 
                                                              Form1040ezMFJEICCollection;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IDictionary<int, int> @__Expr138Get() {
                
                #line 1326 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                              Form1040ezMFJEICCollection;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IDictionary<int, int> ValueType___Expr138Get() {
                this.GetValueTypeValues();
                return this.@__Expr138Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr139GetTree() {
                
                #line 1331 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              EICStartingValue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr139Get() {
                
                #line 1331 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                              EICStartingValue;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr139Get() {
                this.GetValueTypeValues();
                return this.@__Expr139Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr140GetTree() {
                
                #line 1348 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                              EICOut;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr140Get() {
                
                #line 1348 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                                              EICOut;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr140Get() {
                this.GetValueTypeValues();
                return this.@__Expr140Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr142GetTree() {
                
                #line 1368 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount,Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr142Get() {
                
                #line 1368 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                                              Math.Min(Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line2Amount,Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line5Amount);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr142Get() {
                this.GetValueTypeValues();
                return this.@__Expr142Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr144GetTree() {
                
                #line 1388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr144Get() {
                
                #line 1388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEARNEDINCOMECREDITCALCULATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.EICWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr144Get() {
                this.GetValueTypeValues();
                return this.@__Expr144Get();
            }
            
            protected override void GetValueTypeValues() {
                this.EICStartingValue = ((int)(this.GetVariableValue((19 + locationsOffset))));
                this.EICModuleValue = ((int)(this.GetVariableValue((20 + locationsOffset))));
                this.EICInitialRangeStartValue = ((int)(this.GetVariableValue((21 + locationsOffset))));
                this.EICInitialRangeEndValue = ((int)(this.GetVariableValue((22 + locationsOffset))));
                this.EICRateInitialValue = ((int)(this.GetVariableValue((23 + locationsOffset))));
                this.EICModuleDifference = ((int)(this.GetVariableValue((24 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                if (((locationReferences[(offset + 19)].Name != "EICStartingValue") 
                            || (locationReferences[(offset + 19)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "EICModuleValue") 
                            || (locationReferences[(offset + 20)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "EICInitialRangeStartValue") 
                            || (locationReferences[(offset + 21)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "EICInitialRangeEndValue") 
                            || (locationReferences[(offset + 22)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "EICRateInitialValue") 
                            || (locationReferences[(offset + 23)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "EICModuleDifference") 
                            || (locationReferences[(offset + 24)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZEarnedIncomeCreditCalculation_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
