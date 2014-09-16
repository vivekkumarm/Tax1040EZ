
#line 22 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using System;

#line default
#line hidden

#line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using System.Collections;

#line default
#line hidden

#line 23 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using System.Collections.Generic;

#line default
#line hidden

#line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using System.Activities;

#line default
#line hidden

#line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using System.Activities.Expressions;

#line default
#line hidden

#line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using System.Activities.Statements;

#line default
#line hidden

#line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using System.Data;

#line default
#line hidden

#line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using System.Linq;

#line default
#line hidden

#line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using System.Text;

#line default
#line hidden

#line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using JTL.Tax1040.BusinessObject;

#line default
#line hidden

#line 28 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using Tax1040WorkFlow;

#line default
#line hidden

#line 29 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using JTL.Tax1040.Core.Object;

#line default
#line hidden

#line 30 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using JTL.Tax1040.Core.Process;

#line default
#line hidden

#line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EzEligibilityRuleCheck.xaml"
using System.Activities.XamlIntegration;

#line default
#line hidden


public partial class F1040EzEligibilityRuleCheck : System.Activities.XamlIntegration.ICompiledExpressionRoot {
    
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
            this.dataContextActivities = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
        }
        if ((expressionId == 0)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext0 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext0.ValueType___Expr0Get();
        }
        if ((expressionId == 1)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext1 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext1.ValueType___Expr1Get();
        }
        if ((expressionId == 2)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext2 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext2.ValueType___Expr2Get();
        }
        if ((expressionId == 3)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext3 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext3.ValueType___Expr3Get();
        }
        if ((expressionId == 4)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext4 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext4.ValueType___Expr4Get();
        }
        if ((expressionId == 5)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext5 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext5.ValueType___Expr5Get();
        }
        if ((expressionId == 6)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext6 = ((F1040EzEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext6.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 7)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext7 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext7.ValueType___Expr7Get();
        }
        if ((expressionId == 8)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext8 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext8.ValueType___Expr8Get();
        }
        if ((expressionId == 9)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext9 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext9.ValueType___Expr9Get();
        }
        if ((expressionId == 10)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext10 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext10.ValueType___Expr10Get();
        }
        if ((expressionId == 11)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext11 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext11.ValueType___Expr11Get();
        }
        if ((expressionId == 12)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext12 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext12.ValueType___Expr12Get();
        }
        if ((expressionId == 13)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext13 = ((F1040EzEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext13.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 14)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext14 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext14.ValueType___Expr14Get();
        }
        if ((expressionId == 15)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext15 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext15.ValueType___Expr15Get();
        }
        if ((expressionId == 16)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[2] == null)) {
                cachedCompiledDataContext[2] = new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext16 = ((F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
            return valDataContext16.ValueType___Expr16Get();
        }
        if ((expressionId == 17)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[2] == null)) {
                cachedCompiledDataContext[2] = new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext17 = ((F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
            return valDataContext17.ValueType___Expr17Get();
        }
        if ((expressionId == 18)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[2] == null)) {
                cachedCompiledDataContext[2] = new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext18 = ((F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
            return valDataContext18.ValueType___Expr18Get();
        }
        if ((expressionId == 19)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[2] == null)) {
                cachedCompiledDataContext[2] = new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext19 = ((F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
            return valDataContext19.ValueType___Expr19Get();
        }
        if ((expressionId == 20)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[3] == null)) {
                cachedCompiledDataContext[3] = new F1040EzEligibilityRuleCheck_TypedDataContext3(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext3 refDataContext20 = ((F1040EzEligibilityRuleCheck_TypedDataContext3)(cachedCompiledDataContext[3]));
            return refDataContext20.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 21)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[2] == null)) {
                cachedCompiledDataContext[2] = new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext21 = ((F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
            return valDataContext21.ValueType___Expr21Get();
        }
        if ((expressionId == 22)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[2] == null)) {
                cachedCompiledDataContext[2] = new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext22 = ((F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
            return valDataContext22.ValueType___Expr22Get();
        }
        if ((expressionId == 23)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext23 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext23.ValueType___Expr23Get();
        }
        if ((expressionId == 24)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext24 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext24.ValueType___Expr24Get();
        }
        if ((expressionId == 25)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext25 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext25.ValueType___Expr25Get();
        }
        if ((expressionId == 26)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext26 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext26.ValueType___Expr26Get();
        }
        if ((expressionId == 27)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext27 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext27.ValueType___Expr27Get();
        }
        if ((expressionId == 28)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext28 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext28.ValueType___Expr28Get();
        }
        if ((expressionId == 29)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext29 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext29.ValueType___Expr29Get();
        }
        if ((expressionId == 30)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext30 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext30.ValueType___Expr30Get();
        }
        if ((expressionId == 31)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext31 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext31.ValueType___Expr31Get();
        }
        if ((expressionId == 32)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[5] == null)) {
                cachedCompiledDataContext[5] = new F1040EzEligibilityRuleCheck_TypedDataContext4(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4 refDataContext32 = ((F1040EzEligibilityRuleCheck_TypedDataContext4)(cachedCompiledDataContext[5]));
            return refDataContext32.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 33)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext33 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext33.ValueType___Expr33Get();
        }
        if ((expressionId == 34)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext34 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext34.ValueType___Expr34Get();
        }
        if ((expressionId == 35)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext35 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext35.ValueType___Expr35Get();
        }
        if ((expressionId == 36)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext36 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext36.ValueType___Expr36Get();
        }
        if ((expressionId == 37)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[5] == null)) {
                cachedCompiledDataContext[5] = new F1040EzEligibilityRuleCheck_TypedDataContext4(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4 refDataContext37 = ((F1040EzEligibilityRuleCheck_TypedDataContext4)(cachedCompiledDataContext[5]));
            return refDataContext37.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 38)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext38 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext38.ValueType___Expr38Get();
        }
        if ((expressionId == 39)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext39 = ((F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
            return valDataContext39.ValueType___Expr39Get();
        }
        if ((expressionId == 40)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext40 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext40.ValueType___Expr40Get();
        }
        if ((expressionId == 41)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext41 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext41.ValueType___Expr41Get();
        }
        if ((expressionId == 42)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext42 = ((F1040EzEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext42.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 43)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext43 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext43.ValueType___Expr43Get();
        }
        if ((expressionId == 44)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext44 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext44.ValueType___Expr44Get();
        }
        if ((expressionId == 45)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext45 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext45.ValueType___Expr45Get();
        }
        if ((expressionId == 46)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext46 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext46.ValueType___Expr46Get();
        }
        if ((expressionId == 47)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext47 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext47.ValueType___Expr47Get();
        }
        if ((expressionId == 48)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext48 = ((F1040EzEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext48.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 49)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext49 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext49.ValueType___Expr49Get();
        }
        if ((expressionId == 50)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext50 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext50.ValueType___Expr50Get();
        }
        if ((expressionId == 51)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext51 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext51.ValueType___Expr51Get();
        }
        if ((expressionId == 52)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext52 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext52.ValueType___Expr52Get();
        }
        if ((expressionId == 53)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext53 = ((F1040EzEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext53.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 54)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext54 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext54.ValueType___Expr54Get();
        }
        if ((expressionId == 55)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext55 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext55.ValueType___Expr55Get();
        }
        if ((expressionId == 56)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext56 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext56.ValueType___Expr56Get();
        }
        if ((expressionId == 57)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext57 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext57.ValueType___Expr57Get();
        }
        if ((expressionId == 58)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext58 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext58.ValueType___Expr58Get();
        }
        if ((expressionId == 59)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext59 = ((F1040EzEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext59.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 60)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext60 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext60.ValueType___Expr60Get();
        }
        if ((expressionId == 61)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext61 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext61.ValueType___Expr61Get();
        }
        if ((expressionId == 62)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext62 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext62.ValueType___Expr62Get();
        }
        if ((expressionId == 63)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext63 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext63.ValueType___Expr63Get();
        }
        if ((expressionId == 64)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext64 = ((F1040EzEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext64.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 65)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext65 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext65.ValueType___Expr65Get();
        }
        if ((expressionId == 66)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext66 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext66.ValueType___Expr66Get();
        }
        if ((expressionId == 67)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext67 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext67.ValueType___Expr67Get();
        }
        if ((expressionId == 68)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext68 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext68.ValueType___Expr68Get();
        }
        if ((expressionId == 69)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext69 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext69.ValueType___Expr69Get();
        }
        if ((expressionId == 70)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext70 = ((F1040EzEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext70.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 71)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext71 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext71.ValueType___Expr71Get();
        }
        if ((expressionId == 72)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext72 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext72.ValueType___Expr72Get();
        }
        if ((expressionId == 73)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext73 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext73.ValueType___Expr73Get();
        }
        if ((expressionId == 74)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext74 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext74.ValueType___Expr74Get();
        }
        if ((expressionId == 75)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext75 = ((F1040EzEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext75.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 76)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext76 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext76.ValueType___Expr76Get();
        }
        if ((expressionId == 77)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext77 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext77.ValueType___Expr77Get();
        }
        if ((expressionId == 78)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext78 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext78.ValueType___Expr78Get();
        }
        if ((expressionId == 79)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext79 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext79.ValueType___Expr79Get();
        }
        if ((expressionId == 80)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext80 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext80.ValueType___Expr80Get();
        }
        if ((expressionId == 81)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext81 = ((F1040EzEligibilityRuleCheck_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext81.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 82)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext82 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext82.ValueType___Expr82Get();
        }
        if ((expressionId == 83)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext83 = ((F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext83.ValueType___Expr83Get();
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
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext0 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext0.ValueType___Expr0Get();
        }
        if ((expressionId == 1)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext1 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext1.ValueType___Expr1Get();
        }
        if ((expressionId == 2)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext2 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext2.ValueType___Expr2Get();
        }
        if ((expressionId == 3)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext3 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext3.ValueType___Expr3Get();
        }
        if ((expressionId == 4)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext4 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext4.ValueType___Expr4Get();
        }
        if ((expressionId == 5)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext5 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext5.ValueType___Expr5Get();
        }
        if ((expressionId == 6)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext6 = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, true);
            return refDataContext6.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
        }
        if ((expressionId == 7)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext7 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext7.ValueType___Expr7Get();
        }
        if ((expressionId == 8)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext8 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext8.ValueType___Expr8Get();
        }
        if ((expressionId == 9)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext9 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext9.ValueType___Expr9Get();
        }
        if ((expressionId == 10)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext10 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext10.ValueType___Expr10Get();
        }
        if ((expressionId == 11)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext11 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext11.ValueType___Expr11Get();
        }
        if ((expressionId == 12)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext12 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext12.ValueType___Expr12Get();
        }
        if ((expressionId == 13)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext13 = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, true);
            return refDataContext13.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
        }
        if ((expressionId == 14)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext14 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext14.ValueType___Expr14Get();
        }
        if ((expressionId == 15)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext15 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext15.ValueType___Expr15Get();
        }
        if ((expressionId == 16)) {
            F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext16 = new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
            return valDataContext16.ValueType___Expr16Get();
        }
        if ((expressionId == 17)) {
            F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext17 = new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
            return valDataContext17.ValueType___Expr17Get();
        }
        if ((expressionId == 18)) {
            F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext18 = new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
            return valDataContext18.ValueType___Expr18Get();
        }
        if ((expressionId == 19)) {
            F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext19 = new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
            return valDataContext19.ValueType___Expr19Get();
        }
        if ((expressionId == 20)) {
            F1040EzEligibilityRuleCheck_TypedDataContext3 refDataContext20 = new F1040EzEligibilityRuleCheck_TypedDataContext3(locations, true);
            return refDataContext20.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
        }
        if ((expressionId == 21)) {
            F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext21 = new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
            return valDataContext21.ValueType___Expr21Get();
        }
        if ((expressionId == 22)) {
            F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly valDataContext22 = new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locations, true);
            return valDataContext22.ValueType___Expr22Get();
        }
        if ((expressionId == 23)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext23 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext23.ValueType___Expr23Get();
        }
        if ((expressionId == 24)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext24 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext24.ValueType___Expr24Get();
        }
        if ((expressionId == 25)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext25 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext25.ValueType___Expr25Get();
        }
        if ((expressionId == 26)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext26 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext26.ValueType___Expr26Get();
        }
        if ((expressionId == 27)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext27 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext27.ValueType___Expr27Get();
        }
        if ((expressionId == 28)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext28 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext28.ValueType___Expr28Get();
        }
        if ((expressionId == 29)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext29 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext29.ValueType___Expr29Get();
        }
        if ((expressionId == 30)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext30 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext30.ValueType___Expr30Get();
        }
        if ((expressionId == 31)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext31 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext31.ValueType___Expr31Get();
        }
        if ((expressionId == 32)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4 refDataContext32 = new F1040EzEligibilityRuleCheck_TypedDataContext4(locations, true);
            return refDataContext32.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
        }
        if ((expressionId == 33)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext33 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext33.ValueType___Expr33Get();
        }
        if ((expressionId == 34)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext34 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext34.ValueType___Expr34Get();
        }
        if ((expressionId == 35)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext35 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext35.ValueType___Expr35Get();
        }
        if ((expressionId == 36)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext36 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext36.ValueType___Expr36Get();
        }
        if ((expressionId == 37)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4 refDataContext37 = new F1040EzEligibilityRuleCheck_TypedDataContext4(locations, true);
            return refDataContext37.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set);
        }
        if ((expressionId == 38)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext38 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext38.ValueType___Expr38Get();
        }
        if ((expressionId == 39)) {
            F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly valDataContext39 = new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext39.ValueType___Expr39Get();
        }
        if ((expressionId == 40)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext40 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext40.ValueType___Expr40Get();
        }
        if ((expressionId == 41)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext41 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext41.ValueType___Expr41Get();
        }
        if ((expressionId == 42)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext42 = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, true);
            return refDataContext42.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
        }
        if ((expressionId == 43)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext43 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext43.ValueType___Expr43Get();
        }
        if ((expressionId == 44)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext44 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext44.ValueType___Expr44Get();
        }
        if ((expressionId == 45)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext45 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext45.ValueType___Expr45Get();
        }
        if ((expressionId == 46)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext46 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext46.ValueType___Expr46Get();
        }
        if ((expressionId == 47)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext47 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext47.ValueType___Expr47Get();
        }
        if ((expressionId == 48)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext48 = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, true);
            return refDataContext48.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set);
        }
        if ((expressionId == 49)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext49 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext49.ValueType___Expr49Get();
        }
        if ((expressionId == 50)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext50 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext50.ValueType___Expr50Get();
        }
        if ((expressionId == 51)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext51 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext51.ValueType___Expr51Get();
        }
        if ((expressionId == 52)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext52 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext52.ValueType___Expr52Get();
        }
        if ((expressionId == 53)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext53 = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, true);
            return refDataContext53.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set);
        }
        if ((expressionId == 54)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext54 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext54.ValueType___Expr54Get();
        }
        if ((expressionId == 55)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext55 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext55.ValueType___Expr55Get();
        }
        if ((expressionId == 56)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext56 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext56.ValueType___Expr56Get();
        }
        if ((expressionId == 57)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext57 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext57.ValueType___Expr57Get();
        }
        if ((expressionId == 58)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext58 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext58.ValueType___Expr58Get();
        }
        if ((expressionId == 59)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext59 = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, true);
            return refDataContext59.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
        }
        if ((expressionId == 60)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext60 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext60.ValueType___Expr60Get();
        }
        if ((expressionId == 61)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext61 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext61.ValueType___Expr61Get();
        }
        if ((expressionId == 62)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext62 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext62.ValueType___Expr62Get();
        }
        if ((expressionId == 63)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext63 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext63.ValueType___Expr63Get();
        }
        if ((expressionId == 64)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext64 = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, true);
            return refDataContext64.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set);
        }
        if ((expressionId == 65)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext65 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext65.ValueType___Expr65Get();
        }
        if ((expressionId == 66)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext66 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext66.ValueType___Expr66Get();
        }
        if ((expressionId == 67)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext67 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext67.ValueType___Expr67Get();
        }
        if ((expressionId == 68)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext68 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext68.ValueType___Expr68Get();
        }
        if ((expressionId == 69)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext69 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext69.ValueType___Expr69Get();
        }
        if ((expressionId == 70)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext70 = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, true);
            return refDataContext70.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set);
        }
        if ((expressionId == 71)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext71 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext71.ValueType___Expr71Get();
        }
        if ((expressionId == 72)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext72 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext72.ValueType___Expr72Get();
        }
        if ((expressionId == 73)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext73 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext73.ValueType___Expr73Get();
        }
        if ((expressionId == 74)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext74 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext74.ValueType___Expr74Get();
        }
        if ((expressionId == 75)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext75 = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, true);
            return refDataContext75.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set);
        }
        if ((expressionId == 76)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext76 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext76.ValueType___Expr76Get();
        }
        if ((expressionId == 77)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext77 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext77.ValueType___Expr77Get();
        }
        if ((expressionId == 78)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext78 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext78.ValueType___Expr78Get();
        }
        if ((expressionId == 79)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext79 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext79.ValueType___Expr79Get();
        }
        if ((expressionId == 80)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext80 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext80.ValueType___Expr80Get();
        }
        if ((expressionId == 81)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2 refDataContext81 = new F1040EzEligibilityRuleCheck_TypedDataContext2(locations, true);
            return refDataContext81.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set);
        }
        if ((expressionId == 82)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext82 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext82.ValueType___Expr82Get();
        }
        if ((expressionId == 83)) {
            F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly valDataContext83 = new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext83.ValueType___Expr83Get();
        }
        return null;
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.ErrorMessages") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 0;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object !=null") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 1;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.PersonalDetails !=null") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 2;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 3;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.Singl" +
                        "e || Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus." +
                        "MarriedFilingJointly)") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 4;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.TAXPAYER_FILING_STATUS]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 5;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 6;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 7;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 8;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.PersonalDetails.PrimaryTaxPayer != null) && (Tax1040Object.Persona" +
                        "lDetails.Spouse != null)") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 9;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object." +
                        "PersonalDetails.Spouse.Person != null)") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 10;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasVa" +
                        "lue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependen" +
                        "t.Value)") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 11;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.CLAIM_EXEMPTION_FOR_DEPENDENT]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 12;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 13;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 14;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 15;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Utilities.AgeCalculation(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.Dat" +
                        "eOfBirth)") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 16;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Utilities.AgeCalculation(Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth)" +
                        "") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 17;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "!(PersonAgeCompleted  || SpouseAgeCompleted)") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 18;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.TAXPAYER_OR_SPOUSE_DOB]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 19;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext3.Validate(locations, true, 0) == true)))) {
            expressionId = 20;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 21;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 22;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DateTime.Now") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 23;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 24;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DateTime.MinValue+pts") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 25;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "PersonAge.Year-1") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 26;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "TodaysDate - Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 27;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DateTime.MinValue+sts") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 28;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "SpouseAge.Year-1") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 29;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsLegallyBlind.HasValue && " +
                        "Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsLegallyBlind.Value)") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 30;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.TAXPAYER_IS_BLIND]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 31;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4.Validate(locations, true, 0) == true)))) {
            expressionId = 32;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 33;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 34;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.PersonalDetails.Spouse.Person.IsLegallyBlind.HasValue && Tax1040Ob" +
                        "ject.PersonalDetails.Spouse.Person.IsLegallyBlind.Value)") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 35;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.SPOUSE_IS_BLIND]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 36;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4.Validate(locations, true, 0) == true)))) {
            expressionId = 37;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 38;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 39;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsBankruptcyDebtor.HasValue" +
                        " && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsBankruptcyDebtor.Valu" +
                        "e)") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 40;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.TAXPAYER_SHOULD_NOT_BE_UNDER_ANY_BANKRUPTCY_CASE]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 41;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 42;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 43;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 44;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Deductions !=null") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 45;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Deductions.HasAGIDeductions.HasValue && Tax1040Object.Deductions.Ha" +
                        "sAGIDeductions.Value") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 46;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.NO_AGI_DEDUCTIONS]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 47;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 48;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 49;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 50;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Deductions.HasItemizedDeductions.HasValue && Tax1040Object.Deductio" +
                        "ns.HasItemizedDeductions.Value") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 51;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.NO_ITEMIZED_DEDUCTION]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 52;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 53;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 54;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 55;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Credits !=null") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 56;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Credits.HasCreditsToClaim.HasValue && Tax1040Object.Credits.HasCred" +
                        "itsToClaim.Value") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 57;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.NO_CREDITS]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 58;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 59;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 60;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 61;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Credits.HasEstimatedTaxPayments.HasValue && Tax1040Object.Credits.H" +
                        "asEstimatedTaxPayments.Value") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 62;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.NO_ESTIMATE_PAYMENTS]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 63;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 64;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 65;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 66;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.TaxesAndPenalties !=null") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 67;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.TaxesAndPenalties.HasOwedHouseholdEmploymentTax.HasValue && Tax1040" +
                        "Object.TaxesAndPenalties.HasOwedHouseholdEmploymentTax.Value") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 68;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.NO_HOUSEHOLD_EMPLOYMENT_TAXES]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 69;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 70;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 71;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 72;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.TaxesAndPenalties.HasAlternativeMinimumTax.HasValue && Tax1040Objec" +
                        "t.TaxesAndPenalties.HasAlternativeMinimumTax.Value") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 73;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.NO_AMT_TAXES]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 74;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 75;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 76;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 77;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Income !=null") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 78;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Income.HasIncomeFromOtherSources.HasValue && Tax1040Object.Income.H" +
                        "asIncomeFromOtherSources.Value") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 79;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessages[Constants.RECEIVED_INCOME_APART_FROM_WAGES_UNEMPLOYMENT_INTEREST_IN" +
                        "COME]") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 80;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 81;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessageList") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 82;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "ErrorMessage") 
                    && (F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 83;
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
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
        }
        if ((expressionId == 1)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
        }
        if ((expressionId == 2)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
        }
        if ((expressionId == 3)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
        }
        if ((expressionId == 4)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
        }
        if ((expressionId == 5)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
        }
        if ((expressionId == 6)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr6GetTree();
        }
        if ((expressionId == 7)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
        }
        if ((expressionId == 8)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
        }
        if ((expressionId == 9)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
        }
        if ((expressionId == 10)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
        }
        if ((expressionId == 11)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
        }
        if ((expressionId == 12)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr12GetTree();
        }
        if ((expressionId == 13)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr13GetTree();
        }
        if ((expressionId == 14)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr14GetTree();
        }
        if ((expressionId == 15)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
        }
        if ((expressionId == 16)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr16GetTree();
        }
        if ((expressionId == 17)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr17GetTree();
        }
        if ((expressionId == 18)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr18GetTree();
        }
        if ((expressionId == 19)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr19GetTree();
        }
        if ((expressionId == 20)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext3(locationReferences).@__Expr20GetTree();
        }
        if ((expressionId == 21)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr21GetTree();
        }
        if ((expressionId == 22)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(locationReferences).@__Expr22GetTree();
        }
        if ((expressionId == 23)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr23GetTree();
        }
        if ((expressionId == 24)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr24GetTree();
        }
        if ((expressionId == 25)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr25GetTree();
        }
        if ((expressionId == 26)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr26GetTree();
        }
        if ((expressionId == 27)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr27GetTree();
        }
        if ((expressionId == 28)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr28GetTree();
        }
        if ((expressionId == 29)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr29GetTree();
        }
        if ((expressionId == 30)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr30GetTree();
        }
        if ((expressionId == 31)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr31GetTree();
        }
        if ((expressionId == 32)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4(locationReferences).@__Expr32GetTree();
        }
        if ((expressionId == 33)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr33GetTree();
        }
        if ((expressionId == 34)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr34GetTree();
        }
        if ((expressionId == 35)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr35GetTree();
        }
        if ((expressionId == 36)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr36GetTree();
        }
        if ((expressionId == 37)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4(locationReferences).@__Expr37GetTree();
        }
        if ((expressionId == 38)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr38GetTree();
        }
        if ((expressionId == 39)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(locationReferences).@__Expr39GetTree();
        }
        if ((expressionId == 40)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr40GetTree();
        }
        if ((expressionId == 41)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr41GetTree();
        }
        if ((expressionId == 42)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr42GetTree();
        }
        if ((expressionId == 43)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr43GetTree();
        }
        if ((expressionId == 44)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr44GetTree();
        }
        if ((expressionId == 45)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr45GetTree();
        }
        if ((expressionId == 46)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr46GetTree();
        }
        if ((expressionId == 47)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr47GetTree();
        }
        if ((expressionId == 48)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr48GetTree();
        }
        if ((expressionId == 49)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr49GetTree();
        }
        if ((expressionId == 50)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr50GetTree();
        }
        if ((expressionId == 51)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr51GetTree();
        }
        if ((expressionId == 52)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr52GetTree();
        }
        if ((expressionId == 53)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr53GetTree();
        }
        if ((expressionId == 54)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr54GetTree();
        }
        if ((expressionId == 55)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr55GetTree();
        }
        if ((expressionId == 56)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr56GetTree();
        }
        if ((expressionId == 57)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr57GetTree();
        }
        if ((expressionId == 58)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr58GetTree();
        }
        if ((expressionId == 59)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr59GetTree();
        }
        if ((expressionId == 60)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr60GetTree();
        }
        if ((expressionId == 61)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr61GetTree();
        }
        if ((expressionId == 62)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr62GetTree();
        }
        if ((expressionId == 63)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr63GetTree();
        }
        if ((expressionId == 64)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr64GetTree();
        }
        if ((expressionId == 65)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr65GetTree();
        }
        if ((expressionId == 66)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr66GetTree();
        }
        if ((expressionId == 67)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr67GetTree();
        }
        if ((expressionId == 68)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr68GetTree();
        }
        if ((expressionId == 69)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr69GetTree();
        }
        if ((expressionId == 70)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr70GetTree();
        }
        if ((expressionId == 71)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr71GetTree();
        }
        if ((expressionId == 72)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr72GetTree();
        }
        if ((expressionId == 73)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr73GetTree();
        }
        if ((expressionId == 74)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr74GetTree();
        }
        if ((expressionId == 75)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr75GetTree();
        }
        if ((expressionId == 76)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr76GetTree();
        }
        if ((expressionId == 77)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr77GetTree();
        }
        if ((expressionId == 78)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr78GetTree();
        }
        if ((expressionId == 79)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr79GetTree();
        }
        if ((expressionId == 80)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr80GetTree();
        }
        if ((expressionId == 81)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2(locationReferences).@__Expr81GetTree();
        }
        if ((expressionId == 82)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr82GetTree();
        }
        if ((expressionId == 83)) {
            return new F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(locationReferences).@__Expr83GetTree();
        }
        return null;
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EzEligibilityRuleCheck_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EzEligibilityRuleCheck_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
    private class F1040EzEligibilityRuleCheck_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EzEligibilityRuleCheck_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
    private class F1040EzEligibilityRuleCheck_TypedDataContext1 : F1040EzEligibilityRuleCheck_TypedDataContext0 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EzEligibilityRuleCheck_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            return F1040EzEligibilityRuleCheck_TypedDataContext0.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EzEligibilityRuleCheck_TypedDataContext1_ForReadOnly : F1040EzEligibilityRuleCheck_TypedDataContext0_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EzEligibilityRuleCheck_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            return F1040EzEligibilityRuleCheck_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EzEligibilityRuleCheck_TypedDataContext2 : F1040EzEligibilityRuleCheck_TypedDataContext1 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EzEligibilityRuleCheck_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        
        internal System.Linq.Expressions.Expression @__Expr6GetTree() {
            
            #line 105 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                  ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr6Get() {
            
            #line 105 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
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
            
            #line 105 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                                  ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr6Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr6Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr13GetTree() {
            
            #line 156 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr13Get() {
            
            #line 156 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
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
            
            #line 156 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                                          ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr13Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr13Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr42GetTree() {
            
            #line 343 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr42Get() {
            
            #line 343 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr42Get() {
            this.GetValueTypeValues();
            return this.@__Expr42Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr42Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            
            #line 343 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                                          ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr42Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr42Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr48GetTree() {
            
            #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr48Get() {
            
            #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr48Get() {
            this.GetValueTypeValues();
            return this.@__Expr48Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr48Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            
            #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                                ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr48Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr48Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr53GetTree() {
            
            #line 431 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr53Get() {
            
            #line 431 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr53Get() {
            this.GetValueTypeValues();
            return this.@__Expr53Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr53Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            
            #line 431 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                                ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr53Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr53Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr59GetTree() {
            
            #line 478 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr59Get() {
            
            #line 478 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                              ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr59Get() {
            this.GetValueTypeValues();
            return this.@__Expr59Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr59Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            
            #line 478 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                              ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr59Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr59Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr64GetTree() {
            
            #line 512 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr64Get() {
            
            #line 512 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr64Get() {
            this.GetValueTypeValues();
            return this.@__Expr64Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr64Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            
            #line 512 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                                ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr64Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr64Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr70GetTree() {
            
            #line 560 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr70Get() {
            
            #line 560 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
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
            
            #line 560 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                                ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr70Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr70Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr75GetTree() {
            
            #line 595 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr75Get() {
            
            #line 595 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
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
            
            #line 595 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                                ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr75Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr75Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr81GetTree() {
            
            #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr81Get() {
            
            #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                              ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr81Get() {
            this.GetValueTypeValues();
            return this.@__Expr81Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr81Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            
            #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                              ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr81Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr81Set(value);
            this.SetValueTypeValues();
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
            if (((locationReferences[(offset + 2)].Name != "ErrorMessage") 
                        || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                return false;
            }
            if (((locationReferences[(offset + 3)].Name != "ErrorMessageList") 
                        || (locationReferences[(offset + 3)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                return false;
            }
            return F1040EzEligibilityRuleCheck_TypedDataContext1.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly : F1040EzEligibilityRuleCheck_TypedDataContext1_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            #line 66 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
          Tax1040Object.ErrorMessages;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr0Get() {
            
            #line 66 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
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
            
            #line 73 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          Tax1040Object !=null;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr1Get() {
            
            #line 73 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
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
            
            #line 82 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.PersonalDetails !=null;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr2Get() {
            
            #line 82 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                  Tax1040Object.PersonalDetails !=null;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr2Get() {
            this.GetValueTypeValues();
            return this.@__Expr2Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr3GetTree() {
            
            #line 90 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr3Get() {
            
            #line 90 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                        Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr3Get() {
            this.GetValueTypeValues();
            return this.@__Expr3Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr4GetTree() {
            
            #line 97 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            (Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.Single || Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr4Get() {
            
            #line 97 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                            (Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.Single || Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr4Get() {
            this.GetValueTypeValues();
            return this.@__Expr4Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr5GetTree() {
            
            #line 110 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                  ErrorMessages[Constants.TAXPAYER_FILING_STATUS];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr5Get() {
            
            #line 110 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                  ErrorMessages[Constants.TAXPAYER_FILING_STATUS];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr5Get() {
            this.GetValueTypeValues();
            return this.@__Expr5Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr7GetTree() {
            
            #line 121 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr7Get() {
            
            #line 121 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessageList;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr7Get() {
            this.GetValueTypeValues();
            return this.@__Expr7Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr8GetTree() {
            
            #line 117 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                  ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr8Get() {
            
            #line 117 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                  ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr8Get() {
            this.GetValueTypeValues();
            return this.@__Expr8Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr9GetTree() {
            
            #line 132 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null) && (Tax1040Object.PersonalDetails.Spouse != null);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr9Get() {
            
            #line 132 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                        (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null) && (Tax1040Object.PersonalDetails.Spouse != null);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr9Get() {
            this.GetValueTypeValues();
            return this.@__Expr9Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr10GetTree() {
            
            #line 139 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.Spouse.Person != null);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr10Get() {
            
            #line 139 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                            (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person != null) && (Tax1040Object.PersonalDetails.Spouse.Person != null);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr10Get() {
            this.GetValueTypeValues();
            return this.@__Expr10Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr11GetTree() {
            
            #line 148 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr11Get() {
            
            #line 148 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr11Get() {
            this.GetValueTypeValues();
            return this.@__Expr11Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr12GetTree() {
            
            #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessages[Constants.CLAIM_EXEMPTION_FOR_DEPENDENT];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr12Get() {
            
            #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessages[Constants.CLAIM_EXEMPTION_FOR_DEPENDENT];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr12Get() {
            this.GetValueTypeValues();
            return this.@__Expr12Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr14GetTree() {
            
            #line 172 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                        ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr14Get() {
            
            #line 172 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                        ErrorMessageList;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr14Get() {
            this.GetValueTypeValues();
            return this.@__Expr14Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr15GetTree() {
            
            #line 168 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr15Get() {
            
            #line 168 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr15Get() {
            this.GetValueTypeValues();
            return this.@__Expr15Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr40GetTree() {
            
            #line 335 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsBankruptcyDebtor.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsBankruptcyDebtor.Value);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr40Get() {
            
            #line 335 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsBankruptcyDebtor.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsBankruptcyDebtor.Value);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr40Get() {
            this.GetValueTypeValues();
            return this.@__Expr40Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr41GetTree() {
            
            #line 348 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessages[Constants.TAXPAYER_SHOULD_NOT_BE_UNDER_ANY_BANKRUPTCY_CASE];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr41Get() {
            
            #line 348 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessages[Constants.TAXPAYER_SHOULD_NOT_BE_UNDER_ANY_BANKRUPTCY_CASE];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr41Get() {
            this.GetValueTypeValues();
            return this.@__Expr41Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr43GetTree() {
            
            #line 359 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                        ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr43Get() {
            
            #line 359 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                        ErrorMessageList;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr43Get() {
            this.GetValueTypeValues();
            return this.@__Expr43Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr44GetTree() {
            
            #line 355 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr44Get() {
            
            #line 355 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr44Get() {
            this.GetValueTypeValues();
            return this.@__Expr44Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr45GetTree() {
            
            #line 379 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.Deductions !=null;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr45Get() {
            
            #line 379 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                  Tax1040Object.Deductions !=null;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr45Get() {
            this.GetValueTypeValues();
            return this.@__Expr45Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr46GetTree() {
            
            #line 388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.Deductions.HasAGIDeductions.HasValue && Tax1040Object.Deductions.HasAGIDeductions.Value;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr46Get() {
            
            #line 388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                          Tax1040Object.Deductions.HasAGIDeductions.HasValue && Tax1040Object.Deductions.HasAGIDeductions.Value;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr46Get() {
            this.GetValueTypeValues();
            return this.@__Expr46Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr47GetTree() {
            
            #line 401 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessages[Constants.NO_AGI_DEDUCTIONS];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr47Get() {
            
            #line 401 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessages[Constants.NO_AGI_DEDUCTIONS];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr47Get() {
            this.GetValueTypeValues();
            return this.@__Expr47Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr49GetTree() {
            
            #line 412 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                              ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr49Get() {
            
            #line 412 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                              ErrorMessageList;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr49Get() {
            this.GetValueTypeValues();
            return this.@__Expr49Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr50GetTree() {
            
            #line 408 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr50Get() {
            
            #line 408 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr50Get() {
            this.GetValueTypeValues();
            return this.@__Expr50Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr51GetTree() {
            
            #line 423 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.Deductions.HasItemizedDeductions.HasValue && Tax1040Object.Deductions.HasItemizedDeductions.Value;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr51Get() {
            
            #line 423 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                          Tax1040Object.Deductions.HasItemizedDeductions.HasValue && Tax1040Object.Deductions.HasItemizedDeductions.Value;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr51Get() {
            this.GetValueTypeValues();
            return this.@__Expr51Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr52GetTree() {
            
            #line 436 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessages[Constants.NO_ITEMIZED_DEDUCTION];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr52Get() {
            
            #line 436 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessages[Constants.NO_ITEMIZED_DEDUCTION];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr52Get() {
            this.GetValueTypeValues();
            return this.@__Expr52Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr54GetTree() {
            
            #line 447 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                              ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr54Get() {
            
            #line 447 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                              ErrorMessageList;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr54Get() {
            this.GetValueTypeValues();
            return this.@__Expr54Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr55GetTree() {
            
            #line 443 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr55Get() {
            
            #line 443 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr55Get() {
            this.GetValueTypeValues();
            return this.@__Expr55Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr56GetTree() {
            
            #line 462 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.Credits !=null;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr56Get() {
            
            #line 462 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                  Tax1040Object.Credits !=null;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr56Get() {
            this.GetValueTypeValues();
            return this.@__Expr56Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr57GetTree() {
            
            #line 470 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.Credits.HasCreditsToClaim.HasValue && Tax1040Object.Credits.HasCreditsToClaim.Value;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr57Get() {
            
            #line 470 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                        Tax1040Object.Credits.HasCreditsToClaim.HasValue && Tax1040Object.Credits.HasCreditsToClaim.Value;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr57Get() {
            this.GetValueTypeValues();
            return this.@__Expr57Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr58GetTree() {
            
            #line 483 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessages[Constants.NO_CREDITS];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr58Get() {
            
            #line 483 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                              ErrorMessages[Constants.NO_CREDITS];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr58Get() {
            this.GetValueTypeValues();
            return this.@__Expr58Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr60GetTree() {
            
            #line 494 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                            ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr60Get() {
            
            #line 494 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                            ErrorMessageList;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr60Get() {
            this.GetValueTypeValues();
            return this.@__Expr60Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr61GetTree() {
            
            #line 490 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr61Get() {
            
            #line 490 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                              ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr61Get() {
            this.GetValueTypeValues();
            return this.@__Expr61Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr62GetTree() {
            
            #line 504 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.Credits.HasEstimatedTaxPayments.HasValue && Tax1040Object.Credits.HasEstimatedTaxPayments.Value;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr62Get() {
            
            #line 504 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                          Tax1040Object.Credits.HasEstimatedTaxPayments.HasValue && Tax1040Object.Credits.HasEstimatedTaxPayments.Value;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr62Get() {
            this.GetValueTypeValues();
            return this.@__Expr62Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr63GetTree() {
            
            #line 517 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessages[Constants.NO_ESTIMATE_PAYMENTS];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr63Get() {
            
            #line 517 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessages[Constants.NO_ESTIMATE_PAYMENTS];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr63Get() {
            this.GetValueTypeValues();
            return this.@__Expr63Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr65GetTree() {
            
            #line 528 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                              ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr65Get() {
            
            #line 528 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                              ErrorMessageList;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr65Get() {
            this.GetValueTypeValues();
            return this.@__Expr65Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr66GetTree() {
            
            #line 524 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr66Get() {
            
            #line 524 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr66Get() {
            this.GetValueTypeValues();
            return this.@__Expr66Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr67GetTree() {
            
            #line 543 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.TaxesAndPenalties !=null;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr67Get() {
            
            #line 543 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                  Tax1040Object.TaxesAndPenalties !=null;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr67Get() {
            this.GetValueTypeValues();
            return this.@__Expr67Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr68GetTree() {
            
            #line 552 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.TaxesAndPenalties.HasOwedHouseholdEmploymentTax.HasValue && Tax1040Object.TaxesAndPenalties.HasOwedHouseholdEmploymentTax.Value;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr68Get() {
            
            #line 552 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                          Tax1040Object.TaxesAndPenalties.HasOwedHouseholdEmploymentTax.HasValue && Tax1040Object.TaxesAndPenalties.HasOwedHouseholdEmploymentTax.Value;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr68Get() {
            this.GetValueTypeValues();
            return this.@__Expr68Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr69GetTree() {
            
            #line 565 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessages[Constants.NO_HOUSEHOLD_EMPLOYMENT_TAXES];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr69Get() {
            
            #line 565 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessages[Constants.NO_HOUSEHOLD_EMPLOYMENT_TAXES];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr69Get() {
            this.GetValueTypeValues();
            return this.@__Expr69Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr71GetTree() {
            
            #line 576 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                              ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr71Get() {
            
            #line 576 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
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
            
            #line 572 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr72Get() {
            
            #line 572 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr72Get() {
            this.GetValueTypeValues();
            return this.@__Expr72Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr73GetTree() {
            
            #line 587 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.TaxesAndPenalties.HasAlternativeMinimumTax.HasValue && Tax1040Object.TaxesAndPenalties.HasAlternativeMinimumTax.Value;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr73Get() {
            
            #line 587 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                          Tax1040Object.TaxesAndPenalties.HasAlternativeMinimumTax.HasValue && Tax1040Object.TaxesAndPenalties.HasAlternativeMinimumTax.Value;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr73Get() {
            this.GetValueTypeValues();
            return this.@__Expr73Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr74GetTree() {
            
            #line 600 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessages[Constants.NO_AMT_TAXES];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr74Get() {
            
            #line 600 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessages[Constants.NO_AMT_TAXES];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr74Get() {
            this.GetValueTypeValues();
            return this.@__Expr74Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr76GetTree() {
            
            #line 611 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                              ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr76Get() {
            
            #line 611 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
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
            
            #line 607 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr77Get() {
            
            #line 607 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr77Get() {
            this.GetValueTypeValues();
            return this.@__Expr77Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr78GetTree() {
            
            #line 626 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.Income !=null;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr78Get() {
            
            #line 626 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                  Tax1040Object.Income !=null;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr78Get() {
            this.GetValueTypeValues();
            return this.@__Expr78Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr79GetTree() {
            
            #line 634 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.Income.HasIncomeFromOtherSources.HasValue && Tax1040Object.Income.HasIncomeFromOtherSources.Value;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr79Get() {
            
            #line 634 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                        Tax1040Object.Income.HasIncomeFromOtherSources.HasValue && Tax1040Object.Income.HasIncomeFromOtherSources.Value;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr79Get() {
            this.GetValueTypeValues();
            return this.@__Expr79Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr80GetTree() {
            
            #line 647 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessages[Constants.RECEIVED_INCOME_APART_FROM_WAGES_UNEMPLOYMENT_INTEREST_INCOME];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr80Get() {
            
            #line 647 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                              ErrorMessages[Constants.RECEIVED_INCOME_APART_FROM_WAGES_UNEMPLOYMENT_INTEREST_INCOME];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr80Get() {
            this.GetValueTypeValues();
            return this.@__Expr80Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr82GetTree() {
            
            #line 658 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                            ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr82Get() {
            
            #line 658 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                            ErrorMessageList;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr82Get() {
            this.GetValueTypeValues();
            return this.@__Expr82Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr83GetTree() {
            
            #line 654 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                              ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr83Get() {
            
            #line 654 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                              ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr83Get() {
            this.GetValueTypeValues();
            return this.@__Expr83Get();
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
            if (((locationReferences[(offset + 2)].Name != "ErrorMessage") 
                        || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                return false;
            }
            if (((locationReferences[(offset + 3)].Name != "ErrorMessageList") 
                        || (locationReferences[(offset + 3)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                return false;
            }
            return F1040EzEligibilityRuleCheck_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EzEligibilityRuleCheck_TypedDataContext3 : F1040EzEligibilityRuleCheck_TypedDataContext2 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected bool PersonAgeCompleted;
        
        protected bool SpouseAgeCompleted;
        
        public F1040EzEligibilityRuleCheck_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            #line 203 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr20Get() {
            
            #line 203 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
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
            
            #line 203 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                                          ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr20Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr20Set(value);
            this.SetValueTypeValues();
        }
        
        protected override void GetValueTypeValues() {
            this.PersonAgeCompleted = ((bool)(this.GetVariableValue((4 + locationsOffset))));
            this.SpouseAgeCompleted = ((bool)(this.GetVariableValue((5 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        protected override void SetValueTypeValues() {
            this.SetVariableValue((4 + locationsOffset), this.PersonAgeCompleted);
            this.SetVariableValue((5 + locationsOffset), this.SpouseAgeCompleted);
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
            if (((locationReferences[(offset + 4)].Name != "PersonAgeCompleted") 
                        || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                return false;
            }
            if (((locationReferences[(offset + 5)].Name != "SpouseAgeCompleted") 
                        || (locationReferences[(offset + 5)].Type != typeof(bool)))) {
                return false;
            }
            return F1040EzEligibilityRuleCheck_TypedDataContext2.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly : F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected bool PersonAgeCompleted;
        
        protected bool SpouseAgeCompleted;
        
        public F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            #line 183 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Utilities.AgeCalculation(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr16Get() {
            
            #line 183 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    Utilities.AgeCalculation(Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr16Get() {
            this.GetValueTypeValues();
            return this.@__Expr16Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr17GetTree() {
            
            #line 188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Utilities.AgeCalculation(Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr17Get() {
            
            #line 188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    Utilities.AgeCalculation(Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr17Get() {
            this.GetValueTypeValues();
            return this.@__Expr17Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr18GetTree() {
            
            #line 195 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    !(PersonAgeCompleted  || SpouseAgeCompleted);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr18Get() {
            
            #line 195 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    !(PersonAgeCompleted  || SpouseAgeCompleted);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr18Get() {
            this.GetValueTypeValues();
            return this.@__Expr18Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr19GetTree() {
            
            #line 208 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessages[Constants.TAXPAYER_OR_SPOUSE_DOB];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr19Get() {
            
            #line 208 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessages[Constants.TAXPAYER_OR_SPOUSE_DOB];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr19Get() {
            this.GetValueTypeValues();
            return this.@__Expr19Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr21GetTree() {
            
            #line 219 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                        ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr21Get() {
            
            #line 219 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                        ErrorMessageList;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr21Get() {
            this.GetValueTypeValues();
            return this.@__Expr21Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr22GetTree() {
            
            #line 215 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr22Get() {
            
            #line 215 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr22Get() {
            this.GetValueTypeValues();
            return this.@__Expr22Get();
        }
        
        protected override void GetValueTypeValues() {
            this.PersonAgeCompleted = ((bool)(this.GetVariableValue((4 + locationsOffset))));
            this.SpouseAgeCompleted = ((bool)(this.GetVariableValue((5 + locationsOffset))));
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
            if (((locationReferences[(offset + 4)].Name != "PersonAgeCompleted") 
                        || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                return false;
            }
            if (((locationReferences[(offset + 5)].Name != "SpouseAgeCompleted") 
                        || (locationReferences[(offset + 5)].Type != typeof(bool)))) {
                return false;
            }
            return F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EzEligibilityRuleCheck_TypedDataContext4 : F1040EzEligibilityRuleCheck_TypedDataContext2 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected System.DateTime TodaysDate;
        
        protected System.TimeSpan pts;
        
        protected System.DateTime PersonAge;
        
        protected int PersonAgeCompleted;
        
        protected System.TimeSpan sts;
        
        protected System.DateTime SpouseAge;
        
        protected int SpouseAgeCompleted;
        
        public F1040EzEligibilityRuleCheck_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            #line 275 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr32Get() {
            
            #line 275 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr32Get() {
            this.GetValueTypeValues();
            return this.@__Expr32Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr32Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            
            #line 275 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                                          ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr32Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr32Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr37GetTree() {
            
            #line 308 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr37Get() {
            
            #line 308 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr37Get() {
            this.GetValueTypeValues();
            return this.@__Expr37Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr37Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            
            #line 308 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            
                                          ErrorMessage = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr37Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
            this.GetValueTypeValues();
            this.@__Expr37Set(value);
            this.SetValueTypeValues();
        }
        
        protected override void GetValueTypeValues() {
            this.TodaysDate = ((System.DateTime)(this.GetVariableValue((4 + locationsOffset))));
            this.pts = ((System.TimeSpan)(this.GetVariableValue((5 + locationsOffset))));
            this.PersonAge = ((System.DateTime)(this.GetVariableValue((6 + locationsOffset))));
            this.PersonAgeCompleted = ((int)(this.GetVariableValue((7 + locationsOffset))));
            this.sts = ((System.TimeSpan)(this.GetVariableValue((8 + locationsOffset))));
            this.SpouseAge = ((System.DateTime)(this.GetVariableValue((9 + locationsOffset))));
            this.SpouseAgeCompleted = ((int)(this.GetVariableValue((10 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        protected override void SetValueTypeValues() {
            this.SetVariableValue((4 + locationsOffset), this.TodaysDate);
            this.SetVariableValue((5 + locationsOffset), this.pts);
            this.SetVariableValue((6 + locationsOffset), this.PersonAge);
            this.SetVariableValue((7 + locationsOffset), this.PersonAgeCompleted);
            this.SetVariableValue((8 + locationsOffset), this.sts);
            this.SetVariableValue((9 + locationsOffset), this.SpouseAge);
            this.SetVariableValue((10 + locationsOffset), this.SpouseAgeCompleted);
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
            if (((locationReferences[(offset + 4)].Name != "TodaysDate") 
                        || (locationReferences[(offset + 4)].Type != typeof(System.DateTime)))) {
                return false;
            }
            if (((locationReferences[(offset + 5)].Name != "pts") 
                        || (locationReferences[(offset + 5)].Type != typeof(System.TimeSpan)))) {
                return false;
            }
            if (((locationReferences[(offset + 6)].Name != "PersonAge") 
                        || (locationReferences[(offset + 6)].Type != typeof(System.DateTime)))) {
                return false;
            }
            if (((locationReferences[(offset + 7)].Name != "PersonAgeCompleted") 
                        || (locationReferences[(offset + 7)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 8)].Name != "sts") 
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
            return F1040EzEligibilityRuleCheck_TypedDataContext2.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly : F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected System.DateTime TodaysDate;
        
        protected System.TimeSpan pts;
        
        protected System.DateTime PersonAge;
        
        protected int PersonAgeCompleted;
        
        protected System.TimeSpan sts;
        
        protected System.DateTime SpouseAge;
        
        protected int SpouseAgeCompleted;
        
        public F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EzEligibilityRuleCheck_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr23GetTree() {
            
            #line 230 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                    DateTime.Now;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.DateTime @__Expr23Get() {
            
            #line 230 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    DateTime.Now;
            
            #line default
            #line hidden
        }
        
        public System.DateTime ValueType___Expr23Get() {
            this.GetValueTypeValues();
            return this.@__Expr23Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr24GetTree() {
            
            #line 235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                    TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.TimeSpan @__Expr24Get() {
            
            #line 235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
            
            #line default
            #line hidden
        }
        
        public System.TimeSpan ValueType___Expr24Get() {
            this.GetValueTypeValues();
            return this.@__Expr24Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr25GetTree() {
            
            #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                    DateTime.MinValue+pts;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.DateTime @__Expr25Get() {
            
            #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    DateTime.MinValue+pts;
            
            #line default
            #line hidden
        }
        
        public System.DateTime ValueType___Expr25Get() {
            this.GetValueTypeValues();
            return this.@__Expr25Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr26GetTree() {
            
            #line 245 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                    PersonAge.Year-1;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public int @__Expr26Get() {
            
            #line 245 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    PersonAge.Year-1;
            
            #line default
            #line hidden
        }
        
        public int ValueType___Expr26Get() {
            this.GetValueTypeValues();
            return this.@__Expr26Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr27GetTree() {
            
            #line 250 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                    TodaysDate - Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.TimeSpan @__Expr27Get() {
            
            #line 250 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    TodaysDate - Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth;
            
            #line default
            #line hidden
        }
        
        public System.TimeSpan ValueType___Expr27Get() {
            this.GetValueTypeValues();
            return this.@__Expr27Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr28GetTree() {
            
            #line 255 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                    DateTime.MinValue+sts;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.DateTime @__Expr28Get() {
            
            #line 255 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    DateTime.MinValue+sts;
            
            #line default
            #line hidden
        }
        
        public System.DateTime ValueType___Expr28Get() {
            this.GetValueTypeValues();
            return this.@__Expr28Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr29GetTree() {
            
            #line 260 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                    SpouseAge.Year-1;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public int @__Expr29Get() {
            
            #line 260 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    SpouseAge.Year-1;
            
            #line default
            #line hidden
        }
        
        public int ValueType___Expr29Get() {
            this.GetValueTypeValues();
            return this.@__Expr29Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr30GetTree() {
            
            #line 267 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsLegallyBlind.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsLegallyBlind.Value);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr30Get() {
            
            #line 267 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    (Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsLegallyBlind.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.IsLegallyBlind.Value);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr30Get() {
            this.GetValueTypeValues();
            return this.@__Expr30Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr31GetTree() {
            
            #line 280 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessages[Constants.TAXPAYER_IS_BLIND];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr31Get() {
            
            #line 280 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessages[Constants.TAXPAYER_IS_BLIND];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr31Get() {
            this.GetValueTypeValues();
            return this.@__Expr31Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr33GetTree() {
            
            #line 291 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                        ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr33Get() {
            
            #line 291 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                        ErrorMessageList;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr33Get() {
            this.GetValueTypeValues();
            return this.@__Expr33Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr34GetTree() {
            
            #line 287 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr34Get() {
            
            #line 287 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr34Get() {
            this.GetValueTypeValues();
            return this.@__Expr34Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr35GetTree() {
            
            #line 300 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    (Tax1040Object.PersonalDetails.Spouse.Person.IsLegallyBlind.HasValue && Tax1040Object.PersonalDetails.Spouse.Person.IsLegallyBlind.Value);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr35Get() {
            
            #line 300 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                    (Tax1040Object.PersonalDetails.Spouse.Person.IsLegallyBlind.HasValue && Tax1040Object.PersonalDetails.Spouse.Person.IsLegallyBlind.Value);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr35Get() {
            this.GetValueTypeValues();
            return this.@__Expr35Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr36GetTree() {
            
            #line 313 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessages[Constants.SPOUSE_IS_BLIND];
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr36Get() {
            
            #line 313 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessages[Constants.SPOUSE_IS_BLIND];
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr36Get() {
            this.GetValueTypeValues();
            return this.@__Expr36Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr38GetTree() {
            
            #line 324 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                        ErrorMessageList;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr38Get() {
            
            #line 324 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                        ErrorMessageList;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr38Get() {
            this.GetValueTypeValues();
            return this.@__Expr38Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr39GetTree() {
            
            #line 320 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                          ErrorMessage;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.ErrorMessage @__Expr39Get() {
            
            #line 320 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZELIGIBILITYRULECHECK.XAML"
            return 
                                          ErrorMessage;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr39Get() {
            this.GetValueTypeValues();
            return this.@__Expr39Get();
        }
        
        protected override void GetValueTypeValues() {
            this.TodaysDate = ((System.DateTime)(this.GetVariableValue((4 + locationsOffset))));
            this.pts = ((System.TimeSpan)(this.GetVariableValue((5 + locationsOffset))));
            this.PersonAge = ((System.DateTime)(this.GetVariableValue((6 + locationsOffset))));
            this.PersonAgeCompleted = ((int)(this.GetVariableValue((7 + locationsOffset))));
            this.sts = ((System.TimeSpan)(this.GetVariableValue((8 + locationsOffset))));
            this.SpouseAge = ((System.DateTime)(this.GetVariableValue((9 + locationsOffset))));
            this.SpouseAgeCompleted = ((int)(this.GetVariableValue((10 + locationsOffset))));
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
            if (((locationReferences[(offset + 4)].Name != "TodaysDate") 
                        || (locationReferences[(offset + 4)].Type != typeof(System.DateTime)))) {
                return false;
            }
            if (((locationReferences[(offset + 5)].Name != "pts") 
                        || (locationReferences[(offset + 5)].Type != typeof(System.TimeSpan)))) {
                return false;
            }
            if (((locationReferences[(offset + 6)].Name != "PersonAge") 
                        || (locationReferences[(offset + 6)].Type != typeof(System.DateTime)))) {
                return false;
            }
            if (((locationReferences[(offset + 7)].Name != "PersonAgeCompleted") 
                        || (locationReferences[(offset + 7)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 8)].Name != "sts") 
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
            return F1040EzEligibilityRuleCheck_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
}
