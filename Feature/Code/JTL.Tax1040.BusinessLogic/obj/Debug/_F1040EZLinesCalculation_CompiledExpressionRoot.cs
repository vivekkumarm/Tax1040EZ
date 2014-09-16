
#line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using System;

#line default
#line hidden

#line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using System.Collections;

#line default
#line hidden

#line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using System.Collections.Generic;

#line default
#line hidden

#line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using System.Activities;

#line default
#line hidden

#line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using System.Activities.Expressions;

#line default
#line hidden

#line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using System.Activities.Statements;

#line default
#line hidden

#line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using System.Data;

#line default
#line hidden

#line 28 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using System.Linq;

#line default
#line hidden

#line 29 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using System.Text;

#line default
#line hidden

#line 30 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using JTL.Tax1040.BusinessObject;

#line default
#line hidden

#line 31 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using JTL.Tax1040.Core.Object;

#line default
#line hidden

#line 32 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using System.Collections.Concurrent;

#line default
#line hidden

#line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\SampleActivities\F1040EZLinesCalculation.xaml"
using System.Activities.XamlIntegration;

#line default
#line hidden


public partial class F1040EZLinesCalculation : System.Activities.XamlIntegration.ICompiledExpressionRoot {
    
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
            this.dataContextActivities = F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
        }
        if ((expressionId == 0)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext0 = ((F1040EZLinesCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext0.ValueType___Expr0Get();
        }
        if ((expressionId == 1)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext1 = ((F1040EZLinesCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext1.ValueType___Expr1Get();
        }
        if ((expressionId == 2)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EZLinesCalculation_TypedDataContext2(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2 refDataContext2 = ((F1040EZLinesCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.OutputForms>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 3)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext3 = ((F1040EZLinesCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext3.ValueType___Expr3Get();
        }
        if ((expressionId == 4)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EZLinesCalculation_TypedDataContext2(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2 refDataContext4 = ((F1040EZLinesCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext4.GetLocation<JTL.Tax1040.BusinessObject.Tax1040EZPage1>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 5)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[2] == null)) {
                cachedCompiledDataContext[2] = new F1040EZLinesCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext3_ForReadOnly valDataContext5 = ((F1040EZLinesCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
            return valDataContext5.ValueType___Expr5Get();
        }
        if ((expressionId == 6)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[2] == null)) {
                cachedCompiledDataContext[2] = new F1040EZLinesCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext3_ForReadOnly valDataContext6 = ((F1040EZLinesCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
            return valDataContext6.ValueType___Expr6Get();
        }
        if ((expressionId == 7)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[3] == null)) {
                cachedCompiledDataContext[3] = new F1040EZLinesCalculation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext4_ForReadOnly valDataContext7 = ((F1040EZLinesCalculation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
            return valDataContext7.ValueType___Expr7Get();
        }
        if ((expressionId == 8)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EZLinesCalculation_TypedDataContext4(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext4 refDataContext8 = ((F1040EZLinesCalculation_TypedDataContext4)(cachedCompiledDataContext[4]));
            return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 9)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[3] == null)) {
                cachedCompiledDataContext[3] = new F1040EZLinesCalculation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext4_ForReadOnly valDataContext9 = ((F1040EZLinesCalculation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
            return valDataContext9.ValueType___Expr9Get();
        }
        if ((expressionId == 10)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[3] == null)) {
                cachedCompiledDataContext[3] = new F1040EZLinesCalculation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext4_ForReadOnly valDataContext10 = ((F1040EZLinesCalculation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
            return valDataContext10.ValueType___Expr10Get();
        }
        if ((expressionId == 11)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[4] == null)) {
                cachedCompiledDataContext[4] = new F1040EZLinesCalculation_TypedDataContext4(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext4 refDataContext11 = ((F1040EZLinesCalculation_TypedDataContext4)(cachedCompiledDataContext[4]));
            return refDataContext11.GetLocation<double>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 12)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[5] == null)) {
                cachedCompiledDataContext[5] = new F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext5_ForReadOnly valDataContext12 = ((F1040EZLinesCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
            return valDataContext12.ValueType___Expr12Get();
        }
        if ((expressionId == 13)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[5] == null)) {
                cachedCompiledDataContext[5] = new F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext5_ForReadOnly valDataContext13 = ((F1040EZLinesCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
            return valDataContext13.ValueType___Expr13Get();
        }
        if ((expressionId == 14)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[6] == null)) {
                cachedCompiledDataContext[6] = new F1040EZLinesCalculation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext6_ForReadOnly valDataContext14 = ((F1040EZLinesCalculation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
            return valDataContext14.ValueType___Expr14Get();
        }
        if ((expressionId == 15)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[7] == null)) {
                cachedCompiledDataContext[7] = new F1040EZLinesCalculation_TypedDataContext6(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext6 refDataContext15 = ((F1040EZLinesCalculation_TypedDataContext6)(cachedCompiledDataContext[7]));
            return refDataContext15.GetLocation<double>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 16)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[6] == null)) {
                cachedCompiledDataContext[6] = new F1040EZLinesCalculation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext6_ForReadOnly valDataContext16 = ((F1040EZLinesCalculation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
            return valDataContext16.ValueType___Expr16Get();
        }
        if ((expressionId == 17)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[6] == null)) {
                cachedCompiledDataContext[6] = new F1040EZLinesCalculation_TypedDataContext6_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext6_ForReadOnly valDataContext17 = ((F1040EZLinesCalculation_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
            return valDataContext17.ValueType___Expr17Get();
        }
        if ((expressionId == 18)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[7] == null)) {
                cachedCompiledDataContext[7] = new F1040EZLinesCalculation_TypedDataContext6(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext6 refDataContext18 = ((F1040EZLinesCalculation_TypedDataContext6)(cachedCompiledDataContext[7]));
            return refDataContext18.GetLocation<double>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 19)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[5] == null)) {
                cachedCompiledDataContext[5] = new F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext5_ForReadOnly valDataContext19 = ((F1040EZLinesCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
            return valDataContext19.ValueType___Expr19Get();
        }
        if ((expressionId == 20)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[5] == null)) {
                cachedCompiledDataContext[5] = new F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext5_ForReadOnly valDataContext20 = ((F1040EZLinesCalculation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
            return valDataContext20.ValueType___Expr20Get();
        }
        if ((expressionId == 21)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[8] == null)) {
                cachedCompiledDataContext[8] = new F1040EZLinesCalculation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext7_ForReadOnly valDataContext21 = ((F1040EZLinesCalculation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
            return valDataContext21.ValueType___Expr21Get();
        }
        if ((expressionId == 22)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[9] == null)) {
                cachedCompiledDataContext[9] = new F1040EZLinesCalculation_TypedDataContext7(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext7 refDataContext22 = ((F1040EZLinesCalculation_TypedDataContext7)(cachedCompiledDataContext[9]));
            return refDataContext22.GetLocation<double>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 23)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[8] == null)) {
                cachedCompiledDataContext[8] = new F1040EZLinesCalculation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext7_ForReadOnly valDataContext23 = ((F1040EZLinesCalculation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
            return valDataContext23.ValueType___Expr23Get();
        }
        if ((expressionId == 24)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[8] == null)) {
                cachedCompiledDataContext[8] = new F1040EZLinesCalculation_TypedDataContext7_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext7_ForReadOnly valDataContext24 = ((F1040EZLinesCalculation_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
            return valDataContext24.ValueType___Expr24Get();
        }
        if ((expressionId == 25)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[9] == null)) {
                cachedCompiledDataContext[9] = new F1040EZLinesCalculation_TypedDataContext7(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext7 refDataContext25 = ((F1040EZLinesCalculation_TypedDataContext7)(cachedCompiledDataContext[9]));
            return refDataContext25.GetLocation<double>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 26)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[10] == null)) {
                cachedCompiledDataContext[10] = new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext8_ForReadOnly valDataContext26 = ((F1040EZLinesCalculation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
            return valDataContext26.ValueType___Expr26Get();
        }
        if ((expressionId == 27)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[10] == null)) {
                cachedCompiledDataContext[10] = new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext8_ForReadOnly valDataContext27 = ((F1040EZLinesCalculation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
            return valDataContext27.ValueType___Expr27Get();
        }
        if ((expressionId == 28)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[11] == null)) {
                cachedCompiledDataContext[11] = new F1040EZLinesCalculation_TypedDataContext9_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext9_ForReadOnly valDataContext28 = ((F1040EZLinesCalculation_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
            return valDataContext28.ValueType___Expr28Get();
        }
        if ((expressionId == 29)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[12] == null)) {
                cachedCompiledDataContext[12] = new F1040EZLinesCalculation_TypedDataContext9(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext9 refDataContext29 = ((F1040EZLinesCalculation_TypedDataContext9)(cachedCompiledDataContext[12]));
            return refDataContext29.GetLocation<double>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 30)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[11] == null)) {
                cachedCompiledDataContext[11] = new F1040EZLinesCalculation_TypedDataContext9_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext9_ForReadOnly valDataContext30 = ((F1040EZLinesCalculation_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
            return valDataContext30.ValueType___Expr30Get();
        }
        if ((expressionId == 31)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[11] == null)) {
                cachedCompiledDataContext[11] = new F1040EZLinesCalculation_TypedDataContext9_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext9_ForReadOnly valDataContext31 = ((F1040EZLinesCalculation_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
            return valDataContext31.ValueType___Expr31Get();
        }
        if ((expressionId == 32)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[12] == null)) {
                cachedCompiledDataContext[12] = new F1040EZLinesCalculation_TypedDataContext9(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext9 refDataContext32 = ((F1040EZLinesCalculation_TypedDataContext9)(cachedCompiledDataContext[12]));
            return refDataContext32.GetLocation<double>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 33)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[10] == null)) {
                cachedCompiledDataContext[10] = new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext8_ForReadOnly valDataContext33 = ((F1040EZLinesCalculation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
            return valDataContext33.ValueType___Expr33Get();
        }
        if ((expressionId == 34)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[10] == null)) {
                cachedCompiledDataContext[10] = new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext8_ForReadOnly valDataContext34 = ((F1040EZLinesCalculation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
            return valDataContext34.ValueType___Expr34Get();
        }
        if ((expressionId == 35)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[13] == null)) {
                cachedCompiledDataContext[13] = new F1040EZLinesCalculation_TypedDataContext8(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext8 refDataContext35 = ((F1040EZLinesCalculation_TypedDataContext8)(cachedCompiledDataContext[13]));
            return refDataContext35.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 36)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[13] == null)) {
                cachedCompiledDataContext[13] = new F1040EZLinesCalculation_TypedDataContext8(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext8 refDataContext36 = ((F1040EZLinesCalculation_TypedDataContext8)(cachedCompiledDataContext[13]));
            return refDataContext36.GetLocation<double>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 37)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[10] == null)) {
                cachedCompiledDataContext[10] = new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext8_ForReadOnly valDataContext37 = ((F1040EZLinesCalculation_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
            return valDataContext37.ValueType___Expr37Get();
        }
        if ((expressionId == 38)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[13] == null)) {
                cachedCompiledDataContext[13] = new F1040EZLinesCalculation_TypedDataContext8(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext8 refDataContext38 = ((F1040EZLinesCalculation_TypedDataContext8)(cachedCompiledDataContext[13]));
            return refDataContext38.GetLocation<double>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 39)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext39 = ((F1040EZLinesCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext39.ValueType___Expr39Get();
        }
        if ((expressionId == 40)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EZLinesCalculation_TypedDataContext2(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2 refDataContext40 = ((F1040EZLinesCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext40.GetLocation<double>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 41)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext41 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext41.ValueType___Expr41Get();
        }
        if ((expressionId == 42)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext42 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext42.ValueType___Expr42Get();
        }
        if ((expressionId == 43)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext43 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext43.ValueType___Expr43Get();
        }
        if ((expressionId == 44)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext44 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 45)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext45 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext45.ValueType___Expr45Get();
        }
        if ((expressionId == 46)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext46 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext46.ValueType___Expr46Get();
        }
        if ((expressionId == 47)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext47 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext47.GetLocation<double>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 48)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext48 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext48.ValueType___Expr48Get();
        }
        if ((expressionId == 49)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext49 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 50)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext50 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext50.ValueType___Expr50Get();
        }
        if ((expressionId == 51)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext51 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext51.GetLocation<double>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 52)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext52 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext52.ValueType___Expr52Get();
        }
        if ((expressionId == 53)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext53 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext53.GetLocation<double>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 54)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext54 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext54.ValueType___Expr54Get();
        }
        if ((expressionId == 55)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext55 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext55.GetLocation<double>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 56)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext56 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext56.ValueType___Expr56Get();
        }
        if ((expressionId == 57)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext57 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext57.GetLocation<double>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 58)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext58 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext58.ValueType___Expr58Get();
        }
        if ((expressionId == 59)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext59 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext59.GetLocation<double>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 60)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext60 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext60.ValueType___Expr60Get();
        }
        if ((expressionId == 61)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext61 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext61.GetLocation<double>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 62)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext62 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext62.ValueType___Expr62Get();
        }
        if ((expressionId == 63)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext63 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext63.ValueType___Expr63Get();
        }
        if ((expressionId == 64)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext64 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext64.GetLocation<double>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 65)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext65 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext65.ValueType___Expr65Get();
        }
        if ((expressionId == 66)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext66 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext66.ValueType___Expr66Get();
        }
        if ((expressionId == 67)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext67 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext67.GetLocation<double>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 68)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext68 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext68.ValueType___Expr68Get();
        }
        if ((expressionId == 69)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext69 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext69.GetLocation<double>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 70)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext70 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext70.ValueType___Expr70Get();
        }
        if ((expressionId == 71)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext71 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext71.GetLocation<double>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 72)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext72 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext72.ValueType___Expr72Get();
        }
        if ((expressionId == 73)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext73 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext73.GetLocation<double>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 74)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext74 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext74.ValueType___Expr74Get();
        }
        if ((expressionId == 75)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext75 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext75.GetLocation<double>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 76)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext76 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext76.ValueType___Expr76Get();
        }
        if ((expressionId == 77)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext77 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext77.GetLocation<double>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 78)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext78 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext78.ValueType___Expr78Get();
        }
        if ((expressionId == 79)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext79 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext79.GetLocation<double>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 80)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext80 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext80.ValueType___Expr80Get();
        }
        if ((expressionId == 81)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext81 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext81.GetLocation<double>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 82)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext82 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext82.ValueType___Expr82Get();
        }
        if ((expressionId == 83)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext83 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext83.ValueType___Expr83Get();
        }
        if ((expressionId == 84)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext84 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext84.GetLocation<double>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 85)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext85 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext85.ValueType___Expr85Get();
        }
        if ((expressionId == 86)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext86 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext86.GetLocation<double>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 87)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext87 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext87.ValueType___Expr87Get();
        }
        if ((expressionId == 88)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext88 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext88.GetLocation<double>(refDataContext88.ValueType___Expr88Get, refDataContext88.ValueType___Expr88Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 89)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext89 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext89.ValueType___Expr89Get();
        }
        if ((expressionId == 90)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext90 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext90.GetLocation<double>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 91)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext91 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext91.ValueType___Expr91Get();
        }
        if ((expressionId == 92)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext92 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext92.GetLocation<double>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 93)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext93 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext93.ValueType___Expr93Get();
        }
        if ((expressionId == 94)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext94 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext94.GetLocation<double>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 95)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext95 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext95.ValueType___Expr95Get();
        }
        if ((expressionId == 96)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext96 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext96.GetLocation<double>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 97)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[14] == null)) {
                cachedCompiledDataContext[14] = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext97 = ((F1040EZLinesCalculation_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
            return valDataContext97.ValueType___Expr97Get();
        }
        if ((expressionId == 98)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[15] == null)) {
                cachedCompiledDataContext[15] = new F1040EZLinesCalculation_TypedDataContext10(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext10 refDataContext98 = ((F1040EZLinesCalculation_TypedDataContext10)(cachedCompiledDataContext[15]));
            return refDataContext98.GetLocation<double>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 99)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext99 = ((F1040EZLinesCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext99.ValueType___Expr99Get();
        }
        if ((expressionId == 100)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext100 = ((F1040EZLinesCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext100.ValueType___Expr100Get();
        }
        if ((expressionId == 101)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EZLinesCalculation_TypedDataContext2(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2 refDataContext101 = ((F1040EZLinesCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext101.GetLocation<double>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 102)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EZLinesCalculation_TypedDataContext2(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2 refDataContext102 = ((F1040EZLinesCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext102.GetLocation<double>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 103)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[16] == null)) {
                cachedCompiledDataContext[16] = new F1040EZLinesCalculation_TypedDataContext11_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext11_ForReadOnly valDataContext103 = ((F1040EZLinesCalculation_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[16]));
            return valDataContext103.ValueType___Expr103Get();
        }
        if ((expressionId == 104)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[17] == null)) {
                cachedCompiledDataContext[17] = new F1040EZLinesCalculation_TypedDataContext11(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext11 refDataContext104 = ((F1040EZLinesCalculation_TypedDataContext11)(cachedCompiledDataContext[17]));
            return refDataContext104.GetLocation<double>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 105)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[18] == null)) {
                cachedCompiledDataContext[18] = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext105 = ((F1040EZLinesCalculation_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[18]));
            return valDataContext105.ValueType___Expr105Get();
        }
        if ((expressionId == 106)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[18] == null)) {
                cachedCompiledDataContext[18] = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext106 = ((F1040EZLinesCalculation_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[18]));
            return valDataContext106.ValueType___Expr106Get();
        }
        if ((expressionId == 107)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[18] == null)) {
                cachedCompiledDataContext[18] = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext107 = ((F1040EZLinesCalculation_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[18]));
            return valDataContext107.ValueType___Expr107Get();
        }
        if ((expressionId == 108)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[18] == null)) {
                cachedCompiledDataContext[18] = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext108 = ((F1040EZLinesCalculation_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[18]));
            return valDataContext108.ValueType___Expr108Get();
        }
        if ((expressionId == 109)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[18] == null)) {
                cachedCompiledDataContext[18] = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext109 = ((F1040EZLinesCalculation_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[18]));
            return valDataContext109.ValueType___Expr109Get();
        }
        if ((expressionId == 110)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[18] == null)) {
                cachedCompiledDataContext[18] = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext110 = ((F1040EZLinesCalculation_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[18]));
            return valDataContext110.ValueType___Expr110Get();
        }
        if ((expressionId == 111)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[18] == null)) {
                cachedCompiledDataContext[18] = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext111 = ((F1040EZLinesCalculation_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[18]));
            return valDataContext111.ValueType___Expr111Get();
        }
        if ((expressionId == 112)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[18] == null)) {
                cachedCompiledDataContext[18] = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext112 = ((F1040EZLinesCalculation_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[18]));
            return valDataContext112.ValueType___Expr112Get();
        }
        if ((expressionId == 113)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[19] == null)) {
                cachedCompiledDataContext[19] = new F1040EZLinesCalculation_TypedDataContext13_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext13_ForReadOnly valDataContext113 = ((F1040EZLinesCalculation_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
            return valDataContext113.ValueType___Expr113Get();
        }
        if ((expressionId == 114)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[19] == null)) {
                cachedCompiledDataContext[19] = new F1040EZLinesCalculation_TypedDataContext13_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext13_ForReadOnly valDataContext114 = ((F1040EZLinesCalculation_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
            return valDataContext114.ValueType___Expr114Get();
        }
        if ((expressionId == 115)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[20] == null)) {
                cachedCompiledDataContext[20] = new F1040EZLinesCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext14_ForReadOnly valDataContext115 = ((F1040EZLinesCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[20]));
            return valDataContext115.ValueType___Expr115Get();
        }
        if ((expressionId == 116)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[21] == null)) {
                cachedCompiledDataContext[21] = new F1040EZLinesCalculation_TypedDataContext14(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext14 refDataContext116 = ((F1040EZLinesCalculation_TypedDataContext14)(cachedCompiledDataContext[21]));
            return refDataContext116.GetLocation<double>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 117)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[20] == null)) {
                cachedCompiledDataContext[20] = new F1040EZLinesCalculation_TypedDataContext14_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext14_ForReadOnly valDataContext117 = ((F1040EZLinesCalculation_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[20]));
            return valDataContext117.ValueType___Expr117Get();
        }
        if ((expressionId == 118)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[21] == null)) {
                cachedCompiledDataContext[21] = new F1040EZLinesCalculation_TypedDataContext14(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext14 refDataContext118 = ((F1040EZLinesCalculation_TypedDataContext14)(cachedCompiledDataContext[21]));
            return refDataContext118.GetLocation<double>(refDataContext118.ValueType___Expr118Get, refDataContext118.ValueType___Expr118Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 119)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[19] == null)) {
                cachedCompiledDataContext[19] = new F1040EZLinesCalculation_TypedDataContext13_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext13_ForReadOnly valDataContext119 = ((F1040EZLinesCalculation_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
            return valDataContext119.ValueType___Expr119Get();
        }
        if ((expressionId == 120)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[22] == null)) {
                cachedCompiledDataContext[22] = new F1040EZLinesCalculation_TypedDataContext13(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext13 refDataContext120 = ((F1040EZLinesCalculation_TypedDataContext13)(cachedCompiledDataContext[22]));
            return refDataContext120.GetLocation<double>(refDataContext120.ValueType___Expr120Get, refDataContext120.ValueType___Expr120Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 121)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext121 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext121.ValueType___Expr121Get();
        }
        if ((expressionId == 122)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext122 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext122.GetLocation<int>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 123)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext123 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext123.ValueType___Expr123Get();
        }
        if ((expressionId == 124)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext124 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext124.ValueType___Expr124Get();
        }
        if ((expressionId == 125)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext125 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext125.GetLocation<double>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 126)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext126 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext126.ValueType___Expr126Get();
        }
        if ((expressionId == 127)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext127 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext127.GetLocation<int>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 128)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext128 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext128.ValueType___Expr128Get();
        }
        if ((expressionId == 129)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext129 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext129.GetLocation<int>(refDataContext129.ValueType___Expr129Get, refDataContext129.ValueType___Expr129Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 130)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext130 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext130.ValueType___Expr130Get();
        }
        if ((expressionId == 131)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext131 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext131.GetLocation<int>(refDataContext131.ValueType___Expr131Get, refDataContext131.ValueType___Expr131Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 132)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext132 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext132.ValueType___Expr132Get();
        }
        if ((expressionId == 133)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext133 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext133.ValueType___Expr133Get();
        }
        if ((expressionId == 134)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext134 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext134.ValueType___Expr134Get();
        }
        if ((expressionId == 135)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext135 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext135.GetLocation<double>(refDataContext135.ValueType___Expr135Get, refDataContext135.ValueType___Expr135Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 136)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext136 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext136.ValueType___Expr136Get();
        }
        if ((expressionId == 137)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext137 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext137.GetLocation<double>(refDataContext137.ValueType___Expr137Get, refDataContext137.ValueType___Expr137Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 138)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext138 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext138.ValueType___Expr138Get();
        }
        if ((expressionId == 139)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext139 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext139.GetLocation<double>(refDataContext139.ValueType___Expr139Get, refDataContext139.ValueType___Expr139Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 140)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext140 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext140.ValueType___Expr140Get();
        }
        if ((expressionId == 141)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext141 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext141.ValueType___Expr141Get();
        }
        if ((expressionId == 142)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext142 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext142.GetLocation<double>(refDataContext142.ValueType___Expr142Get, refDataContext142.ValueType___Expr142Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 143)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext143 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext143.ValueType___Expr143Get();
        }
        if ((expressionId == 144)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext144 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext144.ValueType___Expr144Get();
        }
        if ((expressionId == 145)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext145 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext145.GetLocation<double>(refDataContext145.ValueType___Expr145Get, refDataContext145.ValueType___Expr145Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 146)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext146 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext146.ValueType___Expr146Get();
        }
        if ((expressionId == 147)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext147 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext147.GetLocation<double>(refDataContext147.ValueType___Expr147Get, refDataContext147.ValueType___Expr147Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 148)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext148 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext148.ValueType___Expr148Get();
        }
        if ((expressionId == 149)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext149 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext149.GetLocation<double>(refDataContext149.ValueType___Expr149Get, refDataContext149.ValueType___Expr149Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 150)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[23] == null)) {
                cachedCompiledDataContext[23] = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext150 = ((F1040EZLinesCalculation_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[23]));
            return valDataContext150.ValueType___Expr150Get();
        }
        if ((expressionId == 151)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[24] == null)) {
                cachedCompiledDataContext[24] = new F1040EZLinesCalculation_TypedDataContext15(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext15 refDataContext151 = ((F1040EZLinesCalculation_TypedDataContext15)(cachedCompiledDataContext[24]));
            return refDataContext151.GetLocation<double>(refDataContext151.ValueType___Expr151Get, refDataContext151.ValueType___Expr151Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 152)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[25] == null)) {
                cachedCompiledDataContext[25] = new F1040EZLinesCalculation_TypedDataContext16_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext16_ForReadOnly valDataContext152 = ((F1040EZLinesCalculation_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[25]));
            return valDataContext152.ValueType___Expr152Get();
        }
        if ((expressionId == 153)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[25] == null)) {
                cachedCompiledDataContext[25] = new F1040EZLinesCalculation_TypedDataContext16_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext16_ForReadOnly valDataContext153 = ((F1040EZLinesCalculation_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[25]));
            return valDataContext153.ValueType___Expr153Get();
        }
        if ((expressionId == 154)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext17_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[26] == null)) {
                cachedCompiledDataContext[26] = new F1040EZLinesCalculation_TypedDataContext17_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext17_ForReadOnly valDataContext154 = ((F1040EZLinesCalculation_TypedDataContext17_ForReadOnly)(cachedCompiledDataContext[26]));
            return valDataContext154.ValueType___Expr154Get();
        }
        if ((expressionId == 155)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext17_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[26] == null)) {
                cachedCompiledDataContext[26] = new F1040EZLinesCalculation_TypedDataContext17_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext17_ForReadOnly valDataContext155 = ((F1040EZLinesCalculation_TypedDataContext17_ForReadOnly)(cachedCompiledDataContext[26]));
            return valDataContext155.ValueType___Expr155Get();
        }
        if ((expressionId == 156)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[27] == null)) {
                cachedCompiledDataContext[27] = new F1040EZLinesCalculation_TypedDataContext18_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext18_ForReadOnly valDataContext156 = ((F1040EZLinesCalculation_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[27]));
            return valDataContext156.ValueType___Expr156Get();
        }
        if ((expressionId == 157)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[27] == null)) {
                cachedCompiledDataContext[27] = new F1040EZLinesCalculation_TypedDataContext18_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext18_ForReadOnly valDataContext157 = ((F1040EZLinesCalculation_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[27]));
            return valDataContext157.ValueType___Expr157Get();
        }
        if ((expressionId == 158)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext18.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[28] == null)) {
                cachedCompiledDataContext[28] = new F1040EZLinesCalculation_TypedDataContext18(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext18 refDataContext158 = ((F1040EZLinesCalculation_TypedDataContext18)(cachedCompiledDataContext[28]));
            return refDataContext158.GetLocation<double>(refDataContext158.ValueType___Expr158Get, refDataContext158.ValueType___Expr158Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 159)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext159 = ((F1040EZLinesCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext159.ValueType___Expr159Get();
        }
        if ((expressionId == 160)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EZLinesCalculation_TypedDataContext2(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2 refDataContext160 = ((F1040EZLinesCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext160.GetLocation<double>(refDataContext160.ValueType___Expr160Get, refDataContext160.ValueType___Expr160Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 161)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext19_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[29] == null)) {
                cachedCompiledDataContext[29] = new F1040EZLinesCalculation_TypedDataContext19_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext19_ForReadOnly valDataContext161 = ((F1040EZLinesCalculation_TypedDataContext19_ForReadOnly)(cachedCompiledDataContext[29]));
            return valDataContext161.ValueType___Expr161Get();
        }
        if ((expressionId == 162)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext19_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[29] == null)) {
                cachedCompiledDataContext[29] = new F1040EZLinesCalculation_TypedDataContext19_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext19_ForReadOnly valDataContext162 = ((F1040EZLinesCalculation_TypedDataContext19_ForReadOnly)(cachedCompiledDataContext[29]));
            return valDataContext162.ValueType___Expr162Get();
        }
        if ((expressionId == 163)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext163 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext163.ValueType___Expr163Get();
        }
        if ((expressionId == 164)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext164 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext164.ValueType___Expr164Get();
        }
        if ((expressionId == 165)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext165 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext165.ValueType___Expr165Get();
        }
        if ((expressionId == 166)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext166 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext166.GetLocation<double>(refDataContext166.ValueType___Expr166Get, refDataContext166.ValueType___Expr166Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 167)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext167 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext167.ValueType___Expr167Get();
        }
        if ((expressionId == 168)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext168 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext168.GetLocation<double>(refDataContext168.ValueType___Expr168Get, refDataContext168.ValueType___Expr168Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 169)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext169 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext169.ValueType___Expr169Get();
        }
        if ((expressionId == 170)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext170 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext170.ValueType___Expr170Get();
        }
        if ((expressionId == 171)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext171 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext171.GetLocation<double>(refDataContext171.ValueType___Expr171Get, refDataContext171.ValueType___Expr171Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 172)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext172 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext172.GetLocation<bool>(refDataContext172.ValueType___Expr172Get, refDataContext172.ValueType___Expr172Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 173)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext173 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext173.ValueType___Expr173Get();
        }
        if ((expressionId == 174)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext174 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext174.ValueType___Expr174Get();
        }
        if ((expressionId == 175)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext175 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext175.GetLocation<double>(refDataContext175.ValueType___Expr175Get, refDataContext175.ValueType___Expr175Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 176)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext176 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext176.ValueType___Expr176Get();
        }
        if ((expressionId == 177)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext177 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext177.GetLocation<double>(refDataContext177.ValueType___Expr177Get, refDataContext177.ValueType___Expr177Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 178)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext178 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext178.ValueType___Expr178Get();
        }
        if ((expressionId == 179)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext179 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext179.ValueType___Expr179Get();
        }
        if ((expressionId == 180)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext180 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext180.GetLocation<double>(refDataContext180.ValueType___Expr180Get, refDataContext180.ValueType___Expr180Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 181)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext181 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext181.ValueType___Expr181Get();
        }
        if ((expressionId == 182)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext182 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext182.GetLocation<double>(refDataContext182.ValueType___Expr182Get, refDataContext182.ValueType___Expr182Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 183)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext183 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext183.GetLocation<bool>(refDataContext183.ValueType___Expr183Get, refDataContext183.ValueType___Expr183Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 184)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext184 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext184.ValueType___Expr184Get();
        }
        if ((expressionId == 185)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext185 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext185.ValueType___Expr185Get();
        }
        if ((expressionId == 186)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext186 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext186.GetLocation<double>(refDataContext186.ValueType___Expr186Get, refDataContext186.ValueType___Expr186Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 187)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext187 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext187.ValueType___Expr187Get();
        }
        if ((expressionId == 188)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext188 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext188.GetLocation<double>(refDataContext188.ValueType___Expr188Get, refDataContext188.ValueType___Expr188Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 189)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext189 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext189.ValueType___Expr189Get();
        }
        if ((expressionId == 190)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext190 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext190.ValueType___Expr190Get();
        }
        if ((expressionId == 191)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext191 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext191.GetLocation<double>(refDataContext191.ValueType___Expr191Get, refDataContext191.ValueType___Expr191Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 192)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext192 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext192.ValueType___Expr192Get();
        }
        if ((expressionId == 193)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext193 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext193.GetLocation<double>(refDataContext193.ValueType___Expr193Get, refDataContext193.ValueType___Expr193Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 194)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext194 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext194.GetLocation<bool>(refDataContext194.ValueType___Expr194Get, refDataContext194.ValueType___Expr194Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 195)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext195 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext195.ValueType___Expr195Get();
        }
        if ((expressionId == 196)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext196 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext196.ValueType___Expr196Get();
        }
        if ((expressionId == 197)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext197 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext197.GetLocation<double>(refDataContext197.ValueType___Expr197Get, refDataContext197.ValueType___Expr197Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 198)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext198 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext198.ValueType___Expr198Get();
        }
        if ((expressionId == 199)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext199 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext199.GetLocation<double>(refDataContext199.ValueType___Expr199Get, refDataContext199.ValueType___Expr199Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 200)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext200 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext200.ValueType___Expr200Get();
        }
        if ((expressionId == 201)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext201 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext201.ValueType___Expr201Get();
        }
        if ((expressionId == 202)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext202 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext202.GetLocation<double>(refDataContext202.ValueType___Expr202Get, refDataContext202.ValueType___Expr202Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 203)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext203 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext203.ValueType___Expr203Get();
        }
        if ((expressionId == 204)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext204 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext204.GetLocation<double>(refDataContext204.ValueType___Expr204Get, refDataContext204.ValueType___Expr204Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 205)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext205 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext205.GetLocation<bool>(refDataContext205.ValueType___Expr205Get, refDataContext205.ValueType___Expr205Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 206)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext206 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext206.ValueType___Expr206Get();
        }
        if ((expressionId == 207)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext207 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext207.ValueType___Expr207Get();
        }
        if ((expressionId == 208)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext208 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext208.GetLocation<double>(refDataContext208.ValueType___Expr208Get, refDataContext208.ValueType___Expr208Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 209)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext209 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext209.ValueType___Expr209Get();
        }
        if ((expressionId == 210)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext210 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext210.GetLocation<double>(refDataContext210.ValueType___Expr210Get, refDataContext210.ValueType___Expr210Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 211)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext211 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext211.ValueType___Expr211Get();
        }
        if ((expressionId == 212)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext212 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext212.ValueType___Expr212Get();
        }
        if ((expressionId == 213)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext213 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext213.GetLocation<double>(refDataContext213.ValueType___Expr213Get, refDataContext213.ValueType___Expr213Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 214)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext214 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext214.ValueType___Expr214Get();
        }
        if ((expressionId == 215)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext215 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext215.GetLocation<double>(refDataContext215.ValueType___Expr215Get, refDataContext215.ValueType___Expr215Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 216)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext216 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext216.GetLocation<bool>(refDataContext216.ValueType___Expr216Get, refDataContext216.ValueType___Expr216Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 217)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext217 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext217.ValueType___Expr217Get();
        }
        if ((expressionId == 218)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext218 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext218.ValueType___Expr218Get();
        }
        if ((expressionId == 219)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext219 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext219.GetLocation<double>(refDataContext219.ValueType___Expr219Get, refDataContext219.ValueType___Expr219Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 220)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext220 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext220.ValueType___Expr220Get();
        }
        if ((expressionId == 221)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext221 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext221.GetLocation<double>(refDataContext221.ValueType___Expr221Get, refDataContext221.ValueType___Expr221Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 222)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext222 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext222.ValueType___Expr222Get();
        }
        if ((expressionId == 223)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext223 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext223.ValueType___Expr223Get();
        }
        if ((expressionId == 224)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext224 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext224.GetLocation<double>(refDataContext224.ValueType___Expr224Get, refDataContext224.ValueType___Expr224Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 225)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext225 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext225.ValueType___Expr225Get();
        }
        if ((expressionId == 226)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext226 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext226.GetLocation<double>(refDataContext226.ValueType___Expr226Get, refDataContext226.ValueType___Expr226Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 227)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext227 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext227.GetLocation<bool>(refDataContext227.ValueType___Expr227Get, refDataContext227.ValueType___Expr227Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 228)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext228 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext228.ValueType___Expr228Get();
        }
        if ((expressionId == 229)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext229 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext229.ValueType___Expr229Get();
        }
        if ((expressionId == 230)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext230 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext230.GetLocation<double>(refDataContext230.ValueType___Expr230Get, refDataContext230.ValueType___Expr230Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 231)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[30] == null)) {
                cachedCompiledDataContext[30] = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext231 = ((F1040EZLinesCalculation_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[30]));
            return valDataContext231.ValueType___Expr231Get();
        }
        if ((expressionId == 232)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[31] == null)) {
                cachedCompiledDataContext[31] = new F1040EZLinesCalculation_TypedDataContext20(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext20 refDataContext232 = ((F1040EZLinesCalculation_TypedDataContext20)(cachedCompiledDataContext[31]));
            return refDataContext232.GetLocation<double>(refDataContext232.ValueType___Expr232Get, refDataContext232.ValueType___Expr232Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 233)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext19_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[29] == null)) {
                cachedCompiledDataContext[29] = new F1040EZLinesCalculation_TypedDataContext19_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext19_ForReadOnly valDataContext233 = ((F1040EZLinesCalculation_TypedDataContext19_ForReadOnly)(cachedCompiledDataContext[29]));
            return valDataContext233.ValueType___Expr233Get();
        }
        if ((expressionId == 234)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext19.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[32] == null)) {
                cachedCompiledDataContext[32] = new F1040EZLinesCalculation_TypedDataContext19(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext19 refDataContext234 = ((F1040EZLinesCalculation_TypedDataContext19)(cachedCompiledDataContext[32]));
            return refDataContext234.GetLocation<double>(refDataContext234.ValueType___Expr234Get, refDataContext234.ValueType___Expr234Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 235)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext235 = ((F1040EZLinesCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext235.ValueType___Expr235Get();
        }
        if ((expressionId == 236)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext236 = ((F1040EZLinesCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext236.ValueType___Expr236Get();
        }
        if ((expressionId == 237)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EZLinesCalculation_TypedDataContext2(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2 refDataContext237 = ((F1040EZLinesCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext237.GetLocation<double>(refDataContext237.ValueType___Expr237Get, refDataContext237.ValueType___Expr237Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 238)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EZLinesCalculation_TypedDataContext2(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2 refDataContext238 = ((F1040EZLinesCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext238.GetLocation<double>(refDataContext238.ValueType___Expr238Get, refDataContext238.ValueType___Expr238Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 239)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[0] == null)) {
                cachedCompiledDataContext[0] = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext239 = ((F1040EZLinesCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
            return valDataContext239.ValueType___Expr239Get();
        }
        if ((expressionId == 240)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EZLinesCalculation_TypedDataContext2(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2 refDataContext240 = ((F1040EZLinesCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext240.GetLocation<double>(refDataContext240.ValueType___Expr240Get, refDataContext240.ValueType___Expr240Set, expressionId, this.rootActivity, activityContext);
        }
        if ((expressionId == 241)) {
            System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZLinesCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 33);
            if ((cachedCompiledDataContext[1] == null)) {
                cachedCompiledDataContext[1] = new F1040EZLinesCalculation_TypedDataContext2(locations, activityContext, true);
            }
            F1040EZLinesCalculation_TypedDataContext2 refDataContext241 = ((F1040EZLinesCalculation_TypedDataContext2)(cachedCompiledDataContext[1]));
            return refDataContext241.GetLocation<double>(refDataContext241.ValueType___Expr241Get, refDataContext241.ValueType___Expr241Set, expressionId, this.rootActivity, activityContext);
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
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext0 = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext0.ValueType___Expr0Get();
        }
        if ((expressionId == 1)) {
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext1 = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext1.ValueType___Expr1Get();
        }
        if ((expressionId == 2)) {
            F1040EZLinesCalculation_TypedDataContext2 refDataContext2 = new F1040EZLinesCalculation_TypedDataContext2(locations, true);
            return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.OutputForms>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
        }
        if ((expressionId == 3)) {
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext3 = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext3.ValueType___Expr3Get();
        }
        if ((expressionId == 4)) {
            F1040EZLinesCalculation_TypedDataContext2 refDataContext4 = new F1040EZLinesCalculation_TypedDataContext2(locations, true);
            return refDataContext4.GetLocation<JTL.Tax1040.BusinessObject.Tax1040EZPage1>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
        }
        if ((expressionId == 5)) {
            F1040EZLinesCalculation_TypedDataContext3_ForReadOnly valDataContext5 = new F1040EZLinesCalculation_TypedDataContext3_ForReadOnly(locations, true);
            return valDataContext5.ValueType___Expr5Get();
        }
        if ((expressionId == 6)) {
            F1040EZLinesCalculation_TypedDataContext3_ForReadOnly valDataContext6 = new F1040EZLinesCalculation_TypedDataContext3_ForReadOnly(locations, true);
            return valDataContext6.ValueType___Expr6Get();
        }
        if ((expressionId == 7)) {
            F1040EZLinesCalculation_TypedDataContext4_ForReadOnly valDataContext7 = new F1040EZLinesCalculation_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext7.ValueType___Expr7Get();
        }
        if ((expressionId == 8)) {
            F1040EZLinesCalculation_TypedDataContext4 refDataContext8 = new F1040EZLinesCalculation_TypedDataContext4(locations, true);
            return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
        }
        if ((expressionId == 9)) {
            F1040EZLinesCalculation_TypedDataContext4_ForReadOnly valDataContext9 = new F1040EZLinesCalculation_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext9.ValueType___Expr9Get();
        }
        if ((expressionId == 10)) {
            F1040EZLinesCalculation_TypedDataContext4_ForReadOnly valDataContext10 = new F1040EZLinesCalculation_TypedDataContext4_ForReadOnly(locations, true);
            return valDataContext10.ValueType___Expr10Get();
        }
        if ((expressionId == 11)) {
            F1040EZLinesCalculation_TypedDataContext4 refDataContext11 = new F1040EZLinesCalculation_TypedDataContext4(locations, true);
            return refDataContext11.GetLocation<double>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
        }
        if ((expressionId == 12)) {
            F1040EZLinesCalculation_TypedDataContext5_ForReadOnly valDataContext12 = new F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(locations, true);
            return valDataContext12.ValueType___Expr12Get();
        }
        if ((expressionId == 13)) {
            F1040EZLinesCalculation_TypedDataContext5_ForReadOnly valDataContext13 = new F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(locations, true);
            return valDataContext13.ValueType___Expr13Get();
        }
        if ((expressionId == 14)) {
            F1040EZLinesCalculation_TypedDataContext6_ForReadOnly valDataContext14 = new F1040EZLinesCalculation_TypedDataContext6_ForReadOnly(locations, true);
            return valDataContext14.ValueType___Expr14Get();
        }
        if ((expressionId == 15)) {
            F1040EZLinesCalculation_TypedDataContext6 refDataContext15 = new F1040EZLinesCalculation_TypedDataContext6(locations, true);
            return refDataContext15.GetLocation<double>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
        }
        if ((expressionId == 16)) {
            F1040EZLinesCalculation_TypedDataContext6_ForReadOnly valDataContext16 = new F1040EZLinesCalculation_TypedDataContext6_ForReadOnly(locations, true);
            return valDataContext16.ValueType___Expr16Get();
        }
        if ((expressionId == 17)) {
            F1040EZLinesCalculation_TypedDataContext6_ForReadOnly valDataContext17 = new F1040EZLinesCalculation_TypedDataContext6_ForReadOnly(locations, true);
            return valDataContext17.ValueType___Expr17Get();
        }
        if ((expressionId == 18)) {
            F1040EZLinesCalculation_TypedDataContext6 refDataContext18 = new F1040EZLinesCalculation_TypedDataContext6(locations, true);
            return refDataContext18.GetLocation<double>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
        }
        if ((expressionId == 19)) {
            F1040EZLinesCalculation_TypedDataContext5_ForReadOnly valDataContext19 = new F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(locations, true);
            return valDataContext19.ValueType___Expr19Get();
        }
        if ((expressionId == 20)) {
            F1040EZLinesCalculation_TypedDataContext5_ForReadOnly valDataContext20 = new F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(locations, true);
            return valDataContext20.ValueType___Expr20Get();
        }
        if ((expressionId == 21)) {
            F1040EZLinesCalculation_TypedDataContext7_ForReadOnly valDataContext21 = new F1040EZLinesCalculation_TypedDataContext7_ForReadOnly(locations, true);
            return valDataContext21.ValueType___Expr21Get();
        }
        if ((expressionId == 22)) {
            F1040EZLinesCalculation_TypedDataContext7 refDataContext22 = new F1040EZLinesCalculation_TypedDataContext7(locations, true);
            return refDataContext22.GetLocation<double>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set);
        }
        if ((expressionId == 23)) {
            F1040EZLinesCalculation_TypedDataContext7_ForReadOnly valDataContext23 = new F1040EZLinesCalculation_TypedDataContext7_ForReadOnly(locations, true);
            return valDataContext23.ValueType___Expr23Get();
        }
        if ((expressionId == 24)) {
            F1040EZLinesCalculation_TypedDataContext7_ForReadOnly valDataContext24 = new F1040EZLinesCalculation_TypedDataContext7_ForReadOnly(locations, true);
            return valDataContext24.ValueType___Expr24Get();
        }
        if ((expressionId == 25)) {
            F1040EZLinesCalculation_TypedDataContext7 refDataContext25 = new F1040EZLinesCalculation_TypedDataContext7(locations, true);
            return refDataContext25.GetLocation<double>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
        }
        if ((expressionId == 26)) {
            F1040EZLinesCalculation_TypedDataContext8_ForReadOnly valDataContext26 = new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locations, true);
            return valDataContext26.ValueType___Expr26Get();
        }
        if ((expressionId == 27)) {
            F1040EZLinesCalculation_TypedDataContext8_ForReadOnly valDataContext27 = new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locations, true);
            return valDataContext27.ValueType___Expr27Get();
        }
        if ((expressionId == 28)) {
            F1040EZLinesCalculation_TypedDataContext9_ForReadOnly valDataContext28 = new F1040EZLinesCalculation_TypedDataContext9_ForReadOnly(locations, true);
            return valDataContext28.ValueType___Expr28Get();
        }
        if ((expressionId == 29)) {
            F1040EZLinesCalculation_TypedDataContext9 refDataContext29 = new F1040EZLinesCalculation_TypedDataContext9(locations, true);
            return refDataContext29.GetLocation<double>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
        }
        if ((expressionId == 30)) {
            F1040EZLinesCalculation_TypedDataContext9_ForReadOnly valDataContext30 = new F1040EZLinesCalculation_TypedDataContext9_ForReadOnly(locations, true);
            return valDataContext30.ValueType___Expr30Get();
        }
        if ((expressionId == 31)) {
            F1040EZLinesCalculation_TypedDataContext9_ForReadOnly valDataContext31 = new F1040EZLinesCalculation_TypedDataContext9_ForReadOnly(locations, true);
            return valDataContext31.ValueType___Expr31Get();
        }
        if ((expressionId == 32)) {
            F1040EZLinesCalculation_TypedDataContext9 refDataContext32 = new F1040EZLinesCalculation_TypedDataContext9(locations, true);
            return refDataContext32.GetLocation<double>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
        }
        if ((expressionId == 33)) {
            F1040EZLinesCalculation_TypedDataContext8_ForReadOnly valDataContext33 = new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locations, true);
            return valDataContext33.ValueType___Expr33Get();
        }
        if ((expressionId == 34)) {
            F1040EZLinesCalculation_TypedDataContext8_ForReadOnly valDataContext34 = new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locations, true);
            return valDataContext34.ValueType___Expr34Get();
        }
        if ((expressionId == 35)) {
            F1040EZLinesCalculation_TypedDataContext8 refDataContext35 = new F1040EZLinesCalculation_TypedDataContext8(locations, true);
            return refDataContext35.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
        }
        if ((expressionId == 36)) {
            F1040EZLinesCalculation_TypedDataContext8 refDataContext36 = new F1040EZLinesCalculation_TypedDataContext8(locations, true);
            return refDataContext36.GetLocation<double>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
        }
        if ((expressionId == 37)) {
            F1040EZLinesCalculation_TypedDataContext8_ForReadOnly valDataContext37 = new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locations, true);
            return valDataContext37.ValueType___Expr37Get();
        }
        if ((expressionId == 38)) {
            F1040EZLinesCalculation_TypedDataContext8 refDataContext38 = new F1040EZLinesCalculation_TypedDataContext8(locations, true);
            return refDataContext38.GetLocation<double>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
        }
        if ((expressionId == 39)) {
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext39 = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext39.ValueType___Expr39Get();
        }
        if ((expressionId == 40)) {
            F1040EZLinesCalculation_TypedDataContext2 refDataContext40 = new F1040EZLinesCalculation_TypedDataContext2(locations, true);
            return refDataContext40.GetLocation<double>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set);
        }
        if ((expressionId == 41)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext41 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext41.ValueType___Expr41Get();
        }
        if ((expressionId == 42)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext42 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext42.ValueType___Expr42Get();
        }
        if ((expressionId == 43)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext43 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext43.ValueType___Expr43Get();
        }
        if ((expressionId == 44)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext44 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
        }
        if ((expressionId == 45)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext45 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext45.ValueType___Expr45Get();
        }
        if ((expressionId == 46)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext46 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext46.ValueType___Expr46Get();
        }
        if ((expressionId == 47)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext47 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext47.GetLocation<double>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
        }
        if ((expressionId == 48)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext48 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext48.ValueType___Expr48Get();
        }
        if ((expressionId == 49)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext49 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set);
        }
        if ((expressionId == 50)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext50 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext50.ValueType___Expr50Get();
        }
        if ((expressionId == 51)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext51 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext51.GetLocation<double>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
        }
        if ((expressionId == 52)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext52 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext52.ValueType___Expr52Get();
        }
        if ((expressionId == 53)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext53 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext53.GetLocation<double>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set);
        }
        if ((expressionId == 54)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext54 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext54.ValueType___Expr54Get();
        }
        if ((expressionId == 55)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext55 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext55.GetLocation<double>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set);
        }
        if ((expressionId == 56)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext56 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext56.ValueType___Expr56Get();
        }
        if ((expressionId == 57)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext57 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext57.GetLocation<double>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set);
        }
        if ((expressionId == 58)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext58 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext58.ValueType___Expr58Get();
        }
        if ((expressionId == 59)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext59 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext59.GetLocation<double>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
        }
        if ((expressionId == 60)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext60 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext60.ValueType___Expr60Get();
        }
        if ((expressionId == 61)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext61 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext61.GetLocation<double>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
        }
        if ((expressionId == 62)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext62 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext62.ValueType___Expr62Get();
        }
        if ((expressionId == 63)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext63 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext63.ValueType___Expr63Get();
        }
        if ((expressionId == 64)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext64 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext64.GetLocation<double>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set);
        }
        if ((expressionId == 65)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext65 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext65.ValueType___Expr65Get();
        }
        if ((expressionId == 66)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext66 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext66.ValueType___Expr66Get();
        }
        if ((expressionId == 67)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext67 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext67.GetLocation<double>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set);
        }
        if ((expressionId == 68)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext68 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext68.ValueType___Expr68Get();
        }
        if ((expressionId == 69)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext69 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext69.GetLocation<double>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set);
        }
        if ((expressionId == 70)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext70 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext70.ValueType___Expr70Get();
        }
        if ((expressionId == 71)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext71 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext71.GetLocation<double>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set);
        }
        if ((expressionId == 72)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext72 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext72.ValueType___Expr72Get();
        }
        if ((expressionId == 73)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext73 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext73.GetLocation<double>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set);
        }
        if ((expressionId == 74)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext74 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext74.ValueType___Expr74Get();
        }
        if ((expressionId == 75)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext75 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext75.GetLocation<double>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set);
        }
        if ((expressionId == 76)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext76 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext76.ValueType___Expr76Get();
        }
        if ((expressionId == 77)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext77 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext77.GetLocation<double>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set);
        }
        if ((expressionId == 78)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext78 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext78.ValueType___Expr78Get();
        }
        if ((expressionId == 79)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext79 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext79.GetLocation<double>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set);
        }
        if ((expressionId == 80)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext80 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext80.ValueType___Expr80Get();
        }
        if ((expressionId == 81)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext81 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext81.GetLocation<double>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set);
        }
        if ((expressionId == 82)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext82 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext82.ValueType___Expr82Get();
        }
        if ((expressionId == 83)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext83 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext83.ValueType___Expr83Get();
        }
        if ((expressionId == 84)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext84 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext84.GetLocation<double>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set);
        }
        if ((expressionId == 85)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext85 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext85.ValueType___Expr85Get();
        }
        if ((expressionId == 86)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext86 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext86.GetLocation<double>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set);
        }
        if ((expressionId == 87)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext87 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext87.ValueType___Expr87Get();
        }
        if ((expressionId == 88)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext88 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext88.GetLocation<double>(refDataContext88.ValueType___Expr88Get, refDataContext88.ValueType___Expr88Set);
        }
        if ((expressionId == 89)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext89 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext89.ValueType___Expr89Get();
        }
        if ((expressionId == 90)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext90 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext90.GetLocation<double>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set);
        }
        if ((expressionId == 91)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext91 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext91.ValueType___Expr91Get();
        }
        if ((expressionId == 92)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext92 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext92.GetLocation<double>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set);
        }
        if ((expressionId == 93)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext93 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext93.ValueType___Expr93Get();
        }
        if ((expressionId == 94)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext94 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext94.GetLocation<double>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set);
        }
        if ((expressionId == 95)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext95 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext95.ValueType___Expr95Get();
        }
        if ((expressionId == 96)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext96 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext96.GetLocation<double>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set);
        }
        if ((expressionId == 97)) {
            F1040EZLinesCalculation_TypedDataContext10_ForReadOnly valDataContext97 = new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locations, true);
            return valDataContext97.ValueType___Expr97Get();
        }
        if ((expressionId == 98)) {
            F1040EZLinesCalculation_TypedDataContext10 refDataContext98 = new F1040EZLinesCalculation_TypedDataContext10(locations, true);
            return refDataContext98.GetLocation<double>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set);
        }
        if ((expressionId == 99)) {
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext99 = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext99.ValueType___Expr99Get();
        }
        if ((expressionId == 100)) {
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext100 = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext100.ValueType___Expr100Get();
        }
        if ((expressionId == 101)) {
            F1040EZLinesCalculation_TypedDataContext2 refDataContext101 = new F1040EZLinesCalculation_TypedDataContext2(locations, true);
            return refDataContext101.GetLocation<double>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set);
        }
        if ((expressionId == 102)) {
            F1040EZLinesCalculation_TypedDataContext2 refDataContext102 = new F1040EZLinesCalculation_TypedDataContext2(locations, true);
            return refDataContext102.GetLocation<double>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set);
        }
        if ((expressionId == 103)) {
            F1040EZLinesCalculation_TypedDataContext11_ForReadOnly valDataContext103 = new F1040EZLinesCalculation_TypedDataContext11_ForReadOnly(locations, true);
            return valDataContext103.ValueType___Expr103Get();
        }
        if ((expressionId == 104)) {
            F1040EZLinesCalculation_TypedDataContext11 refDataContext104 = new F1040EZLinesCalculation_TypedDataContext11(locations, true);
            return refDataContext104.GetLocation<double>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set);
        }
        if ((expressionId == 105)) {
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext105 = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, true);
            return valDataContext105.ValueType___Expr105Get();
        }
        if ((expressionId == 106)) {
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext106 = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, true);
            return valDataContext106.ValueType___Expr106Get();
        }
        if ((expressionId == 107)) {
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext107 = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, true);
            return valDataContext107.ValueType___Expr107Get();
        }
        if ((expressionId == 108)) {
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext108 = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, true);
            return valDataContext108.ValueType___Expr108Get();
        }
        if ((expressionId == 109)) {
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext109 = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, true);
            return valDataContext109.ValueType___Expr109Get();
        }
        if ((expressionId == 110)) {
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext110 = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, true);
            return valDataContext110.ValueType___Expr110Get();
        }
        if ((expressionId == 111)) {
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext111 = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, true);
            return valDataContext111.ValueType___Expr111Get();
        }
        if ((expressionId == 112)) {
            F1040EZLinesCalculation_TypedDataContext12_ForReadOnly valDataContext112 = new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locations, true);
            return valDataContext112.ValueType___Expr112Get();
        }
        if ((expressionId == 113)) {
            F1040EZLinesCalculation_TypedDataContext13_ForReadOnly valDataContext113 = new F1040EZLinesCalculation_TypedDataContext13_ForReadOnly(locations, true);
            return valDataContext113.ValueType___Expr113Get();
        }
        if ((expressionId == 114)) {
            F1040EZLinesCalculation_TypedDataContext13_ForReadOnly valDataContext114 = new F1040EZLinesCalculation_TypedDataContext13_ForReadOnly(locations, true);
            return valDataContext114.ValueType___Expr114Get();
        }
        if ((expressionId == 115)) {
            F1040EZLinesCalculation_TypedDataContext14_ForReadOnly valDataContext115 = new F1040EZLinesCalculation_TypedDataContext14_ForReadOnly(locations, true);
            return valDataContext115.ValueType___Expr115Get();
        }
        if ((expressionId == 116)) {
            F1040EZLinesCalculation_TypedDataContext14 refDataContext116 = new F1040EZLinesCalculation_TypedDataContext14(locations, true);
            return refDataContext116.GetLocation<double>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set);
        }
        if ((expressionId == 117)) {
            F1040EZLinesCalculation_TypedDataContext14_ForReadOnly valDataContext117 = new F1040EZLinesCalculation_TypedDataContext14_ForReadOnly(locations, true);
            return valDataContext117.ValueType___Expr117Get();
        }
        if ((expressionId == 118)) {
            F1040EZLinesCalculation_TypedDataContext14 refDataContext118 = new F1040EZLinesCalculation_TypedDataContext14(locations, true);
            return refDataContext118.GetLocation<double>(refDataContext118.ValueType___Expr118Get, refDataContext118.ValueType___Expr118Set);
        }
        if ((expressionId == 119)) {
            F1040EZLinesCalculation_TypedDataContext13_ForReadOnly valDataContext119 = new F1040EZLinesCalculation_TypedDataContext13_ForReadOnly(locations, true);
            return valDataContext119.ValueType___Expr119Get();
        }
        if ((expressionId == 120)) {
            F1040EZLinesCalculation_TypedDataContext13 refDataContext120 = new F1040EZLinesCalculation_TypedDataContext13(locations, true);
            return refDataContext120.GetLocation<double>(refDataContext120.ValueType___Expr120Get, refDataContext120.ValueType___Expr120Set);
        }
        if ((expressionId == 121)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext121 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext121.ValueType___Expr121Get();
        }
        if ((expressionId == 122)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext122 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext122.GetLocation<int>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set);
        }
        if ((expressionId == 123)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext123 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext123.ValueType___Expr123Get();
        }
        if ((expressionId == 124)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext124 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext124.ValueType___Expr124Get();
        }
        if ((expressionId == 125)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext125 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext125.GetLocation<double>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set);
        }
        if ((expressionId == 126)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext126 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext126.ValueType___Expr126Get();
        }
        if ((expressionId == 127)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext127 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext127.GetLocation<int>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set);
        }
        if ((expressionId == 128)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext128 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext128.ValueType___Expr128Get();
        }
        if ((expressionId == 129)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext129 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext129.GetLocation<int>(refDataContext129.ValueType___Expr129Get, refDataContext129.ValueType___Expr129Set);
        }
        if ((expressionId == 130)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext130 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext130.ValueType___Expr130Get();
        }
        if ((expressionId == 131)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext131 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext131.GetLocation<int>(refDataContext131.ValueType___Expr131Get, refDataContext131.ValueType___Expr131Set);
        }
        if ((expressionId == 132)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext132 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext132.ValueType___Expr132Get();
        }
        if ((expressionId == 133)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext133 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext133.ValueType___Expr133Get();
        }
        if ((expressionId == 134)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext134 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext134.ValueType___Expr134Get();
        }
        if ((expressionId == 135)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext135 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext135.GetLocation<double>(refDataContext135.ValueType___Expr135Get, refDataContext135.ValueType___Expr135Set);
        }
        if ((expressionId == 136)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext136 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext136.ValueType___Expr136Get();
        }
        if ((expressionId == 137)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext137 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext137.GetLocation<double>(refDataContext137.ValueType___Expr137Get, refDataContext137.ValueType___Expr137Set);
        }
        if ((expressionId == 138)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext138 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext138.ValueType___Expr138Get();
        }
        if ((expressionId == 139)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext139 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext139.GetLocation<double>(refDataContext139.ValueType___Expr139Get, refDataContext139.ValueType___Expr139Set);
        }
        if ((expressionId == 140)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext140 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext140.ValueType___Expr140Get();
        }
        if ((expressionId == 141)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext141 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext141.ValueType___Expr141Get();
        }
        if ((expressionId == 142)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext142 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext142.GetLocation<double>(refDataContext142.ValueType___Expr142Get, refDataContext142.ValueType___Expr142Set);
        }
        if ((expressionId == 143)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext143 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext143.ValueType___Expr143Get();
        }
        if ((expressionId == 144)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext144 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext144.ValueType___Expr144Get();
        }
        if ((expressionId == 145)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext145 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext145.GetLocation<double>(refDataContext145.ValueType___Expr145Get, refDataContext145.ValueType___Expr145Set);
        }
        if ((expressionId == 146)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext146 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext146.ValueType___Expr146Get();
        }
        if ((expressionId == 147)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext147 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext147.GetLocation<double>(refDataContext147.ValueType___Expr147Get, refDataContext147.ValueType___Expr147Set);
        }
        if ((expressionId == 148)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext148 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext148.ValueType___Expr148Get();
        }
        if ((expressionId == 149)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext149 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext149.GetLocation<double>(refDataContext149.ValueType___Expr149Get, refDataContext149.ValueType___Expr149Set);
        }
        if ((expressionId == 150)) {
            F1040EZLinesCalculation_TypedDataContext15_ForReadOnly valDataContext150 = new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locations, true);
            return valDataContext150.ValueType___Expr150Get();
        }
        if ((expressionId == 151)) {
            F1040EZLinesCalculation_TypedDataContext15 refDataContext151 = new F1040EZLinesCalculation_TypedDataContext15(locations, true);
            return refDataContext151.GetLocation<double>(refDataContext151.ValueType___Expr151Get, refDataContext151.ValueType___Expr151Set);
        }
        if ((expressionId == 152)) {
            F1040EZLinesCalculation_TypedDataContext16_ForReadOnly valDataContext152 = new F1040EZLinesCalculation_TypedDataContext16_ForReadOnly(locations, true);
            return valDataContext152.ValueType___Expr152Get();
        }
        if ((expressionId == 153)) {
            F1040EZLinesCalculation_TypedDataContext16_ForReadOnly valDataContext153 = new F1040EZLinesCalculation_TypedDataContext16_ForReadOnly(locations, true);
            return valDataContext153.ValueType___Expr153Get();
        }
        if ((expressionId == 154)) {
            F1040EZLinesCalculation_TypedDataContext17_ForReadOnly valDataContext154 = new F1040EZLinesCalculation_TypedDataContext17_ForReadOnly(locations, true);
            return valDataContext154.ValueType___Expr154Get();
        }
        if ((expressionId == 155)) {
            F1040EZLinesCalculation_TypedDataContext17_ForReadOnly valDataContext155 = new F1040EZLinesCalculation_TypedDataContext17_ForReadOnly(locations, true);
            return valDataContext155.ValueType___Expr155Get();
        }
        if ((expressionId == 156)) {
            F1040EZLinesCalculation_TypedDataContext18_ForReadOnly valDataContext156 = new F1040EZLinesCalculation_TypedDataContext18_ForReadOnly(locations, true);
            return valDataContext156.ValueType___Expr156Get();
        }
        if ((expressionId == 157)) {
            F1040EZLinesCalculation_TypedDataContext18_ForReadOnly valDataContext157 = new F1040EZLinesCalculation_TypedDataContext18_ForReadOnly(locations, true);
            return valDataContext157.ValueType___Expr157Get();
        }
        if ((expressionId == 158)) {
            F1040EZLinesCalculation_TypedDataContext18 refDataContext158 = new F1040EZLinesCalculation_TypedDataContext18(locations, true);
            return refDataContext158.GetLocation<double>(refDataContext158.ValueType___Expr158Get, refDataContext158.ValueType___Expr158Set);
        }
        if ((expressionId == 159)) {
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext159 = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext159.ValueType___Expr159Get();
        }
        if ((expressionId == 160)) {
            F1040EZLinesCalculation_TypedDataContext2 refDataContext160 = new F1040EZLinesCalculation_TypedDataContext2(locations, true);
            return refDataContext160.GetLocation<double>(refDataContext160.ValueType___Expr160Get, refDataContext160.ValueType___Expr160Set);
        }
        if ((expressionId == 161)) {
            F1040EZLinesCalculation_TypedDataContext19_ForReadOnly valDataContext161 = new F1040EZLinesCalculation_TypedDataContext19_ForReadOnly(locations, true);
            return valDataContext161.ValueType___Expr161Get();
        }
        if ((expressionId == 162)) {
            F1040EZLinesCalculation_TypedDataContext19_ForReadOnly valDataContext162 = new F1040EZLinesCalculation_TypedDataContext19_ForReadOnly(locations, true);
            return valDataContext162.ValueType___Expr162Get();
        }
        if ((expressionId == 163)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext163 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext163.ValueType___Expr163Get();
        }
        if ((expressionId == 164)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext164 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext164.ValueType___Expr164Get();
        }
        if ((expressionId == 165)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext165 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext165.ValueType___Expr165Get();
        }
        if ((expressionId == 166)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext166 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext166.GetLocation<double>(refDataContext166.ValueType___Expr166Get, refDataContext166.ValueType___Expr166Set);
        }
        if ((expressionId == 167)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext167 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext167.ValueType___Expr167Get();
        }
        if ((expressionId == 168)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext168 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext168.GetLocation<double>(refDataContext168.ValueType___Expr168Get, refDataContext168.ValueType___Expr168Set);
        }
        if ((expressionId == 169)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext169 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext169.ValueType___Expr169Get();
        }
        if ((expressionId == 170)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext170 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext170.ValueType___Expr170Get();
        }
        if ((expressionId == 171)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext171 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext171.GetLocation<double>(refDataContext171.ValueType___Expr171Get, refDataContext171.ValueType___Expr171Set);
        }
        if ((expressionId == 172)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext172 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext172.GetLocation<bool>(refDataContext172.ValueType___Expr172Get, refDataContext172.ValueType___Expr172Set);
        }
        if ((expressionId == 173)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext173 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext173.ValueType___Expr173Get();
        }
        if ((expressionId == 174)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext174 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext174.ValueType___Expr174Get();
        }
        if ((expressionId == 175)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext175 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext175.GetLocation<double>(refDataContext175.ValueType___Expr175Get, refDataContext175.ValueType___Expr175Set);
        }
        if ((expressionId == 176)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext176 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext176.ValueType___Expr176Get();
        }
        if ((expressionId == 177)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext177 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext177.GetLocation<double>(refDataContext177.ValueType___Expr177Get, refDataContext177.ValueType___Expr177Set);
        }
        if ((expressionId == 178)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext178 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext178.ValueType___Expr178Get();
        }
        if ((expressionId == 179)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext179 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext179.ValueType___Expr179Get();
        }
        if ((expressionId == 180)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext180 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext180.GetLocation<double>(refDataContext180.ValueType___Expr180Get, refDataContext180.ValueType___Expr180Set);
        }
        if ((expressionId == 181)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext181 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext181.ValueType___Expr181Get();
        }
        if ((expressionId == 182)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext182 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext182.GetLocation<double>(refDataContext182.ValueType___Expr182Get, refDataContext182.ValueType___Expr182Set);
        }
        if ((expressionId == 183)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext183 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext183.GetLocation<bool>(refDataContext183.ValueType___Expr183Get, refDataContext183.ValueType___Expr183Set);
        }
        if ((expressionId == 184)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext184 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext184.ValueType___Expr184Get();
        }
        if ((expressionId == 185)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext185 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext185.ValueType___Expr185Get();
        }
        if ((expressionId == 186)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext186 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext186.GetLocation<double>(refDataContext186.ValueType___Expr186Get, refDataContext186.ValueType___Expr186Set);
        }
        if ((expressionId == 187)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext187 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext187.ValueType___Expr187Get();
        }
        if ((expressionId == 188)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext188 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext188.GetLocation<double>(refDataContext188.ValueType___Expr188Get, refDataContext188.ValueType___Expr188Set);
        }
        if ((expressionId == 189)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext189 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext189.ValueType___Expr189Get();
        }
        if ((expressionId == 190)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext190 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext190.ValueType___Expr190Get();
        }
        if ((expressionId == 191)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext191 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext191.GetLocation<double>(refDataContext191.ValueType___Expr191Get, refDataContext191.ValueType___Expr191Set);
        }
        if ((expressionId == 192)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext192 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext192.ValueType___Expr192Get();
        }
        if ((expressionId == 193)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext193 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext193.GetLocation<double>(refDataContext193.ValueType___Expr193Get, refDataContext193.ValueType___Expr193Set);
        }
        if ((expressionId == 194)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext194 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext194.GetLocation<bool>(refDataContext194.ValueType___Expr194Get, refDataContext194.ValueType___Expr194Set);
        }
        if ((expressionId == 195)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext195 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext195.ValueType___Expr195Get();
        }
        if ((expressionId == 196)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext196 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext196.ValueType___Expr196Get();
        }
        if ((expressionId == 197)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext197 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext197.GetLocation<double>(refDataContext197.ValueType___Expr197Get, refDataContext197.ValueType___Expr197Set);
        }
        if ((expressionId == 198)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext198 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext198.ValueType___Expr198Get();
        }
        if ((expressionId == 199)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext199 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext199.GetLocation<double>(refDataContext199.ValueType___Expr199Get, refDataContext199.ValueType___Expr199Set);
        }
        if ((expressionId == 200)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext200 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext200.ValueType___Expr200Get();
        }
        if ((expressionId == 201)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext201 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext201.ValueType___Expr201Get();
        }
        if ((expressionId == 202)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext202 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext202.GetLocation<double>(refDataContext202.ValueType___Expr202Get, refDataContext202.ValueType___Expr202Set);
        }
        if ((expressionId == 203)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext203 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext203.ValueType___Expr203Get();
        }
        if ((expressionId == 204)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext204 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext204.GetLocation<double>(refDataContext204.ValueType___Expr204Get, refDataContext204.ValueType___Expr204Set);
        }
        if ((expressionId == 205)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext205 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext205.GetLocation<bool>(refDataContext205.ValueType___Expr205Get, refDataContext205.ValueType___Expr205Set);
        }
        if ((expressionId == 206)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext206 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext206.ValueType___Expr206Get();
        }
        if ((expressionId == 207)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext207 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext207.ValueType___Expr207Get();
        }
        if ((expressionId == 208)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext208 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext208.GetLocation<double>(refDataContext208.ValueType___Expr208Get, refDataContext208.ValueType___Expr208Set);
        }
        if ((expressionId == 209)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext209 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext209.ValueType___Expr209Get();
        }
        if ((expressionId == 210)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext210 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext210.GetLocation<double>(refDataContext210.ValueType___Expr210Get, refDataContext210.ValueType___Expr210Set);
        }
        if ((expressionId == 211)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext211 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext211.ValueType___Expr211Get();
        }
        if ((expressionId == 212)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext212 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext212.ValueType___Expr212Get();
        }
        if ((expressionId == 213)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext213 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext213.GetLocation<double>(refDataContext213.ValueType___Expr213Get, refDataContext213.ValueType___Expr213Set);
        }
        if ((expressionId == 214)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext214 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext214.ValueType___Expr214Get();
        }
        if ((expressionId == 215)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext215 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext215.GetLocation<double>(refDataContext215.ValueType___Expr215Get, refDataContext215.ValueType___Expr215Set);
        }
        if ((expressionId == 216)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext216 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext216.GetLocation<bool>(refDataContext216.ValueType___Expr216Get, refDataContext216.ValueType___Expr216Set);
        }
        if ((expressionId == 217)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext217 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext217.ValueType___Expr217Get();
        }
        if ((expressionId == 218)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext218 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext218.ValueType___Expr218Get();
        }
        if ((expressionId == 219)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext219 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext219.GetLocation<double>(refDataContext219.ValueType___Expr219Get, refDataContext219.ValueType___Expr219Set);
        }
        if ((expressionId == 220)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext220 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext220.ValueType___Expr220Get();
        }
        if ((expressionId == 221)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext221 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext221.GetLocation<double>(refDataContext221.ValueType___Expr221Get, refDataContext221.ValueType___Expr221Set);
        }
        if ((expressionId == 222)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext222 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext222.ValueType___Expr222Get();
        }
        if ((expressionId == 223)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext223 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext223.ValueType___Expr223Get();
        }
        if ((expressionId == 224)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext224 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext224.GetLocation<double>(refDataContext224.ValueType___Expr224Get, refDataContext224.ValueType___Expr224Set);
        }
        if ((expressionId == 225)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext225 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext225.ValueType___Expr225Get();
        }
        if ((expressionId == 226)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext226 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext226.GetLocation<double>(refDataContext226.ValueType___Expr226Get, refDataContext226.ValueType___Expr226Set);
        }
        if ((expressionId == 227)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext227 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext227.GetLocation<bool>(refDataContext227.ValueType___Expr227Get, refDataContext227.ValueType___Expr227Set);
        }
        if ((expressionId == 228)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext228 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext228.ValueType___Expr228Get();
        }
        if ((expressionId == 229)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext229 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext229.ValueType___Expr229Get();
        }
        if ((expressionId == 230)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext230 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext230.GetLocation<double>(refDataContext230.ValueType___Expr230Get, refDataContext230.ValueType___Expr230Set);
        }
        if ((expressionId == 231)) {
            F1040EZLinesCalculation_TypedDataContext20_ForReadOnly valDataContext231 = new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locations, true);
            return valDataContext231.ValueType___Expr231Get();
        }
        if ((expressionId == 232)) {
            F1040EZLinesCalculation_TypedDataContext20 refDataContext232 = new F1040EZLinesCalculation_TypedDataContext20(locations, true);
            return refDataContext232.GetLocation<double>(refDataContext232.ValueType___Expr232Get, refDataContext232.ValueType___Expr232Set);
        }
        if ((expressionId == 233)) {
            F1040EZLinesCalculation_TypedDataContext19_ForReadOnly valDataContext233 = new F1040EZLinesCalculation_TypedDataContext19_ForReadOnly(locations, true);
            return valDataContext233.ValueType___Expr233Get();
        }
        if ((expressionId == 234)) {
            F1040EZLinesCalculation_TypedDataContext19 refDataContext234 = new F1040EZLinesCalculation_TypedDataContext19(locations, true);
            return refDataContext234.GetLocation<double>(refDataContext234.ValueType___Expr234Get, refDataContext234.ValueType___Expr234Set);
        }
        if ((expressionId == 235)) {
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext235 = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext235.ValueType___Expr235Get();
        }
        if ((expressionId == 236)) {
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext236 = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext236.ValueType___Expr236Get();
        }
        if ((expressionId == 237)) {
            F1040EZLinesCalculation_TypedDataContext2 refDataContext237 = new F1040EZLinesCalculation_TypedDataContext2(locations, true);
            return refDataContext237.GetLocation<double>(refDataContext237.ValueType___Expr237Get, refDataContext237.ValueType___Expr237Set);
        }
        if ((expressionId == 238)) {
            F1040EZLinesCalculation_TypedDataContext2 refDataContext238 = new F1040EZLinesCalculation_TypedDataContext2(locations, true);
            return refDataContext238.GetLocation<double>(refDataContext238.ValueType___Expr238Get, refDataContext238.ValueType___Expr238Set);
        }
        if ((expressionId == 239)) {
            F1040EZLinesCalculation_TypedDataContext2_ForReadOnly valDataContext239 = new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locations, true);
            return valDataContext239.ValueType___Expr239Get();
        }
        if ((expressionId == 240)) {
            F1040EZLinesCalculation_TypedDataContext2 refDataContext240 = new F1040EZLinesCalculation_TypedDataContext2(locations, true);
            return refDataContext240.GetLocation<double>(refDataContext240.ValueType___Expr240Get, refDataContext240.ValueType___Expr240Set);
        }
        if ((expressionId == 241)) {
            F1040EZLinesCalculation_TypedDataContext2 refDataContext241 = new F1040EZLinesCalculation_TypedDataContext2(locations, true);
            return refDataContext241.GetLocation<double>(refDataContext241.ValueType___Expr241Get, refDataContext241.ValueType___Expr241Set);
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
                        "4050,20},{14100,16},{14150,13},{14200,9},{14250,5},{14300,0},{14350,0},{14400,0}" +
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
                    && (F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 0;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "new OutputForms()") 
                    && (F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 1;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms") 
                    && (F1040EZLinesCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 2;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "new Tax1040EZPage1()") 
                    && (F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 3;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1") 
                    && (F1040EZLinesCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 4;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0)") 
                    && (F1040EZLinesCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 5;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Income.W2Wages") 
                    && (F1040EZLinesCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 6;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(W2.WagesAmount.HasValue?W2.WagesAmount.Value : 0) + Tax1040Object.OutputForms.Ta" +
                        "x1040EZPage1.TotalWages") 
                    && (F1040EZLinesCalculation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 7;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages") 
                    && (F1040EZLinesCalculation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
            expressionId = 8;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "W2.FederalTaxWithholdingAmount.HasValue && W2.FederalTaxWithholdingAmount.Value !" +
                        "= 0.0D") 
                    && (F1040EZLinesCalculation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 9;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "W2.FederalTaxWithholdingAmount.Value + W2FederalTaxWithholdTotal") 
                    && (F1040EZLinesCalculation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 10;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "W2FederalTaxWithholdTotal") 
                    && (F1040EZLinesCalculation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
            expressionId = 11;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.C" +
                        "ount > 0)") 
                    && (F1040EZLinesCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 12;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Income.Form1099INT") 
                    && (F1040EZLinesCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 13;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + (Form1099INT.InterestI" +
                        "ncome.HasValue?Form1099INT.InterestIncome.Value:0) + (Form1099INT.USBondsTreasur" +
                        "y.HasValue?Form1099INT.USBondsTreasury.Value:0)") 
                    && (F1040EZLinesCalculation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 14;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest") 
                    && (F1040EZLinesCalculation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
            expressionId = 15;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Form1099INT.FederalTaxWithHoldingAmount.HasValue && Form1099INT.FederalTaxWithHol" +
                        "dingAmount.Value != 0.0D") 
                    && (F1040EZLinesCalculation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 16;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Form1099INT.FederalTaxWithHoldingAmount.Value + Form1099INTFederalTaxWithholdTota" +
                        "l") 
                    && (F1040EZLinesCalculation_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 17;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Form1099INTFederalTaxWithholdTotal") 
                    && (F1040EZLinesCalculation_TypedDataContext6.Validate(locations, true, 0) == true)))) {
            expressionId = 18;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.C" +
                        "ount > 0)") 
                    && (F1040EZLinesCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 19;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Income.Form1099OID") 
                    && (F1040EZLinesCalculation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 20;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + (Form1099OID.OriginalI" +
                        "ssueDiscount.HasValue?Form1099OID.OriginalIssueDiscount.Value : 0)+(Form1099OID." +
                        "OtherPeriodicInterest.HasValue?Form1099OID.OtherPeriodicInterest.Value:0)") 
                    && (F1040EZLinesCalculation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 21;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest") 
                    && (F1040EZLinesCalculation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
            expressionId = 22;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Form1099OID.FederalTaxWithHoldingAmount.HasValue && Form1099OID.FederalTaxWithHol" +
                        "dingAmount.Value != 0.0D") 
                    && (F1040EZLinesCalculation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 23;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Form1099OID.FederalTaxWithHoldingAmount.Value + Form1099OIDFederalTaxWithholdTota" +
                        "l") 
                    && (F1040EZLinesCalculation_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 24;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Form1099OIDFederalTaxWithholdTotal") 
                    && (F1040EZLinesCalculation_TypedDataContext7.Validate(locations, true, 0) == true)))) {
            expressionId = 25;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count" +
                        " > 0)") 
                    && (F1040EZLinesCalculation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 26;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Income.Form1099G") 
                    && (F1040EZLinesCalculation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 27;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "UnEmployment + (Form1099G.UnEmploymentCompensation.HasValue?Form1099G.UnEmploymen" +
                        "tCompensation.Value : 0)") 
                    && (F1040EZLinesCalculation_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 28;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "UnEmployment") 
                    && (F1040EZLinesCalculation_TypedDataContext9.Validate(locations, true, 0) == true)))) {
            expressionId = 29;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Form1099G.FederalTaxWithHoldingAmount.HasValue && Form1099G.FederalTaxWithHolding" +
                        "Amount.Value != 0.0D") 
                    && (F1040EZLinesCalculation_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 30;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Form1099G.FederalTaxWithHoldingAmount.Value + Form1099GFederalTaxWithholdTotal") 
                    && (F1040EZLinesCalculation_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 31;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Form1099GFederalTaxWithholdTotal") 
                    && (F1040EZLinesCalculation_TypedDataContext9.Validate(locations, true, 0) == true)))) {
            expressionId = 32;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Income.OtherIncome !=null") 
                    && (F1040EZLinesCalculation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 33;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object" +
                        ".Income.OtherIncome.HasAlaskaPermanantFund.Value") 
                    && (F1040EZLinesCalculation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 34;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object") 
                    && (F1040EZLinesCalculation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
            expressionId = 35;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "AlaskaPermanantFundAmount") 
                    && (F1040EZLinesCalculation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
            expressionId = 36;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation + UnEmployment " +
                        "+ AlaskaPermanantFundAmount") 
                    && (F1040EZLinesCalculation_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 37;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation") 
                    && (F1040EZLinesCalculation_TypedDataContext8.Validate(locations, true, 0) == true)))) {
            expressionId = 38;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.T" +
                        "ax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.Unemplo" +
                        "ymentCompensation") 
                    && (F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 39;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 40;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 41;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == @"((!Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value))") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 42;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorksheetSingleDefaultStandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 43;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 44;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == @"((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value))") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 45;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + 350") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 46;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountA") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 47;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorksheetMinimunStandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 48;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountB") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 49;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Math.Max(DeductionWorkSheetAmountA, DeductionWorkSheetAmountB)") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 50;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountC") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 51;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorkSheetSingleStandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 52;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountD") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 53;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Math.Min(DeductionWorkSheetAmountC, DeductionWorkSheetAmountD)") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 54;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountE") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 55;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorkSheetDefaultExemption") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 56;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountF") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 57;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorkSheetAmountE + DeductionWorkSheetAmountF") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 58;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountG") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 59;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorkSheetAmountG") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 60;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 61;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == @"((!Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && !Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue && !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value))") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 62;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorksheetMFJDefaultStandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 63;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 64;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == @"((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value))") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 65;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + 350") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 66;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountA") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 67;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorksheetMinimunStandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 68;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountB") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 69;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Math.Max(DeductionWorkSheetAmountA, DeductionWorkSheetAmountB)") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 70;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountC") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 71;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorkSheetMFJStandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 72;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountD") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 73;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Math.Min(DeductionWorkSheetAmountC, DeductionWorkSheetAmountD)") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 74;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountE") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 75;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorkSheetMFJExemption") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 76;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountF") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 77;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorkSheetAmountE + DeductionWorkSheetAmountF") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 78;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountG") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 79;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorkSheetAmountG") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 80;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 81;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == @"((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value))") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 82;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + 350") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 83;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountA") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 84;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorksheetMinimunStandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 85;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountB") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 86;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Math.Max(DeductionWorkSheetAmountA, DeductionWorkSheetAmountB)") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 87;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountC") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 88;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorkSheetMFJStandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 89;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountD") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 90;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Math.Min(DeductionWorkSheetAmountC, DeductionWorkSheetAmountD)") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 91;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountE") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 92;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorkSheetDefaultExemption") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 93;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountF") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 94;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorkSheetAmountE + DeductionWorkSheetAmountF") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 95;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "DeductionWorkSheetAmountG") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 96;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DeductionWorkSheetAmountG") 
                    && (F1040EZLinesCalculation_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 97;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext10.Validate(locations, true, 0) == true)))) {
            expressionId = 98;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome > Tax1040Object.Outp" +
                        "utForms.Tax1040EZPage1.StandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 99;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome - Tax1040Object.Outp" +
                        "utForms.Tax1040EZPage1.StandardDeduction") 
                    && (F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 100;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 101;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 102;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "W2FederalTaxWithholdTotal+ Form1099INTFederalTaxWithholdTotal+ Form1099OIDFederal" +
                        "TaxWithholdTotal + Form1099GFederalTaxWithholdTotal") 
                    && (F1040EZLinesCalculation_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 103;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount") 
                    && (F1040EZLinesCalculation_TypedDataContext11.Validate(locations, true, 0) == true)))) {
            expressionId = 104;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DateTime.Now") 
                    && (F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 105;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth") 
                    && (F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 106;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DateTime.MinValue + TaxPayerTimeZone") 
                    && (F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 107;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "PersonAge.Year - 1") 
                    && (F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 108;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "TodaysDate - Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth") 
                    && (F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 109;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "DateTime.MinValue + SpouseTimeZone") 
                    && (F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 110;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "SpouseAge.Year - 1") 
                    && (F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 111;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == @"((Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.Single)
 && (Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome < SingleAdjustedGrossIncome) && (!Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value))
 || ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly) && (Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome < MFJAdjustedGrossIncome)
  && ((!Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) || (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value)))
 && ((PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && (SpouseAgeCompleted >= MinAge && SpouseAgeCompleted <= MaxAge))") 
                    && (F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 112;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0)") 
                    && (F1040EZLinesCalculation_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 113;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Income.W2Wages") 
                    && (F1040EZLinesCalculation_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 114;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Line8Step2W2NonQualifiedPlans + (W2.NonQualifiedPlansAmount.HasValue ? W2.NonQual" +
                        "ifiedPlansAmount.Value : 0)") 
                    && (F1040EZLinesCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 115;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Line8Step2W2NonQualifiedPlans") 
                    && (F1040EZLinesCalculation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
            expressionId = 116;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Line8Step2W2NonTaxableCombatPay") 
                    && (F1040EZLinesCalculation_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 117;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Line8Step2W2NonTaxableCombatPay") 
                    && (F1040EZLinesCalculation_TypedDataContext14.Validate(locations, true, 0) == true)))) {
            expressionId = 118;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages - Line8Step2W2NonQualifiedPla" +
                        "ns + Line8Step2W2NonTaxableCombatPay") 
                    && (F1040EZLinesCalculation_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 119;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Line8Step2EarnedIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext13.Validate(locations, true, 0) == true)))) {
            expressionId = 120;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(int)Line8Step2EarnedIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 121;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Line8EICWorkSheetLine1") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 122;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Line8EICWorkSheetLine1 > EICInitialRangeStartValue && Line8EICWorkSheetLine1 <= E" +
                        "ICInitialRangeEndValue") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 123;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "EICRateInitialValue") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 124;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Line8EICWorkSheetLine2") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 125;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Line8EICWorkSheetLine1 % EICModuleValue;") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 126;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "EICModuleDifference") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 127;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Line8EICWorkSheetLine1 != EICModuleDifference ? Line8EICWorkSheetLine1 - EICModul" +
                        "eDifference : Line8EICWorkSheetLine1") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 128;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "EICStartingValue") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 129;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty)") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 130;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "EICOut") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 131;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Form1040ezEICCollection") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 132;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "EICStartingValue") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 133;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "EICOut") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 134;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Line8EICWorkSheetLine2") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 135;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Line8EICWorkSheetLine2 == 0") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 136;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Line8EICWorkSheetLine6") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 137;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 138;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Line8EICWorkSheetLine3") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 139;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Line8EICWorkSheetLine3 == Line8EICWorkSheetLine1") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 140;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Line8EICWorkSheetLine2") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 141;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Line8EICWorkSheetLine6") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 142;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == @"(((Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.Single) && (Line8EICWorkSheetLine3 < 7800)) 
            || ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly) &&(Line8EICWorkSheetLine3 < 13000)))") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 143;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Line8EICWorkSheetLine2") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 144;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Line8EICWorkSheetLine6") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 145;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Line8EICWorkSheetLine5") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 146;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Line8EICWorkSheetLine5") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 147;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Math.Min(Line8EICWorkSheetLine2,Line8EICWorkSheetLine5)") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 148;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Line8EICWorkSheetLine6") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 149;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Line8EICWorkSheetLine6") 
                    && (F1040EZLinesCalculation_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 150;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit") 
                    && (F1040EZLinesCalculation_TypedDataContext15.Validate(locations, true, 0) == true)))) {
            expressionId = 151;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "(Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count > 0" +
                        ")") 
                    && (F1040EZLinesCalculation_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 152;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.Income.W2Wages") 
                    && (F1040EZLinesCalculation_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 153;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "W2.W2EmployerCodes != null && W2.W2EmployerCodes.Count>0") 
                    && (F1040EZLinesCalculation_TypedDataContext17_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 154;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "W2.W2EmployerCodes") 
                    && (F1040EZLinesCalculation_TypedDataContext17_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 155;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "W2EmployerCode.EmployerCode.HasValue && W2EmployerCode.EmployerCode.Value == Empl" +
                        "oyerCode.QNonTaxableCombatPay") 
                    && (F1040EZLinesCalculation_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 156;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "W2EmployerCode.Amount.HasValue ? W2EmployerCode.Amount.Value : 0 + Tax1040Object." +
                        "OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection") 
                    && (F1040EZLinesCalculation_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 157;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection") 
                    && (F1040EZLinesCalculation_TypedDataContext18.Validate(locations, true, 0) == true)))) {
            expressionId = 158;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount + Tax1040Obj" +
                        "ect.OutputForms.Tax1040EZPage1.EarnedIncomeCredit") 
                    && (F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 159;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits") 
                    && (F1040EZLinesCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 160;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext19_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 161;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                    && (F1040EZLinesCalculation_TypedDataContext19_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 162;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome>0.0") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 163;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange1End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 164;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "SingleRange1End - SingleRange1Start") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 165;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ProcessingIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 166;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range1TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 167;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 168;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange1End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 169;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range1TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 170;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 171;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "IsCaseContinue") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 172;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange2End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 173;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "SingleRange2End - SingleRange1End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 174;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ProcessingIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 175;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range2TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 176;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 177;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange2End && IsCa" +
                        "seContinue") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 178;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange1End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 179;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ProcessingIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 180;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range2TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 181;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 182;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "IsCaseContinue") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 183;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange3End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 184;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "SingleRange3End - SingleRange2End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 185;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ProcessingIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 186;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range3TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 187;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 188;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange3End && IsCa" +
                        "seContinue") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 189;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange2End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 190;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ProcessingIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 191;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range3TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 192;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 193;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "IsCaseContinue") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 194;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange4End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 195;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "SingleRange4End - SingleRange3End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 196;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ProcessingIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 197;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range4TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 198;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 199;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange4End && IsCa" +
                        "seContinue") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 200;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange3End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 201;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ProcessingIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 202;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range4TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 203;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 204;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "IsCaseContinue") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 205;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange5End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 206;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "SingleRange5End - SingleRange4End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 207;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ProcessingIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 208;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range5TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 209;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 210;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange5End && IsCa" +
                        "seContinue") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 211;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange4End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 212;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ProcessingIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 213;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range5TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 214;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 215;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "IsCaseContinue") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 216;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange6End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 217;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "SingleRange6End - SingleRange5End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 218;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ProcessingIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 219;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range6TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 220;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 221;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange6End && IsCa" +
                        "seContinue") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 222;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange5End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 223;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ProcessingIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 224;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range6TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 225;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 226;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "IsCaseContinue") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 227;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome >= SingleRange7Start") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 228;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange6End") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 229;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "ProcessingIncome") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 230;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax + (ProcessingIncome * Range7TaxRate)") 
                    && (F1040EZLinesCalculation_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 231;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext20.Validate(locations, true, 0) == true)))) {
            expressionId = 232;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax") 
                    && (F1040EZLinesCalculation_TypedDataContext19_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 233;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount") 
                    && (F1040EZLinesCalculation_TypedDataContext19.Validate(locations, true, 0) == true)))) {
            expressionId = 234;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits > Tax1040Object." +
                        "OutputForms.Tax1040EZPage1.TaxAmount") 
                    && (F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 235;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits - Tax1040Object." +
                        "OutputForms.Tax1040EZPage1.TaxAmount") 
                    && (F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 236;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount") 
                    && (F1040EZLinesCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 237;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount") 
                    && (F1040EZLinesCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 238;
            return true;
        }
        if (((isReference == false) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Ta" +
                        "x1040EZPage1.TotalPaymentsAndCredits") 
                    && (F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
            expressionId = 239;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount") 
                    && (F1040EZLinesCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 240;
            return true;
        }
        if (((isReference == true) 
                    && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount") 
                    && (F1040EZLinesCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
            expressionId = 241;
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
            return new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
        }
        if ((expressionId == 1)) {
            return new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
        }
        if ((expressionId == 2)) {
            return new F1040EZLinesCalculation_TypedDataContext2(locationReferences).@__Expr2GetTree();
        }
        if ((expressionId == 3)) {
            return new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
        }
        if ((expressionId == 4)) {
            return new F1040EZLinesCalculation_TypedDataContext2(locationReferences).@__Expr4GetTree();
        }
        if ((expressionId == 5)) {
            return new F1040EZLinesCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr5GetTree();
        }
        if ((expressionId == 6)) {
            return new F1040EZLinesCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr6GetTree();
        }
        if ((expressionId == 7)) {
            return new F1040EZLinesCalculation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr7GetTree();
        }
        if ((expressionId == 8)) {
            return new F1040EZLinesCalculation_TypedDataContext4(locationReferences).@__Expr8GetTree();
        }
        if ((expressionId == 9)) {
            return new F1040EZLinesCalculation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr9GetTree();
        }
        if ((expressionId == 10)) {
            return new F1040EZLinesCalculation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr10GetTree();
        }
        if ((expressionId == 11)) {
            return new F1040EZLinesCalculation_TypedDataContext4(locationReferences).@__Expr11GetTree();
        }
        if ((expressionId == 12)) {
            return new F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr12GetTree();
        }
        if ((expressionId == 13)) {
            return new F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr13GetTree();
        }
        if ((expressionId == 14)) {
            return new F1040EZLinesCalculation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr14GetTree();
        }
        if ((expressionId == 15)) {
            return new F1040EZLinesCalculation_TypedDataContext6(locationReferences).@__Expr15GetTree();
        }
        if ((expressionId == 16)) {
            return new F1040EZLinesCalculation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr16GetTree();
        }
        if ((expressionId == 17)) {
            return new F1040EZLinesCalculation_TypedDataContext6_ForReadOnly(locationReferences).@__Expr17GetTree();
        }
        if ((expressionId == 18)) {
            return new F1040EZLinesCalculation_TypedDataContext6(locationReferences).@__Expr18GetTree();
        }
        if ((expressionId == 19)) {
            return new F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr19GetTree();
        }
        if ((expressionId == 20)) {
            return new F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr20GetTree();
        }
        if ((expressionId == 21)) {
            return new F1040EZLinesCalculation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr21GetTree();
        }
        if ((expressionId == 22)) {
            return new F1040EZLinesCalculation_TypedDataContext7(locationReferences).@__Expr22GetTree();
        }
        if ((expressionId == 23)) {
            return new F1040EZLinesCalculation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr23GetTree();
        }
        if ((expressionId == 24)) {
            return new F1040EZLinesCalculation_TypedDataContext7_ForReadOnly(locationReferences).@__Expr24GetTree();
        }
        if ((expressionId == 25)) {
            return new F1040EZLinesCalculation_TypedDataContext7(locationReferences).@__Expr25GetTree();
        }
        if ((expressionId == 26)) {
            return new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr26GetTree();
        }
        if ((expressionId == 27)) {
            return new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr27GetTree();
        }
        if ((expressionId == 28)) {
            return new F1040EZLinesCalculation_TypedDataContext9_ForReadOnly(locationReferences).@__Expr28GetTree();
        }
        if ((expressionId == 29)) {
            return new F1040EZLinesCalculation_TypedDataContext9(locationReferences).@__Expr29GetTree();
        }
        if ((expressionId == 30)) {
            return new F1040EZLinesCalculation_TypedDataContext9_ForReadOnly(locationReferences).@__Expr30GetTree();
        }
        if ((expressionId == 31)) {
            return new F1040EZLinesCalculation_TypedDataContext9_ForReadOnly(locationReferences).@__Expr31GetTree();
        }
        if ((expressionId == 32)) {
            return new F1040EZLinesCalculation_TypedDataContext9(locationReferences).@__Expr32GetTree();
        }
        if ((expressionId == 33)) {
            return new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr33GetTree();
        }
        if ((expressionId == 34)) {
            return new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr34GetTree();
        }
        if ((expressionId == 35)) {
            return new F1040EZLinesCalculation_TypedDataContext8(locationReferences).@__Expr35GetTree();
        }
        if ((expressionId == 36)) {
            return new F1040EZLinesCalculation_TypedDataContext8(locationReferences).@__Expr36GetTree();
        }
        if ((expressionId == 37)) {
            return new F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(locationReferences).@__Expr37GetTree();
        }
        if ((expressionId == 38)) {
            return new F1040EZLinesCalculation_TypedDataContext8(locationReferences).@__Expr38GetTree();
        }
        if ((expressionId == 39)) {
            return new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr39GetTree();
        }
        if ((expressionId == 40)) {
            return new F1040EZLinesCalculation_TypedDataContext2(locationReferences).@__Expr40GetTree();
        }
        if ((expressionId == 41)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr41GetTree();
        }
        if ((expressionId == 42)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr42GetTree();
        }
        if ((expressionId == 43)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr43GetTree();
        }
        if ((expressionId == 44)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr44GetTree();
        }
        if ((expressionId == 45)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr45GetTree();
        }
        if ((expressionId == 46)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr46GetTree();
        }
        if ((expressionId == 47)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr47GetTree();
        }
        if ((expressionId == 48)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr48GetTree();
        }
        if ((expressionId == 49)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr49GetTree();
        }
        if ((expressionId == 50)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr50GetTree();
        }
        if ((expressionId == 51)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr51GetTree();
        }
        if ((expressionId == 52)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr52GetTree();
        }
        if ((expressionId == 53)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr53GetTree();
        }
        if ((expressionId == 54)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr54GetTree();
        }
        if ((expressionId == 55)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr55GetTree();
        }
        if ((expressionId == 56)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr56GetTree();
        }
        if ((expressionId == 57)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr57GetTree();
        }
        if ((expressionId == 58)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr58GetTree();
        }
        if ((expressionId == 59)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr59GetTree();
        }
        if ((expressionId == 60)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr60GetTree();
        }
        if ((expressionId == 61)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr61GetTree();
        }
        if ((expressionId == 62)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr62GetTree();
        }
        if ((expressionId == 63)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr63GetTree();
        }
        if ((expressionId == 64)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr64GetTree();
        }
        if ((expressionId == 65)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr65GetTree();
        }
        if ((expressionId == 66)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr66GetTree();
        }
        if ((expressionId == 67)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr67GetTree();
        }
        if ((expressionId == 68)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr68GetTree();
        }
        if ((expressionId == 69)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr69GetTree();
        }
        if ((expressionId == 70)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr70GetTree();
        }
        if ((expressionId == 71)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr71GetTree();
        }
        if ((expressionId == 72)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr72GetTree();
        }
        if ((expressionId == 73)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr73GetTree();
        }
        if ((expressionId == 74)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr74GetTree();
        }
        if ((expressionId == 75)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr75GetTree();
        }
        if ((expressionId == 76)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr76GetTree();
        }
        if ((expressionId == 77)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr77GetTree();
        }
        if ((expressionId == 78)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr78GetTree();
        }
        if ((expressionId == 79)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr79GetTree();
        }
        if ((expressionId == 80)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr80GetTree();
        }
        if ((expressionId == 81)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr81GetTree();
        }
        if ((expressionId == 82)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr82GetTree();
        }
        if ((expressionId == 83)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr83GetTree();
        }
        if ((expressionId == 84)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr84GetTree();
        }
        if ((expressionId == 85)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr85GetTree();
        }
        if ((expressionId == 86)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr86GetTree();
        }
        if ((expressionId == 87)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr87GetTree();
        }
        if ((expressionId == 88)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr88GetTree();
        }
        if ((expressionId == 89)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr89GetTree();
        }
        if ((expressionId == 90)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr90GetTree();
        }
        if ((expressionId == 91)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr91GetTree();
        }
        if ((expressionId == 92)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr92GetTree();
        }
        if ((expressionId == 93)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr93GetTree();
        }
        if ((expressionId == 94)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr94GetTree();
        }
        if ((expressionId == 95)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr95GetTree();
        }
        if ((expressionId == 96)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr96GetTree();
        }
        if ((expressionId == 97)) {
            return new F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(locationReferences).@__Expr97GetTree();
        }
        if ((expressionId == 98)) {
            return new F1040EZLinesCalculation_TypedDataContext10(locationReferences).@__Expr98GetTree();
        }
        if ((expressionId == 99)) {
            return new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr99GetTree();
        }
        if ((expressionId == 100)) {
            return new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr100GetTree();
        }
        if ((expressionId == 101)) {
            return new F1040EZLinesCalculation_TypedDataContext2(locationReferences).@__Expr101GetTree();
        }
        if ((expressionId == 102)) {
            return new F1040EZLinesCalculation_TypedDataContext2(locationReferences).@__Expr102GetTree();
        }
        if ((expressionId == 103)) {
            return new F1040EZLinesCalculation_TypedDataContext11_ForReadOnly(locationReferences).@__Expr103GetTree();
        }
        if ((expressionId == 104)) {
            return new F1040EZLinesCalculation_TypedDataContext11(locationReferences).@__Expr104GetTree();
        }
        if ((expressionId == 105)) {
            return new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locationReferences).@__Expr105GetTree();
        }
        if ((expressionId == 106)) {
            return new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locationReferences).@__Expr106GetTree();
        }
        if ((expressionId == 107)) {
            return new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locationReferences).@__Expr107GetTree();
        }
        if ((expressionId == 108)) {
            return new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locationReferences).@__Expr108GetTree();
        }
        if ((expressionId == 109)) {
            return new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locationReferences).@__Expr109GetTree();
        }
        if ((expressionId == 110)) {
            return new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locationReferences).@__Expr110GetTree();
        }
        if ((expressionId == 111)) {
            return new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locationReferences).@__Expr111GetTree();
        }
        if ((expressionId == 112)) {
            return new F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(locationReferences).@__Expr112GetTree();
        }
        if ((expressionId == 113)) {
            return new F1040EZLinesCalculation_TypedDataContext13_ForReadOnly(locationReferences).@__Expr113GetTree();
        }
        if ((expressionId == 114)) {
            return new F1040EZLinesCalculation_TypedDataContext13_ForReadOnly(locationReferences).@__Expr114GetTree();
        }
        if ((expressionId == 115)) {
            return new F1040EZLinesCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr115GetTree();
        }
        if ((expressionId == 116)) {
            return new F1040EZLinesCalculation_TypedDataContext14(locationReferences).@__Expr116GetTree();
        }
        if ((expressionId == 117)) {
            return new F1040EZLinesCalculation_TypedDataContext14_ForReadOnly(locationReferences).@__Expr117GetTree();
        }
        if ((expressionId == 118)) {
            return new F1040EZLinesCalculation_TypedDataContext14(locationReferences).@__Expr118GetTree();
        }
        if ((expressionId == 119)) {
            return new F1040EZLinesCalculation_TypedDataContext13_ForReadOnly(locationReferences).@__Expr119GetTree();
        }
        if ((expressionId == 120)) {
            return new F1040EZLinesCalculation_TypedDataContext13(locationReferences).@__Expr120GetTree();
        }
        if ((expressionId == 121)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr121GetTree();
        }
        if ((expressionId == 122)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr122GetTree();
        }
        if ((expressionId == 123)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr123GetTree();
        }
        if ((expressionId == 124)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr124GetTree();
        }
        if ((expressionId == 125)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr125GetTree();
        }
        if ((expressionId == 126)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr126GetTree();
        }
        if ((expressionId == 127)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr127GetTree();
        }
        if ((expressionId == 128)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr128GetTree();
        }
        if ((expressionId == 129)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr129GetTree();
        }
        if ((expressionId == 130)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr130GetTree();
        }
        if ((expressionId == 131)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr131GetTree();
        }
        if ((expressionId == 132)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr132GetTree();
        }
        if ((expressionId == 133)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr133GetTree();
        }
        if ((expressionId == 134)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr134GetTree();
        }
        if ((expressionId == 135)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr135GetTree();
        }
        if ((expressionId == 136)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr136GetTree();
        }
        if ((expressionId == 137)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr137GetTree();
        }
        if ((expressionId == 138)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr138GetTree();
        }
        if ((expressionId == 139)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr139GetTree();
        }
        if ((expressionId == 140)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr140GetTree();
        }
        if ((expressionId == 141)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr141GetTree();
        }
        if ((expressionId == 142)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr142GetTree();
        }
        if ((expressionId == 143)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr143GetTree();
        }
        if ((expressionId == 144)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr144GetTree();
        }
        if ((expressionId == 145)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr145GetTree();
        }
        if ((expressionId == 146)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr146GetTree();
        }
        if ((expressionId == 147)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr147GetTree();
        }
        if ((expressionId == 148)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr148GetTree();
        }
        if ((expressionId == 149)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr149GetTree();
        }
        if ((expressionId == 150)) {
            return new F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(locationReferences).@__Expr150GetTree();
        }
        if ((expressionId == 151)) {
            return new F1040EZLinesCalculation_TypedDataContext15(locationReferences).@__Expr151GetTree();
        }
        if ((expressionId == 152)) {
            return new F1040EZLinesCalculation_TypedDataContext16_ForReadOnly(locationReferences).@__Expr152GetTree();
        }
        if ((expressionId == 153)) {
            return new F1040EZLinesCalculation_TypedDataContext16_ForReadOnly(locationReferences).@__Expr153GetTree();
        }
        if ((expressionId == 154)) {
            return new F1040EZLinesCalculation_TypedDataContext17_ForReadOnly(locationReferences).@__Expr154GetTree();
        }
        if ((expressionId == 155)) {
            return new F1040EZLinesCalculation_TypedDataContext17_ForReadOnly(locationReferences).@__Expr155GetTree();
        }
        if ((expressionId == 156)) {
            return new F1040EZLinesCalculation_TypedDataContext18_ForReadOnly(locationReferences).@__Expr156GetTree();
        }
        if ((expressionId == 157)) {
            return new F1040EZLinesCalculation_TypedDataContext18_ForReadOnly(locationReferences).@__Expr157GetTree();
        }
        if ((expressionId == 158)) {
            return new F1040EZLinesCalculation_TypedDataContext18(locationReferences).@__Expr158GetTree();
        }
        if ((expressionId == 159)) {
            return new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr159GetTree();
        }
        if ((expressionId == 160)) {
            return new F1040EZLinesCalculation_TypedDataContext2(locationReferences).@__Expr160GetTree();
        }
        if ((expressionId == 161)) {
            return new F1040EZLinesCalculation_TypedDataContext19_ForReadOnly(locationReferences).@__Expr161GetTree();
        }
        if ((expressionId == 162)) {
            return new F1040EZLinesCalculation_TypedDataContext19_ForReadOnly(locationReferences).@__Expr162GetTree();
        }
        if ((expressionId == 163)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr163GetTree();
        }
        if ((expressionId == 164)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr164GetTree();
        }
        if ((expressionId == 165)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr165GetTree();
        }
        if ((expressionId == 166)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr166GetTree();
        }
        if ((expressionId == 167)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr167GetTree();
        }
        if ((expressionId == 168)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr168GetTree();
        }
        if ((expressionId == 169)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr169GetTree();
        }
        if ((expressionId == 170)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr170GetTree();
        }
        if ((expressionId == 171)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr171GetTree();
        }
        if ((expressionId == 172)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr172GetTree();
        }
        if ((expressionId == 173)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr173GetTree();
        }
        if ((expressionId == 174)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr174GetTree();
        }
        if ((expressionId == 175)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr175GetTree();
        }
        if ((expressionId == 176)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr176GetTree();
        }
        if ((expressionId == 177)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr177GetTree();
        }
        if ((expressionId == 178)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr178GetTree();
        }
        if ((expressionId == 179)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr179GetTree();
        }
        if ((expressionId == 180)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr180GetTree();
        }
        if ((expressionId == 181)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr181GetTree();
        }
        if ((expressionId == 182)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr182GetTree();
        }
        if ((expressionId == 183)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr183GetTree();
        }
        if ((expressionId == 184)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr184GetTree();
        }
        if ((expressionId == 185)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr185GetTree();
        }
        if ((expressionId == 186)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr186GetTree();
        }
        if ((expressionId == 187)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr187GetTree();
        }
        if ((expressionId == 188)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr188GetTree();
        }
        if ((expressionId == 189)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr189GetTree();
        }
        if ((expressionId == 190)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr190GetTree();
        }
        if ((expressionId == 191)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr191GetTree();
        }
        if ((expressionId == 192)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr192GetTree();
        }
        if ((expressionId == 193)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr193GetTree();
        }
        if ((expressionId == 194)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr194GetTree();
        }
        if ((expressionId == 195)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr195GetTree();
        }
        if ((expressionId == 196)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr196GetTree();
        }
        if ((expressionId == 197)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr197GetTree();
        }
        if ((expressionId == 198)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr198GetTree();
        }
        if ((expressionId == 199)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr199GetTree();
        }
        if ((expressionId == 200)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr200GetTree();
        }
        if ((expressionId == 201)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr201GetTree();
        }
        if ((expressionId == 202)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr202GetTree();
        }
        if ((expressionId == 203)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr203GetTree();
        }
        if ((expressionId == 204)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr204GetTree();
        }
        if ((expressionId == 205)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr205GetTree();
        }
        if ((expressionId == 206)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr206GetTree();
        }
        if ((expressionId == 207)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr207GetTree();
        }
        if ((expressionId == 208)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr208GetTree();
        }
        if ((expressionId == 209)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr209GetTree();
        }
        if ((expressionId == 210)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr210GetTree();
        }
        if ((expressionId == 211)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr211GetTree();
        }
        if ((expressionId == 212)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr212GetTree();
        }
        if ((expressionId == 213)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr213GetTree();
        }
        if ((expressionId == 214)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr214GetTree();
        }
        if ((expressionId == 215)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr215GetTree();
        }
        if ((expressionId == 216)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr216GetTree();
        }
        if ((expressionId == 217)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr217GetTree();
        }
        if ((expressionId == 218)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr218GetTree();
        }
        if ((expressionId == 219)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr219GetTree();
        }
        if ((expressionId == 220)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr220GetTree();
        }
        if ((expressionId == 221)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr221GetTree();
        }
        if ((expressionId == 222)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr222GetTree();
        }
        if ((expressionId == 223)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr223GetTree();
        }
        if ((expressionId == 224)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr224GetTree();
        }
        if ((expressionId == 225)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr225GetTree();
        }
        if ((expressionId == 226)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr226GetTree();
        }
        if ((expressionId == 227)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr227GetTree();
        }
        if ((expressionId == 228)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr228GetTree();
        }
        if ((expressionId == 229)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr229GetTree();
        }
        if ((expressionId == 230)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr230GetTree();
        }
        if ((expressionId == 231)) {
            return new F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(locationReferences).@__Expr231GetTree();
        }
        if ((expressionId == 232)) {
            return new F1040EZLinesCalculation_TypedDataContext20(locationReferences).@__Expr232GetTree();
        }
        if ((expressionId == 233)) {
            return new F1040EZLinesCalculation_TypedDataContext19_ForReadOnly(locationReferences).@__Expr233GetTree();
        }
        if ((expressionId == 234)) {
            return new F1040EZLinesCalculation_TypedDataContext19(locationReferences).@__Expr234GetTree();
        }
        if ((expressionId == 235)) {
            return new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr235GetTree();
        }
        if ((expressionId == 236)) {
            return new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr236GetTree();
        }
        if ((expressionId == 237)) {
            return new F1040EZLinesCalculation_TypedDataContext2(locationReferences).@__Expr237GetTree();
        }
        if ((expressionId == 238)) {
            return new F1040EZLinesCalculation_TypedDataContext2(locationReferences).@__Expr238GetTree();
        }
        if ((expressionId == 239)) {
            return new F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr239GetTree();
        }
        if ((expressionId == 240)) {
            return new F1040EZLinesCalculation_TypedDataContext2(locationReferences).@__Expr240GetTree();
        }
        if ((expressionId == 241)) {
            return new F1040EZLinesCalculation_TypedDataContext2(locationReferences).@__Expr241GetTree();
        }
        return null;
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
    private class F1040EZLinesCalculation_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
    private class F1040EZLinesCalculation_TypedDataContext1 : F1040EZLinesCalculation_TypedDataContext0 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected int EICOut;
        
        public F1040EZLinesCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            this.EICOut = ((int)(this.GetVariableValue((1 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        protected override void SetValueTypeValues() {
            this.SetVariableValue((1 + locationsOffset), this.EICOut);
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
            if (((locationReferences[(offset + 1)].Name != "EICOut") 
                        || (locationReferences[(offset + 1)].Type != typeof(int)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext0.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext1_ForReadOnly : F1040EZLinesCalculation_TypedDataContext0_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected int EICOut;
        
        public F1040EZLinesCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            this.EICOut = ((int)(this.GetVariableValue((1 + locationsOffset))));
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
            if (((locationReferences[(offset + 1)].Name != "EICOut") 
                        || (locationReferences[(offset + 1)].Type != typeof(int)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext2 : F1040EZLinesCalculation_TypedDataContext1 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected double W2FederalTaxWithholdTotal;
        
        protected double Form1099INTFederalTaxWithholdTotal;
        
        protected double Form1099OIDFederalTaxWithholdTotal;
        
        protected double Form1099GFederalTaxWithholdTotal;
        
        protected double Range1TaxRate;
        
        public F1040EZLinesCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected System.Collections.Concurrent.ConcurrentDictionary<int, int> Form1040ezEICCollection {
            get {
                return ((System.Collections.Concurrent.ConcurrentDictionary<int, int>)(this.GetVariableValue((6 + locationsOffset))));
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
        
        internal System.Linq.Expressions.Expression @__Expr2GetTree() {
            
            #line 113 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.OutputForms>> expression = () => 
            Tax1040Object.OutputForms;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.BusinessObject.OutputForms @__Expr2Get() {
            
            #line 113 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
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
            
            #line 113 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
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
            
            #line 125 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040EZPage1>> expression = () => 
            Tax1040Object.OutputForms.Tax1040EZPage1;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.BusinessObject.Tax1040EZPage1 @__Expr4Get() {
            
            #line 125 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
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
            
            #line 125 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
            Tax1040Object.OutputForms.Tax1040EZPage1 = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr4Set(JTL.Tax1040.BusinessObject.Tax1040EZPage1 value) {
            this.GetValueTypeValues();
            this.@__Expr4Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr40GetTree() {
            
            #line 428 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
              Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr40Get() {
            
            #line 428 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
              Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr40Get() {
            this.GetValueTypeValues();
            return this.@__Expr40Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr40Set(double value) {
            
            #line 428 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
              Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr40Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr40Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr101GetTree() {
            
            #line 844 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr101Get() {
            
            #line 844 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr101Get() {
            this.GetValueTypeValues();
            return this.@__Expr101Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr101Set(double value) {
            
            #line 844 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr101Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr101Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr102GetTree() {
            
            #line 858 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr102Get() {
            
            #line 858 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr102Get() {
            this.GetValueTypeValues();
            return this.@__Expr102Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr102Set(double value) {
            
            #line 858 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr102Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr102Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr160GetTree() {
            
            #line 1323 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
            Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr160Get() {
            
            #line 1323 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr160Get() {
            this.GetValueTypeValues();
            return this.@__Expr160Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr160Set(double value) {
            
            #line 1323 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
            Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr160Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr160Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr237GetTree() {
            
            #line 1928 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                  Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr237Get() {
            
            #line 1928 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                  Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr237Get() {
            this.GetValueTypeValues();
            return this.@__Expr237Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr237Set(double value) {
            
            #line 1928 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                  Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr237Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr237Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr238GetTree() {
            
            #line 1940 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                  Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr238Get() {
            
            #line 1940 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                  Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr238Get() {
            this.GetValueTypeValues();
            return this.@__Expr238Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr238Set(double value) {
            
            #line 1940 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                  Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr238Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr238Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr240GetTree() {
            
            #line 1954 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                  Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr240Get() {
            
            #line 1954 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                  Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr240Get() {
            this.GetValueTypeValues();
            return this.@__Expr240Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr240Set(double value) {
            
            #line 1954 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                  Tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr240Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr240Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr241GetTree() {
            
            #line 1966 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                  Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr241Get() {
            
            #line 1966 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                  Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr241Get() {
            this.GetValueTypeValues();
            return this.@__Expr241Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr241Set(double value) {
            
            #line 1966 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                  Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr241Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr241Set(value);
            this.SetValueTypeValues();
        }
        
        protected override void GetValueTypeValues() {
            this.W2FederalTaxWithholdTotal = ((double)(this.GetVariableValue((2 + locationsOffset))));
            this.Form1099INTFederalTaxWithholdTotal = ((double)(this.GetVariableValue((3 + locationsOffset))));
            this.Form1099OIDFederalTaxWithholdTotal = ((double)(this.GetVariableValue((4 + locationsOffset))));
            this.Form1099GFederalTaxWithholdTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
            this.Range1TaxRate = ((double)(this.GetVariableValue((7 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        protected override void SetValueTypeValues() {
            this.SetVariableValue((2 + locationsOffset), this.W2FederalTaxWithholdTotal);
            this.SetVariableValue((3 + locationsOffset), this.Form1099INTFederalTaxWithholdTotal);
            this.SetVariableValue((4 + locationsOffset), this.Form1099OIDFederalTaxWithholdTotal);
            this.SetVariableValue((5 + locationsOffset), this.Form1099GFederalTaxWithholdTotal);
            this.SetVariableValue((7 + locationsOffset), this.Range1TaxRate);
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
            if (((locationReferences[(offset + 6)].Name != "Form1040ezEICCollection") 
                        || (locationReferences[(offset + 6)].Type != typeof(System.Collections.Concurrent.ConcurrentDictionary<int, int>)))) {
                return false;
            }
            if (((locationReferences[(offset + 2)].Name != "W2FederalTaxWithholdTotal") 
                        || (locationReferences[(offset + 2)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 3)].Name != "Form1099INTFederalTaxWithholdTotal") 
                        || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 4)].Name != "Form1099OIDFederalTaxWithholdTotal") 
                        || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 5)].Name != "Form1099GFederalTaxWithholdTotal") 
                        || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 7)].Name != "Range1TaxRate") 
                        || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext1.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext2_ForReadOnly : F1040EZLinesCalculation_TypedDataContext1_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected double W2FederalTaxWithholdTotal;
        
        protected double Form1099INTFederalTaxWithholdTotal;
        
        protected double Form1099OIDFederalTaxWithholdTotal;
        
        protected double Form1099GFederalTaxWithholdTotal;
        
        protected double Range1TaxRate;
        
        public F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected System.Collections.Concurrent.ConcurrentDictionary<int, int> Form1040ezEICCollection {
            get {
                return ((System.Collections.Concurrent.ConcurrentDictionary<int, int>)(this.GetVariableValue((6 + locationsOffset))));
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
            
            #line 72 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
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
{14050,20},{14100,16},{14150,13},{14200,9},{14250,5},{14300,0},{14350,0},{14400,0},{14450,0},{14500,0},{14550,0},{14600,0},{14650,0},{14700,0},{14750,0},{14800,0},
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
            
            #line 72 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
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
{14050,20},{14100,16},{14150,13},{14200,9},{14250,5},{14300,0},{14350,0},{14400,0},{14450,0},{14500,0},{14550,0},{14600,0},{14650,0},{14700,0},{14750,0},{14800,0},
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
            
            #line 118 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.OutputForms>> expression = () => 
            new OutputForms();
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.BusinessObject.OutputForms @__Expr1Get() {
            
            #line 118 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
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
            
            #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040EZPage1>> expression = () => 
            new Tax1040EZPage1();
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.BusinessObject.Tax1040EZPage1 @__Expr3Get() {
            
            #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            new Tax1040EZPage1();
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.BusinessObject.Tax1040EZPage1 ValueType___Expr3Get() {
            this.GetValueTypeValues();
            return this.@__Expr3Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr39GetTree() {
            
            #line 433 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
              Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr39Get() {
            
            #line 433 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
              Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr39Get() {
            this.GetValueTypeValues();
            return this.@__Expr39Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr99GetTree() {
            
            #line 837 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome > Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr99Get() {
            
            #line 837 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome > Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr99Get() {
            this.GetValueTypeValues();
            return this.@__Expr99Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr100GetTree() {
            
            #line 849 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome - Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr100Get() {
            
            #line 849 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome - Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr100Get() {
            this.GetValueTypeValues();
            return this.@__Expr100Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr159GetTree() {
            
            #line 1328 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
            Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount + Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr159Get() {
            
            #line 1328 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount + Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr159Get() {
            this.GetValueTypeValues();
            return this.@__Expr159Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr235GetTree() {
            
            #line 1920 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
            Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits > Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr235Get() {
            
            #line 1920 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits > Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr235Get() {
            this.GetValueTypeValues();
            return this.@__Expr235Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr236GetTree() {
            
            #line 1933 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                  Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits - Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr236Get() {
            
            #line 1933 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                  Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits - Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr236Get() {
            this.GetValueTypeValues();
            return this.@__Expr236Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr239GetTree() {
            
            #line 1959 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                  Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr239Get() {
            
            #line 1959 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                  Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr239Get() {
            this.GetValueTypeValues();
            return this.@__Expr239Get();
        }
        
        protected override void GetValueTypeValues() {
            this.W2FederalTaxWithholdTotal = ((double)(this.GetVariableValue((2 + locationsOffset))));
            this.Form1099INTFederalTaxWithholdTotal = ((double)(this.GetVariableValue((3 + locationsOffset))));
            this.Form1099OIDFederalTaxWithholdTotal = ((double)(this.GetVariableValue((4 + locationsOffset))));
            this.Form1099GFederalTaxWithholdTotal = ((double)(this.GetVariableValue((5 + locationsOffset))));
            this.Range1TaxRate = ((double)(this.GetVariableValue((7 + locationsOffset))));
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
            if (((locationReferences[(offset + 6)].Name != "Form1040ezEICCollection") 
                        || (locationReferences[(offset + 6)].Type != typeof(System.Collections.Concurrent.ConcurrentDictionary<int, int>)))) {
                return false;
            }
            if (((locationReferences[(offset + 2)].Name != "W2FederalTaxWithholdTotal") 
                        || (locationReferences[(offset + 2)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 3)].Name != "Form1099INTFederalTaxWithholdTotal") 
                        || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 4)].Name != "Form1099OIDFederalTaxWithholdTotal") 
                        || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 5)].Name != "Form1099GFederalTaxWithholdTotal") 
                        || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 7)].Name != "Range1TaxRate") 
                        || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext3 : F1040EZLinesCalculation_TypedDataContext2 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected JTL.Tax1040.BusinessObject.W2 W2 {
            get {
                return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((8 + locationsOffset))));
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
        
        public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
            if (((validateLocationCount == true) 
                        && (locationReferences.Count < 9))) {
                return false;
            }
            if ((validateLocationCount == true)) {
                offset = (locationReferences.Count - 9);
            }
            expectedLocationsCount = 9;
            if (((locationReferences[(offset + 8)].Name != "W2") 
                        || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext3_ForReadOnly : F1040EZLinesCalculation_TypedDataContext2_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected JTL.Tax1040.BusinessObject.W2 W2 {
            get {
                return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((8 + locationsOffset))));
            }
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr5GetTree() {
            
            #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
            (Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr5Get() {
            
            #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            (Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr5Get() {
            this.GetValueTypeValues();
            return this.@__Expr5Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr6GetTree() {
            
            #line 150 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.W2>>> expression = () => 
                  Tax1040Object.Income.W2Wages;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.W2> @__Expr6Get() {
            
            #line 150 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                  Tax1040Object.Income.W2Wages;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.W2> ValueType___Expr6Get() {
            this.GetValueTypeValues();
            return this.@__Expr6Get();
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
            if (((locationReferences[(offset + 8)].Name != "W2") 
                        || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext4 : F1040EZLinesCalculation_TypedDataContext3 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected new JTL.Tax1040.BusinessObject.W2 W2 {
            get {
                return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((9 + locationsOffset))));
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
        
        internal System.Linq.Expressions.Expression @__Expr8GetTree() {
            
            #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr8Get() {
            
            #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
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
            
            #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr8Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr8Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr11GetTree() {
            
            #line 180 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            W2FederalTaxWithholdTotal;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr11Get() {
            
            #line 180 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            W2FederalTaxWithholdTotal;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr11Get() {
            this.GetValueTypeValues();
            return this.@__Expr11Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr11Set(double value) {
            
            #line 180 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            W2FederalTaxWithholdTotal = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr11Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr11Set(value);
            this.SetValueTypeValues();
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
            if (((locationReferences[(offset + 9)].Name != "W2") 
                        || (locationReferences[(offset + 9)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext3.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext4_ForReadOnly : F1040EZLinesCalculation_TypedDataContext3_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected new JTL.Tax1040.BusinessObject.W2 W2 {
            get {
                return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((9 + locationsOffset))));
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
            
            #line 166 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        (W2.WagesAmount.HasValue?W2.WagesAmount.Value : 0) + Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr7Get() {
            
            #line 166 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        (W2.WagesAmount.HasValue?W2.WagesAmount.Value : 0) + Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr7Get() {
            this.GetValueTypeValues();
            return this.@__Expr7Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr9GetTree() {
            
            #line 173 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        W2.FederalTaxWithholdingAmount.HasValue && W2.FederalTaxWithholdingAmount.Value != 0.0D;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr9Get() {
            
            #line 173 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        W2.FederalTaxWithholdingAmount.HasValue && W2.FederalTaxWithholdingAmount.Value != 0.0D;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr9Get() {
            this.GetValueTypeValues();
            return this.@__Expr9Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr10GetTree() {
            
            #line 185 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            W2.FederalTaxWithholdingAmount.Value + W2FederalTaxWithholdTotal;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr10Get() {
            
            #line 185 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            W2.FederalTaxWithholdingAmount.Value + W2FederalTaxWithholdTotal;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr10Get() {
            this.GetValueTypeValues();
            return this.@__Expr10Get();
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
            if (((locationReferences[(offset + 9)].Name != "W2") 
                        || (locationReferences[(offset + 9)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext5 : F1040EZLinesCalculation_TypedDataContext2 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((8 + locationsOffset))));
            }
            set {
                this.SetVariableValue((8 + locationsOffset), value);
            }
        }
        
        protected JTL.Tax1040.BusinessObject.Form1099INT Form1099INT {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((9 + locationsOffset))));
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
        
        public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
            if (((validateLocationCount == true) 
                        && (locationReferences.Count < 10))) {
                return false;
            }
            if ((validateLocationCount == true)) {
                offset = (locationReferences.Count - 10);
            }
            expectedLocationsCount = 10;
            if (((locationReferences[(offset + 8)].Name != "Form1099OID") 
                        || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "Form1099INT") 
                        || (locationReferences[(offset + 9)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext5_ForReadOnly : F1040EZLinesCalculation_TypedDataContext2_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((8 + locationsOffset))));
            }
        }
        
        protected JTL.Tax1040.BusinessObject.Form1099INT Form1099INT {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((9 + locationsOffset))));
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
            
            #line 206 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
            (Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr12Get() {
            
            #line 206 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            (Tax1040Object.Income.Form1099INT != null) && (Tax1040Object.Income.Form1099INT.Count > 0);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr12Get() {
            this.GetValueTypeValues();
            return this.@__Expr12Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr13GetTree() {
            
            #line 213 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099INT>>> expression = () => 
                Tax1040Object.Income.Form1099INT;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099INT> @__Expr13Get() {
            
            #line 213 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                Tax1040Object.Income.Form1099INT;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099INT> ValueType___Expr13Get() {
            this.GetValueTypeValues();
            return this.@__Expr13Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr19GetTree() {
            
            #line 262 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
            (Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr19Get() {
            
            #line 262 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            (Tax1040Object.Income.Form1099OID != null) && (Tax1040Object.Income.Form1099OID.Count > 0);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr19Get() {
            this.GetValueTypeValues();
            return this.@__Expr19Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr20GetTree() {
            
            #line 269 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099OID>>> expression = () => 
                Tax1040Object.Income.Form1099OID;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099OID> @__Expr20Get() {
            
            #line 269 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                Tax1040Object.Income.Form1099OID;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099OID> ValueType___Expr20Get() {
            this.GetValueTypeValues();
            return this.@__Expr20Get();
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
            if (((locationReferences[(offset + 8)].Name != "Form1099OID") 
                        || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "Form1099INT") 
                        || (locationReferences[(offset + 9)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext6 : F1040EZLinesCalculation_TypedDataContext5 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected new JTL.Tax1040.BusinessObject.Form1099INT Form1099INT {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((10 + locationsOffset))));
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
        
        internal System.Linq.Expressions.Expression @__Expr15GetTree() {
            
            #line 224 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr15Get() {
            
            #line 224 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr15Get() {
            this.GetValueTypeValues();
            return this.@__Expr15Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr15Set(double value) {
            
            #line 224 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr15Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr15Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr18GetTree() {
            
            #line 243 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099INTFederalTaxWithholdTotal;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr18Get() {
            
            #line 243 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Form1099INTFederalTaxWithholdTotal;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr18Get() {
            this.GetValueTypeValues();
            return this.@__Expr18Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr18Set(double value) {
            
            #line 243 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          Form1099INTFederalTaxWithholdTotal = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr18Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr18Set(value);
            this.SetValueTypeValues();
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
            if (((locationReferences[(offset + 10)].Name != "Form1099INT") 
                        || (locationReferences[(offset + 10)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext5.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext6_ForReadOnly : F1040EZLinesCalculation_TypedDataContext5_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected new JTL.Tax1040.BusinessObject.Form1099INT Form1099INT {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((10 + locationsOffset))));
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
            
            #line 229 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + (Form1099INT.InterestIncome.HasValue?Form1099INT.InterestIncome.Value:0) + (Form1099INT.USBondsTreasury.HasValue?Form1099INT.USBondsTreasury.Value:0);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr14Get() {
            
            #line 229 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + (Form1099INT.InterestIncome.HasValue?Form1099INT.InterestIncome.Value:0) + (Form1099INT.USBondsTreasury.HasValue?Form1099INT.USBondsTreasury.Value:0);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr14Get() {
            this.GetValueTypeValues();
            return this.@__Expr14Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr16GetTree() {
            
            #line 236 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Form1099INT.FederalTaxWithHoldingAmount.HasValue && Form1099INT.FederalTaxWithHoldingAmount.Value != 0.0D;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr16Get() {
            
            #line 236 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Form1099INT.FederalTaxWithHoldingAmount.HasValue && Form1099INT.FederalTaxWithHoldingAmount.Value != 0.0D;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr16Get() {
            this.GetValueTypeValues();
            return this.@__Expr16Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr17GetTree() {
            
            #line 248 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099INT.FederalTaxWithHoldingAmount.Value + Form1099INTFederalTaxWithholdTotal;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr17Get() {
            
            #line 248 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Form1099INT.FederalTaxWithHoldingAmount.Value + Form1099INTFederalTaxWithholdTotal;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr17Get() {
            this.GetValueTypeValues();
            return this.@__Expr17Get();
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
            if (((locationReferences[(offset + 10)].Name != "Form1099INT") 
                        || (locationReferences[(offset + 10)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext5_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext7 : F1040EZLinesCalculation_TypedDataContext5 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected new JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((10 + locationsOffset))));
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
        
        internal System.Linq.Expressions.Expression @__Expr22GetTree() {
            
            #line 280 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr22Get() {
            
            #line 280 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr22Get() {
            this.GetValueTypeValues();
            return this.@__Expr22Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr22Set(double value) {
            
            #line 280 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr22Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr22Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr25GetTree() {
            
            #line 299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099OIDFederalTaxWithholdTotal;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr25Get() {
            
            #line 299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Form1099OIDFederalTaxWithholdTotal;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr25Get() {
            this.GetValueTypeValues();
            return this.@__Expr25Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr25Set(double value) {
            
            #line 299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          Form1099OIDFederalTaxWithholdTotal = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr25Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr25Set(value);
            this.SetValueTypeValues();
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
            if (((locationReferences[(offset + 10)].Name != "Form1099OID") 
                        || (locationReferences[(offset + 10)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext5.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext7_ForReadOnly : F1040EZLinesCalculation_TypedDataContext5_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected new JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((10 + locationsOffset))));
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
            
            #line 285 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + (Form1099OID.OriginalIssueDiscount.HasValue?Form1099OID.OriginalIssueDiscount.Value : 0)+(Form1099OID.OtherPeriodicInterest.HasValue?Form1099OID.OtherPeriodicInterest.Value:0);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr21Get() {
            
            #line 285 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + (Form1099OID.OriginalIssueDiscount.HasValue?Form1099OID.OriginalIssueDiscount.Value : 0)+(Form1099OID.OtherPeriodicInterest.HasValue?Form1099OID.OtherPeriodicInterest.Value:0);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr21Get() {
            this.GetValueTypeValues();
            return this.@__Expr21Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr23GetTree() {
            
            #line 292 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Form1099OID.FederalTaxWithHoldingAmount.HasValue && Form1099OID.FederalTaxWithHoldingAmount.Value != 0.0D;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr23Get() {
            
            #line 292 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Form1099OID.FederalTaxWithHoldingAmount.HasValue && Form1099OID.FederalTaxWithHoldingAmount.Value != 0.0D;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr23Get() {
            this.GetValueTypeValues();
            return this.@__Expr23Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr24GetTree() {
            
            #line 304 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099OID.FederalTaxWithHoldingAmount.Value + Form1099OIDFederalTaxWithholdTotal;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr24Get() {
            
            #line 304 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Form1099OID.FederalTaxWithHoldingAmount.Value + Form1099OIDFederalTaxWithholdTotal;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr24Get() {
            this.GetValueTypeValues();
            return this.@__Expr24Get();
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
            if (((locationReferences[(offset + 10)].Name != "Form1099OID") 
                        || (locationReferences[(offset + 10)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext5_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext8 : F1040EZLinesCalculation_TypedDataContext2 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected double UnEmployment;
        
        protected double AlaskaPermanantFundAmount;
        
        public F1040EZLinesCalculation_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected JTL.Tax1040.BusinessObject.Form1099G Form1099G {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((8 + locationsOffset))));
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
            
            #line 401 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                      Tax1040Object;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.BusinessObject.Tax1040 @__Expr35Get() {
            
            #line 401 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr35Get() {
            this.GetValueTypeValues();
            return this.@__Expr35Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr35Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
            
            #line 401 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                      Tax1040Object = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr35Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
            this.GetValueTypeValues();
            this.@__Expr35Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr36GetTree() {
            
            #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                      AlaskaPermanantFundAmount;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr36Get() {
            
            #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      AlaskaPermanantFundAmount;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr36Get() {
            this.GetValueTypeValues();
            return this.@__Expr36Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr36Set(double value) {
            
            #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                      AlaskaPermanantFundAmount = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr36Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr36Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr38GetTree() {
            
            #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
            Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr38Get() {
            
            #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr38Get() {
            this.GetValueTypeValues();
            return this.@__Expr38Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr38Set(double value) {
            
            #line 413 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
            Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr38Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr38Set(value);
            this.SetValueTypeValues();
        }
        
        protected override void GetValueTypeValues() {
            this.UnEmployment = ((double)(this.GetVariableValue((9 + locationsOffset))));
            this.AlaskaPermanantFundAmount = ((double)(this.GetVariableValue((10 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        protected override void SetValueTypeValues() {
            this.SetVariableValue((9 + locationsOffset), this.UnEmployment);
            this.SetVariableValue((10 + locationsOffset), this.AlaskaPermanantFundAmount);
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
            if (((locationReferences[(offset + 8)].Name != "Form1099G") 
                        || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "UnEmployment") 
                        || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 10)].Name != "AlaskaPermanantFundAmount") 
                        || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext8_ForReadOnly : F1040EZLinesCalculation_TypedDataContext2_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected double UnEmployment;
        
        protected double AlaskaPermanantFundAmount;
        
        public F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected JTL.Tax1040.BusinessObject.Form1099G Form1099G {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((8 + locationsOffset))));
            }
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr26GetTree() {
            
            #line 325 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
            (Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count > 0);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr26Get() {
            
            #line 325 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            (Tax1040Object.Income.Form1099G != null) && (Tax1040Object.Income.Form1099G.Count > 0);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr26Get() {
            this.GetValueTypeValues();
            return this.@__Expr26Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr27GetTree() {
            
            #line 332 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099G>>> expression = () => 
                Tax1040Object.Income.Form1099G;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099G> @__Expr27Get() {
            
            #line 332 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                Tax1040Object.Income.Form1099G;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.Form1099G> ValueType___Expr27Get() {
            this.GetValueTypeValues();
            return this.@__Expr27Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr33GetTree() {
            
            #line 381 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
            Tax1040Object.Income.OtherIncome !=null;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr33Get() {
            
            #line 381 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            Tax1040Object.Income.OtherIncome !=null;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr33Get() {
            this.GetValueTypeValues();
            return this.@__Expr33Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr34GetTree() {
            
            #line 388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.Value;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr34Get() {
            
            #line 388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.HasValue && Tax1040Object.Income.OtherIncome.HasAlaskaPermanantFund.Value;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr34Get() {
            this.GetValueTypeValues();
            return this.@__Expr34Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr37GetTree() {
            
            #line 418 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
            Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation + UnEmployment + AlaskaPermanantFundAmount;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr37Get() {
            
            #line 418 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation + UnEmployment + AlaskaPermanantFundAmount;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr37Get() {
            this.GetValueTypeValues();
            return this.@__Expr37Get();
        }
        
        protected override void GetValueTypeValues() {
            this.UnEmployment = ((double)(this.GetVariableValue((9 + locationsOffset))));
            this.AlaskaPermanantFundAmount = ((double)(this.GetVariableValue((10 + locationsOffset))));
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
            if (((locationReferences[(offset + 8)].Name != "Form1099G") 
                        || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "UnEmployment") 
                        || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 10)].Name != "AlaskaPermanantFundAmount") 
                        || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext9 : F1040EZLinesCalculation_TypedDataContext8 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext9(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected new JTL.Tax1040.BusinessObject.Form1099G Form1099G {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((11 + locationsOffset))));
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
        
        internal System.Linq.Expressions.Expression @__Expr29GetTree() {
            
            #line 343 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                      UnEmployment;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr29Get() {
            
            #line 343 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      UnEmployment;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr29Get() {
            this.GetValueTypeValues();
            return this.@__Expr29Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr29Set(double value) {
            
            #line 343 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                      UnEmployment = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr29Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr29Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr32GetTree() {
            
            #line 362 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099GFederalTaxWithholdTotal;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr32Get() {
            
            #line 362 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Form1099GFederalTaxWithholdTotal;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr32Get() {
            this.GetValueTypeValues();
            return this.@__Expr32Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr32Set(double value) {
            
            #line 362 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          Form1099GFederalTaxWithholdTotal = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr32Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr32Set(value);
            this.SetValueTypeValues();
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
            if (((locationReferences[(offset + 11)].Name != "Form1099G") 
                        || (locationReferences[(offset + 11)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext8.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext9_ForReadOnly : F1040EZLinesCalculation_TypedDataContext8_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected new JTL.Tax1040.BusinessObject.Form1099G Form1099G {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((11 + locationsOffset))));
            }
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr28GetTree() {
            
            #line 348 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                      UnEmployment + (Form1099G.UnEmploymentCompensation.HasValue?Form1099G.UnEmploymentCompensation.Value : 0);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr28Get() {
            
            #line 348 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      UnEmployment + (Form1099G.UnEmploymentCompensation.HasValue?Form1099G.UnEmploymentCompensation.Value : 0);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr28Get() {
            this.GetValueTypeValues();
            return this.@__Expr28Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr30GetTree() {
            
            #line 355 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Form1099G.FederalTaxWithHoldingAmount.HasValue && Form1099G.FederalTaxWithHoldingAmount.Value != 0.0D;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr30Get() {
            
            #line 355 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Form1099G.FederalTaxWithHoldingAmount.HasValue && Form1099G.FederalTaxWithHoldingAmount.Value != 0.0D;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr30Get() {
            this.GetValueTypeValues();
            return this.@__Expr30Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr31GetTree() {
            
            #line 367 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Form1099G.FederalTaxWithHoldingAmount.Value + Form1099GFederalTaxWithholdTotal;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr31Get() {
            
            #line 367 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Form1099G.FederalTaxWithHoldingAmount.Value + Form1099GFederalTaxWithholdTotal;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr31Get() {
            this.GetValueTypeValues();
            return this.@__Expr31Get();
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
            if (((locationReferences[(offset + 11)].Name != "Form1099G") 
                        || (locationReferences[(offset + 11)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext8_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext10 : F1040EZLinesCalculation_TypedDataContext2 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected double DeductionWorkSheetAmountA;
        
        protected double DeductionWorkSheetAmountB;
        
        protected double DeductionWorkSheetAmountC;
        
        protected double DeductionWorkSheetAmountD;
        
        protected double DeductionWorkSheetAmountE;
        
        protected double DeductionWorkSheetAmountF;
        
        protected double DeductionWorkSheetAmountG;
        
        protected double DeductionWorkSheetSingleStandardDeduction;
        
        protected double DeductionWorkSheetMFJStandardDeduction;
        
        protected double DeductionWorkSheetMFJExemption;
        
        protected double DeductionWorkSheetDefaultExemption;
        
        protected double DeductionWorksheetSingleDefaultStandardDeduction;
        
        protected double DeductionWorksheetMFJDefaultStandardDeduction;
        
        protected double DeductionWorksheetMinimunStandardDeduction;
        
        public F1040EZLinesCalculation_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext10(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            #line 472 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                  Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr44Get() {
            
            #line 472 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                  Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr44Get() {
            this.GetValueTypeValues();
            return this.@__Expr44Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr44Set(double value) {
            
            #line 472 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                  Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr44Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr44Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr47GetTree() {
            
            #line 494 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        DeductionWorkSheetAmountA;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr47Get() {
            
            #line 494 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        DeductionWorkSheetAmountA;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr47Get() {
            this.GetValueTypeValues();
            return this.@__Expr47Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr47Set(double value) {
            
            #line 494 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                        DeductionWorkSheetAmountA = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr47Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr47Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr49GetTree() {
            
            #line 506 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        DeductionWorkSheetAmountB;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr49Get() {
            
            #line 506 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        DeductionWorkSheetAmountB;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr49Get() {
            this.GetValueTypeValues();
            return this.@__Expr49Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr49Set(double value) {
            
            #line 506 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                        DeductionWorkSheetAmountB = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr49Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr49Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr51GetTree() {
            
            #line 518 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        DeductionWorkSheetAmountC;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr51Get() {
            
            #line 518 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        DeductionWorkSheetAmountC;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr51Get() {
            this.GetValueTypeValues();
            return this.@__Expr51Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr51Set(double value) {
            
            #line 518 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                        DeductionWorkSheetAmountC = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr51Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr51Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr53GetTree() {
            
            #line 530 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        DeductionWorkSheetAmountD;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr53Get() {
            
            #line 530 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        DeductionWorkSheetAmountD;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr53Get() {
            this.GetValueTypeValues();
            return this.@__Expr53Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr53Set(double value) {
            
            #line 530 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                        DeductionWorkSheetAmountD = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr53Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr53Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr55GetTree() {
            
            #line 542 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        DeductionWorkSheetAmountE;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr55Get() {
            
            #line 542 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        DeductionWorkSheetAmountE;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr55Get() {
            this.GetValueTypeValues();
            return this.@__Expr55Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr55Set(double value) {
            
            #line 542 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                        DeductionWorkSheetAmountE = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr55Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr55Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr57GetTree() {
            
            #line 554 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        DeductionWorkSheetAmountF;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr57Get() {
            
            #line 554 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        DeductionWorkSheetAmountF;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr57Get() {
            this.GetValueTypeValues();
            return this.@__Expr57Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr57Set(double value) {
            
            #line 554 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                        DeductionWorkSheetAmountF = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr57Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr57Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr59GetTree() {
            
            #line 566 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        DeductionWorkSheetAmountG;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr59Get() {
            
            #line 566 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        DeductionWorkSheetAmountG;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr59Get() {
            this.GetValueTypeValues();
            return this.@__Expr59Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr59Set(double value) {
            
            #line 566 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                        DeductionWorkSheetAmountG = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr59Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr59Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr61GetTree() {
            
            #line 578 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr61Get() {
            
            #line 578 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr61Get() {
            this.GetValueTypeValues();
            return this.@__Expr61Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr61Set(double value) {
            
            #line 578 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                        Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr61Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr61Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr64GetTree() {
            
            #line 602 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                  Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr64Get() {
            
            #line 602 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                  Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr64Get() {
            this.GetValueTypeValues();
            return this.@__Expr64Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr64Set(double value) {
            
            #line 602 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                  Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr64Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr64Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr67GetTree() {
            
            #line 625 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountA;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr67Get() {
            
            #line 625 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountA;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr67Get() {
            this.GetValueTypeValues();
            return this.@__Expr67Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr67Set(double value) {
            
            #line 625 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountA = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr67Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr67Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr69GetTree() {
            
            #line 637 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountB;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr69Get() {
            
            #line 637 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountB;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr69Get() {
            this.GetValueTypeValues();
            return this.@__Expr69Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr69Set(double value) {
            
            #line 637 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountB = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr69Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr69Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr71GetTree() {
            
            #line 649 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountC;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr71Get() {
            
            #line 649 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountC;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr71Get() {
            this.GetValueTypeValues();
            return this.@__Expr71Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr71Set(double value) {
            
            #line 649 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountC = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr71Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr71Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr73GetTree() {
            
            #line 661 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountD;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr73Get() {
            
            #line 661 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountD;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr73Get() {
            this.GetValueTypeValues();
            return this.@__Expr73Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr73Set(double value) {
            
            #line 661 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountD = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr73Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr73Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr75GetTree() {
            
            #line 673 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountE;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr75Get() {
            
            #line 673 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountE;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr75Get() {
            this.GetValueTypeValues();
            return this.@__Expr75Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr75Set(double value) {
            
            #line 673 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountE = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr75Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr75Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr77GetTree() {
            
            #line 685 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountF;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr77Get() {
            
            #line 685 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountF;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr77Get() {
            this.GetValueTypeValues();
            return this.@__Expr77Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr77Set(double value) {
            
            #line 685 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountF = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr77Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr77Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr79GetTree() {
            
            #line 697 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountG;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr79Get() {
            
            #line 697 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountG;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr79Get() {
            this.GetValueTypeValues();
            return this.@__Expr79Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr79Set(double value) {
            
            #line 697 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountG = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr79Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr79Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr81GetTree() {
            
            #line 709 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr81Get() {
            
            #line 709 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr81Get() {
            this.GetValueTypeValues();
            return this.@__Expr81Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr81Set(double value) {
            
            #line 709 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr81Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr81Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr84GetTree() {
            
            #line 732 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountA;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr84Get() {
            
            #line 732 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountA;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr84Get() {
            this.GetValueTypeValues();
            return this.@__Expr84Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr84Set(double value) {
            
            #line 732 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountA = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr84Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr84Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr86GetTree() {
            
            #line 744 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountB;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr86Get() {
            
            #line 744 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountB;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr86Get() {
            this.GetValueTypeValues();
            return this.@__Expr86Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr86Set(double value) {
            
            #line 744 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountB = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr86Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr86Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr88GetTree() {
            
            #line 756 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountC;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr88Get() {
            
            #line 756 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountC;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr88Get() {
            this.GetValueTypeValues();
            return this.@__Expr88Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr88Set(double value) {
            
            #line 756 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountC = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr88Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr88Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr90GetTree() {
            
            #line 768 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountD;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr90Get() {
            
            #line 768 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountD;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr90Get() {
            this.GetValueTypeValues();
            return this.@__Expr90Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr90Set(double value) {
            
            #line 768 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountD = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr90Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr90Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr92GetTree() {
            
            #line 780 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountE;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr92Get() {
            
            #line 780 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountE;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr92Get() {
            this.GetValueTypeValues();
            return this.@__Expr92Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr92Set(double value) {
            
            #line 780 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountE = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr92Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr92Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr94GetTree() {
            
            #line 792 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountF;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr94Get() {
            
            #line 792 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountF;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr94Get() {
            this.GetValueTypeValues();
            return this.@__Expr94Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr94Set(double value) {
            
            #line 792 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountF = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr94Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr94Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr96GetTree() {
            
            #line 804 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountG;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr96Get() {
            
            #line 804 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountG;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr96Get() {
            this.GetValueTypeValues();
            return this.@__Expr96Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr96Set(double value) {
            
            #line 804 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          DeductionWorkSheetAmountG = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr96Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr96Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr98GetTree() {
            
            #line 816 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr98Get() {
            
            #line 816 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr98Get() {
            this.GetValueTypeValues();
            return this.@__Expr98Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr98Set(double value) {
            
            #line 816 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          Tax1040Object.OutputForms.Tax1040EZPage1.StandardDeduction = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr98Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr98Set(value);
            this.SetValueTypeValues();
        }
        
        protected override void GetValueTypeValues() {
            this.DeductionWorkSheetAmountA = ((double)(this.GetVariableValue((8 + locationsOffset))));
            this.DeductionWorkSheetAmountB = ((double)(this.GetVariableValue((9 + locationsOffset))));
            this.DeductionWorkSheetAmountC = ((double)(this.GetVariableValue((10 + locationsOffset))));
            this.DeductionWorkSheetAmountD = ((double)(this.GetVariableValue((11 + locationsOffset))));
            this.DeductionWorkSheetAmountE = ((double)(this.GetVariableValue((12 + locationsOffset))));
            this.DeductionWorkSheetAmountF = ((double)(this.GetVariableValue((13 + locationsOffset))));
            this.DeductionWorkSheetAmountG = ((double)(this.GetVariableValue((14 + locationsOffset))));
            this.DeductionWorkSheetSingleStandardDeduction = ((double)(this.GetVariableValue((15 + locationsOffset))));
            this.DeductionWorkSheetMFJStandardDeduction = ((double)(this.GetVariableValue((16 + locationsOffset))));
            this.DeductionWorkSheetMFJExemption = ((double)(this.GetVariableValue((17 + locationsOffset))));
            this.DeductionWorkSheetDefaultExemption = ((double)(this.GetVariableValue((18 + locationsOffset))));
            this.DeductionWorksheetSingleDefaultStandardDeduction = ((double)(this.GetVariableValue((19 + locationsOffset))));
            this.DeductionWorksheetMFJDefaultStandardDeduction = ((double)(this.GetVariableValue((20 + locationsOffset))));
            this.DeductionWorksheetMinimunStandardDeduction = ((double)(this.GetVariableValue((21 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        protected override void SetValueTypeValues() {
            this.SetVariableValue((8 + locationsOffset), this.DeductionWorkSheetAmountA);
            this.SetVariableValue((9 + locationsOffset), this.DeductionWorkSheetAmountB);
            this.SetVariableValue((10 + locationsOffset), this.DeductionWorkSheetAmountC);
            this.SetVariableValue((11 + locationsOffset), this.DeductionWorkSheetAmountD);
            this.SetVariableValue((12 + locationsOffset), this.DeductionWorkSheetAmountE);
            this.SetVariableValue((13 + locationsOffset), this.DeductionWorkSheetAmountF);
            this.SetVariableValue((14 + locationsOffset), this.DeductionWorkSheetAmountG);
            this.SetVariableValue((15 + locationsOffset), this.DeductionWorkSheetSingleStandardDeduction);
            this.SetVariableValue((16 + locationsOffset), this.DeductionWorkSheetMFJStandardDeduction);
            this.SetVariableValue((17 + locationsOffset), this.DeductionWorkSheetMFJExemption);
            this.SetVariableValue((18 + locationsOffset), this.DeductionWorkSheetDefaultExemption);
            this.SetVariableValue((19 + locationsOffset), this.DeductionWorksheetSingleDefaultStandardDeduction);
            this.SetVariableValue((20 + locationsOffset), this.DeductionWorksheetMFJDefaultStandardDeduction);
            this.SetVariableValue((21 + locationsOffset), this.DeductionWorksheetMinimunStandardDeduction);
            base.SetValueTypeValues();
        }
        
        public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
            if (((validateLocationCount == true) 
                        && (locationReferences.Count < 22))) {
                return false;
            }
            if ((validateLocationCount == true)) {
                offset = (locationReferences.Count - 22);
            }
            expectedLocationsCount = 22;
            if (((locationReferences[(offset + 8)].Name != "DeductionWorkSheetAmountA") 
                        || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "DeductionWorkSheetAmountB") 
                        || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 10)].Name != "DeductionWorkSheetAmountC") 
                        || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 11)].Name != "DeductionWorkSheetAmountD") 
                        || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 12)].Name != "DeductionWorkSheetAmountE") 
                        || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 13)].Name != "DeductionWorkSheetAmountF") 
                        || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 14)].Name != "DeductionWorkSheetAmountG") 
                        || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 15)].Name != "DeductionWorkSheetSingleStandardDeduction") 
                        || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 16)].Name != "DeductionWorkSheetMFJStandardDeduction") 
                        || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 17)].Name != "DeductionWorkSheetMFJExemption") 
                        || (locationReferences[(offset + 17)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 18)].Name != "DeductionWorkSheetDefaultExemption") 
                        || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 19)].Name != "DeductionWorksheetSingleDefaultStandardDeduction") 
                        || (locationReferences[(offset + 19)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 20)].Name != "DeductionWorksheetMFJDefaultStandardDeduction") 
                        || (locationReferences[(offset + 20)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 21)].Name != "DeductionWorksheetMinimunStandardDeduction") 
                        || (locationReferences[(offset + 21)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext10_ForReadOnly : F1040EZLinesCalculation_TypedDataContext2_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected double DeductionWorkSheetAmountA;
        
        protected double DeductionWorkSheetAmountB;
        
        protected double DeductionWorkSheetAmountC;
        
        protected double DeductionWorkSheetAmountD;
        
        protected double DeductionWorkSheetAmountE;
        
        protected double DeductionWorkSheetAmountF;
        
        protected double DeductionWorkSheetAmountG;
        
        protected double DeductionWorkSheetSingleStandardDeduction;
        
        protected double DeductionWorkSheetMFJStandardDeduction;
        
        protected double DeductionWorkSheetMFJExemption;
        
        protected double DeductionWorkSheetDefaultExemption;
        
        protected double DeductionWorksheetSingleDefaultStandardDeduction;
        
        protected double DeductionWorksheetMFJDefaultStandardDeduction;
        
        protected double DeductionWorksheetMinimunStandardDeduction;
        
        public F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr41GetTree() {
            
            #line 459 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.FilingStatus @__Expr41Get() {
            
            #line 459 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr41Get() {
            this.GetValueTypeValues();
            return this.@__Expr41Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr42GetTree() {
            
            #line 465 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              ((!Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value));
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr42Get() {
            
            #line 465 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
              ((!Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value));
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr42Get() {
            this.GetValueTypeValues();
            return this.@__Expr42Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr43GetTree() {
            
            #line 477 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                  DeductionWorksheetSingleDefaultStandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr43Get() {
            
            #line 477 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                  DeductionWorksheetSingleDefaultStandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr43Get() {
            this.GetValueTypeValues();
            return this.@__Expr43Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr45GetTree() {
            
            #line 486 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value));
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr45Get() {
            
            #line 486 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                  ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value));
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr45Get() {
            this.GetValueTypeValues();
            return this.@__Expr45Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr46GetTree() {
            
            #line 499 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + 350;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr46Get() {
            
            #line 499 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + 350;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr46Get() {
            this.GetValueTypeValues();
            return this.@__Expr46Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr48GetTree() {
            
            #line 511 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        DeductionWorksheetMinimunStandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr48Get() {
            
            #line 511 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        DeductionWorksheetMinimunStandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr48Get() {
            this.GetValueTypeValues();
            return this.@__Expr48Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr50GetTree() {
            
            #line 523 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Math.Max(DeductionWorkSheetAmountA, DeductionWorkSheetAmountB);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr50Get() {
            
            #line 523 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        Math.Max(DeductionWorkSheetAmountA, DeductionWorkSheetAmountB);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr50Get() {
            this.GetValueTypeValues();
            return this.@__Expr50Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr52GetTree() {
            
            #line 535 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        DeductionWorkSheetSingleStandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr52Get() {
            
            #line 535 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        DeductionWorkSheetSingleStandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr52Get() {
            this.GetValueTypeValues();
            return this.@__Expr52Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr54GetTree() {
            
            #line 547 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Math.Min(DeductionWorkSheetAmountC, DeductionWorkSheetAmountD);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr54Get() {
            
            #line 547 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        Math.Min(DeductionWorkSheetAmountC, DeductionWorkSheetAmountD);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr54Get() {
            this.GetValueTypeValues();
            return this.@__Expr54Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr56GetTree() {
            
            #line 559 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        DeductionWorkSheetDefaultExemption;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr56Get() {
            
            #line 559 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        DeductionWorkSheetDefaultExemption;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr56Get() {
            this.GetValueTypeValues();
            return this.@__Expr56Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr58GetTree() {
            
            #line 571 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        DeductionWorkSheetAmountE + DeductionWorkSheetAmountF;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr58Get() {
            
            #line 571 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        DeductionWorkSheetAmountE + DeductionWorkSheetAmountF;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr58Get() {
            this.GetValueTypeValues();
            return this.@__Expr58Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr60GetTree() {
            
            #line 583 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        DeductionWorkSheetAmountG;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr60Get() {
            
            #line 583 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        DeductionWorkSheetAmountG;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr60Get() {
            this.GetValueTypeValues();
            return this.@__Expr60Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr62GetTree() {
            
            #line 595 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              ((!Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && !Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue && !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value));
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr62Get() {
            
            #line 595 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
              ((!Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && !Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue && !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value));
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr62Get() {
            this.GetValueTypeValues();
            return this.@__Expr62Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr63GetTree() {
            
            #line 607 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                  DeductionWorksheetMFJDefaultStandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr63Get() {
            
            #line 607 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                  DeductionWorksheetMFJDefaultStandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr63Get() {
            this.GetValueTypeValues();
            return this.@__Expr63Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr65GetTree() {
            
            #line 617 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value));
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr65Get() {
            
            #line 617 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                    ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value));
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr65Get() {
            this.GetValueTypeValues();
            return this.@__Expr65Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr66GetTree() {
            
            #line 630 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + 350;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr66Get() {
            
            #line 630 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + 350;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr66Get() {
            this.GetValueTypeValues();
            return this.@__Expr66Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr68GetTree() {
            
            #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorksheetMinimunStandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr68Get() {
            
            #line 642 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorksheetMinimunStandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr68Get() {
            this.GetValueTypeValues();
            return this.@__Expr68Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr70GetTree() {
            
            #line 654 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Math.Max(DeductionWorkSheetAmountA, DeductionWorkSheetAmountB);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr70Get() {
            
            #line 654 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Math.Max(DeductionWorkSheetAmountA, DeductionWorkSheetAmountB);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr70Get() {
            this.GetValueTypeValues();
            return this.@__Expr70Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr72GetTree() {
            
            #line 666 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetMFJStandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr72Get() {
            
            #line 666 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetMFJStandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr72Get() {
            this.GetValueTypeValues();
            return this.@__Expr72Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr74GetTree() {
            
            #line 678 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Math.Min(DeductionWorkSheetAmountC, DeductionWorkSheetAmountD);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr74Get() {
            
            #line 678 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Math.Min(DeductionWorkSheetAmountC, DeductionWorkSheetAmountD);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr74Get() {
            this.GetValueTypeValues();
            return this.@__Expr74Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr76GetTree() {
            
            #line 690 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetMFJExemption;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr76Get() {
            
            #line 690 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetMFJExemption;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr76Get() {
            this.GetValueTypeValues();
            return this.@__Expr76Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr78GetTree() {
            
            #line 702 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountE + DeductionWorkSheetAmountF;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr78Get() {
            
            #line 702 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountE + DeductionWorkSheetAmountF;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr78Get() {
            this.GetValueTypeValues();
            return this.@__Expr78Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr80GetTree() {
            
            #line 714 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountG;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr80Get() {
            
            #line 714 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountG;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr80Get() {
            this.GetValueTypeValues();
            return this.@__Expr80Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr82GetTree() {
            
            #line 724 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value));
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr82Get() {
            
            #line 724 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                    ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) && (Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue && Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value));
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr82Get() {
            this.GetValueTypeValues();
            return this.@__Expr82Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr83GetTree() {
            
            #line 737 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + 350;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr83Get() {
            
            #line 737 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages + 350;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr83Get() {
            this.GetValueTypeValues();
            return this.@__Expr83Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr85GetTree() {
            
            #line 749 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorksheetMinimunStandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr85Get() {
            
            #line 749 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorksheetMinimunStandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr85Get() {
            this.GetValueTypeValues();
            return this.@__Expr85Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr87GetTree() {
            
            #line 761 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Math.Max(DeductionWorkSheetAmountA, DeductionWorkSheetAmountB);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr87Get() {
            
            #line 761 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Math.Max(DeductionWorkSheetAmountA, DeductionWorkSheetAmountB);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr87Get() {
            this.GetValueTypeValues();
            return this.@__Expr87Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr89GetTree() {
            
            #line 773 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetMFJStandardDeduction;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr89Get() {
            
            #line 773 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetMFJStandardDeduction;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr89Get() {
            this.GetValueTypeValues();
            return this.@__Expr89Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr91GetTree() {
            
            #line 785 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Math.Min(DeductionWorkSheetAmountC, DeductionWorkSheetAmountD);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr91Get() {
            
            #line 785 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Math.Min(DeductionWorkSheetAmountC, DeductionWorkSheetAmountD);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr91Get() {
            this.GetValueTypeValues();
            return this.@__Expr91Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr93GetTree() {
            
            #line 797 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetDefaultExemption;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr93Get() {
            
            #line 797 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetDefaultExemption;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr93Get() {
            this.GetValueTypeValues();
            return this.@__Expr93Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr95GetTree() {
            
            #line 809 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountE + DeductionWorkSheetAmountF;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr95Get() {
            
            #line 809 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountE + DeductionWorkSheetAmountF;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr95Get() {
            this.GetValueTypeValues();
            return this.@__Expr95Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr97GetTree() {
            
            #line 821 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          DeductionWorkSheetAmountG;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr97Get() {
            
            #line 821 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          DeductionWorkSheetAmountG;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr97Get() {
            this.GetValueTypeValues();
            return this.@__Expr97Get();
        }
        
        protected override void GetValueTypeValues() {
            this.DeductionWorkSheetAmountA = ((double)(this.GetVariableValue((8 + locationsOffset))));
            this.DeductionWorkSheetAmountB = ((double)(this.GetVariableValue((9 + locationsOffset))));
            this.DeductionWorkSheetAmountC = ((double)(this.GetVariableValue((10 + locationsOffset))));
            this.DeductionWorkSheetAmountD = ((double)(this.GetVariableValue((11 + locationsOffset))));
            this.DeductionWorkSheetAmountE = ((double)(this.GetVariableValue((12 + locationsOffset))));
            this.DeductionWorkSheetAmountF = ((double)(this.GetVariableValue((13 + locationsOffset))));
            this.DeductionWorkSheetAmountG = ((double)(this.GetVariableValue((14 + locationsOffset))));
            this.DeductionWorkSheetSingleStandardDeduction = ((double)(this.GetVariableValue((15 + locationsOffset))));
            this.DeductionWorkSheetMFJStandardDeduction = ((double)(this.GetVariableValue((16 + locationsOffset))));
            this.DeductionWorkSheetMFJExemption = ((double)(this.GetVariableValue((17 + locationsOffset))));
            this.DeductionWorkSheetDefaultExemption = ((double)(this.GetVariableValue((18 + locationsOffset))));
            this.DeductionWorksheetSingleDefaultStandardDeduction = ((double)(this.GetVariableValue((19 + locationsOffset))));
            this.DeductionWorksheetMFJDefaultStandardDeduction = ((double)(this.GetVariableValue((20 + locationsOffset))));
            this.DeductionWorksheetMinimunStandardDeduction = ((double)(this.GetVariableValue((21 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
            if (((validateLocationCount == true) 
                        && (locationReferences.Count < 22))) {
                return false;
            }
            if ((validateLocationCount == true)) {
                offset = (locationReferences.Count - 22);
            }
            expectedLocationsCount = 22;
            if (((locationReferences[(offset + 8)].Name != "DeductionWorkSheetAmountA") 
                        || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "DeductionWorkSheetAmountB") 
                        || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 10)].Name != "DeductionWorkSheetAmountC") 
                        || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 11)].Name != "DeductionWorkSheetAmountD") 
                        || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 12)].Name != "DeductionWorkSheetAmountE") 
                        || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 13)].Name != "DeductionWorkSheetAmountF") 
                        || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 14)].Name != "DeductionWorkSheetAmountG") 
                        || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 15)].Name != "DeductionWorkSheetSingleStandardDeduction") 
                        || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 16)].Name != "DeductionWorkSheetMFJStandardDeduction") 
                        || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 17)].Name != "DeductionWorkSheetMFJExemption") 
                        || (locationReferences[(offset + 17)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 18)].Name != "DeductionWorkSheetDefaultExemption") 
                        || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 19)].Name != "DeductionWorksheetSingleDefaultStandardDeduction") 
                        || (locationReferences[(offset + 19)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 20)].Name != "DeductionWorksheetMFJDefaultStandardDeduction") 
                        || (locationReferences[(offset + 20)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 21)].Name != "DeductionWorksheetMinimunStandardDeduction") 
                        || (locationReferences[(offset + 21)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext11 : F1040EZLinesCalculation_TypedDataContext2 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext11(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected JTL.Tax1040.BusinessObject.W2 W2 {
            get {
                return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((8 + locationsOffset))));
            }
            set {
                this.SetVariableValue((8 + locationsOffset), value);
            }
        }
        
        protected JTL.Tax1040.BusinessObject.Form1099INT Form1099INT {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((9 + locationsOffset))));
            }
            set {
                this.SetVariableValue((9 + locationsOffset), value);
            }
        }
        
        protected JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((10 + locationsOffset))));
            }
            set {
                this.SetVariableValue((10 + locationsOffset), value);
            }
        }
        
        protected JTL.Tax1040.BusinessObject.Form1099G Form1099G {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((11 + locationsOffset))));
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
        
        internal System.Linq.Expressions.Expression @__Expr104GetTree() {
            
            #line 879 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
              Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr104Get() {
            
            #line 879 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
              Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr104Get() {
            this.GetValueTypeValues();
            return this.@__Expr104Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr104Set(double value) {
            
            #line 879 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
              Tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr104Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr104Set(value);
            this.SetValueTypeValues();
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
            if (((locationReferences[(offset + 8)].Name != "W2") 
                        || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "Form1099INT") 
                        || (locationReferences[(offset + 9)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                return false;
            }
            if (((locationReferences[(offset + 10)].Name != "Form1099OID") 
                        || (locationReferences[(offset + 10)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                return false;
            }
            if (((locationReferences[(offset + 11)].Name != "Form1099G") 
                        || (locationReferences[(offset + 11)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext11_ForReadOnly : F1040EZLinesCalculation_TypedDataContext2_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected JTL.Tax1040.BusinessObject.W2 W2 {
            get {
                return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((8 + locationsOffset))));
            }
        }
        
        protected JTL.Tax1040.BusinessObject.Form1099INT Form1099INT {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099INT)(this.GetVariableValue((9 + locationsOffset))));
            }
        }
        
        protected JTL.Tax1040.BusinessObject.Form1099OID Form1099OID {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099OID)(this.GetVariableValue((10 + locationsOffset))));
            }
        }
        
        protected JTL.Tax1040.BusinessObject.Form1099G Form1099G {
            get {
                return ((JTL.Tax1040.BusinessObject.Form1099G)(this.GetVariableValue((11 + locationsOffset))));
            }
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr103GetTree() {
            
            #line 884 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
              W2FederalTaxWithholdTotal+ Form1099INTFederalTaxWithholdTotal+ Form1099OIDFederalTaxWithholdTotal + Form1099GFederalTaxWithholdTotal;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr103Get() {
            
            #line 884 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
              W2FederalTaxWithholdTotal+ Form1099INTFederalTaxWithholdTotal+ Form1099OIDFederalTaxWithholdTotal + Form1099GFederalTaxWithholdTotal;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr103Get() {
            this.GetValueTypeValues();
            return this.@__Expr103Get();
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
            if (((locationReferences[(offset + 8)].Name != "W2") 
                        || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "Form1099INT") 
                        || (locationReferences[(offset + 9)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099INT)))) {
                return false;
            }
            if (((locationReferences[(offset + 10)].Name != "Form1099OID") 
                        || (locationReferences[(offset + 10)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099OID)))) {
                return false;
            }
            if (((locationReferences[(offset + 11)].Name != "Form1099G") 
                        || (locationReferences[(offset + 11)].Type != typeof(JTL.Tax1040.BusinessObject.Form1099G)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext12 : F1040EZLinesCalculation_TypedDataContext2 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected System.DateTime TodaysDate;
        
        protected System.TimeSpan TaxPayerTimeZone;
        
        protected System.DateTime PersonAge;
        
        protected int PersonAgeCompleted;
        
        protected System.TimeSpan SpouseTimeZone;
        
        protected System.DateTime SpouseAge;
        
        protected int SpouseAgeCompleted;
        
        protected int MinAge;
        
        protected int MaxAge;
        
        protected double MFJAdjustedGrossIncome;
        
        protected double SingleAdjustedGrossIncome;
        
        public F1040EZLinesCalculation_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext12(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            this.TodaysDate = ((System.DateTime)(this.GetVariableValue((8 + locationsOffset))));
            this.TaxPayerTimeZone = ((System.TimeSpan)(this.GetVariableValue((9 + locationsOffset))));
            this.PersonAge = ((System.DateTime)(this.GetVariableValue((10 + locationsOffset))));
            this.PersonAgeCompleted = ((int)(this.GetVariableValue((11 + locationsOffset))));
            this.SpouseTimeZone = ((System.TimeSpan)(this.GetVariableValue((12 + locationsOffset))));
            this.SpouseAge = ((System.DateTime)(this.GetVariableValue((13 + locationsOffset))));
            this.SpouseAgeCompleted = ((int)(this.GetVariableValue((14 + locationsOffset))));
            this.MinAge = ((int)(this.GetVariableValue((15 + locationsOffset))));
            this.MaxAge = ((int)(this.GetVariableValue((16 + locationsOffset))));
            this.MFJAdjustedGrossIncome = ((double)(this.GetVariableValue((17 + locationsOffset))));
            this.SingleAdjustedGrossIncome = ((double)(this.GetVariableValue((18 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        protected override void SetValueTypeValues() {
            this.SetVariableValue((8 + locationsOffset), this.TodaysDate);
            this.SetVariableValue((9 + locationsOffset), this.TaxPayerTimeZone);
            this.SetVariableValue((10 + locationsOffset), this.PersonAge);
            this.SetVariableValue((11 + locationsOffset), this.PersonAgeCompleted);
            this.SetVariableValue((12 + locationsOffset), this.SpouseTimeZone);
            this.SetVariableValue((13 + locationsOffset), this.SpouseAge);
            this.SetVariableValue((14 + locationsOffset), this.SpouseAgeCompleted);
            this.SetVariableValue((15 + locationsOffset), this.MinAge);
            this.SetVariableValue((16 + locationsOffset), this.MaxAge);
            this.SetVariableValue((17 + locationsOffset), this.MFJAdjustedGrossIncome);
            this.SetVariableValue((18 + locationsOffset), this.SingleAdjustedGrossIncome);
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
            if (((locationReferences[(offset + 8)].Name != "TodaysDate") 
                        || (locationReferences[(offset + 8)].Type != typeof(System.DateTime)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "TaxPayerTimeZone") 
                        || (locationReferences[(offset + 9)].Type != typeof(System.TimeSpan)))) {
                return false;
            }
            if (((locationReferences[(offset + 10)].Name != "PersonAge") 
                        || (locationReferences[(offset + 10)].Type != typeof(System.DateTime)))) {
                return false;
            }
            if (((locationReferences[(offset + 11)].Name != "PersonAgeCompleted") 
                        || (locationReferences[(offset + 11)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 12)].Name != "SpouseTimeZone") 
                        || (locationReferences[(offset + 12)].Type != typeof(System.TimeSpan)))) {
                return false;
            }
            if (((locationReferences[(offset + 13)].Name != "SpouseAge") 
                        || (locationReferences[(offset + 13)].Type != typeof(System.DateTime)))) {
                return false;
            }
            if (((locationReferences[(offset + 14)].Name != "SpouseAgeCompleted") 
                        || (locationReferences[(offset + 14)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 15)].Name != "MinAge") 
                        || (locationReferences[(offset + 15)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 16)].Name != "MaxAge") 
                        || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 17)].Name != "MFJAdjustedGrossIncome") 
                        || (locationReferences[(offset + 17)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 18)].Name != "SingleAdjustedGrossIncome") 
                        || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext12_ForReadOnly : F1040EZLinesCalculation_TypedDataContext2_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected System.DateTime TodaysDate;
        
        protected System.TimeSpan TaxPayerTimeZone;
        
        protected System.DateTime PersonAge;
        
        protected int PersonAgeCompleted;
        
        protected System.TimeSpan SpouseTimeZone;
        
        protected System.DateTime SpouseAge;
        
        protected int SpouseAgeCompleted;
        
        protected int MinAge;
        
        protected int MaxAge;
        
        protected double MFJAdjustedGrossIncome;
        
        protected double SingleAdjustedGrossIncome;
        
        public F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr105GetTree() {
            
            #line 894 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
            DateTime.Now;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.DateTime @__Expr105Get() {
            
            #line 894 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            DateTime.Now;
            
            #line default
            #line hidden
        }
        
        public System.DateTime ValueType___Expr105Get() {
            this.GetValueTypeValues();
            return this.@__Expr105Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr106GetTree() {
            
            #line 899 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
            TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.TimeSpan @__Expr106Get() {
            
            #line 899 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            TodaysDate - Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
            
            #line default
            #line hidden
        }
        
        public System.TimeSpan ValueType___Expr106Get() {
            this.GetValueTypeValues();
            return this.@__Expr106Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr107GetTree() {
            
            #line 904 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
            DateTime.MinValue + TaxPayerTimeZone;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.DateTime @__Expr107Get() {
            
            #line 904 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            DateTime.MinValue + TaxPayerTimeZone;
            
            #line default
            #line hidden
        }
        
        public System.DateTime ValueType___Expr107Get() {
            this.GetValueTypeValues();
            return this.@__Expr107Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr108GetTree() {
            
            #line 909 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
            PersonAge.Year - 1;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public int @__Expr108Get() {
            
            #line 909 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            PersonAge.Year - 1;
            
            #line default
            #line hidden
        }
        
        public int ValueType___Expr108Get() {
            this.GetValueTypeValues();
            return this.@__Expr108Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr109GetTree() {
            
            #line 914 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
            TodaysDate - Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.TimeSpan @__Expr109Get() {
            
            #line 914 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            TodaysDate - Tax1040Object.PersonalDetails.Spouse.Person.DateOfBirth;
            
            #line default
            #line hidden
        }
        
        public System.TimeSpan ValueType___Expr109Get() {
            this.GetValueTypeValues();
            return this.@__Expr109Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr110GetTree() {
            
            #line 919 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
            DateTime.MinValue + SpouseTimeZone;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.DateTime @__Expr110Get() {
            
            #line 919 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            DateTime.MinValue + SpouseTimeZone;
            
            #line default
            #line hidden
        }
        
        public System.DateTime ValueType___Expr110Get() {
            this.GetValueTypeValues();
            return this.@__Expr110Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr111GetTree() {
            
            #line 924 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
            SpouseAge.Year - 1;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public int @__Expr111Get() {
            
            #line 924 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            SpouseAge.Year - 1;
            
            #line default
            #line hidden
        }
        
        public int ValueType___Expr111Get() {
            this.GetValueTypeValues();
            return this.@__Expr111Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr112GetTree() {
            
            #line 936 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.Single)
 && (Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome < SingleAdjustedGrossIncome) && (!Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value))
 || ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly) && (Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome < MFJAdjustedGrossIncome)
  && ((!Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) || (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value)))
 && ((PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && (SpouseAgeCompleted >= MinAge && SpouseAgeCompleted <= MaxAge));
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr112Get() {
            
            #line 936 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
              ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.Single)
 && (Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome < SingleAdjustedGrossIncome) && (!Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value))
 || ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly) && (Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome < MFJAdjustedGrossIncome)
  && ((!Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value) || (!Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue || !Tax1040Object.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value)))
 && ((PersonAgeCompleted >= MinAge && PersonAgeCompleted <= MaxAge) && (SpouseAgeCompleted >= MinAge && SpouseAgeCompleted <= MaxAge));
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr112Get() {
            this.GetValueTypeValues();
            return this.@__Expr112Get();
        }
        
        protected override void GetValueTypeValues() {
            this.TodaysDate = ((System.DateTime)(this.GetVariableValue((8 + locationsOffset))));
            this.TaxPayerTimeZone = ((System.TimeSpan)(this.GetVariableValue((9 + locationsOffset))));
            this.PersonAge = ((System.DateTime)(this.GetVariableValue((10 + locationsOffset))));
            this.PersonAgeCompleted = ((int)(this.GetVariableValue((11 + locationsOffset))));
            this.SpouseTimeZone = ((System.TimeSpan)(this.GetVariableValue((12 + locationsOffset))));
            this.SpouseAge = ((System.DateTime)(this.GetVariableValue((13 + locationsOffset))));
            this.SpouseAgeCompleted = ((int)(this.GetVariableValue((14 + locationsOffset))));
            this.MinAge = ((int)(this.GetVariableValue((15 + locationsOffset))));
            this.MaxAge = ((int)(this.GetVariableValue((16 + locationsOffset))));
            this.MFJAdjustedGrossIncome = ((double)(this.GetVariableValue((17 + locationsOffset))));
            this.SingleAdjustedGrossIncome = ((double)(this.GetVariableValue((18 + locationsOffset))));
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
            if (((locationReferences[(offset + 8)].Name != "TodaysDate") 
                        || (locationReferences[(offset + 8)].Type != typeof(System.DateTime)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "TaxPayerTimeZone") 
                        || (locationReferences[(offset + 9)].Type != typeof(System.TimeSpan)))) {
                return false;
            }
            if (((locationReferences[(offset + 10)].Name != "PersonAge") 
                        || (locationReferences[(offset + 10)].Type != typeof(System.DateTime)))) {
                return false;
            }
            if (((locationReferences[(offset + 11)].Name != "PersonAgeCompleted") 
                        || (locationReferences[(offset + 11)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 12)].Name != "SpouseTimeZone") 
                        || (locationReferences[(offset + 12)].Type != typeof(System.TimeSpan)))) {
                return false;
            }
            if (((locationReferences[(offset + 13)].Name != "SpouseAge") 
                        || (locationReferences[(offset + 13)].Type != typeof(System.DateTime)))) {
                return false;
            }
            if (((locationReferences[(offset + 14)].Name != "SpouseAgeCompleted") 
                        || (locationReferences[(offset + 14)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 15)].Name != "MinAge") 
                        || (locationReferences[(offset + 15)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 16)].Name != "MaxAge") 
                        || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 17)].Name != "MFJAdjustedGrossIncome") 
                        || (locationReferences[(offset + 17)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 18)].Name != "SingleAdjustedGrossIncome") 
                        || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext13 : F1040EZLinesCalculation_TypedDataContext12 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected double Line8Step2EarnedIncome;
        
        protected double Line8Step2W2NonQualifiedPlans;
        
        protected double Line8Step2W2NonTaxableCombatPay;
        
        public F1040EZLinesCalculation_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext13(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr120GetTree() {
            
            #line 1000 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Line8Step2EarnedIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr120Get() {
            
            #line 1000 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                    Line8Step2EarnedIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr120Get() {
            this.GetValueTypeValues();
            return this.@__Expr120Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr120Set(double value) {
            
            #line 1000 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                    Line8Step2EarnedIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr120Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr120Set(value);
            this.SetValueTypeValues();
        }
        
        protected override void GetValueTypeValues() {
            this.Line8Step2EarnedIncome = ((double)(this.GetVariableValue((19 + locationsOffset))));
            this.Line8Step2W2NonQualifiedPlans = ((double)(this.GetVariableValue((20 + locationsOffset))));
            this.Line8Step2W2NonTaxableCombatPay = ((double)(this.GetVariableValue((21 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        protected override void SetValueTypeValues() {
            this.SetVariableValue((19 + locationsOffset), this.Line8Step2EarnedIncome);
            this.SetVariableValue((20 + locationsOffset), this.Line8Step2W2NonQualifiedPlans);
            this.SetVariableValue((21 + locationsOffset), this.Line8Step2W2NonTaxableCombatPay);
            base.SetValueTypeValues();
        }
        
        public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
            if (((validateLocationCount == true) 
                        && (locationReferences.Count < 22))) {
                return false;
            }
            if ((validateLocationCount == true)) {
                offset = (locationReferences.Count - 22);
            }
            expectedLocationsCount = 22;
            if (((locationReferences[(offset + 19)].Name != "Line8Step2EarnedIncome") 
                        || (locationReferences[(offset + 19)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 20)].Name != "Line8Step2W2NonQualifiedPlans") 
                        || (locationReferences[(offset + 20)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 21)].Name != "Line8Step2W2NonTaxableCombatPay") 
                        || (locationReferences[(offset + 21)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext12.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext13_ForReadOnly : F1040EZLinesCalculation_TypedDataContext12_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected double Line8Step2EarnedIncome;
        
        protected double Line8Step2W2NonQualifiedPlans;
        
        protected double Line8Step2W2NonTaxableCombatPay;
        
        public F1040EZLinesCalculation_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr113GetTree() {
            
            #line 953 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    (Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr113Get() {
            
            #line 953 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                    (Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count>0);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr113Get() {
            this.GetValueTypeValues();
            return this.@__Expr113Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr114GetTree() {
            
            #line 960 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.W2>>> expression = () => 
                        Tax1040Object.Income.W2Wages;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.W2> @__Expr114Get() {
            
            #line 960 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        Tax1040Object.Income.W2Wages;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.W2> ValueType___Expr114Get() {
            this.GetValueTypeValues();
            return this.@__Expr114Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr119GetTree() {
            
            #line 1005 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages - Line8Step2W2NonQualifiedPlans + Line8Step2W2NonTaxableCombatPay;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr119Get() {
            
            #line 1005 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages - Line8Step2W2NonQualifiedPlans + Line8Step2W2NonTaxableCombatPay;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr119Get() {
            this.GetValueTypeValues();
            return this.@__Expr119Get();
        }
        
        protected override void GetValueTypeValues() {
            this.Line8Step2EarnedIncome = ((double)(this.GetVariableValue((19 + locationsOffset))));
            this.Line8Step2W2NonQualifiedPlans = ((double)(this.GetVariableValue((20 + locationsOffset))));
            this.Line8Step2W2NonTaxableCombatPay = ((double)(this.GetVariableValue((21 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
            if (((validateLocationCount == true) 
                        && (locationReferences.Count < 22))) {
                return false;
            }
            if ((validateLocationCount == true)) {
                offset = (locationReferences.Count - 22);
            }
            expectedLocationsCount = 22;
            if (((locationReferences[(offset + 19)].Name != "Line8Step2EarnedIncome") 
                        || (locationReferences[(offset + 19)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 20)].Name != "Line8Step2W2NonQualifiedPlans") 
                        || (locationReferences[(offset + 20)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 21)].Name != "Line8Step2W2NonTaxableCombatPay") 
                        || (locationReferences[(offset + 21)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext12_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext14 : F1040EZLinesCalculation_TypedDataContext13 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext14(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected JTL.Tax1040.BusinessObject.W2 W2 {
            get {
                return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((22 + locationsOffset))));
            }
            set {
                this.SetVariableValue((22 + locationsOffset), value);
            }
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr116GetTree() {
            
            #line 971 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Line8Step2W2NonQualifiedPlans;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr116Get() {
            
            #line 971 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                              Line8Step2W2NonQualifiedPlans;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr116Get() {
            this.GetValueTypeValues();
            return this.@__Expr116Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr116Set(double value) {
            
            #line 971 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                              Line8Step2W2NonQualifiedPlans = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr116Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr116Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr118GetTree() {
            
            #line 983 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Line8Step2W2NonTaxableCombatPay;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr118Get() {
            
            #line 983 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                              Line8Step2W2NonTaxableCombatPay;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr118Get() {
            this.GetValueTypeValues();
            return this.@__Expr118Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr118Set(double value) {
            
            #line 983 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                              Line8Step2W2NonTaxableCombatPay = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr118Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr118Set(value);
            this.SetValueTypeValues();
        }
        
        public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
            if (((validateLocationCount == true) 
                        && (locationReferences.Count < 23))) {
                return false;
            }
            if ((validateLocationCount == true)) {
                offset = (locationReferences.Count - 23);
            }
            expectedLocationsCount = 23;
            if (((locationReferences[(offset + 22)].Name != "W2") 
                        || (locationReferences[(offset + 22)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext13.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext14_ForReadOnly : F1040EZLinesCalculation_TypedDataContext13_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected JTL.Tax1040.BusinessObject.W2 W2 {
            get {
                return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((22 + locationsOffset))));
            }
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr115GetTree() {
            
            #line 976 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Line8Step2W2NonQualifiedPlans + (W2.NonQualifiedPlansAmount.HasValue ? W2.NonQualifiedPlansAmount.Value : 0);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr115Get() {
            
            #line 976 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                              Line8Step2W2NonQualifiedPlans + (W2.NonQualifiedPlansAmount.HasValue ? W2.NonQualifiedPlansAmount.Value : 0);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr115Get() {
            this.GetValueTypeValues();
            return this.@__Expr115Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr117GetTree() {
            
            #line 988 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Line8Step2W2NonTaxableCombatPay;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr117Get() {
            
            #line 988 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                              Line8Step2W2NonTaxableCombatPay;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr117Get() {
            this.GetValueTypeValues();
            return this.@__Expr117Get();
        }
        
        public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
            if (((validateLocationCount == true) 
                        && (locationReferences.Count < 23))) {
                return false;
            }
            if ((validateLocationCount == true)) {
                offset = (locationReferences.Count - 23);
            }
            expectedLocationsCount = 23;
            if (((locationReferences[(offset + 22)].Name != "W2") 
                        || (locationReferences[(offset + 22)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext13_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext15 : F1040EZLinesCalculation_TypedDataContext13 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected int Line8EICWorkSheetLine1;
        
        protected double Line8EICWorkSheetLine2;
        
        protected double Line8EICWorkSheetLine6;
        
        protected double Line8EICWorkSheetLine3;
        
        protected double Line8EICWorkSheetLine5;
        
        protected int EICStartingValue;
        
        protected int EICModuleValue;
        
        protected int EICInitialRangeStartValue;
        
        protected int EICInitialRangeEndValue;
        
        protected int EICRateInitialValue;
        
        protected int EICModuleDifference;
        
        public F1040EZLinesCalculation_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext15(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr122GetTree() {
            
            #line 1026 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      Line8EICWorkSheetLine1;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public int @__Expr122Get() {
            
            #line 1026 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Line8EICWorkSheetLine1;
            
            #line default
            #line hidden
        }
        
        public int ValueType___Expr122Get() {
            this.GetValueTypeValues();
            return this.@__Expr122Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr122Set(int value) {
            
            #line 1026 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                      Line8EICWorkSheetLine1 = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr122Set(int value) {
            this.GetValueTypeValues();
            this.@__Expr122Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr125GetTree() {
            
            #line 1045 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Line8EICWorkSheetLine2;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr125Get() {
            
            #line 1045 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Line8EICWorkSheetLine2;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr125Get() {
            this.GetValueTypeValues();
            return this.@__Expr125Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr125Set(double value) {
            
            #line 1045 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          Line8EICWorkSheetLine2 = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr125Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr125Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr127GetTree() {
            
            #line 1060 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            EICModuleDifference;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public int @__Expr127Get() {
            
            #line 1060 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            EICModuleDifference;
            
            #line default
            #line hidden
        }
        
        public int ValueType___Expr127Get() {
            this.GetValueTypeValues();
            return this.@__Expr127Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr127Set(int value) {
            
            #line 1060 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            EICModuleDifference = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr127Set(int value) {
            this.GetValueTypeValues();
            this.@__Expr127Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr129GetTree() {
            
            #line 1072 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            EICStartingValue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public int @__Expr129Get() {
            
            #line 1072 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            EICStartingValue;
            
            #line default
            #line hidden
        }
        
        public int ValueType___Expr129Get() {
            this.GetValueTypeValues();
            return this.@__Expr129Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr129Set(int value) {
            
            #line 1072 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            EICStartingValue = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr129Set(int value) {
            this.GetValueTypeValues();
            this.@__Expr129Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr131GetTree() {
            
            #line 1102 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  EICOut;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public int @__Expr131Get() {
            
            #line 1102 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                  EICOut;
            
            #line default
            #line hidden
        }
        
        public int ValueType___Expr131Get() {
            this.GetValueTypeValues();
            return this.@__Expr131Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr131Set(int value) {
            
            #line 1102 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                  EICOut = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr131Set(int value) {
            this.GetValueTypeValues();
            this.@__Expr131Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr135GetTree() {
            
            #line 1109 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  Line8EICWorkSheetLine2;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr135Get() {
            
            #line 1109 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                  Line8EICWorkSheetLine2;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr135Get() {
            this.GetValueTypeValues();
            return this.@__Expr135Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr135Set(double value) {
            
            #line 1109 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                  Line8EICWorkSheetLine2 = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr135Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr135Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr137GetTree() {
            
            #line 1134 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Line8EICWorkSheetLine6;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr137Get() {
            
            #line 1134 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Line8EICWorkSheetLine6;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr137Get() {
            this.GetValueTypeValues();
            return this.@__Expr137Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr137Set(double value) {
            
            #line 1134 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                          Line8EICWorkSheetLine6 = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr137Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr137Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr139GetTree() {
            
            #line 1147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Line8EICWorkSheetLine3;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr139Get() {
            
            #line 1147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Line8EICWorkSheetLine3;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr139Get() {
            this.GetValueTypeValues();
            return this.@__Expr139Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr139Set(double value) {
            
            #line 1147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            Line8EICWorkSheetLine3 = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr139Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr139Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr142GetTree() {
            
            #line 1166 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Line8EICWorkSheetLine6;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr142Get() {
            
            #line 1166 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Line8EICWorkSheetLine6;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr142Get() {
            this.GetValueTypeValues();
            return this.@__Expr142Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr142Set(double value) {
            
            #line 1166 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                Line8EICWorkSheetLine6 = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr142Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr142Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr145GetTree() {
            
            #line 1188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Line8EICWorkSheetLine6;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr145Get() {
            
            #line 1188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                    Line8EICWorkSheetLine6;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr145Get() {
            this.GetValueTypeValues();
            return this.@__Expr145Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr145Set(double value) {
            
            #line 1188 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                    Line8EICWorkSheetLine6 = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr145Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr145Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr147GetTree() {
            
            #line 1203 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      Line8EICWorkSheetLine5;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr147Get() {
            
            #line 1203 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                      Line8EICWorkSheetLine5;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr147Get() {
            this.GetValueTypeValues();
            return this.@__Expr147Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr147Set(double value) {
            
            #line 1203 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                      Line8EICWorkSheetLine5 = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr147Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr147Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr149GetTree() {
            
            #line 1215 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      Line8EICWorkSheetLine6;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr149Get() {
            
            #line 1215 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                      Line8EICWorkSheetLine6;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr149Get() {
            this.GetValueTypeValues();
            return this.@__Expr149Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr149Set(double value) {
            
            #line 1215 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                      Line8EICWorkSheetLine6 = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr149Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr149Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr151GetTree() {
            
            #line 1235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr151Get() {
            
            #line 1235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr151Get() {
            this.GetValueTypeValues();
            return this.@__Expr151Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr151Set(double value) {
            
            #line 1235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                      Tax1040Object.OutputForms.Tax1040EZPage1.EarnedIncomeCredit = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr151Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr151Set(value);
            this.SetValueTypeValues();
        }
        
        protected override void GetValueTypeValues() {
            this.Line8EICWorkSheetLine1 = ((int)(this.GetVariableValue((22 + locationsOffset))));
            this.Line8EICWorkSheetLine2 = ((double)(this.GetVariableValue((23 + locationsOffset))));
            this.Line8EICWorkSheetLine6 = ((double)(this.GetVariableValue((24 + locationsOffset))));
            this.Line8EICWorkSheetLine3 = ((double)(this.GetVariableValue((25 + locationsOffset))));
            this.Line8EICWorkSheetLine5 = ((double)(this.GetVariableValue((26 + locationsOffset))));
            this.EICStartingValue = ((int)(this.GetVariableValue((27 + locationsOffset))));
            this.EICModuleValue = ((int)(this.GetVariableValue((28 + locationsOffset))));
            this.EICInitialRangeStartValue = ((int)(this.GetVariableValue((29 + locationsOffset))));
            this.EICInitialRangeEndValue = ((int)(this.GetVariableValue((30 + locationsOffset))));
            this.EICRateInitialValue = ((int)(this.GetVariableValue((31 + locationsOffset))));
            this.EICModuleDifference = ((int)(this.GetVariableValue((32 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        protected override void SetValueTypeValues() {
            this.SetVariableValue((22 + locationsOffset), this.Line8EICWorkSheetLine1);
            this.SetVariableValue((23 + locationsOffset), this.Line8EICWorkSheetLine2);
            this.SetVariableValue((24 + locationsOffset), this.Line8EICWorkSheetLine6);
            this.SetVariableValue((25 + locationsOffset), this.Line8EICWorkSheetLine3);
            this.SetVariableValue((26 + locationsOffset), this.Line8EICWorkSheetLine5);
            this.SetVariableValue((27 + locationsOffset), this.EICStartingValue);
            this.SetVariableValue((28 + locationsOffset), this.EICModuleValue);
            this.SetVariableValue((29 + locationsOffset), this.EICInitialRangeStartValue);
            this.SetVariableValue((30 + locationsOffset), this.EICInitialRangeEndValue);
            this.SetVariableValue((31 + locationsOffset), this.EICRateInitialValue);
            this.SetVariableValue((32 + locationsOffset), this.EICModuleDifference);
            base.SetValueTypeValues();
        }
        
        public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
            if (((validateLocationCount == true) 
                        && (locationReferences.Count < 33))) {
                return false;
            }
            if ((validateLocationCount == true)) {
                offset = (locationReferences.Count - 33);
            }
            expectedLocationsCount = 33;
            if (((locationReferences[(offset + 22)].Name != "Line8EICWorkSheetLine1") 
                        || (locationReferences[(offset + 22)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 23)].Name != "Line8EICWorkSheetLine2") 
                        || (locationReferences[(offset + 23)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 24)].Name != "Line8EICWorkSheetLine6") 
                        || (locationReferences[(offset + 24)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 25)].Name != "Line8EICWorkSheetLine3") 
                        || (locationReferences[(offset + 25)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 26)].Name != "Line8EICWorkSheetLine5") 
                        || (locationReferences[(offset + 26)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 27)].Name != "EICStartingValue") 
                        || (locationReferences[(offset + 27)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 28)].Name != "EICModuleValue") 
                        || (locationReferences[(offset + 28)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 29)].Name != "EICInitialRangeStartValue") 
                        || (locationReferences[(offset + 29)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 30)].Name != "EICInitialRangeEndValue") 
                        || (locationReferences[(offset + 30)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 31)].Name != "EICRateInitialValue") 
                        || (locationReferences[(offset + 31)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 32)].Name != "EICModuleDifference") 
                        || (locationReferences[(offset + 32)].Type != typeof(int)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext13.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext15_ForReadOnly : F1040EZLinesCalculation_TypedDataContext13_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected int Line8EICWorkSheetLine1;
        
        protected double Line8EICWorkSheetLine2;
        
        protected double Line8EICWorkSheetLine6;
        
        protected double Line8EICWorkSheetLine3;
        
        protected double Line8EICWorkSheetLine5;
        
        protected int EICStartingValue;
        
        protected int EICModuleValue;
        
        protected int EICInitialRangeStartValue;
        
        protected int EICInitialRangeEndValue;
        
        protected int EICRateInitialValue;
        
        protected int EICModuleDifference;
        
        public F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr121GetTree() {
            
            #line 1031 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      (int)Line8Step2EarnedIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public int @__Expr121Get() {
            
            #line 1031 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      (int)Line8Step2EarnedIncome;
            
            #line default
            #line hidden
        }
        
        public int ValueType___Expr121Get() {
            this.GetValueTypeValues();
            return this.@__Expr121Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr123GetTree() {
            
            #line 1038 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Line8EICWorkSheetLine1 > EICInitialRangeStartValue && Line8EICWorkSheetLine1 <= EICInitialRangeEndValue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr123Get() {
            
            #line 1038 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Line8EICWorkSheetLine1 > EICInitialRangeStartValue && Line8EICWorkSheetLine1 <= EICInitialRangeEndValue;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr123Get() {
            this.GetValueTypeValues();
            return this.@__Expr123Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr124GetTree() {
            
            #line 1050 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          EICRateInitialValue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr124Get() {
            
            #line 1050 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          EICRateInitialValue;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr124Get() {
            this.GetValueTypeValues();
            return this.@__Expr124Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr126GetTree() {
            
            #line 1065 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            Line8EICWorkSheetLine1 % EICModuleValue;;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public int @__Expr126Get() {
            
            #line 1065 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Line8EICWorkSheetLine1 % EICModuleValue;;
            
            #line default
            #line hidden
        }
        
        public int ValueType___Expr126Get() {
            this.GetValueTypeValues();
            return this.@__Expr126Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr128GetTree() {
            
            #line 1077 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            Line8EICWorkSheetLine1 != EICModuleDifference ? Line8EICWorkSheetLine1 - EICModuleDifference : Line8EICWorkSheetLine1;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public int @__Expr128Get() {
            
            #line 1077 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Line8EICWorkSheetLine1 != EICModuleDifference ? Line8EICWorkSheetLine1 - EICModuleDifference : Line8EICWorkSheetLine1;
            
            #line default
            #line hidden
        }
        
        public int ValueType___Expr128Get() {
            this.GetValueTypeValues();
            return this.@__Expr128Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr130GetTree() {
            
            #line 1084 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            (Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr130Get() {
            
            #line 1084 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            (Form1040ezEICCollection != null && !Form1040ezEICCollection.IsEmpty);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr130Get() {
            this.GetValueTypeValues();
            return this.@__Expr130Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr132GetTree() {
            
            #line 1092 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IDictionary<int, int>>> expression = () => 
                                  Form1040ezEICCollection;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.IDictionary<int, int> @__Expr132Get() {
            
            #line 1092 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                  Form1040ezEICCollection;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.IDictionary<int, int> ValueType___Expr132Get() {
            this.GetValueTypeValues();
            return this.@__Expr132Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr133GetTree() {
            
            #line 1097 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  EICStartingValue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public int @__Expr133Get() {
            
            #line 1097 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                  EICStartingValue;
            
            #line default
            #line hidden
        }
        
        public int ValueType___Expr133Get() {
            this.GetValueTypeValues();
            return this.@__Expr133Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr134GetTree() {
            
            #line 1114 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  EICOut;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr134Get() {
            
            #line 1114 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                  EICOut;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr134Get() {
            this.GetValueTypeValues();
            return this.@__Expr134Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr136GetTree() {
            
            #line 1127 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Line8EICWorkSheetLine2 == 0;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr136Get() {
            
            #line 1127 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Line8EICWorkSheetLine2 == 0;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr136Get() {
            this.GetValueTypeValues();
            return this.@__Expr136Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr138GetTree() {
            
            #line 1152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr138Get() {
            
            #line 1152 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr138Get() {
            this.GetValueTypeValues();
            return this.@__Expr138Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr140GetTree() {
            
            #line 1159 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Line8EICWorkSheetLine3 == Line8EICWorkSheetLine1;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr140Get() {
            
            #line 1159 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Line8EICWorkSheetLine3 == Line8EICWorkSheetLine1;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr140Get() {
            this.GetValueTypeValues();
            return this.@__Expr140Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr141GetTree() {
            
            #line 1171 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Line8EICWorkSheetLine2;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr141Get() {
            
            #line 1171 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Line8EICWorkSheetLine2;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr141Get() {
            this.GetValueTypeValues();
            return this.@__Expr141Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr143GetTree() {
            
            #line 1180 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                (((Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.Single) && (Line8EICWorkSheetLine3 < 7800)) 
            || ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly) &&(Line8EICWorkSheetLine3 < 13000)));
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr143Get() {
            
            #line 1180 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                (((Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.Single) && (Line8EICWorkSheetLine3 < 7800)) 
            || ((Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus == FilingStatus.MarriedFilingJointly) &&(Line8EICWorkSheetLine3 < 13000)));
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr143Get() {
            this.GetValueTypeValues();
            return this.@__Expr143Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr144GetTree() {
            
            #line 1193 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Line8EICWorkSheetLine2;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr144Get() {
            
            #line 1193 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                    Line8EICWorkSheetLine2;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr144Get() {
            this.GetValueTypeValues();
            return this.@__Expr144Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr146GetTree() {
            
            #line 1208 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      Line8EICWorkSheetLine5;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr146Get() {
            
            #line 1208 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                      Line8EICWorkSheetLine5;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr146Get() {
            this.GetValueTypeValues();
            return this.@__Expr146Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr148GetTree() {
            
            #line 1220 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                      Math.Min(Line8EICWorkSheetLine2,Line8EICWorkSheetLine5);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr148Get() {
            
            #line 1220 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                      Math.Min(Line8EICWorkSheetLine2,Line8EICWorkSheetLine5);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr148Get() {
            this.GetValueTypeValues();
            return this.@__Expr148Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr150GetTree() {
            
            #line 1240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                      Line8EICWorkSheetLine6;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr150Get() {
            
            #line 1240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Line8EICWorkSheetLine6;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr150Get() {
            this.GetValueTypeValues();
            return this.@__Expr150Get();
        }
        
        protected override void GetValueTypeValues() {
            this.Line8EICWorkSheetLine1 = ((int)(this.GetVariableValue((22 + locationsOffset))));
            this.Line8EICWorkSheetLine2 = ((double)(this.GetVariableValue((23 + locationsOffset))));
            this.Line8EICWorkSheetLine6 = ((double)(this.GetVariableValue((24 + locationsOffset))));
            this.Line8EICWorkSheetLine3 = ((double)(this.GetVariableValue((25 + locationsOffset))));
            this.Line8EICWorkSheetLine5 = ((double)(this.GetVariableValue((26 + locationsOffset))));
            this.EICStartingValue = ((int)(this.GetVariableValue((27 + locationsOffset))));
            this.EICModuleValue = ((int)(this.GetVariableValue((28 + locationsOffset))));
            this.EICInitialRangeStartValue = ((int)(this.GetVariableValue((29 + locationsOffset))));
            this.EICInitialRangeEndValue = ((int)(this.GetVariableValue((30 + locationsOffset))));
            this.EICRateInitialValue = ((int)(this.GetVariableValue((31 + locationsOffset))));
            this.EICModuleDifference = ((int)(this.GetVariableValue((32 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
            if (((validateLocationCount == true) 
                        && (locationReferences.Count < 33))) {
                return false;
            }
            if ((validateLocationCount == true)) {
                offset = (locationReferences.Count - 33);
            }
            expectedLocationsCount = 33;
            if (((locationReferences[(offset + 22)].Name != "Line8EICWorkSheetLine1") 
                        || (locationReferences[(offset + 22)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 23)].Name != "Line8EICWorkSheetLine2") 
                        || (locationReferences[(offset + 23)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 24)].Name != "Line8EICWorkSheetLine6") 
                        || (locationReferences[(offset + 24)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 25)].Name != "Line8EICWorkSheetLine3") 
                        || (locationReferences[(offset + 25)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 26)].Name != "Line8EICWorkSheetLine5") 
                        || (locationReferences[(offset + 26)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 27)].Name != "EICStartingValue") 
                        || (locationReferences[(offset + 27)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 28)].Name != "EICModuleValue") 
                        || (locationReferences[(offset + 28)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 29)].Name != "EICInitialRangeStartValue") 
                        || (locationReferences[(offset + 29)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 30)].Name != "EICInitialRangeEndValue") 
                        || (locationReferences[(offset + 30)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 31)].Name != "EICRateInitialValue") 
                        || (locationReferences[(offset + 31)].Type != typeof(int)))) {
                return false;
            }
            if (((locationReferences[(offset + 32)].Name != "EICModuleDifference") 
                        || (locationReferences[(offset + 32)].Type != typeof(int)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext13_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext16 : F1040EZLinesCalculation_TypedDataContext2 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected JTL.Tax1040.Core.Object.EmployerCode W2EmployerCode;
        
        public F1040EZLinesCalculation_TypedDataContext16(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext16(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext16(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected JTL.Tax1040.BusinessObject.W2 W2 {
            get {
                return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((8 + locationsOffset))));
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
        
        protected override void GetValueTypeValues() {
            this.W2EmployerCode = ((JTL.Tax1040.Core.Object.EmployerCode)(this.GetVariableValue((9 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        protected override void SetValueTypeValues() {
            this.SetVariableValue((9 + locationsOffset), this.W2EmployerCode);
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
            if (((locationReferences[(offset + 8)].Name != "W2") 
                        || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "W2EmployerCode") 
                        || (locationReferences[(offset + 9)].Type != typeof(JTL.Tax1040.Core.Object.EmployerCode)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext16_ForReadOnly : F1040EZLinesCalculation_TypedDataContext2_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected JTL.Tax1040.Core.Object.EmployerCode W2EmployerCode;
        
        public F1040EZLinesCalculation_TypedDataContext16_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext16_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext16_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected JTL.Tax1040.BusinessObject.W2 W2 {
            get {
                return ((JTL.Tax1040.BusinessObject.W2)(this.GetVariableValue((8 + locationsOffset))));
            }
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr152GetTree() {
            
            #line 1258 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
            (Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count > 0);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr152Get() {
            
            #line 1258 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            (Tax1040Object.Income.W2Wages != null) && (Tax1040Object.Income.W2Wages.Count > 0);
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr152Get() {
            this.GetValueTypeValues();
            return this.@__Expr152Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr153GetTree() {
            
            #line 1265 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.W2>>> expression = () => 
                Tax1040Object.Income.W2Wages;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.W2> @__Expr153Get() {
            
            #line 1265 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                Tax1040Object.Income.W2Wages;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.W2> ValueType___Expr153Get() {
            this.GetValueTypeValues();
            return this.@__Expr153Get();
        }
        
        protected override void GetValueTypeValues() {
            this.W2EmployerCode = ((JTL.Tax1040.Core.Object.EmployerCode)(this.GetVariableValue((9 + locationsOffset))));
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
            if (((locationReferences[(offset + 8)].Name != "W2") 
                        || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.W2)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "W2EmployerCode") 
                        || (locationReferences[(offset + 9)].Type != typeof(JTL.Tax1040.Core.Object.EmployerCode)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext17 : F1040EZLinesCalculation_TypedDataContext16 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext17(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext17(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext17(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected new JTL.Tax1040.BusinessObject.W2 W2 {
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
            return F1040EZLinesCalculation_TypedDataContext16.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext17_ForReadOnly : F1040EZLinesCalculation_TypedDataContext16_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext17_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext17_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext17_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected new JTL.Tax1040.BusinessObject.W2 W2 {
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
        
        internal System.Linq.Expressions.Expression @__Expr154GetTree() {
            
            #line 1275 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    W2.W2EmployerCodes != null && W2.W2EmployerCodes.Count>0;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr154Get() {
            
            #line 1275 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                    W2.W2EmployerCodes != null && W2.W2EmployerCodes.Count>0;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr154Get() {
            this.GetValueTypeValues();
            return this.@__Expr154Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr155GetTree() {
            
            #line 1282 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.W2EmployerCode>>> expression = () => 
                        W2.W2EmployerCodes;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.W2EmployerCode> @__Expr155Get() {
            
            #line 1282 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                        W2.W2EmployerCodes;
            
            #line default
            #line hidden
        }
        
        public System.Collections.Generic.IEnumerable<JTL.Tax1040.BusinessObject.W2EmployerCode> ValueType___Expr155Get() {
            this.GetValueTypeValues();
            return this.@__Expr155Get();
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
            return F1040EZLinesCalculation_TypedDataContext16_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext18 : F1040EZLinesCalculation_TypedDataContext17 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext18(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext18(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext18(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected new JTL.Tax1040.BusinessObject.W2EmployerCode W2EmployerCode {
            get {
                return ((JTL.Tax1040.BusinessObject.W2EmployerCode)(this.GetVariableValue((11 + locationsOffset))));
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
        
        internal System.Linq.Expressions.Expression @__Expr158GetTree() {
            
            #line 1299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr158Get() {
            
            #line 1299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr158Get() {
            this.GetValueTypeValues();
            return this.@__Expr158Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr158Set(double value) {
            
            #line 1299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr158Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr158Set(value);
            this.SetValueTypeValues();
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
            if (((locationReferences[(offset + 11)].Name != "W2EmployerCode") 
                        || (locationReferences[(offset + 11)].Type != typeof(JTL.Tax1040.BusinessObject.W2EmployerCode)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext17.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext18_ForReadOnly : F1040EZLinesCalculation_TypedDataContext17_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        public F1040EZLinesCalculation_TypedDataContext18_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext18_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext18_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        protected new JTL.Tax1040.BusinessObject.W2EmployerCode W2EmployerCode {
            get {
                return ((JTL.Tax1040.BusinessObject.W2EmployerCode)(this.GetVariableValue((11 + locationsOffset))));
            }
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr156GetTree() {
            
            #line 1292 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            W2EmployerCode.EmployerCode.HasValue && W2EmployerCode.EmployerCode.Value == EmployerCode.QNonTaxableCombatPay;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr156Get() {
            
            #line 1292 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            W2EmployerCode.EmployerCode.HasValue && W2EmployerCode.EmployerCode.Value == EmployerCode.QNonTaxableCombatPay;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr156Get() {
            this.GetValueTypeValues();
            return this.@__Expr156Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr157GetTree() {
            
            #line 1304 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                W2EmployerCode.Amount.HasValue ? W2EmployerCode.Amount.Value : 0 + Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr157Get() {
            
            #line 1304 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                W2EmployerCode.Amount.HasValue ? W2EmployerCode.Amount.Value : 0 + Tax1040Object.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr157Get() {
            this.GetValueTypeValues();
            return this.@__Expr157Get();
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
            if (((locationReferences[(offset + 11)].Name != "W2EmployerCode") 
                        || (locationReferences[(offset + 11)].Type != typeof(JTL.Tax1040.BusinessObject.W2EmployerCode)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext17_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext19 : F1040EZLinesCalculation_TypedDataContext2 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected double ProcessingIncome;
        
        protected double Tax;
        
        protected double Range2TaxRate;
        
        protected double Range3TaxRate;
        
        protected double Range4TaxRate;
        
        protected double Range5TaxRate;
        
        protected double Range6TaxRate;
        
        protected bool IsCaseContinue;
        
        protected double Range7TaxRate;
        
        public F1040EZLinesCalculation_TypedDataContext19(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext19(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext19(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr234GetTree() {
            
            #line 1906 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
            Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr234Get() {
            
            #line 1906 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr234Get() {
            this.GetValueTypeValues();
            return this.@__Expr234Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr234Set(double value) {
            
            #line 1906 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
            Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr234Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr234Set(value);
            this.SetValueTypeValues();
        }
        
        protected override void GetValueTypeValues() {
            this.ProcessingIncome = ((double)(this.GetVariableValue((8 + locationsOffset))));
            this.Tax = ((double)(this.GetVariableValue((9 + locationsOffset))));
            this.Range2TaxRate = ((double)(this.GetVariableValue((10 + locationsOffset))));
            this.Range3TaxRate = ((double)(this.GetVariableValue((11 + locationsOffset))));
            this.Range4TaxRate = ((double)(this.GetVariableValue((12 + locationsOffset))));
            this.Range5TaxRate = ((double)(this.GetVariableValue((13 + locationsOffset))));
            this.Range6TaxRate = ((double)(this.GetVariableValue((14 + locationsOffset))));
            this.IsCaseContinue = ((bool)(this.GetVariableValue((15 + locationsOffset))));
            this.Range7TaxRate = ((double)(this.GetVariableValue((16 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        protected override void SetValueTypeValues() {
            this.SetVariableValue((8 + locationsOffset), this.ProcessingIncome);
            this.SetVariableValue((9 + locationsOffset), this.Tax);
            this.SetVariableValue((10 + locationsOffset), this.Range2TaxRate);
            this.SetVariableValue((11 + locationsOffset), this.Range3TaxRate);
            this.SetVariableValue((12 + locationsOffset), this.Range4TaxRate);
            this.SetVariableValue((13 + locationsOffset), this.Range5TaxRate);
            this.SetVariableValue((14 + locationsOffset), this.Range6TaxRate);
            this.SetVariableValue((15 + locationsOffset), this.IsCaseContinue);
            this.SetVariableValue((16 + locationsOffset), this.Range7TaxRate);
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
            if (((locationReferences[(offset + 8)].Name != "ProcessingIncome") 
                        || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "Tax") 
                        || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 10)].Name != "Range2TaxRate") 
                        || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 11)].Name != "Range3TaxRate") 
                        || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 12)].Name != "Range4TaxRate") 
                        || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 13)].Name != "Range5TaxRate") 
                        || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 14)].Name != "Range6TaxRate") 
                        || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 15)].Name != "IsCaseContinue") 
                        || (locationReferences[(offset + 15)].Type != typeof(bool)))) {
                return false;
            }
            if (((locationReferences[(offset + 16)].Name != "Range7TaxRate") 
                        || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext19_ForReadOnly : F1040EZLinesCalculation_TypedDataContext2_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected double ProcessingIncome;
        
        protected double Tax;
        
        protected double Range2TaxRate;
        
        protected double Range3TaxRate;
        
        protected double Range4TaxRate;
        
        protected double Range5TaxRate;
        
        protected double Range6TaxRate;
        
        protected bool IsCaseContinue;
        
        protected double Range7TaxRate;
        
        public F1040EZLinesCalculation_TypedDataContext19_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext19_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext19_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr161GetTree() {
            
            #line 1337 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr161Get() {
            
            #line 1337 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr161Get() {
            this.GetValueTypeValues();
            return this.@__Expr161Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr162GetTree() {
            
            #line 1352 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public JTL.Tax1040.Core.Object.FilingStatus @__Expr162Get() {
            
            #line 1352 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
            
            #line default
            #line hidden
        }
        
        public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr162Get() {
            this.GetValueTypeValues();
            return this.@__Expr162Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr233GetTree() {
            
            #line 1911 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
            Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr233Get() {
            
            #line 1911 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
            Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr233Get() {
            this.GetValueTypeValues();
            return this.@__Expr233Get();
        }
        
        protected override void GetValueTypeValues() {
            this.ProcessingIncome = ((double)(this.GetVariableValue((8 + locationsOffset))));
            this.Tax = ((double)(this.GetVariableValue((9 + locationsOffset))));
            this.Range2TaxRate = ((double)(this.GetVariableValue((10 + locationsOffset))));
            this.Range3TaxRate = ((double)(this.GetVariableValue((11 + locationsOffset))));
            this.Range4TaxRate = ((double)(this.GetVariableValue((12 + locationsOffset))));
            this.Range5TaxRate = ((double)(this.GetVariableValue((13 + locationsOffset))));
            this.Range6TaxRate = ((double)(this.GetVariableValue((14 + locationsOffset))));
            this.IsCaseContinue = ((bool)(this.GetVariableValue((15 + locationsOffset))));
            this.Range7TaxRate = ((double)(this.GetVariableValue((16 + locationsOffset))));
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
            if (((locationReferences[(offset + 8)].Name != "ProcessingIncome") 
                        || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 9)].Name != "Tax") 
                        || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 10)].Name != "Range2TaxRate") 
                        || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 11)].Name != "Range3TaxRate") 
                        || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 12)].Name != "Range4TaxRate") 
                        || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 13)].Name != "Range5TaxRate") 
                        || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 14)].Name != "Range6TaxRate") 
                        || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 15)].Name != "IsCaseContinue") 
                        || (locationReferences[(offset + 15)].Type != typeof(bool)))) {
                return false;
            }
            if (((locationReferences[(offset + 16)].Name != "Range7TaxRate") 
                        || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext20 : F1040EZLinesCalculation_TypedDataContext19 {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected double SingleRange1Start;
        
        protected double SingleRange7Start;
        
        protected double SingleRange6End;
        
        protected double SingleRange6Start;
        
        protected double SingleRange5End;
        
        protected double SingleRange5Start;
        
        protected double SingleRange4Start;
        
        protected double SingleRange4End;
        
        protected double SingleRange1End;
        
        protected double SingleRange2Start;
        
        protected double SingleRange3Start;
        
        protected double SingleRange3End;
        
        protected double SingleRange2End;
        
        public F1040EZLinesCalculation_TypedDataContext20(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext20(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext20(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr166GetTree() {
            
            #line 1390 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            ProcessingIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr166Get() {
            
            #line 1390 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            ProcessingIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr166Get() {
            this.GetValueTypeValues();
            return this.@__Expr166Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr166Set(double value) {
            
            #line 1390 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            ProcessingIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr166Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr166Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr168GetTree() {
            
            #line 1402 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr168Get() {
            
            #line 1402 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr168Get() {
            this.GetValueTypeValues();
            return this.@__Expr168Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr168Set(double value) {
            
            #line 1402 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr168Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr168Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr171GetTree() {
            
            #line 1425 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr171Get() {
            
            #line 1425 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr171Get() {
            this.GetValueTypeValues();
            return this.@__Expr171Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr171Set(double value) {
            
            #line 1425 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr171Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr171Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr172GetTree() {
            
            #line 1437 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                IsCaseContinue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr172Get() {
            
            #line 1437 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                IsCaseContinue;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr172Get() {
            this.GetValueTypeValues();
            return this.@__Expr172Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr172Set(bool value) {
            
            #line 1437 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                IsCaseContinue = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr172Set(bool value) {
            this.GetValueTypeValues();
            this.@__Expr172Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr175GetTree() {
            
            #line 1460 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            ProcessingIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr175Get() {
            
            #line 1460 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            ProcessingIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr175Get() {
            this.GetValueTypeValues();
            return this.@__Expr175Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr175Set(double value) {
            
            #line 1460 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            ProcessingIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr175Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr175Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr177GetTree() {
            
            #line 1472 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr177Get() {
            
            #line 1472 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr177Get() {
            this.GetValueTypeValues();
            return this.@__Expr177Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr177Set(double value) {
            
            #line 1472 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr177Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr177Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr180GetTree() {
            
            #line 1495 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                ProcessingIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr180Get() {
            
            #line 1495 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                ProcessingIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr180Get() {
            this.GetValueTypeValues();
            return this.@__Expr180Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr180Set(double value) {
            
            #line 1495 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                ProcessingIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr180Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr180Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr182GetTree() {
            
            #line 1507 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr182Get() {
            
            #line 1507 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr182Get() {
            this.GetValueTypeValues();
            return this.@__Expr182Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr182Set(double value) {
            
            #line 1507 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr182Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr182Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr183GetTree() {
            
            #line 1519 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                IsCaseContinue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr183Get() {
            
            #line 1519 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                IsCaseContinue;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr183Get() {
            this.GetValueTypeValues();
            return this.@__Expr183Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr183Set(bool value) {
            
            #line 1519 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                IsCaseContinue = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr183Set(bool value) {
            this.GetValueTypeValues();
            this.@__Expr183Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr186GetTree() {
            
            #line 1542 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            ProcessingIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr186Get() {
            
            #line 1542 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            ProcessingIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr186Get() {
            this.GetValueTypeValues();
            return this.@__Expr186Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr186Set(double value) {
            
            #line 1542 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            ProcessingIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr186Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr186Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr188GetTree() {
            
            #line 1554 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr188Get() {
            
            #line 1554 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr188Get() {
            this.GetValueTypeValues();
            return this.@__Expr188Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr188Set(double value) {
            
            #line 1554 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr188Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr188Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr191GetTree() {
            
            #line 1577 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                ProcessingIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr191Get() {
            
            #line 1577 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                ProcessingIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr191Get() {
            this.GetValueTypeValues();
            return this.@__Expr191Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr191Set(double value) {
            
            #line 1577 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                ProcessingIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr191Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr191Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr193GetTree() {
            
            #line 1589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr193Get() {
            
            #line 1589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr193Get() {
            this.GetValueTypeValues();
            return this.@__Expr193Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr193Set(double value) {
            
            #line 1589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr193Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr193Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr194GetTree() {
            
            #line 1601 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                IsCaseContinue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr194Get() {
            
            #line 1601 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                IsCaseContinue;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr194Get() {
            this.GetValueTypeValues();
            return this.@__Expr194Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr194Set(bool value) {
            
            #line 1601 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                IsCaseContinue = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr194Set(bool value) {
            this.GetValueTypeValues();
            this.@__Expr194Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr197GetTree() {
            
            #line 1624 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            ProcessingIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr197Get() {
            
            #line 1624 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            ProcessingIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr197Get() {
            this.GetValueTypeValues();
            return this.@__Expr197Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr197Set(double value) {
            
            #line 1624 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            ProcessingIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr197Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr197Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr199GetTree() {
            
            #line 1636 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr199Get() {
            
            #line 1636 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr199Get() {
            this.GetValueTypeValues();
            return this.@__Expr199Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr199Set(double value) {
            
            #line 1636 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr199Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr199Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr202GetTree() {
            
            #line 1659 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                ProcessingIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr202Get() {
            
            #line 1659 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                ProcessingIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr202Get() {
            this.GetValueTypeValues();
            return this.@__Expr202Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr202Set(double value) {
            
            #line 1659 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                ProcessingIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr202Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr202Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr204GetTree() {
            
            #line 1671 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr204Get() {
            
            #line 1671 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr204Get() {
            this.GetValueTypeValues();
            return this.@__Expr204Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr204Set(double value) {
            
            #line 1671 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr204Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr204Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr205GetTree() {
            
            #line 1683 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                IsCaseContinue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr205Get() {
            
            #line 1683 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                IsCaseContinue;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr205Get() {
            this.GetValueTypeValues();
            return this.@__Expr205Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr205Set(bool value) {
            
            #line 1683 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                IsCaseContinue = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr205Set(bool value) {
            this.GetValueTypeValues();
            this.@__Expr205Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr208GetTree() {
            
            #line 1706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            ProcessingIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr208Get() {
            
            #line 1706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            ProcessingIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr208Get() {
            this.GetValueTypeValues();
            return this.@__Expr208Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr208Set(double value) {
            
            #line 1706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            ProcessingIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr208Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr208Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr210GetTree() {
            
            #line 1718 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr210Get() {
            
            #line 1718 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr210Get() {
            this.GetValueTypeValues();
            return this.@__Expr210Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr210Set(double value) {
            
            #line 1718 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr210Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr210Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr213GetTree() {
            
            #line 1741 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                ProcessingIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr213Get() {
            
            #line 1741 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                ProcessingIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr213Get() {
            this.GetValueTypeValues();
            return this.@__Expr213Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr213Set(double value) {
            
            #line 1741 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                ProcessingIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr213Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr213Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr215GetTree() {
            
            #line 1753 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr215Get() {
            
            #line 1753 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr215Get() {
            this.GetValueTypeValues();
            return this.@__Expr215Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr215Set(double value) {
            
            #line 1753 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr215Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr215Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr216GetTree() {
            
            #line 1765 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                IsCaseContinue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr216Get() {
            
            #line 1765 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                IsCaseContinue;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr216Get() {
            this.GetValueTypeValues();
            return this.@__Expr216Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr216Set(bool value) {
            
            #line 1765 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                IsCaseContinue = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr216Set(bool value) {
            this.GetValueTypeValues();
            this.@__Expr216Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr219GetTree() {
            
            #line 1788 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            ProcessingIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr219Get() {
            
            #line 1788 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            ProcessingIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr219Get() {
            this.GetValueTypeValues();
            return this.@__Expr219Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr219Set(double value) {
            
            #line 1788 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            ProcessingIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr219Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr219Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr221GetTree() {
            
            #line 1800 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr221Get() {
            
            #line 1800 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr221Get() {
            this.GetValueTypeValues();
            return this.@__Expr221Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr221Set(double value) {
            
            #line 1800 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr221Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr221Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr224GetTree() {
            
            #line 1823 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                ProcessingIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr224Get() {
            
            #line 1823 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                ProcessingIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr224Get() {
            this.GetValueTypeValues();
            return this.@__Expr224Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr224Set(double value) {
            
            #line 1823 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                ProcessingIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr224Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr224Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr226GetTree() {
            
            #line 1835 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr226Get() {
            
            #line 1835 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr226Get() {
            this.GetValueTypeValues();
            return this.@__Expr226Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr226Set(double value) {
            
            #line 1835 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr226Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr226Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr227GetTree() {
            
            #line 1847 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                IsCaseContinue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr227Get() {
            
            #line 1847 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                IsCaseContinue;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr227Get() {
            this.GetValueTypeValues();
            return this.@__Expr227Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr227Set(bool value) {
            
            #line 1847 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                                IsCaseContinue = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr227Set(bool value) {
            this.GetValueTypeValues();
            this.@__Expr227Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr230GetTree() {
            
            #line 1870 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            ProcessingIncome;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr230Get() {
            
            #line 1870 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            ProcessingIncome;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr230Get() {
            this.GetValueTypeValues();
            return this.@__Expr230Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr230Set(double value) {
            
            #line 1870 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            ProcessingIncome = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr230Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr230Set(value);
            this.SetValueTypeValues();
        }
        
        internal System.Linq.Expressions.Expression @__Expr232GetTree() {
            
            #line 1882 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr232Get() {
            
            #line 1882 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr232Get() {
            this.GetValueTypeValues();
            return this.@__Expr232Get();
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public void @__Expr232Set(double value) {
            
            #line 1882 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            
                            Tax = value;
            
            #line default
            #line hidden
        }
        
        public void ValueType___Expr232Set(double value) {
            this.GetValueTypeValues();
            this.@__Expr232Set(value);
            this.SetValueTypeValues();
        }
        
        protected override void GetValueTypeValues() {
            this.SingleRange1Start = ((double)(this.GetVariableValue((17 + locationsOffset))));
            this.SingleRange7Start = ((double)(this.GetVariableValue((18 + locationsOffset))));
            this.SingleRange6End = ((double)(this.GetVariableValue((19 + locationsOffset))));
            this.SingleRange6Start = ((double)(this.GetVariableValue((20 + locationsOffset))));
            this.SingleRange5End = ((double)(this.GetVariableValue((21 + locationsOffset))));
            this.SingleRange5Start = ((double)(this.GetVariableValue((22 + locationsOffset))));
            this.SingleRange4Start = ((double)(this.GetVariableValue((23 + locationsOffset))));
            this.SingleRange4End = ((double)(this.GetVariableValue((24 + locationsOffset))));
            this.SingleRange1End = ((double)(this.GetVariableValue((25 + locationsOffset))));
            this.SingleRange2Start = ((double)(this.GetVariableValue((26 + locationsOffset))));
            this.SingleRange3Start = ((double)(this.GetVariableValue((27 + locationsOffset))));
            this.SingleRange3End = ((double)(this.GetVariableValue((28 + locationsOffset))));
            this.SingleRange2End = ((double)(this.GetVariableValue((29 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        protected override void SetValueTypeValues() {
            this.SetVariableValue((17 + locationsOffset), this.SingleRange1Start);
            this.SetVariableValue((18 + locationsOffset), this.SingleRange7Start);
            this.SetVariableValue((19 + locationsOffset), this.SingleRange6End);
            this.SetVariableValue((20 + locationsOffset), this.SingleRange6Start);
            this.SetVariableValue((21 + locationsOffset), this.SingleRange5End);
            this.SetVariableValue((22 + locationsOffset), this.SingleRange5Start);
            this.SetVariableValue((23 + locationsOffset), this.SingleRange4Start);
            this.SetVariableValue((24 + locationsOffset), this.SingleRange4End);
            this.SetVariableValue((25 + locationsOffset), this.SingleRange1End);
            this.SetVariableValue((26 + locationsOffset), this.SingleRange2Start);
            this.SetVariableValue((27 + locationsOffset), this.SingleRange3Start);
            this.SetVariableValue((28 + locationsOffset), this.SingleRange3End);
            this.SetVariableValue((29 + locationsOffset), this.SingleRange2End);
            base.SetValueTypeValues();
        }
        
        public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
            if (((validateLocationCount == true) 
                        && (locationReferences.Count < 30))) {
                return false;
            }
            if ((validateLocationCount == true)) {
                offset = (locationReferences.Count - 30);
            }
            expectedLocationsCount = 30;
            if (((locationReferences[(offset + 17)].Name != "SingleRange1Start") 
                        || (locationReferences[(offset + 17)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 18)].Name != "SingleRange7Start") 
                        || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 19)].Name != "SingleRange6End") 
                        || (locationReferences[(offset + 19)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 20)].Name != "SingleRange6Start") 
                        || (locationReferences[(offset + 20)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 21)].Name != "SingleRange5End") 
                        || (locationReferences[(offset + 21)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 22)].Name != "SingleRange5Start") 
                        || (locationReferences[(offset + 22)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 23)].Name != "SingleRange4Start") 
                        || (locationReferences[(offset + 23)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 24)].Name != "SingleRange4End") 
                        || (locationReferences[(offset + 24)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 25)].Name != "SingleRange1End") 
                        || (locationReferences[(offset + 25)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 26)].Name != "SingleRange2Start") 
                        || (locationReferences[(offset + 26)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 27)].Name != "SingleRange3Start") 
                        || (locationReferences[(offset + 27)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 28)].Name != "SingleRange3End") 
                        || (locationReferences[(offset + 28)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 29)].Name != "SingleRange2End") 
                        || (locationReferences[(offset + 29)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext19.Validate(locationReferences, false, offset);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    private class F1040EZLinesCalculation_TypedDataContext20_ForReadOnly : F1040EZLinesCalculation_TypedDataContext19_ForReadOnly {
        
        private int locationsOffset;
        
        private static int expectedLocationsCount;
        
        protected double SingleRange1Start;
        
        protected double SingleRange7Start;
        
        protected double SingleRange6End;
        
        protected double SingleRange6Start;
        
        protected double SingleRange5End;
        
        protected double SingleRange5Start;
        
        protected double SingleRange4Start;
        
        protected double SingleRange4End;
        
        protected double SingleRange1End;
        
        protected double SingleRange2Start;
        
        protected double SingleRange3Start;
        
        protected double SingleRange3End;
        
        protected double SingleRange2End;
        
        public F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                base(locations, activityContext, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                base(locations, false) {
            if ((computelocationsOffset == true)) {
                this.SetLocationsOffset((locations.Count - expectedLocationsCount));
            }
        }
        
        public F1040EZLinesCalculation_TypedDataContext20_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                base(locationReferences) {
        }
        
        internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
            return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
        }
        
        public new virtual void SetLocationsOffset(int locationsOffsetValue) {
            locationsOffset = locationsOffsetValue;
            base.SetLocationsOffset(locationsOffset);
        }
        
        internal System.Linq.Expressions.Expression @__Expr163GetTree() {
            
            #line 1374 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome>0.0;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr163Get() {
            
            #line 1374 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome>0.0;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr163Get() {
            this.GetValueTypeValues();
            return this.@__Expr163Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr164GetTree() {
            
            #line 1382 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange1End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr164Get() {
            
            #line 1382 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange1End;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr164Get() {
            this.GetValueTypeValues();
            return this.@__Expr164Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr165GetTree() {
            
            #line 1395 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            SingleRange1End - SingleRange1Start;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr165Get() {
            
            #line 1395 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            SingleRange1End - SingleRange1Start;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr165Get() {
            this.GetValueTypeValues();
            return this.@__Expr165Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr167GetTree() {
            
            #line 1407 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax + (ProcessingIncome * Range1TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr167Get() {
            
            #line 1407 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax + (ProcessingIncome * Range1TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr167Get() {
            this.GetValueTypeValues();
            return this.@__Expr167Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr169GetTree() {
            
            #line 1417 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange1End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr169Get() {
            
            #line 1417 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange1End;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr169Get() {
            this.GetValueTypeValues();
            return this.@__Expr169Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr170GetTree() {
            
            #line 1430 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax + (ProcessingIncome * Range1TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr170Get() {
            
            #line 1430 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax + (ProcessingIncome * Range1TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr170Get() {
            this.GetValueTypeValues();
            return this.@__Expr170Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr173GetTree() {
            
            #line 1452 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange2End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr173Get() {
            
            #line 1452 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange2End;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr173Get() {
            this.GetValueTypeValues();
            return this.@__Expr173Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr174GetTree() {
            
            #line 1465 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            SingleRange2End - SingleRange1End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr174Get() {
            
            #line 1465 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            SingleRange2End - SingleRange1End;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr174Get() {
            this.GetValueTypeValues();
            return this.@__Expr174Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr176GetTree() {
            
            #line 1477 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax + (ProcessingIncome * Range2TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr176Get() {
            
            #line 1477 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax + (ProcessingIncome * Range2TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr176Get() {
            this.GetValueTypeValues();
            return this.@__Expr176Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr178GetTree() {
            
            #line 1487 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange2End && IsCaseContinue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr178Get() {
            
            #line 1487 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange2End && IsCaseContinue;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr178Get() {
            this.GetValueTypeValues();
            return this.@__Expr178Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr179GetTree() {
            
            #line 1500 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange1End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr179Get() {
            
            #line 1500 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange1End;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr179Get() {
            this.GetValueTypeValues();
            return this.@__Expr179Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr181GetTree() {
            
            #line 1512 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax + (ProcessingIncome * Range2TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr181Get() {
            
            #line 1512 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax + (ProcessingIncome * Range2TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr181Get() {
            this.GetValueTypeValues();
            return this.@__Expr181Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr184GetTree() {
            
            #line 1534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange3End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr184Get() {
            
            #line 1534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange3End;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr184Get() {
            this.GetValueTypeValues();
            return this.@__Expr184Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr185GetTree() {
            
            #line 1547 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            SingleRange3End - SingleRange2End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr185Get() {
            
            #line 1547 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            SingleRange3End - SingleRange2End;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr185Get() {
            this.GetValueTypeValues();
            return this.@__Expr185Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr187GetTree() {
            
            #line 1559 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax + (ProcessingIncome * Range3TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr187Get() {
            
            #line 1559 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax + (ProcessingIncome * Range3TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr187Get() {
            this.GetValueTypeValues();
            return this.@__Expr187Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr189GetTree() {
            
            #line 1569 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange3End && IsCaseContinue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr189Get() {
            
            #line 1569 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange3End && IsCaseContinue;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr189Get() {
            this.GetValueTypeValues();
            return this.@__Expr189Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr190GetTree() {
            
            #line 1582 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange2End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr190Get() {
            
            #line 1582 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange2End;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr190Get() {
            this.GetValueTypeValues();
            return this.@__Expr190Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr192GetTree() {
            
            #line 1594 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax + (ProcessingIncome * Range3TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr192Get() {
            
            #line 1594 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax + (ProcessingIncome * Range3TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr192Get() {
            this.GetValueTypeValues();
            return this.@__Expr192Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr195GetTree() {
            
            #line 1616 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange4End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr195Get() {
            
            #line 1616 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange4End;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr195Get() {
            this.GetValueTypeValues();
            return this.@__Expr195Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr196GetTree() {
            
            #line 1629 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            SingleRange4End - SingleRange3End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr196Get() {
            
            #line 1629 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            SingleRange4End - SingleRange3End;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr196Get() {
            this.GetValueTypeValues();
            return this.@__Expr196Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr198GetTree() {
            
            #line 1641 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax + (ProcessingIncome * Range4TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr198Get() {
            
            #line 1641 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax + (ProcessingIncome * Range4TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr198Get() {
            this.GetValueTypeValues();
            return this.@__Expr198Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr200GetTree() {
            
            #line 1651 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange4End && IsCaseContinue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr200Get() {
            
            #line 1651 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange4End && IsCaseContinue;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr200Get() {
            this.GetValueTypeValues();
            return this.@__Expr200Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr201GetTree() {
            
            #line 1664 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange3End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr201Get() {
            
            #line 1664 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange3End;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr201Get() {
            this.GetValueTypeValues();
            return this.@__Expr201Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr203GetTree() {
            
            #line 1676 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax + (ProcessingIncome * Range4TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr203Get() {
            
            #line 1676 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax + (ProcessingIncome * Range4TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr203Get() {
            this.GetValueTypeValues();
            return this.@__Expr203Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr206GetTree() {
            
            #line 1698 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange5End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr206Get() {
            
            #line 1698 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange5End;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr206Get() {
            this.GetValueTypeValues();
            return this.@__Expr206Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr207GetTree() {
            
            #line 1711 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            SingleRange5End - SingleRange4End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr207Get() {
            
            #line 1711 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            SingleRange5End - SingleRange4End;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr207Get() {
            this.GetValueTypeValues();
            return this.@__Expr207Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr209GetTree() {
            
            #line 1723 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax + (ProcessingIncome * Range5TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr209Get() {
            
            #line 1723 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax + (ProcessingIncome * Range5TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr209Get() {
            this.GetValueTypeValues();
            return this.@__Expr209Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr211GetTree() {
            
            #line 1733 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange5End && IsCaseContinue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr211Get() {
            
            #line 1733 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange5End && IsCaseContinue;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr211Get() {
            this.GetValueTypeValues();
            return this.@__Expr211Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr212GetTree() {
            
            #line 1746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange4End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr212Get() {
            
            #line 1746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange4End;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr212Get() {
            this.GetValueTypeValues();
            return this.@__Expr212Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr214GetTree() {
            
            #line 1758 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax + (ProcessingIncome * Range5TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr214Get() {
            
            #line 1758 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax + (ProcessingIncome * Range5TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr214Get() {
            this.GetValueTypeValues();
            return this.@__Expr214Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr217GetTree() {
            
            #line 1780 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange6End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr217Get() {
            
            #line 1780 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange6End;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr217Get() {
            this.GetValueTypeValues();
            return this.@__Expr217Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr218GetTree() {
            
            #line 1793 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            SingleRange6End - SingleRange5End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr218Get() {
            
            #line 1793 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            SingleRange6End - SingleRange5End;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr218Get() {
            this.GetValueTypeValues();
            return this.@__Expr218Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr220GetTree() {
            
            #line 1805 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax + (ProcessingIncome * Range6TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr220Get() {
            
            #line 1805 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax + (ProcessingIncome * Range6TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr220Get() {
            this.GetValueTypeValues();
            return this.@__Expr220Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr222GetTree() {
            
            #line 1815 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange6End && IsCaseContinue;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr222Get() {
            
            #line 1815 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange6End && IsCaseContinue;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr222Get() {
            this.GetValueTypeValues();
            return this.@__Expr222Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr223GetTree() {
            
            #line 1828 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange5End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr223Get() {
            
            #line 1828 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange5End;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr223Get() {
            this.GetValueTypeValues();
            return this.@__Expr223Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr225GetTree() {
            
            #line 1840 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                Tax + (ProcessingIncome * Range6TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr225Get() {
            
            #line 1840 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                                Tax + (ProcessingIncome * Range6TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr225Get() {
            this.GetValueTypeValues();
            return this.@__Expr225Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr228GetTree() {
            
            #line 1862 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome >= SingleRange7Start;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public bool @__Expr228Get() {
            
            #line 1862 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                      Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome >= SingleRange7Start;
            
            #line default
            #line hidden
        }
        
        public bool ValueType___Expr228Get() {
            this.GetValueTypeValues();
            return this.@__Expr228Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr229GetTree() {
            
            #line 1875 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange6End;
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr229Get() {
            
            #line 1875 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange6End;
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr229Get() {
            this.GetValueTypeValues();
            return this.@__Expr229Get();
        }
        
        internal System.Linq.Expressions.Expression @__Expr231GetTree() {
            
            #line 1887 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax + (ProcessingIncome * Range7TaxRate);
            
            #line default
            #line hidden
            return base.RewriteExpressionTree(expression);
        }
        
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public double @__Expr231Get() {
            
            #line 1887 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\SAMPLEACTIVITIES\F1040EZLINESCALCULATION.XAML"
            return 
                            Tax + (ProcessingIncome * Range7TaxRate);
            
            #line default
            #line hidden
        }
        
        public double ValueType___Expr231Get() {
            this.GetValueTypeValues();
            return this.@__Expr231Get();
        }
        
        protected override void GetValueTypeValues() {
            this.SingleRange1Start = ((double)(this.GetVariableValue((17 + locationsOffset))));
            this.SingleRange7Start = ((double)(this.GetVariableValue((18 + locationsOffset))));
            this.SingleRange6End = ((double)(this.GetVariableValue((19 + locationsOffset))));
            this.SingleRange6Start = ((double)(this.GetVariableValue((20 + locationsOffset))));
            this.SingleRange5End = ((double)(this.GetVariableValue((21 + locationsOffset))));
            this.SingleRange5Start = ((double)(this.GetVariableValue((22 + locationsOffset))));
            this.SingleRange4Start = ((double)(this.GetVariableValue((23 + locationsOffset))));
            this.SingleRange4End = ((double)(this.GetVariableValue((24 + locationsOffset))));
            this.SingleRange1End = ((double)(this.GetVariableValue((25 + locationsOffset))));
            this.SingleRange2Start = ((double)(this.GetVariableValue((26 + locationsOffset))));
            this.SingleRange3Start = ((double)(this.GetVariableValue((27 + locationsOffset))));
            this.SingleRange3End = ((double)(this.GetVariableValue((28 + locationsOffset))));
            this.SingleRange2End = ((double)(this.GetVariableValue((29 + locationsOffset))));
            base.GetValueTypeValues();
        }
        
        public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
            if (((validateLocationCount == true) 
                        && (locationReferences.Count < 30))) {
                return false;
            }
            if ((validateLocationCount == true)) {
                offset = (locationReferences.Count - 30);
            }
            expectedLocationsCount = 30;
            if (((locationReferences[(offset + 17)].Name != "SingleRange1Start") 
                        || (locationReferences[(offset + 17)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 18)].Name != "SingleRange7Start") 
                        || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 19)].Name != "SingleRange6End") 
                        || (locationReferences[(offset + 19)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 20)].Name != "SingleRange6Start") 
                        || (locationReferences[(offset + 20)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 21)].Name != "SingleRange5End") 
                        || (locationReferences[(offset + 21)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 22)].Name != "SingleRange5Start") 
                        || (locationReferences[(offset + 22)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 23)].Name != "SingleRange4Start") 
                        || (locationReferences[(offset + 23)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 24)].Name != "SingleRange4End") 
                        || (locationReferences[(offset + 24)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 25)].Name != "SingleRange1End") 
                        || (locationReferences[(offset + 25)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 26)].Name != "SingleRange2Start") 
                        || (locationReferences[(offset + 26)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 27)].Name != "SingleRange3Start") 
                        || (locationReferences[(offset + 27)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 28)].Name != "SingleRange3End") 
                        || (locationReferences[(offset + 28)].Type != typeof(double)))) {
                return false;
            }
            if (((locationReferences[(offset + 29)].Name != "SingleRange2End") 
                        || (locationReferences[(offset + 29)].Type != typeof(double)))) {
                return false;
            }
            return F1040EZLinesCalculation_TypedDataContext19_ForReadOnly.Validate(locationReferences, false, offset);
        }
    }
}
