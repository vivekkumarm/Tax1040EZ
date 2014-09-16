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
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext0 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly valDataContext1 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 refDataContext2 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 refDataContext3 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext3.GetLocation<double>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly valDataContext4 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 refDataContext5 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext5.GetLocation<bool>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3 refDataContext6 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext7 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext8 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly valDataContext9 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4 refDataContext10 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext10.GetLocation<double>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly valDataContext11 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly valDataContext12 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4 refDataContext13 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext13.GetLocation<bool>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly valDataContext14 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4 refDataContext15 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext15.GetLocation<bool>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext16 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext17 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext18 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext19 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext20 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext20.GetLocation<bool>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext21 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext22 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext23 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext24 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext24.GetLocation<bool>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext25 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext26 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext27 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext28 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext28.GetLocation<bool>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext29 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext30 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext30.GetLocation<bool>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext31 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext32 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext32.GetLocation<bool>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext33 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext34 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext34.GetLocation<bool>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext35 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext35.GetLocation<bool>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext36 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext36.GetLocation<bool>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext37 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext38 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext39 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext40 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext41 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext42 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext43 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext44 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext45 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6 refDataContext46 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6)(cachedCompiledDataContext[8]));
                return refDataContext46.GetLocation<bool>(refDataContext46.ValueType___Expr46Get, refDataContext46.ValueType___Expr46Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext47 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[9]));
                return refDataContext47.GetLocation<bool>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext48 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext49 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext50 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext51 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext52 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext53 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext54 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext55 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7 refDataContext56 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext56.GetLocation<bool>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext57 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[9]));
                return refDataContext57.GetLocation<bool>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext58 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext59 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext59.GetLocation<bool>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext60 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext61 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext62 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext62.GetLocation<System.Nullable<bool>>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext63 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext64 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext64.GetLocation<JTL.Tax1040.BusinessObject.Credits>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext65 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext66 = ((F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[5]));
                return refDataContext66.GetLocation<System.Nullable<bool>>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set, expressionId, this.rootActivity, activityContext);
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
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext38 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext39 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext40 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext41 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext42 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext43 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext44 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly valDataContext45 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6 refDataContext46 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6(locations, true);
                return refDataContext46.GetLocation<bool>(refDataContext46.ValueType___Expr46Get, refDataContext46.ValueType___Expr46Set);
            }
            if ((expressionId == 47)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext47 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext47.GetLocation<bool>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
            }
            if ((expressionId == 48)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly valDataContext48 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext49 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext50 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext51 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext52 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly valDataContext53 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locations, true);
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
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7 refDataContext56 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7(locations, true);
                return refDataContext56.GetLocation<bool>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set);
            }
            if ((expressionId == 57)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 refDataContext57 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext57.GetLocation<bool>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set);
            }
            if ((expressionId == 58)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext58 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext59 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext59.GetLocation<bool>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext60 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext61 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext62 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext62.GetLocation<System.Nullable<bool>>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set);
            }
            if ((expressionId == 63)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext63 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext64 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext64.GetLocation<JTL.Tax1040.BusinessObject.Credits>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set);
            }
            if ((expressionId == 65)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly valDataContext65 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2 refDataContext66 = new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext66.GetLocation<System.Nullable<bool>>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set);
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
                        && ((expressionText == "DateTime.Now") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails !=null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer != null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(IsEICEligible && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null)") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.MinValue + TaxPayerTimeZone") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "PersonAge.Year - 1") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(IsEICEligible && (PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) " +
                            "&& Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth !=null)") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(IsEICEligible && ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null)" +
                            " && (Tax1040Object.PersonalDetails.Spouse != null) && (Tax1040Object.PersonalDet" +
                            "ails.Spouse.Person != null)))") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TodaysDate - Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.MinValue + SpouseTimeZone") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "SpouseAge.Year - 1") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.MinValue + TaxPayerTimeZone") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "PersonAge.Year - 1") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"(IsEICEligible && ((PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth != null) &&

