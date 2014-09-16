namespace Tax1040WorkFlow.WorkFlow.Activities {
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 28 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 29 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 30 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using JTL.Tax1040.Core.Object;
    
    #line default
    #line hidden
    
    #line 31 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using JTL.Tax1040.Core.Process;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZLineByLineCalculation.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class F1040EZLineByLineCalculation : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext0 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext1 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext2 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext3 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext4 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<JTL.Tax1040.BusinessObject.OutputForms>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext5 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext6 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext6.GetLocation<JTL.Tax1040.BusinessObject.Tax1040EZPage1>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext7 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly valDataContext8 = ((F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZLineByLineCalculation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext4 refDataContext9 = ((F1040EZLineByLineCalculation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext9.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZLineByLineCalculation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext4 refDataContext10 = ((F1040EZLineByLineCalculation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext10.GetLocation<double>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZLineByLineCalculation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext4_ForReadOnly valDataContext11 = ((F1040EZLineByLineCalculation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZLineByLineCalculation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext4 refDataContext12 = ((F1040EZLineByLineCalculation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZLineByLineCalculation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext4 refDataContext13 = ((F1040EZLineByLineCalculation_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext13.GetLocation<double>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly valDataContext14 = ((F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZLineByLineCalculation_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext6 refDataContext15 = ((F1040EZLineByLineCalculation_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext15.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZLineByLineCalculation_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext6 refDataContext16 = ((F1040EZLineByLineCalculation_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext16.GetLocation<double>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZLineByLineCalculation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext6_ForReadOnly valDataContext17 = ((F1040EZLineByLineCalculation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZLineByLineCalculation_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext6 refDataContext18 = ((F1040EZLineByLineCalculation_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext18.GetLocation<double>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly valDataContext19 = ((F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZLineByLineCalculation_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext7 refDataContext20 = ((F1040EZLineByLineCalculation_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext20.GetLocation<double>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZLineByLineCalculation_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext7 refDataContext21 = ((F1040EZLineByLineCalculation_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext21.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZLineByLineCalculation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext7_ForReadOnly valDataContext22 = ((F1040EZLineByLineCalculation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZLineByLineCalculation_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext7 refDataContext23 = ((F1040EZLineByLineCalculation_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext23.GetLocation<double>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly valDataContext24 = ((F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZLineByLineCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext5 refDataContext25 = ((F1040EZLineByLineCalculation_TypedDataContext5)(cachedCompiledDataContext[10]));
                return refDataContext25.GetLocation<double>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly valDataContext26 = ((F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZLineByLineCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext5 refDataContext27 = ((F1040EZLineByLineCalculation_TypedDataContext5)(cachedCompiledDataContext[10]));
                return refDataContext27.GetLocation<double>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly valDataContext28 = ((F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZLineByLineCalculation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext5 refDataContext29 = ((F1040EZLineByLineCalculation_TypedDataContext5)(cachedCompiledDataContext[10]));
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly valDataContext30 = ((F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new F1040EZLineByLineCalculation_TypedDataContext9(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext9 refDataContext31 = ((F1040EZLineByLineCalculation_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext31.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly valDataContext32 = ((F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new F1040EZLineByLineCalculation_TypedDataContext9(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext9 refDataContext33 = ((F1040EZLineByLineCalculation_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext33.GetLocation<double>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new F1040EZLineByLineCalculation_TypedDataContext9(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext9 refDataContext34 = ((F1040EZLineByLineCalculation_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext34.GetLocation<double>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly valDataContext35 = ((F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new F1040EZLineByLineCalculation_TypedDataContext9(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext9 refDataContext36 = ((F1040EZLineByLineCalculation_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext36.GetLocation<string>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly valDataContext37 = ((F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly valDataContext38 = ((F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new F1040EZLineByLineCalculation_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext8 refDataContext39 = ((F1040EZLineByLineCalculation_TypedDataContext8)(cachedCompiledDataContext[14]));
                return refDataContext39.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new F1040EZLineByLineCalculation_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext8 refDataContext40 = ((F1040EZLineByLineCalculation_TypedDataContext8)(cachedCompiledDataContext[14]));
                return refDataContext40.GetLocation<double>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly valDataContext41 = ((F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new F1040EZLineByLineCalculation_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext8 refDataContext42 = ((F1040EZLineByLineCalculation_TypedDataContext8)(cachedCompiledDataContext[14]));
                return refDataContext42.GetLocation<double>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new F1040EZLineByLineCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext10_ForReadOnly valDataContext43 = ((F1040EZLineByLineCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new F1040EZLineByLineCalculation_TypedDataContext10(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext10 refDataContext44 = ((F1040EZLineByLineCalculation_TypedDataContext10)(cachedCompiledDataContext[16]));
                return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new F1040EZLineByLineCalculation_TypedDataContext11(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext11 refDataContext45 = ((F1040EZLineByLineCalculation_TypedDataContext11)(cachedCompiledDataContext[17]));
                return refDataContext45.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new F1040EZLineByLineCalculation_TypedDataContext11(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext11 refDataContext46 = ((F1040EZLineByLineCalculation_TypedDataContext11)(cachedCompiledDataContext[17]));
                return refDataContext46.GetLocation<double>(refDataContext46.ValueType___Expr46Get, refDataContext46.ValueType___Expr46Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext47 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext48 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext49 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext50 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext50.GetLocation<double>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext51 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext51.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext52 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext52.GetLocation<double>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext53 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext53.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext54 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext54.GetLocation<double>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext55 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext55.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext56 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext56.GetLocation<double>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext57 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext57.GetLocation<double>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext58 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext58.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext59 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext59.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext60 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext60.GetLocation<double>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext61 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext61.GetLocation<double>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext62 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext62.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new F1040EZLineByLineCalculation_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13_ForReadOnly valDataContext63 = ((F1040EZLineByLineCalculation_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new F1040EZLineByLineCalculation_TypedDataContext13(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext64 = ((F1040EZLineByLineCalculation_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext64.GetLocation<double>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new F1040EZLineByLineCalculation_TypedDataContext14(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext65 = ((F1040EZLineByLineCalculation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext65.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new F1040EZLineByLineCalculation_TypedDataContext14(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext66 = ((F1040EZLineByLineCalculation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext66.GetLocation<double>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext67 = ((F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext68 = ((F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new F1040EZLineByLineCalculation_TypedDataContext14(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext69 = ((F1040EZLineByLineCalculation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext69.GetLocation<string>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext70 = ((F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext71 = ((F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext72 = ((F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new F1040EZLineByLineCalculation_TypedDataContext14(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext73 = ((F1040EZLineByLineCalculation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext73.GetLocation<string>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext74 = ((F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new F1040EZLineByLineCalculation_TypedDataContext14(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext75 = ((F1040EZLineByLineCalculation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext75.GetLocation<string>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext76 = ((F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext77 = ((F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext78 = ((F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new F1040EZLineByLineCalculation_TypedDataContext14(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext79 = ((F1040EZLineByLineCalculation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext79.GetLocation<string>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext80 = ((F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new F1040EZLineByLineCalculation_TypedDataContext14(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext81 = ((F1040EZLineByLineCalculation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext81.GetLocation<string>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext82 = ((F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new F1040EZLineByLineCalculation_TypedDataContext14(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext83 = ((F1040EZLineByLineCalculation_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext83.GetLocation<string>(refDataContext83.ValueType___Expr83Get, refDataContext83.ValueType___Expr83Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new F1040EZLineByLineCalculation_TypedDataContext15(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext15 refDataContext84 = ((F1040EZLineByLineCalculation_TypedDataContext15)(cachedCompiledDataContext[22]));
                return refDataContext84.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new F1040EZLineByLineCalculation_TypedDataContext15(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext15 refDataContext85 = ((F1040EZLineByLineCalculation_TypedDataContext15)(cachedCompiledDataContext[22]));
                return refDataContext85.GetLocation<double>(refDataContext85.ValueType___Expr85Get, refDataContext85.ValueType___Expr85Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext86 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext87 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext88 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext88.GetLocation<double>(refDataContext88.ValueType___Expr88Get, refDataContext88.ValueType___Expr88Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext89 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext90 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext90.GetLocation<double>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly valDataContext91 = ((F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[23]));
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly valDataContext92 = ((F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[23]));
                return valDataContext92.ValueType___Expr92Get();
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly valDataContext93 = ((F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[23]));
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext16.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new F1040EZLineByLineCalculation_TypedDataContext16(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext16 refDataContext94 = ((F1040EZLineByLineCalculation_TypedDataContext16)(cachedCompiledDataContext[24]));
                return refDataContext94.GetLocation<double>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext95 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext96 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext97 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext97.GetLocation<double>(refDataContext97.ValueType___Expr97Get, refDataContext97.ValueType___Expr97Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext98 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext98.GetLocation<double>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext99 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext100 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext100.GetLocation<double>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext101 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext101.GetLocation<double>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext102 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext102.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext103 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext104 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext104.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext105 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext106 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext106.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext106.ValueType___Expr106Get, refDataContext106.ValueType___Expr106Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext107 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext108 = ((F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLineByLineCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZLineByLineCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext109 = ((F1040EZLineByLineCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext109.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set, expressionId, this.rootActivity, activityContext);
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
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext0 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext1 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext2 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext3 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext4 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<JTL.Tax1040.BusinessObject.OutputForms>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext5 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext6 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext6.GetLocation<JTL.Tax1040.BusinessObject.Tax1040EZPage1>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext7 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly valDataContext8 = new F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                F1040EZLineByLineCalculation_TypedDataContext4 refDataContext9 = new F1040EZLineByLineCalculation_TypedDataContext4(locations, true);
                return refDataContext9.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                F1040EZLineByLineCalculation_TypedDataContext4 refDataContext10 = new F1040EZLineByLineCalculation_TypedDataContext4(locations, true);
                return refDataContext10.GetLocation<double>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                F1040EZLineByLineCalculation_TypedDataContext4_ForReadOnly valDataContext11 = new F1040EZLineByLineCalculation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                F1040EZLineByLineCalculation_TypedDataContext4 refDataContext12 = new F1040EZLineByLineCalculation_TypedDataContext4(locations, true);
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                F1040EZLineByLineCalculation_TypedDataContext4 refDataContext13 = new F1040EZLineByLineCalculation_TypedDataContext4(locations, true);
                return refDataContext13.GetLocation<double>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly valDataContext14 = new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                F1040EZLineByLineCalculation_TypedDataContext6 refDataContext15 = new F1040EZLineByLineCalculation_TypedDataContext6(locations, true);
                return refDataContext15.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                F1040EZLineByLineCalculation_TypedDataContext6 refDataContext16 = new F1040EZLineByLineCalculation_TypedDataContext6(locations, true);
                return refDataContext16.GetLocation<double>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                F1040EZLineByLineCalculation_TypedDataContext6_ForReadOnly valDataContext17 = new F1040EZLineByLineCalculation_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                F1040EZLineByLineCalculation_TypedDataContext6 refDataContext18 = new F1040EZLineByLineCalculation_TypedDataContext6(locations, true);
                return refDataContext18.GetLocation<double>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly valDataContext19 = new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                F1040EZLineByLineCalculation_TypedDataContext7 refDataContext20 = new F1040EZLineByLineCalculation_TypedDataContext7(locations, true);
                return refDataContext20.GetLocation<double>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                F1040EZLineByLineCalculation_TypedDataContext7 refDataContext21 = new F1040EZLineByLineCalculation_TypedDataContext7(locations, true);
                return refDataContext21.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                F1040EZLineByLineCalculation_TypedDataContext7_ForReadOnly valDataContext22 = new F1040EZLineByLineCalculation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                F1040EZLineByLineCalculation_TypedDataContext7 refDataContext23 = new F1040EZLineByLineCalculation_TypedDataContext7(locations, true);
                return refDataContext23.GetLocation<double>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly valDataContext24 = new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                F1040EZLineByLineCalculation_TypedDataContext5 refDataContext25 = new F1040EZLineByLineCalculation_TypedDataContext5(locations, true);
                return refDataContext25.GetLocation<double>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly valDataContext26 = new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                F1040EZLineByLineCalculation_TypedDataContext5 refDataContext27 = new F1040EZLineByLineCalculation_TypedDataContext5(locations, true);
                return refDataContext27.GetLocation<double>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly valDataContext28 = new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                F1040EZLineByLineCalculation_TypedDataContext5 refDataContext29 = new F1040EZLineByLineCalculation_TypedDataContext5(locations, true);
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly valDataContext30 = new F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                F1040EZLineByLineCalculation_TypedDataContext9 refDataContext31 = new F1040EZLineByLineCalculation_TypedDataContext9(locations, true);
                return refDataContext31.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly valDataContext32 = new F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                F1040EZLineByLineCalculation_TypedDataContext9 refDataContext33 = new F1040EZLineByLineCalculation_TypedDataContext9(locations, true);
                return refDataContext33.GetLocation<double>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                F1040EZLineByLineCalculation_TypedDataContext9 refDataContext34 = new F1040EZLineByLineCalculation_TypedDataContext9(locations, true);
                return refDataContext34.GetLocation<double>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly valDataContext35 = new F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                F1040EZLineByLineCalculation_TypedDataContext9 refDataContext36 = new F1040EZLineByLineCalculation_TypedDataContext9(locations, true);
                return refDataContext36.GetLocation<string>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
            }
            if ((expressionId == 37)) {
                F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly valDataContext37 = new F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly valDataContext38 = new F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                F1040EZLineByLineCalculation_TypedDataContext8 refDataContext39 = new F1040EZLineByLineCalculation_TypedDataContext8(locations, true);
                return refDataContext39.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                F1040EZLineByLineCalculation_TypedDataContext8 refDataContext40 = new F1040EZLineByLineCalculation_TypedDataContext8(locations, true);
                return refDataContext40.GetLocation<double>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set);
            }
            if ((expressionId == 41)) {
                F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly valDataContext41 = new F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                F1040EZLineByLineCalculation_TypedDataContext8 refDataContext42 = new F1040EZLineByLineCalculation_TypedDataContext8(locations, true);
                return refDataContext42.GetLocation<double>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                F1040EZLineByLineCalculation_TypedDataContext10_ForReadOnly valDataContext43 = new F1040EZLineByLineCalculation_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                F1040EZLineByLineCalculation_TypedDataContext10 refDataContext44 = new F1040EZLineByLineCalculation_TypedDataContext10(locations, true);
                return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
            }
            if ((expressionId == 45)) {
                F1040EZLineByLineCalculation_TypedDataContext11 refDataContext45 = new F1040EZLineByLineCalculation_TypedDataContext11(locations, true);
                return refDataContext45.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                F1040EZLineByLineCalculation_TypedDataContext11 refDataContext46 = new F1040EZLineByLineCalculation_TypedDataContext11(locations, true);
                return refDataContext46.GetLocation<double>(refDataContext46.ValueType___Expr46Get, refDataContext46.ValueType___Expr46Set);
            }
            if ((expressionId == 47)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext47 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext48 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext49 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set);
            }
            if ((expressionId == 50)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext50 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext50.GetLocation<double>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set);
            }
            if ((expressionId == 51)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext51 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext51.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext52 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext52.GetLocation<double>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set);
            }
            if ((expressionId == 53)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext53 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext53.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set);
            }
            if ((expressionId == 54)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext54 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext54.GetLocation<double>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set);
            }
            if ((expressionId == 55)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext55 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext55.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set);
            }
            if ((expressionId == 56)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext56 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext56.GetLocation<double>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set);
            }
            if ((expressionId == 57)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext57 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext57.GetLocation<double>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set);
            }
            if ((expressionId == 58)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext58 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext58.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set);
            }
            if ((expressionId == 59)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext59 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext59.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext60 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext60.GetLocation<double>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set);
            }
            if ((expressionId == 61)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext61 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext61.GetLocation<double>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext62 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext62.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set);
            }
            if ((expressionId == 63)) {
                F1040EZLineByLineCalculation_TypedDataContext13_ForReadOnly valDataContext63 = new F1040EZLineByLineCalculation_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                F1040EZLineByLineCalculation_TypedDataContext13 refDataContext64 = new F1040EZLineByLineCalculation_TypedDataContext13(locations, true);
                return refDataContext64.GetLocation<double>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set);
            }
            if ((expressionId == 65)) {
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext65 = new F1040EZLineByLineCalculation_TypedDataContext14(locations, true);
                return refDataContext65.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set);
            }
            if ((expressionId == 66)) {
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext66 = new F1040EZLineByLineCalculation_TypedDataContext14(locations, true);
                return refDataContext66.GetLocation<double>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set);
            }
            if ((expressionId == 67)) {
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext67 = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext68 = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext69 = new F1040EZLineByLineCalculation_TypedDataContext14(locations, true);
                return refDataContext69.GetLocation<string>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set);
            }
            if ((expressionId == 70)) {
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext70 = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext71 = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext72 = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext73 = new F1040EZLineByLineCalculation_TypedDataContext14(locations, true);
                return refDataContext73.GetLocation<string>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set);
            }
            if ((expressionId == 74)) {
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext74 = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext75 = new F1040EZLineByLineCalculation_TypedDataContext14(locations, true);
                return refDataContext75.GetLocation<string>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set);
            }
            if ((expressionId == 76)) {
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext76 = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext77 = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext78 = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext79 = new F1040EZLineByLineCalculation_TypedDataContext14(locations, true);
                return refDataContext79.GetLocation<string>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set);
            }
            if ((expressionId == 80)) {
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext80 = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext81 = new F1040EZLineByLineCalculation_TypedDataContext14(locations, true);
                return refDataContext81.GetLocation<string>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set);
            }
            if ((expressionId == 82)) {
                F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly valDataContext82 = new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                F1040EZLineByLineCalculation_TypedDataContext14 refDataContext83 = new F1040EZLineByLineCalculation_TypedDataContext14(locations, true);
                return refDataContext83.GetLocation<string>(refDataContext83.ValueType___Expr83Get, refDataContext83.ValueType___Expr83Set);
            }
            if ((expressionId == 84)) {
                F1040EZLineByLineCalculation_TypedDataContext15 refDataContext84 = new F1040EZLineByLineCalculation_TypedDataContext15(locations, true);
                return refDataContext84.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set);
            }
            if ((expressionId == 85)) {
                F1040EZLineByLineCalculation_TypedDataContext15 refDataContext85 = new F1040EZLineByLineCalculation_TypedDataContext15(locations, true);
                return refDataContext85.GetLocation<double>(refDataContext85.ValueType___Expr85Get, refDataContext85.ValueType___Expr85Set);
            }
            if ((expressionId == 86)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext86 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext87 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext88 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext88.GetLocation<double>(refDataContext88.ValueType___Expr88Get, refDataContext88.ValueType___Expr88Set);
            }
            if ((expressionId == 89)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext89 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext90 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext90.GetLocation<double>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set);
            }
            if ((expressionId == 91)) {
                F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly valDataContext91 = new F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly(locations, true);
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly valDataContext92 = new F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly(locations, true);
                return valDataContext92.ValueType___Expr92Get();
            }
            if ((expressionId == 93)) {
                F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly valDataContext93 = new F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly(locations, true);
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                F1040EZLineByLineCalculation_TypedDataContext16 refDataContext94 = new F1040EZLineByLineCalculation_TypedDataContext16(locations, true);
                return refDataContext94.GetLocation<double>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set);
            }
            if ((expressionId == 95)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext95 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext96 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext97 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext97.GetLocation<double>(refDataContext97.ValueType___Expr97Get, refDataContext97.ValueType___Expr97Set);
            }
            if ((expressionId == 98)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext98 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext98.GetLocation<double>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set);
            }
            if ((expressionId == 99)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext99 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext100 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext100.GetLocation<double>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set);
            }
            if ((expressionId == 101)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext101 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext101.GetLocation<double>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set);
            }
            if ((expressionId == 102)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext102 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext102.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set);
            }
            if ((expressionId == 103)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext103 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext104 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext104.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set);
            }
            if ((expressionId == 105)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext105 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext106 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext106.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext106.ValueType___Expr106Get, refDataContext106.ValueType___Expr106Set);
            }
            if ((expressionId == 107)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext107 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly valDataContext108 = new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                F1040EZLineByLineCalculation_TypedDataContext2 refDataContext109 = new F1040EZLineByLineCalculation_TypedDataContext2(locations, true);
                return refDataContext109.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "0.0D") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object !=null") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new OutputForms()") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Tax1040EZPage1()") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income !=null") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0)" +
                            ")") 
                        && (F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages") 
                        && (F1040EZLineByLineCalculation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZLineByLineCalculation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix") 
                        && (F1040EZLineByLineCalculation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NonQualifiedPlansAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT." +
                            "Count > 0))") 
                        && (F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099INTTaxExemptInterest") 
                        && (F1040EZLineByLineCalculation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZLineByLineCalculation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099INTTotal") 
                        && (F1040EZLineByLineCalculation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID." +
                            "Count > 0))") 
                        && (F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099OIDTaxExemptInterest") 
                        && (F1040EZLineByLineCalculation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZLineByLineCalculation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099OIDTotal") 
                        && (F1040EZLineByLineCalculation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099INTTotal + Form1099OIDTotal") 
                        && (F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest") 
                        && (F1040EZLineByLineCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "F1099INTTaxExemptInterest + F1099OIDTaxExemptInterest") 
                        && (F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TEI") 
                        && (F1040EZLineByLineCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TEI !=null") 
                        && (F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix") 
                        && (F1040EZLineByLineCalculation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Coun" +
                            "t > 0))") 
                        && (F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "UnemploymentAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalRepaid") 
                        && (F1040EZLineByLineCalculation_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalRepaid.ToString()") 
                        && (F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear") 
                        && (F1040EZLineByLineCalculation_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome !=null") 
                        && (F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue&&Tax1040Object.I" +
                            "ncome.OtherIncome.HasAlaskaPermanantFund.Value") 
                        && (F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AlaskaPermanantFundAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "UnemploymentAmount + AlaskaPermanantFundAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation") 
                        && (F1040EZLineByLineCalculation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.T" +
                            "ax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.Unemplo" +
                            "ymentCompensation") 
                        && (F1040EZLineByLineCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome") 
                        && (F1040EZLineByLineCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction") 
                        && (F1040EZLineByLineCalculation_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome > Tax1040Object.Outp" +
                            "utForms.Tax1040EZPage1.StandardDeduction") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome - Tax1040Object.Outp" +
                            "utForms.Tax1040EZPage1.StandardDeduction") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "W2FederalTaxWithholdTotal") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099INTFederalTaxWithholdTotal") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099OIDFederalTaxWithholdTotal") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099GFederalTaxWithholdTotal") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "FSSBFederalTaxWithHoldingTotal") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "FRRBFederalTaxWithHoldingTotal") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "W2FederalTaxWithholdTotal + Form1099INTFederalTaxWithholdTotal + Form1099OIDFeder" +
                            "alTaxWithholdTotal + Form1099GFederalTaxWithholdTotal + FSSBFederalTaxWithHoldin" +
                            "gTotal + FRRBFederalTaxWithHoldingTotal") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NonQualifiedPlansAmount > 0") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Utilities.IsStringEmpty(Prefix1040EZLine1)") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"DFC $\" + NonQualifiedPlansAmount.ToString()") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Prefix1040EZLine1 + \",DFC $\" + NonQualifiedPlansAmount.ToString()") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.Credits!=null) && (Tax1040Object.Credits.EIC!=null) && (Tax1040Obj" +
                            "ect.Credits.EIC.PenalInstitutionInmateWages.HasValue) &&(Tax1040Object.Credits.E" +
                            "IC.PenalInstitutionInmateWages > 0)") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Utilities.IsStringEmpty(Prefix1040EZLine1)") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"PRI $\" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString()") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Prefix1040EZLine1 + \",DFC $\" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWa" +
                            "ges.ToString()") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Prefix1040EZLine1") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix") 
                        && (F1040EZLineByLineCalculation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection") 
                        && (F1040EZLineByLineCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties != null && Tax1040Object.TaxesAndPenalties.Federa" +
                            "lExtensionAmount != null") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.HasValue ? Tax1040Object." +
                            "TaxesAndPenalties.FederalExtensionAmount.Value : 0)") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount + Tax1040Obj" +
                            "ect.OutputForms.Tax1040EZPage1.EarnedIncomeCredit+ Tax1040Object.OutputForms.Tax" +
                            "1040EZPage1.FederalExtensionAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails != null && Tax1040Object.PersonalDetails.PrimaryTax" +
                            "Payer != null && Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus !=nu" +
                            "ll") 
                        && (F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms != null && Tax1040Object.OutputForms.Tax1040EZPage1 != " +
                            "null && Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome !=null") 
                        && (F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "JTL.Tax1040.Core.Process.TaxRateCalculation.TaxCalculation(Tax1040Object.Personal" +
                            "Details.PrimaryTaxPayer.FilingStatus, Tax1040Object.OutputForms.Tax1040EZPage1.T" +
                            "axableIncome)") 
                        && (F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext16.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits > Tax1040Object." +
                            "OutputForms.Tax1040EZPage1.TaxAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits - Tax1040Object." +
                            "OutputForms.Tax1040EZPage1.TaxAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Ta" +
                            "x1040EZPage1.TotalPaymentsAndCredits") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (F1040EZLineByLineCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
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
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new F1040EZLineByLineCalculation_TypedDataContext4(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new F1040EZLineByLineCalculation_TypedDataContext4(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new F1040EZLineByLineCalculation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new F1040EZLineByLineCalculation_TypedDataContext4(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new F1040EZLineByLineCalculation_TypedDataContext4(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new F1040EZLineByLineCalculation_TypedDataContext6(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new F1040EZLineByLineCalculation_TypedDataContext6(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new F1040EZLineByLineCalculation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new F1040EZLineByLineCalculation_TypedDataContext6(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new F1040EZLineByLineCalculation_TypedDataContext7(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new F1040EZLineByLineCalculation_TypedDataContext7(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new F1040EZLineByLineCalculation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new F1040EZLineByLineCalculation_TypedDataContext7(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new F1040EZLineByLineCalculation_TypedDataContext5(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new F1040EZLineByLineCalculation_TypedDataContext5(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new F1040EZLineByLineCalculation_TypedDataContext5(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new F1040EZLineByLineCalculation_TypedDataContext9(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new F1040EZLineByLineCalculation_TypedDataContext9(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new F1040EZLineByLineCalculation_TypedDataContext9(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new F1040EZLineByLineCalculation_TypedDataContext9(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new F1040EZLineByLineCalculation_TypedDataContext8(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new F1040EZLineByLineCalculation_TypedDataContext8(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new F1040EZLineByLineCalculation_TypedDataContext8(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new F1040EZLineByLineCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new F1040EZLineByLineCalculation_TypedDataContext10(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new F1040EZLineByLineCalculation_TypedDataContext11(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new F1040EZLineByLineCalculation_TypedDataContext11(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new F1040EZLineByLineCalculation_TypedDataContext13(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new F1040EZLineByLineCalculation_TypedDataContext14(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new F1040EZLineByLineCalculation_TypedDataContext15(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new F1040EZLineByLineCalculation_TypedDataContext15(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new F1040EZLineByLineCalculation_TypedDataContext16(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new F1040EZLineByLineCalculation_TypedDataContext2(locationReferences).@__Expr109GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZLineByLineCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZLineByLineCalculation_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZLineByLineCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZLineByLineCalculation_TypedDataContext1 : F1040EZLineByLineCalculation_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZLineByLineCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                return F1040EZLineByLineCalculation_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext1_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZLineByLineCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                return F1040EZLineByLineCalculation_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext2 : F1040EZLineByLineCalculation_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double NonQualifiedPlansAmount;
            
            public F1040EZLineByLineCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 89 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.OutputForms>> expression = () => 
                  Tax1040Object.OutputForms;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.OutputForms @__Expr4Get() {
                
                #line 89 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                  Tax1040Object.OutputForms;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.OutputForms ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(JTL.Tax1040.BusinessObject.OutputForms value) {
                
                #line 89 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                  Tax1040Object.OutputForms = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(JTL.Tax1040.BusinessObject.OutputForms value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 101 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040EZPage1>> expression = () => 
                  Tax1040Object.OutputForms.Tax1040EZPage1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 @__Expr6Get() {
                
                #line 101 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                  Tax1040Object.OutputForms.Tax1040EZPage1;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(JTL.Tax1040.BusinessObject.Tax1040EZPage1 value) {
                
                #line 101 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                  Tax1040Object.OutputForms.Tax1040EZPage1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(JTL.Tax1040.BusinessObject.Tax1040EZPage1 value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 442 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr49Get() {
                
                #line 442 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr49Set(double value) {
                
                #line 442 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr49Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr49Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 456 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr50Get() {
                
                #line 456 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr50Set(double value) {
                
                #line 456 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr50Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr50Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 727 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr88Get() {
                
                #line 727 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr88Set(double value) {
                
                #line 727 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr88Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr88Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 741 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr90Get() {
                
                #line 741 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr90Set(double value) {
                
                #line 741 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr90Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr90Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 800 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr97Get() {
                
                #line 800 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr97Set(double value) {
                
                #line 800 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr97Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr97Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 812 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr98Get() {
                
                #line 812 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr98Set(double value) {
                
                #line 812 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr98Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr98Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 826 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr100Get() {
                
                #line 826 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr100Set(double value) {
                
                #line 826 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr100Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr100Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 838 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr101Get() {
                
                #line 838 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr101Set(double value) {
                
                #line 838 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr101Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr101Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 858 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr102Get() {
                
                #line 858 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr102Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 858 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                        Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr102Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr102Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 872 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr104Get() {
                
                #line 872 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr104Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 872 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                        Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr104Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr104Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 886 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr106Get() {
                
                #line 886 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 886 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                        Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr106Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr106Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 894 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                      Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr109Get() {
                
                #line 894 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                      Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr109Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                
                #line 894 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                      Tax1040Object.ErrorMessages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr109Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                this.GetValueTypeValues();
                this.@__Expr109Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.NonQualifiedPlansAmount = ((double)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.NonQualifiedPlansAmount);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 2)].Name != "ErrorMessage") 
                            || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "ErrorMessageList") 
                            || (locationReferences[(offset + 3)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "NonQualifiedPlansAmount") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double NonQualifiedPlansAmount;
            
            public F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 68 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
          Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr0Get() {
                
                #line 68 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 73 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
          0.0D;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr1Get() {
                
                #line 73 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
          0.0D;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 80 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          Tax1040Object !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr2Get() {
                
                #line 80 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
          Tax1040Object !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 94 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.OutputForms>> expression = () => 
                  new OutputForms();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.OutputForms @__Expr3Get() {
                
                #line 94 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                  new OutputForms();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.OutputForms ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 106 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040EZPage1>> expression = () => 
                  new Tax1040EZPage1();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 @__Expr5Get() {
                
                #line 106 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                  new Tax1040EZPage1();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 114 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                Tax1040Object.Income !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr7Get() {
                
                #line 114 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                Tax1040Object.Income !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 435 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome > Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr47Get() {
                
                #line 435 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome > Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 447 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome - Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr48Get() {
                
                #line 447 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome - Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 720 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.TaxesAndPenalties != null && Tax1040Object.TaxesAndPenalties.FederalExtensionAmount != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr86Get() {
                
                #line 720 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.TaxesAndPenalties != null && Tax1040Object.TaxesAndPenalties.FederalExtensionAmount != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 732 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            (Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.HasValue ? Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.Value : 0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr87Get() {
                
                #line 732 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                            (Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.HasValue ? Tax1040Object.TaxesAndPenalties.FederalExtensionAmount.Value : 0);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount + Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit+ Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr89Get() {
                
                #line 746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount + Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit+ Tax1040Object.OutputForms.Tax1040EZPage1.FederalExtensionAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 792 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits > Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr95Get() {
                
                #line 792 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits > Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 805 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits - Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr96Get() {
                
                #line 805 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits - Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 831 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr99Get() {
                
                #line 831 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 853 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                        ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr103Get() {
                
                #line 853 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 867 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                        ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr105Get() {
                
                #line 867 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 881 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                        ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr107Get() {
                
                #line 881 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 899 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                      ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr108Get() {
                
                #line 899 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                      ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            protected override void GetValueTypeValues() {
                this.NonQualifiedPlansAmount = ((double)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 2)].Name != "ErrorMessage") 
                            || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "ErrorMessageList") 
                            || (locationReferences[(offset + 3)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "NonQualifiedPlansAmount") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext3 : F1040EZLineByLineCalculation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZLineByLineCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.W2 W2 {
                get {
                    return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((5 + locationsOffset))));
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
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "W2") 
                            || (locationReferences[(offset + 5)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.W2 W2 {
                get {
                    return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((5 + locationsOffset))));
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
                
                #line 126 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        ((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 126 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        ((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
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
                if (((locationReferences[(offset + 5)].Name != "W2") 
                            || (locationReferences[(offset + 5)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext4 : F1040EZLineByLineCalculation_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWages;
            
            public F1040EZLineByLineCalculation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                              Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr9Get() {
                
                #line 152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                              Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 157 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr10Get() {
                
                #line 157 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(double value) {
                
                #line 157 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(string value) {
                
                #line 147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                              Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              NonQualifiedPlansAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr13Get() {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              NonQualifiedPlansAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(double value) {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                              NonQualifiedPlansAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalWages = ((double)(this.GetVariableValue((6 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((6 + locationsOffset), this.TotalWages);
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
                if (((locationReferences[(offset + 6)].Name != "TotalWages") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext4_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWages;
            
            public F1040EZLineByLineCalculation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 137 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                              ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr11Get() {
                
                #line 137 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalWages = ((double)(this.GetVariableValue((6 + locationsOffset))));
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
                if (((locationReferences[(offset + 6)].Name != "TotalWages") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext5 : F1040EZLineByLineCalculation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Totol1099OIDAmount;
            
            protected double Form1099INTTotal;
            
            protected double Form1099OIDTotal;
            
            protected double F1099INTTaxExemptInterest;
            
            protected double F1099OIDTaxExemptInterest;
            
            public F1040EZLineByLineCalculation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099INT Form1099INT {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((6 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 250 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr25Get() {
                
                #line 250 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 250 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
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
                
                #line 262 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TEI;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr27Get() {
                
                #line 262 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 262 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                        Tax1040Object.OutputForms.Tax1040EZPage1.TEI = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 281 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 281 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 281 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableExemptInterestPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Totol1099OIDAmount = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((10 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((7 + locationsOffset), this.Totol1099OIDAmount);
                this.SetVariableValue((8 + locationsOffset), this.Form1099INTTotal);
                this.SetVariableValue((9 + locationsOffset), this.Form1099OIDTotal);
                this.SetVariableValue((10 + locationsOffset), this.F1099INTTaxExemptInterest);
                this.SetVariableValue((11 + locationsOffset), this.F1099OIDTaxExemptInterest);
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
                if (((locationReferences[(offset + 5)].Name != "Form1099OID") 
                            || (locationReferences[(offset + 5)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Form1099INT") 
                            || (locationReferences[(offset + 6)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Totol1099OIDAmount") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Totol1099OIDAmount;
            
            protected double Form1099INTTotal;
            
            protected double Form1099OIDTotal;
            
            protected double F1099INTTaxExemptInterest;
            
            protected double F1099OIDTaxExemptInterest;
            
            public F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099INT Form1099INT {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 178 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        ((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr14Get() {
                
                #line 178 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        ((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        ((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr19Get() {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        ((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 255 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Form1099INTTotal + Form1099OIDTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr24Get() {
                
                #line 255 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 267 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        F1099INTTaxExemptInterest + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr26Get() {
                
                #line 267 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 274 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TEI !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr28Get() {
                
                #line 274 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TEI !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Totol1099OIDAmount = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((10 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((11 + locationsOffset))));
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
                if (((locationReferences[(offset + 5)].Name != "Form1099OID") 
                            || (locationReferences[(offset + 5)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Form1099INT") 
                            || (locationReferences[(offset + 6)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Totol1099OIDAmount") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext6 : F1040EZLineByLineCalculation_TypedDataContext5 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Total1099INTAmount;
            
            public F1040EZLineByLineCalculation_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 194 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                              Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr15Get() {
                
                #line 194 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 194 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                              Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 204 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr16Get() {
                
                #line 204 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(double value) {
                
                #line 204 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                              F1099INTTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 199 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Form1099INTTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr18Get() {
                
                #line 199 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 199 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
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
                this.Total1099INTAmount = ((double)(this.GetVariableValue((12 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((12 + locationsOffset), this.Total1099INTAmount);
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
                if (((locationReferences[(offset + 12)].Name != "Total1099INTAmount") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext5.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext6_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Total1099INTAmount;
            
            public F1040EZLineByLineCalculation_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 189 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                              ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr17Get() {
                
                #line 189 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Total1099INTAmount = ((double)(this.GetVariableValue((12 + locationsOffset))));
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
                if (((locationReferences[(offset + 12)].Name != "Total1099INTAmount") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext7 : F1040EZLineByLineCalculation_TypedDataContext5 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZLineByLineCalculation_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string variable1 {
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
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr20Get() {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
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
                
                #line 230 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                              Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr21Get() {
                
                #line 230 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 230 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                              Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Form1099OIDTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr23Get() {
                
                #line 235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                              Form1099OIDTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
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
                if (((locationReferences[(offset + 12)].Name != "variable1") 
                            || (locationReferences[(offset + 12)].Type != typeof(string)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext5.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext7_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZLineByLineCalculation_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string variable1 {
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
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 225 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                              ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr22Get() {
                
                #line 225 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                              ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
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
                if (((locationReferences[(offset + 12)].Name != "variable1") 
                            || (locationReferences[(offset + 12)].Type != typeof(string)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext5_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext8 : F1040EZLineByLineCalculation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double AlaskaPermanantFundAmount;
            
            protected double UnemploymentAmount;
            
            public F1040EZLineByLineCalculation_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099G Form1099G {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((5 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 371 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                  Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr39Get() {
                
                #line 371 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                  Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 371 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                                  Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 366 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr40Get() {
                
                #line 366 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                  AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr40Set(double value) {
                
                #line 366 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                                  AlaskaPermanantFundAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr40Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr40Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr42Get() {
                
                #line 383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(double value) {
                
                #line 383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                        Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.AlaskaPermanantFundAmount = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.UnemploymentAmount = ((double)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((6 + locationsOffset), this.AlaskaPermanantFundAmount);
                this.SetVariableValue((7 + locationsOffset), this.UnemploymentAmount);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 5)].Name != "Form1099G") 
                            || (locationReferences[(offset + 5)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "AlaskaPermanantFundAmount") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "UnemploymentAmount") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double AlaskaPermanantFundAmount;
            
            protected double UnemploymentAmount;
            
            public F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099G Form1099G {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 300 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        ((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr30Get() {
                
                #line 300 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        ((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 351 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr37Get() {
                
                #line 351 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 358 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue&&Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr38Get() {
                
                #line 358 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                            Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue&&Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.Value;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        UnemploymentAmount + AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr41Get() {
                
                #line 388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        UnemploymentAmount + AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            protected override void GetValueTypeValues() {
                this.AlaskaPermanantFundAmount = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.UnemploymentAmount = ((double)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 5)].Name != "Form1099G") 
                            || (locationReferences[(offset + 5)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "AlaskaPermanantFundAmount") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "UnemploymentAmount") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext9 : F1040EZLineByLineCalculation_TypedDataContext8 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalUnemploymentCompensationAmount;
            
            protected double TotalRepaid;
            
            public F1040EZLineByLineCalculation_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext9(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 318 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr31Get() {
                
                #line 318 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 318 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                                Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 328 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                UnemploymentAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr33Get() {
                
                #line 328 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                UnemploymentAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(double value) {
                
                #line 328 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                                UnemploymentAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 323 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                TotalRepaid;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr34Get() {
                
                #line 323 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                TotalRepaid;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(double value) {
                
                #line 323 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                                TotalRepaid = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 335 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr36Get() {
                
                #line 335 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr36Set(string value) {
                
                #line 335 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                                Tax1040Object.OutputForms.Tax1040EZPage1.TotalRepaidForCurrentYear = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalUnemploymentCompensationAmount = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.TotalRepaid = ((double)(this.GetVariableValue((9 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((8 + locationsOffset), this.TotalUnemploymentCompensationAmount);
                this.SetVariableValue((9 + locationsOffset), this.TotalRepaid);
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
                if (((locationReferences[(offset + 8)].Name != "TotalUnemploymentCompensationAmount") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "TotalRepaid") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext8.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalUnemploymentCompensationAmount;
            
            protected double TotalRepaid;
            
            public F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 313 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                                ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr32Get() {
                
                #line 313 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 340 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                TotalRepaid.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr35Get() {
                
                #line 340 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                TotalRepaid.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalUnemploymentCompensationAmount = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.TotalRepaid = ((double)(this.GetVariableValue((9 + locationsOffset))));
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
                if (((locationReferences[(offset + 8)].Name != "TotalUnemploymentCompensationAmount") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "TotalRepaid") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext8_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext10 : F1040EZLineByLineCalculation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalAdjustedGrossIncome;
            
            public F1040EZLineByLineCalculation_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext10(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 401 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr44Get() {
                
                #line 401 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr44Set(double value) {
                
                #line 401 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr44Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr44Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalAdjustedGrossIncome = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.TotalAdjustedGrossIncome);
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
                if (((locationReferences[(offset + 5)].Name != "TotalAdjustedGrossIncome") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext10_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalAdjustedGrossIncome;
            
            public F1040EZLineByLineCalculation_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 406 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr43Get() {
                
                #line 406 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalAdjustedGrossIncome = ((double)(this.GetVariableValue((5 + locationsOffset))));
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
                if (((locationReferences[(offset + 5)].Name != "TotalAdjustedGrossIncome") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext11 : F1040EZLineByLineCalculation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalStandardDeduction;
            
            public F1040EZLineByLineCalculation_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext11(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 420 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr45Get() {
                
                #line 420 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 420 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 425 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr46Get() {
                
                #line 425 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr46Set(double value) {
                
                #line 425 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr46Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr46Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalStandardDeduction = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.TotalStandardDeduction);
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
                if (((locationReferences[(offset + 5)].Name != "TotalStandardDeduction") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext11_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalStandardDeduction;
            
            public F1040EZLineByLineCalculation_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.TotalStandardDeduction = ((double)(this.GetVariableValue((5 + locationsOffset))));
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
                if (((locationReferences[(offset + 5)].Name != "TotalStandardDeduction") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext12 : F1040EZLineByLineCalculation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double W2FederalTaxWithholdTotal;
            
            protected double Form1099INTFederalTaxWithholdTotal;
            
            protected double Form1099OIDFederalTaxWithholdTotal;
            
            protected double Form1099GFederalTaxWithholdTotal;
            
            public F1040EZLineByLineCalculation_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext12(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.W2FederalTaxWithholdTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.Form1099INTFederalTaxWithholdTotal = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.Form1099OIDFederalTaxWithholdTotal = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.Form1099GFederalTaxWithholdTotal = ((double)(this.GetVariableValue((8 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.W2FederalTaxWithholdTotal);
                this.SetVariableValue((6 + locationsOffset), this.Form1099INTFederalTaxWithholdTotal);
                this.SetVariableValue((7 + locationsOffset), this.Form1099OIDFederalTaxWithholdTotal);
                this.SetVariableValue((8 + locationsOffset), this.Form1099GFederalTaxWithholdTotal);
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
                if (((locationReferences[(offset + 5)].Name != "W2FederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Form1099INTFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Form1099OIDFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Form1099GFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext12_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double W2FederalTaxWithholdTotal;
            
            protected double Form1099INTFederalTaxWithholdTotal;
            
            protected double Form1099OIDFederalTaxWithholdTotal;
            
            protected double Form1099GFederalTaxWithholdTotal;
            
            public F1040EZLineByLineCalculation_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.W2FederalTaxWithholdTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.Form1099INTFederalTaxWithholdTotal = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.Form1099OIDFederalTaxWithholdTotal = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.Form1099GFederalTaxWithholdTotal = ((double)(this.GetVariableValue((8 + locationsOffset))));
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
                if (((locationReferences[(offset + 5)].Name != "W2FederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Form1099INTFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Form1099OIDFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Form1099GFederalTaxWithholdTotal") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext13 : F1040EZLineByLineCalculation_TypedDataContext12 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double FSSBFederalTaxWithHoldingTotal;
            
            protected double FRRBFederalTaxWithHoldingTotal;
            
            public F1040EZLineByLineCalculation_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext13(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 481 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr51Get() {
                
                #line 481 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 481 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 486 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          W2FederalTaxWithholdTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr52Get() {
                
                #line 486 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          W2FederalTaxWithholdTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr52Set(double value) {
                
                #line 486 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          W2FederalTaxWithholdTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr52Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr52Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 493 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr53Get() {
                
                #line 493 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr53Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 493 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr53Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr53Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 498 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099INTFederalTaxWithholdTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr54Get() {
                
                #line 498 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          Form1099INTFederalTaxWithholdTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr54Set(double value) {
                
                #line 498 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          Form1099INTFederalTaxWithholdTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr54Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr54Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr55Get() {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr55Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr55Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr55Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 510 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099OIDFederalTaxWithholdTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr56Get() {
                
                #line 510 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          Form1099OIDFederalTaxWithholdTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr56Set(double value) {
                
                #line 510 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          Form1099OIDFederalTaxWithholdTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr56Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr56Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 522 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099GFederalTaxWithholdTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr57Get() {
                
                #line 522 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          Form1099GFederalTaxWithholdTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr57Set(double value) {
                
                #line 522 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          Form1099GFederalTaxWithholdTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr57Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr57Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 517 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr58Get() {
                
                #line 517 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 517 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
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
                
                #line 529 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr59Get() {
                
                #line 529 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 529 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
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
                
                #line 534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          FSSBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr60Get() {
                
                #line 534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          FSSBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr60Set(double value) {
                
                #line 534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          FSSBFederalTaxWithHoldingTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr60Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr60Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 546 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          FRRBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr61Get() {
                
                #line 546 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          FRRBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(double value) {
                
                #line 546 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          FRRBFederalTaxWithHoldingTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 541 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                          Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr62Get() {
                
                #line 541 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr62Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 541 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr62Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr62Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 553 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr64Get() {
                
                #line 553 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr64Set(double value) {
                
                #line 553 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                          Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr64Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr64Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.FSSBFederalTaxWithHoldingTotal = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.FRRBFederalTaxWithHoldingTotal = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((9 + locationsOffset), this.FSSBFederalTaxWithHoldingTotal);
                this.SetVariableValue((10 + locationsOffset), this.FRRBFederalTaxWithHoldingTotal);
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
                if (((locationReferences[(offset + 9)].Name != "FSSBFederalTaxWithHoldingTotal") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "FRRBFederalTaxWithHoldingTotal") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext12.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext13_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext12_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double FSSBFederalTaxWithHoldingTotal;
            
            protected double FRRBFederalTaxWithHoldingTotal;
            
            public F1040EZLineByLineCalculation_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 558 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          W2FederalTaxWithholdTotal + Form1099INTFederalTaxWithholdTotal + Form1099OIDFederalTaxWithholdTotal + Form1099GFederalTaxWithholdTotal + FSSBFederalTaxWithHoldingTotal + FRRBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr63Get() {
                
                #line 558 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                          W2FederalTaxWithholdTotal + Form1099INTFederalTaxWithholdTotal + Form1099OIDFederalTaxWithholdTotal + Form1099GFederalTaxWithholdTotal + FSSBFederalTaxWithHoldingTotal + FRRBFederalTaxWithHoldingTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            protected override void GetValueTypeValues() {
                this.FSSBFederalTaxWithHoldingTotal = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.FRRBFederalTaxWithHoldingTotal = ((double)(this.GetVariableValue((10 + locationsOffset))));
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
                if (((locationReferences[(offset + 9)].Name != "FSSBFederalTaxWithHoldingTotal") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "FRRBFederalTaxWithHoldingTotal") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext12_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext14 : F1040EZLineByLineCalculation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double EarnedIncomeCreditTotal;
            
            public F1040EZLineByLineCalculation_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext14(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 577 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr65Get() {
                
                #line 577 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 577 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
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
                
                #line 582 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr66Get() {
                
                #line 582 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr66Set(double value) {
                
                #line 582 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                        Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr66Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr66Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr69Get() {
                
                #line 589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr69Set(string value) {
                
                #line 589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                        Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr69Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr69Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 615 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr73Get() {
                
                #line 615 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr73Set(string value) {
                
                #line 615 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                                Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr73Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr73Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 629 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr75Get() {
                
                #line 629 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr75Set(string value) {
                
                #line 629 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                                Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr75Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr75Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 659 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr79Get() {
                
                #line 659 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 659 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                                Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr79Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr79Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 673 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr81Get() {
                
                #line 673 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr81Set(string value) {
                
                #line 673 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                                Prefix1040EZLine1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr81Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr81Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 689 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr83Get() {
                
                #line 689 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr83Set(string value) {
                
                #line 689 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                        Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr83Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr83Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.EarnedIncomeCreditTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.EarnedIncomeCreditTotal);
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
                if (((locationReferences[(offset + 6)].Name != "Prefix1040EZLine1") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "EarnedIncomeCreditTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double EarnedIncomeCreditTotal;
            
            public F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 572 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                        ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr67Get() {
                
                #line 572 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 594 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr68Get() {
                
                #line 594 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.WagesPrefix;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 601 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        NonQualifiedPlansAmount > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr70Get() {
                
                #line 601 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        NonQualifiedPlansAmount > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 608 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Utilities.IsStringEmpty(Prefix1040EZLine1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr71Get() {
                
                #line 608 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                            Utilities.IsStringEmpty(Prefix1040EZLine1);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 620 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                "DFC $" + NonQualifiedPlansAmount.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr72Get() {
                
                #line 620 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                "DFC $" + NonQualifiedPlansAmount.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 634 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Prefix1040EZLine1 + ",DFC $" + NonQualifiedPlansAmount.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr74Get() {
                
                #line 634 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                Prefix1040EZLine1 + ",DFC $" + NonQualifiedPlansAmount.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 645 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        (Tax1040Object.Credits!=null) && (Tax1040Object.Credits.EIC!=null) && (Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.HasValue) &&(Tax1040Object.Credits.EIC.PenalInstitutionInmateWages > 0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr76Get() {
                
                #line 645 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        (Tax1040Object.Credits!=null) && (Tax1040Object.Credits.EIC!=null) && (Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.HasValue) &&(Tax1040Object.Credits.EIC.PenalInstitutionInmateWages > 0);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 652 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Utilities.IsStringEmpty(Prefix1040EZLine1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr77Get() {
                
                #line 652 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                            Utilities.IsStringEmpty(Prefix1040EZLine1);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 664 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                "PRI $" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr78Get() {
                
                #line 664 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                "PRI $" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 678 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Prefix1040EZLine1 + ",DFC $" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr80Get() {
                
                #line 678 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                Prefix1040EZLine1 + ",DFC $" + Tax1040Object.Credits.EIC.PenalInstitutionInmateWages.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 694 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        Prefix1040EZLine1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr82Get() {
                
                #line 694 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Prefix1040EZLine1;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            protected override void GetValueTypeValues() {
                this.EarnedIncomeCreditTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
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
                if (((locationReferences[(offset + 6)].Name != "Prefix1040EZLine1") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "EarnedIncomeCreditTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext15 : F1040EZLineByLineCalculation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double NonTaxableCombatPayElectionTotal;
            
            public F1040EZLineByLineCalculation_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext15(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr84Get() {
                
                #line 706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
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
                
                #line 706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
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
                
                #line 711 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr85Get() {
                
                #line 711 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr85Set(double value) {
                
                #line 711 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                        Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr85Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr85Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.NonTaxableCombatPayElectionTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.NonTaxableCombatPayElectionTotal);
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
                if (((locationReferences[(offset + 5)].Name != "NonTaxableCombatPayElectionTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext15_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double NonTaxableCombatPayElectionTotal;
            
            public F1040EZLineByLineCalculation_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.NonTaxableCombatPayElectionTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
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
                if (((locationReferences[(offset + 5)].Name != "NonTaxableCombatPayElectionTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext16 : F1040EZLineByLineCalculation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TaxAmountTotal;
            
            public F1040EZLineByLineCalculation_TypedDataContext16(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext16(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext16(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 772 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr94Get() {
                
                #line 772 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr94Set(double value) {
                
                #line 772 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr94Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr94Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TaxAmountTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.TaxAmountTotal);
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
                if (((locationReferences[(offset + 5)].Name != "TaxAmountTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly : F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TaxAmountTotal;
            
            public F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZLineByLineCalculation_TypedDataContext16_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 758 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.PersonalDetails != null && Tax1040Object.PersonalDetails.PrimaryTaxPayer != null && Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr91Get() {
                
                #line 758 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                        Tax1040Object.PersonalDetails != null && Tax1040Object.PersonalDetails.PrimaryTaxPayer != null && Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 765 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Tax1040Object.OutputForms != null && Tax1040Object.OutputForms.Tax1040EZPage1 != null && Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr92Get() {
                
                #line 765 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                            Tax1040Object.OutputForms != null && Tax1040Object.OutputForms.Tax1040EZPage1 != null && Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 777 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                JTL.Tax1040.Core.Process.TaxRateCalculation.TaxCalculation(Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus, Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr93Get() {
                
                #line 777 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZLINEBYLINECALCULATION.XAML"
                return 
                                JTL.Tax1040.Core.Process.TaxRateCalculation.TaxCalculation(Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus, Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TaxAmountTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
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
                if (((locationReferences[(offset + 5)].Name != "TaxAmountTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZLineByLineCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
