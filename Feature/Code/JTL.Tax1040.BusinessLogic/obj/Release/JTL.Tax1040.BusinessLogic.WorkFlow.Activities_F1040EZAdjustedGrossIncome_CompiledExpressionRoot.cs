namespace JTL.Tax1040.BusinessLogic.WorkFlow.Activities {
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZAdjustedGrossIncome.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZAdjustedGrossIncome.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZAdjustedGrossIncome.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZAdjustedGrossIncome.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZAdjustedGrossIncome.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZAdjustedGrossIncome.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZAdjustedGrossIncome.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZAdjustedGrossIncome.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 28 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZAdjustedGrossIncome.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 29 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZAdjustedGrossIncome.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 30 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZAdjustedGrossIncome.xaml"
    using JTL.Tax1040.Core.Object;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZAdjustedGrossIncome.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class F1040EZAdjustedGrossIncome : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly valDataContext0 = ((F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly valDataContext1 = ((F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZAdjustedGrossIncome_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext2 refDataContext2 = ((F1040EZAdjustedGrossIncome_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.OutputForms>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly valDataContext3 = ((F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZAdjustedGrossIncome_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext2 refDataContext4 = ((F1040EZAdjustedGrossIncome_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<JTL.Tax1040.BusinessObject.Tax1040EZPage1>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly valDataContext5 = ((F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly valDataContext6 = ((F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZAdjustedGrossIncome_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext3 refDataContext7 = ((F1040EZAdjustedGrossIncome_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext7.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZAdjustedGrossIncome_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext3 refDataContext8 = ((F1040EZAdjustedGrossIncome_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly valDataContext9 = ((F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly valDataContext10 = ((F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZAdjustedGrossIncome_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext5 refDataContext11 = ((F1040EZAdjustedGrossIncome_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext11.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZAdjustedGrossIncome_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext5 refDataContext12 = ((F1040EZAdjustedGrossIncome_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext12.GetLocation<double>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZAdjustedGrossIncome_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext5_ForReadOnly valDataContext13 = ((F1040EZAdjustedGrossIncome_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZAdjustedGrossIncome_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext5 refDataContext14 = ((F1040EZAdjustedGrossIncome_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext14.GetLocation<double>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly valDataContext15 = ((F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZAdjustedGrossIncome_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext6 refDataContext16 = ((F1040EZAdjustedGrossIncome_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext16.GetLocation<double>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZAdjustedGrossIncome_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext6 refDataContext17 = ((F1040EZAdjustedGrossIncome_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext17.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZAdjustedGrossIncome_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext6_ForReadOnly valDataContext18 = ((F1040EZAdjustedGrossIncome_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZAdjustedGrossIncome_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext6 refDataContext19 = ((F1040EZAdjustedGrossIncome_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext19.GetLocation<double>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly valDataContext20 = ((F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZAdjustedGrossIncome_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext4 refDataContext21 = ((F1040EZAdjustedGrossIncome_TypedDataContext4)(cachedCompiledDataContext[9]));
                return refDataContext21.GetLocation<double>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly valDataContext22 = ((F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZAdjustedGrossIncome_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext4 refDataContext23 = ((F1040EZAdjustedGrossIncome_TypedDataContext4)(cachedCompiledDataContext[9]));
                return refDataContext23.GetLocation<double>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly valDataContext24 = ((F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZAdjustedGrossIncome_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext8 refDataContext25 = ((F1040EZAdjustedGrossIncome_TypedDataContext8)(cachedCompiledDataContext[11]));
                return refDataContext25.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new F1040EZAdjustedGrossIncome_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext8_ForReadOnly valDataContext26 = ((F1040EZAdjustedGrossIncome_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZAdjustedGrossIncome_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext8 refDataContext27 = ((F1040EZAdjustedGrossIncome_TypedDataContext8)(cachedCompiledDataContext[11]));
                return refDataContext27.GetLocation<double>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly valDataContext28 = ((F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly valDataContext29 = ((F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new F1040EZAdjustedGrossIncome_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext7 refDataContext30 = ((F1040EZAdjustedGrossIncome_TypedDataContext7)(cachedCompiledDataContext[13]));
                return refDataContext30.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new F1040EZAdjustedGrossIncome_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext7 refDataContext31 = ((F1040EZAdjustedGrossIncome_TypedDataContext7)(cachedCompiledDataContext[13]));
                return refDataContext31.GetLocation<double>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly valDataContext32 = ((F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new F1040EZAdjustedGrossIncome_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext7 refDataContext33 = ((F1040EZAdjustedGrossIncome_TypedDataContext7)(cachedCompiledDataContext[13]));
                return refDataContext33.GetLocation<double>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly valDataContext34 = ((F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZAdjustedGrossIncome_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext3 refDataContext35 = ((F1040EZAdjustedGrossIncome_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext35.GetLocation<double>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly valDataContext36 = ((F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZAdjustedGrossIncome_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext3 refDataContext37 = ((F1040EZAdjustedGrossIncome_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext37.GetLocation<double>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly valDataContext38 = ((F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZAdjustedGrossIncome_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZAdjustedGrossIncome_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZAdjustedGrossIncome_TypedDataContext3 refDataContext39 = ((F1040EZAdjustedGrossIncome_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext39.GetLocation<double>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
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
                F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly valDataContext0 = new F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly valDataContext1 = new F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                F1040EZAdjustedGrossIncome_TypedDataContext2 refDataContext2 = new F1040EZAdjustedGrossIncome_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.OutputForms>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly valDataContext3 = new F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                F1040EZAdjustedGrossIncome_TypedDataContext2 refDataContext4 = new F1040EZAdjustedGrossIncome_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<JTL.Tax1040.BusinessObject.Tax1040EZPage1>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly valDataContext5 = new F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly valDataContext6 = new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                F1040EZAdjustedGrossIncome_TypedDataContext3 refDataContext7 = new F1040EZAdjustedGrossIncome_TypedDataContext3(locations, true);
                return refDataContext7.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                F1040EZAdjustedGrossIncome_TypedDataContext3 refDataContext8 = new F1040EZAdjustedGrossIncome_TypedDataContext3(locations, true);
                return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly valDataContext9 = new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly valDataContext10 = new F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                F1040EZAdjustedGrossIncome_TypedDataContext5 refDataContext11 = new F1040EZAdjustedGrossIncome_TypedDataContext5(locations, true);
                return refDataContext11.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                F1040EZAdjustedGrossIncome_TypedDataContext5 refDataContext12 = new F1040EZAdjustedGrossIncome_TypedDataContext5(locations, true);
                return refDataContext12.GetLocation<double>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                F1040EZAdjustedGrossIncome_TypedDataContext5_ForReadOnly valDataContext13 = new F1040EZAdjustedGrossIncome_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                F1040EZAdjustedGrossIncome_TypedDataContext5 refDataContext14 = new F1040EZAdjustedGrossIncome_TypedDataContext5(locations, true);
                return refDataContext14.GetLocation<double>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly valDataContext15 = new F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                F1040EZAdjustedGrossIncome_TypedDataContext6 refDataContext16 = new F1040EZAdjustedGrossIncome_TypedDataContext6(locations, true);
                return refDataContext16.GetLocation<double>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                F1040EZAdjustedGrossIncome_TypedDataContext6 refDataContext17 = new F1040EZAdjustedGrossIncome_TypedDataContext6(locations, true);
                return refDataContext17.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                F1040EZAdjustedGrossIncome_TypedDataContext6_ForReadOnly valDataContext18 = new F1040EZAdjustedGrossIncome_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                F1040EZAdjustedGrossIncome_TypedDataContext6 refDataContext19 = new F1040EZAdjustedGrossIncome_TypedDataContext6(locations, true);
                return refDataContext19.GetLocation<double>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly valDataContext20 = new F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                F1040EZAdjustedGrossIncome_TypedDataContext4 refDataContext21 = new F1040EZAdjustedGrossIncome_TypedDataContext4(locations, true);
                return refDataContext21.GetLocation<double>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly valDataContext22 = new F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                F1040EZAdjustedGrossIncome_TypedDataContext4 refDataContext23 = new F1040EZAdjustedGrossIncome_TypedDataContext4(locations, true);
                return refDataContext23.GetLocation<double>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly valDataContext24 = new F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                F1040EZAdjustedGrossIncome_TypedDataContext8 refDataContext25 = new F1040EZAdjustedGrossIncome_TypedDataContext8(locations, true);
                return refDataContext25.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                F1040EZAdjustedGrossIncome_TypedDataContext8_ForReadOnly valDataContext26 = new F1040EZAdjustedGrossIncome_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                F1040EZAdjustedGrossIncome_TypedDataContext8 refDataContext27 = new F1040EZAdjustedGrossIncome_TypedDataContext8(locations, true);
                return refDataContext27.GetLocation<double>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly valDataContext28 = new F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly valDataContext29 = new F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                F1040EZAdjustedGrossIncome_TypedDataContext7 refDataContext30 = new F1040EZAdjustedGrossIncome_TypedDataContext7(locations, true);
                return refDataContext30.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                F1040EZAdjustedGrossIncome_TypedDataContext7 refDataContext31 = new F1040EZAdjustedGrossIncome_TypedDataContext7(locations, true);
                return refDataContext31.GetLocation<double>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly valDataContext32 = new F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                F1040EZAdjustedGrossIncome_TypedDataContext7 refDataContext33 = new F1040EZAdjustedGrossIncome_TypedDataContext7(locations, true);
                return refDataContext33.GetLocation<double>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly valDataContext34 = new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                F1040EZAdjustedGrossIncome_TypedDataContext3 refDataContext35 = new F1040EZAdjustedGrossIncome_TypedDataContext3(locations, true);
                return refDataContext35.GetLocation<double>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly valDataContext36 = new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                F1040EZAdjustedGrossIncome_TypedDataContext3 refDataContext37 = new F1040EZAdjustedGrossIncome_TypedDataContext3(locations, true);
                return refDataContext37.GetLocation<double>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set);
            }
            if ((expressionId == 38)) {
                F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly valDataContext38 = new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                F1040EZAdjustedGrossIncome_TypedDataContext3 refDataContext39 = new F1040EZAdjustedGrossIncome_TypedDataContext3(locations, true);
                return refDataContext39.GetLocation<double>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object!=null") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new OutputForms()") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Tax1040EZPage1()") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income!=null") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0)" +
                            ")") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT." +
                            "Count > 0))") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099INTTaxExemptInterest") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099INTTotal") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID." +
                            "Count > 0))") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099OIDTaxExemptInterest") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099OIDTotal") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099INTTotal + Form1099OIDTotal") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "F1099INTTaxExemptInterest + F1099OIDTaxExemptInterest") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TEI") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Coun" +
                            "t > 0))") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "UnemploymentAmount") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome !=null") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object" +
                            ".Income.OtherIncome.HasAlaskaPermanantFund.Value") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AlaskaPermanantFundAmount") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "UnemploymentAmount + AlaskaPermanantFundAmount") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.T" +
                            "ax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.Unemplo" +
                            "ymentCompensation") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AnnualGrossIncome") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "AnnualGrossIncome") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalW2Wages") 
                        && (F1040EZAdjustedGrossIncome_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
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
                return new F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext3(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext3(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext5(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext5(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext5_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext5(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext6(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext6(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext6_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext6(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext4(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext4(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext8(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext8_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext8(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext7(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext7(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext7(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext3(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext3(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new F1040EZAdjustedGrossIncome_TypedDataContext3(locationReferences).@__Expr39GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZAdjustedGrossIncome_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZAdjustedGrossIncome_TypedDataContext1 : F1040EZAdjustedGrossIncome_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double AnnualGrossIncome;
            
            protected double TotalW2Wages;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            protected override void GetValueTypeValues() {
                this.AnnualGrossIncome = ((double)(this.GetVariableValue((2 + locationsOffset))));
                this.TotalW2Wages = ((double)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((2 + locationsOffset), this.AnnualGrossIncome);
                this.SetVariableValue((3 + locationsOffset), this.TotalW2Wages);
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
                if (((locationReferences[(offset + 1)].Name != "ErrorMessages") 
                            || (locationReferences[(offset + 1)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessages)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "AnnualGrossIncome") 
                            || (locationReferences[(offset + 2)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "TotalW2Wages") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext1_ForReadOnly : F1040EZAdjustedGrossIncome_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double AnnualGrossIncome;
            
            protected double TotalW2Wages;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            protected override void GetValueTypeValues() {
                this.AnnualGrossIncome = ((double)(this.GetVariableValue((2 + locationsOffset))));
                this.TotalW2Wages = ((double)(this.GetVariableValue((3 + locationsOffset))));
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
                if (((locationReferences[(offset + 1)].Name != "ErrorMessages") 
                            || (locationReferences[(offset + 1)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessages)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "AnnualGrossIncome") 
                            || (locationReferences[(offset + 2)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "TotalW2Wages") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext2 : F1040EZAdjustedGrossIncome_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWages;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 77 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.OutputForms>> expression = () => 
                    Tax1040Object.OutputForms;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.OutputForms @__Expr2Get() {
                
                #line 77 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
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
                
                #line 77 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
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
                
                #line 89 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040EZPage1>> expression = () => 
                    Tax1040Object.OutputForms.Tax1040EZPage1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 @__Expr4Get() {
                
                #line 89 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
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
                
                #line 89 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                    Tax1040Object.OutputForms.Tax1040EZPage1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(JTL.Tax1040.BusinessObject.Tax1040EZPage1 value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
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
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 4)].Name != "TotalWages") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly : F1040EZAdjustedGrossIncome_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWages;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 68 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
            Tax1040Object!=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr0Get() {
                
                #line 68 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
            Tax1040Object!=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 82 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.OutputForms>> expression = () => 
                    new OutputForms();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.OutputForms @__Expr1Get() {
                
                #line 82 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
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
                
                #line 94 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040EZPage1>> expression = () => 
                    new Tax1040EZPage1();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040EZPage1 @__Expr3Get() {
                
                #line 94 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
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
                
                #line 103 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    Tax1040Object.Income!=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 103 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                    Tax1040Object.Income!=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalWages = ((double)(this.GetVariableValue((4 + locationsOffset))));
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
                if (((locationReferences[(offset + 4)].Name != "TotalWages") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext3 : F1040EZAdjustedGrossIncome_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 127 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr7Get() {
                
                #line 127 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
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
                
                #line 127 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
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
                
                #line 132 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr8Get() {
                
                #line 132 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(double value) {
                
                #line 132 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                                Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            AnnualGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr35Get() {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            AnnualGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(double value) {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                            AnnualGrossIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 346 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr37Get() {
                
                #line 346 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr37Set(double value) {
                
                #line 346 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr37Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr37Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 358 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            TotalW2Wages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr39Get() {
                
                #line 358 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            TotalW2Wages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(double value) {
                
                #line 358 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                            TotalW2Wages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
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
                return F1040EZAdjustedGrossIncome_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly : F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 114 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          ((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 114 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                          ((Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 122 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                                ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr9Get() {
                
                #line 122 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr34Get() {
                
                #line 339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 351 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            AnnualGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr36Get() {
                
                #line 351 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            AnnualGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr38Get() {
                
                #line 363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
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
                return F1040EZAdjustedGrossIncome_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext4 : F1040EZAdjustedGrossIncome_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Totol1099OIDAmount;
            
            protected double Form1099INTTotal;
            
            protected double Form1099OIDTotal;
            
            protected double F1099INTTaxExemptInterest;
            
            protected double F1099OIDTaxExemptInterest;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            protected JTL.Tax1040.BusinessObject.Form1099INT Form1099INT {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
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
                
                #line 224 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr21Get() {
                
                #line 224 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(double value) {
                
                #line 224 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 236 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TEI;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr23Get() {
                
                #line 236 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TEI;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(double value) {
                
                #line 236 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.TEI = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Totol1099OIDAmount = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((10 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((12 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((8 + locationsOffset), this.Totol1099OIDAmount);
                this.SetVariableValue((9 + locationsOffset), this.Form1099INTTotal);
                this.SetVariableValue((10 + locationsOffset), this.Form1099OIDTotal);
                this.SetVariableValue((11 + locationsOffset), this.F1099INTTaxExemptInterest);
                this.SetVariableValue((12 + locationsOffset), this.F1099OIDTaxExemptInterest);
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
                if (((locationReferences[(offset + 6)].Name != "Form1099OID") 
                            || (locationReferences[(offset + 6)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Form1099INT") 
                            || (locationReferences[(offset + 7)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Totol1099OIDAmount") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly : F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Totol1099OIDAmount;
            
            protected double Form1099INTTotal;
            
            protected double Form1099OIDTotal;
            
            protected double F1099INTTaxExemptInterest;
            
            protected double F1099OIDTaxExemptInterest;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099INT Form1099INT {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((7 + locationsOffset))));
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
                
                #line 152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            ((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr10Get() {
                
                #line 152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            ((Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            ((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr15Get() {
                
                #line 188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            ((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 229 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Form1099INTTotal + Form1099OIDTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr20Get() {
                
                #line 229 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            Form1099INTTotal + Form1099OIDTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 241 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            F1099INTTaxExemptInterest + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr22Get() {
                
                #line 241 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            F1099INTTaxExemptInterest + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Totol1099OIDAmount = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((10 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((12 + locationsOffset))));
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
                if (((locationReferences[(offset + 6)].Name != "Form1099OID") 
                            || (locationReferences[(offset + 6)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Form1099INT") 
                            || (locationReferences[(offset + 7)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Totol1099OIDAmount") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext5 : F1040EZAdjustedGrossIncome_TypedDataContext4 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Total1099INTAmount;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 168 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                  Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr11Get() {
                
                #line 168 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
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
                
                #line 168 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
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
                
                #line 178 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr12Get() {
                
                #line 178 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                  F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(double value) {
                
                #line 178 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                                  F1099INTTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 173 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Form1099INTTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr14Get() {
                
                #line 173 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                  Form1099INTTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(double value) {
                
                #line 173 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                                  Form1099INTTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Total1099INTAmount = ((double)(this.GetVariableValue((13 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((13 + locationsOffset), this.Total1099INTAmount);
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
                if (((locationReferences[(offset + 13)].Name != "Total1099INTAmount") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext5_ForReadOnly : F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Total1099INTAmount;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 163 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                                  ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr13Get() {
                
                #line 163 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                  ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Total1099INTAmount = ((double)(this.GetVariableValue((13 + locationsOffset))));
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
                if (((locationReferences[(offset + 13)].Name != "Total1099INTAmount") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext6 : F1040EZAdjustedGrossIncome_TypedDataContext4 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string variable1 {
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
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr16Get() {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                  F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(double value) {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                                  F1099OIDTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 204 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                  Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr17Get() {
                
                #line 204 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
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
                
                #line 204 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                                  Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 209 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Form1099OIDTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr19Get() {
                
                #line 209 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                  Form1099OIDTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(double value) {
                
                #line 209 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                                  Form1099OIDTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
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
                if (((locationReferences[(offset + 13)].Name != "variable1") 
                            || (locationReferences[(offset + 13)].Type != typeof(string)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext6_ForReadOnly : F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string variable1 {
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
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 199 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                                  ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr18Get() {
                
                #line 199 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                  ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
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
                if (((locationReferences[(offset + 13)].Name != "variable1") 
                            || (locationReferences[(offset + 13)].Type != typeof(string)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext7 : F1040EZAdjustedGrossIncome_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double AlaskaPermanantFundAmount;
            
            protected double UnemploymentAmount;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099G Form1099G {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((6 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 308 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                      Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr30Get() {
                
                #line 308 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                      Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 308 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                                      Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 303 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr31Get() {
                
                #line 303 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                      AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(double value) {
                
                #line 303 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                                      AlaskaPermanantFundAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 320 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr33Get() {
                
                #line 320 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(double value) {
                
                #line 320 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.AlaskaPermanantFundAmount = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.UnemploymentAmount = ((double)(this.GetVariableValue((8 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((7 + locationsOffset), this.AlaskaPermanantFundAmount);
                this.SetVariableValue((8 + locationsOffset), this.UnemploymentAmount);
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
                if (((locationReferences[(offset + 6)].Name != "Form1099G") 
                            || (locationReferences[(offset + 6)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "AlaskaPermanantFundAmount") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "UnemploymentAmount") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly : F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double AlaskaPermanantFundAmount;
            
            protected double UnemploymentAmount;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099G Form1099G {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 255 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            ((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr24Get() {
                
                #line 255 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            ((Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 288 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr28Get() {
                
                #line 288 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 295 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr29Get() {
                
                #line 295 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.Value;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 325 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            UnemploymentAmount + AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr32Get() {
                
                #line 325 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                            UnemploymentAmount + AlaskaPermanantFundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            protected override void GetValueTypeValues() {
                this.AlaskaPermanantFundAmount = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.UnemploymentAmount = ((double)(this.GetVariableValue((8 + locationsOffset))));
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
                if (((locationReferences[(offset + 6)].Name != "Form1099G") 
                            || (locationReferences[(offset + 6)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "AlaskaPermanantFundAmount") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "UnemploymentAmount") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext8 : F1040EZAdjustedGrossIncome_TypedDataContext7 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalUnemploymentCompensationAmount;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 272 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                    Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr25Get() {
                
                #line 272 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                    Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 272 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                                    Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 277 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    UnemploymentAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr27Get() {
                
                #line 277 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                    UnemploymentAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(double value) {
                
                #line 277 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                
                                    UnemploymentAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalUnemploymentCompensationAmount = ((double)(this.GetVariableValue((9 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((9 + locationsOffset), this.TotalUnemploymentCompensationAmount);
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
                if (((locationReferences[(offset + 9)].Name != "TotalUnemploymentCompensationAmount") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext7.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZAdjustedGrossIncome_TypedDataContext8_ForReadOnly : F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalUnemploymentCompensationAmount;
            
            public F1040EZAdjustedGrossIncome_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZAdjustedGrossIncome_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 267 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                                    ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr26Get() {
                
                #line 267 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZADJUSTEDGROSSINCOME.XAML"
                return 
                                    ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalUnemploymentCompensationAmount = ((double)(this.GetVariableValue((9 + locationsOffset))));
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
                if (((locationReferences[(offset + 9)].Name != "TotalUnemploymentCompensationAmount") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZAdjustedGrossIncome_TypedDataContext7_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