((SpouseAgeCompleted >= MinAge && SpouseAgeCompleted <= MaxAge) && (Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth != null)))") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "HasEarnedIncomeCredit") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits != null") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.Credits.HasEarnedIncomeCredits") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Credits()") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.Credits") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.Credits.HasEarnedIncomeCredits") 
                        && (F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
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
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2(locationReferences).@__Expr66GetTree();
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
                
                #line 422 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr36Get() {
                
                #line 422 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
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
                
                #line 422 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 607 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                HasEarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr59Get() {
                
                #line 607 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                HasEarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(bool value) {
                
                #line 607 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                HasEarnedIncomeCredit = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 626 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                    Tax1040Object.Credits.HasEarnedIncomeCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr62Get() {
                
                #line 626 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                    Tax1040Object.Credits.HasEarnedIncomeCredits;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr62Set(System.Nullable<bool> value) {
                
                #line 626 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                    Tax1040Object.Credits.HasEarnedIncomeCredits = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr62Set(System.Nullable<bool> value) {
                this.GetValueTypeValues();
                this.@__Expr62Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 641 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Credits>> expression = () => 
                      Tax1040Object.Credits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Credits @__Expr64Get() {
                
                #line 641 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object.Credits;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Credits ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr64Set(JTL.Tax1040.BusinessObject.Credits value) {
                
                #line 641 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                      Tax1040Object.Credits = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr64Set(JTL.Tax1040.BusinessObject.Credits value) {
                this.GetValueTypeValues();
                this.@__Expr64Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 653 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                      Tax1040Object.Credits.HasEarnedIncomeCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr66Get() {
                
                #line 653 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object.Credits.HasEarnedIncomeCredits;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr66Set(System.Nullable<bool> value) {
                
                #line 653 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                      Tax1040Object.Credits.HasEarnedIncomeCredits = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr66Set(System.Nullable<bool> value) {
                this.GetValueTypeValues();
                this.@__Expr66Set(value);
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
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 612 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr58Get() {
                
                #line 612 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 619 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                Tax1040Object.Credits != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr60Get() {
                
                #line 619 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                Tax1040Object.Credits != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 631 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                    IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr61Get() {
                
                #line 631 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                    IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 646 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Credits>> expression = () => 
                      new Credits();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Credits @__Expr63Get() {
                
                #line 646 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      new Credits();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Credits ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 658 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr65Get() {
                
                #line 658 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
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
            
            protected System.DateTime TodaysDate;
            
            protected int MinAge;
            
            protected int MaxAge;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 513 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr47Get() {
                
                #line 513 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr47Set(bool value) {
                
                #line 513 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr47Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr47Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr57Get() {
                
                #line 589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr57Set(bool value) {
                
                #line 589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr57Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr57Set(value);
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
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.DateTime TodaysDate;
            
            protected int MinAge;
            
            protected int MaxAge;
            
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
                
                #line 437 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                  DateTime.Now;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr37Get() {
                
                #line 437 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  DateTime.Now;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 446 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.PersonalDetails !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr38Get() {
                
                #line 446 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                  Tax1040Object.PersonalDetails !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 453 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr39Get() {
                
                #line 453 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 460 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                          Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr40Get() {
                
                #line 460 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 466 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            (IsEICEligible && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr41Get() {
                
                #line 466 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                            (IsEICEligible && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 525 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            (IsEICEligible && ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.Spouse != null) && (Tax1040Object.PersonalDetails.Spouse.Person != null)));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr48Get() {
                
                #line 525 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                            (IsEICEligible && ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.Spouse != null) && (Tax1040Object.PersonalDetails.Spouse.Person != null)));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
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
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6 : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.TimeSpan TaxPayerTimeZone;
            
            protected System.DateTime PersonAge;
            
            protected int PersonAgeCompleted;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 498 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr46Get() {
                
                #line 498 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr46Set(bool value) {
                
                #line 498 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr46Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr46Set(value);
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
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext6_ForReadOnly : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.TimeSpan TaxPayerTimeZone;
            
            protected System.DateTime PersonAge;
            
            protected int PersonAgeCompleted;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 474 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                  TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr42Get() {
                
                #line 474 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 479 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                  DateTime.MinValue + TaxPayerTimeZone;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr43Get() {
                
                #line 479 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  DateTime.MinValue + TaxPayerTimeZone;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 484 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  PersonAge.Year - 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr44Get() {
                
                #line 484 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  PersonAge.Year - 1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 491 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  (IsEICEligible && (PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth !=null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr45Get() {
                
                #line 491 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  (IsEICEligible && (PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth !=null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
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
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7 : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.TimeSpan SpouseTimeZone;
            
            protected System.DateTime SpouseAge;
            
            protected int SpouseAgeCompleted;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 574 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr56Get() {
                
                #line 574 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr56Set(bool value) {
                
                #line 574 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                
                                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr56Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr56Set(value);
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
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext7_ForReadOnly : F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.TimeSpan SpouseTimeZone;
            
            protected System.DateTime SpouseAge;
            
            protected int SpouseAgeCompleted;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 533 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                  TodaysDate - Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr49Get() {
                
                #line 533 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  TodaysDate - Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth;
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 538 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                  DateTime.MinValue + SpouseTimeZone;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr50Get() {
                
                #line 538 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  DateTime.MinValue + SpouseTimeZone;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 543 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  SpouseAge.Year - 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr51Get() {
                
                #line 543 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  SpouseAge.Year - 1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 548 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                  TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr52Get() {
                
                #line 548 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 553 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                  DateTime.MinValue + TaxPayerTimeZone;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr53Get() {
                
                #line 553 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  DateTime.MinValue + TaxPayerTimeZone;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 558 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  PersonAge.Year - 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr54Get() {
                
                #line 558 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  PersonAge.Year - 1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 565 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  (IsEICEligible && ((PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth != null) &&

((SpouseAgeCompleted >= MinAge && SpouseAgeCompleted <= MaxAge) && (Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth != null)));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr55Get() {
                
                #line 565 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\F1040EZEICELIGIBILITYRULECHECKWITHNOVALIDATION.XAML"
                return 
                                  (IsEICEligible && ((PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth != null) &&

((SpouseAgeCompleted >= MinAge && SpouseAgeCompleted <= MaxAge) && (Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth != null)));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
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
                return F1040EZEICEligibilityRuleCheckWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
