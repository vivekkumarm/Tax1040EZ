namespace Tax1040WorkFlow.WorkFlow.Activities {
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 28 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 29 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 30 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using JTL.Tax1040.Core.Object;
    
    #line default
    #line hidden
    
    #line 31 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using JTL.Tax1040.Core.Process;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZEICEligibilityRuleCheck.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class F1040EZEICEligibilityRuleCheck : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext0 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext1 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext2 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext3 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext4 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext5 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext6 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext7 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext8 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext9 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext10 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext11 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext11.GetLocation<double>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext12 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext13 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext14 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext15 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext15.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext16 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext17 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext18 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext18.GetLocation<bool>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext19 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext20 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext21 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext21.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext22 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext23 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext24 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext24.GetLocation<bool>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext25 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext26 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext27 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext27.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext28 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext29 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext30 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext30.GetLocation<bool>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext31 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext32 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext33 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext33.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext34 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext35 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext36 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext36.GetLocation<bool>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext37 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext38 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext39 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext39.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext40 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext41 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext42 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext42.GetLocation<bool>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext43 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext44 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext45 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext45.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext46 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext47 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext48 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext48.GetLocation<bool>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext49 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext50 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext50.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext51 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext51.GetLocation<double>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext52 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext52.GetLocation<double>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext53 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext54 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext54.GetLocation<double>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext55 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext55.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext56 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext56.GetLocation<double>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext57 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext58 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext58.GetLocation<double>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext59 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext60 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext61 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext61.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext62 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext63 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext64 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext64.GetLocation<bool>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext65 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5 refDataContext66 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext66.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5 refDataContext67 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext67.GetLocation<double>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext68 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext69 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5 refDataContext70 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext70.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext71 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext72 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5 refDataContext73 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext73.GetLocation<bool>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext74 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5 refDataContext75 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext75.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext76 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext77 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext5 refDataContext78 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext78.GetLocation<bool>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext79 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext79.ValueType___Expr79Get();
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext80 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext80.GetLocation<double>(refDataContext80.ValueType___Expr80Get, refDataContext80.ValueType___Expr80Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext81 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext82 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext83 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext84 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext84.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext85 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext86 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext87 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext87.GetLocation<bool>(refDataContext87.ValueType___Expr87Get, refDataContext87.ValueType___Expr87Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext88 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext89 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext90 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext90.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext91 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext92 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext92.ValueType___Expr92Get();
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext93 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext93.GetLocation<bool>(refDataContext93.ValueType___Expr93Get, refDataContext93.ValueType___Expr93Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext94 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext95 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext96 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext96.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext97 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext98 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext99 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext99.GetLocation<bool>(refDataContext99.ValueType___Expr99Get, refDataContext99.ValueType___Expr99Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext100 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext100.ValueType___Expr100Get();
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext101 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext102 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext102.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext103 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext104 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext105 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext105.GetLocation<bool>(refDataContext105.ValueType___Expr105Get, refDataContext105.ValueType___Expr105Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext106 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext107 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext108 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext108.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext108.ValueType___Expr108Get, refDataContext108.ValueType___Expr108Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext109 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext109.ValueType___Expr109Get();
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext110 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext111 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext111.GetLocation<bool>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext112 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext113 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext114 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext114.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext115 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext116 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext116.ValueType___Expr116Get();
            }
            if ((expressionId == 117)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext117 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext117.GetLocation<bool>(refDataContext117.ValueType___Expr117Get, refDataContext117.ValueType___Expr117Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 118)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext118 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext119 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6)(cachedCompiledDataContext[9]));
                return refDataContext119.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext119.ValueType___Expr119Get, refDataContext119.ValueType___Expr119Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 120)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext120 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6)(cachedCompiledDataContext[9]));
                return refDataContext120.GetLocation<double>(refDataContext120.ValueType___Expr120Get, refDataContext120.ValueType___Expr120Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 121)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext121 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6)(cachedCompiledDataContext[9]));
                return refDataContext121.GetLocation<double>(refDataContext121.ValueType___Expr121Get, refDataContext121.ValueType___Expr121Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 122)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext122 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext122.ValueType___Expr122Get();
            }
            if ((expressionId == 123)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext123 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6)(cachedCompiledDataContext[9]));
                return refDataContext123.GetLocation<double>(refDataContext123.ValueType___Expr123Get, refDataContext123.ValueType___Expr123Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 124)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext124 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6)(cachedCompiledDataContext[9]));
                return refDataContext124.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 125)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext125 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6)(cachedCompiledDataContext[9]));
                return refDataContext125.GetLocation<double>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 126)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext126 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext127 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6)(cachedCompiledDataContext[9]));
                return refDataContext127.GetLocation<double>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 128)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext128 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext129 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext129.ValueType___Expr129Get();
            }
            if ((expressionId == 130)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext130 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6)(cachedCompiledDataContext[9]));
                return refDataContext130.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext130.ValueType___Expr130Get, refDataContext130.ValueType___Expr130Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 131)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext131 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext132 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext132.ValueType___Expr132Get();
            }
            if ((expressionId == 133)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext133 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext6)(cachedCompiledDataContext[9]));
                return refDataContext133.GetLocation<bool>(refDataContext133.ValueType___Expr133Get, refDataContext133.ValueType___Expr133Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 134)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext134 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7 refDataContext135 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext135.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext135.ValueType___Expr135Get, refDataContext135.ValueType___Expr135Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 136)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7 refDataContext136 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext136.GetLocation<double>(refDataContext136.ValueType___Expr136Get, refDataContext136.ValueType___Expr136Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 137)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext137 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext138 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7 refDataContext139 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext139.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext139.ValueType___Expr139Get, refDataContext139.ValueType___Expr139Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 140)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext140 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext141 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7 refDataContext142 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext142.GetLocation<bool>(refDataContext142.ValueType___Expr142Get, refDataContext142.ValueType___Expr142Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 143)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext143 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext143.ValueType___Expr143Get();
            }
            if ((expressionId == 144)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7 refDataContext144 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext144.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext144.ValueType___Expr144Get, refDataContext144.ValueType___Expr144Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 145)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext145 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext145.ValueType___Expr145Get();
            }
            if ((expressionId == 146)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext146 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext146.ValueType___Expr146Get();
            }
            if ((expressionId == 147)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext7 refDataContext147 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext7)(cachedCompiledDataContext[11]));
                return refDataContext147.GetLocation<bool>(refDataContext147.ValueType___Expr147Get, refDataContext147.ValueType___Expr147Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 148)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext148 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext148.ValueType___Expr148Get();
            }
            if ((expressionId == 149)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext149 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext149.ValueType___Expr149Get();
            }
            if ((expressionId == 150)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext150 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext150.GetLocation<JTL.Tax1040.BusinessObject.EIC>(refDataContext150.ValueType___Expr150Get, refDataContext150.ValueType___Expr150Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 151)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext151 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext151.ValueType___Expr151Get();
            }
            if ((expressionId == 152)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext152 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext152.ValueType___Expr152Get();
            }
            if ((expressionId == 153)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext153 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext153.ValueType___Expr153Get();
            }
            if ((expressionId == 154)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext154 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext154.ValueType___Expr154Get();
            }
            if ((expressionId == 155)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext155 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext155.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext155.ValueType___Expr155Get, refDataContext155.ValueType___Expr155Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 156)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext156 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext156.ValueType___Expr156Get();
            }
            if ((expressionId == 157)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext157 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext157.ValueType___Expr157Get();
            }
            if ((expressionId == 158)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext158 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext158.GetLocation<bool>(refDataContext158.ValueType___Expr158Get, refDataContext158.ValueType___Expr158Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 159)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext159 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext159.ValueType___Expr159Get();
            }
            if ((expressionId == 160)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext160 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext160.ValueType___Expr160Get();
            }
            if ((expressionId == 161)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext161 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext161.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext161.ValueType___Expr161Get, refDataContext161.ValueType___Expr161Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 162)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext162 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext162.ValueType___Expr162Get();
            }
            if ((expressionId == 163)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext163 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext163.ValueType___Expr163Get();
            }
            if ((expressionId == 164)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext164 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext164.GetLocation<bool>(refDataContext164.ValueType___Expr164Get, refDataContext164.ValueType___Expr164Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 165)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext165 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext165.ValueType___Expr165Get();
            }
            if ((expressionId == 166)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext166 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext166.ValueType___Expr166Get();
            }
            if ((expressionId == 167)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext167 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext167.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext167.ValueType___Expr167Get, refDataContext167.ValueType___Expr167Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 168)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext168 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext168.ValueType___Expr168Get();
            }
            if ((expressionId == 169)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext169 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext169.ValueType___Expr169Get();
            }
            if ((expressionId == 170)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext170 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext170.GetLocation<bool>(refDataContext170.ValueType___Expr170Get, refDataContext170.ValueType___Expr170Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 171)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext171 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext171.ValueType___Expr171Get();
            }
            if ((expressionId == 172)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext172 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext172.ValueType___Expr172Get();
            }
            if ((expressionId == 173)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext173 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext173.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext173.ValueType___Expr173Get, refDataContext173.ValueType___Expr173Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 174)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext174 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext174.ValueType___Expr174Get();
            }
            if ((expressionId == 175)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext175 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext175.ValueType___Expr175Get();
            }
            if ((expressionId == 176)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext176 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext176.GetLocation<bool>(refDataContext176.ValueType___Expr176Get, refDataContext176.ValueType___Expr176Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 177)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext177 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext177.GetLocation<bool>(refDataContext177.ValueType___Expr177Get, refDataContext177.ValueType___Expr177Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 178)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext178 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext178.GetLocation<bool>(refDataContext178.ValueType___Expr178Get, refDataContext178.ValueType___Expr178Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 179)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext179 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext179.ValueType___Expr179Get();
            }
            if ((expressionId == 180)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext180 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext180.GetLocation<bool>(refDataContext180.ValueType___Expr180Get, refDataContext180.ValueType___Expr180Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 181)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext181 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext181.ValueType___Expr181Get();
            }
            if ((expressionId == 182)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext182 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext182.ValueType___Expr182Get();
            }
            if ((expressionId == 183)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext183 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext183.GetLocation<System.Nullable<bool>>(refDataContext183.ValueType___Expr183Get, refDataContext183.ValueType___Expr183Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 184)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext184 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext184.ValueType___Expr184Get();
            }
            if ((expressionId == 185)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext185 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext185.GetLocation<JTL.Tax1040.BusinessObject.Credits>(refDataContext185.ValueType___Expr185Get, refDataContext185.ValueType___Expr185Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 186)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext186 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext186.ValueType___Expr186Get();
            }
            if ((expressionId == 187)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext187 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext187.GetLocation<System.Nullable<bool>>(refDataContext187.ValueType___Expr187Get, refDataContext187.ValueType___Expr187Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 188)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext188 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext188.ValueType___Expr188Get();
            }
            if ((expressionId == 189)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZEICEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext189 = ((F1040EZEICEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext189.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext189.ValueType___Expr189Get, refDataContext189.ValueType___Expr189Set, expressionId, this.rootActivity, activityContext);
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
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext0 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext1 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext2 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext3 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext4 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext5 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext6 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext7 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext8 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext9 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext10 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext11 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext11.GetLocation<double>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext12 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext13 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext14 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext15 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext15.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext16 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext17 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext18 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext18.GetLocation<bool>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext19 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext20 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext21 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext21.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext22 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext23 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext24 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext24.GetLocation<bool>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext25 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext26 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext27 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext27.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext28 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext29 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext30 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext30.GetLocation<bool>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext31 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext32 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext33 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext33.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext34 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext35 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext36 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext36.GetLocation<bool>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
            }
            if ((expressionId == 37)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext37 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext38 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext39 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext39.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext40 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext41 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext42 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext42.GetLocation<bool>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext43 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext44 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext45 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext45.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext46 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext47 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext48 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext48.GetLocation<bool>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set);
            }
            if ((expressionId == 49)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext49 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext50 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, true);
                return refDataContext50.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set);
            }
            if ((expressionId == 51)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext51 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, true);
                return refDataContext51.GetLocation<double>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext52 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, true);
                return refDataContext52.GetLocation<double>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set);
            }
            if ((expressionId == 53)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext53 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext54 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, true);
                return refDataContext54.GetLocation<double>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set);
            }
            if ((expressionId == 55)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext55 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, true);
                return refDataContext55.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set);
            }
            if ((expressionId == 56)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext56 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, true);
                return refDataContext56.GetLocation<double>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set);
            }
            if ((expressionId == 57)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext57 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext58 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, true);
                return refDataContext58.GetLocation<double>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set);
            }
            if ((expressionId == 59)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext59 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext60 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext61 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, true);
                return refDataContext61.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext62 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext63 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext4 refDataContext64 = new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locations, true);
                return refDataContext64.GetLocation<bool>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set);
            }
            if ((expressionId == 65)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext65 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5 refDataContext66 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locations, true);
                return refDataContext66.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set);
            }
            if ((expressionId == 67)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5 refDataContext67 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locations, true);
                return refDataContext67.GetLocation<double>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set);
            }
            if ((expressionId == 68)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext68 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext69 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5 refDataContext70 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locations, true);
                return refDataContext70.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set);
            }
            if ((expressionId == 71)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext71 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext72 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5 refDataContext73 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locations, true);
                return refDataContext73.GetLocation<bool>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set);
            }
            if ((expressionId == 74)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext74 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5 refDataContext75 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locations, true);
                return refDataContext75.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set);
            }
            if ((expressionId == 76)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext76 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly valDataContext77 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext5 refDataContext78 = new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locations, true);
                return refDataContext78.GetLocation<bool>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set);
            }
            if ((expressionId == 79)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext79 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext79.ValueType___Expr79Get();
            }
            if ((expressionId == 80)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext80 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext80.GetLocation<double>(refDataContext80.ValueType___Expr80Get, refDataContext80.ValueType___Expr80Set);
            }
            if ((expressionId == 81)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext81 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext82 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext83 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext84 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext84.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set);
            }
            if ((expressionId == 85)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext85 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext86 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext87 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext87.GetLocation<bool>(refDataContext87.ValueType___Expr87Get, refDataContext87.ValueType___Expr87Set);
            }
            if ((expressionId == 88)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext88 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext89 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext90 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext90.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set);
            }
            if ((expressionId == 91)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext91 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext92 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext92.ValueType___Expr92Get();
            }
            if ((expressionId == 93)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext93 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext93.GetLocation<bool>(refDataContext93.ValueType___Expr93Get, refDataContext93.ValueType___Expr93Set);
            }
            if ((expressionId == 94)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext94 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext95 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext96 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext96.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set);
            }
            if ((expressionId == 97)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext97 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext98 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext99 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext99.GetLocation<bool>(refDataContext99.ValueType___Expr99Get, refDataContext99.ValueType___Expr99Set);
            }
            if ((expressionId == 100)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext100 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext100.ValueType___Expr100Get();
            }
            if ((expressionId == 101)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext101 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext102 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext102.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set);
            }
            if ((expressionId == 103)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext103 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext104 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext105 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext105.GetLocation<bool>(refDataContext105.ValueType___Expr105Get, refDataContext105.ValueType___Expr105Set);
            }
            if ((expressionId == 106)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext106 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext107 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext108 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext108.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext108.ValueType___Expr108Get, refDataContext108.ValueType___Expr108Set);
            }
            if ((expressionId == 109)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext109 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext109.ValueType___Expr109Get();
            }
            if ((expressionId == 110)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext110 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext111 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext111.GetLocation<bool>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set);
            }
            if ((expressionId == 112)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext112 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext113 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext114 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext114.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set);
            }
            if ((expressionId == 115)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext115 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext116 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext116.ValueType___Expr116Get();
            }
            if ((expressionId == 117)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext3 refDataContext117 = new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locations, true);
                return refDataContext117.GetLocation<bool>(refDataContext117.ValueType___Expr117Get, refDataContext117.ValueType___Expr117Set);
            }
            if ((expressionId == 118)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext118 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext119 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, true);
                return refDataContext119.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext119.ValueType___Expr119Get, refDataContext119.ValueType___Expr119Set);
            }
            if ((expressionId == 120)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext120 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, true);
                return refDataContext120.GetLocation<double>(refDataContext120.ValueType___Expr120Get, refDataContext120.ValueType___Expr120Set);
            }
            if ((expressionId == 121)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext121 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, true);
                return refDataContext121.GetLocation<double>(refDataContext121.ValueType___Expr121Get, refDataContext121.ValueType___Expr121Set);
            }
            if ((expressionId == 122)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext122 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext122.ValueType___Expr122Get();
            }
            if ((expressionId == 123)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext123 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, true);
                return refDataContext123.GetLocation<double>(refDataContext123.ValueType___Expr123Get, refDataContext123.ValueType___Expr123Set);
            }
            if ((expressionId == 124)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext124 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, true);
                return refDataContext124.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set);
            }
            if ((expressionId == 125)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext125 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, true);
                return refDataContext125.GetLocation<double>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set);
            }
            if ((expressionId == 126)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext126 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext127 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, true);
                return refDataContext127.GetLocation<double>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set);
            }
            if ((expressionId == 128)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext128 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext129 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext129.ValueType___Expr129Get();
            }
            if ((expressionId == 130)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext130 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, true);
                return refDataContext130.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext130.ValueType___Expr130Get, refDataContext130.ValueType___Expr130Set);
            }
            if ((expressionId == 131)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext131 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly valDataContext132 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext132.ValueType___Expr132Get();
            }
            if ((expressionId == 133)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext6 refDataContext133 = new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locations, true);
                return refDataContext133.GetLocation<bool>(refDataContext133.ValueType___Expr133Get, refDataContext133.ValueType___Expr133Set);
            }
            if ((expressionId == 134)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext134 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7 refDataContext135 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locations, true);
                return refDataContext135.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext135.ValueType___Expr135Get, refDataContext135.ValueType___Expr135Set);
            }
            if ((expressionId == 136)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7 refDataContext136 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locations, true);
                return refDataContext136.GetLocation<double>(refDataContext136.ValueType___Expr136Get, refDataContext136.ValueType___Expr136Set);
            }
            if ((expressionId == 137)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext137 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext138 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7 refDataContext139 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locations, true);
                return refDataContext139.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext139.ValueType___Expr139Get, refDataContext139.ValueType___Expr139Set);
            }
            if ((expressionId == 140)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext140 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext141 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7 refDataContext142 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locations, true);
                return refDataContext142.GetLocation<bool>(refDataContext142.ValueType___Expr142Get, refDataContext142.ValueType___Expr142Set);
            }
            if ((expressionId == 143)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext143 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext143.ValueType___Expr143Get();
            }
            if ((expressionId == 144)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7 refDataContext144 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locations, true);
                return refDataContext144.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext144.ValueType___Expr144Get, refDataContext144.ValueType___Expr144Set);
            }
            if ((expressionId == 145)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext145 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext145.ValueType___Expr145Get();
            }
            if ((expressionId == 146)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly valDataContext146 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext146.ValueType___Expr146Get();
            }
            if ((expressionId == 147)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext7 refDataContext147 = new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locations, true);
                return refDataContext147.GetLocation<bool>(refDataContext147.ValueType___Expr147Get, refDataContext147.ValueType___Expr147Set);
            }
            if ((expressionId == 148)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext148 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext148.ValueType___Expr148Get();
            }
            if ((expressionId == 149)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext149 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext149.ValueType___Expr149Get();
            }
            if ((expressionId == 150)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext150 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext150.GetLocation<JTL.Tax1040.BusinessObject.EIC>(refDataContext150.ValueType___Expr150Get, refDataContext150.ValueType___Expr150Set);
            }
            if ((expressionId == 151)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext151 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext151.ValueType___Expr151Get();
            }
            if ((expressionId == 152)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext152 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext152.ValueType___Expr152Get();
            }
            if ((expressionId == 153)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext153 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext153.ValueType___Expr153Get();
            }
            if ((expressionId == 154)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext154 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext154.ValueType___Expr154Get();
            }
            if ((expressionId == 155)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext155 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext155.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext155.ValueType___Expr155Get, refDataContext155.ValueType___Expr155Set);
            }
            if ((expressionId == 156)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext156 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext156.ValueType___Expr156Get();
            }
            if ((expressionId == 157)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext157 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext157.ValueType___Expr157Get();
            }
            if ((expressionId == 158)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext158 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext158.GetLocation<bool>(refDataContext158.ValueType___Expr158Get, refDataContext158.ValueType___Expr158Set);
            }
            if ((expressionId == 159)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext159 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext159.ValueType___Expr159Get();
            }
            if ((expressionId == 160)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext160 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext160.ValueType___Expr160Get();
            }
            if ((expressionId == 161)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext161 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext161.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext161.ValueType___Expr161Get, refDataContext161.ValueType___Expr161Set);
            }
            if ((expressionId == 162)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext162 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext162.ValueType___Expr162Get();
            }
            if ((expressionId == 163)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext163 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext163.ValueType___Expr163Get();
            }
            if ((expressionId == 164)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext164 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext164.GetLocation<bool>(refDataContext164.ValueType___Expr164Get, refDataContext164.ValueType___Expr164Set);
            }
            if ((expressionId == 165)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext165 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext165.ValueType___Expr165Get();
            }
            if ((expressionId == 166)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext166 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext166.ValueType___Expr166Get();
            }
            if ((expressionId == 167)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext167 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext167.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext167.ValueType___Expr167Get, refDataContext167.ValueType___Expr167Set);
            }
            if ((expressionId == 168)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext168 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext168.ValueType___Expr168Get();
            }
            if ((expressionId == 169)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext169 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext169.ValueType___Expr169Get();
            }
            if ((expressionId == 170)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext170 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext170.GetLocation<bool>(refDataContext170.ValueType___Expr170Get, refDataContext170.ValueType___Expr170Set);
            }
            if ((expressionId == 171)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext171 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext171.ValueType___Expr171Get();
            }
            if ((expressionId == 172)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext172 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext172.ValueType___Expr172Get();
            }
            if ((expressionId == 173)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext173 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext173.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext173.ValueType___Expr173Get, refDataContext173.ValueType___Expr173Set);
            }
            if ((expressionId == 174)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext174 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext174.ValueType___Expr174Get();
            }
            if ((expressionId == 175)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext175 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext175.ValueType___Expr175Get();
            }
            if ((expressionId == 176)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext176 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext176.GetLocation<bool>(refDataContext176.ValueType___Expr176Get, refDataContext176.ValueType___Expr176Set);
            }
            if ((expressionId == 177)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext177 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext177.GetLocation<bool>(refDataContext177.ValueType___Expr177Get, refDataContext177.ValueType___Expr177Set);
            }
            if ((expressionId == 178)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext178 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext178.GetLocation<bool>(refDataContext178.ValueType___Expr178Get, refDataContext178.ValueType___Expr178Set);
            }
            if ((expressionId == 179)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext179 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext179.ValueType___Expr179Get();
            }
            if ((expressionId == 180)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext180 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext180.GetLocation<bool>(refDataContext180.ValueType___Expr180Get, refDataContext180.ValueType___Expr180Set);
            }
            if ((expressionId == 181)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext181 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext181.ValueType___Expr181Get();
            }
            if ((expressionId == 182)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext182 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext182.ValueType___Expr182Get();
            }
            if ((expressionId == 183)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext183 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext183.GetLocation<System.Nullable<bool>>(refDataContext183.ValueType___Expr183Get, refDataContext183.ValueType___Expr183Set);
            }
            if ((expressionId == 184)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext184 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext184.ValueType___Expr184Get();
            }
            if ((expressionId == 185)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext185 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext185.GetLocation<JTL.Tax1040.BusinessObject.Credits>(refDataContext185.ValueType___Expr185Get, refDataContext185.ValueType___Expr185Set);
            }
            if ((expressionId == 186)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext186 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext186.ValueType___Expr186Get();
            }
            if ((expressionId == 187)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext187 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext187.GetLocation<System.Nullable<bool>>(refDataContext187.ValueType___Expr187Get, refDataContext187.ValueType___Expr187Set);
            }
            if ((expressionId == 188)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext188 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext188.ValueType___Expr188Get();
            }
            if ((expressionId == 189)) {
                F1040EZEICEligibilityRuleCheck_TypedDataContext2 refDataContext189 = new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locations, true);
                return refDataContext189.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext189.ValueType___Expr189Get, refDataContext189.ValueType___Expr189Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object !=null") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(ErrorMessageList==null)") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new List<ErrorMessage> ()") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails !=null") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer != null") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Utilities.MinimumDOB()") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Utilities.MaximumDOB()") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AnnualGrossIncome") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.OutputForms!=null) && (Tax1040Object.OutputForms.Tax1040EZPage1 !=" +
                            " null)") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= SingleAdjustedGro" +
                            "ssIncome") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_AGI_LIMIT]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person == null || Utilities.IsStrin" +
                            "gEmpty(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.SSN)") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_FORGOT_TAXPAYER_SSN]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!Utilities.IsValidSSN(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.SSN)") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_VALID_TAXPAYER_SSN]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object." +
                            "PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue &&  Tax104" +
                            "0Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value)") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_TAXPAYER_CLAIM_DEPENDENT]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person == null) || (Tax1040Object." +
                            "PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth == null)") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_TAXPAYER_AGE_LIMIT]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Utilities.EICAgeCalculation (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person" +
                            ".DateOfBirth)") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_TAXPAYER_AGE_LIMIT]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099INT != null) && " +
                            "(Tax1040Object.Income.Form1099INT.Count > 0))") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099INTTaxExemptInterest") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099INTTotal") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099OID != null) && " +
                            "(Tax1040Object.Income.Form1099OID.Count > 0))") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099OIDTaxExemptInterest") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099OIDTotal") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099INTTotal + F1099INTTaxExemptInterest + Form1099OIDTotal + F1099OIDTaxExem" +
                            "ptInterest") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "InvestmentIncome") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "InvestmentIncome > TaxableInterestLimit") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_TAXPAYER_INVESTMENT_INCOME_LIMIT]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income != null && Tax1040Object.Income.W2Wages != null") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWages") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalWages==0") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_HAVE_EARNED_INCOME]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_HAVE_EARNED_INCOME]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AnnualGrossIncome") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.OutputForms != null) && (Tax1040Object.OutputForms.Tax1040EZPage1 " +
                            "!= null)") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= MFJAdjustedGrossI" +
                            "ncome") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_AGI_LIMIT]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"((Tax1040Object.PersonalDetails.Spouse == null) || (Tax1040Object.PersonalDetails.Spouse.Person == null) || Utilities.IsStringEmpty(Tax1040Object.PersonalDetails.Spouse.Person.SSN)) || ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person == null) || Utilities.IsStringEmpty(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.SSN))") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_FORGOT_TAXPAYER_OR_SPOUSE_SSN]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(!Utilities.IsValidSSN(Tax1040Object.PersonalDetails.Spouse.Person.SSN)) || (!Uti" +
                            "lities.IsValidSSN(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.SSN))") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_VALID_TAXPAYER_OR_SPOUSE_SSN]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value)) || ((Tax1040Object.PersonalDetails.Spouse != null) && (Tax1040Object.PersonalDetails.Spouse.Person != null) && (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value))") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_CLAIM_DEPENDENT]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person == null) || (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth == null))
