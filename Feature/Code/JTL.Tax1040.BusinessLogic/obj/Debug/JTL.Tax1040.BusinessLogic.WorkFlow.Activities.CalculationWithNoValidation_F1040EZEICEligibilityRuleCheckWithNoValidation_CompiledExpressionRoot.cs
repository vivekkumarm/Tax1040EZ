namespace JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation {
    
    #line 23 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZEICEligibilityRuleCheckWithNoValidation.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZEICEligibilityRuleCheckWithNoValidation.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZEICEligibilityRuleCheckWithNoValidation.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZEICEligibilityRuleCheckWithNoValidation.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZEICEligibilityRuleCheckWithNoValidation.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZEICEligibilityRuleCheckWithNoValidation.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZEICEligibilityRuleCheckWithNoValidation.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZEICEligibilityRuleCheckWithNoValidation.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZEICEligibilityRuleCheckWithNoValidation.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 28 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZEICEligibilityRuleCheckWithNoValidation.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\F1040EZEICEligibilityRuleCheckWithNoValidation.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class F1040EZEICEligibilityRuleCheckWithNoValidation : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext0 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly valDataContext1 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 refDataContext2 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 refDataContext3 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext3.GetLocation<double>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly valDataContext4 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 refDataContext5 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext5.GetLocation<bool>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 refDataContext6 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext7 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext8 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly valDataContext9 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4 refDataContext10 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext10.GetLocation<double>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly valDataContext11 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly valDataContext12 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4 refDataContext13 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext13.GetLocation<bool>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly valDataContext14 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4 refDataContext15 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext15.GetLocation<bool>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext16 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext17 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext18 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext19 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext20 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext20.GetLocation<bool>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext21 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext22 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext23 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext24 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext24.GetLocation<bool>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext25 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext26 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext27 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext28 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext28.GetLocation<bool>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext29 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext30 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext30.GetLocation<bool>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext31 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext32 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext32.GetLocation<bool>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext33 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext34 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext34.GetLocation<bool>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext35 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext35.GetLocation<bool>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext36 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext36.GetLocation<bool>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext37 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext38 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext38.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext39 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext39.GetLocation<double>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext40 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext40.GetLocation<double>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext41 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext42 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext42.GetLocation<double>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext43 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext43.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext44 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext45 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext46 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext46.GetLocation<double>(refDataContext46.ValueType___Expr46Get, refDataContext46.ValueType___Expr46Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext47 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext48 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext48.GetLocation<bool>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext49 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext50 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext51 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext52 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext53 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext54 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext55 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext56 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext57 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7 refDataContext58 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7)(cachedCompiledDataContext[10]));
                return refDataContext58.GetLocation<bool>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6 refDataContext59 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6)(cachedCompiledDataContext[11]));
                return refDataContext59.GetLocation<bool>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext60 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext61 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext62 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext63 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext64 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext65 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext66 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext67 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8 refDataContext68 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8)(cachedCompiledDataContext[13]));
                return refDataContext68.GetLocation<bool>(refDataContext68.ValueType___Expr68Get, refDataContext68.ValueType___Expr68Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6 refDataContext69 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6)(cachedCompiledDataContext[11]));
                return refDataContext69.GetLocation<bool>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext70 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext71 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext71.GetLocation<bool>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext72 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext73 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext74 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext74.GetLocation<System.Nullable<bool>>(refDataContext74.ValueType___Expr74Get, refDataContext74.ValueType___Expr74Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext75 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext76 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext76.GetLocation<JTL.Tax1040.BusinessObject.Credits>(refDataContext76.ValueType___Expr76Get, refDataContext76.ValueType___Expr76Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext77 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 14);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext78 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext78.GetLocation<System.Nullable<bool>>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set, expressionId, this.rootActivity, activityContext);
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
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext0 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly valDataContext1 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 refDataContext2 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locations, true);
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 refDataContext3 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locations, true);
                return refDataContext3.GetLocation<double>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly valDataContext4 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 refDataContext5 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locations, true);
                return refDataContext5.GetLocation<bool>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 refDataContext6 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locations, true);
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext7 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext8 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly valDataContext9 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4 refDataContext10 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext10.GetLocation<double>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly valDataContext11 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly valDataContext12 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4 refDataContext13 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext13.GetLocation<bool>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly valDataContext14 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4 refDataContext15 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext15.GetLocation<bool>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext16 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext17 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext18 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext19 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext20 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext20.GetLocation<bool>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext21 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext22 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext23 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext24 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext24.GetLocation<bool>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext25 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext26 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext27 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext28 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext28.GetLocation<bool>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext29 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext30 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext30.GetLocation<bool>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext31 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext32 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext32.GetLocation<bool>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext33 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext34 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext34.GetLocation<bool>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext35 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext35.GetLocation<bool>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext36 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext36.GetLocation<bool>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
            }
            if ((expressionId == 37)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext37 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext38 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext38.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
            }
            if ((expressionId == 39)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext39 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext39.GetLocation<double>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext40 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext40.GetLocation<double>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set);
            }
            if ((expressionId == 41)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext41 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext42 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext42.GetLocation<double>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext43 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext43.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext44 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
            }
            if ((expressionId == 45)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext45 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext46 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext46.GetLocation<double>(refDataContext46.ValueType___Expr46Get, refDataContext46.ValueType___Expr46Set);
            }
            if ((expressionId == 47)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext47 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext48 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext48.GetLocation<bool>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set);
            }
            if ((expressionId == 49)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext49 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext50 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext51 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext52 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext53 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext54 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext55 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext56 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext57 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7 refDataContext58 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7(locations, true);
                return refDataContext58.GetLocation<bool>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set);
            }
            if ((expressionId == 59)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6 refDataContext59 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6(locations, true);
                return refDataContext59.GetLocation<bool>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext60 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext61 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext62 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext63 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext64 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext65 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext66 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly valDataContext67 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8 refDataContext68 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8(locations, true);
                return refDataContext68.GetLocation<bool>(refDataContext68.ValueType___Expr68Get, refDataContext68.ValueType___Expr68Set);
            }
            if ((expressionId == 69)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6 refDataContext69 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6(locations, true);
                return refDataContext69.GetLocation<bool>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set);
            }
            if ((expressionId == 70)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext70 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext71 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext71.GetLocation<bool>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set);
            }
            if ((expressionId == 72)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext72 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext73 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext74 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext74.GetLocation<System.Nullable<bool>>(refDataContext74.ValueType___Expr74Get, refDataContext74.ValueType___Expr74Set);
            }
            if ((expressionId == 75)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext75 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext76 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext76.GetLocation<JTL.Tax1040.BusinessObject.Credits>(refDataContext76.ValueType___Expr76Get, refDataContext76.ValueType___Expr76Set);
            }
            if ((expressionId == 77)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext77 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext78 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext78.GetLocation<System.Nullable<bool>>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object !=null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income != null && Tax1040Object.Income.W2Wages != null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWages") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalWages==0") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(IsEICEligible && Tax1040Object.PersonalDetails != null)") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer != null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AnnualGrossIncome") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= SingleAdjustedGro" +
                            "ssIncome") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= MFJAdjustedGrossI" +
                            "ncome") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails !=null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person !=null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(IsEICEligible && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimed" +
                            "AsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.Has" +
                            "ClaimedAsDependent.Value)") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.Spouse !=null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.Spouse.Person !=null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(IsEICEligible && Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDepende" +
                            "nt.HasValue && Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent" +
                            ".Value)") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits !=null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits.EIC !=null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(IsEICEligible && Tax1040Object.Credits.EIC.IsInUSMorethanHalfYear.HasValue && Ta" +
                            "x1040Object.Credits.EIC.IsInUSMorethanHalfYear.Value)") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(IsEICEligible && Tax1040Object.Credits.EIC.HasValidSSN.HasValue && Tax1040Object" +
                            ".Credits.EIC.HasValidSSN.Value)") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits.EIC.HasClaimedAsQualifyingChild.HasValue && Tax1040Object.C" +
                            "redits.EIC.HasClaimedAsQualifyingChild.Value") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible.HasValue && Tax104" +
                            "0Object.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible.Value") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099INT != null) && " +
                            "(Tax1040Object.Income.Form1099INT.Count > 0))") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099INTTaxExemptInterest") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099INTTotal") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099OID != null) && " +
                            "(Tax1040Object.Income.Form1099OID.Count > 0))") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099OIDTaxExemptInterest") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099OIDTotal") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099INTTotal + F1099INTTaxExemptInterest + Form1099OIDTotal + F1099OIDTaxExem" +
                            "ptInterest") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "InvestmentIncome") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "InvestmentIncome > TaxableInterestLimit") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails !=null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer != null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(IsEICEligible && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null)") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.MinValue + TaxPayerTimeZone") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "PersonAge.Year - 1") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(IsEICEligible && (PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) " +
                            "&& Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth !=null)") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(IsEICEligible && ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null)" +
                            " && (Tax1040Object.PersonalDetails.Spouse != null) && (Tax1040Object.PersonalDet" +
                            "ails.Spouse.Person != null)))") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TodaysDate - Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.MinValue + SpouseTimeZone") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "SpouseAge.Year - 1") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.MinValue + TaxPayerTimeZone") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "PersonAge.Year - 1") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"(IsEICEligible && ((PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth != null) &&

