namespace Tax1040WorkFlow.WorkFlow.Activities {
    
    #line 21 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1099OIDBusinessRuleValidation.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1099OIDBusinessRuleValidation.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 22 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1099OIDBusinessRuleValidation.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1099OIDBusinessRuleValidation.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1099OIDBusinessRuleValidation.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1099OIDBusinessRuleValidation.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 23 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1099OIDBusinessRuleValidation.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1099OIDBusinessRuleValidation.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1099OIDBusinessRuleValidation.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1099OIDBusinessRuleValidation.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1099OIDBusinessRuleValidation.xaml"
    using JTL.Tax1040.Core.Object;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1099OIDBusinessRuleValidation.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class F1099OIDBusinessValidation : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly valDataContext0 = ((F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly valDataContext1 = ((F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly valDataContext2 = ((F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly valDataContext3 = ((F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext4 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext5 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1099OIDBusinessValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext6 = ((F1099OIDBusinessValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext6.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext7 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1099OIDBusinessValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext8 = ((F1099OIDBusinessValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext8.GetLocation<long>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext9 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext10 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext11 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext12 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1099OIDBusinessValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext13 = ((F1099OIDBusinessValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext13.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext14 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1099OIDBusinessValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext15 = ((F1099OIDBusinessValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext15.GetLocation<long>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext16 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext17 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext18 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext19 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1099OIDBusinessValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext20 = ((F1099OIDBusinessValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext20.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext21 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1099OIDBusinessValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext22 = ((F1099OIDBusinessValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext22.GetLocation<long>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext23 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext24 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext25 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext26 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1099OIDBusinessValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext27 = ((F1099OIDBusinessValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext27.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext28 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1099OIDBusinessValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext29 = ((F1099OIDBusinessValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext29.GetLocation<long>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext30 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext31 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext32 = ((F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext33 = ((F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1099OIDBusinessValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext5_ForReadOnly valDataContext34 = ((F1099OIDBusinessValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1099OIDBusinessValidation_TypedDataContext5(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext5 refDataContext35 = ((F1099OIDBusinessValidation_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext35.GetLocation<double>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext36 = ((F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext37 = ((F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1099OIDBusinessValidation_TypedDataContext4(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext4 refDataContext38 = ((F1099OIDBusinessValidation_TypedDataContext4)(cachedCompiledDataContext[6]));
                return refDataContext38.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext39 = ((F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1099OIDBusinessValidation_TypedDataContext4(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext4 refDataContext40 = ((F1099OIDBusinessValidation_TypedDataContext4)(cachedCompiledDataContext[6]));
                return refDataContext40.GetLocation<long>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext41 = ((F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext42 = ((F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext43 = ((F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1099OIDBusinessValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1099OIDBusinessValidation_TypedDataContext3(locations, activityContext, true);
                }
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext44 = ((F1099OIDBusinessValidation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext44.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
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
                F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly valDataContext0 = new F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly valDataContext1 = new F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly valDataContext2 = new F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly valDataContext3 = new F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext4 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext5 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext6 = new F1099OIDBusinessValidation_TypedDataContext3(locations, true);
                return refDataContext6.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext7 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext8 = new F1099OIDBusinessValidation_TypedDataContext3(locations, true);
                return refDataContext8.GetLocation<long>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext9 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext10 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext11 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext12 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext13 = new F1099OIDBusinessValidation_TypedDataContext3(locations, true);
                return refDataContext13.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext14 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext15 = new F1099OIDBusinessValidation_TypedDataContext3(locations, true);
                return refDataContext15.GetLocation<long>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext16 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext17 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext18 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext19 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext20 = new F1099OIDBusinessValidation_TypedDataContext3(locations, true);
                return refDataContext20.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext21 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext22 = new F1099OIDBusinessValidation_TypedDataContext3(locations, true);
                return refDataContext22.GetLocation<long>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set);
            }
            if ((expressionId == 23)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext23 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext24 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext25 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext26 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext27 = new F1099OIDBusinessValidation_TypedDataContext3(locations, true);
                return refDataContext27.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext28 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext29 = new F1099OIDBusinessValidation_TypedDataContext3(locations, true);
                return refDataContext29.GetLocation<long>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext30 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext31 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext32 = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext33 = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                F1099OIDBusinessValidation_TypedDataContext5_ForReadOnly valDataContext34 = new F1099OIDBusinessValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                F1099OIDBusinessValidation_TypedDataContext5 refDataContext35 = new F1099OIDBusinessValidation_TypedDataContext5(locations, true);
                return refDataContext35.GetLocation<double>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext36 = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext37 = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                F1099OIDBusinessValidation_TypedDataContext4 refDataContext38 = new F1099OIDBusinessValidation_TypedDataContext4(locations, true);
                return refDataContext38.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
            }
            if ((expressionId == 39)) {
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext39 = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                F1099OIDBusinessValidation_TypedDataContext4 refDataContext40 = new F1099OIDBusinessValidation_TypedDataContext4(locations, true);
                return refDataContext40.GetLocation<long>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set);
            }
            if ((expressionId == 41)) {
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext41 = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly valDataContext42 = new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly valDataContext43 = new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                F1099OIDBusinessValidation_TypedDataContext3 refDataContext44 = new F1099OIDBusinessValidation_TypedDataContext3(locations, true);
                return refDataContext44.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object != null) && (Tax1040Object.Income != null))") 
                        && (F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID." +
                            "Any()))") 
                        && (F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.Form1099OID") 
                        && (F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099OID.EarlyWithdrawalPenalty.HasValue && Form1099OID.EarlyWithdrawalPenalty" +
                            ".Value > 0") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.OID__EARLY_WITHDRAWAL_PENALTY_BR]") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1099OIDBusinessValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099OID.Form1099OIDId") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage.FormId") 
                        && (F1099OIDBusinessValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"Form1099OID.FederalTaxWithHoldingAmount.HasValue && Form1099OID.FederalTaxWithHoldingAmount.Value > ((Form1099OID.OriginalIssueDiscount.HasValue ? Form1099OID.OriginalIssueDiscount.Value:0) + (Form1099OID.OtherPeriodicInterest.HasValue ? Form1099OID.OtherPeriodicInterest.Value:0) + (Form1099OID.USTreasuryObligations.HasValue ? Form1099OID.USTreasuryObligations.Value:0))") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.OID_FEDERAL_WITHHOLDING_BR]") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1099OIDBusinessValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099OID.Form1099OIDId") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage.FormId") 
                        && (F1099OIDBusinessValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099OID.ForeignTaxPaid.HasValue && Form1099OID.ForeignTaxPaid.Value > 0") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.OID_FOREIGN_TAX_WITHHELD_BR]") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1099OIDBusinessValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099OID.Form1099OIDId") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage.FormId") 
                        && (F1099OIDBusinessValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099OID.InvestmentExpenses.HasValue && Form1099OID.InvestmentExpenses.Value >" +
                            " 0") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.OID_INVESTMENT_EXPENSES_BR]") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1099OIDBusinessValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099OID.Form1099OIDId") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage.FormId") 
                        && (F1099OIDBusinessValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Form1099OID.Form1099StateInfo != null) && (Form1099OID.Form1099StateInfo.Any())" +
                            ")") 
                        && (F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099OID.Form1099StateInfo") 
                        && (F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Form1099StateInfo.StateTaxWithholdingAmount.HasValue ? Form1099StateInfo.StateTa" +
                            "xWithholdingAmount.Value:0) + StateTaxWithholdingAmountTotal") 
                        && (F1099OIDBusinessValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "StateTaxWithholdingAmountTotal") 
                        && (F1099OIDBusinessValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"StateTaxWithholdingAmountTotal > ((Form1099OID.OriginalIssueDiscount.HasValue?Form1099OID.OriginalIssueDiscount.Value:0) + (Form1099OID.OtherPeriodicInterest.HasValue?Form1099OID.OtherPeriodicInterest.Value:0) + (Form1099OID.USTreasuryObligations.HasValue?Form1099OID.USTreasuryObligations.Value:0))") 
                        && (F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.OID_STATE_TAX_WITHHELD_BR]") 
                        && (F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1099OIDBusinessValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Form1099OID.Form1099OIDId") 
                        && (F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage.FormId") 
                        && (F1099OIDBusinessValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (F1099OIDBusinessValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
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
                return new F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new F1099OIDBusinessValidation_TypedDataContext3(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new F1099OIDBusinessValidation_TypedDataContext3(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new F1099OIDBusinessValidation_TypedDataContext3(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new F1099OIDBusinessValidation_TypedDataContext3(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new F1099OIDBusinessValidation_TypedDataContext3(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new F1099OIDBusinessValidation_TypedDataContext3(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new F1099OIDBusinessValidation_TypedDataContext3(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new F1099OIDBusinessValidation_TypedDataContext3(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new F1099OIDBusinessValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new F1099OIDBusinessValidation_TypedDataContext5(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new F1099OIDBusinessValidation_TypedDataContext4(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new F1099OIDBusinessValidation_TypedDataContext4(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new F1099OIDBusinessValidation_TypedDataContext3(locationReferences).@__Expr44GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1099OIDBusinessValidation_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1099OIDBusinessValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1099OIDBusinessValidation_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1099OIDBusinessValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1099OIDBusinessValidation_TypedDataContext1 : F1099OIDBusinessValidation_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1099OIDBusinessValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                return F1099OIDBusinessValidation_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1099OIDBusinessValidation_TypedDataContext1_ForReadOnly : F1099OIDBusinessValidation_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1099OIDBusinessValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                return F1099OIDBusinessValidation_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1099OIDBusinessValidation_TypedDataContext2 : F1099OIDBusinessValidation_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1099OIDBusinessValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
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
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 2)].Name != "Form1099OID") 
                            || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "ErrorMessage") 
                            || (locationReferences[(offset + 3)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "ErrorMessageList") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                return F1099OIDBusinessValidation_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly : F1099OIDBusinessValidation_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((2 + locationsOffset))));
                }
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
                
                #line 63 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
          Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr0Get() {
                
                #line 63 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
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
                
                #line 70 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          ((Tax1040Object != null) && (Tax1040Object.Income != null));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 70 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
          ((Tax1040Object != null) && (Tax1040Object.Income != null));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 77 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              ((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Any()));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr2Get() {
                
                #line 77 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
              ((Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Any()));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 84 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099OID>>> expression = () => 
                  Tax1040Object.Income.Form1099OID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099OID> @__Expr3Get() {
                
                #line 84 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                  Tax1040Object.Income.Form1099OID;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099OID> ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
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
                if (((locationReferences[(offset + 2)].Name != "Form1099OID") 
                            || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "ErrorMessage") 
                            || (locationReferences[(offset + 3)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "ErrorMessageList") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                return F1099OIDBusinessValidation_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1099OIDBusinessValidation_TypedDataContext3 : F1099OIDBusinessValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1099OIDBusinessValidation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected new JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((5 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 104 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr6Get() {
                
                #line 104 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 104 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                
                                ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 116 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                                ErrorMessage.FormId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr8Get() {
                
                #line 116 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                ErrorMessage.FormId;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(long value) {
                
                #line 116 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                
                                ErrorMessage.FormId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(long value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 150 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr13Get() {
                
                #line 150 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 150 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                
                              ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 162 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                              ErrorMessage.FormId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr15Get() {
                
                #line 162 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              ErrorMessage.FormId;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(long value) {
                
                #line 162 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                
                              ErrorMessage.FormId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(long value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 195 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr20Get() {
                
                #line 195 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 195 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                
                              ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 207 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                              ErrorMessage.FormId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr22Get() {
                
                #line 207 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              ErrorMessage.FormId;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr22Set(long value) {
                
                #line 207 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                
                              ErrorMessage.FormId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr22Set(long value) {
                this.GetValueTypeValues();
                this.@__Expr22Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr27Get() {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
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
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                
                              ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 252 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                              ErrorMessage.FormId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr29Get() {
                
                #line 252 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              ErrorMessage.FormId;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(long value) {
                
                #line 252 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                
                              ErrorMessage.FormId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(long value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                        Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr44Get() {
                
                #line 363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                        Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr44Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                
                #line 363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                
                        Tax1040Object.ErrorMessages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr44Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                this.GetValueTypeValues();
                this.@__Expr44Set(value);
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
                if (((locationReferences[(offset + 5)].Name != "Form1099OID") 
                            || (locationReferences[(offset + 5)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                    return false;
                }
                return F1099OIDBusinessValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly : F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected new JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((5 + locationsOffset))));
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
                
                #line 96 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Form1099OID.EarlyWithdrawalPenalty.HasValue && Form1099OID.EarlyWithdrawalPenalty.Value > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 96 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                          Form1099OID.EarlyWithdrawalPenalty.HasValue && Form1099OID.EarlyWithdrawalPenalty.Value > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 109 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessages[Constants.OID__EARLY_WITHDRAWAL_PENALTY_BR];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr5Get() {
                
                #line 109 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                ErrorMessages[Constants.OID__EARLY_WITHDRAWAL_PENALTY_BR];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 121 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                                Form1099OID.Form1099OIDId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr7Get() {
                
                #line 121 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                Form1099OID.Form1099OIDId;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 132 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                              ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr9Get() {
                
                #line 132 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 128 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr10Get() {
                
                #line 128 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Form1099OID.FederalTaxWithHoldingAmount.HasValue && Form1099OID.FederalTaxWithHoldingAmount.Value > ((Form1099OID.OriginalIssueDiscount.HasValue ? Form1099OID.OriginalIssueDiscount.Value:0) + (Form1099OID.OtherPeriodicInterest.HasValue ? Form1099OID.OtherPeriodicInterest.Value:0) + (Form1099OID.USTreasuryObligations.HasValue ? Form1099OID.USTreasuryObligations.Value:0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr11Get() {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                        Form1099OID.FederalTaxWithHoldingAmount.HasValue && Form1099OID.FederalTaxWithHoldingAmount.Value > ((Form1099OID.OriginalIssueDiscount.HasValue ? Form1099OID.OriginalIssueDiscount.Value:0) + (Form1099OID.OtherPeriodicInterest.HasValue ? Form1099OID.OtherPeriodicInterest.Value:0) + (Form1099OID.USTreasuryObligations.HasValue ? Form1099OID.USTreasuryObligations.Value:0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 155 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessages[Constants.OID_FEDERAL_WITHHOLDING_BR];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr12Get() {
                
                #line 155 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              ErrorMessages[Constants.OID_FEDERAL_WITHHOLDING_BR];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 167 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                              Form1099OID.Form1099OIDId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr14Get() {
                
                #line 167 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              Form1099OID.Form1099OIDId;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 178 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                            ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr16Get() {
                
                #line 178 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
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
                
                #line 174 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr17Get() {
                
                #line 174 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 187 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Form1099OID.ForeignTaxPaid.HasValue && Form1099OID.ForeignTaxPaid.Value > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr18Get() {
                
                #line 187 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                        Form1099OID.ForeignTaxPaid.HasValue && Form1099OID.ForeignTaxPaid.Value > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 200 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessages[Constants.OID_FOREIGN_TAX_WITHHELD_BR];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr19Get() {
                
                #line 200 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              ErrorMessages[Constants.OID_FOREIGN_TAX_WITHHELD_BR];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 212 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                              Form1099OID.Form1099OIDId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr21Get() {
                
                #line 212 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              Form1099OID.Form1099OIDId;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 223 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                            ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr23Get() {
                
                #line 223 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                            ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 219 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr24Get() {
                
                #line 219 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 232 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Form1099OID.InvestmentExpenses.HasValue && Form1099OID.InvestmentExpenses.Value > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr25Get() {
                
                #line 232 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                        Form1099OID.InvestmentExpenses.HasValue && Form1099OID.InvestmentExpenses.Value > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 245 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessages[Constants.OID_INVESTMENT_EXPENSES_BR];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr26Get() {
                
                #line 245 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              ErrorMessages[Constants.OID_INVESTMENT_EXPENSES_BR];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 257 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                              Form1099OID.Form1099OIDId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr28Get() {
                
                #line 257 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              Form1099OID.Form1099OIDId;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 268 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                            ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr30Get() {
                
                #line 268 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                            ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 264 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr31Get() {
                
                #line 264 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                              ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 368 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                        ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr43Get() {
                
                #line 368 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                        ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
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
                if (((locationReferences[(offset + 5)].Name != "Form1099OID") 
                            || (locationReferences[(offset + 5)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                    return false;
                }
                return F1099OIDBusinessValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1099OIDBusinessValidation_TypedDataContext4 : F1099OIDBusinessValidation_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double StateTaxWithholdingAmountTotal;
            
            public F1099OIDBusinessValidation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099StateInformation Form1099StateInfo {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099StateInformation)(this.GetVariableValue((6 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 322 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr38Get() {
                
                #line 322 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr38Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                
                #line 322 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                
                                      ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr38Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr38Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                                      ErrorMessage.FormId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr40Get() {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                      ErrorMessage.FormId;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr40Set(long value) {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                
                                      ErrorMessage.FormId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr40Set(long value) {
                this.GetValueTypeValues();
                this.@__Expr40Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.StateTaxWithholdingAmountTotal = ((double)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((7 + locationsOffset), this.StateTaxWithholdingAmountTotal);
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
                if (((locationReferences[(offset + 6)].Name != "Form1099StateInfo") 
                            || (locationReferences[(offset + 6)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099StateInformation)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "StateTaxWithholdingAmountTotal") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                return F1099OIDBusinessValidation_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly : F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double StateTaxWithholdingAmountTotal;
            
            public F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.Form1099StateInformation Form1099StateInfo {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099StateInformation)(this.GetVariableValue((6 + locationsOffset))));
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
                
                #line 282 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          ((Form1099OID.Form1099StateInfo != null) && (Form1099OID.Form1099StateInfo.Any()));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr32Get() {
                
                #line 282 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                          ((Form1099OID.Form1099StateInfo != null) && (Form1099OID.Form1099StateInfo.Any()));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 290 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099StateInformation>>> expression = () => 
                                Form1099OID.Form1099StateInfo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099StateInformation> @__Expr33Get() {
                
                #line 290 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                Form1099OID.Form1099StateInfo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099StateInformation> ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 314 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                StateTaxWithholdingAmountTotal > ((Form1099OID.OriginalIssueDiscount.HasValue?Form1099OID.OriginalIssueDiscount.Value:0) + (Form1099OID.OtherPeriodicInterest.HasValue?Form1099OID.OtherPeriodicInterest.Value:0) + (Form1099OID.USTreasuryObligations.HasValue?Form1099OID.USTreasuryObligations.Value:0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr36Get() {
                
                #line 314 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                StateTaxWithholdingAmountTotal > ((Form1099OID.OriginalIssueDiscount.HasValue?Form1099OID.OriginalIssueDiscount.Value:0) + (Form1099OID.OtherPeriodicInterest.HasValue?Form1099OID.OtherPeriodicInterest.Value:0) + (Form1099OID.USTreasuryObligations.HasValue?Form1099OID.USTreasuryObligations.Value:0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessages[Constants.OID_STATE_TAX_WITHHELD_BR];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr37Get() {
                
                #line 327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                      ErrorMessages[Constants.OID_STATE_TAX_WITHHELD_BR];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                                      Form1099OID.Form1099OIDId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr39Get() {
                
                #line 339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                      Form1099OID.Form1099OIDId;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 350 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                    ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr41Get() {
                
                #line 350 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                    ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 346 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr42Get() {
                
                #line 346 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            protected override void GetValueTypeValues() {
                this.StateTaxWithholdingAmountTotal = ((double)(this.GetVariableValue((7 + locationsOffset))));
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
                if (((locationReferences[(offset + 6)].Name != "Form1099StateInfo") 
                            || (locationReferences[(offset + 6)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099StateInformation)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "StateTaxWithholdingAmountTotal") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                return F1099OIDBusinessValidation_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1099OIDBusinessValidation_TypedDataContext5 : F1099OIDBusinessValidation_TypedDataContext4 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1099OIDBusinessValidation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected new JTL.Tax1040.BusinessObject.Form1099StateInformation Form1099StateInfo {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099StateInformation)(this.GetVariableValue((8 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 300 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    StateTaxWithholdingAmountTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr35Get() {
                
                #line 300 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                    StateTaxWithholdingAmountTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(double value) {
                
                #line 300 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                
                                    StateTaxWithholdingAmountTotal = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
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
                if (((locationReferences[(offset + 8)].Name != "Form1099StateInfo") 
                            || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099StateInformation)))) {
                    return false;
                }
                return F1099OIDBusinessValidation_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1099OIDBusinessValidation_TypedDataContext5_ForReadOnly : F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1099OIDBusinessValidation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1099OIDBusinessValidation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected new JTL.Tax1040.BusinessObject.Form1099StateInformation Form1099StateInfo {
                get {
                    return ((JTL.Tax1040.BusinessObject.Form1099StateInformation)(this.GetVariableValue((8 + locationsOffset))));
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
                
                #line 305 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    (Form1099StateInfo.StateTaxWithholdingAmount.HasValue ? Form1099StateInfo.StateTaxWithholdingAmount.Value:0) + StateTaxWithholdingAmountTotal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr34Get() {
                
                #line 305 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1099OIDBUSINESSRULEVALIDATION.XAML"
                return 
                                    (Form1099StateInfo.StateTaxWithholdingAmount.HasValue ? Form1099StateInfo.StateTaxWithholdingAmount.Value:0) + StateTaxWithholdingAmountTotal;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
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
                if (((locationReferences[(offset + 8)].Name != "Form1099StateInfo") 
                            || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099StateInformation)))) {
                    return false;
                }
                return F1099OIDBusinessValidation_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