|| ((Tax1040Object.PersonalDetails.Spouse == null) || (Tax1040Object.PersonalDetails.Spouse.Person == null) || (Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth == null))") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_AGE_LIMIT]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Utilities.EICAgeCalculation(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person." +
                            "DateOfBirth) && Utilities.EICAgeCalculation(Tax1040Object.PersonalDetails.Spouse" +
                            ".Person.DateOfBirth)") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_AGE_LIMIT]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 116;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 117;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099INT != null) && " +
                            "(Tax1040Object.Income.Form1099INT.Count > 0))") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 118;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 119;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099INTTaxExemptInterest") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 120;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099INTTotal") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 121;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099OID != null) && " +
                            "(Tax1040Object.Income.Form1099OID.Count > 0))") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 122;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099OIDTaxExemptInterest") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 123;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 124;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Form1099OIDTotal") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 125;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099INTTotal + F1099INTTaxExemptInterest + Form1099OIDTotal + F1099OIDTaxExem" +
                            "ptInterest") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 126;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "InvestmentIncome") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 127;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "InvestmentIncome > TaxableInterestLimit") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 128;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_TAXPAYER_INVESTMENT_INCOME_LIMIT]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 129;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 130;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 131;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 132;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 133;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income != null && Tax1040Object.Income.W2Wages != null") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 134;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 135;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWages") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 136;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalWages==0") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 137;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_HAVE_EARNED_INCOME]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 138;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 139;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 140;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 141;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 142;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_INFO_HAVE_EARNED_INCOME]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 143;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 144;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 145;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 146;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 147;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!IsEICEligible && Tax1040Object.Credits != null && Tax1040Object.Credits.EIC !=nu" +
                            "ll") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 148;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "null") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 149;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.Credits.EIC") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 150;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits !=null") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 151;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits.EIC !=null") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 152;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits.EIC.IsInUSMorethanHalfYear.HasValue && Tax1040Object.Credit" +
                            "s.EIC.IsInUSMorethanHalfYear.Value") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 153;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_LIVED_IN_US]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 154;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 155;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 156;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 157;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 158;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits.EIC.HasValidSSN.HasValue && Tax1040Object.Credits.EIC.HasVa" +
                            "lidSSN.Value") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 159;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_SINGLE_OR_MFJ__INVALID_SSN]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 160;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 161;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 162;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 163;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 164;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits.EIC.HasClaimedAsQualifyingChild.HasValue && Tax1040Object.C" +
                            "redits.EIC.HasClaimedAsQualifyingChild.Value") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 165;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_NON_QUALIFIED_CHILD]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 166;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 167;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 168;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 169;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 170;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible.HasValue && Tax104" +
                            "0Object.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible.Value") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 171;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.EIC_RECEIVED_IRS_NOTICE]") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 172;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 173;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 174;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 175;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 176;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 177;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 178;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 179;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "HasEarnedIncomeCredit") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 180;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Credits != null") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 181;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 182;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.Credits.HasEarnedIncomeCredits") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 183;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Credits()") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 184;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.Credits") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 185;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsEICEligible") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 186;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.Credits.HasEarnedIncomeCredits") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 187;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 188;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 189;
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
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext4(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext5(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr109GetTree();
            }
            if ((expressionId == 110)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr110GetTree();
            }
            if ((expressionId == 111)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr111GetTree();
            }
            if ((expressionId == 112)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr112GetTree();
            }
            if ((expressionId == 113)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr113GetTree();
            }
            if ((expressionId == 114)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr114GetTree();
            }
            if ((expressionId == 115)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr115GetTree();
            }
            if ((expressionId == 116)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr116GetTree();
            }
            if ((expressionId == 117)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr117GetTree();
            }
            if ((expressionId == 118)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locationReferences).@__Expr118GetTree();
            }
            if ((expressionId == 119)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locationReferences).@__Expr119GetTree();
            }
            if ((expressionId == 120)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locationReferences).@__Expr120GetTree();
            }
            if ((expressionId == 121)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locationReferences).@__Expr121GetTree();
            }
            if ((expressionId == 122)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locationReferences).@__Expr122GetTree();
            }
            if ((expressionId == 123)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locationReferences).@__Expr123GetTree();
            }
            if ((expressionId == 124)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locationReferences).@__Expr124GetTree();
            }
            if ((expressionId == 125)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locationReferences).@__Expr125GetTree();
            }
            if ((expressionId == 126)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locationReferences).@__Expr126GetTree();
            }
            if ((expressionId == 127)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locationReferences).@__Expr127GetTree();
            }
            if ((expressionId == 128)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locationReferences).@__Expr128GetTree();
            }
            if ((expressionId == 129)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locationReferences).@__Expr129GetTree();
            }
            if ((expressionId == 130)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locationReferences).@__Expr130GetTree();
            }
            if ((expressionId == 131)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locationReferences).@__Expr131GetTree();
            }
            if ((expressionId == 132)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(locationReferences).@__Expr132GetTree();
            }
            if ((expressionId == 133)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext6(locationReferences).@__Expr133GetTree();
            }
            if ((expressionId == 134)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locationReferences).@__Expr134GetTree();
            }
            if ((expressionId == 135)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locationReferences).@__Expr135GetTree();
            }
            if ((expressionId == 136)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locationReferences).@__Expr136GetTree();
            }
            if ((expressionId == 137)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locationReferences).@__Expr137GetTree();
            }
            if ((expressionId == 138)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locationReferences).@__Expr138GetTree();
            }
            if ((expressionId == 139)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locationReferences).@__Expr139GetTree();
            }
            if ((expressionId == 140)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locationReferences).@__Expr140GetTree();
            }
            if ((expressionId == 141)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locationReferences).@__Expr141GetTree();
            }
            if ((expressionId == 142)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locationReferences).@__Expr142GetTree();
            }
            if ((expressionId == 143)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locationReferences).@__Expr143GetTree();
            }
            if ((expressionId == 144)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locationReferences).@__Expr144GetTree();
            }
            if ((expressionId == 145)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locationReferences).@__Expr145GetTree();
            }
            if ((expressionId == 146)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(locationReferences).@__Expr146GetTree();
            }
            if ((expressionId == 147)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext7(locationReferences).@__Expr147GetTree();
            }
            if ((expressionId == 148)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr148GetTree();
            }
            if ((expressionId == 149)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr149GetTree();
            }
            if ((expressionId == 150)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr150GetTree();
            }
            if ((expressionId == 151)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr151GetTree();
            }
            if ((expressionId == 152)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr152GetTree();
            }
            if ((expressionId == 153)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr153GetTree();
            }
            if ((expressionId == 154)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr154GetTree();
            }
            if ((expressionId == 155)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr155GetTree();
            }
            if ((expressionId == 156)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr156GetTree();
            }
            if ((expressionId == 157)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr157GetTree();
            }
            if ((expressionId == 158)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr158GetTree();
            }
            if ((expressionId == 159)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr159GetTree();
            }
            if ((expressionId == 160)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr160GetTree();
            }
            if ((expressionId == 161)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr161GetTree();
            }
            if ((expressionId == 162)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr162GetTree();
            }
            if ((expressionId == 163)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr163GetTree();
            }
            if ((expressionId == 164)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr164GetTree();
            }
            if ((expressionId == 165)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr165GetTree();
            }
            if ((expressionId == 166)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr166GetTree();
            }
            if ((expressionId == 167)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr167GetTree();
            }
            if ((expressionId == 168)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr168GetTree();
            }
            if ((expressionId == 169)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr169GetTree();
            }
            if ((expressionId == 170)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr170GetTree();
            }
            if ((expressionId == 171)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr171GetTree();
            }
            if ((expressionId == 172)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr172GetTree();
            }
            if ((expressionId == 173)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr173GetTree();
            }
            if ((expressionId == 174)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr174GetTree();
            }
            if ((expressionId == 175)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr175GetTree();
            }
            if ((expressionId == 176)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr176GetTree();
            }
            if ((expressionId == 177)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr177GetTree();
            }
            if ((expressionId == 178)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr178GetTree();
            }
            if ((expressionId == 179)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr179GetTree();
            }
            if ((expressionId == 180)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr180GetTree();
            }
            if ((expressionId == 181)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr181GetTree();
            }
            if ((expressionId == 182)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr182GetTree();
            }
            if ((expressionId == 183)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr183GetTree();
            }
            if ((expressionId == 184)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr184GetTree();
            }
            if ((expressionId == 185)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr185GetTree();
            }
            if ((expressionId == 186)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr186GetTree();
            }
            if ((expressionId == 187)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr187GetTree();
            }
            if ((expressionId == 188)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr188GetTree();
            }
            if ((expressionId == 189)) {
                return new F1040EZEICEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr189GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext1 : F1040EZEICEligibilityRuleCheck_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool HasEarnedIncomeCredit;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.HasEarnedIncomeCredit = ((bool)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.HasEarnedIncomeCredit);
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
                if (((locationReferences[(offset + 0)].Name != "Tax1040Object") 
                            || (locationReferences[(offset + 0)].Type != typeof(JTL.Tax1040.BusinessObject.Tax1040)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "ErrorMessages") 
                            || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessages)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "HasEarnedIncomeCredit") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext1_ForReadOnly : F1040EZEICEligibilityRuleCheck_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool HasEarnedIncomeCredit;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.HasEarnedIncomeCredit = ((bool)(this.GetVariableValue((1 + locationsOffset))));
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
                if (((locationReferences[(offset + 0)].Name != "Tax1040Object") 
                            || (locationReferences[(offset + 0)].Type != typeof(JTL.Tax1040.BusinessObject.Tax1040)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "ErrorMessages") 
                            || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessages)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "HasEarnedIncomeCredit") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext2 : F1040EZEICEligibilityRuleCheck_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double SingleAdjustedGrossIncome;
            
            protected double MFJAdjustedGrossIncome;
            
            protected bool IsEICEligible;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.Core.Object.ErrorMessage ErrorMessage {
                get {
                    return ((JTL.Tax1040.Core.Object.ErrorMessage)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ErrorMessageList {
                get {
                    return ((System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)(this.GetVariableValue((4 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 94 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                      ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr4Get() {
                
                #line 94 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                      ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                
                #line 94 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                      ErrorMessageList = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr150GetTree() {
                
                #line 1188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.EIC>> expression = () => 
                      Tax1040Object.Credits.EIC;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.EIC @__Expr150Get() {
                
                #line 1188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                      Tax1040Object.Credits.EIC;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.EIC ValueType___Expr150Get() {
                this.GetValueTypeValues();
                return this.@__Expr150Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr150Set(JTL.Tax1040.BusinessObject.EIC value) {
                
                #line 1188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                      Tax1040Object.Credits.EIC = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr150Set(JTL.Tax1040.BusinessObject.EIC value) {
                this.GetValueTypeValues();
                this.@__Expr150Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr155GetTree() {
                
                #line 1228 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                    ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr155Get() {
                
                #line 1228 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr155Get() {
                this.GetValueTypeValues();
                return this.@__Expr155Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr155Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 1228 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                    ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr155Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr155Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr158GetTree() {
                
                #line 1250 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr158Get() {
                
                #line 1250 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr158Get() {
                this.GetValueTypeValues();
                return this.@__Expr158Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr158Set(bool value) {
                
                #line 1250 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                    IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr158Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr158Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr161GetTree() {
                
                #line 1273 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                    ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr161Get() {
                
                #line 1273 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr161Get() {
                this.GetValueTypeValues();
                return this.@__Expr161Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr161Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 1273 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                    ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr161Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr161Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr164GetTree() {
                
                #line 1295 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr164Get() {
                
                #line 1295 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr164Get() {
                this.GetValueTypeValues();
                return this.@__Expr164Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr164Set(bool value) {
                
                #line 1295 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                    IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr164Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr164Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr167GetTree() {
                
                #line 1318 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                    ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr167Get() {
                
                #line 1318 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr167Get() {
                this.GetValueTypeValues();
                return this.@__Expr167Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr167Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 1318 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                    ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr167Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr167Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr170GetTree() {
                
                #line 1340 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr170Get() {
                
                #line 1340 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr170Get() {
                this.GetValueTypeValues();
                return this.@__Expr170Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr170Set(bool value) {
                
                #line 1340 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                    IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr170Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr170Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr173GetTree() {
                
                #line 1363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                    ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr173Get() {
                
                #line 1363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr173Get() {
                this.GetValueTypeValues();
                return this.@__Expr173Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr173Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 1363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                    ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr173Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr173Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr176GetTree() {
                
                #line 1385 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr176Get() {
                
                #line 1385 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr176Get() {
                this.GetValueTypeValues();
                return this.@__Expr176Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr176Set(bool value) {
                
                #line 1385 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                    IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr176Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr176Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr177GetTree() {
                
                #line 1402 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr177Get() {
                
                #line 1402 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                          IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr177Get() {
                this.GetValueTypeValues();
                return this.@__Expr177Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr177Set(bool value) {
                
                #line 1402 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                          IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr177Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr177Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr178GetTree() {
                
                #line 1416 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr178Get() {
                
                #line 1416 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr178Get() {
                this.GetValueTypeValues();
                return this.@__Expr178Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr178Set(bool value) {
                
                #line 1416 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr178Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr178Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr180GetTree() {
                
                #line 1429 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                HasEarnedIncomeCredit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr180Get() {
                
                #line 1429 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                HasEarnedIncomeCredit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr180Get() {
                this.GetValueTypeValues();
                return this.@__Expr180Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr180Set(bool value) {
                
                #line 1429 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                HasEarnedIncomeCredit = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr180Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr180Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr183GetTree() {
                
                #line 1448 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                    Tax1040Object.Credits.HasEarnedIncomeCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr183Get() {
                
                #line 1448 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                    Tax1040Object.Credits.HasEarnedIncomeCredits;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr183Get() {
                this.GetValueTypeValues();
                return this.@__Expr183Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr183Set(System.Nullable<bool> value) {
                
                #line 1448 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                    Tax1040Object.Credits.HasEarnedIncomeCredits = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr183Set(System.Nullable<bool> value) {
                this.GetValueTypeValues();
                this.@__Expr183Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr185GetTree() {
                
                #line 1463 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Credits>> expression = () => 
                      Tax1040Object.Credits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Credits @__Expr185Get() {
                
                #line 1463 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                      Tax1040Object.Credits;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Credits ValueType___Expr185Get() {
                this.GetValueTypeValues();
                return this.@__Expr185Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr185Set(JTL.Tax1040.BusinessObject.Credits value) {
                
                #line 1463 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                      Tax1040Object.Credits = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr185Set(JTL.Tax1040.BusinessObject.Credits value) {
                this.GetValueTypeValues();
                this.@__Expr185Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr187GetTree() {
                
                #line 1475 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                      Tax1040Object.Credits.HasEarnedIncomeCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr187Get() {
                
                #line 1475 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                      Tax1040Object.Credits.HasEarnedIncomeCredits;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr187Get() {
                this.GetValueTypeValues();
                return this.@__Expr187Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr187Set(System.Nullable<bool> value) {
                
                #line 1475 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                      Tax1040Object.Credits.HasEarnedIncomeCredits = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr187Set(System.Nullable<bool> value) {
                this.GetValueTypeValues();
                this.@__Expr187Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr189GetTree() {
                
                #line 1490 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr189Get() {
                
                #line 1490 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr189Get() {
                this.GetValueTypeValues();
                return this.@__Expr189Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr189Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                
                #line 1490 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                Tax1040Object.ErrorMessages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr189Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                this.GetValueTypeValues();
                this.@__Expr189Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.SingleAdjustedGrossIncome = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.MFJAdjustedGrossIncome = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.IsEICEligible = ((bool)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.SingleAdjustedGrossIncome);
                this.SetVariableValue((6 + locationsOffset), this.MFJAdjustedGrossIncome);
                this.SetVariableValue((7 + locationsOffset), this.IsEICEligible);
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
                if (((locationReferences[(offset + 3)].Name != "ErrorMessage") 
                            || (locationReferences[(offset + 3)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "ErrorMessageList") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "SingleAdjustedGrossIncome") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "MFJAdjustedGrossIncome") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "IsEICEligible") 
                            || (locationReferences[(offset + 7)].Type != typeof(bool)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly : F1040EZEICEligibilityRuleCheck_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double SingleAdjustedGrossIncome;
            
            protected double MFJAdjustedGrossIncome;
            
            protected bool IsEICEligible;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.Core.Object.ErrorMessage ErrorMessage {
                get {
                    return ((JTL.Tax1040.Core.Object.ErrorMessage)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ErrorMessageList {
                get {
                    return ((System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)(this.GetVariableValue((4 + locationsOffset))));
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
                
                #line 68 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
          Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr0Get() {
                
                #line 68 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
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
                
                #line 78 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          Tax1040Object !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 78 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
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
                
                #line 86 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                (ErrorMessageList==null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr2Get() {
                
                #line 86 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                (ErrorMessageList==null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 99 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                      new List<ErrorMessage> ();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr3Get() {
                
                #line 99 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                      new List<ErrorMessage> ();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 110 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.PersonalDetails !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 110 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                  Tax1040Object.PersonalDetails !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 117 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 117 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr148GetTree() {
                
                #line 1181 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  !IsEICEligible && Tax1040Object.Credits != null && Tax1040Object.Credits.EIC !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr148Get() {
                
                #line 1181 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                  !IsEICEligible && Tax1040Object.Credits != null && Tax1040Object.Credits.EIC !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr148Get() {
                this.GetValueTypeValues();
                return this.@__Expr148Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr149GetTree() {
                
                #line 1193 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.EIC>> expression = () => 
                      null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.EIC @__Expr149Get() {
                
                #line 1193 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                      null;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.EIC ValueType___Expr149Get() {
                this.GetValueTypeValues();
                return this.@__Expr149Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr151GetTree() {
                
                #line 1204 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.Credits !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr151Get() {
                
                #line 1204 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                  Tax1040Object.Credits !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr151Get() {
                this.GetValueTypeValues();
                return this.@__Expr151Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr152GetTree() {
                
                #line 1211 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.Credits.EIC !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr152Get() {
                
                #line 1211 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                      Tax1040Object.Credits.EIC !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr152Get() {
                this.GetValueTypeValues();
                return this.@__Expr152Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr153GetTree() {
                
                #line 1220 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.Credits.EIC.IsInUSMorethanHalfYear.HasValue && Tax1040Object.Credits.EIC.IsInUSMorethanHalfYear.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr153Get() {
                
                #line 1220 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                              Tax1040Object.Credits.EIC.IsInUSMorethanHalfYear.HasValue && Tax1040Object.Credits.EIC.IsInUSMorethanHalfYear.Value;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr153Get() {
                this.GetValueTypeValues();
                return this.@__Expr153Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr154GetTree() {
                
                #line 1233 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                    ErrorMessages[Constants.EIC_LIVED_IN_US];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr154Get() {
                
                #line 1233 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessages[Constants.EIC_LIVED_IN_US];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr154Get() {
                this.GetValueTypeValues();
                return this.@__Expr154Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr156GetTree() {
                
                #line 1244 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                  ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr156Get() {
                
                #line 1244 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr156Get() {
                this.GetValueTypeValues();
                return this.@__Expr156Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr157GetTree() {
                
                #line 1240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                    ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr157Get() {
                
                #line 1240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr157Get() {
                this.GetValueTypeValues();
                return this.@__Expr157Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr159GetTree() {
                
                #line 1265 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.Credits.EIC.HasValidSSN.HasValue && Tax1040Object.Credits.EIC.HasValidSSN.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr159Get() {
                
                #line 1265 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                              Tax1040Object.Credits.EIC.HasValidSSN.HasValue && Tax1040Object.Credits.EIC.HasValidSSN.Value;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr159Get() {
                this.GetValueTypeValues();
                return this.@__Expr159Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr160GetTree() {
                
                #line 1278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                    ErrorMessages[Constants.EIC_SINGLE_OR_MFJ__INVALID_SSN];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr160Get() {
                
                #line 1278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessages[Constants.EIC_SINGLE_OR_MFJ__INVALID_SSN];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr160Get() {
                this.GetValueTypeValues();
                return this.@__Expr160Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr162GetTree() {
                
                #line 1289 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                  ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr162Get() {
                
                #line 1289 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr162Get() {
                this.GetValueTypeValues();
                return this.@__Expr162Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr163GetTree() {
                
                #line 1285 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                    ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr163Get() {
                
                #line 1285 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr163Get() {
                this.GetValueTypeValues();
                return this.@__Expr163Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr165GetTree() {
                
                #line 1310 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.Credits.EIC.HasClaimedAsQualifyingChild.HasValue && Tax1040Object.Credits.EIC.HasClaimedAsQualifyingChild.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr165Get() {
                
                #line 1310 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                              Tax1040Object.Credits.EIC.HasClaimedAsQualifyingChild.HasValue && Tax1040Object.Credits.EIC.HasClaimedAsQualifyingChild.Value;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr165Get() {
                this.GetValueTypeValues();
                return this.@__Expr165Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr166GetTree() {
                
                #line 1323 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                    ErrorMessages[Constants.EIC_NON_QUALIFIED_CHILD];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr166Get() {
                
                #line 1323 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessages[Constants.EIC_NON_QUALIFIED_CHILD];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr166Get() {
                this.GetValueTypeValues();
                return this.@__Expr166Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr168GetTree() {
                
                #line 1334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                  ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr168Get() {
                
                #line 1334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr168Get() {
                this.GetValueTypeValues();
                return this.@__Expr168Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr169GetTree() {
                
                #line 1330 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                    ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr169Get() {
                
                #line 1330 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr169Get() {
                this.GetValueTypeValues();
                return this.@__Expr169Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr171GetTree() {
                
                #line 1355 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible.HasValue && Tax1040Object.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr171Get() {
                
                #line 1355 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                              Tax1040Object.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible.HasValue && Tax1040Object.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible.Value;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr171Get() {
                this.GetValueTypeValues();
                return this.@__Expr171Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr172GetTree() {
                
                #line 1368 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                    ErrorMessages[Constants.EIC_RECEIVED_IRS_NOTICE];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr172Get() {
                
                #line 1368 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessages[Constants.EIC_RECEIVED_IRS_NOTICE];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr172Get() {
                this.GetValueTypeValues();
                return this.@__Expr172Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr174GetTree() {
                
                #line 1379 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                  ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr174Get() {
                
                #line 1379 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr174Get() {
                this.GetValueTypeValues();
                return this.@__Expr174Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr175GetTree() {
                
                #line 1375 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                    ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr175Get() {
                
                #line 1375 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr175Get() {
                this.GetValueTypeValues();
                return this.@__Expr175Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr179GetTree() {
                
                #line 1434 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr179Get() {
                
                #line 1434 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr179Get() {
                this.GetValueTypeValues();
                return this.@__Expr179Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr181GetTree() {
                
                #line 1441 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                Tax1040Object.Credits != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr181Get() {
                
                #line 1441 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                Tax1040Object.Credits != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr181Get() {
                this.GetValueTypeValues();
                return this.@__Expr181Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr182GetTree() {
                
                #line 1453 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                    IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr182Get() {
                
                #line 1453 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                    IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr182Get() {
                this.GetValueTypeValues();
                return this.@__Expr182Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr184GetTree() {
                
                #line 1468 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Credits>> expression = () => 
                      new Credits();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Credits @__Expr184Get() {
                
                #line 1468 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                      new Credits();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Credits ValueType___Expr184Get() {
                this.GetValueTypeValues();
                return this.@__Expr184Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr186GetTree() {
                
                #line 1480 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<bool>>> expression = () => 
                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<bool> @__Expr186Get() {
                
                #line 1480 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<bool> ValueType___Expr186Get() {
                this.GetValueTypeValues();
                return this.@__Expr186Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr188GetTree() {
                
                #line 1495 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr188Get() {
                
                #line 1495 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr188Get() {
                this.GetValueTypeValues();
                return this.@__Expr188Get();
            }
            
            protected override void GetValueTypeValues() {
                this.SingleAdjustedGrossIncome = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.MFJAdjustedGrossIncome = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.IsEICEligible = ((bool)(this.GetVariableValue((7 + locationsOffset))));
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
                if (((locationReferences[(offset + 3)].Name != "ErrorMessage") 
                            || (locationReferences[(offset + 3)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "ErrorMessageList") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "SingleAdjustedGrossIncome") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "MFJAdjustedGrossIncome") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "IsEICEligible") 
                            || (locationReferences[(offset + 7)].Type != typeof(bool)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext3 : F1040EZEICEligibilityRuleCheck_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.DateTime MinimumDOB;
            
            protected System.DateTime MaximumDOB;
            
            protected double AnnualGrossIncome;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 145 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                AnnualGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr11Get() {
                
                #line 145 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                AnnualGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(double value) {
                
                #line 145 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                AnnualGrossIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 172 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr15Get() {
                
                #line 172 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 172 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                          ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 194 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr18Get() {
                
                #line 194 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(bool value) {
                
                #line 194 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                          IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 217 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr21Get() {
                
                #line 217 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 217 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                      ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 239 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr24Get() {
                
                #line 239 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
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
                
                #line 239 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 260 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr27Get() {
                
                #line 260 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 260 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                          ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 282 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr30Get() {
                
                #line 282 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
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
                
                #line 282 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                          IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 305 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr33Get() {
                
                #line 305 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 305 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                      ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr36Get() {
                
                #line 327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
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
                
                #line 327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 348 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr39Get() {
                
                #line 348 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 348 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                      ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 370 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr42Get() {
                
                #line 370 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(bool value) {
                
                #line 370 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 391 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr45Get() {
                
                #line 391 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 391 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                          ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr48Get() {
                
                #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
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
                
                #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                          IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr48Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr48Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 658 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                AnnualGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr80Get() {
                
                #line 658 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                AnnualGrossIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr80Set(double value) {
                
                #line 658 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                AnnualGrossIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr80Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr80Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 685 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr84Get() {
                
                #line 685 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr84Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 685 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                          ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr84Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr84Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 707 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr87Get() {
                
                #line 707 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr87Set(bool value) {
                
                #line 707 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                          IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr87Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr87Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 730 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr90Get() {
                
                #line 730 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr90Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 730 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                      ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr90Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr90Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 752 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr93Get() {
                
                #line 752 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr93Set(bool value) {
                
                #line 752 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr93Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr93Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 774 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr96Get() {
                
                #line 774 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr96Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 774 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                          ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr96Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr96Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 796 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr99Get() {
                
                #line 796 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr99Set(bool value) {
                
                #line 796 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                          IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr99Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr99Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 820 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr102Get() {
                
                #line 820 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr102Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 820 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                      ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr102Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr102Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 842 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr105Get() {
                
                #line 842 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr105Set(bool value) {
                
                #line 842 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr105Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr105Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 864 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr108Get() {
                
                #line 864 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr108Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 864 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                      ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr108Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr108Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr111GetTree() {
                
                #line 886 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr111Get() {
                
                #line 886 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr111Get() {
                this.GetValueTypeValues();
                return this.@__Expr111Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr111Set(bool value) {
                
                #line 886 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                      IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr111Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr111Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr114GetTree() {
                
                #line 907 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr114Get() {
                
                #line 907 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr114Get() {
                this.GetValueTypeValues();
                return this.@__Expr114Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr114Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 907 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                          ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr114Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr114Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr117GetTree() {
                
                #line 929 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr117Get() {
                
                #line 929 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr117Get() {
                this.GetValueTypeValues();
                return this.@__Expr117Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr117Set(bool value) {
                
                #line 929 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                          IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr117Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr117Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.MinimumDOB = ((System.DateTime)(this.GetVariableValue((8 + locationsOffset))));
                this.MaximumDOB = ((System.DateTime)(this.GetVariableValue((9 + locationsOffset))));
                this.AnnualGrossIncome = ((double)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((8 + locationsOffset), this.MinimumDOB);
                this.SetVariableValue((9 + locationsOffset), this.MaximumDOB);
                this.SetVariableValue((10 + locationsOffset), this.AnnualGrossIncome);
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
                if (((locationReferences[(offset + 8)].Name != "MinimumDOB") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "MaximumDOB") 
                            || (locationReferences[(offset + 9)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "AnnualGrossIncome") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly : F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.DateTime MinimumDOB;
            
            protected System.DateTime MaximumDOB;
            
            protected double AnnualGrossIncome;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 125 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                            Utilities.MinimumDOB();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr7Get() {
                
                #line 125 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                            Utilities.MinimumDOB();
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                            Utilities.MaximumDOB();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr8Get() {
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                            Utilities.MaximumDOB();
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 138 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr9Get() {
                
                #line 138 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 150 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr10Get() {
                
                #line 150 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 157 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                (Tax1040Object.OutputForms!=null) && (Tax1040Object.OutputForms.Tax1040EZPage1 != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 157 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                (Tax1040Object.OutputForms!=null) && (Tax1040Object.OutputForms.Tax1040EZPage1 != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 164 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= SingleAdjustedGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 164 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= SingleAdjustedGrossIncome;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 177 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_AGI_LIMIT];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr14Get() {
                
                #line 177 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_AGI_LIMIT];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                        ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr16Get() {
                
                #line 188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 184 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr17Get() {
                
                #line 184 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 209 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person == null || Utilities.IsStringEmpty(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.SSN);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr19Get() {
                
                #line 209 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person == null || Utilities.IsStringEmpty(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.SSN);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 222 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessages[Constants.EIC_INFO_FORGOT_TAXPAYER_SSN];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr20Get() {
                
                #line 222 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessages[Constants.EIC_INFO_FORGOT_TAXPAYER_SSN];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 233 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                    ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr22Get() {
                
                #line 233 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 229 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr23Get() {
                
                #line 229 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 252 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    !Utilities.IsValidSSN(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.SSN);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr25Get() {
                
                #line 252 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    !Utilities.IsValidSSN(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.SSN);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 265 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessages[Constants.EIC_INFO_VALID_TAXPAYER_SSN];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr26Get() {
                
                #line 265 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessages[Constants.EIC_INFO_VALID_TAXPAYER_SSN];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 276 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                        ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr28Get() {
                
                #line 276 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 272 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr29Get() {
                
                #line 272 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 297 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue &&  Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr31Get() {
                
                #line 297 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue &&  Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 310 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessages[Constants.EIC_INFO_TAXPAYER_CLAIM_DEPENDENT];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr32Get() {
                
                #line 310 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessages[Constants.EIC_INFO_TAXPAYER_CLAIM_DEPENDENT];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 321 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                    ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr34Get() {
                
                #line 321 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 317 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr35Get() {
                
                #line 317 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 340 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person == null) || (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth == null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr37Get() {
                
                #line 340 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person == null) || (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth == null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 353 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessages[Constants.EIC_INFO_TAXPAYER_AGE_LIMIT];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr38Get() {
                
                #line 353 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessages[Constants.EIC_INFO_TAXPAYER_AGE_LIMIT];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 364 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                    ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr40Get() {
                
                #line 364 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 360 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr41Get() {
                
                #line 360 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Utilities.EICAgeCalculation (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr43Get() {
                
                #line 383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    Utilities.EICAgeCalculation (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessages[Constants.EIC_INFO_TAXPAYER_AGE_LIMIT];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr44Get() {
                
                #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessages[Constants.EIC_INFO_TAXPAYER_AGE_LIMIT];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 407 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                        ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr46Get() {
                
                #line 407 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 403 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr47Get() {
                
                #line 403 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 663 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr79Get() {
                
                #line 663 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 670 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                (Tax1040Object.OutputForms != null) && (Tax1040Object.OutputForms.Tax1040EZPage1 != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr81Get() {
                
                #line 670 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                (Tax1040Object.OutputForms != null) && (Tax1040Object.OutputForms.Tax1040EZPage1 != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 677 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= MFJAdjustedGrossIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr82Get() {
                
                #line 677 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome <= MFJAdjustedGrossIncome;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 690 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_AGI_LIMIT];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr83Get() {
                
                #line 690 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_AGI_LIMIT];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 701 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                        ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr85Get() {
                
                #line 701 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 697 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr86Get() {
                
                #line 697 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 722 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                ((Tax1040Object.PersonalDetails.Spouse == null) || (Tax1040Object.PersonalDetails.Spouse.Person == null) || Utilities.IsStringEmpty(Tax1040Object.PersonalDetails.Spouse.Person.SSN)) || ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person == null) || Utilities.IsStringEmpty(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.SSN));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr88Get() {
                
                #line 722 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                ((Tax1040Object.PersonalDetails.Spouse == null) || (Tax1040Object.PersonalDetails.Spouse.Person == null) || Utilities.IsStringEmpty(Tax1040Object.PersonalDetails.Spouse.Person.SSN)) || ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person == null) || Utilities.IsStringEmpty(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.SSN));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 735 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessages[Constants.EIC_INFO_FORGOT_TAXPAYER_OR_SPOUSE_SSN];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr89Get() {
                
                #line 735 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessages[Constants.EIC_INFO_FORGOT_TAXPAYER_OR_SPOUSE_SSN];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                    ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr91Get() {
                
                #line 746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 742 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr92Get() {
                
                #line 742 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr94GetTree() {
                
                #line 766 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    (!Utilities.IsValidSSN(Tax1040Object.PersonalDetails.Spouse.Person.SSN)) || (!Utilities.IsValidSSN(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.SSN));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr94Get() {
                
                #line 766 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    (!Utilities.IsValidSSN(Tax1040Object.PersonalDetails.Spouse.Person.SSN)) || (!Utilities.IsValidSSN(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.SSN));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 779 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessages[Constants.EIC_INFO_VALID_TAXPAYER_OR_SPOUSE_SSN];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr95Get() {
                
                #line 779 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessages[Constants.EIC_INFO_VALID_TAXPAYER_OR_SPOUSE_SSN];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 790 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                        ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr97Get() {
                
                #line 790 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 786 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr98Get() {
                
                #line 786 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 812 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value)) || ((Tax1040Object.PersonalDetails.Spouse != null) && (Tax1040Object.PersonalDetails.Spouse.Person != null) && (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr100Get() {
                
                #line 812 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value)) || ((Tax1040Object.PersonalDetails.Spouse != null) && (Tax1040Object.PersonalDetails.Spouse.Person != null) && (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 825 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_CLAIM_DEPENDENT];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr101Get() {
                
                #line 825 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_CLAIM_DEPENDENT];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 836 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                    ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr103Get() {
                
                #line 836 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 832 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr104Get() {
                
                #line 832 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 855 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person == null) || (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth == null))
|| ((Tax1040Object.PersonalDetails.Spouse == null) || (Tax1040Object.PersonalDetails.Spouse.Person == null) || (Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth == null));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr106Get() {
                
                #line 855 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person == null) || (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth == null))
|| ((Tax1040Object.PersonalDetails.Spouse == null) || (Tax1040Object.PersonalDetails.Spouse.Person == null) || (Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth == null));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr106Get() {
                this.GetValueTypeValues();
                return this.@__Expr106Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 869 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_AGE_LIMIT];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr107Get() {
                
                #line 869 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_AGE_LIMIT];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 880 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                    ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr109Get() {
                
                #line 880 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr110GetTree() {
                
                #line 876 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr110Get() {
                
                #line 876 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr110Get() {
                this.GetValueTypeValues();
                return this.@__Expr110Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr112GetTree() {
                
                #line 899 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Utilities.EICAgeCalculation(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth) && Utilities.EICAgeCalculation(Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr112Get() {
                
                #line 899 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                    Utilities.EICAgeCalculation(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth) && Utilities.EICAgeCalculation(Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr112Get() {
                this.GetValueTypeValues();
                return this.@__Expr112Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 912 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_AGE_LIMIT];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr113Get() {
                
                #line 912 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessages[Constants.EIC_INFO_TAXPAYER_SPOUSE_AGE_LIMIT];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr113Get() {
                this.GetValueTypeValues();
                return this.@__Expr113Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 923 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                        ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr115Get() {
                
                #line 923 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr116GetTree() {
                
                #line 919 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr116Get() {
                
                #line 919 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                          ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr116Get() {
                this.GetValueTypeValues();
                return this.@__Expr116Get();
            }
            
            protected override void GetValueTypeValues() {
                this.MinimumDOB = ((System.DateTime)(this.GetVariableValue((8 + locationsOffset))));
                this.MaximumDOB = ((System.DateTime)(this.GetVariableValue((9 + locationsOffset))));
                this.AnnualGrossIncome = ((double)(this.GetVariableValue((10 + locationsOffset))));
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
                if (((locationReferences[(offset + 8)].Name != "MinimumDOB") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "MaximumDOB") 
                            || (locationReferences[(offset + 9)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "AnnualGrossIncome") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext4 : F1040EZEICEligibilityRuleCheck_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Form1099OIDTotal;
            
            protected double F1099OIDTaxExemptInterest;
            
            protected double Form1099INTTotal;
            
            protected double F1099INTTaxExemptInterest;
            
            protected double InvestmentIncome;
            
            protected double TaxableInterestLimit;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 445 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr50Get() {
                
                #line 445 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr50Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 445 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr50Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr50Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 455 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr51Get() {
                
                #line 455 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(double value) {
                
                #line 455 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        F1099INTTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 450 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Form1099INTTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr52Get() {
                
                #line 450 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        Form1099INTTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr52Set(double value) {
                
                #line 450 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        Form1099INTTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr52Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr52Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 483 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr54Get() {
                
                #line 483 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr54Set(double value) {
                
                #line 483 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        F1099OIDTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr54Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr54Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 473 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr55Get() {
                
                #line 473 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
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
                
                #line 473 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
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
                
                #line 478 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Form1099OIDTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr56Get() {
                
                #line 478 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        Form1099OIDTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr56Set(double value) {
                
                #line 478 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        Form1099OIDTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr56Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr56Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 493 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  InvestmentIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr58Get() {
                
                #line 493 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  InvestmentIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr58Set(double value) {
                
                #line 493 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                  InvestmentIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr58Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr58Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 513 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                        ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr61Get() {
                
                #line 513 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 513 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 535 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr64Get() {
                
                #line 535 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr64Set(bool value) {
                
                #line 535 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr64Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr64Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((12 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.InvestmentIncome = ((double)(this.GetVariableValue((15 + locationsOffset))));
                this.TaxableInterestLimit = ((double)(this.GetVariableValue((16 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((11 + locationsOffset), this.Form1099OIDTotal);
                this.SetVariableValue((12 + locationsOffset), this.F1099OIDTaxExemptInterest);
                this.SetVariableValue((13 + locationsOffset), this.Form1099INTTotal);
                this.SetVariableValue((14 + locationsOffset), this.F1099INTTaxExemptInterest);
                this.SetVariableValue((15 + locationsOffset), this.InvestmentIncome);
                this.SetVariableValue((16 + locationsOffset), this.TaxableInterestLimit);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 17))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 17);
                }
                expectedLocationsCount = 17;
                if (((locationReferences[(offset + 11)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "InvestmentIncome") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "TaxableInterestLimit") 
                            || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly : F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Form1099OIDTotal;
            
            protected double F1099OIDTaxExemptInterest;
            
            protected double Form1099INTTotal;
            
            protected double F1099INTTaxExemptInterest;
            
            protected double InvestmentIncome;
            
            protected double TaxableInterestLimit;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 437 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  ((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr49Get() {
                
                #line 437 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  ((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 465 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  ((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr53Get() {
                
                #line 465 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  ((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 498 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Form1099INTTotal + F1099INTTaxExemptInterest + Form1099OIDTotal + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr57Get() {
                
                #line 498 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  Form1099INTTotal + F1099INTTaxExemptInterest + Form1099OIDTotal + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  InvestmentIncome > TaxableInterestLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr59Get() {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  InvestmentIncome > TaxableInterestLimit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 518 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                        ErrorMessages[Constants.EIC_INFO_TAXPAYER_INVESTMENT_INCOME_LIMIT];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr60Get() {
                
                #line 518 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessages[Constants.EIC_INFO_TAXPAYER_INVESTMENT_INCOME_LIMIT];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 529 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                      ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr62Get() {
                
                #line 529 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 525 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                        ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr63Get() {
                
                #line 525 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((12 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.InvestmentIncome = ((double)(this.GetVariableValue((15 + locationsOffset))));
                this.TaxableInterestLimit = ((double)(this.GetVariableValue((16 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 17))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 17);
                }
                expectedLocationsCount = 17;
                if (((locationReferences[(offset + 11)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "InvestmentIncome") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "TaxableInterestLimit") 
                            || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext5 : F1040EZEICEligibilityRuleCheck_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWages;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 561 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr66Get() {
                
                #line 561 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr66Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 561 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr66Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr66Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 566 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr67Get() {
                
                #line 566 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr67Set(double value) {
                
                #line 566 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr67Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr67Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 581 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                              ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr70Get() {
                
                #line 581 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                              ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr70Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 581 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                              ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr70Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr70Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 603 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr73Get() {
                
                #line 603 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                              IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr73Set(bool value) {
                
                #line 603 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                              IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr73Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr73Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 620 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                        ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr75Get() {
                
                #line 620 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr75Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 620 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr75Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr75Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr78Get() {
                
                #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr78Set(bool value) {
                
                #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr78Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr78Set(value);
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
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "TotalWages") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly : F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWages;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 553 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  Tax1040Object.Income != null && Tax1040Object.Income.W2Wages != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr65Get() {
                
                #line 553 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  Tax1040Object.Income != null && Tax1040Object.Income.W2Wages != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 573 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        TotalWages==0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr68Get() {
                
                #line 573 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        TotalWages==0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 586 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                              ErrorMessages[Constants.EIC_INFO_HAVE_EARNED_INCOME];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr69Get() {
                
                #line 586 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                              ErrorMessages[Constants.EIC_INFO_HAVE_EARNED_INCOME];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 597 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                            ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr71Get() {
                
                #line 597 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                            ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 593 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                              ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr72Get() {
                
                #line 593 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                              ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 625 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                        ErrorMessages[Constants.EIC_INFO_HAVE_EARNED_INCOME];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr74Get() {
                
                #line 625 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessages[Constants.EIC_INFO_HAVE_EARNED_INCOME];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 636 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                      ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr76Get() {
                
                #line 636 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 632 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                        ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr77Get() {
                
                #line 632 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalWages = ((double)(this.GetVariableValue((11 + locationsOffset))));
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
                if (((locationReferences[(offset + 11)].Name != "TotalWages") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext6 : F1040EZEICEligibilityRuleCheck_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Form1099OIDTotal;
            
            protected double F1099OIDTaxExemptInterest;
            
            protected double Form1099INTTotal;
            
            protected double F1099INTTaxExemptInterest;
            
            protected double InvestmentIncome;
            
            protected double TaxableInterestLimit;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr119GetTree() {
                
                #line 961 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr119Get() {
                
                #line 961 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr119Get() {
                this.GetValueTypeValues();
                return this.@__Expr119Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr119Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 961 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr119Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr119Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr120GetTree() {
                
                #line 971 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr120Get() {
                
                #line 971 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        F1099INTTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr120Get() {
                this.GetValueTypeValues();
                return this.@__Expr120Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr120Set(double value) {
                
                #line 971 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        F1099INTTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr120Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr120Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr121GetTree() {
                
                #line 966 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Form1099INTTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr121Get() {
                
                #line 966 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        Form1099INTTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr121Get() {
                this.GetValueTypeValues();
                return this.@__Expr121Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr121Set(double value) {
                
                #line 966 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        Form1099INTTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr121Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr121Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr123GetTree() {
                
                #line 999 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr123Get() {
                
                #line 999 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr123Get() {
                this.GetValueTypeValues();
                return this.@__Expr123Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr123Set(double value) {
                
                #line 999 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        F1099OIDTaxExemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr123Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr123Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr124GetTree() {
                
                #line 989 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr124Get() {
                
                #line 989 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr124Get() {
                this.GetValueTypeValues();
                return this.@__Expr124Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr124Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 989 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr124Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr124Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr125GetTree() {
                
                #line 994 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        Form1099OIDTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr125Get() {
                
                #line 994 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        Form1099OIDTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr125Get() {
                this.GetValueTypeValues();
                return this.@__Expr125Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr125Set(double value) {
                
                #line 994 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        Form1099OIDTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr125Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr125Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr127GetTree() {
                
                #line 1009 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  InvestmentIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr127Get() {
                
                #line 1009 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  InvestmentIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr127Get() {
                this.GetValueTypeValues();
                return this.@__Expr127Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr127Set(double value) {
                
                #line 1009 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                  InvestmentIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr127Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr127Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr130GetTree() {
                
                #line 1029 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                        ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr130Get() {
                
                #line 1029 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr130Get() {
                this.GetValueTypeValues();
                return this.@__Expr130Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr130Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 1029 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr130Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr130Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr133GetTree() {
                
                #line 1051 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr133Get() {
                
                #line 1051 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr133Get() {
                this.GetValueTypeValues();
                return this.@__Expr133Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr133Set(bool value) {
                
                #line 1051 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr133Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr133Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((12 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.InvestmentIncome = ((double)(this.GetVariableValue((15 + locationsOffset))));
                this.TaxableInterestLimit = ((double)(this.GetVariableValue((16 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((11 + locationsOffset), this.Form1099OIDTotal);
                this.SetVariableValue((12 + locationsOffset), this.F1099OIDTaxExemptInterest);
                this.SetVariableValue((13 + locationsOffset), this.Form1099INTTotal);
                this.SetVariableValue((14 + locationsOffset), this.F1099INTTaxExemptInterest);
                this.SetVariableValue((15 + locationsOffset), this.InvestmentIncome);
                this.SetVariableValue((16 + locationsOffset), this.TaxableInterestLimit);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 17))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 17);
                }
                expectedLocationsCount = 17;
                if (((locationReferences[(offset + 11)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "InvestmentIncome") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "TaxableInterestLimit") 
                            || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly : F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double Form1099OIDTotal;
            
            protected double F1099OIDTaxExemptInterest;
            
            protected double Form1099INTTotal;
            
            protected double F1099INTTaxExemptInterest;
            
            protected double InvestmentIncome;
            
            protected double TaxableInterestLimit;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr118GetTree() {
                
                #line 953 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  ((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr118Get() {
                
                #line 953 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  ((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr118Get() {
                this.GetValueTypeValues();
                return this.@__Expr118Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr122GetTree() {
                
                #line 981 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  ((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr122Get() {
                
                #line 981 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  ((Tax1040Object.Income != null) && (Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr122Get() {
                this.GetValueTypeValues();
                return this.@__Expr122Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr126GetTree() {
                
                #line 1014 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Form1099INTTotal + F1099INTTaxExemptInterest + Form1099OIDTotal + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr126Get() {
                
                #line 1014 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  Form1099INTTotal + F1099INTTaxExemptInterest + Form1099OIDTotal + F1099OIDTaxExemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr126Get() {
                this.GetValueTypeValues();
                return this.@__Expr126Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr128GetTree() {
                
                #line 1021 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  InvestmentIncome > TaxableInterestLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr128Get() {
                
                #line 1021 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  InvestmentIncome > TaxableInterestLimit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr128Get() {
                this.GetValueTypeValues();
                return this.@__Expr128Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr129GetTree() {
                
                #line 1034 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                        ErrorMessages[Constants.EIC_INFO_TAXPAYER_INVESTMENT_INCOME_LIMIT];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr129Get() {
                
                #line 1034 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessages[Constants.EIC_INFO_TAXPAYER_INVESTMENT_INCOME_LIMIT];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr129Get() {
                this.GetValueTypeValues();
                return this.@__Expr129Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr131GetTree() {
                
                #line 1045 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                      ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr131Get() {
                
                #line 1045 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr131Get() {
                this.GetValueTypeValues();
                return this.@__Expr131Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr132GetTree() {
                
                #line 1041 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                        ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr132Get() {
                
                #line 1041 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr132Get() {
                this.GetValueTypeValues();
                return this.@__Expr132Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Form1099OIDTotal = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.F1099OIDTaxExemptInterest = ((double)(this.GetVariableValue((12 + locationsOffset))));
                this.Form1099INTTotal = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.F1099INTTaxExemptInterest = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.InvestmentIncome = ((double)(this.GetVariableValue((15 + locationsOffset))));
                this.TaxableInterestLimit = ((double)(this.GetVariableValue((16 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 17))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 17);
                }
                expectedLocationsCount = 17;
                if (((locationReferences[(offset + 11)].Name != "Form1099OIDTotal") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "F1099OIDTaxExemptInterest") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Form1099INTTotal") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "F1099INTTaxExemptInterest") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "InvestmentIncome") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "TaxableInterestLimit") 
                            || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext7 : F1040EZEICEligibilityRuleCheck_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWages;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr135GetTree() {
                
                #line 1077 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr135Get() {
                
                #line 1077 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr135Get() {
                this.GetValueTypeValues();
                return this.@__Expr135Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr135Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 1077 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr135Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr135Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr136GetTree() {
                
                #line 1082 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                        TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr136Get() {
                
                #line 1082 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr136Get() {
                this.GetValueTypeValues();
                return this.@__Expr136Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr136Set(double value) {
                
                #line 1082 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr136Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr136Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr139GetTree() {
                
                #line 1097 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                              ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr139Get() {
                
                #line 1097 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                              ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr139Get() {
                this.GetValueTypeValues();
                return this.@__Expr139Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr139Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 1097 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                              ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr139Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr139Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr142GetTree() {
                
                #line 1119 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr142Get() {
                
                #line 1119 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                              IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr142Get() {
                this.GetValueTypeValues();
                return this.@__Expr142Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr142Set(bool value) {
                
                #line 1119 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                              IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr142Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr142Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr144GetTree() {
                
                #line 1136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                        ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr144Get() {
                
                #line 1136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr144Get() {
                this.GetValueTypeValues();
                return this.@__Expr144Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr144Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 1136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr144Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr144Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr147GetTree() {
                
                #line 1158 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        IsEICEligible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr147Get() {
                
                #line 1158 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        IsEICEligible;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr147Get() {
                this.GetValueTypeValues();
                return this.@__Expr147Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr147Set(bool value) {
                
                #line 1158 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                
                                        IsEICEligible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr147Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr147Set(value);
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
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "TotalWages") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly : F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalWages;
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZEICEligibilityRuleCheck_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 1069 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  Tax1040Object.Income != null && Tax1040Object.Income.W2Wages != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr134Get() {
                
                #line 1069 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                  Tax1040Object.Income != null && Tax1040Object.Income.W2Wages != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr134Get() {
                this.GetValueTypeValues();
                return this.@__Expr134Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr137GetTree() {
                
                #line 1089 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        TotalWages==0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr137Get() {
                
                #line 1089 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        TotalWages==0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr137Get() {
                this.GetValueTypeValues();
                return this.@__Expr137Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr138GetTree() {
                
                #line 1102 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                              ErrorMessages[Constants.EIC_INFO_HAVE_EARNED_INCOME];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr138Get() {
                
                #line 1102 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                              ErrorMessages[Constants.EIC_INFO_HAVE_EARNED_INCOME];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr138Get() {
                this.GetValueTypeValues();
                return this.@__Expr138Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr140GetTree() {
                
                #line 1113 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                            ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr140Get() {
                
                #line 1113 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                            ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr140Get() {
                this.GetValueTypeValues();
                return this.@__Expr140Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr141GetTree() {
                
                #line 1109 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                              ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr141Get() {
                
                #line 1109 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                              ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr141Get() {
                this.GetValueTypeValues();
                return this.@__Expr141Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr143GetTree() {
                
                #line 1141 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                        ErrorMessages[Constants.EIC_INFO_HAVE_EARNED_INCOME];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr143Get() {
                
                #line 1141 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessages[Constants.EIC_INFO_HAVE_EARNED_INCOME];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr143Get() {
                this.GetValueTypeValues();
                return this.@__Expr143Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr145GetTree() {
                
                #line 1152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                      ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr145Get() {
                
                #line 1152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                      ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr145Get() {
                this.GetValueTypeValues();
                return this.@__Expr145Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr146GetTree() {
                
                #line 1148 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                        ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr146Get() {
                
                #line 1148 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZEICELIGIBILITYRULECHECK.XAML"
                return 
                                        ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr146Get() {
                this.GetValueTypeValues();
                return this.@__Expr146Get();
            }
            
            protected override void GetValueTypeValues() {
                this.TotalWages = ((double)(this.GetVariableValue((11 + locationsOffset))));
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
                if (((locationReferences[(offset + 11)].Name != "TotalWages") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZEICEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