((SpouseAgeCompleted >= MinAge && SpouseAgeCompleted <= MaxAge) && (Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth != null)))") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "HasEarnedIncomeCredit") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits != null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.Credits.HasEarnedIncomeCredits") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Credits()") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.Credits") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.Credits.HasEarnedIncomeCredits") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
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
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr78GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext1 : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool HasEarnedIncomeCredit;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.HasEarnedIncomeCredit = ((bool)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.HasEarnedIncomeCredit);
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
                if (((locationReferences[(offset + 1)].Name != "HasEarnedIncomeCredit") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext1_ForReadOnly : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool HasEarnedIncomeCredit;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.HasEarnedIncomeCredit = ((bool)(this.GetVariableValue((1 + locationsOffset))));
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
                if (((locationReferences[(offset + 1)].Name != "HasEarnedIncomeCredit") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double SingleAdjustedGrossIncome;
            
            protected double MFJAdjustedGrossIncome;
            
            protected bool IsEICEligible;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 247 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr20Get() {
                
                #line 247 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                    IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(bool value) {
                
                #line 247 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                    IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 284 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr24Get() {
                
                #line 284 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                    IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(bool value) {
                
                #line 284 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                    IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 328 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr28Get() {
                
                #line 328 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(bool value) {
                
                #line 328 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                  IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 349 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr30Get() {
                
                #line 349 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(bool value) {
                
                #line 349 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                  IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 370 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr32Get() {
                
                #line 370 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(bool value) {
                
                #line 370 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                  IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 391 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr34Get() {
                
                #line 391 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(bool value) {
                
                #line 391 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                  IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 407 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr35Get() {
                
                #line 407 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                          IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(bool value) {
                
                #line 407 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                          IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 421 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr36Get() {
                
                #line 421 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr36Set(bool value) {
                
                #line 421 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 712 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                HasEarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr71Get() {
                
                #line 712 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
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
                
                #line 712 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                HasEarnedIncomeCredit = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr71Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr71Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 731 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                    Tax1040Object.Credits.HasEarnedIncomeCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr74Get() {
                
                #line 731 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                    Tax1040Object.Credits.HasEarnedIncomeCredits;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr74Set(System.Nullable<bool> value) {
                
                #line 731 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                    Tax1040Object.Credits.HasEarnedIncomeCredits = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr74Set(System.Nullable<bool> value) {
                this.GetValueTypeValues();
                this.@__Expr74Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Credits>> expression = () => 
                      Tax1040Object.Credits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Credits @__Expr76Get() {
                
                #line 746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object.Credits;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Credits ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr76Set(JTL.Tax1040.BusinessObject.Credits value) {
                
                #line 746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                      Tax1040Object.Credits = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr76Set(JTL.Tax1040.BusinessObject.Credits value) {
                this.GetValueTypeValues();
                this.@__Expr76Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 758 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                      Tax1040Object.Credits.HasEarnedIncomeCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr78Get() {
                
                #line 758 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object.Credits.HasEarnedIncomeCredits;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr78Set(System.Nullable<bool> value) {
                
                #line 758 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                      Tax1040Object.Credits.HasEarnedIncomeCredits = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr78Set(System.Nullable<bool> value) {
                this.GetValueTypeValues();
                this.@__Expr78Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.SingleAdjustedGrossIncome = ((double)(this.GetVariableValue((2 + locationsOffset))));
                this.MFJAdjustedGrossIncome = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.IsEICEligible = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((2 + locationsOffset), this.SingleAdjustedGrossIncome);
                this.SetVariableValue((3 + locationsOffset), this.MFJAdjustedGrossIncome);
                this.SetVariableValue((4 + locationsOffset), this.IsEICEligible);
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
                if (((locationReferences[(offset + 2)].Name != "SingleAdjustedGrossIncome") 
                            || (locationReferences[(offset + 2)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "MFJAdjustedGrossIncome") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "IsEICEligible") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double SingleAdjustedGrossIncome;
            
            protected double MFJAdjustedGrossIncome;
            
            protected bool IsEICEligible;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 68 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          Tax1040Object !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr0Get() {
                
                #line 68 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
          Tax1040Object !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  (IsEICEligible && Tax1040Object.PersonalDetails != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr7Get() {
                
                #line 136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  (IsEICEligible && Tax1040Object.PersonalDetails != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 143 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 143 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 218 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.PersonalDetails !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr16Get() {
                
                #line 218 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  Tax1040Object.PersonalDetails !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 226 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr17Get() {
                
                #line 226 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 233 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr18Get() {
                
                #line 233 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                (IsEICEligible && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr19Get() {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                (IsEICEligible && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 263 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.PersonalDetails.Spouse !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr21Get() {
                
                #line 263 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.PersonalDetails.Spouse !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 270 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Tax1040Object.PersonalDetails.Spouse.Person !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 270 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.PersonalDetails.Spouse.Person !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 277 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                (IsEICEligible && Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr23Get() {
                
                #line 277 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                (IsEICEligible && Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 305 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.Credits !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr25Get() {
                
                #line 305 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  Tax1040Object.Credits !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 312 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.Credits.EIC !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr26Get() {
                
                #line 312 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object.Credits.EIC !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 321 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              (IsEICEligible && Tax1040Object.Credits.EIC.IsInUSMorethanHalfYear.HasValue && Tax1040Object.Credits.EIC.IsInUSMorethanHalfYear.Value);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr27Get() {
                
                #line 321 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                              (IsEICEligible && Tax1040Object.Credits.EIC.IsInUSMorethanHalfYear.HasValue && Tax1040Object.Credits.EIC.IsInUSMorethanHalfYear.Value);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 342 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              (IsEICEligible && Tax1040Object.Credits.EIC.HasValidSSN.HasValue && Tax1040Object.Credits.EIC.HasValidSSN.Value);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr29Get() {
                
                #line 342 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                              (IsEICEligible && Tax1040Object.Credits.EIC.HasValidSSN.HasValue && Tax1040Object.Credits.EIC.HasValidSSN.Value);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.Credits.EIC.HasClaimedAsQualifyingChild.HasValue && Tax1040Object.Credits.EIC.HasClaimedAsQualifyingChild.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr31Get() {
                
                #line 363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.Credits.EIC.HasClaimedAsQualifyingChild.HasValue && Tax1040Object.Credits.EIC.HasClaimedAsQualifyingChild.Value;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 384 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible.HasValue && Tax1040Object.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr33Get() {
                
                #line 384 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible.HasValue && Tax1040Object.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible.Value;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 717 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr70Get() {
                
                #line 717 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 724 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                Tax1040Object.Credits != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr72Get() {
                
                #line 724 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                Tax1040Object.Credits != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 736 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                    IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr73Get() {
                
                #line 736 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                    IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 751 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Credits>> expression = () => 
                      new Credits();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Credits @__Expr75Get() {
                
                #line 751 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      new Credits();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Credits ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 763 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr77Get() {
                
                #line 763 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            protected override void GetValueTypeValues() {
                this.SingleAdjustedGrossIncome = ((double)(this.GetVariableValue((2 + locationsOffset))));
                this.MFJAdjustedGrossIncome = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.IsEICEligible = ((bool)(this.GetVariableValue((4 + locationsOffset))));
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
                if (((locationReferences[(offset + 2)].Name != "SingleAdjustedGrossIncome") 
                            || (locationReferences[(offset + 2)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "MFJAdjustedGrossIncome") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "IsEICEligible") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWages;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 88 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr2Get() {
                
                #line 88 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
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
                
                #line 88 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
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
                
                #line 93 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr3Get() {
                
                #line 93 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                        TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(double value) {
                
                #line 93 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                        TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 107 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 107 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                            IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(bool value) {
                
                #line 107 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                            IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 122 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 122 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(bool value) {
                
                #line 122 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalWages = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.TotalWages);
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
                if (((locationReferences[(offset + 5)].Name != "TotalWages") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWages;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 80 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.Income != null && Tax1040Object.Income.W2Wages != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 80 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  Tax1040Object.Income != null && Tax1040Object.Income.W2Wages != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 100 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        TotalWages==0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 100 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                        TotalWages==0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalWages = ((double)(this.GetVariableValue((5 + locationsOffset))));
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
                if (((locationReferences[(offset + 5)].Name != "TotalWages") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4 : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double AnnualGrossIncome;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            AnnualGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr10Get() {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                            AnnualGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(double value) {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                            AnnualGrossIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 179 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 179 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(bool value) {
                
                #line 179 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                  IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 198 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr15Get() {
                
                #line 198 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(bool value) {
                
                #line 198 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                  IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.AnnualGrossIncome = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.AnnualGrossIncome);
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
                if (((locationReferences[(offset + 5)].Name != "AnnualGrossIncome") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double AnnualGrossIncome;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 159 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                            Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr9Get() {
                
                #line 159 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 166 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr11Get() {
                
                #line 166 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 172 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= SingleAdjustedGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 172 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= SingleAdjustedGrossIncome;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 191 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= MFJAdjustedGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr14Get() {
                
                #line 191 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= MFJAdjustedGrossIncome;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            protected override void GetValueTypeValues() {
                this.AnnualGrossIncome = ((double)(this.GetVariableValue((5 + locationsOffset))));
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
                if (((locationReferences[(offset + 5)].Name != "AnnualGrossIncome") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Form1099OIDTotal;
            
            protected double F1099OIDTaxExemptInterest;
            
            protected double Form1099INTTotal;
            
            protected double F1099INTTaxExemptInterest;
            
            protected double InvestmentIncome;
            
            protected double TaxableInterestLimit;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 451 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr38Get() {
                
                #line 451 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr38Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 451 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                        Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr38Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr38Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 461 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr39Get() {
                
                #line 461 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                        F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(double value) {
                
                #line 461 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                        F1099INTTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 456 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Form1099INTTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr40Get() {
                
                #line 456 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                        Form1099INTTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr40Set(double value) {
                
                #line 456 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                        Form1099INTTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr40Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr40Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 492 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr42Get() {
                
                #line 492 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                        F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(double value) {
                
                #line 492 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                        F1099OIDTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 482 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr43Get() {
                
                #line 482 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
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
                
                #line 482 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
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
                
                #line 487 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Form1099OIDTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr44Get() {
                
                #line 487 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                        Form1099OIDTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr44Set(double value) {
                
                #line 487 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                        Form1099OIDTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr44Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr44Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                  InvestmentIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr46Get() {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  InvestmentIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr46Set(double value) {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                  InvestmentIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr46Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr46Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 525 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr48Get() {
                
                #line 525 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr48Set(bool value) {
                
                #line 525 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr48Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr48Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.InvestmentIncome = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.TaxableInterestLimit = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.Form1099OIDTotal);
                this.SetVariableValue((6 + locationsOffset), this.F1099OIDTaxExemptInterest);
                this.SetVariableValue((7 + locationsOffset), this.Form1099INTTotal);
                this.SetVariableValue((8 + locationsOffset), this.F1099INTTaxExemptInterest);
                this.SetVariableValue((9 + locationsOffset), this.InvestmentIncome);
                this.SetVariableValue((10 + locationsOffset), this.TaxableInterestLimit);
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
                if (((locationReferences[(offset + 5)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "InvestmentIncome") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TaxableInterestLimit") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Form1099OIDTotal;
            
            protected double F1099OIDTaxExemptInterest;
            
            protected double Form1099INTTotal;
            
            protected double F1099INTTaxExemptInterest;
            
            protected double InvestmentIncome;
            
            protected double TaxableInterestLimit;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 443 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  ((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr37Get() {
                
                #line 443 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  ((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 474 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  ((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr41Get() {
                
                #line 474 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  ((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 510 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                  Form1099INTTotal + F1099INTTaxExemptInterest + Form1099OIDTotal + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr45Get() {
                
                #line 510 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  Form1099INTTotal + F1099INTTaxExemptInterest + Form1099OIDTotal + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 518 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  InvestmentIncome > TaxableInterestLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr47Get() {
                
                #line 518 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  InvestmentIncome > TaxableInterestLimit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.InvestmentIncome = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.TaxableInterestLimit = ((double)(this.GetVariableValue((10 + locationsOffset))));
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
                if (((locationReferences[(offset + 5)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "InvestmentIncome") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TaxableInterestLimit") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6 : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.DateTime TodaysDate;
            
            protected int MinAge;
            
            protected int MaxAge;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 618 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr59Get() {
                
                #line 618 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(bool value) {
                
                #line 618 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 694 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr69Get() {
                
                #line 694 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr69Set(bool value) {
                
                #line 694 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr69Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr69Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TodaysDate = ((System.DateTime)(this.GetVariableValue((5 + locationsOffset))));
                this.MinAge = ((int)(this.GetVariableValue((6 + locationsOffset))));
                this.MaxAge = ((int)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.TodaysDate);
                this.SetVariableValue((6 + locationsOffset), this.MinAge);
                this.SetVariableValue((7 + locationsOffset), this.MaxAge);
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
                if (((locationReferences[(offset + 5)].Name != "TodaysDate") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "MinAge") 
                            || (locationReferences[(offset + 6)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "MaxAge") 
                            || (locationReferences[(offset + 7)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.DateTime TodaysDate;
            
            protected int MinAge;
            
            protected int MaxAge;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 542 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                  DateTime.Now;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr49Get() {
                
                #line 542 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  DateTime.Now;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 551 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.PersonalDetails !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr50Get() {
                
                #line 551 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  Tax1040Object.PersonalDetails !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 558 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr51Get() {
                
                #line 558 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 565 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                          Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr52Get() {
                
                #line 565 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 571 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            (IsEICEligible && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr53Get() {
                
                #line 571 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                            (IsEICEligible && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 630 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            (IsEICEligible && ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.Spouse != null) && (Tax1040Object.PersonalDetails.Spouse.Person != null)));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr60Get() {
                
                #line 630 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                            (IsEICEligible && ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.Spouse != null) && (Tax1040Object.PersonalDetails.Spouse.Person != null)));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TodaysDate = ((System.DateTime)(this.GetVariableValue((5 + locationsOffset))));
                this.MinAge = ((int)(this.GetVariableValue((6 + locationsOffset))));
                this.MaxAge = ((int)(this.GetVariableValue((7 + locationsOffset))));
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
                if (((locationReferences[(offset + 5)].Name != "TodaysDate") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "MinAge") 
                            || (locationReferences[(offset + 6)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "MaxAge") 
                            || (locationReferences[(offset + 7)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7 : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.TimeSpan TaxPayerTimeZone;
            
            protected System.DateTime PersonAge;
            
            protected int PersonAgeCompleted;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 603 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr58Get() {
                
                #line 603 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr58Set(bool value) {
                
                #line 603 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr58Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr58Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.TaxPayerTimeZone = ((System.TimeSpan)(this.GetVariableValue((8 + locationsOffset))));
                this.PersonAge = ((System.DateTime)(this.GetVariableValue((9 + locationsOffset))));
                this.PersonAgeCompleted = ((int)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((8 + locationsOffset), this.TaxPayerTimeZone);
                this.SetVariableValue((9 + locationsOffset), this.PersonAge);
                this.SetVariableValue((10 + locationsOffset), this.PersonAgeCompleted);
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
                if (((locationReferences[(offset + 8)].Name != "TaxPayerTimeZone") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.TimeSpan)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "PersonAge") 
                            || (locationReferences[(offset + 9)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "PersonAgeCompleted") 
                            || (locationReferences[(offset + 10)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.TimeSpan TaxPayerTimeZone;
            
            protected System.DateTime PersonAge;
            
            protected int PersonAgeCompleted;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 579 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                  TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr54Get() {
                
                #line 579 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 584 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                  DateTime.MinValue + TaxPayerTimeZone;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr55Get() {
                
                #line 584 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  DateTime.MinValue + TaxPayerTimeZone;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  PersonAge.Year - 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr56Get() {
                
                #line 589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  PersonAge.Year - 1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 596 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  (IsEICEligible && (PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth !=null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr57Get() {
                
                #line 596 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  (IsEICEligible && (PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth !=null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TaxPayerTimeZone = ((System.TimeSpan)(this.GetVariableValue((8 + locationsOffset))));
                this.PersonAge = ((System.DateTime)(this.GetVariableValue((9 + locationsOffset))));
                this.PersonAgeCompleted = ((int)(this.GetVariableValue((10 + locationsOffset))));
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
                if (((locationReferences[(offset + 8)].Name != "TaxPayerTimeZone") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.TimeSpan)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "PersonAge") 
                            || (locationReferences[(offset + 9)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "PersonAgeCompleted") 
                            || (locationReferences[(offset + 10)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8 : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.TimeSpan SpouseTimeZone;
            
            protected System.DateTime SpouseAge;
            
            protected int SpouseAgeCompleted;
            
            protected System.TimeSpan TaxPayerTimeZone;
            
            protected System.DateTime PersonAge;
            
            protected int PersonAgeCompleted;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 679 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr68Get() {
                
                #line 679 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr68Set(bool value) {
                
                #line 679 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr68Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr68Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.SpouseTimeZone = ((System.TimeSpan)(this.GetVariableValue((8 + locationsOffset))));
                this.SpouseAge = ((System.DateTime)(this.GetVariableValue((9 + locationsOffset))));
                this.SpouseAgeCompleted = ((int)(this.GetVariableValue((10 + locationsOffset))));
                this.TaxPayerTimeZone = ((System.TimeSpan)(this.GetVariableValue((11 + locationsOffset))));
                this.PersonAge = ((System.DateTime)(this.GetVariableValue((12 + locationsOffset))));
                this.PersonAgeCompleted = ((int)(this.GetVariableValue((13 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((8 + locationsOffset), this.SpouseTimeZone);
                this.SetVariableValue((9 + locationsOffset), this.SpouseAge);
                this.SetVariableValue((10 + locationsOffset), this.SpouseAgeCompleted);
                this.SetVariableValue((11 + locationsOffset), this.TaxPayerTimeZone);
                this.SetVariableValue((12 + locationsOffset), this.PersonAge);
                this.SetVariableValue((13 + locationsOffset), this.PersonAgeCompleted);
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
                if (((locationReferences[(offset + 8)].Name != "SpouseTimeZone") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.TimeSpan)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "SpouseAge") 
                            || (locationReferences[(offset + 9)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "SpouseAgeCompleted") 
                            || (locationReferences[(offset + 10)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "TaxPayerTimeZone") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.TimeSpan)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "PersonAge") 
                            || (locationReferences[(offset + 12)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "PersonAgeCompleted") 
                            || (locationReferences[(offset + 13)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.TimeSpan SpouseTimeZone;
            
            protected System.DateTime SpouseAge;
            
            protected int SpouseAgeCompleted;
            
            protected System.TimeSpan TaxPayerTimeZone;
            
            protected System.DateTime PersonAge;
            
            protected int PersonAgeCompleted;
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 638 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                  TodaysDate - Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr61Get() {
                
                #line 638 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  TodaysDate - Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth;
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 643 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                  DateTime.MinValue + SpouseTimeZone;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr62Get() {
                
                #line 643 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  DateTime.MinValue + SpouseTimeZone;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 648 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  SpouseAge.Year - 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr63Get() {
                
                #line 648 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  SpouseAge.Year - 1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 653 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                  TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr64Get() {
                
                #line 653 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 658 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                  DateTime.MinValue + TaxPayerTimeZone;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr65Get() {
                
                #line 658 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  DateTime.MinValue + TaxPayerTimeZone;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 663 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  PersonAge.Year - 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr66Get() {
                
                #line 663 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  PersonAge.Year - 1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 670 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  (IsEICEligible && ((PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth != null) &&

((SpouseAgeCompleted >= MinAge && SpouseAgeCompleted <= MaxAge) && (Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth != null)));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr67Get() {
                
                #line 670 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  (IsEICEligible && ((PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth != null) &&

((SpouseAgeCompleted >= MinAge && SpouseAgeCompleted <= MaxAge) && (Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth != null)));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            protected override void GetValueTypeValues() {
                this.SpouseTimeZone = ((System.TimeSpan)(this.GetVariableValue((8 + locationsOffset))));
                this.SpouseAge = ((System.DateTime)(this.GetVariableValue((9 + locationsOffset))));
                this.SpouseAgeCompleted = ((int)(this.GetVariableValue((10 + locationsOffset))));
                this.TaxPayerTimeZone = ((System.TimeSpan)(this.GetVariableValue((11 + locationsOffset))));
                this.PersonAge = ((System.DateTime)(this.GetVariableValue((12 + locationsOffset))));
                this.PersonAgeCompleted = ((int)(this.GetVariableValue((13 + locationsOffset))));
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
                if (((locationReferences[(offset + 8)].Name != "SpouseTimeZone") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.TimeSpan)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "SpouseAge") 
                            || (locationReferences[(offset + 9)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "SpouseAgeCompleted") 
                            || (locationReferences[(offset + 10)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "TaxPayerTimeZone") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.TimeSpan)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "PersonAge") 
                            || (locationReferences[(offset + 12)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "PersonAgeCompleted") 
                            || (locationReferences[(offset + 13)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
